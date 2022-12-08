using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CP74045.Data.ViewModels
{
    public class ProjectVM
    {
        public string ProjectName { get; set; }
        public int ProjectDurationInDays { get; set; }
        public string ProjectType { get; set; }
        public string BackendRequirements { get; set; }
        public string FrontendRequirements { get; set; }
        public int ProjectBudget { get; set; }
        public string ProjectDatabaseUsed { get; set; }
        public string ProjectInfo { get; set; }
        public string ProjectStatus { get; set; }

    }
}
