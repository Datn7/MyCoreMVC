using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCoreMVC.Models
{
    public class MockCategoryRepo : ICategoryRepo
    {
        public IEnumerable<Category> AllCategories => new List<Category>
        {
            new Category{CategoryId=1, CategoryName="ვიტონი", Description="კაი ჩანთაა"},
            new Category{CategoryId=2, CategoryName="გუჩი", Description="ნიჩივო ჩანთაა"}
        };
    }
}
