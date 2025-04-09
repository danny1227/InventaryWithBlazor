﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ProductEntity
    {
        [Key]
        [StringLength(50)]
        public string ProductId { get; set; }
        [Required]
        [StringLength(100)]
        public string ProductName { get; set; }
        [StringLength(600)]
        public string ProductDescription { get; set; }
        public int TotalQuantity { get; set; }
        //Relación con categorias (CategoryEntity)
        public string CategoryId { get; set; }
        public CategoryEntity Category { get; set; }
        //Relación con almacenes (StorageEntity)
        public ICollection<StorageEntity> Storage { get; set; }
    }
}
