/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * API version: v0.0.1-alpha.71
 * Contact: support@ory.sh
 */

// Code generated by OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.

package client

import (
	"encoding/json"
	"time"
)

// ProjectRevisionIdentitySchema struct for ProjectRevisionIdentitySchema
type ProjectRevisionIdentitySchema struct {
	// The Project's Revision Creation Date
	CreatedAt *time.Time `json:"created_at,omitempty"`
	Id *string `json:"id,omitempty"`
	IdentitySchema *IdentitySchema `json:"identity_schema,omitempty"`
	IdentitySchemaId *string `json:"identity_schema_id,omitempty"`
	// The imported (named) ID of the Identity Schema referenced in the Ory Kratos config.
	ImportId *string `json:"import_id,omitempty"`
	// The ImportURL can be used to import an Identity Schema from a bse64 encoded string. In the future, this key also support HTTPS and other sources!  If you import an Ory Kratos configuration, this would be akin to the `identity.schemas.#.url` key.  The configuration will always return the import URL when you fetch it from the API.
	ImportUrl *string `json:"import_url,omitempty"`
	// If true sets the default schema for identities  Only one schema can ever be the default schema. If you try to add two schemas with default to true, the request will fail.
	IsDefault *bool `json:"is_default,omitempty"`
	// Use a preset instead of a custom identity schema.
	Preset *string `json:"preset,omitempty"`
	ProjectRevisionId *string `json:"project_revision_id,omitempty"`
	// Last Time Project's Revision was Updated
	UpdatedAt *time.Time `json:"updated_at,omitempty"`
}

// NewProjectRevisionIdentitySchema instantiates a new ProjectRevisionIdentitySchema object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewProjectRevisionIdentitySchema() *ProjectRevisionIdentitySchema {
	this := ProjectRevisionIdentitySchema{}
	return &this
}

// NewProjectRevisionIdentitySchemaWithDefaults instantiates a new ProjectRevisionIdentitySchema object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewProjectRevisionIdentitySchemaWithDefaults() *ProjectRevisionIdentitySchema {
	this := ProjectRevisionIdentitySchema{}
	return &this
}

// GetCreatedAt returns the CreatedAt field value if set, zero value otherwise.
func (o *ProjectRevisionIdentitySchema) GetCreatedAt() time.Time {
	if o == nil || o.CreatedAt == nil {
		var ret time.Time
		return ret
	}
	return *o.CreatedAt
}

// GetCreatedAtOk returns a tuple with the CreatedAt field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *ProjectRevisionIdentitySchema) GetCreatedAtOk() (*time.Time, bool) {
	if o == nil || o.CreatedAt == nil {
		return nil, false
	}
	return o.CreatedAt, true
}

// HasCreatedAt returns a boolean if a field has been set.
func (o *ProjectRevisionIdentitySchema) HasCreatedAt() bool {
	if o != nil && o.CreatedAt != nil {
		return true
	}

	return false
}

// SetCreatedAt gets a reference to the given time.Time and assigns it to the CreatedAt field.
func (o *ProjectRevisionIdentitySchema) SetCreatedAt(v time.Time) {
	o.CreatedAt = &v
}

// GetId returns the Id field value if set, zero value otherwise.
func (o *ProjectRevisionIdentitySchema) GetId() string {
	if o == nil || o.Id == nil {
		var ret string
		return ret
	}
	return *o.Id
}

// GetIdOk returns a tuple with the Id field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *ProjectRevisionIdentitySchema) GetIdOk() (*string, bool) {
	if o == nil || o.Id == nil {
		return nil, false
	}
	return o.Id, true
}

// HasId returns a boolean if a field has been set.
func (o *ProjectRevisionIdentitySchema) HasId() bool {
	if o != nil && o.Id != nil {
		return true
	}

	return false
}

// SetId gets a reference to the given string and assigns it to the Id field.
func (o *ProjectRevisionIdentitySchema) SetId(v string) {
	o.Id = &v
}

// GetIdentitySchema returns the IdentitySchema field value if set, zero value otherwise.
func (o *ProjectRevisionIdentitySchema) GetIdentitySchema() IdentitySchema {
	if o == nil || o.IdentitySchema == nil {
		var ret IdentitySchema
		return ret
	}
	return *o.IdentitySchema
}

// GetIdentitySchemaOk returns a tuple with the IdentitySchema field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *ProjectRevisionIdentitySchema) GetIdentitySchemaOk() (*IdentitySchema, bool) {
	if o == nil || o.IdentitySchema == nil {
		return nil, false
	}
	return o.IdentitySchema, true
}

