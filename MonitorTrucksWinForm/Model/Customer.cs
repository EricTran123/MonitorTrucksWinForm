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
            try
            {
                var collection = mongoDatabase.GetCollection<Customer>("customers");
                collection.FindOneAndDeleteAsync(Builders<Customer>.Filter.Eq("_id",ObjectId.Parse(id)));
            } catch(Exception e)
            {
                throw e;
            }        
        }
        public Customer findCustomerByPhone( String phoneNumber, IMongoDatabase mongoDatabase)
        {
            var collection = mongoDatabase.GetCollection<Customer>("customers");
            return collection.Find(x => x.phoneNumber.Equals(phoneNumber)).FirstOrDefault();
        }

        public Customer findCustomerByID(IMongoDatabase mongoDatabase, String id)
        {
            try
            {
                var collection = mongoDatabase.GetCollection<Customer>("customers");
                return collection.Find(Builders<Customer>.Filter.Eq("_id", ObjectId.Parse(id))).FirstOrDefault(); ;
            }
            catch (Exception e)
            {
                return null;
                throw e;
            }
        }
        public List<Customer> getAllCustomers (IMongoDatabase mongoDatabase)
        {
            var collection = mongoDatabase.GetCollection<Customer>("customers");
            return collection.Find(x => !String.IsNullOrEmpty(x.name)).SortBy(x => x.createDate).ToList();
        }
        public void updateCustomer(IMongoDatabase mongoDatabase, Customer currentCustomer, Customer updateCustomer)
        {
            if (currentCustomer != null && updateCustomer != null){
                var collection = mongoDatabase.GetCollection<Customer>("customers");
                try
                {
                    if (!currentCustomer.name.Equals(updateCustomer.name) || !currentCustomer.phoneNumber.Equals(updateCustomer.phoneNumber)
                        || !currentCustomer.address.Equals(updateCustomer.address)|| !currentCustomer.isActive.Equals(updateCustomer.isActive))
                    {
                        if (!currentCustomer.name.Equals(updateCustomer.name))
                        {
                            collection.FindOneAndUpdate(Builders<Customer>.Filter.Eq("_id", ObjectId.Parse(currentCustomer._id.ToString())), Builders<Customer>.Update.Set("name", updateCustomer.name));
                        }
                        if (!currentCustomer.phoneNumber.Equals(updateCustomer.phoneNumber))
                        {
                            collection.FindOneAndUpdate(Builders<Customer>.Filter.Eq("_id", ObjectId.Parse(currentCustomer._id.ToString())), Builders<Customer>.Update.Set("phoneNumber", updateCustomer.phoneNumber));
                        }
                        if (!currentCustomer.address.Equals(updateCustomer.address))
                        {
                            collection.FindOneAndUpdate(Builders<Customer>.Filter.Eq("_id", ObjectId.Parse(currentCustomer._id.ToString())), Builders<Customer>.Update.Set("address", updateCustomer.address));
                        }
                        if (!currentCustomer.isActive.Equals(updateCustomer.isActive))
                        {
                            collection.FindOneAndUpdate(Builders<Customer>.Filter.Eq("_id", ObjectId.Parse(currentCustomer._id.ToString())), Builders<Customer>.Update.Set("isActive", updateCustomer.isActive));
                        }
                        collection.FindOneAndUpdate(Builders<Customer>.Filter.Eq("_id", ObjectId.Parse(currentCustomer._id.ToString())), Builders<Customer>.Update.Set("modifyDate", updateCustomer.modifyDate));
                    }
                   
                } catch (Exception e)
                {
                    throw e;
                }
               
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
