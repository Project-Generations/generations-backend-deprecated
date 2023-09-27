﻿using System.ComponentModel.DataAnnotations;

namespace Generations.DA.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool IsHeldItem { get; set; }
    }
}
