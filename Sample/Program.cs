using ErgozBuilderLib;
using Sample.Models;

namespace Sample
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var person = ErgozBuilder.CreateItem(new Person());

			Console.WriteLine(person.ToString());
		}
	}
}