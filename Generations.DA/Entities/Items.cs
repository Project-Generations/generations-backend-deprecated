﻿using System.ComponentModel.DataAnnotations;

namespace Generations.DA.Entities
{
    public class Items
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool IsHeldItem { get; set; }
    }
}
