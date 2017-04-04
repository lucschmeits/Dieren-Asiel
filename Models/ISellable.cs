namespace Models
{
    internal interface ISellable
    {
        string Naam { get; set; }
        decimal Price { get; set; }
    }
}