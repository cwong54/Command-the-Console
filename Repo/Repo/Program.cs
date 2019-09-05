using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http; // for the HTTPClient Class
using static System.Console; //for using the static methods of the Console class without having to reference the class name.

namespace Repo
{
   
    class Program
    {
        const string API_BASE = "http://www.gitignore.io/api/";
        const string API_LIST_LINES = API_BASE + "list? format = lines";
        static void Main(string[] args)
        {
            var client = new HttpClient();
            var response = client.GetAsync(API_LIST_LINES).GetAwaiter().GetResult();
            //Will give you an HTTP response object
            //
            if(response.IsSuccessStatusCode)
            {
                var content = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                //So you don't have to use Console.WriteLine
                WriteLine(content);

            }
            //Run do it's job while other code does it's own job
            //Wait for it to complete before get results
            //Do it Async is ONE after another
        }
    }
}
