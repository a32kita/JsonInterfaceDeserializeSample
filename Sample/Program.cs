using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

using Sample.TestClasses;

namespace Sample
{
    public static class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Console.WriteLine("シリアライズします;");
            
            // Serialize
            // Object instance => JSON data
            ITestClass serializeTarget = new Alpha();
            string jsonData = JsonConvert.SerializeObject(serializeTarget);
            Console.WriteLine(jsonData);

            Console.WriteLine();
            Console.WriteLine("キーを押すと続行します...");
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine("デシリアライズします;");

            // Deserialize
            // JSON data => Object instance
            ITestClass deserializeResult = JsonConvert.DeserializeObject<ITestClass>(jsonData);

            Console.WriteLine("成功しました!!");
            Console.ReadKey();
        }
    }
}
