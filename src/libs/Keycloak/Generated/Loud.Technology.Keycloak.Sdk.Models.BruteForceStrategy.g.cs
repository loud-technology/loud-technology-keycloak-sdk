
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public enum BruteForceStrategy
    {
        /// <summary>
        ///
        /// </summary>
        Linear,
        /// <summary>
        ///
        /// </summary>
        Multiple,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BruteForceStrategyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BruteForceStrategy value)
        {
            return value switch
            {
                BruteForceStrategy.Linear => "LINEAR",
                BruteForceStrategy.Multiple => "MULTIPLE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BruteForceStrategy? ToEnum(string value)
        {
            return value switch
            {
                "LINEAR" => BruteForceStrategy.Linear,
                "MULTIPLE" => BruteForceStrategy.Multiple,
                _ => null,
            };
        }
    }
}