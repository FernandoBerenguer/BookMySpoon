using BookMySpoon.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookMySpoon.Repositorio
{
    interface IClientsRepository
    {
        Task<bool> SaveClient(Client client);
        Task<IEnumerable<Client>> GetAllClients();
    }
}
