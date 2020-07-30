using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCoreMVC.Models
{
    public interface IBagRepo
    {
        IEnumerable<Bag> AllBags { get; }
        IEnumerable<Bag> BagsOfTheWeek { get; }
        Bag GetBagById(int bagId);
    }
}
