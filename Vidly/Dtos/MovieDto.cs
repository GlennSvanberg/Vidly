﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }

        [Required]
        //[MinNumberInStock]
        public int NumberInStock { get; set; }


        [Required]
        public int GenreId { get; set; }
    }
}