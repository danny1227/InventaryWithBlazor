﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class WarehouseEntity
    {
        [Key]
        [StringLength(50)]
        public string WarehouseId { get; set; }
        [Required]
        [StringLength(100)] 
        public string WarehouseName { get; set; }
        [Required]
        [MinLength(5)]  
        [MaxLength(600)] 
        public string WherehouseAddress { get; set; }

        //Relación con almacenes (StorageEntity)
        public ICollection<StorageEntity> Storage { get; set; }
    }
}
