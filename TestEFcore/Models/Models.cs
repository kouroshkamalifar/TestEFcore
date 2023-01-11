using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TestEFcore.Models
{
    public class person
    {
        public int Id { get; set; }
        public string BaseAddress { get; set; }
        public string AddressUrl { get; set; }
        public bool IsLoginUrl { get; set; }
        public bool IsLogoutUrl { get; set; }
        public List<address> address { get; set; }

    }

    public class address
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public List<person> person { get; set; }

    }
    //public class City
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
       
    //}
}
