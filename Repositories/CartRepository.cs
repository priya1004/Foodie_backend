using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;


namespace Repositories
{
    public class CartRepository : ICartRepository
    {
        IMongoClient mongoClient;
        IMongoDatabase database;
        public CartRepository()
        {
            mongoClient = new MongoClient("mongodb://127.0.0.1:27017"); //url of the server
            database = mongoClient.GetDatabase("Cart"); //db name
        }
        IMongoCollection<Cart> CartSet => database.GetCollection<Cart>("CartTable");




        //public void InsertVisitor(Visitor v)
        //{
        //    Visitors.InsertOne(v);
        //}

        public List<Cart> ShowCart()
        {
            return CartSet.Find((p) => true).ToList();

        }
    }
}
