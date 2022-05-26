using System;
using System.Collections.Generic;

namespace EcommerceApp.Models
{
    public class Producer
    {
        public Producer()
        {
        }
        public int Id { get; set; }

        public string FullName { get; set; }

        public string Biography { get; set; }

        //Relationship
        public List<Movie> Movies { get; set; }
    }
}
