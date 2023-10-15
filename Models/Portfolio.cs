using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models
{
    public class Portfolio
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public string PhotoUrl { get; set; }
        public string Title { get; set; }

        public static implicit operator Portfolio?(Banner? v)
        {
            throw new NotImplementedException();
        }
    }
}