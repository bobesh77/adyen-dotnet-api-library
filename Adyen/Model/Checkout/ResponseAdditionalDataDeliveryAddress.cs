#region Licence

// 
//                        ######
//                        ######
//  ############    ####( ######  #####. ######  ############   ############
//  #############  #####( ######  #####. ######  #############  #############
//         ######  #####( ######  #####. ######  #####  ######  #####  ######
//  ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  ###### ######  #####( ######  #####. ######  #####          #####  ######
//  #############  #############  #############  #############  #####  ######
//   ############   ############  #############   ############  #####  ######
//                                       ######
//                                #############
//                                ############
// 
//  Adyen Dotnet API Library
// 
//  Copyright (c) 2020 Adyen B.V.
//  This file is open source and available under the MIT license.
//  See the LICENSE file for more info.

#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// ResponseAdditionalDataDeliveryAddress
    /// </summary>
    [DataContract]
    public partial class ResponseAdditionalDataDeliveryAddress : IEquatable<ResponseAdditionalDataDeliveryAddress>,
        IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseAdditionalDataDeliveryAddress" /> class.
        /// </summary>
        /// <param name="deliveryAddressCity">The delivery address city passed in the payment request..</param>
        /// <param name="deliveryAddressCountry">The delivery address country passed in the payment request.  Example: NL.</param>
        /// <param name="deliveryAddressHouseNumberOrName">The delivery address house number or name passed in the payment request..</param>
        /// <param name="deliveryAddressPostalCode">The delivery address postal code passed in the payment request.  Example: 1011 DJ.</param>
        /// <param name="deliveryAddressStateOrProvince">The delivery address state or province passed in the payment request.  Example: NH.</param>
        /// <param name="deliveryAddressStreet">The delivery address street passed in the payment request..</param>
        public ResponseAdditionalDataDeliveryAddress(string deliveryAddressCity = default(string),
            string deliveryAddressCountry = default(string), string deliveryAddressHouseNumberOrName = default(string),
            string deliveryAddressPostalCode = default(string), string deliveryAddressStateOrProvince = default(string),
            string deliveryAddressStreet = default(string))
        {
            this.DeliveryAddressCity = deliveryAddressCity;
            this.DeliveryAddressCountry = deliveryAddressCountry;
            this.DeliveryAddressHouseNumberOrName = deliveryAddressHouseNumberOrName;
            this.DeliveryAddressPostalCode = deliveryAddressPostalCode;
            this.DeliveryAddressStateOrProvince = deliveryAddressStateOrProvince;
            this.DeliveryAddressStreet = deliveryAddressStreet;
        }

        /// <summary>
        /// The delivery address city passed in the payment request.
        /// </summary>
        /// <value>The delivery address city passed in the payment request.</value>
        [DataMember(Name = "deliveryAddress.city", EmitDefaultValue = false)]
        public string DeliveryAddressCity { get; set; }

        /// <summary>
        /// The delivery address country passed in the payment request.  Example: NL
        /// </summary>
        /// <value>The delivery address country passed in the payment request.  Example: NL</value>
        [DataMember(Name = "deliveryAddress.country", EmitDefaultValue = false)]
        public string DeliveryAddressCountry { get; set; }

        /// <summary>
        /// The delivery address house number or name passed in the payment request.
        /// </summary>
        /// <value>The delivery address house number or name passed in the payment request.</value>
        [DataMember(Name = "deliveryAddress.houseNumberOrName", EmitDefaultValue = false)]
        public string DeliveryAddressHouseNumberOrName { get; set; }

        /// <summary>
        /// The delivery address postal code passed in the payment request.  Example: 1011 DJ
        /// </summary>
        /// <value>The delivery address postal code passed in the payment request.  Example: 1011 DJ</value>
        [DataMember(Name = "deliveryAddress.postalCode", EmitDefaultValue = false)]
        public string DeliveryAddressPostalCode { get; set; }

        /// <summary>
        /// The delivery address state or province passed in the payment request.  Example: NH
        /// </summary>
        /// <value>The delivery address state or province passed in the payment request.  Example: NH</value>
        [DataMember(Name = "deliveryAddress.stateOrProvince", EmitDefaultValue = false)]
        public string DeliveryAddressStateOrProvince { get; set; }

        /// <summary>
        /// The delivery address street passed in the payment request.
        /// </summary>
        /// <value>The delivery address street passed in the payment request.</value>
        [DataMember(Name = "deliveryAddress.street", EmitDefaultValue = false)]
        public string DeliveryAddressStreet { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResponseAdditionalDataDeliveryAddress {\n");
            sb.Append("  DeliveryAddressCity: ").Append(DeliveryAddressCity).Append("\n");
            sb.Append("  DeliveryAddressCountry: ").Append(DeliveryAddressCountry).Append("\n");
            sb.Append("  DeliveryAddressHouseNumberOrName: ").Append(DeliveryAddressHouseNumberOrName).Append("\n");
            sb.Append("  DeliveryAddressPostalCode: ").Append(DeliveryAddressPostalCode).Append("\n");
            sb.Append("  DeliveryAddressStateOrProvince: ").Append(DeliveryAddressStateOrProvince).Append("\n");
            sb.Append("  DeliveryAddressStreet: ").Append(DeliveryAddressStreet).Append("\n");
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
            return this.Equals(input as ResponseAdditionalDataDeliveryAddress);
        }

        /// <summary>
        /// Returns true if ResponseAdditionalDataDeliveryAddress instances are equal
        /// </summary>
        /// <param name="input">Instance of ResponseAdditionalDataDeliveryAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResponseAdditionalDataDeliveryAddress input)
        {
            if (input == null)
                return false;

            return
                (
                    this.DeliveryAddressCity == input.DeliveryAddressCity ||
                    this.DeliveryAddressCity != null &&
                    this.DeliveryAddressCity.Equals(input.DeliveryAddressCity)
                ) &&
                (
                    this.DeliveryAddressCountry == input.DeliveryAddressCountry ||
                    this.DeliveryAddressCountry != null &&
                    this.DeliveryAddressCountry.Equals(input.DeliveryAddressCountry)
                ) &&
                (
                    this.DeliveryAddressHouseNumberOrName == input.DeliveryAddressHouseNumberOrName ||
                    this.DeliveryAddressHouseNumberOrName != null &&
                    this.DeliveryAddressHouseNumberOrName.Equals(input.DeliveryAddressHouseNumberOrName)
                ) &&
                (
                    this.DeliveryAddressPostalCode == input.DeliveryAddressPostalCode ||
                    this.DeliveryAddressPostalCode != null &&
                    this.DeliveryAddressPostalCode.Equals(input.DeliveryAddressPostalCode)
                ) &&
                (
                    this.DeliveryAddressStateOrProvince == input.DeliveryAddressStateOrProvince ||
                    this.DeliveryAddressStateOrProvince != null &&
                    this.DeliveryAddressStateOrProvince.Equals(input.DeliveryAddressStateOrProvince)
                ) &&
                (
                    this.DeliveryAddressStreet == input.DeliveryAddressStreet ||
                    this.DeliveryAddressStreet != null &&
                    this.DeliveryAddressStreet.Equals(input.DeliveryAddressStreet)
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
                if (this.DeliveryAddressCity != null)
                    hashCode = hashCode * 59 + this.DeliveryAddressCity.GetHashCode();
                if (this.DeliveryAddressCountry != null)
                    hashCode = hashCode * 59 + this.DeliveryAddressCountry.GetHashCode();
                if (this.DeliveryAddressHouseNumberOrName != null)
                    hashCode = hashCode * 59 + this.DeliveryAddressHouseNumberOrName.GetHashCode();
                if (this.DeliveryAddressPostalCode != null)
                    hashCode = hashCode * 59 + this.DeliveryAddressPostalCode.GetHashCode();
                if (this.DeliveryAddressStateOrProvince != null)
                    hashCode = hashCode * 59 + this.DeliveryAddressStateOrProvince.GetHashCode();
                if (this.DeliveryAddressStreet != null)
                    hashCode = hashCode * 59 + this.DeliveryAddressStreet.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(
            ValidationContext validationContext)
        {
            yield break;
        }
    }
}