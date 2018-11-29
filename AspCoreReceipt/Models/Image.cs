using System.Collections.Generic;

namespace App.Backend.Models
{
    public class Image : Entity
    {
        public string Url { get; set; }
        public string Caption { get; set; }

        public virtual List<Receipt> Receipts { get; set; }
        public virtual List<Ingredient> Ingredients { get; set; }
    }
}