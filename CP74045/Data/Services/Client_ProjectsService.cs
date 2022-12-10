using CP74045.Data.Models;
using CP74045.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CP74045.Data.Services
{
    public class Client_ProjectsService
    {
        private AppDbContext _context;
        public Client_ProjectsService(AppDbContext context)
        {
            _context = context;
        }

        public void AddClient_Project(Client_ProjectVM client_project)
        {
            var _client_project = new Client_Project()
            {
                ClientId = client_project.ClientId,
                ProjectId = client_project.ProjectId
                
            };
            _context.Client_Projects.Add(_client_project);
            _context.SaveChanges();

        }

        public List<Client_Project> GetAllClient_Projects() => _context.Client_Projects.ToList();

        public Client_Project GetClient_ProjectById(int client_projectId) => _context.Client_Projects.FirstOrDefault(n => n.CPId == client_projectId);

        public List<Client_Project> GetClient_ProjectByClientId(int Id) => _context.Client_Projects.Where(n => n.ClientId == Id).ToList();

        public List<Client_Project> GetClient_ProjectByProjectId(int Id) => _context.Client_Projects.Where(n => n.ProjectId == Id).ToList();

        public Client_Project UpdateClient_ProjectById(int Id, Client_ProjectVM client_project)
        {
            var _client_project = _context.Client_Projects.FirstOrDefault(n => n.CPId == Id);
            if (_client_project != null)
            {

                _client_project.ClientId = client_project.ClientId;
                _client_project.ProjectId = client_project.ProjectId;

                _context.SaveChanges();
            }
            return _client_project;
        }

        public void DeleteClient_ProjectById(int client_projectId)
        {
            var _client_project = _context.Client_Projects.FirstOrDefault(n => n.CPId == client_projectId);
            if (_client_project != null)
            {
                _context.Client_Projects.Remove(_client_project);
                _context.SaveChanges();
            }
        }

    }
}
