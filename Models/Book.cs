﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace Ilie_Adrian_Laurentiu_Lab2.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int? AuthorID { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }

        public Author? Author { get; set; }

        public ICollection<Order>? Orders { get; set; }
        public ICollection<PublishedBook>? PublishedBooks { get; set; }
    }
}
