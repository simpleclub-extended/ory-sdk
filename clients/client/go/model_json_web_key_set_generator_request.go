/*
Ory APIs

Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 

API version: v0.2.0-alpha.38
Contact: support@ory.sh
*/

// Code generated by OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.

package client

import (
	"encoding/json"
)

// JsonWebKeySetGeneratorRequest struct for JsonWebKeySetGeneratorRequest
type JsonWebKeySetGeneratorRequest struct {
	// The algorithm to be used for creating the key. Supports \"RS256\", \"ES256\", \"ES512\", \"HS512\", and \"HS256\"
	Alg string `json:"alg"`
	// The kid of the key to be created
	Kid string `json:"kid"`
	// The \"use\" (public key use) parameter identifies the intended use of the public key. The \"use\" parameter is employed to indicate whether a public key is used for encrypting data or verifying the signature on data. Valid values are \"enc\" and \"sig\".
	Use string `json:"use"`
}

// NewJsonWebKeySetGeneratorRequest instantiates a new JsonWebKeySetGeneratorRequest object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewJsonWebKeySetGeneratorRequest(alg string, kid string, use string) *JsonWebKeySetGeneratorRequest {
	this := JsonWebKeySetGeneratorRequest{}
	this.Alg = alg
	this.Kid = kid
	this.Use = use
	return &this
}

// NewJsonWebKeySetGeneratorRequestWithDefaults instantiates a new JsonWebKeySetGeneratorRequest object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewJsonWebKeySetGeneratorRequestWithDefaults() *JsonWebKeySetGeneratorRequest {
	this := JsonWebKeySetGeneratorRequest{}
	return &this
}

// GetAlg returns the Alg field value
func (o *JsonWebKeySetGeneratorRequest) GetAlg() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.Alg
}

// GetAlgOk returns a tuple with the Alg field value
// and a boolean to check if the value has been set.
func (o *JsonWebKeySetGeneratorRequest) GetAlgOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.Alg, true
}

// SetAlg sets field value
func (o *JsonWebKeySetGeneratorRequest) SetAlg(v string) {
	o.Alg = v
}

// GetKid returns the Kid field value
func (o *JsonWebKeySetGeneratorRequest) GetKid() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.Kid
}

// GetKidOk returns a tuple with the Kid field value
// and a boolean to check if the value has been set.
func (o *JsonWebKeySetGeneratorRequest) GetKidOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.Kid, true
}

// SetKid sets field value
func (o *JsonWebKeySetGeneratorRequest) SetKid(v string) {
	o.Kid = v
}

// GetUse returns the Use field value
func (o *JsonWebKeySetGeneratorRequest) GetUse() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.Use
}

// GetUseOk returns a tuple with the Use field value
// and a boolean to check if the value has been set.
func (o *JsonWebKeySetGeneratorRequest) GetUseOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.Use, true
}

// SetUse sets field value
func (o *JsonWebKeySetGeneratorRequest) SetUse(v string) {
	o.Use = v
}

func (o JsonWebKeySetGeneratorRequest) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]interface{}{}
	if true {
		toSerialize["alg"] = o.Alg
	}
	if true {
		toSerialize["kid"] = o.Kid
	}
	if true {
		toSerialize["use"] = o.Use
	}
	return json.Marshal(toSerialize)
}

type NullableJsonWebKeySetGeneratorRequest struct {
	value *JsonWebKeySetGeneratorRequest
	isSet bool
}

func (v NullableJsonWebKeySetGeneratorRequest) Get() *JsonWebKeySetGeneratorRequest {
	return v.value
}

func (v *NullableJsonWebKeySetGeneratorRequest) Set(val *JsonWebKeySetGeneratorRequest) {
	v.value = val
	v.isSet = true
}

func (v NullableJsonWebKeySetGeneratorRequest) IsSet() bool {
	return v.isSet
}

func (v *NullableJsonWebKeySetGeneratorRequest) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableJsonWebKeySetGeneratorRequest(val *JsonWebKeySetGeneratorRequest) *NullableJsonWebKeySetGeneratorRequest {
	return &NullableJsonWebKeySetGeneratorRequest{value: val, isSet: true}
}

func (v NullableJsonWebKeySetGeneratorRequest) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableJsonWebKeySetGeneratorRequest) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


