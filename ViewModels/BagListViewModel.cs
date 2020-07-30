using Microsoft.AspNetCore.Http;
using MyCoreMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCoreMVC.ViewModels
{
    public class BagListViewModel
    {
        public string BagName { get; set; }
        public string BagPrice { get; set; }
        public bool IsPopular { get; set; }

        public IEnumerable<Bag> Bags { get; set; }
        public string CurrentCategory { get; set; }

        public IFormFile ProfileImage { get; set; }

    }
}
