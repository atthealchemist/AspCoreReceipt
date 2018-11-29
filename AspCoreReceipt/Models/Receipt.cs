using System.Collections.Generic;

namespace App.Backend.Models
{
    public class Receipt : Entity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public virtual List<Image> Images { get; set; }
        public virtual Duration CookingTime { get; set; }
        public virtual List<Ingredient> Ingredients { get; set; }
        public virtual List<Step> Steps { get; set; }

    }
}