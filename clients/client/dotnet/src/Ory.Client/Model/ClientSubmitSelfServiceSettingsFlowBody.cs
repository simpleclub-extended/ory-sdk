/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.0.1-alpha.104
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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Ory.Client.Client.OpenAPIDateConverter;
using System.Reflection;

namespace Ory.Client.Model
{
    /// <summary>
    /// ClientSubmitSelfServiceSettingsFlowBody
    /// </summary>
    [JsonConverter(typeof(ClientSubmitSelfServiceSettingsFlowBodyJsonConverter))]
    [DataContract(Name = "submitSelfServiceSettingsFlowBody")]
    public partial class ClientSubmitSelfServiceSettingsFlowBody : AbstractOpenAPISchema, IEquatable<ClientSubmitSelfServiceSettingsFlowBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSubmitSelfServiceSettingsFlowBody" /> class
        /// with the <see cref="ClientSubmitSelfServiceSettingsFlowWithOidcMethodBody" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ClientSubmitSelfServiceSettingsFlowWithOidcMethodBody.</param>
        public ClientSubmitSelfServiceSettingsFlowBody(ClientSubmitSelfServiceSettingsFlowWithOidcMethodBody actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSubmitSelfServiceSettingsFlowBody" /> class
        /// with the <see cref="ClientSubmitSelfServiceSettingsFlowWithPasswordMethodBody" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ClientSubmitSelfServiceSettingsFlowWithPasswordMethodBody.</param>
        public ClientSubmitSelfServiceSettingsFlowBody(ClientSubmitSelfServiceSettingsFlowWithPasswordMethodBody actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSubmitSelfServiceSettingsFlowBody" /> class
        /// with the <see cref="ClientSubmitSelfServiceSettingsFlowWithProfileMethodBody" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ClientSubmitSelfServiceSettingsFlowWithProfileMethodBody.</param>
        public ClientSubmitSelfServiceSettingsFlowBody(ClientSubmitSelfServiceSettingsFlowWithProfileMethodBody actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSubmitSelfServiceSettingsFlowBody" /> class
        /// with the <see cref="ClientSubmitSelfServiceSettingsFlowWithTotpMethodBody" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ClientSubmitSelfServiceSettingsFlowWithTotpMethodBody.</param>
        public ClientSubmitSelfServiceSettingsFlowBody(ClientSubmitSelfServiceSettingsFlowWithTotpMethodBody actualInstance)
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
                if (value.GetType() == typeof(ClientSubmitSelfServiceSettingsFlowWithOidcMethodBody))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ClientSubmitSelfServiceSettingsFlowWithPasswordMethodBody))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ClientSubmitSelfServiceSettingsFlowWithProfileMethodBody))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ClientSubmitSelfServiceSettingsFlowWithTotpMethodBody))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: ClientSubmitSelfServiceSettingsFlowWithOidcMethodBody, ClientSubmitSelfServiceSettingsFlowWithPasswordMethodBody, ClientSubmitSelfServiceSettingsFlowWithProfileMethodBody, ClientSubmitSelfServiceSettingsFlowWithTotpMethodBody");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `ClientSubmitSelfServiceSettingsFlowWithOidcMethodBody`. If the actual instance is not `ClientSubmitSelfServiceSettingsFlowWithOidcMethodBody`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ClientSubmitSelfServiceSettingsFlowWithOidcMethodBody</returns>
        public ClientSubmitSelfServiceSettingsFlowWithOidcMethodBody GetClientSubmitSelfServiceSettingsFlowWithOidcMethodBody()
        {
            return (ClientSubmitSelfServiceSettingsFlowWithOidcMethodBody)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ClientSubmitSelfServiceSettingsFlowWithPasswordMethodBody`. If the actual instance is not `ClientSubmitSelfServiceSettingsFlowWithPasswordMethodBody`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ClientSubmitSelfServiceSettingsFlowWithPasswordMethodBody</returns>
        public ClientSubmitSelfServiceSettingsFlowWithPasswordMethodBody GetClientSubmitSelfServiceSettingsFlowWithPasswordMethodBody()
        {
            return (ClientSubmitSelfServiceSettingsFlowWithPasswordMethodBody)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ClientSubmitSelfServiceSettingsFlowWithProfileMethodBody`. If the actual instance is not `ClientSubmitSelfServiceSettingsFlowWithProfileMethodBody`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ClientSubmitSelfServiceSettingsFlowWithProfileMethodBody</returns>
        public ClientSubmitSelfServiceSettingsFlowWithProfileMethodBody GetClientSubmitSelfServiceSettingsFlowWithProfileMethodBody()
        {
            return (ClientSubmitSelfServiceSettingsFlowWithProfileMethodBody)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ClientSubmitSelfServiceSettingsFlowWithTotpMethodBody`. If the actual instance is not `ClientSubmitSelfServiceSettingsFlowWithTotpMethodBody`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ClientSubmitSelfServiceSettingsFlowWithTotpMethodBody</returns>
        public ClientSubmitSelfServiceSettingsFlowWithTotpMethodBody GetClientSubmitSelfServiceSettingsFlowWithTotpMethodBody()
        {
            return (ClientSubmitSelfServiceSettingsFlowWithTotpMethodBody)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClientSubmitSelfServiceSettingsFlowBody {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, ClientSubmitSelfServiceSettingsFlowBody.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of ClientSubmitSelfServiceSettingsFlowBody
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of ClientSubmitSelfServiceSettingsFlowBody</returns>
        public static ClientSubmitSelfServiceSettingsFlowBody FromJson(string jsonString)
        {
            ClientSubmitSelfServiceSettingsFlowBody newClientSubmitSelfServiceSettingsFlowBody = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newClientSubmitSelfServiceSettingsFlowBody;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ClientSubmitSelfServiceSettingsFlowWithOidcMethodBody).GetProperty("AdditionalProperties") == null)
                {
                    newClientSubmitSelfServiceSettingsFlowBody = new ClientSubmitSelfServiceSettingsFlowBody(JsonConvert.DeserializeObject<ClientSubmitSelfServiceSettingsFlowWithOidcMethodBody>(jsonString, ClientSubmitSelfServiceSettingsFlowBody.SerializerSettings));
                }
                else
                {
                    newClientSubmitSelfServiceSettingsFlowBody = new ClientSubmitSelfServiceSettingsFlowBody(JsonConvert.DeserializeObject<ClientSubmitSelfServiceSettingsFlowWithOidcMethodBody>(jsonString, ClientSubmitSelfServiceSettingsFlowBody.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ClientSubmitSelfServiceSettingsFlowWithOidcMethodBody");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ClientSubmitSelfServiceSettingsFlowWithOidcMethodBody: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ClientSubmitSelfServiceSettingsFlowWithPasswordMethodBody).GetProperty("AdditionalProperties") == null)
                {
                    newClientSubmitSelfServiceSettingsFlowBody = new ClientSubmitSelfServiceSettingsFlowBody(JsonConvert.DeserializeObject<ClientSubmitSelfServiceSettingsFlowWithPasswordMethodBody>(jsonString, ClientSubmitSelfServiceSettingsFlowBody.SerializerSettings));
                }
                else
                {
                    newClientSubmitSelfServiceSettingsFlowBody = new ClientSubmitSelfServiceSettingsFlowBody(JsonConvert.DeserializeObject<ClientSubmitSelfServiceSettingsFlowWithPasswordMethodBody>(jsonString, ClientSubmitSelfServiceSettingsFlowBody.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ClientSubmitSelfServiceSettingsFlowWithPasswordMethodBody");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ClientSubmitSelfServiceSettingsFlowWithPasswordMethodBody: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ClientSubmitSelfServiceSettingsFlowWithProfileMethodBody).GetProperty("AdditionalProperties") == null)
                {
                    newClientSubmitSelfServiceSettingsFlowBody = new ClientSubmitSelfServiceSettingsFlowBody(JsonConvert.DeserializeObject<ClientSubmitSelfServiceSettingsFlowWithProfileMethodBody>(jsonString, ClientSubmitSelfServiceSettingsFlowBody.SerializerSettings));
                }
                else
                {
                    newClientSubmitSelfServiceSettingsFlowBody = new ClientSubmitSelfServiceSettingsFlowBody(JsonConvert.DeserializeObject<ClientSubmitSelfServiceSettingsFlowWithProfileMethodBody>(jsonString, ClientSubmitSelfServiceSettingsFlowBody.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ClientSubmitSelfServiceSettingsFlowWithProfileMethodBody");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ClientSubmitSelfServiceSettingsFlowWithProfileMethodBody: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ClientSubmitSelfServiceSettingsFlowWithTotpMethodBody).GetProperty("AdditionalProperties") == null)
                {
                    newClientSubmitSelfServiceSettingsFlowBody = new ClientSubmitSelfServiceSettingsFlowBody(JsonConvert.DeserializeObject<ClientSubmitSelfServiceSettingsFlowWithTotpMethodBody>(jsonString, ClientSubmitSelfServiceSettingsFlowBody.SerializerSettings));
                }
                else
                {
                    newClientSubmitSelfServiceSettingsFlowBody = new ClientSubmitSelfServiceSettingsFlowBody(JsonConvert.DeserializeObject<ClientSubmitSelfServiceSettingsFlowWithTotpMethodBody>(jsonString, ClientSubmitSelfServiceSettingsFlowBody.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ClientSubmitSelfServiceSettingsFlowWithTotpMethodBody");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ClientSubmitSelfServiceSettingsFlowWithTotpMethodBody: {1}", jsonString, exception.ToString()));
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
            return newClientSubmitSelfServiceSettingsFlowBody;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ClientSubmitSelfServiceSettingsFlowBody);
        }

        /// <summary>
        /// Returns true if ClientSubmitSelfServiceSettingsFlowBody instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientSubmitSelfServiceSettingsFlowBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientSubmitSelfServiceSettingsFlowBody input)
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
    /// Custom JSON converter for ClientSubmitSelfServiceSettingsFlowBody
    /// </summary>
    public class ClientSubmitSelfServiceSettingsFlowBodyJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(ClientSubmitSelfServiceSettingsFlowBody).GetMethod("ToJson").Invoke(value, null)));
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
                return ClientSubmitSelfServiceSettingsFlowBody.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
