using App.Backend.Enumerable;
using System.Collections.Generic;

namespace App.Backend.Models
{
    public class Amount : Entity
    {
        public decimal Value { get; set; }
        public WeightUnit Unit { get; set; }

        public virtual List<Ingredient> Ingredients { get; set; }
    }
}