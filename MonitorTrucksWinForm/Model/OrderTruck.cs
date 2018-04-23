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
        public Customer customer { get; set; }
        public String materialType { get; set; }
        public int subtotal { get; set; }
        public String note { get; set; }
        public DateTime createDate { get; set; }
        public DateTime completedDate { get; set; }
        public DateTime modifyDate { get; set; }

       
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
