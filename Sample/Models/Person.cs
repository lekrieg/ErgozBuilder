namespace Sample.Models;

public class Person
{
	public string Name { get; set; }
	public string Phone { get; set; }
	public string Email { get; set; }
	public Address Address { get; set; }

	public override string ToString()
	{
		return $"Name: {Name}, Phone: {Phone},\nEmail: {Email},\nAddress:\n{Address}";
	}
}
