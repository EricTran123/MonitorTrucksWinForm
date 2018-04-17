﻿using System;
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
        private IMongoDatabase mongoDatabase = null;

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
        public IMongoDatabase getMongoData(String connectionString)
        {
            if (mongoDatabase == null)
            {
                try
                {
                    MongoClient mongoClient = new MongoClient(connectionString);
                    return mongoClient.GetDatabase("truckmonitoring");
                }
                catch (MongoClientException e)
                {
                    mongoDatabase = null;
                }

            }
            return mongoDatabase;
        }
       

    }
}
