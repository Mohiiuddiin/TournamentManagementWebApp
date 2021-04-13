using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using TournamentManagementWebApp.Models;

namespace TournamentManagementWebApp.DAL
{
    public class DataContext : DbContext
    {
        public DataContext() : base("TournamentDB")
        {

        }

        public DbSet<Team> Teams { get; set; }

    }
}