using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ItemRepository : IItemRepository
    {
        public ItemRepository() { }
        public bool AddItem(Item i)
        {
            return true;
        }
    }
}
