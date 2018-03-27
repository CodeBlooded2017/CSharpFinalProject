using BluesBBQ.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BluesBBQ.DAL
{
    public class MenuContext : DbContext
    {
        public DbSet<MenuItem> MenuItems { get; set; }
    }
}