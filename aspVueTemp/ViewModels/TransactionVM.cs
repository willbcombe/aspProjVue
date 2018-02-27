using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace aspVueTemp.ViewModels
{
    public class TransactionVM
    {
        [DisplayName ("Transaction Id")]
        public string id { get; set; }
        [DisplayName("Name")]
        public string name { get; set; }
        public string type { get; set; }
        public DateTime date { get; set; }
        public decimal amount_total { get; set; }
        public int amount_of_users { get; set; }
        public string sender_id { get; set; }
    }
}
