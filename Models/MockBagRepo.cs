using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCoreMVC.Models
{
    public class MockBagRepo : IBagRepo
    {
        private readonly ICategoryRepo categoryRepo = new MockCategoryRepo();

        public IEnumerable<Bag> AllBags => new List<Bag>
        {
            new Bag{id=1,Name="ჩიჩილაკი",Price="150"},

            new Bag{id=2,Name="ვუბლა",Price="150"},

            new Bag{id=3,Name="ქუგლა",Price="150"}
        };

        public IEnumerable<Bag> BagsOfTheWeek { get; }

        public Bag GetBagById(int bagId)
        {
            return AllBags.FirstOrDefault(b => b.id == bagId);
        }
    }
}
