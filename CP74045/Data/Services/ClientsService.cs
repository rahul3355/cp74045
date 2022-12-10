using CP74045.Data.Models;
using CP74045.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CP74045.Data.Services
{
    public class ClientsService
    {
        private AppDbContext _context;
        public ClientsService(AppDbContext context)
        {
            _context = context;
        }

        public void AddClient(ClientVM client)
        {
            var _client = new Client()
            {
                ClientName = client.ClientName,
                ClientPhone = client.ClientPhone,
                ClientAddress = client.ClientAddress,
                ClientGender = client.ClientGender,
                ClientUsername = client.ClientUsername,
                ClientPassword = client.ClientPassword
            };
            _context.Clients.Add(_client);
            _context.SaveChanges();

            
            
            
        }

        public List<Client> GetAllClients() => _context.Clients.ToList();

        public Client GetClientById(int clientId) => _context.Clients.FirstOrDefault(n => n.ClientId == clientId);

        public Client UpdateClientById(int Id, ClientVM client)
        {
            var _client = _context.Clients.FirstOrDefault(n => n.ClientId == Id);
            if (_client != null)
            {
                _client.ClientName = client.ClientName;
                _client.ClientPhone = client.ClientPhone;
                _client.ClientAddress = client.ClientAddress;
                _client.ClientGender = client.ClientGender;
                _client.ClientUsername = client.ClientUsername;
                _client.ClientPassword = client.ClientPassword;

                _context.SaveChanges();
            }
            return _client;
        }

        public void DeleteClientById(int clientId)
        {
            var _client = _context.Clients.FirstOrDefault(n => n.ClientId == clientId);
            if (_client != null)
            {
                _context.Clients.Remove(_client);
                _context.SaveChanges();
            }
        }
    }
}