// HasIdentitySchema returns a boolean if a field has been set.
func (o *ProjectRevisionIdentitySchema) HasIdentitySchema() bool {
	if o != nil && o.IdentitySchema != nil {
		return true
	}

	return false
}

// SetIdentitySchema gets a reference to the given IdentitySchema and assigns it to the IdentitySchema field.
func (o *ProjectRevisionIdentitySchema) SetIdentitySchema(v IdentitySchema) {
	o.IdentitySchema = &v
}

// GetIdentitySchemaId returns the IdentitySchemaId field value if set, zero value otherwise.
func (o *ProjectRevisionIdentitySchema) GetIdentitySchemaId() string {
	if o == nil || o.IdentitySchemaId == nil {
		var ret string
		return ret
	}
	return *o.IdentitySchemaId
}

// GetIdentitySchemaIdOk returns a tuple with the IdentitySchemaId field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *ProjectRevisionIdentitySchema) GetIdentitySchemaIdOk() (*string, bool) {
	if o == nil || o.IdentitySchemaId == nil {
		return nil, false
	}
	return o.IdentitySchemaId, true
}

// HasIdentitySchemaId returns a boolean if a field has been set.
func (o *ProjectRevisionIdentitySchema) HasIdentitySchemaId() bool {
	if o != nil && o.IdentitySchemaId != nil {
		return true
	}

	return false
}

// SetIdentitySchemaId gets a reference to the given string and assigns it to the IdentitySchemaId field.
func (o *ProjectRevisionIdentitySchema) SetIdentitySchemaId(v string) {
	o.IdentitySchemaId = &v
}

// GetImportId returns the ImportId field value if set, zero value otherwise.
func (o *ProjectRevisionIdentitySchema) GetImportId() string {
	if o == nil || o.ImportId == nil {
		var ret string
		return ret
	}
	return *o.ImportId
}

// GetImportIdOk returns a tuple with the ImportId field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *ProjectRevisionIdentitySchema) GetImportIdOk() (*string, bool) {
	if o == nil || o.ImportId == nil {
		return nil, false
	}
	return o.ImportId, true
}

// HasImportId returns a boolean if a field has been set.
func (o *ProjectRevisionIdentitySchema) HasImportId() bool {
	if o != nil && o.ImportId != nil {
		return true
	}

	return false
}

// SetImportId gets a reference to the given string and assigns it to the ImportId field.
func (o *ProjectRevisionIdentitySchema) SetImportId(v string) {
	o.ImportId = &v
}

// GetImportUrl returns the ImportUrl field value if set, zero value otherwise.
func (o *ProjectRevisionIdentitySchema) GetImportUrl() string {
	if o == nil || o.ImportUrl == nil {
		var ret string
		return ret
	}
	return *o.ImportUrl
}

// GetImportUrlOk returns a tuple with the ImportUrl field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *ProjectRevisionIdentitySchema) GetImportUrlOk() (*string, bool) {
	if o == nil || o.ImportUrl == nil {
		return nil, false
	}
	return o.ImportUrl, true
}

// HasImportUrl returns a boolean if a field has been set.
func (o *ProjectRevisionIdentitySchema) HasImportUrl() bool {
	if o != nil && o.ImportUrl != nil {
		return true
	}

	return false
}

// SetImportUrl gets a reference to the given string and assigns it to the ImportUrl field.
func (o *ProjectRevisionIdentitySchema) SetImportUrl(v string) {
	o.ImportUrl = &v
}

// GetIsDefault returns the IsDefault field value if set, zero value otherwise.
func (o *ProjectRevisionIdentitySchema) GetIsDefault() bool {
	if o == nil || o.IsDefault == nil {
		var ret bool
		return ret
	}
	return *o.IsDefault
}

// GetIsDefaultOk returns a tuple with the IsDefault field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *ProjectRevisionIdentitySchema) GetIsDefaultOk() (*bool, bool) {
	if o == nil || o.IsDefault == nil {
		return nil, false
	}
	return o.IsDefault, true
}

// HasIsDefault returns a boolean if a field has been set.
func (o *ProjectRevisionIdentitySchema) HasIsDefault() bool {
	if o != nil && o.IsDefault != nil {
		return true
	}

	return false
}

// SetIsDefault gets a reference to the given bool and assigns it to the IsDefault field.
func (o *ProjectRevisionIdentitySchema) SetIsDefault(v bool) {
	o.IsDefault = &v
}

// GetPreset returns the Preset field value if set, zero value otherwise.
func (o *ProjectRevisionIdentitySchema) GetPreset() string {
	if o == nil || o.Preset == nil {
		var ret string
		return ret
	}
	return *o.Preset
}

// GetPresetOk returns a tuple with the Preset field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *ProjectRevisionIdentitySchema) GetPresetOk() (*string, bool) {
	if o == nil || o.Preset == nil {
		return nil, false
	}
	return o.Preset, true
}

