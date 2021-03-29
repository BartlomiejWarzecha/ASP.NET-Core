using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_API.Entities
{
    public class Dish
    {
        public int Id { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        public int RestaurantId { get; set; }
        public virtual Restaurant  Restaurant { get; set; }
    }
}
