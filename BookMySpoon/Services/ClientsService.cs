using BookMySpoon.Data;
using BookMySpoon.Interfaces;
using BookMySpoon.Repositorio;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookMySpoon.Servicios
{
    public class ClientsService : IClientsServices
    {
        private IClientsRepository clientsRepository;
        private SqlConfig config;

        public ClientsService(SqlConfig c)
        {
            config = c;
            clientsRepository = new ClientsRepository(config.ConnectionString);
        }
        public Task<bool> SaveClient(Client client)
        {
            if (client.Id == 0)
                return clientsRepository.SaveClient(client);

            return Task.FromResult(false);
        }

        public Task<IEnumerable<Client>> GetAllClients()
        {
            return clientsRepository.GetAllClients();
        }
    }
}
