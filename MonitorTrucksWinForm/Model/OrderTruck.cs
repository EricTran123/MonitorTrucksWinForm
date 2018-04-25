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
    }
}
