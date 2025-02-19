namespace Flattening;

public class Flattener
{
    public static List<string> Flatten(IEnumerable<object> notFlat)
    {
        var flat = FlattenItems(notFlat);
        return flat;
    }

    private static List<string> FlattenItems(IEnumerable<object> items)
    {
        var listOfStrings = new List<string>() { };
        foreach (var item in items)
        {
            if (item is string)
            {
                listOfStrings.Add(item.ToString() ?? "");
            }
            else
            {
                listOfStrings.AddRange(FlattenItems(item as IEnumerable<object> ?? Array.Empty<object>()));
            }
        }

        return listOfStrings;
    }
}