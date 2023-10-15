using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models;


namespace WebUI.WiewModels
{
    public class HomeVM
    {
        public required Banner Banner { get; set; }
        public required List<Service> Services { get; set; }
        public required Portfolio Portfolio { get; set; }
}
    }
