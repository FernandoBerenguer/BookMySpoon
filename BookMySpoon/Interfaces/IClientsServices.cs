using BookMySpoon.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookMySpoon.Interfaces
{
    interface IClientsServices
    {
        Task<bool> SaveClient(Client client);
        Task<IEnumerable<Client>> GetAllClients();
    }
}
