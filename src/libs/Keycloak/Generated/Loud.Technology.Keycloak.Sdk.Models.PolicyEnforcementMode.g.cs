
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public enum PolicyEnforcementMode
    {
        /// <summary>
        ///
        /// </summary>
        Disabled,
        /// <summary>
        ///
        /// </summary>
        Enforcing,
        /// <summary>
        ///
        /// </summary>
        Permissive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PolicyEnforcementModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PolicyEnforcementMode value)
        {
            return value switch
            {
                PolicyEnforcementMode.Disabled => "DISABLED",
                PolicyEnforcementMode.Enforcing => "ENFORCING",
                PolicyEnforcementMode.Permissive => "PERMISSIVE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PolicyEnforcementMode? ToEnum(string value)
        {
            return value switch
            {
                "DISABLED" => PolicyEnforcementMode.Disabled,
                "ENFORCING" => PolicyEnforcementMode.Enforcing,
                "PERMISSIVE" => PolicyEnforcementMode.Permissive,
                _ => null,
            };
        }
    }
}