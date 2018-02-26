using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace Sample.TestClasses
{
    /// <summary>
    /// 
    /// </summary>
    public class TestClassConverter : JsonConverter<ITestClass>
    {
        // 公開プロパティ

        /// <summary>
        /// このコンバータが JSON の読み込みに対応しているかどうかを示す値を取得します。
        /// </summary>
        public override bool CanRead
        {
            get => true;
        }

        /// <summary>
        /// このコンバータが JSON の書き込みに対応しているかどうかを示す値を取得します。
        /// </summary>
        public override bool CanWrite
        {
            get => false;
        }


        // コンストラクタ

        /// <summary>
        /// 新しい <see cref="TestClassConverter"/> クラスのインスタンスを初期化します。
        /// </summary>
        public TestClassConverter()
        {
            // 実装なし
        }


        // 公開メソッド

        /// <summary>
        /// JSONデータからインスタンスを作成します。
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="objectType"></param>
        /// <param name="existingValue"></param>
        /// <param name="hasExistingValue"></param>
        /// <param name="serializer"></param>
        /// <returns></returns>
        public override ITestClass ReadJson(JsonReader reader, Type objectType, ITestClass existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            // JSONの中身を読めるようにする
            var tokens = Newtonsoft.Json.Linq.JToken.ReadFrom(reader);

            // TargetTypeの値を取得
            var targetType = tokens["TargetType"].ToString();

            // 型判断
            switch (targetType)
            {
                case nameof(Alpha):
                    return tokens.ToObject<Alpha>();
                case nameof(Beta):
                    return tokens.ToObject<Beta>();
                default:
                    throw new NotSupportedException($"型 {targetType} は {nameof(TestClassConverter)} ではサポートしておりません。");
            }
        }

        /// <summary>
        /// このコンバータではサポートしておりません。
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="value"></param>
        /// <param name="serializer"></param>
        public override void WriteJson(JsonWriter writer, ITestClass value, JsonSerializer serializer)
        {
            // CanWriteがfalseになっており、既定のコンバート処理が為されるため、定義不要。
            throw new NotImplementedException();
        }
    }
}
