using Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Request
{
    public class ProductRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Barcode { get; set; }
        public byte[] Image { get; set; }
        public string Description { get; set; }
        public decimal Rate { get; set; }
        public int BrandId { get; set; }
        public virtual Brand Brand { get; set; }
    }
}
