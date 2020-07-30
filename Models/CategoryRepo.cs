using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCoreMVC.Models
{
    public class CategoryRepo : ICategoryRepo
    {
        private readonly AppDbContext appDbContext;

        public CategoryRepo(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public IEnumerable<Category> AllCategories => appDbContext.Categories;
    }
}
