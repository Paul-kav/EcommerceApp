using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using EcommerceApp.Data;

namespace EcommerceApp.Models
{
    public class Movie
    {
        public Movie()
        {
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int Price { get; set; }

        public MovieCategory MovieCategory { get; set; }

        //Relationship
        public List<Actor_Movie> Actor_Movie { get; set; }

        //Producer
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]

        public Producer Producer { get; set; }


        //Cinema
        public int  CinemaId { get; set; }
        [ForeignKey("CinemaId")]

        public Cinema Cinema { get; set; }
    }
}
