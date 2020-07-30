using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCoreMVC.Models
{
    public class BagRepo : IBagRepo
    {
        private readonly AppDbContext appDbContext;

        public BagRepo(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public IEnumerable<Bag> AllBags {
            get
            {
                return appDbContext.Bags.Include(c => c.Category);
            }
        }

        public IEnumerable<Bag> BagsOfTheWeek
        {
            get
            {
                return appDbContext.Bags.Include(c => c.Category).Where(p => p.IsBagOfTheWeek);
            }
        }

        public Bag GetBagById(int bagId)
        {
            return appDbContext.Bags.FirstOrDefault(p => p.id == bagId);
        }
    }
}
