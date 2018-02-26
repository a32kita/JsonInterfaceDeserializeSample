using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace Sample.TestClasses
{
    [JsonConverter(typeof(DefaultConverter))]
    public class Alpha : ITestClass
    {
        public string TargetType
        {
            get;
            set;
        }
        
        public Alpha()
        {
            // 型名の代入
            this.TargetType = nameof(Alpha);
        }
    }
}
