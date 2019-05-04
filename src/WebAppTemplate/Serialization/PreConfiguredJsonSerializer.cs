using System;
using Dalion.WebAppTemplate.Utils;
using Newtonsoft.Json;

namespace Dalion.WebAppTemplate.Serialization {
    public static class PreConfiguredJsonSerializer {
        public static IJsonSerializer Create() {
            return Create(_ => { });
        }

        public static IJsonSerializer Create(Action<JsonSerializerSettings> modifySettings) {
            var jsonSerializerSettings = PreConfiguredJsonSerializerSettings.Create();
            modifySettings(jsonSerializerSettings);
            return new JsonSerializer(Newtonsoft.Json.JsonSerializer.Create(jsonSerializerSettings));
        }
    }
}
