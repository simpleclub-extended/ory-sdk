/*
 * Ory Identities API
 *
 * This is the API specification for Ory Identities with features such as registration, login, recovery, account verification, profile settings, password reset, identity management, session management, email and sms delivery, and more. 
 *
 * The version of the OpenAPI document: v0.11.1
 * Contact: office@ory.sh
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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Ory.Kratos.Client.Client.OpenAPIDateConverter;
using System.Reflection;

namespace Ory.Kratos.Client.Model
{
    /// <summary>
    /// Update Settings Flow Request Body
    /// </summary>
    [JsonConverter(typeof(KratosUpdateSettingsFlowBodyJsonConverter))]
    [DataContract(Name = "updateSettingsFlowBody")]
    public partial class KratosUpdateSettingsFlowBody : AbstractOpenAPISchema, IEquatable<KratosUpdateSettingsFlowBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosUpdateSettingsFlowBody" /> class
        /// with the <see cref="KratosUpdateSettingsFlowWithLookupMethod" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of KratosUpdateSettingsFlowWithLookupMethod.</param>
        public KratosUpdateSettingsFlowBody(KratosUpdateSettingsFlowWithLookupMethod actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KratosUpdateSettingsFlowBody" /> class
        /// with the <see cref="KratosUpdateSettingsFlowWithOidcMethod" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of KratosUpdateSettingsFlowWithOidcMethod.</param>
        public KratosUpdateSettingsFlowBody(KratosUpdateSettingsFlowWithOidcMethod actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KratosUpdateSettingsFlowBody" /> class
        /// with the <see cref="KratosUpdateSettingsFlowWithPasswordMethod" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of KratosUpdateSettingsFlowWithPasswordMethod.</param>
        public KratosUpdateSettingsFlowBody(KratosUpdateSettingsFlowWithPasswordMethod actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KratosUpdateSettingsFlowBody" /> class
        /// with the <see cref="KratosUpdateSettingsFlowWithProfileMethod" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of KratosUpdateSettingsFlowWithProfileMethod.</param>
        public KratosUpdateSettingsFlowBody(KratosUpdateSettingsFlowWithProfileMethod actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KratosUpdateSettingsFlowBody" /> class
        /// with the <see cref="KratosUpdateSettingsFlowWithTotpMethod" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of KratosUpdateSettingsFlowWithTotpMethod.</param>
        public KratosUpdateSettingsFlowBody(KratosUpdateSettingsFlowWithTotpMethod actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KratosUpdateSettingsFlowBody" /> class
        /// with the <see cref="KratosUpdateSettingsFlowWithWebAuthnMethod" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of KratosUpdateSettingsFlowWithWebAuthnMethod.</param>
        public KratosUpdateSettingsFlowBody(KratosUpdateSettingsFlowWithWebAuthnMethod actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(KratosUpdateSettingsFlowWithLookupMethod))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(KratosUpdateSettingsFlowWithOidcMethod))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(KratosUpdateSettingsFlowWithPasswordMethod))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(KratosUpdateSettingsFlowWithProfileMethod))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(KratosUpdateSettingsFlowWithTotpMethod))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(KratosUpdateSettingsFlowWithWebAuthnMethod))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: KratosUpdateSettingsFlowWithLookupMethod, KratosUpdateSettingsFlowWithOidcMethod, KratosUpdateSettingsFlowWithPasswordMethod, KratosUpdateSettingsFlowWithProfileMethod, KratosUpdateSettingsFlowWithTotpMethod, KratosUpdateSettingsFlowWithWebAuthnMethod");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `KratosUpdateSettingsFlowWithLookupMethod`. If the actual instance is not `KratosUpdateSettingsFlowWithLookupMethod`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of KratosUpdateSettingsFlowWithLookupMethod</returns>
        public KratosUpdateSettingsFlowWithLookupMethod GetKratosUpdateSettingsFlowWithLookupMethod()
        {
            return (KratosUpdateSettingsFlowWithLookupMethod)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `KratosUpdateSettingsFlowWithOidcMethod`. If the actual instance is not `KratosUpdateSettingsFlowWithOidcMethod`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of KratosUpdateSettingsFlowWithOidcMethod</returns>
        public KratosUpdateSettingsFlowWithOidcMethod GetKratosUpdateSettingsFlowWithOidcMethod()
        {
            return (KratosUpdateSettingsFlowWithOidcMethod)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `KratosUpdateSettingsFlowWithPasswordMethod`. If the actual instance is not `KratosUpdateSettingsFlowWithPasswordMethod`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of KratosUpdateSettingsFlowWithPasswordMethod</returns>
        public KratosUpdateSettingsFlowWithPasswordMethod GetKratosUpdateSettingsFlowWithPasswordMethod()
        {
            return (KratosUpdateSettingsFlowWithPasswordMethod)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `KratosUpdateSettingsFlowWithProfileMethod`. If the actual instance is not `KratosUpdateSettingsFlowWithProfileMethod`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of KratosUpdateSettingsFlowWithProfileMethod</returns>
        public KratosUpdateSettingsFlowWithProfileMethod GetKratosUpdateSettingsFlowWithProfileMethod()
        {
            return (KratosUpdateSettingsFlowWithProfileMethod)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `KratosUpdateSettingsFlowWithTotpMethod`. If the actual instance is not `KratosUpdateSettingsFlowWithTotpMethod`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of KratosUpdateSettingsFlowWithTotpMethod</returns>
        public KratosUpdateSettingsFlowWithTotpMethod GetKratosUpdateSettingsFlowWithTotpMethod()
        {
            return (KratosUpdateSettingsFlowWithTotpMethod)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `KratosUpdateSettingsFlowWithWebAuthnMethod`. If the actual instance is not `KratosUpdateSettingsFlowWithWebAuthnMethod`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of KratosUpdateSettingsFlowWithWebAuthnMethod</returns>
        public KratosUpdateSettingsFlowWithWebAuthnMethod GetKratosUpdateSettingsFlowWithWebAuthnMethod()
        {
            return (KratosUpdateSettingsFlowWithWebAuthnMethod)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KratosUpdateSettingsFlowBody {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, KratosUpdateSettingsFlowBody.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of KratosUpdateSettingsFlowBody
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of KratosUpdateSettingsFlowBody</returns>
        public static KratosUpdateSettingsFlowBody FromJson(string jsonString)
        {
            KratosUpdateSettingsFlowBody newKratosUpdateSettingsFlowBody = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newKratosUpdateSettingsFlowBody;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(KratosUpdateSettingsFlowWithLookupMethod).GetProperty("AdditionalProperties") == null)
                {
                    newKratosUpdateSettingsFlowBody = new KratosUpdateSettingsFlowBody(JsonConvert.DeserializeObject<KratosUpdateSettingsFlowWithLookupMethod>(jsonString, KratosUpdateSettingsFlowBody.SerializerSettings));
                }
                else
                {
                    newKratosUpdateSettingsFlowBody = new KratosUpdateSettingsFlowBody(JsonConvert.DeserializeObject<KratosUpdateSettingsFlowWithLookupMethod>(jsonString, KratosUpdateSettingsFlowBody.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("KratosUpdateSettingsFlowWithLookupMethod");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into KratosUpdateSettingsFlowWithLookupMethod: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(KratosUpdateSettingsFlowWithOidcMethod).GetProperty("AdditionalProperties") == null)
                {
                    newKratosUpdateSettingsFlowBody = new KratosUpdateSettingsFlowBody(JsonConvert.DeserializeObject<KratosUpdateSettingsFlowWithOidcMethod>(jsonString, KratosUpdateSettingsFlowBody.SerializerSettings));
                }
                else
                {
                    newKratosUpdateSettingsFlowBody = new KratosUpdateSettingsFlowBody(JsonConvert.DeserializeObject<KratosUpdateSettingsFlowWithOidcMethod>(jsonString, KratosUpdateSettingsFlowBody.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("KratosUpdateSettingsFlowWithOidcMethod");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into KratosUpdateSettingsFlowWithOidcMethod: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(KratosUpdateSettingsFlowWithPasswordMethod).GetProperty("AdditionalProperties") == null)
                {
                    newKratosUpdateSettingsFlowBody = new KratosUpdateSettingsFlowBody(JsonConvert.DeserializeObject<KratosUpdateSettingsFlowWithPasswordMethod>(jsonString, KratosUpdateSettingsFlowBody.SerializerSettings));
                }
                else
                {
                    newKratosUpdateSettingsFlowBody = new KratosUpdateSettingsFlowBody(JsonConvert.DeserializeObject<KratosUpdateSettingsFlowWithPasswordMethod>(jsonString, KratosUpdateSettingsFlowBody.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("KratosUpdateSettingsFlowWithPasswordMethod");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into KratosUpdateSettingsFlowWithPasswordMethod: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(KratosUpdateSettingsFlowWithProfileMethod).GetProperty("AdditionalProperties") == null)
                {
                    newKratosUpdateSettingsFlowBody = new KratosUpdateSettingsFlowBody(JsonConvert.DeserializeObject<KratosUpdateSettingsFlowWithProfileMethod>(jsonString, KratosUpdateSettingsFlowBody.SerializerSettings));
                }
                else
                {
                    newKratosUpdateSettingsFlowBody = new KratosUpdateSettingsFlowBody(JsonConvert.DeserializeObject<KratosUpdateSettingsFlowWithProfileMethod>(jsonString, KratosUpdateSettingsFlowBody.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("KratosUpdateSettingsFlowWithProfileMethod");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into KratosUpdateSettingsFlowWithProfileMethod: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(KratosUpdateSettingsFlowWithTotpMethod).GetProperty("AdditionalProperties") == null)
                {
                    newKratosUpdateSettingsFlowBody = new KratosUpdateSettingsFlowBody(JsonConvert.DeserializeObject<KratosUpdateSettingsFlowWithTotpMethod>(jsonString, KratosUpdateSettingsFlowBody.SerializerSettings));
                }
                else
                {
                    newKratosUpdateSettingsFlowBody = new KratosUpdateSettingsFlowBody(JsonConvert.DeserializeObject<KratosUpdateSettingsFlowWithTotpMethod>(jsonString, KratosUpdateSettingsFlowBody.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("KratosUpdateSettingsFlowWithTotpMethod");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into KratosUpdateSettingsFlowWithTotpMethod: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(KratosUpdateSettingsFlowWithWebAuthnMethod).GetProperty("AdditionalProperties") == null)
                {
                    newKratosUpdateSettingsFlowBody = new KratosUpdateSettingsFlowBody(JsonConvert.DeserializeObject<KratosUpdateSettingsFlowWithWebAuthnMethod>(jsonString, KratosUpdateSettingsFlowBody.SerializerSettings));
                }
                else
                {
                    newKratosUpdateSettingsFlowBody = new KratosUpdateSettingsFlowBody(JsonConvert.DeserializeObject<KratosUpdateSettingsFlowWithWebAuthnMethod>(jsonString, KratosUpdateSettingsFlowBody.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("KratosUpdateSettingsFlowWithWebAuthnMethod");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into KratosUpdateSettingsFlowWithWebAuthnMethod: {1}", jsonString, exception.ToString()));
            }

            if (match == 0)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
            }
            else if (match > 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + matchedTypes);
            }

            // deserialization is considered successful at this point if no exception has been thrown.
            return newKratosUpdateSettingsFlowBody;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as KratosUpdateSettingsFlowBody);
        }

        /// <summary>
        /// Returns true if KratosUpdateSettingsFlowBody instances are equal
        /// </summary>
        /// <param name="input">Instance of KratosUpdateSettingsFlowBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KratosUpdateSettingsFlowBody input)
        {
            if (input == null)
                return false;

            return this.ActualInstance.Equals(input.ActualInstance);
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
                if (this.ActualInstance != null)
                    hashCode = hashCode * 59 + this.ActualInstance.GetHashCode();
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

    /// <summary>
    /// Custom JSON converter for KratosUpdateSettingsFlowBody
    /// </summary>
    public class KratosUpdateSettingsFlowBodyJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(KratosUpdateSettingsFlowBody).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if(reader.TokenType != JsonToken.Null)
            {
                return KratosUpdateSettingsFlowBody.FromJson(JObject.Load(reader).ToString(Formatting.None));
            }
            return null;
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}
