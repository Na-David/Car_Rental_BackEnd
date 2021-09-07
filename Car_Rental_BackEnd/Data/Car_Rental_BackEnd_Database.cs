using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Car_Rental_BackEnd.Models;

namespace Car_Rental_BackEnd.Data
{
    public class Car_Rental_BackEnd_Database : DbContext
    {
        public Car_Rental_BackEnd_Database (DbContextOptions<Car_Rental_BackEnd_Database> options)
            : base(options)
        {
        }

        public DbSet<Car_Rental_BackEnd.Models.Car_Details> Car_Details { get; set; }
    }
}
