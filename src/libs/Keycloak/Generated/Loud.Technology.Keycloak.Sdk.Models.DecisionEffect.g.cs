
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public enum DecisionEffect
    {
        /// <summary>
        ///
        /// </summary>
        Deny,
        /// <summary>
        ///
        /// </summary>
        Permit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DecisionEffectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DecisionEffect value)
        {
            return value switch
            {
                DecisionEffect.Deny => "DENY",
                DecisionEffect.Permit => "PERMIT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DecisionEffect? ToEnum(string value)
        {
            return value switch
            {
                "DENY" => DecisionEffect.Deny,
                "PERMIT" => DecisionEffect.Permit,
                _ => null,
            };
        }
    }
}