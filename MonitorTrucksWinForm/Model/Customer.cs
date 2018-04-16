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
        public ObjectId id { get; set; }
        public String name { get; set; }
        public String address { get; set; }
        public String createDate { get; set; }
        public String phoneNumber { get; set; }
        public Boolean active { get; set; }

        public List<Customer> getAllActiveCustomers (IMongoDatabase mongoDatabase)
        {
            var collection = mongoDatabase.GetCollection<Customer>("customers");
            return collection.Find(x => x.active).ToList();
        }
        public void deleteCustomer (IMongoDatabase mongoDatabase)
        {

        }
        public Customer findCustomerByPhone( String phoneNumber, IMongoDatabase mongoDatabase)
        {
            var collection = mongoDatabase.GetCollection<Customer>("customers");
            return collection.Find(x => x.phoneNumber.Equals(phoneNumber)).FirstOrDefault();
        }
    }
}
