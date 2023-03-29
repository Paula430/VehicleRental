﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BikeRentalSystem.Models
{
    public class Bike : Vehicle
    {
        [Required]
        public string Size { get; set; }
       
       
    }
    
}
