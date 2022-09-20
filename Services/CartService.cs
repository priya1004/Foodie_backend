using Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CartService : ICartService
    {
        private readonly ICartRepository rep;
        public CartService(ICartRepository r)
        {
            rep = r;
        }
        public List<Cart> ViewCart()
        {
            return rep.ShowCart();
        }
    }
}
