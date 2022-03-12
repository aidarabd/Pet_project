using System;
using System.Collections.Generic;
using DBAccess.Models.Base;

namespace DBAccess.Models
{
    public class Recipe : BaseEntity
    {
        public string Name { get; set; }
        public TimeSpan TimeToCook { get; set; }
        public bool IsDeleted { get; set; }
        public int Method { get; set; }

        public bool IsVegetarian { get; set; }
        public bool IsVegan { get; set; }

        public ICollection<Ingredient> Ingredients { get; set; }
    }
}