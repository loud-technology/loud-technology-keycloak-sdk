#nullable enable

namespace Loud.Technology.Keycloak.Sdk.JsonConverters
{
    /// <inheritdoc />
    public sealed class DecisionEffectNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Loud.Technology.Keycloak.Sdk.DecisionEffect?>
    {
        /// <inheritdoc />
        public override global::Loud.Technology.Keycloak.Sdk.DecisionEffect? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Loud.Technology.Keycloak.Sdk.DecisionEffectExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Loud.Technology.Keycloak.Sdk.DecisionEffect)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Loud.Technology.Keycloak.Sdk.DecisionEffect?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Loud.Technology.Keycloak.Sdk.DecisionEffect? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Loud.Technology.Keycloak.Sdk.DecisionEffectExtensions.ToValueString(value.Value));
            }
        }
    }
}
