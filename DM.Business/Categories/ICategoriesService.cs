using System;
using System.Collections.Generic;
using System.Text;
using DM.DataAccess.Models;

namespace DM.Business
{
    public interface ICategoriesService
    {
        List<Categories> GetAll();
        Categories GetById(int Id);
    }
}
