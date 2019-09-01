using DM.Common;
using Microsoft.Extensions.Options;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DM.Business
{
    public class BaseService
    {
        public readonly IDbConnection _db;
        public BaseService()
        {
        }
        public BaseService(IOptions<DbConnect> connectionStrings)
        {
            _db = new MySqlConnection(connectionStrings.Value.ConnectionString);
        }
        public void Dispose()
        {
            _db.Close();
        }
    }
}
