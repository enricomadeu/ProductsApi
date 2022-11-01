﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsApi.Application.DTO
{
    public class ProductDTO : BaseDTO
    {
        public string Description { get; set; }
        public bool Situation { get; set; }
        public DateTime FabricationDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string SupplierCode { get; set; }
        public string SupplierDescription { get; set; }
        public string SupplierCNPJ { get; set; }
    }
}
