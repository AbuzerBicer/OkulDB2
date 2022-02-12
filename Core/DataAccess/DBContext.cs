using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace Core.DataAccess
{
    public class DBContext
    {
        DbConnection _connection;
        DbCommand _command;
        DbDataReader _dr;

        public DBContext(DbConnection connection, string connectionString)
        {
            _connection = connection;
            _connection.ConnectionString = connectionString;
        }

        public DbDataReader Baglan(DbCommand command,string sorgu)
        {
            _connection.Open();
            command.CommandText = sorgu;
            command.Connection = _connection;
            _command = command;
            return _dr=_command.ExecuteReader();
        }

        public void ConnectionClose()
        {
            _connection.Close();
        }
    }
}
