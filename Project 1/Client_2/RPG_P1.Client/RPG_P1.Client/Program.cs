using RPG_P1.Client;
using System.Text.Json;

namespace TrainingAPI.App
{
    class Program
    {
        // Fields
        public static readonly HttpClient client = new HttpClient();
        public static string uri = "https://localhost:7230/api/Actor";


        // Methods
        static async Task Main()
        {
            string response = await client.GetStringAsync(uri);


            List<Actor> characters = JsonSerializer.Deserialize<List<Actor>>(response);

            foreach (var item in characters)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}