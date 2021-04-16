using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int IdMovie { get; set; }


        public string Reviewer { get; set; }

        public string Text { get; set; }



        public DateTime ReviewDate { get; set; }
    }
}
