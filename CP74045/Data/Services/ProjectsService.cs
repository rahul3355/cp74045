using CP74045.Data.Models;
using CP74045.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CP74045.Data.Services
{
    public class ProjectsService
    {
        private AppDbContext _context;

        public ProjectsService(AppDbContext context)
        {
            _context = context;
        }

        public void AddProject(ProjectVM project)
        {
            var _project = new Project()
            {
                ProjectName = project.ProjectName,
                ProjectDurationInDays = project.ProjectDurationInDays,
                ProjectType = project.ProjectType,
                FrontendRequirements = project.FrontendRequirements,
                BackendRequirements = project.BackendRequirements,
                ProjectBudget = project.ProjectBudget,
                ProjectDatabaseUsed = project.ProjectDatabaseUsed,
                ProjectInfo = project.ProjectInfo,
                ProjectStatus = project.ProjectStatus,
            };
            _context.Projects.Add(_project);
            _context.SaveChanges();

        }
        
        public List<Project> GetAllProjects() => _context.Projects.ToList();

        public Project GetProjectById(int projectId) => _context.Projects.FirstOrDefault(n => n.ProjectId == projectId);

        public Project UpdateProjectById(int Id, ProjectVM project)
        {
            var _project = _context.Projects.FirstOrDefault(n => n.ProjectId == Id);
            if (_project != null)
            {
                _project.ProjectName = project.ProjectName;
                _project.ProjectDurationInDays = project.ProjectDurationInDays;
                _project.ProjectType = project.ProjectType;
                _project.FrontendRequirements = project.FrontendRequirements;
                _project.BackendRequirements = project.BackendRequirements;
                _project.ProjectBudget = project.ProjectBudget;
                _project.ProjectDatabaseUsed = project.ProjectDatabaseUsed;
                _project.ProjectInfo = project.ProjectInfo;
                _project.ProjectStatus = project.ProjectStatus;

                _context.SaveChanges();
            }
            return _project;
        }

        public void DeleteProjectById(int projectId)
        {
            var _project = _context.Projects.FirstOrDefault(n => n.ProjectId == projectId);
            if (_project != null)
            {
                _context.Projects.Remove(_project);
                _context.SaveChanges();
            }
        }

    }
}
