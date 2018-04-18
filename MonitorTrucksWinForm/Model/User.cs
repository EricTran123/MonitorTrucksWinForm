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
        public ObjectId Id { get; set; }
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
            return collection.Find(x => !String.IsNullOrEmpty(x.userName)).SortBy(x => x.userName).ToList();
        }
        /*
         Delete user
        */
        public void deleteUser(IMongoDatabase mongoDatabase, String id)
        {
            var collection = mongoDatabase.GetCollection<User>("users");
            collection.FindOneAndDeleteAsync(x => x.Id.Equals(id));
        }

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
    }


}
