namespace ScondDemoModels.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }//"?-->to allow null use questin mark

        public int Price { get; set; }
    }
}
