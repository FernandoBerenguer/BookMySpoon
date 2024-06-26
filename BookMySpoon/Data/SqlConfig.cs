namespace BookMySpoon.Data
{
    public class SqlConfig
    {
        private string _connectionString;
        public string ConnectionString { get => _connectionString; }
        public SqlConfig(string conn)
        {
            _connectionString = conn;
        }
    }
}
