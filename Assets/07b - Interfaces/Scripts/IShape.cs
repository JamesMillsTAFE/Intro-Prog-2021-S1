// Interfaces are blueprints for properties and functions
// The standard is to name them with a starting capital 'I'
// They cannot have any functionality within them as everything
// is technically abstract.
public interface IShape
{
    float Height { get; }
    float Width { get; }
    string Name { get; }
}
