using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;


namespace Movie4Free.Models
{
    public class MovieGenreViewModel
    {
        public List <Movie>? Movies { get; set; }
        public SelectList? Genre { get; set; }
        public string? MovieGenre { get; set; }
        public string? SearchString { get; set; }
    }
}
