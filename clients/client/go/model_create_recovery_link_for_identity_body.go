/*
Ory APIs

Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 

API version: v1.1.2
Contact: support@ory.sh
*/

// Code generated by OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.

package client

import (
	"encoding/json"
)

// CreateRecoveryLinkForIdentityBody Create Recovery Link for Identity Request Body
type CreateRecoveryLinkForIdentityBody struct {
	// Link Expires In  The recovery link will expire after that amount of time has passed. Defaults to the configuration value of `selfservice.methods.code.config.lifespan`.
	ExpiresIn *string `json:"expires_in,omitempty"`
	// Identity to Recover  The identity's ID you wish to recover.
	IdentityId string `json:"identity_id"`
}

// NewCreateRecoveryLinkForIdentityBody instantiates a new CreateRecoveryLinkForIdentityBody object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewCreateRecoveryLinkForIdentityBody(identityId string) *CreateRecoveryLinkForIdentityBody {
	this := CreateRecoveryLinkForIdentityBody{}
	this.IdentityId = identityId
	return &this
}

// NewCreateRecoveryLinkForIdentityBodyWithDefaults instantiates a new CreateRecoveryLinkForIdentityBody object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewCreateRecoveryLinkForIdentityBodyWithDefaults() *CreateRecoveryLinkForIdentityBody {
	this := CreateRecoveryLinkForIdentityBody{}
	return &this
}

// GetExpiresIn returns the ExpiresIn field value if set, zero value otherwise.
func (o *CreateRecoveryLinkForIdentityBody) GetExpiresIn() string {
	if o == nil || o.ExpiresIn == nil {
		var ret string
		return ret
	}
	return *o.ExpiresIn
}

// GetExpiresInOk returns a tuple with the ExpiresIn field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *CreateRecoveryLinkForIdentityBody) GetExpiresInOk() (*string, bool) {
	if o == nil || o.ExpiresIn == nil {
		return nil, false
	}
	return o.ExpiresIn, true
}

// HasExpiresIn returns a boolean if a field has been set.
func (o *CreateRecoveryLinkForIdentityBody) HasExpiresIn() bool {
	if o != nil && o.ExpiresIn != nil {
		return true
	}

	return false
}

// SetExpiresIn gets a reference to the given string and assigns it to the ExpiresIn field.
func (o *CreateRecoveryLinkForIdentityBody) SetExpiresIn(v string) {
	o.ExpiresIn = &v
}

// GetIdentityId returns the IdentityId field value
func (o *CreateRecoveryLinkForIdentityBody) GetIdentityId() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.IdentityId
}

// GetIdentityIdOk returns a tuple with the IdentityId field value
// and a boolean to check if the value has been set.
func (o *CreateRecoveryLinkForIdentityBody) GetIdentityIdOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.IdentityId, true
}

// SetIdentityId sets field value
func (o *CreateRecoveryLinkForIdentityBody) SetIdentityId(v string) {
	o.IdentityId = v
}

func (o CreateRecoveryLinkForIdentityBody) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]interface{}{}
	if o.ExpiresIn != nil {
		toSerialize["expires_in"] = o.ExpiresIn
	}
	if true {
		toSerialize["identity_id"] = o.IdentityId
	}
	return json.Marshal(toSerialize)
}

type NullableCreateRecoveryLinkForIdentityBody struct {
	value *CreateRecoveryLinkForIdentityBody
	isSet bool
}

func (v NullableCreateRecoveryLinkForIdentityBody) Get() *CreateRecoveryLinkForIdentityBody {
	return v.value
}

func (v *NullableCreateRecoveryLinkForIdentityBody) Set(val *CreateRecoveryLinkForIdentityBody) {
	v.value = val
	v.isSet = true
}

func (v NullableCreateRecoveryLinkForIdentityBody) IsSet() bool {
	return v.isSet
}

func (v *NullableCreateRecoveryLinkForIdentityBody) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableCreateRecoveryLinkForIdentityBody(val *CreateRecoveryLinkForIdentityBody) *NullableCreateRecoveryLinkForIdentityBody {
	return &NullableCreateRecoveryLinkForIdentityBody{value: val, isSet: true}
}

func (v NullableCreateRecoveryLinkForIdentityBody) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableCreateRecoveryLinkForIdentityBody) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


