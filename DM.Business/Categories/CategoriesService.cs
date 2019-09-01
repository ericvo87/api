using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Dapper;
using DM.Common;
using DM.DataAccess.Models;
using Microsoft.Extensions.Options;
using MySql.Data.MySqlClient;

namespace DM.Business
{
    public class CategoriesService : BaseService, ICategoriesService
    {
        public CategoriesService(IOptions<DbConnect> connectionStrings):base(connectionStrings)
        {
        }
        public List<Categories> GetAll()
        {
            return _db.Query<Categories>("SELECT * FROM Categories").ToList();
        }

        public Categories GetById(int Id)
        {
            return _db.Query<Categories>("SELECT * FROM Categories where Id ="+Id.ToString()).FirstOrDefault();
        }
    }
}
