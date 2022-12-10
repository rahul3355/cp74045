using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CP74045.Data.Models
{
    public class Client_Project
    {
        [Key]
        public int CPId { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
