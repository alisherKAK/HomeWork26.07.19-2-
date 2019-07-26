using System;
using System.ComponentModel.DataAnnotations;

namespace HomeWork26_07_19_2.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public decimal Price { get; set; }
        public int Weight { get; set; }

    }
}
