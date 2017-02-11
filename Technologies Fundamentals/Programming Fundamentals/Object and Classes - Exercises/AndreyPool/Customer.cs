using System.Collections.Generic;

namespace AndreyPool
{
    public class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, int> ShopList { get; set; }
        public double Bill { get; set; }
    }
}
