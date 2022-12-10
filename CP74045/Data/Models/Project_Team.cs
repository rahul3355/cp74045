using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CP74045.Data.Models
{
    public class Project_Team
    {
        [Key]
        public int PTId { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }

        public int TeamId { get; set; }
        public Team Team { get; set; }
    }
}
