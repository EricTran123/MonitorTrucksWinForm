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
        public String username { get; set; }
        public String password { get; set; }
        public String createDate { get; set; }

        //public User(String user, String password, String createDate)
        //{
        //    this.userName = user;
        //    this.password = password;
        //    this.createDate = createDate;
        //}
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

        //public User findUserByName (String userName, IMongoDatabase mongoDatabase)
        //{
        //    var collection = mongoDatabase.GetCollection<User>("users");
        //    var foundUser = collection.Find(x => x.username == userName).FirstOrDefault();
        //    return foundUser.ToBson;
        //}


    }
    
   
}
