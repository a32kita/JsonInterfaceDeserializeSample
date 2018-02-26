using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace Sample.TestClasses
{
    [JsonConverter(typeof(TestClassConverter))]
    public interface ITestClass
    {
        string TargetType
        {
            get;
            set;
        }
    }
}
