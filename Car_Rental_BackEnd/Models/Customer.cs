using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Rental_BackEnd.Models
{
    public class Customer
    {
        [Key]
        public string UserName { get; set; }
        public string Cust_Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }


    }
}
