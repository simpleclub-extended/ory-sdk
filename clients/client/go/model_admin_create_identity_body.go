/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * API version: v0.0.1-alpha.187
 * Contact: support@ory.sh
 */

// Code generated by OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.

package client

import (
	"encoding/json"
)

// AdminCreateIdentityBody struct for AdminCreateIdentityBody
type AdminCreateIdentityBody struct {
	Credentials *AdminIdentityImportCredentials `json:"credentials,omitempty"`
	// Store metadata about the user which is only accessible through admin APIs such as `GET /admin/identities/<id>`.
	MetadataAdmin interface{} `json:"metadata_admin,omitempty"`
	// Store metadata about the identity which the identity itself can see when calling for example the session endpoint. Do not store sensitive information (e.g. credit score) about the identity in this field.
	MetadataPublic interface{} `json:"metadata_public,omitempty"`
	// RecoveryAddresses contains all the addresses that can be used to recover an identity.  Use this structure to import recovery addresses for an identity. Please keep in mind that the address needs to be represented in the Identity Schema or this field will be overwritten on the next identity update.
	RecoveryAddresses []RecoveryAddress `json:"recovery_addresses,omitempty"`
	// SchemaID is the ID of the JSON Schema to be used for validating the identity's traits.
	SchemaId string `json:"schema_id"`
	State *IdentityState `json:"state,omitempty"`
	// Traits represent an identity's traits. The identity is able to create, modify, and delete traits in a self-service manner. The input will always be validated against the JSON Schema defined in `schema_url`.
	Traits map[string]interface{} `json:"traits"`
	// VerifiableAddresses contains all the addresses that can be verified by the user.  Use this structure to import verified addresses for an identity. Please keep in mind that the address needs to be represented in the Identity Schema or this field will be overwritten on the next identity update.
	VerifiableAddresses []VerifiableIdentityAddress `json:"verifiable_addresses,omitempty"`
}

// NewAdminCreateIdentityBody instantiates a new AdminCreateIdentityBody object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewAdminCreateIdentityBody(schemaId string, traits map[string]interface{}) *AdminCreateIdentityBody {
	this := AdminCreateIdentityBody{}
	this.SchemaId = schemaId
	this.Traits = traits
	return &this
}

// NewAdminCreateIdentityBodyWithDefaults instantiates a new AdminCreateIdentityBody object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewAdminCreateIdentityBodyWithDefaults() *AdminCreateIdentityBody {
	this := AdminCreateIdentityBody{}
	return &this
}

// GetCredentials returns the Credentials field value if set, zero value otherwise.
func (o *AdminCreateIdentityBody) GetCredentials() AdminIdentityImportCredentials {
	if o == nil || o.Credentials == nil {
		var ret AdminIdentityImportCredentials
		return ret
	}
	return *o.Credentials
}

// GetCredentialsOk returns a tuple with the Credentials field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *AdminCreateIdentityBody) GetCredentialsOk() (*AdminIdentityImportCredentials, bool) {
	if o == nil || o.Credentials == nil {
		return nil, false
	}
	return o.Credentials, true
}

// HasCredentials returns a boolean if a field has been set.
func (o *AdminCreateIdentityBody) HasCredentials() bool {
	if o != nil && o.Credentials != nil {
		return true
	}

	return false
}

// SetCredentials gets a reference to the given AdminIdentityImportCredentials and assigns it to the Credentials field.
func (o *AdminCreateIdentityBody) SetCredentials(v AdminIdentityImportCredentials) {
	o.Credentials = &v
}

// GetMetadataAdmin returns the MetadataAdmin field value if set, zero value otherwise (both if not set or set to explicit null).
func (o *AdminCreateIdentityBody) GetMetadataAdmin() interface{} {
	if o == nil  {
		var ret interface{}
		return ret
	}
	return o.MetadataAdmin
}

