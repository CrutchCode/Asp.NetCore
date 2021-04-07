using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3DPlastSiteMVC.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string UserEmail { get; set; }
        public string UserPhone { get; set; }
    }
}
