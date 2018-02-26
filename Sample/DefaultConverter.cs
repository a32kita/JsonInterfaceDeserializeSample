using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace Sample
{
    public class DefaultConverter : JsonConverter
    {
        // 公開プロパティ

        public override bool CanRead
        {
            get => false;
        }

        public override bool CanWrite
        {
            get => false;
        }


        // 公開メソッド

        public override bool CanConvert(Type objectType)
        {
            return false;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
