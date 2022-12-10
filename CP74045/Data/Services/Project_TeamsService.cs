using CP74045.Data.Models;
using CP74045.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CP74045.Data.Services
{
    public class Project_TeamsService
    {
        private AppDbContext _context;
        public Project_TeamsService(AppDbContext context)
        {
            _context = context;
        }

        public void AddProject_Team(Project_TeamVM project_team)
        {
            var _project_team = new Project_Team()
            {
                ProjectId = project_team.ProjectId,
                TeamId = project_team.TeamId


            };
            _context.Project_Teams.Add(_project_team);
            _context.SaveChanges();

        }

        public List<Project_Team> GetAllProject_Teams() => _context.Project_Teams.ToList();

        public Project_Team GetProject_TeamById(int project_teamId) => _context.Project_Teams.FirstOrDefault(n => n.PTId == project_teamId);

        public List<Project_Team> GetProject_TeamByProjectId(int Id) => _context.Project_Teams.Where(n => n.ProjectId == Id).ToList();

        public List<Project_Team> GetProject_TeamByTeamId(int Id) => _context.Project_Teams.Where(n => n.TeamId == Id).ToList();

        public Project_Team UpdateProject_TeamById(int Id, Project_TeamVM project_team)
        {
            var _project_team = _context.Project_Teams.FirstOrDefault(n => n.PTId == Id);
            if (_project_team != null)
            {

                _project_team.ProjectId = project_team.ProjectId;
                _project_team.TeamId = project_team.TeamId;

                _context.SaveChanges();
            }
            return _project_team;
        }

        public void DeleteProject_TeamById(int project_teamId)
        {
            var _project_team = _context.Project_Teams.FirstOrDefault(n => n.PTId == project_teamId);
            if (_project_team != null)
            {
                _context.Project_Teams.Remove(_project_team);
                _context.SaveChanges();
            }
        }


    }
}
