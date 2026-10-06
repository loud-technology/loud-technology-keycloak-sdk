
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public enum UnmanagedAttributePolicy
    {
        /// <summary>
        ///
        /// </summary>
        AdminEdit,
        /// <summary>
        ///
        /// </summary>
        AdminView,
        /// <summary>
        ///
        /// </summary>
        Enabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnmanagedAttributePolicyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnmanagedAttributePolicy value)
        {
            return value switch
            {
                UnmanagedAttributePolicy.AdminEdit => "ADMIN_EDIT",
                UnmanagedAttributePolicy.AdminView => "ADMIN_VIEW",
                UnmanagedAttributePolicy.Enabled => "ENABLED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnmanagedAttributePolicy? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN_EDIT" => UnmanagedAttributePolicy.AdminEdit,
                "ADMIN_VIEW" => UnmanagedAttributePolicy.AdminView,
                "ENABLED" => UnmanagedAttributePolicy.Enabled,
                _ => null,
            };
        }
    }
}