namespace ErgozBuilderLib;

public class ErgozBuilder
{
	public static T CreateItem<T>(T someType)
	where T : new()
	{
		var pis = someType!.GetType().GetProperties();
		foreach (var pi in pis)
		{
			if (pi.PropertyType == typeof(int))
			{
				pi.SetValue(someType, Faker.RandomNumber.Next(0, 500));
			}
			else if (pi.PropertyType == typeof(string))
			{
				pi.SetValue(someType, Faker.Lorem.GetFirstWord());
			}
			else if (pi.PropertyType == typeof(bool))
			{
				pi.SetValue(someType, Faker.Boolean.Random());
			}
			else if (pi.PropertyType.IsInterface)
			{
				continue;
			}
			else if (pi.PropertyType.IsGenericType)
			{
				continue;
			}
			else if (pi.PropertyType.IsEnum)
			{
				continue;
			}
			else
			{
				var y = Activator.CreateInstance(type: pi.PropertyType);
				var foo = CreateItem(y);
				pi.SetValue(someType, foo);
			}
		}

		return someType;
	}
}