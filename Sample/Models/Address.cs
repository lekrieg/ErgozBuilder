namespace Sample.Models;

public class Address
{
	public string Street { get; set; }
	public string PostalCode { get; set; }

	public override string ToString()
	{
		return $"\tStreet: {Street},\n\tPostalCode: {PostalCode}";
	}
}
