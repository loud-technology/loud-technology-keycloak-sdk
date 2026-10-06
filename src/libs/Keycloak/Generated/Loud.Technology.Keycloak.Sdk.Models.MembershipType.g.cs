
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public enum MembershipType
    {
        /// <summary>
        ///
        /// </summary>
        Managed,
        /// <summary>
        ///
        /// </summary>
        Unmanaged,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MembershipTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MembershipType value)
        {
            return value switch
            {
                MembershipType.Managed => "MANAGED",
                MembershipType.Unmanaged => "UNMANAGED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MembershipType? ToEnum(string value)
        {
            return value switch
            {
                "MANAGED" => MembershipType.Managed,
                "UNMANAGED" => MembershipType.Unmanaged,
                _ => null,
            };
        }
    }
}