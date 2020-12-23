/* 
 * Adyen Checkout API
 *
 * Adyen Checkout API provides a simple and flexible way to initiate and authorise online payments. You can use the same integration for payments made with cards (including 3D Secure), mobile wallets, and local payment methods (for example, iDEAL and Sofort).  This API reference provides information on available endpoints and how to interact with them. To learn more about the API, visit [Checkout documentation](https://docs.adyen.com/checkout).  ## Authentication Each request to the Checkout API must be signed with an API key. For this, obtain an API Key from your Customer Area, as described in [How to get the API key](https://docs.adyen.com/development-resources/api-credentials#generate-api-key). Then set this key to the `X-API-Key` header value, for example:  ``` curl -H \"Content-Type: application/json\" \\ -H \"X-API-Key: Your_Checkout_API_key\" \\ ... ``` Note that when going live, you need to generate a new API Key to access the [live endpoints](https://docs.adyen.com/development-resources/live-endpoints).  ## Versioning Checkout API supports versioning of its endpoints through a version suffix in the endpoint URL. This suffix has the following format: \"vXX\", where XX is the version number.  For example: ``` https://checkout-test.adyen.com/v66/payments ```
 *
 * OpenAPI spec version: 66
 * Contact: developer-experience@adyen.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// CheckoutOneTimePasscodeAction
    /// </summary>
    [DataContract]
        public partial class CheckoutOneTimePasscodeAction :  IEquatable<CheckoutOneTimePasscodeAction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutOneTimePasscodeAction" /> class.
        /// </summary>
        /// <param name="paymentData">When non-empty, contains a value that you must submit to the &#x60;/payments/details&#x60; endpoint. In some cases, required for polling..</param>
        /// <param name="paymentMethodType">Specifies the payment method..</param>
        /// <param name="redirect">redirect.</param>
        /// <param name="resendInterval">The interval in second between OTP resend..</param>
        /// <param name="resendMaxAttempts">The maximum number of OTP resend attempts..</param>
        /// <param name="resendUrl">The URL, to which you make POST request to trigger OTP resend..</param>
        /// <param name="url">Specifies the URL to redirect to..</param>
        public CheckoutOneTimePasscodeAction(string paymentData = default(string), string paymentMethodType = default(string), Redirect redirect = default(Redirect), int? resendInterval = default(int?), int? resendMaxAttempts = default(int?), string resendUrl = default(string), string url = default(string))
        {
            this.PaymentData = paymentData;
            this.PaymentMethodType = paymentMethodType;
            this.Redirect = redirect;
            this.ResendInterval = resendInterval;
            this.ResendMaxAttempts = resendMaxAttempts;
            this.ResendUrl = resendUrl;
            this.Url = url;
        }
        
        /// <summary>
        /// When non-empty, contains a value that you must submit to the &#x60;/payments/details&#x60; endpoint. In some cases, required for polling.
        /// </summary>
        /// <value>When non-empty, contains a value that you must submit to the &#x60;/payments/details&#x60; endpoint. In some cases, required for polling.</value>
        [DataMember(Name="paymentData", EmitDefaultValue=false)]
        public string PaymentData { get; set; }

        /// <summary>
        /// Specifies the payment method.
        /// </summary>
        /// <value>Specifies the payment method.</value>
        [DataMember(Name="paymentMethodType", EmitDefaultValue=false)]
        public string PaymentMethodType { get; set; }

        /// <summary>
        /// Gets or Sets Redirect
        /// </summary>
        [DataMember(Name="redirect", EmitDefaultValue=false)]
        public Redirect Redirect { get; set; }

        /// <summary>
        /// The interval in second between OTP resend.
        /// </summary>
        /// <value>The interval in second between OTP resend.</value>
        [DataMember(Name="resendInterval", EmitDefaultValue=false)]
        public int? ResendInterval { get; set; }

        /// <summary>
        /// The maximum number of OTP resend attempts.
        /// </summary>
        /// <value>The maximum number of OTP resend attempts.</value>
        [DataMember(Name="resendMaxAttempts", EmitDefaultValue=false)]
        public int? ResendMaxAttempts { get; set; }

        /// <summary>
        /// The URL, to which you make POST request to trigger OTP resend.
        /// </summary>
        /// <value>The URL, to which you make POST request to trigger OTP resend.</value>
        [DataMember(Name="resendUrl", EmitDefaultValue=false)]
        public string ResendUrl { get; set; }

        /// <summary>
        /// Specifies the URL to redirect to.
        /// </summary>
        /// <value>Specifies the URL to redirect to.</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckoutOneTimePasscodeAction {\n");
            sb.Append("  PaymentData: ").Append(PaymentData).Append("\n");
            sb.Append("  PaymentMethodType: ").Append(PaymentMethodType).Append("\n");
            sb.Append("  Redirect: ").Append(Redirect).Append("\n");
            sb.Append("  ResendInterval: ").Append(ResendInterval).Append("\n");
            sb.Append("  ResendMaxAttempts: ").Append(ResendMaxAttempts).Append("\n");
            sb.Append("  ResendUrl: ").Append(ResendUrl).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CheckoutOneTimePasscodeAction);
        }

        /// <summary>
        /// Returns true if CheckoutOneTimePasscodeAction instances are equal
        /// </summary>
        /// <param name="input">Instance of CheckoutOneTimePasscodeAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CheckoutOneTimePasscodeAction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PaymentData == input.PaymentData ||
                    (this.PaymentData != null &&
                    this.PaymentData.Equals(input.PaymentData))
                ) && 
                (
                    this.PaymentMethodType == input.PaymentMethodType ||
                    (this.PaymentMethodType != null &&
                    this.PaymentMethodType.Equals(input.PaymentMethodType))
                ) && 
                (
                    this.Redirect == input.Redirect ||
                    (this.Redirect != null &&
                    this.Redirect.Equals(input.Redirect))
                ) && 
                (
                    this.ResendInterval == input.ResendInterval ||
                    (this.ResendInterval != null &&
                    this.ResendInterval.Equals(input.ResendInterval))
                ) && 
                (
                    this.ResendMaxAttempts == input.ResendMaxAttempts ||
                    (this.ResendMaxAttempts != null &&
                    this.ResendMaxAttempts.Equals(input.ResendMaxAttempts))
                ) && 
                (
                    this.ResendUrl == input.ResendUrl ||
                    (this.ResendUrl != null &&
                    this.ResendUrl.Equals(input.ResendUrl))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.PaymentData != null)
                    hashCode = hashCode * 59 + this.PaymentData.GetHashCode();
                if (this.PaymentMethodType != null)
                    hashCode = hashCode * 59 + this.PaymentMethodType.GetHashCode();
                if (this.Redirect != null)
                    hashCode = hashCode * 59 + this.Redirect.GetHashCode();
                if (this.ResendInterval != null)
                    hashCode = hashCode * 59 + this.ResendInterval.GetHashCode();
                if (this.ResendMaxAttempts != null)
                    hashCode = hashCode * 59 + this.ResendMaxAttempts.GetHashCode();
                if (this.ResendUrl != null)
                    hashCode = hashCode * 59 + this.ResendUrl.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
