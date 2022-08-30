/*
Ory APIs

Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 

API version: v0.2.0-alpha.23
Contact: support@ory.sh
*/

// Code generated by OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.

package client

import (
	"encoding/json"
)

// IsReady503Response struct for IsReady503Response
type IsReady503Response struct {
	// Errors contains a list of errors that caused the not ready status.
	Errors map[string]string `json:"errors"`
}

// NewIsReady503Response instantiates a new IsReady503Response object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewIsReady503Response(errors map[string]string) *IsReady503Response {
	this := IsReady503Response{}
	this.Errors = errors
	return &this
}

// NewIsReady503ResponseWithDefaults instantiates a new IsReady503Response object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewIsReady503ResponseWithDefaults() *IsReady503Response {
	this := IsReady503Response{}
	return &this
}

// GetErrors returns the Errors field value
func (o *IsReady503Response) GetErrors() map[string]string {
	if o == nil {
		var ret map[string]string
		return ret
	}

	return o.Errors
}

// GetErrorsOk returns a tuple with the Errors field value
// and a boolean to check if the value has been set.
func (o *IsReady503Response) GetErrorsOk() (*map[string]string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.Errors, true
}

// SetErrors sets field value
func (o *IsReady503Response) SetErrors(v map[string]string) {
	o.Errors = v
}

func (o IsReady503Response) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]interface{}{}
	if true {
		toSerialize["errors"] = o.Errors
	}
	return json.Marshal(toSerialize)
}

type NullableIsReady503Response struct {
	value *IsReady503Response
	isSet bool
}

func (v NullableIsReady503Response) Get() *IsReady503Response {
	return v.value
}

func (v *NullableIsReady503Response) Set(val *IsReady503Response) {
	v.value = val
	v.isSet = true
}

func (v NullableIsReady503Response) IsSet() bool {
	return v.isSet
}

func (v *NullableIsReady503Response) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableIsReady503Response(val *IsReady503Response) *NullableIsReady503Response {
	return &NullableIsReady503Response{value: val, isSet: true}
}

func (v NullableIsReady503Response) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableIsReady503Response) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


