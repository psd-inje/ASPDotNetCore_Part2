namespace DotNetNote.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int SuperCategory { get; set; }
        public int Align { get; set; }

    }
}
