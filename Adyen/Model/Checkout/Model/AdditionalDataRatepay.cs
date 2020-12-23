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
    /// AdditionalDataRatepay
    /// </summary>
    [DataContract]
        public partial class AdditionalDataRatepay :  IEquatable<AdditionalDataRatepay>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalDataRatepay" /> class.
        /// </summary>
        /// <param name="ratepayInstallmentAmount">Amount the customer has to pay each month..</param>
        /// <param name="ratepayInterestRate">Interest rate of this installment..</param>
        /// <param name="ratepayLastInstallmentAmount">Amount of the last installment..</param>
        /// <param name="ratepayPaymentFirstday">Calendar day of the first payment..</param>
        /// <param name="ratepaydataDeliveryDate">Date the merchant delivered the goods to the customer..</param>
        /// <param name="ratepaydataDueDate">Date by which the customer must settle the payment..</param>
        /// <param name="ratepaydataInvoiceDate">Invoice date, defined by the merchant. If not included, the invoice date is set to the delivery date..</param>
        /// <param name="ratepaydataInvoiceId">Identification name or number for the invoice, defined by the merchant..</param>
        public AdditionalDataRatepay(string ratepayInstallmentAmount = default(string), string ratepayInterestRate = default(string), string ratepayLastInstallmentAmount = default(string), string ratepayPaymentFirstday = default(string), string ratepaydataDeliveryDate = default(string), string ratepaydataDueDate = default(string), string ratepaydataInvoiceDate = default(string), string ratepaydataInvoiceId = default(string))
        {
            this.RatepayInstallmentAmount = ratepayInstallmentAmount;
            this.RatepayInterestRate = ratepayInterestRate;
            this.RatepayLastInstallmentAmount = ratepayLastInstallmentAmount;
            this.RatepayPaymentFirstday = ratepayPaymentFirstday;
            this.RatepaydataDeliveryDate = ratepaydataDeliveryDate;
            this.RatepaydataDueDate = ratepaydataDueDate;
            this.RatepaydataInvoiceDate = ratepaydataInvoiceDate;
            this.RatepaydataInvoiceId = ratepaydataInvoiceId;
        }
        
        /// <summary>
        /// Amount the customer has to pay each month.
        /// </summary>
        /// <value>Amount the customer has to pay each month.</value>
        [DataMember(Name="ratepay.installmentAmount", EmitDefaultValue=false)]
        public string RatepayInstallmentAmount { get; set; }

        /// <summary>
        /// Interest rate of this installment.
        /// </summary>
        /// <value>Interest rate of this installment.</value>
        [DataMember(Name="ratepay.interestRate", EmitDefaultValue=false)]
        public string RatepayInterestRate { get; set; }

        /// <summary>
        /// Amount of the last installment.
        /// </summary>
        /// <value>Amount of the last installment.</value>
        [DataMember(Name="ratepay.lastInstallmentAmount", EmitDefaultValue=false)]
        public string RatepayLastInstallmentAmount { get; set; }

        /// <summary>
        /// Calendar day of the first payment.
        /// </summary>
        /// <value>Calendar day of the first payment.</value>
        [DataMember(Name="ratepay.paymentFirstday", EmitDefaultValue=false)]
        public string RatepayPaymentFirstday { get; set; }

        /// <summary>
        /// Date the merchant delivered the goods to the customer.
        /// </summary>
        /// <value>Date the merchant delivered the goods to the customer.</value>
        [DataMember(Name="ratepaydata.deliveryDate", EmitDefaultValue=false)]
        public string RatepaydataDeliveryDate { get; set; }

        /// <summary>
        /// Date by which the customer must settle the payment.
        /// </summary>
        /// <value>Date by which the customer must settle the payment.</value>
        [DataMember(Name="ratepaydata.dueDate", EmitDefaultValue=false)]
        public string RatepaydataDueDate { get; set; }

        /// <summary>
        /// Invoice date, defined by the merchant. If not included, the invoice date is set to the delivery date.
        /// </summary>
        /// <value>Invoice date, defined by the merchant. If not included, the invoice date is set to the delivery date.</value>
        [DataMember(Name="ratepaydata.invoiceDate", EmitDefaultValue=false)]
        public string RatepaydataInvoiceDate { get; set; }

        /// <summary>
        /// Identification name or number for the invoice, defined by the merchant.
        /// </summary>
        /// <value>Identification name or number for the invoice, defined by the merchant.</value>
        [DataMember(Name="ratepaydata.invoiceId", EmitDefaultValue=false)]
        public string RatepaydataInvoiceId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdditionalDataRatepay {\n");
            sb.Append("  RatepayInstallmentAmount: ").Append(RatepayInstallmentAmount).Append("\n");
            sb.Append("  RatepayInterestRate: ").Append(RatepayInterestRate).Append("\n");
            sb.Append("  RatepayLastInstallmentAmount: ").Append(RatepayLastInstallmentAmount).Append("\n");
            sb.Append("  RatepayPaymentFirstday: ").Append(RatepayPaymentFirstday).Append("\n");
            sb.Append("  RatepaydataDeliveryDate: ").Append(RatepaydataDeliveryDate).Append("\n");
            sb.Append("  RatepaydataDueDate: ").Append(RatepaydataDueDate).Append("\n");
            sb.Append("  RatepaydataInvoiceDate: ").Append(RatepaydataInvoiceDate).Append("\n");
            sb.Append("  RatepaydataInvoiceId: ").Append(RatepaydataInvoiceId).Append("\n");
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
            return this.Equals(input as AdditionalDataRatepay);
        }

        /// <summary>
        /// Returns true if AdditionalDataRatepay instances are equal
        /// </summary>
        /// <param name="input">Instance of AdditionalDataRatepay to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdditionalDataRatepay input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RatepayInstallmentAmount == input.RatepayInstallmentAmount ||
                    (this.RatepayInstallmentAmount != null &&
                    this.RatepayInstallmentAmount.Equals(input.RatepayInstallmentAmount))
                ) && 
                (
                    this.RatepayInterestRate == input.RatepayInterestRate ||
                    (this.RatepayInterestRate != null &&
                    this.RatepayInterestRate.Equals(input.RatepayInterestRate))
                ) && 
                (
                    this.RatepayLastInstallmentAmount == input.RatepayLastInstallmentAmount ||
                    (this.RatepayLastInstallmentAmount != null &&
                    this.RatepayLastInstallmentAmount.Equals(input.RatepayLastInstallmentAmount))
                ) && 
                (
                    this.RatepayPaymentFirstday == input.RatepayPaymentFirstday ||
                    (this.RatepayPaymentFirstday != null &&
                    this.RatepayPaymentFirstday.Equals(input.RatepayPaymentFirstday))
                ) && 
                (
                    this.RatepaydataDeliveryDate == input.RatepaydataDeliveryDate ||
                    (this.RatepaydataDeliveryDate != null &&
                    this.RatepaydataDeliveryDate.Equals(input.RatepaydataDeliveryDate))
                ) && 
                (
                    this.RatepaydataDueDate == input.RatepaydataDueDate ||
                    (this.RatepaydataDueDate != null &&
                    this.RatepaydataDueDate.Equals(input.RatepaydataDueDate))
                ) && 
                (
                    this.RatepaydataInvoiceDate == input.RatepaydataInvoiceDate ||
                    (this.RatepaydataInvoiceDate != null &&
                    this.RatepaydataInvoiceDate.Equals(input.RatepaydataInvoiceDate))
                ) && 
                (
                    this.RatepaydataInvoiceId == input.RatepaydataInvoiceId ||
                    (this.RatepaydataInvoiceId != null &&
                    this.RatepaydataInvoiceId.Equals(input.RatepaydataInvoiceId))
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
                if (this.RatepayInstallmentAmount != null)
                    hashCode = hashCode * 59 + this.RatepayInstallmentAmount.GetHashCode();
                if (this.RatepayInterestRate != null)
                    hashCode = hashCode * 59 + this.RatepayInterestRate.GetHashCode();
                if (this.RatepayLastInstallmentAmount != null)
                    hashCode = hashCode * 59 + this.RatepayLastInstallmentAmount.GetHashCode();
                if (this.RatepayPaymentFirstday != null)
                    hashCode = hashCode * 59 + this.RatepayPaymentFirstday.GetHashCode();
                if (this.RatepaydataDeliveryDate != null)
                    hashCode = hashCode * 59 + this.RatepaydataDeliveryDate.GetHashCode();
                if (this.RatepaydataDueDate != null)
                    hashCode = hashCode * 59 + this.RatepaydataDueDate.GetHashCode();
                if (this.RatepaydataInvoiceDate != null)
                    hashCode = hashCode * 59 + this.RatepaydataInvoiceDate.GetHashCode();
                if (this.RatepaydataInvoiceId != null)
                    hashCode = hashCode * 59 + this.RatepaydataInvoiceId.GetHashCode();
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
