﻿using static System.Formats.Asn1.AsnWriter;

namespace UserApplication.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Place { get; set; }
        public string? VideoLink { get; set; }

        //elk product heeft een lijst met meerdere leveranciers, voor nu kan die ook leeg zijn (Many to many)
        // https://www.learnentityframeworkcore.com/configuration/many-to-many-relationship-configuration
        public ICollection<Store>? Stores { get; set; }

        ////every product has one image (One To One)
        public Image ProductImage { get; set; }
    }
}
