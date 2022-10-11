﻿using System;

namespace ProductСompany.DTO
{
    public class ProductDTO
    {
        public string ProductName { get; set; }
        public int ProductID { get; set; }
        public int SupplierID { get; set; }
        public int CategoryID { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsOnOnder { get; set; }
        public bool Discontinued { get; set; }
        public string Description { get; set; }
        public DateTime RowInsertTime { get; set; }
        public DateTime RowUpdateTime { get; set; }

    }
}
