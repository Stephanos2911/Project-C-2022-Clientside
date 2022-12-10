﻿namespace UserApplication.Models
{
    public class Store
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string SiteLink { get; set; }

        public ICollection<Product>? Products { get; set; }

        //every image is related to one product (One To One)
        public byte[] StoreLogo { get; set; }
    }
}
