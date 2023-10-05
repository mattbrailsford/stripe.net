// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodConfigurationSofort : StripeEntity<PaymentMethodConfigurationSofort>
    {
        /// <summary>
        /// Whether this payment method may be offered at checkout. True if
        /// <c>display_preference</c> is <c>on</c> and the payment method's capability is active.
        /// </summary>
        [JsonProperty("available")]
        public bool Available { get; set; }

        [JsonProperty("display_preference")]
        public PaymentMethodConfigurationSofortDisplayPreference DisplayPreference { get; set; }
    }
}