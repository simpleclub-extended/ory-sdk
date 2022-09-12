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
pub struct TrustedJwtGrantIssuer {
    /// The \"allow_any_subject\" indicates that the issuer is allowed to have any principal as the subject of the JWT.
    #[serde(rename = "allow_any_subject", skip_serializing_if = "Option::is_none")]
    pub allow_any_subject: Option<bool>,
    /// The \"created_at\" indicates, when grant was created.
    #[serde(rename = "created_at", skip_serializing_if = "Option::is_none")]
    pub created_at: Option<String>,
    /// The \"expires_at\" indicates, when grant will expire, so we will reject assertion from \"issuer\" targeting \"subject\".
    #[serde(rename = "expires_at", skip_serializing_if = "Option::is_none")]
    pub expires_at: Option<String>,
    #[serde(rename = "id", skip_serializing_if = "Option::is_none")]
    pub id: Option<String>,
    /// The \"issuer\" identifies the principal that issued the JWT assertion (same as \"iss\" claim in JWT).
    #[serde(rename = "issuer", skip_serializing_if = "Option::is_none")]
    pub issuer: Option<String>,
    #[serde(rename = "public_key", skip_serializing_if = "Option::is_none")]
    pub public_key: Option<Box<crate::models::TrustedJsonWebKey>>,
    /// The \"scope\" contains list of scope values (as described in Section 3.3 of OAuth 2.0 [RFC6749])
    #[serde(rename = "scope", skip_serializing_if = "Option::is_none")]
    pub scope: Option<Vec<String>>,
    /// The \"subject\" identifies the principal that is the subject of the JWT.
    #[serde(rename = "subject", skip_serializing_if = "Option::is_none")]
    pub subject: Option<String>,
}

impl Default for TrustedJwtGrantIssuer {
    fn default() -> Self {
        Self::new()
    }
}

impl TrustedJwtGrantIssuer {
    pub fn new() -> TrustedJwtGrantIssuer {
        TrustedJwtGrantIssuer {
                allow_any_subject: None,
                created_at: None,
                expires_at: None,
                id: None,
                issuer: None,
                public_key: None,
                scope: None,
                subject: None,
        }
    }
}


