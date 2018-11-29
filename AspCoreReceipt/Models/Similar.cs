namespace App.Backend.Models
{
    public class Similar<T>
    {
        public T Object { get; set; }
        public decimal Percentage { get; set; }
        public bool Same { get; set; }
    }
}