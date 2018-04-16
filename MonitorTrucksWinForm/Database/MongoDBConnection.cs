using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace WindowsFormsAppTest.Database
{
    class MongoDBConnection
    {
        private static volatile MongoDBConnection mongoDBConnection;
        private static object syncLock = new Object();
        private MongoClient mongoClient = null;

        private MongoDBConnection() { }
        public static MongoDBConnection getMongoConnection
        {
            get
            {
                if (mongoDBConnection == null)
                {
                    lock (syncLock)
                    {
                        if (mongoDBConnection == null)
                            mongoDBConnection = new MongoDBConnection();
                    }
                }

                return mongoDBConnection;
            }
        }
        public MongoClient getMongoClient(String connectionString)
        {
            if (mongoClient == null)
            {
                try
                {
                    mongoClient = new MongoClient(connectionString);
                }
                catch (MongoClientException e)
                {
                    mongoClient = null;
                }

            }
            return mongoClient;
        }
       

    }
}
