
#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public enum StepExecutionStatus
    {
        /// <summary>
        ///
        /// </summary>
        Completed,
        /// <summary>
        ///
        /// </summary>
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StepExecutionStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StepExecutionStatus value)
        {
            return value switch
            {
                StepExecutionStatus.Completed => "COMPLETED",
                StepExecutionStatus.Pending => "PENDING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StepExecutionStatus? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETED" => StepExecutionStatus.Completed,
                "PENDING" => StepExecutionStatus.Pending,
                _ => null,
            };
        }
    }
}