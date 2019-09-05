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
        }
    }
}
