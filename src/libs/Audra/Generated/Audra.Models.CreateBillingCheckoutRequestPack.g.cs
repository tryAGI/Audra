
#nullable enable

namespace Audra
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateBillingCheckoutRequestPack
    {
        /// <summary>
        /// 
        /// </summary>
        Credits100,
        /// <summary>
        /// 
        /// </summary>
        Credits20,
        /// <summary>
        /// 
        /// </summary>
        Credits5,
        /// <summary>
        /// 
        /// </summary>
        Credits50,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateBillingCheckoutRequestPackExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateBillingCheckoutRequestPack value)
        {
            return value switch
            {
                CreateBillingCheckoutRequestPack.Credits100 => "credits_100",
                CreateBillingCheckoutRequestPack.Credits20 => "credits_20",
                CreateBillingCheckoutRequestPack.Credits5 => "credits_5",
                CreateBillingCheckoutRequestPack.Credits50 => "credits_50",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateBillingCheckoutRequestPack? ToEnum(string value)
        {
            return value switch
            {
                "credits_100" => CreateBillingCheckoutRequestPack.Credits100,
                "credits_20" => CreateBillingCheckoutRequestPack.Credits20,
                "credits_5" => CreateBillingCheckoutRequestPack.Credits5,
                "credits_50" => CreateBillingCheckoutRequestPack.Credits50,
                _ => null,
            };
        }
    }
}