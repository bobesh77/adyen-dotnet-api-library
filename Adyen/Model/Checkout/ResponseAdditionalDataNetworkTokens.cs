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
    /// ResponseAdditionalDataNetworkTokens
    /// </summary>
    [DataContract]
    public partial class ResponseAdditionalDataNetworkTokens : IEquatable<ResponseAdditionalDataNetworkTokens>,
        IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseAdditionalDataNetworkTokens" /> class.
        /// </summary>
        /// <param name="networkTokenAvailable">Indicates whether a network token is available for the specified card..</param>
        /// <param name="networkTokenBin">The Bank Identification Number of a tokenized card, which is the first six digits of a card number..</param>
        /// <param name="networkTokenTokenSummary">The last four digits of a network token..</param>
        public ResponseAdditionalDataNetworkTokens(string networkTokenAvailable = default(string),
            string networkTokenBin = default(string), string networkTokenTokenSummary = default(string))
        {
            this.NetworkTokenAvailable = networkTokenAvailable;
            this.NetworkTokenBin = networkTokenBin;
            this.NetworkTokenTokenSummary = networkTokenTokenSummary;
        }

        /// <summary>
        /// Indicates whether a network token is available for the specified card.
        /// </summary>
        /// <value>Indicates whether a network token is available for the specified card.</value>
        [DataMember(Name = "networkToken.available", EmitDefaultValue = false)]
        public string NetworkTokenAvailable { get; set; }

        /// <summary>
        /// The Bank Identification Number of a tokenized card, which is the first six digits of a card number.
        /// </summary>
        /// <value>The Bank Identification Number of a tokenized card, which is the first six digits of a card number.</value>
        [DataMember(Name = "networkToken.bin", EmitDefaultValue = false)]
        public string NetworkTokenBin { get; set; }

        /// <summary>
        /// The last four digits of a network token.
        /// </summary>
        /// <value>The last four digits of a network token.</value>
        [DataMember(Name = "networkToken.tokenSummary", EmitDefaultValue = false)]
        public string NetworkTokenTokenSummary { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResponseAdditionalDataNetworkTokens {\n");
            sb.Append("  NetworkTokenAvailable: ").Append(NetworkTokenAvailable).Append("\n");
            sb.Append("  NetworkTokenBin: ").Append(NetworkTokenBin).Append("\n");
            sb.Append("  NetworkTokenTokenSummary: ").Append(NetworkTokenTokenSummary).Append("\n");
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
            return this.Equals(input as ResponseAdditionalDataNetworkTokens);
        }

        /// <summary>
        /// Returns true if ResponseAdditionalDataNetworkTokens instances are equal
        /// </summary>
        /// <param name="input">Instance of ResponseAdditionalDataNetworkTokens to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResponseAdditionalDataNetworkTokens input)
        {
            if (input == null)
                return false;

            return
                (
                    this.NetworkTokenAvailable == input.NetworkTokenAvailable ||
                    this.NetworkTokenAvailable != null &&
                    this.NetworkTokenAvailable.Equals(input.NetworkTokenAvailable)
                ) &&
                (
                    this.NetworkTokenBin == input.NetworkTokenBin ||
                    this.NetworkTokenBin != null &&
                    this.NetworkTokenBin.Equals(input.NetworkTokenBin)
                ) &&
                (
                    this.NetworkTokenTokenSummary == input.NetworkTokenTokenSummary ||
                    this.NetworkTokenTokenSummary != null &&
                    this.NetworkTokenTokenSummary.Equals(input.NetworkTokenTokenSummary)
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
                if (this.NetworkTokenAvailable != null)
                    hashCode = hashCode * 59 + this.NetworkTokenAvailable.GetHashCode();
                if (this.NetworkTokenBin != null)
                    hashCode = hashCode * 59 + this.NetworkTokenBin.GetHashCode();
                if (this.NetworkTokenTokenSummary != null)
                    hashCode = hashCode * 59 + this.NetworkTokenTokenSummary.GetHashCode();
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