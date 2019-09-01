using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace DM.DataAccess.Models
{
    [Table("Categories")]
    public class Categories
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Parent { get; set; }
        public int Position { get; set; }
    }
}
