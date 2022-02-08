using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Configuration;

namespace Airline_Management_CF.Models
{
    public class Airline_Management_CF_Context:DbContext
    {

        public Airline_Management_CF_Context(DbContextOptions<Airline_Management_CF_Context> options)
       : base(options)
        {

        }

        

       
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<FlightInfo> FlightInfos { get; set; }
        public virtual DbSet<FlightDetails> Flightdetails { get; set; }
        public virtual DbSet<User>Users { get; set; }
        //public virtual DbSet<Seat>Seats { get; set; }
        //public virtual DbSet<Passenger> Passengers { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }

      

    }

   
}
