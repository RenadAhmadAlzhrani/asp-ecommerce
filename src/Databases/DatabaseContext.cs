using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeCrafters_backend_teamwork.src.Databases
{
    public class DatabaseContext
    {
        public IEnumerable<OrderItem> orderItem {get;}

        public DatabaseContext ()
        {
            orderItem = new OrderItem (34,"{orderCheckoutId}","{stockId}",4)
        }
    }
}
