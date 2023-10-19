using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace WebUI.Models
{
    public class Portfolio
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public string PhotoUrl { get; set; }
        public string Title { get; set; }
        public int CategoryId {get; set; }
        public Categry Category {get; set; }
        
    }
}