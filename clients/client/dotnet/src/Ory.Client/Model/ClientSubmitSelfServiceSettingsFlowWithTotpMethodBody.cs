/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.0.1-alpha.71
 * Contact: support@ory.sh
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Ory.Client.Client.OpenAPIDateConverter;

namespace Ory.Client.Model
{
    /// <summary>
    /// ClientSubmitSelfServiceSettingsFlowWithTotpMethodBody
    /// </summary>
    [DataContract(Name = "submitSelfServiceSettingsFlowWithTotpMethodBody")]
    public partial class ClientSubmitSelfServiceSettingsFlowWithTotpMethodBody : IEquatable<ClientSubmitSelfServiceSettingsFlowWithTotpMethodBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSubmitSelfServiceSettingsFlowWithTotpMethodBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientSubmitSelfServiceSettingsFlowWithTotpMethodBody()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSubmitSelfServiceSettingsFlowWithTotpMethodBody" /> class.
        /// </summary>
        /// <param name="csrfToken">CSRFToken is the anti-CSRF token.</param>
        /// <param name="method">Method  Should be set to \&quot;totp\&quot; when trying to add, update, or remove a totp pairing. (required).</param>
        /// <param name="totpCode">ValidationTOTP must contain a valid TOTP based on the.</param>
        /// <param name="totpUnlink">UnlinkTOTP if true will remove the TOTP pairing, effectively removing the credential. This can be used to set up a new TOTP device..</param>
        public ClientSubmitSelfServiceSettingsFlowWithTotpMethodBody(string csrfToken = default(string), string method = default(string), string totpCode = default(string), bool totpUnlink = default(bool))
        {
            // to ensure "method" is required (not null)
            if (method == null) {
                throw new ArgumentNullException("method is a required property for ClientSubmitSelfServiceSettingsFlowWithTotpMethodBody and cannot be null");
            }
            this.Method = method;
            this.CsrfToken = csrfToken;
            this.TotpCode = totpCode;
            this.TotpUnlink = totpUnlink;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// CSRFToken is the anti-CSRF token
        /// </summary>
        /// <value>CSRFToken is the anti-CSRF token</value>
        [DataMember(Name = "csrf_token", EmitDefaultValue = false)]
        public string CsrfToken { get; set; }

        /// <summary>
        /// Method  Should be set to \&quot;totp\&quot; when trying to add, update, or remove a totp pairing.
        /// </summary>
        /// <value>Method  Should be set to \&quot;totp\&quot; when trying to add, update, or remove a totp pairing.</value>
        [DataMember(Name = "method", IsRequired = true, EmitDefaultValue = false)]
        public string Method { get; set; }

        /// <summary>
        /// ValidationTOTP must contain a valid TOTP based on the
        /// </summary>
        /// <value>ValidationTOTP must contain a valid TOTP based on the</value>
        [DataMember(Name = "totp_code", EmitDefaultValue = false)]
        public string TotpCode { get; set; }

        /// <summary>
        /// UnlinkTOTP if true will remove the TOTP pairing, effectively removing the credential. This can be used to set up a new TOTP device.
        /// </summary>
        /// <value>UnlinkTOTP if true will remove the TOTP pairing, effectively removing the credential. This can be used to set up a new TOTP device.</value>
        [DataMember(Name = "totp_unlink", EmitDefaultValue = true)]
        public bool TotpUnlink { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ClientSubmitSelfServiceSettingsFlowWithTotpMethodBody {\n");
            sb.Append("  CsrfToken: ").Append(CsrfToken).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  TotpCode: ").Append(TotpCode).Append("\n");
            sb.Append("  TotpUnlink: ").Append(TotpUnlink).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ClientSubmitSelfServiceSettingsFlowWithTotpMethodBody);
        }

        /// <summary>
        /// Returns true if ClientSubmitSelfServiceSettingsFlowWithTotpMethodBody instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientSubmitSelfServiceSettingsFlowWithTotpMethodBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientSubmitSelfServiceSettingsFlowWithTotpMethodBody input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CsrfToken == input.CsrfToken ||
                    (this.CsrfToken != null &&
                    this.CsrfToken.Equals(input.CsrfToken))
                ) && 
                (
                    this.Method == input.Method ||
                    (this.Method != null &&
                    this.Method.Equals(input.Method))
                ) && 
                (
                    this.TotpCode == input.TotpCode ||
                    (this.TotpCode != null &&
                    this.TotpCode.Equals(input.TotpCode))
                ) && 
                (
                    this.TotpUnlink == input.TotpUnlink ||
                    this.TotpUnlink.Equals(input.TotpUnlink)
                )
                && (this.AdditionalProperties.Count == input.AdditionalProperties.Count && !this.AdditionalProperties.Except(input.AdditionalProperties).Any());
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
                if (this.CsrfToken != null)
                {
                    hashCode = (hashCode * 59) + this.CsrfToken.GetHashCode();
                }
                if (this.Method != null)
                {
                    hashCode = (hashCode * 59) + this.Method.GetHashCode();
                }
                if (this.TotpCode != null)
                {
                    hashCode = (hashCode * 59) + this.TotpCode.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TotpUnlink.GetHashCode();
                if (this.AdditionalProperties != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalProperties.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
