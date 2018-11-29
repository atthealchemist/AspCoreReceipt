using System.Collections.Generic;

namespace App.Backend.Models
{
    public class Ingredient : Entity
    {
        public string Title { get; set; }
        //public List<Possible<Ingredient>> PossibleReplacement { get; set; }
        public List<Image> Images { get; set; }

        public virtual Amount Amount { get; set; }
        public virtual List<Receipt> Receipts { get; set; }
    }
}