using MVC_Core_test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Core_test.ViewModels
{
    public class HomeViewModel
    {
        public string  Title { get; set; }
        public List<Pie> Pies { get; set; }
    }
}
