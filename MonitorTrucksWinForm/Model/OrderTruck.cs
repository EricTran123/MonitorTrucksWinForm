using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppTest.Model;
using MongoDB.Driver;
using MongoDB.Bson;

namespace WindowsFormsAppTest.Model
{
    class OrderTruck
    {
        public ObjectId _id { get; set; }
        public Customer customer { get; set; }
        public String materialType { get; set; }
        public int subtotal { get; set; }
        public String note { get; set; }
        public DateTime createDate { get; set; }
        public DateTime completedDate { get; set; }
        public DateTime modifyDate { get; set; }
        public bool isPaid { get; set; }
        

        public List<OrderTruck> getAllOrderTrucks(IMongoDatabase mongoDatabase)
        {
            try
            {
                var collection = mongoDatabase.GetCollection<OrderTruck>("ordertrucks");
                return collection.Find(x => (x.customer != null)).SortBy(x => x.completedDate).ToList();
            } catch (Exception e)
            {
                return null;
                throw e;
            }
        }
        public OrderTruck getOrderTruckByID(IMongoDatabase mongoDatabase, String id)
        {
            try
            {
                var collection = mongoDatabase.GetCollection<OrderTruck>("ordertrucks");
                return collection.Find(Builders<OrderTruck>.Filter.Eq("_id", ObjectId.Parse(id))).FirstOrDefault(); ;
            } catch (Exception e)
            {
                return null;
                throw e;
            }
        }
        public void addOrderTruck(IMongoDatabase mongoDatabase, OrderTruck newOrderTruck)
        {
            try
            {
                var collection = mongoDatabase.GetCollection<OrderTruck>("ordertrucks");
                if (null != newOrderTruck)
                {
                    collection.InsertOneAsync(newOrderTruck);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public List<OrderTruck> filterByCreateDate (DateTime startDate, DateTime endDate, IMongoDatabase mongoDatabase)
        {
            if (startDate <= endDate)
            {
                var collection = mongoDatabase.GetCollection<OrderTruck>("ordertrucks");
                return collection.Find(x => (x.createDate >= startDate && x.createDate <= endDate)).ToList();
            } else
            {
                return null;
            }
        }
        public List<OrderTruck> getListIsPaidOrderTruck (IMongoDatabase mongoDatabase, bool isPaid)
        {
            try
            {
                var collection = mongoDatabase.GetCollection<OrderTruck>("ordertrucks");
                return collection.FindSync(x => x.isPaid.Equals(isPaid)).ToList();
            } catch (Exception e)
            {
                return null;
                throw e;
            }
        }

        public List<OrderTruck> filterByMaterialType(String materialType, IMongoDatabase mongoDatabase)
        {
            if (materialType != null)
            {
                var collection = mongoDatabase.GetCollection<OrderTruck>("ordertrucks");
                return collection.Find(x => x.materialType.Equals(materialType)).ToList();
            } else
            {
                return null;
            }
        }
        public void updateOrderTruck (IMongoDatabase mongoDatabase, OrderTruck currentOrderTruck, OrderTruck updatedOrderTruck)
        {
            if ( currentOrderTruck != null && updatedOrderTruck != null)
            {
                try
                {
                    var collection = mongoDatabase.GetCollection<OrderTruck>("ordertrucks");
                    if (!currentOrderTruck.customer.Equals(updatedOrderTruck.customer) || !currentOrderTruck.materialType.Equals(updatedOrderTruck.materialType)
                        || !currentOrderTruck.note.Equals(updatedOrderTruck.note) || !currentOrderTruck.subtotal.Equals(updatedOrderTruck.subtotal)
                        || !currentOrderTruck.completedDate.Equals(updatedOrderTruck.completedDate) || !currentOrderTruck.isPaid.Equals(updatedOrderTruck.isPaid))
                    {
                        if (!currentOrderTruck.customer.Equals(updatedOrderTruck.customer))
                        {
                            collection.FindOneAndUpdate(Builders<OrderTruck>.Filter.Eq("_id", ObjectId.Parse(currentOrderTruck._id.ToString())), Builders<OrderTruck>.Update.Set("customer", updatedOrderTruck.customer));
                        }
                        if (!currentOrderTruck.materialType.Equals(updatedOrderTruck.materialType))
                        {
                            collection.FindOneAndUpdate(Builders<OrderTruck>.Filter.Eq("_id", ObjectId.Parse(currentOrderTruck._id.ToString())), Builders<OrderTruck>.Update.Set("materialType", updatedOrderTruck.materialType));
                        }
                        if (!currentOrderTruck.note.Equals(updatedOrderTruck.note))
                        {
                            collection.FindOneAndUpdate(Builders<OrderTruck>.Filter.Eq("_id", ObjectId.Parse(currentOrderTruck._id.ToString())), Builders<OrderTruck>.Update.Set("note", updatedOrderTruck.note));
                        }
                        if (!currentOrderTruck.subtotal.Equals(updatedOrderTruck.subtotal))
                        {
                            collection.FindOneAndUpdate(Builders<OrderTruck>.Filter.Eq("_id", ObjectId.Parse(currentOrderTruck._id.ToString())), Builders<OrderTruck>.Update.Set("subtotal", updatedOrderTruck.subtotal));
                        }
                        if (!currentOrderTruck.completedDate.Equals(updatedOrderTruck.completedDate))
                        {
                            collection.FindOneAndUpdate(Builders<OrderTruck>.Filter.Eq("_id", ObjectId.Parse(currentOrderTruck._id.ToString())), Builders<OrderTruck>.Update.Set("completedDate", updatedOrderTruck.completedDate));
                        }
                        if (!currentOrderTruck.isPaid.Equals(updatedOrderTruck.isPaid))
                        {
                            collection.FindOneAndUpdate(Builders<OrderTruck>.Filter.Eq("_id", ObjectId.Parse(currentOrderTruck._id.ToString())), Builders<OrderTruck>.Update.Set("isPaid", updatedOrderTruck.isPaid));
                        }
                        collection.FindOneAndUpdate(Builders<OrderTruck>.Filter.Eq("_id", ObjectId.Parse(currentOrderTruck._id.ToString())), Builders<OrderTruck>.Update.Set("modifyDate", updatedOrderTruck.modifyDate));
                    }
                } catch (Exception e)
                {
                    throw e;
                }
            }
        }
        public void updateOrderTruckByCustomer (IMongoDatabase mongoDatabase, Customer updateCustomer)
        {
            try
            {
                var collection = mongoDatabase.GetCollection<OrderTruck>("ordertrucks");
                collection.UpdateManyAsync(x => x.customer._id.Equals(updateCustomer._id), Builders<OrderTruck>.Update.Set("customer", updateCustomer));
            } catch (Exception e)
            {
                throw e;
            }
        }
        public void deleteOrderTruck(IMongoDatabase mongoDatabase, String _id)
        {
            try
            {
                var collection = mongoDatabase.GetCollection<OrderTruck>("ordertrucks");
                collection.FindOneAndDeleteAsync(Builders<OrderTruck>.Filter.Eq("_id", ObjectId.Parse(_id)));
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