// GetMetadataAdminOk returns a tuple with the MetadataAdmin field value if set, nil otherwise
// and a boolean to check if the value has been set.
// NOTE: If the value is an explicit nil, `nil, true` will be returned
func (o *AdminCreateIdentityBody) GetMetadataAdminOk() (*interface{}, bool) {
	if o == nil || o.MetadataAdmin == nil {
		return nil, false
	}
	return &o.MetadataAdmin, true
}

// HasMetadataAdmin returns a boolean if a field has been set.
func (o *AdminCreateIdentityBody) HasMetadataAdmin() bool {
	if o != nil && o.MetadataAdmin != nil {
		return true
	}

	return false
}

// SetMetadataAdmin gets a reference to the given interface{} and assigns it to the MetadataAdmin field.
func (o *AdminCreateIdentityBody) SetMetadataAdmin(v interface{}) {
	o.MetadataAdmin = v
}

// GetMetadataPublic returns the MetadataPublic field value if set, zero value otherwise (both if not set or set to explicit null).
func (o *AdminCreateIdentityBody) GetMetadataPublic() interface{} {
	if o == nil  {
		var ret interface{}
		return ret
	}
	return o.MetadataPublic
}

// GetMetadataPublicOk returns a tuple with the MetadataPublic field value if set, nil otherwise
// and a boolean to check if the value has been set.
// NOTE: If the value is an explicit nil, `nil, true` will be returned
func (o *AdminCreateIdentityBody) GetMetadataPublicOk() (*interface{}, bool) {
	if o == nil || o.MetadataPublic == nil {
		return nil, false
	}
	return &o.MetadataPublic, true
}

// HasMetadataPublic returns a boolean if a field has been set.
func (o *AdminCreateIdentityBody) HasMetadataPublic() bool {
	if o != nil && o.MetadataPublic != nil {
		return true
	}

	return false
}

// SetMetadataPublic gets a reference to the given interface{} and assigns it to the MetadataPublic field.
func (o *AdminCreateIdentityBody) SetMetadataPublic(v interface{}) {
	o.MetadataPublic = v
}

// GetRecoveryAddresses returns the RecoveryAddresses field value if set, zero value otherwise.
func (o *AdminCreateIdentityBody) GetRecoveryAddresses() []RecoveryAddress {
	if o == nil || o.RecoveryAddresses == nil {
		var ret []RecoveryAddress
		return ret
	}
	return o.RecoveryAddresses
}

// GetRecoveryAddressesOk returns a tuple with the RecoveryAddresses field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *AdminCreateIdentityBody) GetRecoveryAddressesOk() ([]RecoveryAddress, bool) {
	if o == nil || o.RecoveryAddresses == nil {
		return nil, false
	}
	return o.RecoveryAddresses, true
}

// HasRecoveryAddresses returns a boolean if a field has been set.
func (o *AdminCreateIdentityBody) HasRecoveryAddresses() bool {
	if o != nil && o.RecoveryAddresses != nil {
		return true
	}

	return false
}

// SetRecoveryAddresses gets a reference to the given []RecoveryAddress and assigns it to the RecoveryAddresses field.
func (o *AdminCreateIdentityBody) SetRecoveryAddresses(v []RecoveryAddress) {
	o.RecoveryAddresses = v
}

// GetSchemaId returns the SchemaId field value
func (o *AdminCreateIdentityBody) GetSchemaId() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.SchemaId
}

// GetSchemaIdOk returns a tuple with the SchemaId field value
// and a boolean to check if the value has been set.
func (o *AdminCreateIdentityBody) GetSchemaIdOk() (*string, bool) {
	if o == nil  {
		return nil, false
	}
	return &o.SchemaId, true
}

// SetSchemaId sets field value
func (o *AdminCreateIdentityBody) SetSchemaId(v string) {
	o.SchemaId = v
}

// GetState returns the State field value if set, zero value otherwise.
func (o *AdminCreateIdentityBody) GetState() IdentityState {
	if o == nil || o.State == nil {
		var ret IdentityState
		return ret
	}
	return *o.State
}

// GetStateOk returns a tuple with the State field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *AdminCreateIdentityBody) GetStateOk() (*IdentityState, bool) {
	if o == nil || o.State == nil {
		return nil, false
	}
	return o.State, true
}

