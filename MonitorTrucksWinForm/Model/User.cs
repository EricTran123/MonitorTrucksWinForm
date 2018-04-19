using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using MongoDB.Driver;
using MongoDB.Bson;

namespace WindowsFormsAppTest.Model
{
    class User
    {
        public ObjectId _id { get; set; }
        public String userName { get; set; }
        public String passWord { get; set; }
        public DateTime createDate { get; set; }
        public bool active { get; set; }
        
        /*
         Crypyt the password field.
        */
        public String getMD5(String password)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(password));
            byte[] result = md5.Hash;
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                stringBuilder.Append(result[i].ToString("x2"));
            }
            return stringBuilder.ToString();
        }
        /*
         Find user by username field.
        */
        public User findUserByName(String userName, IMongoDatabase mongoDatabase)
        {
            var collection = mongoDatabase.GetCollection<User>("users");
            return collection.Find(x => x.userName == userName).FirstOrDefault();
        }
        /*
         Get list of users.
        */
        public List<User> getListAllUsers(IMongoDatabase mongoDatabase)
        {
            var collection = mongoDatabase.GetCollection<User>("users");
            return collection.Find(x => !String.IsNullOrEmpty(x.userName)).SortBy(x => x.createDate).ToList();
        }
        /*
         Delete user
        */
        public void deleteByUsername(IMongoDatabase mongoDatabase, String username)
        {
            var collection = mongoDatabase.GetCollection<User>("users");
            try
            {
                Console.WriteLine(userName);
                collection.FindOneAndDelete(x => x.userName.Equals(username));
            }
            catch (Exception e)
            {
                throw e;
            }
            
        }
        /*
         Add new user
        */
        public void addUser(IMongoDatabase mongoDatabase, User newUser)
        {
            try
            {
                var collection = mongoDatabase.GetCollection<User>("users");
                collection.InsertOneAsync(newUser);
            } catch (Exception e)
            {
                throw e;
            }
           
        }
        /*
         Change password, active field
        */
        public void updateUser (IMongoDatabase mongoDatabase, User currentUser, User updateUser)
        {
            try
            {
                var collection = mongoDatabase.GetCollection<User>("users");
                if (!currentUser.passWord.Equals(updateUser.passWord))
                {
                    collection.FindOneAndUpdate(x => x.userName.Equals(currentUser.userName), Builders<User>.Update.Set("passWord", currentUser.getMD5(updateUser.passWord)));
                }
                if (currentUser.active != updateUser.active)
                {
                    collection.FindOneAndUpdate(x => x.userName.Equals(currentUser.userName), Builders<User>.Update.Set("active", updateUser.active));
                }
            } catch (Exception e)
            {
                throw e;
            }
        }
    }


}
