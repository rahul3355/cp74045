using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CP74045.Data.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public int ProjectDurationInDays { get; set; }
        public string ProjectType { get; set; }
        public string BackendRequirements { get; set; }
        public string FrontendRequirements { get; set; }
        public int ProjectBudget { get; set; }
        public string ProjectDatabaseUsed { get; set; }
        public string ProjectInfo { get; set; }
        public string ProjectStatus { get; set; }

        //Navigation Properties
        public List<Client_Project> Client_Projects { get; set; }

    }
}
