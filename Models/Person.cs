public class Person
{
    public string PersonId { get; set; } = null!;
    public string? Name { get; set; }  // 🔥 Cho phép null
    public string Address { get; set; } = null!;
}
