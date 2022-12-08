using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CP74045.Data.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public string ClientPhone { get; set; }
        public string ClientAddress { get; set; }
        public string ClientGender { get; set; }
        public string ClientUsername { get; set; }
        public string ClientPassword { get; set; }
    }
}
