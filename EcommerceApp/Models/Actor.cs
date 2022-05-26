using System;
using System.Collections.Generic;

namespace EcommerceApp.Models
{
    public class Actor
    {
        public Actor()
        {
        }

        public int Id { get; set; }

        public string FullName { get; set; }

        public string Biograpy { get; set; }

        //Relationship
        public List<Actor_Movie> Actors_Movies { get; set; }

    }
}
