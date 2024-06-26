using BookMySpoon.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace BookMySpoon.Repositorio
{
    public class ClientsRepository : IClientsRepository
    {
        private string ConnectionString;

        public ClientsRepository(string conn)
        {
            ConnectionString = conn;
        }

        private SqlConnection Connect()
        {
            return new SqlConnection(ConnectionString);
        }
        public async Task<bool> SaveClient(Client client)
        {
            bool isCreated;
            try
            {
                using (SqlConnection sqlConexion = Connect())
                {
                    await sqlConexion.OpenAsync();
                    using (SqlCommand Comm = sqlConexion.CreateCommand())
                    {
                        Comm.CommandText = "dbo.NewUser";
                        Comm.CommandType = CommandType.StoredProcedure;
                        Comm.Parameters.Add("@Name", SqlDbType.VarChar, 500).Value = client.Name;
                        Comm.Parameters.Add("@Email", SqlDbType.VarChar, 500).Value = client.Email;
                        Comm.Parameters.Add("@PhoneNumber", SqlDbType.VarChar, 100).Value = client.PhoneNumber;
                        Comm.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = DateTime.Now;

                        await Comm.ExecuteNonQueryAsync();
                        isCreated = true;
                    }
                }
            }
            catch (SqlException ex)
            {
                // Detallar la información del error
                Console.WriteLine($"SQL Error: {ex.Message}");
                foreach (SqlError error in ex.Errors)
                {
                    Console.WriteLine($"Error Code: {error.Number}, Message: {error.Message}");
                }
                throw new Exception("Error saving client", ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General Error: {ex.Message}");
                throw new Exception("Error saving client", ex);
            }

            return isCreated;
        }

        public async Task<IEnumerable<Client>> GetAllClients()
        {
            List<Client> clients = new List<Client>();

            try
            {
                using (SqlConnection sqlConexion = Connect())
                {
                    await sqlConexion.OpenAsync();
                    using (SqlCommand Comm = sqlConexion.CreateCommand())
                    {
                        Comm.CommandText = "dbo.ClientsList";
                        Comm.CommandType = CommandType.StoredProcedure;
                        SqlDataReader reader = await Comm.ExecuteReaderAsync();
                        while (reader.Read())
                        {
                            Client c = new Client();
                            c.Id = reader.GetInt32("Id");
                            c.Name = reader.GetString("Name");
                            c.Email = reader.GetString("Email");
                            c.PhoneNumber = reader.GetString("PhoneNumber");
                            clients.Add(c);
                        }
                        reader.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                // Detallar la información del error
                Console.WriteLine($"SQL Error: {ex.Message}");
                foreach (SqlError error in ex.Errors)
                {
                    Console.WriteLine($"Error Code: {error.Number}, Message: {error.Message}");
                }
                throw new Exception("Error saving client", ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General Error: {ex.Message}");
                throw new Exception("Error saving client", ex);
            }

            return clients;
        }
    }
}
