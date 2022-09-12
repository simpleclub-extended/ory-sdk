/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.2.0-alpha.38
 * Contact: support@ory.sh
 * Generated by: https://openapi-generator.tech
 */

/// PatchDocument : A JSONPatch document as defined by RFC 6902



#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
pub struct PatchDocument {
    /// A JSON-pointer
    #[serde(rename = "from", skip_serializing_if = "Option::is_none")]
    pub from: Option<String>,
    /// The operation to be performed
    #[serde(rename = "op")]
    pub op: String,
    /// A JSON-pointer
    #[serde(rename = "path")]
    pub path: String,
    /// The value to be used within the operations
    #[serde(rename = "value", skip_serializing_if = "Option::is_none")]
    pub value: Option<serde_json::Value>,
}


impl PatchDocument {
    /// A JSONPatch document as defined by RFC 6902
    pub fn new(op: String, path: String) -> PatchDocument {
        PatchDocument {
                from: None,
                op,
                path,
                value: None,
        }
    }
}


