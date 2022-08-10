using Data.DTO;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;

namespace API_Connection
{
    public class CharacterRetrival
    {
        // Fields
        public static readonly HttpClient client = new HttpClient();
        public static string uri = "https://localhost:7230/api/Actor";


        // Methods
        public async Task GetCharacter()
        {
            string response = await client.GetStringAsync(uri);


            List<Character> characters = JsonSerializer.Deserialize<List<Character>>(response);

            foreach (var item in characters)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}