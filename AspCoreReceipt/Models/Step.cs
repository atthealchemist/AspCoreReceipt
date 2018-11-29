using System;

namespace App.Backend.Models
{
    public class Step : Entity
    {
        public int Number { get; set; }
        public Duration Duration { get; set; }
        public string Description { get; set; }
        public bool Completed { get; set; } = false;

        public virtual Receipt Receipt { get; set; }
    }
}