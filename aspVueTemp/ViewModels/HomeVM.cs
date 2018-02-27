using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace aspVueTemp.ViewModels
{
    public class HomeVM
    {
        [DisplayName("Home ID")]
        public string id { get; set; }
        [DisplayName("Home Name")]
        public string name { get; set; }
    }
}
