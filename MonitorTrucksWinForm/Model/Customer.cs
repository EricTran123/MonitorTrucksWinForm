using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace WindowsFormsAppTest
{
    class Customer
    {
        public ObjectId _id { get; set; }
        public String name { get; set; }
        public String phoneNumber { get; set; }
        public String address { get; set; }
        public Boolean isActive { get; set; }
        public DateTime createDate { get; set; }
        public DateTime modifyDate { get; set; }
        public Customer()
        {
            isActive = false;
        }
        public List<Customer> getAllActiveCustomers (IMongoDatabase mongoDatabase)
        {
            var collection = mongoDatabase.GetCollection<Customer>("customers");
            return collection.Find(x => x.isActive).ToList();
        }
        public void deleteCustomer (IMongoDatabase mongoDatabase, String id)
        {
            var collection = mongoDatabase.GetCollection<Customer>("customers");
            collection.FindOneAndDeleteAsync(x => x._id.Equals(id));
        }
        public Customer findCustomerByPhone( String phoneNumber, IMongoDatabase mongoDatabase)
        {
            var collection = mongoDatabase.GetCollection<Customer>("customers");
            return collection.Find(x => x.phoneNumber.Equals(phoneNumber)).FirstOrDefault();
        }
        public List<Customer> getAllCustomers (IMongoDatabase mongoDatabase)
        {
            var collection = mongoDatabase.GetCollection<Customer>("customers");
            return collection.Find(x => !String.IsNullOrEmpty(x.name)).SortBy(x => x.createDate).ToList();
        }
        public void updateCustomer(IMongoDatabase mongoDatabase, Customer currentUser, Customer newUser)
        {
            if (!currentUser.Equals(newUser)){

            }
            {
                var collection = mongoDatabase.GetCollection<Customer>("customers");
            }
        }
        public void addCustomer (IMongoDatabase mongoDatabase, Customer newCustomer)
        {
           
            try
            {
                var collection = mongoDatabase.GetCollection<Customer>("customers");
                if (newCustomer != null)
                {
                    collection.InsertOneAsync(newCustomer);
                }
            } catch(Exception e)
            {
                throw e;
            }
        }
    }
}
