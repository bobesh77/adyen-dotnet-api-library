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
    /// KlarnaDetails
    /// </summary>
    [DataContract]
        public partial class KlarnaDetails :  IEquatable<KlarnaDetails>, IValidatableObject
    {
        /// <summary>
        /// **klarna**
        /// </summary>
        /// <value>**klarna**</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum
        {
            /// <summary>
            /// Enum Klarna for value: klarna
            /// </summary>
            [EnumMember(Value = "klarna")]
            Klarna = 1,
            /// <summary>
            /// Enum Klarnapayments for value: klarnapayments
            /// </summary>
            [EnumMember(Value = "klarnapayments")]
            Klarnapayments = 2,
            /// <summary>
            /// Enum Klarnapaymentsaccount for value: klarnapayments_account
            /// </summary>
            [EnumMember(Value = "klarnapayments_account")]
            Klarnapaymentsaccount = 3,
            /// <summary>
            /// Enum Klarnapaymentsb2b for value: klarnapayments_b2b
            /// </summary>
            [EnumMember(Value = "klarnapayments_b2b")]
            Klarnapaymentsb2b = 4,
            /// <summary>
            /// Enum Klarnapaynow for value: klarna_paynow
            /// </summary>
            [EnumMember(Value = "klarna_paynow")]
            Klarnapaynow = 5,
            /// <summary>
            /// Enum Klarnaaccount for value: klarna_account
            /// </summary>
            [EnumMember(Value = "klarna_account")]
            Klarnaaccount = 6,
            /// <summary>
            /// Enum Klarnab2b for value: klarna_b2b
            /// </summary>
            [EnumMember(Value = "klarna_b2b")]
            Klarnab2b = 7        }
        /// <summary>
        /// **klarna**
        /// </summary>
        /// <value>**klarna**</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KlarnaDetails" /> class.
        /// </summary>
        /// <param name="bankAccount">bankAccount.</param>
        /// <param name="billingAddress">billingAddress.</param>
        /// <param name="deliveryAddress">deliveryAddress.</param>
        /// <param name="installmentConfigurationKey">installmentConfigurationKey.</param>
        /// <param name="personalDetails">personalDetails.</param>
        /// <param name="recurringDetailReference">This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token..</param>
        /// <param name="separateDeliveryAddress">separateDeliveryAddress.</param>
        /// <param name="storedPaymentMethodId">This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token..</param>
        /// <param name="type">**klarna** (required) (default to TypeEnum.Klarna).</param>
        public KlarnaDetails(string bankAccount = default(string), string billingAddress = default(string), string deliveryAddress = default(string), string installmentConfigurationKey = default(string), string personalDetails = default(string), string recurringDetailReference = default(string), string separateDeliveryAddress = default(string), string storedPaymentMethodId = default(string), TypeEnum type = TypeEnum.Klarna)
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for KlarnaDetails and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            this.BankAccount = bankAccount;
            this.BillingAddress = billingAddress;
            this.DeliveryAddress = deliveryAddress;
            this.InstallmentConfigurationKey = installmentConfigurationKey;
            this.PersonalDetails = personalDetails;
            this.RecurringDetailReference = recurringDetailReference;
            this.SeparateDeliveryAddress = separateDeliveryAddress;
            this.StoredPaymentMethodId = storedPaymentMethodId;
        }
        
        /// <summary>
        /// Gets or Sets BankAccount
        /// </summary>
        [DataMember(Name="bankAccount", EmitDefaultValue=false)]
        public string BankAccount { get; set; }

        /// <summary>
        /// Gets or Sets BillingAddress
        /// </summary>
        [DataMember(Name="billingAddress", EmitDefaultValue=false)]
        public string BillingAddress { get; set; }

        /// <summary>
        /// Gets or Sets DeliveryAddress
        /// </summary>
        [DataMember(Name="deliveryAddress", EmitDefaultValue=false)]
        public string DeliveryAddress { get; set; }

        /// <summary>
        /// Gets or Sets InstallmentConfigurationKey
        /// </summary>
        [DataMember(Name="installmentConfigurationKey", EmitDefaultValue=false)]
        public string InstallmentConfigurationKey { get; set; }

        /// <summary>
        /// Gets or Sets PersonalDetails
        /// </summary>
        [DataMember(Name="personalDetails", EmitDefaultValue=false)]
        public string PersonalDetails { get; set; }

        /// <summary>
        /// This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token.
        /// </summary>
        /// <value>This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token.</value>
        [DataMember(Name="recurringDetailReference", EmitDefaultValue=false)]
        public string RecurringDetailReference { get; set; }

        /// <summary>
        /// Gets or Sets SeparateDeliveryAddress
        /// </summary>
        [DataMember(Name="separateDeliveryAddress", EmitDefaultValue=false)]
        public string SeparateDeliveryAddress { get; set; }

        /// <summary>
        /// This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token.
        /// </summary>
        /// <value>This is the &#x60;recurringDetailReference&#x60; returned in the response when you created the token.</value>
        [DataMember(Name="storedPaymentMethodId", EmitDefaultValue=false)]
        public string StoredPaymentMethodId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KlarnaDetails {\n");
            sb.Append("  BankAccount: ").Append(BankAccount).Append("\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  DeliveryAddress: ").Append(DeliveryAddress).Append("\n");
            sb.Append("  InstallmentConfigurationKey: ").Append(InstallmentConfigurationKey).Append("\n");
            sb.Append("  PersonalDetails: ").Append(PersonalDetails).Append("\n");
            sb.Append("  RecurringDetailReference: ").Append(RecurringDetailReference).Append("\n");
            sb.Append("  SeparateDeliveryAddress: ").Append(SeparateDeliveryAddress).Append("\n");
            sb.Append("  StoredPaymentMethodId: ").Append(StoredPaymentMethodId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as KlarnaDetails);
        }

        /// <summary>
        /// Returns true if KlarnaDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of KlarnaDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KlarnaDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BankAccount == input.BankAccount ||
                    (this.BankAccount != null &&
                    this.BankAccount.Equals(input.BankAccount))
                ) && 
                (
                    this.BillingAddress == input.BillingAddress ||
                    (this.BillingAddress != null &&
                    this.BillingAddress.Equals(input.BillingAddress))
                ) && 
                (
                    this.DeliveryAddress == input.DeliveryAddress ||
                    (this.DeliveryAddress != null &&
                    this.DeliveryAddress.Equals(input.DeliveryAddress))
                ) && 
                (
                    this.InstallmentConfigurationKey == input.InstallmentConfigurationKey ||
                    (this.InstallmentConfigurationKey != null &&
                    this.InstallmentConfigurationKey.Equals(input.InstallmentConfigurationKey))
                ) && 
                (
                    this.PersonalDetails == input.PersonalDetails ||
                    (this.PersonalDetails != null &&
                    this.PersonalDetails.Equals(input.PersonalDetails))
                ) && 
                (
                    this.RecurringDetailReference == input.RecurringDetailReference ||
                    (this.RecurringDetailReference != null &&
                    this.RecurringDetailReference.Equals(input.RecurringDetailReference))
                ) && 
                (
                    this.SeparateDeliveryAddress == input.SeparateDeliveryAddress ||
                    (this.SeparateDeliveryAddress != null &&
                    this.SeparateDeliveryAddress.Equals(input.SeparateDeliveryAddress))
                ) && 
                (
                    this.StoredPaymentMethodId == input.StoredPaymentMethodId ||
                    (this.StoredPaymentMethodId != null &&
                    this.StoredPaymentMethodId.Equals(input.StoredPaymentMethodId))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.BankAccount != null)
                    hashCode = hashCode * 59 + this.BankAccount.GetHashCode();
                if (this.BillingAddress != null)
                    hashCode = hashCode * 59 + this.BillingAddress.GetHashCode();
                if (this.DeliveryAddress != null)
                    hashCode = hashCode * 59 + this.DeliveryAddress.GetHashCode();
                if (this.InstallmentConfigurationKey != null)
                    hashCode = hashCode * 59 + this.InstallmentConfigurationKey.GetHashCode();
                if (this.PersonalDetails != null)
                    hashCode = hashCode * 59 + this.PersonalDetails.GetHashCode();
                if (this.RecurringDetailReference != null)
                    hashCode = hashCode * 59 + this.RecurringDetailReference.GetHashCode();
                if (this.SeparateDeliveryAddress != null)
                    hashCode = hashCode * 59 + this.SeparateDeliveryAddress.GetHashCode();
                if (this.StoredPaymentMethodId != null)
                    hashCode = hashCode * 59 + this.StoredPaymentMethodId.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
