using System;
//
using System.Collections.Generic;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//

namespace Crawler
{
    class Program
    {
        public async static Task Main(string[] args)
        {
            var websiteUr1 = args[0];

            var list = new List<string>();
            var dictionary = new Dictionary<string, string>();
            var set = new HashSet<string>();

            var httpClient = new HttpClient();

            var response = await httpClient.GetAsync(websiteUr1);
            var content = await response.Content.ReadAsStringAsync();


            var regex = new Regex(@"[await-zA-Z0-9_.+-]+@[a-zA-Z0-9]+\.[a-zA-Z0-9-.=]+");
            var matchCollection = regex.Matches(content);

            foreach (var item in matchCollection)

            {

                Console.WriteLine(item);
            }
        }
    }
}
