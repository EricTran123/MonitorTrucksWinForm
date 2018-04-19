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
        public String createDate { get; set; }
        public String modifyDate { get; set; }
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
            return collection.Find(x => !String.IsNullOrEmpty(x.name)).SortBy(x => x.name).ToList();
        }
        public void updateCustomer(Customer customer, IMongoDatabase mongoDatabase)
        {
            if (null != customer)
            {
                var collection = mongoDatabase.GetCollection<Customer>("customers");
            }
        }
    }
}
