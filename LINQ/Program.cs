namespace LINQ
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            
            List<string> videoGamesNames = new List<string>() 
            {"Warzone", "Fortnite", "GrandTheft Auto"};
            videoGamesNames.Add("Ben Ten");
            videoGamesNames.Add("Call Of Duty");

            var ordererdNames = videoGamesNames.OrderByDescending(name => name.Length);
            foreach (var games in ordererdNames)
            {
                Console.WriteLine(games);
            }


           // Console.WriteLine("Hello, World!");
        }
    }
}
