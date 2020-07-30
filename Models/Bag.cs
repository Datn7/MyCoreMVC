using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCoreMVC.Models
{
    public class Bag
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public bool IsBagOfTheWeek { get; set; }
        public string ProfilePicture { get; set; }
        public Category Category { get; set; }

    }
}