// HasPreset returns a boolean if a field has been set.
func (o *ProjectRevisionIdentitySchema) HasPreset() bool {
	if o != nil && o.Preset != nil {
		return true
	}

	return false
}

// SetPreset gets a reference to the given string and assigns it to the Preset field.
func (o *ProjectRevisionIdentitySchema) SetPreset(v string) {
	o.Preset = &v
}

// GetProjectRevisionId returns the ProjectRevisionId field value if set, zero value otherwise.
func (o *ProjectRevisionIdentitySchema) GetProjectRevisionId() string {
	if o == nil || o.ProjectRevisionId == nil {
		var ret string
		return ret
	}
	return *o.ProjectRevisionId
}

// GetProjectRevisionIdOk returns a tuple with the ProjectRevisionId field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *ProjectRevisionIdentitySchema) GetProjectRevisionIdOk() (*string, bool) {
	if o == nil || o.ProjectRevisionId == nil {
		return nil, false
	}
	return o.ProjectRevisionId, true
}

// HasProjectRevisionId returns a boolean if a field has been set.
func (o *ProjectRevisionIdentitySchema) HasProjectRevisionId() bool {
	if o != nil && o.ProjectRevisionId != nil {
		return true
	}

	return false
}

// SetProjectRevisionId gets a reference to the given string and assigns it to the ProjectRevisionId field.
func (o *ProjectRevisionIdentitySchema) SetProjectRevisionId(v string) {
	o.ProjectRevisionId = &v
}

// GetUpdatedAt returns the UpdatedAt field value if set, zero value otherwise.
func (o *ProjectRevisionIdentitySchema) GetUpdatedAt() time.Time {
	if o == nil || o.UpdatedAt == nil {
		var ret time.Time
		return ret
	}
	return *o.UpdatedAt
}

// GetUpdatedAtOk returns a tuple with the UpdatedAt field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *ProjectRevisionIdentitySchema) GetUpdatedAtOk() (*time.Time, bool) {
	if o == nil || o.UpdatedAt == nil {
		return nil, false
	}
	return o.UpdatedAt, true
}

// HasUpdatedAt returns a boolean if a field has been set.
func (o *ProjectRevisionIdentitySchema) HasUpdatedAt() bool {
	if o != nil && o.UpdatedAt != nil {
		return true
	}

	return false
}

// SetUpdatedAt gets a reference to the given time.Time and assigns it to the UpdatedAt field.
func (o *ProjectRevisionIdentitySchema) SetUpdatedAt(v time.Time) {
	o.UpdatedAt = &v
}

func (o ProjectRevisionIdentitySchema) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]interface{}{}
	if o.CreatedAt != nil {
		toSerialize["created_at"] = o.CreatedAt
	}
	if o.Id != nil {
		toSerialize["id"] = o.Id
	}
	if o.IdentitySchema != nil {
		toSerialize["identity_schema"] = o.IdentitySchema
	}
	if o.IdentitySchemaId != nil {
		toSerialize["identity_schema_id"] = o.IdentitySchemaId
	}
	if o.ImportId != nil {
		toSerialize["import_id"] = o.ImportId
	}
	if o.ImportUrl != nil {
		toSerialize["import_url"] = o.ImportUrl
	}
	if o.IsDefault != nil {
		toSerialize["is_default"] = o.IsDefault
	}
	if o.Preset != nil {
		toSerialize["preset"] = o.Preset
	}
	if o.ProjectRevisionId != nil {
		toSerialize["project_revision_id"] = o.ProjectRevisionId
	}
	if o.UpdatedAt != nil {
		toSerialize["updated_at"] = o.UpdatedAt
	}
	return json.Marshal(toSerialize)
}

type NullableProjectRevisionIdentitySchema struct {
	value *ProjectRevisionIdentitySchema
	isSet bool
}

func (v NullableProjectRevisionIdentitySchema) Get() *ProjectRevisionIdentitySchema {
	return v.value
}

func (v *NullableProjectRevisionIdentitySchema) Set(val *ProjectRevisionIdentitySchema) {
	v.value = val
	v.isSet = true
}

func (v NullableProjectRevisionIdentitySchema) IsSet() bool {
	return v.isSet
}

func (v *NullableProjectRevisionIdentitySchema) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableProjectRevisionIdentitySchema(val *ProjectRevisionIdentitySchema) *NullableProjectRevisionIdentitySchema {
	return &NullableProjectRevisionIdentitySchema{value: val, isSet: true}
}

func (v NullableProjectRevisionIdentitySchema) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableProjectRevisionIdentitySchema) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


