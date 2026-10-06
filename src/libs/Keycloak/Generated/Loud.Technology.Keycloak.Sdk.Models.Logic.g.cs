
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public enum Logic
    {
        /// <summary>
        ///
        /// </summary>
        Negative,
        /// <summary>
        ///
        /// </summary>
        Positive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LogicExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Logic value)
        {
            return value switch
            {
                Logic.Negative => "NEGATIVE",
                Logic.Positive => "POSITIVE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Logic? ToEnum(string value)
        {
            return value switch
            {
                "NEGATIVE" => Logic.Negative,
                "POSITIVE" => Logic.Positive,
                _ => null,
            };
        }
    }
}