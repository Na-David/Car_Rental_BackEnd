using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Rental_BackEnd.Models
{
    public class Car_Details
    {
        [Key]
        public string RegNumber { get; set; }
        public string Car_Maker { get; set; }
        public string Car_Model { get; set; }
        public int Car_Mileage { get; set; }

    }
}
