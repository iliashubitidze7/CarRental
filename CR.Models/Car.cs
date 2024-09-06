﻿
using System.ComponentModel.DataAnnotations;

namespace CR.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Model { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        [MaxLength(5)]
        public string Seats { get; set; }

        [Required]
        public string Fuel { get; set; }

        [Required]
        public string Transmission { get; set; }

        public string Interior { get; set; }

        public Double Price { get; set; }

        public Double PriceFor8 { get; set; }

        public DateOnly StartingDate { get; set; }

        public DateOnly EndDate { get; set; }

        

    }
}