// HasState returns a boolean if a field has been set.
func (o *AdminCreateIdentityBody) HasState() bool {
	if o != nil && o.State != nil {
		return true
	}

	return false
}

// SetState gets a reference to the given IdentityState and assigns it to the State field.
func (o *AdminCreateIdentityBody) SetState(v IdentityState) {
	o.State = &v
}

// GetTraits returns the Traits field value
func (o *AdminCreateIdentityBody) GetTraits() map[string]interface{} {
	if o == nil {
		var ret map[string]interface{}
		return ret
	}

	return o.Traits
}

// GetTraitsOk returns a tuple with the Traits field value
// and a boolean to check if the value has been set.
func (o *AdminCreateIdentityBody) GetTraitsOk() (map[string]interface{}, bool) {
	if o == nil  {
		return nil, false
	}
	return o.Traits, true
}

// SetTraits sets field value
func (o *AdminCreateIdentityBody) SetTraits(v map[string]interface{}) {
	o.Traits = v
}

// GetVerifiableAddresses returns the VerifiableAddresses field value if set, zero value otherwise.
func (o *AdminCreateIdentityBody) GetVerifiableAddresses() []VerifiableIdentityAddress {
	if o == nil || o.VerifiableAddresses == nil {
		var ret []VerifiableIdentityAddress
		return ret
	}
	return o.VerifiableAddresses
}

// GetVerifiableAddressesOk returns a tuple with the VerifiableAddresses field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *AdminCreateIdentityBody) GetVerifiableAddressesOk() ([]VerifiableIdentityAddress, bool) {
	if o == nil || o.VerifiableAddresses == nil {
		return nil, false
	}
	return o.VerifiableAddresses, true
}

// HasVerifiableAddresses returns a boolean if a field has been set.
func (o *AdminCreateIdentityBody) HasVerifiableAddresses() bool {
	if o != nil && o.VerifiableAddresses != nil {
		return true
	}

	return false
}

// SetVerifiableAddresses gets a reference to the given []VerifiableIdentityAddress and assigns it to the VerifiableAddresses field.
func (o *AdminCreateIdentityBody) SetVerifiableAddresses(v []VerifiableIdentityAddress) {
	o.VerifiableAddresses = v
}

func (o AdminCreateIdentityBody) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]interface{}{}
	if o.Credentials != nil {
		toSerialize["credentials"] = o.Credentials
	}
	if o.MetadataAdmin != nil {
		toSerialize["metadata_admin"] = o.MetadataAdmin
	}
	if o.MetadataPublic != nil {
		toSerialize["metadata_public"] = o.MetadataPublic
	}
	if o.RecoveryAddresses != nil {
		toSerialize["recovery_addresses"] = o.RecoveryAddresses
	}
	if true {
		toSerialize["schema_id"] = o.SchemaId
	}
	if o.State != nil {
		toSerialize["state"] = o.State
	}
	if true {
		toSerialize["traits"] = o.Traits
	}
	if o.VerifiableAddresses != nil {
		toSerialize["verifiable_addresses"] = o.VerifiableAddresses
	}
	return json.Marshal(toSerialize)
}

type NullableAdminCreateIdentityBody struct {
	value *AdminCreateIdentityBody
	isSet bool
}

func (v NullableAdminCreateIdentityBody) Get() *AdminCreateIdentityBody {
	return v.value
}

func (v *NullableAdminCreateIdentityBody) Set(val *AdminCreateIdentityBody) {
	v.value = val
	v.isSet = true
}

func (v NullableAdminCreateIdentityBody) IsSet() bool {
	return v.isSet
}

func (v *NullableAdminCreateIdentityBody) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableAdminCreateIdentityBody(val *AdminCreateIdentityBody) *NullableAdminCreateIdentityBody {
	return &NullableAdminCreateIdentityBody{value: val, isSet: true}
}

func (v NullableAdminCreateIdentityBody) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableAdminCreateIdentityBody) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


