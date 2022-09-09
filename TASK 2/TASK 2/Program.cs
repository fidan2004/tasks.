using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace TASK_2
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            const string Url = "https://catfact.ninja/fact";
            HttpClient client = new HttpClient();
            bool isContinue;
            Console.WriteLine("Fact about cats\n");

            do
            {

                var result = await client.GetStringAsync(Url);
                var CatFact = JsonConvert.DeserializeObject<CatFact>(result);

                Console.WriteLine(CatFact.Fact);
                isContinue = Convert.ToBoolean(Console.ReadLine());
            }


            while (isContinue);
        }


       public class CatFact
        {
            public string Fact { get; set; }
            public string Length { get; set; }
        }
    }
}

