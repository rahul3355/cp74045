using CP74045.Data.Models;
using CP74045.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CP74045.Data.Services
{
    public class TeamsService
    {
        private AppDbContext _context;
        public TeamsService(AppDbContext context)
        {
            _context = context;
        }

        public void AddTeam(TeamVM team)
        {
            var _team = new Team()
            {
                TeamName = team.TeamName,
                TeamInfo = team.TeamInfo
            };
            _context.Teams.Add(_team);
            _context.SaveChanges();
        }

        public List<Team> GetAllTeams() => _context.Teams.ToList();

        public Team GetTeamById(int teamId) => _context.Teams.FirstOrDefault(n => n.TeamId == teamId);

        public Team UpdateTeamById(int Id, TeamVM team)
        {
            var _team = _context.Teams.FirstOrDefault(n => n.TeamId == Id);
            if (_team != null)
            {

                _team.TeamName = team.TeamName;
                _team.TeamInfo = team.TeamInfo;

                _context.SaveChanges();
            }
            return _team;
        }

        public void DeleteTeamById(int teamId)
        {
            var _team = _context.Teams.FirstOrDefault(n => n.TeamId == teamId);
            if (_team != null)
            {
                _context.Teams.Remove(_team);
                _context.SaveChanges();
            }
        }
    }
}
