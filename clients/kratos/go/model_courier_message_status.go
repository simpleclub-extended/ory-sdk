/*
Ory Identities API

This is the API specification for Ory Identities with features such as registration, login, recovery, account verification, profile settings, password reset, identity management, session management, email and sms delivery, and more. 

API version: v0.11.1
Contact: office@ory.sh
*/

// Code generated by OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.

package client

import (
	"encoding/json"
	"fmt"
)

// CourierMessageStatus A Message's Status
type CourierMessageStatus string

// List of courierMessageStatus
const (
	COURIERMESSAGESTATUS_QUEUED CourierMessageStatus = "queued"
	COURIERMESSAGESTATUS_SENT CourierMessageStatus = "sent"
	COURIERMESSAGESTATUS_PROCESSING CourierMessageStatus = "processing"
	COURIERMESSAGESTATUS_ABANDONED CourierMessageStatus = "abandoned"
)

// All allowed values of CourierMessageStatus enum
var AllowedCourierMessageStatusEnumValues = []CourierMessageStatus{
	"queued",
	"sent",
	"processing",
	"abandoned",
}

func (v *CourierMessageStatus) UnmarshalJSON(src []byte) error {
	var value string
	err := json.Unmarshal(src, &value)
	if err != nil {
		return err
	}
	enumTypeValue := CourierMessageStatus(value)
	for _, existing := range AllowedCourierMessageStatusEnumValues {
		if existing == enumTypeValue {
			*v = enumTypeValue
			return nil
		}
	}

	return fmt.Errorf("%+v is not a valid CourierMessageStatus", value)
}

// NewCourierMessageStatusFromValue returns a pointer to a valid CourierMessageStatus
// for the value passed as argument, or an error if the value passed is not allowed by the enum
func NewCourierMessageStatusFromValue(v string) (*CourierMessageStatus, error) {
	ev := CourierMessageStatus(v)
	if ev.IsValid() {
		return &ev, nil
	} else {
		return nil, fmt.Errorf("invalid value '%v' for CourierMessageStatus: valid values are %v", v, AllowedCourierMessageStatusEnumValues)
	}
}

// IsValid return true if the value is valid for the enum, false otherwise
func (v CourierMessageStatus) IsValid() bool {
	for _, existing := range AllowedCourierMessageStatusEnumValues {
		if existing == v {
			return true
		}
	}
	return false
}

// Ptr returns reference to courierMessageStatus value
func (v CourierMessageStatus) Ptr() *CourierMessageStatus {
	return &v
}

type NullableCourierMessageStatus struct {
	value *CourierMessageStatus
	isSet bool
}

func (v NullableCourierMessageStatus) Get() *CourierMessageStatus {
	return v.value
}

func (v *NullableCourierMessageStatus) Set(val *CourierMessageStatus) {
	v.value = val
	v.isSet = true
}

func (v NullableCourierMessageStatus) IsSet() bool {
	return v.isSet
}

func (v *NullableCourierMessageStatus) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableCourierMessageStatus(val *CourierMessageStatus) *NullableCourierMessageStatus {
	return &NullableCourierMessageStatus{value: val, isSet: true}
}

func (v NullableCourierMessageStatus) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableCourierMessageStatus) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}

