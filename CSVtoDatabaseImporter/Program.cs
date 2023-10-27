using CSVtoDatabaseImporter.Data;

public class Program
{
    public static void Main(string[] args)
    {
        //using(StreamReader stream = new StreamReader(""path))
        //{

        //}
        using(var context = new DatabaseContextFactory().CreateDbContext(args))
        {

        }
        
        Console.WriteLine("stop");
    }
}


