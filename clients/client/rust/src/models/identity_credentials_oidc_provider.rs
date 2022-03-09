/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.0.1-alpha.123
 * Contact: support@ory.sh
 * Generated by: https://openapi-generator.tech
 */




#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
pub struct IdentityCredentialsOidcProvider {
    #[serde(rename = "initial_access_token", skip_serializing_if = "Option::is_none")]
    pub initial_access_token: Option<String>,
    #[serde(rename = "initial_id_token", skip_serializing_if = "Option::is_none")]
    pub initial_id_token: Option<String>,
    #[serde(rename = "initial_refresh_token", skip_serializing_if = "Option::is_none")]
    pub initial_refresh_token: Option<String>,
    #[serde(rename = "provider", skip_serializing_if = "Option::is_none")]
    pub provider: Option<String>,
    #[serde(rename = "subject", skip_serializing_if = "Option::is_none")]
    pub subject: Option<String>,
}

impl IdentityCredentialsOidcProvider {
    pub fn new() -> IdentityCredentialsOidcProvider {
        IdentityCredentialsOidcProvider {
            initial_access_token: None,
            initial_id_token: None,
            initial_refresh_token: None,
            provider: None,
            subject: None,
        }
    }
}


