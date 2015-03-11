using System;
using Newtonsoft.Json.Linq;

namespace ALittleBitOfJson
{
    public class Program
    {
        public void Main(string[] args)
        {
            Console.WriteLine("Here's some JSON:");
            Console.WriteLine(new JObject(
                new JProperty("it's", "json")).ToString());
            Console.ReadLine();
        }
    }
}
