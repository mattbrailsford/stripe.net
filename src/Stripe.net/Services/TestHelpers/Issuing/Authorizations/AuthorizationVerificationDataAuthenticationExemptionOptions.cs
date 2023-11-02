// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using Newtonsoft.Json;

    public class AuthorizationVerificationDataAuthenticationExemptionOptions : INestedOptions
    {
        /// <summary>
        /// The entity that requested the exemption, either the acquiring merchant or the Issuing
        /// user.
        /// One of: <c>acquirer</c>, or <c>issuer</c>.
        /// </summary>
        [JsonProperty("claimed_by")]
        public string ClaimedBy { get; set; }

        /// <summary>
        /// The specific exemption claimed for this authorization.
        /// One of: <c>low_value_transaction</c>, or <c>transaction_risk_analysis</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}