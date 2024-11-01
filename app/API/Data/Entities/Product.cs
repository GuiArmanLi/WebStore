namespace Produtos.Data.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Describe { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"Id {Id} Name {Name} Describe {Describe} Price {Price}";
        }
    }
}