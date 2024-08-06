using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AttackServer
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            
            //string filepatth = await Getfile("C:\\Users\\benio\\OneDrive\\שולחן העבודה\\idf\\exemple.txt");
            //Console.WriteLine(filepatth);
            //Console.WriteLine(await GetData("My name is beni and i live in beiter elit and i sarving in I.D.F "));

            //Console.ReadLine();

            Task<string> taskA = GetDataFromServicAAsync();

            Task<string> taskB = GetDataFromServicBAsync();

            await Task.WhenAll(taskA, taskB);

            Console.WriteLine($"{taskA.Result}");
            Console.WriteLine($"{taskB.Result}");
            Console.ReadLine();

        }
      
        public static async Task<string> GetData(string data)
        {
            await Task.Delay(2000); 
            return data;
        }

        public static async Task<string> Getfile(string filedata)
        {
            await Task.Delay(2000);
            string text = await Task.Run(() => File.ReadAllText(filedata));
            return text;


        }

        public static async Task<string> GetDataFromServicAAsync( )
        {
            await Task.Delay(6000);
           
            return " data A";
        }
        public static async Task<string> GetDataFromServicBAsync()
        {
            await Task.Delay(1000);
            
            return "Data B";
        }


    }
}
