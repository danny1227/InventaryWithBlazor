﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class StorageEntity
    {
        [Key]
        [StringLength(50)]
        public string StorageId { get; set; }
        [Required]
        public DateTime LastUpdate { get; set; }
        [Required]
        public int PartialQuantity { get; set; }
        //Relación con productos (ProductEntity)
        public string ProductId { get; set; }
        public ProductEntity Product { get; set; }
        //Relación con almacenes (WherehouseEntity)
        public string WarehouseId { get; set; }
        public WarehouseEntity Warehouse { get; set; }
        //Relación con entradas y salidas (InputOutputEntity)
        public ICollection<InputOutputEntity> InputOutputs { get; set; }

    }
}
