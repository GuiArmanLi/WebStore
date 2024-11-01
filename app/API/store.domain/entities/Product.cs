namespace src.store.domain.entities;

public class Product : BaseEntitiy
	{
        public Product()
        {
            
        }

    public Product(string name, string description, List<string> images, List<string>? features,
        List<Comment>? comments, double price)
    {
        this.Name = name;
        this.Description = description;
        this.Images = images;
        this.Features = features ?? new List<string>();
        this.Comments = comments ?? new List<Comment>();
        this.Price = price;
    }

    private string Name { get; set; }
    private string Description { get; set; }
    private List<string> Images { get; init; }
    private List<string> Features { get; init; }
    private double Price { get; set; }
    private List<Comment> Comments { get; init; }
}