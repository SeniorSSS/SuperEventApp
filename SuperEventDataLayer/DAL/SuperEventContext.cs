using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using SuperEventDataLayer.Models;

namespace SuperEventDataLayer.DAL
{
    public class SuperEventContext : DbContext
    {
        public SuperEventContext() : base("name=SuperEventConnectionString")
        {

        }

        public DbSet<ParticipantData> Participants { get; set; }

    }
}
