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
    /// MbwayDetails
    /// </summary>
    [DataContract]
        public partial class MbwayDetails :  IEquatable<MbwayDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MbwayDetails" /> class.
        /// </summary>
        /// <param name="shopperEmail">shopperEmail (required).</param>
        /// <param name="telephoneNumber">telephoneNumber (required).</param>
        /// <param name="type">**mbway** (default to &quot;mbway&quot;).</param>
        public MbwayDetails(string shopperEmail = default(string), string telephoneNumber = default(string), string type = "mbway")
        {
            // to ensure "shopperEmail" is required (not null)
            if (shopperEmail == null)
            {
                throw new InvalidDataException("shopperEmail is a required property for MbwayDetails and cannot be null");
            }
            else
            {
                this.ShopperEmail = shopperEmail;
            }
            // to ensure "telephoneNumber" is required (not null)
            if (telephoneNumber == null)
            {
                throw new InvalidDataException("telephoneNumber is a required property for MbwayDetails and cannot be null");
            }
            else
            {
                this.TelephoneNumber = telephoneNumber;
            }
            // use default value if no "type" provided
            if (type == null)
            {
                this.Type = "mbway";
            }
            else
            {
                this.Type = type;
            }
        }
        
        /// <summary>
        /// Gets or Sets ShopperEmail
        /// </summary>
        [DataMember(Name="shopperEmail", EmitDefaultValue=false)]
        public string ShopperEmail { get; set; }

        /// <summary>
        /// Gets or Sets TelephoneNumber
        /// </summary>
        [DataMember(Name="telephoneNumber", EmitDefaultValue=false)]
        public string TelephoneNumber { get; set; }

        /// <summary>
        /// **mbway**
        /// </summary>
        /// <value>**mbway**</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MbwayDetails {\n");
            sb.Append("  ShopperEmail: ").Append(ShopperEmail).Append("\n");
            sb.Append("  TelephoneNumber: ").Append(TelephoneNumber).Append("\n");
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
            return this.Equals(input as MbwayDetails);
        }

        /// <summary>
        /// Returns true if MbwayDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of MbwayDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MbwayDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ShopperEmail == input.ShopperEmail ||
                    (this.ShopperEmail != null &&
                    this.ShopperEmail.Equals(input.ShopperEmail))
                ) && 
                (
                    this.TelephoneNumber == input.TelephoneNumber ||
                    (this.TelephoneNumber != null &&
                    this.TelephoneNumber.Equals(input.TelephoneNumber))
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
                if (this.ShopperEmail != null)
                    hashCode = hashCode * 59 + this.ShopperEmail.GetHashCode();
                if (this.TelephoneNumber != null)
                    hashCode = hashCode * 59 + this.TelephoneNumber.GetHashCode();
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
