using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ItemService : IItemService
    {
        public ItemService() { }
        public bool RegisterItem(Item i)
        {
            return true;
        }
    }
}
