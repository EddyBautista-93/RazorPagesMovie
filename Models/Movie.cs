using System;
using System.ComponentModel.DataAnnotations;
namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int Id {get; set;} // Primary Key 
        public string Title {get; set;}

        [DataType(DataType.Date)] // specifies the type of data, with this a user
                                  // is not required to enter time information in the data field
        public DateTime ReleaseDate { get; set;}
        public string Genre { get; set;}
        public decimal Price { get; set;}

    }
}
