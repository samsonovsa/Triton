namespace Triton.Domain
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public CategoryTypes Type { get; set; }

        public ICollection<Category> Categories { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
