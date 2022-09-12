/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.2.0-alpha.38
 * Contact: support@ory.sh
 * Generated by: https://openapi-generator.tech
 */




#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
pub struct FlushInactiveOAuth2TokensRequest {
    /// NotAfter sets after which point tokens should not be flushed. This is useful when you want to keep a history of recently issued tokens for auditing.
    #[serde(rename = "notAfter", skip_serializing_if = "Option::is_none")]
    pub not_after: Option<String>,
}

impl Default for FlushInactiveOAuth2TokensRequest {
    fn default() -> Self {
        Self::new()
    }
}

impl FlushInactiveOAuth2TokensRequest {
    pub fn new() -> FlushInactiveOAuth2TokensRequest {
        FlushInactiveOAuth2TokensRequest {
                not_after: None,
        }
    }
}


