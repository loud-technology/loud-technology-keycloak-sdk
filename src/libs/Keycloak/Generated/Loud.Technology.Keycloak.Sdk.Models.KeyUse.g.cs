
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public enum KeyUse
    {
        /// <summary>
        ///
        /// </summary>
        Enc,
        /// <summary>
        ///
        /// </summary>
        JwtSvid,
        /// <summary>
        ///
        /// </summary>
        Sig,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KeyUseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KeyUse value)
        {
            return value switch
            {
                KeyUse.Enc => "ENC",
                KeyUse.JwtSvid => "JWT_SVID",
                KeyUse.Sig => "SIG",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KeyUse? ToEnum(string value)
        {
            return value switch
            {
                "ENC" => KeyUse.Enc,
                "JWT_SVID" => KeyUse.JwtSvid,
                "SIG" => KeyUse.Sig,
                _ => null,
            };
        }
    }
}