
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public enum DecisionStrategy
    {
        /// <summary>
        ///
        /// </summary>
        Affirmative,
        /// <summary>
        ///
        /// </summary>
        Consensus,
        /// <summary>
        ///
        /// </summary>
        Unanimous,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DecisionStrategyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DecisionStrategy value)
        {
            return value switch
            {
                DecisionStrategy.Affirmative => "AFFIRMATIVE",
                DecisionStrategy.Consensus => "CONSENSUS",
                DecisionStrategy.Unanimous => "UNANIMOUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DecisionStrategy? ToEnum(string value)
        {
            return value switch
            {
                "AFFIRMATIVE" => DecisionStrategy.Affirmative,
                "CONSENSUS" => DecisionStrategy.Consensus,
                "UNANIMOUS" => DecisionStrategy.Unanimous,
                _ => null,
            };
        }
    }
}