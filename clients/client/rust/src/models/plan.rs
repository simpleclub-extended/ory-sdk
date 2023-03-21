/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.1.23
 * Contact: support@ory.sh
 * Generated by: https://openapi-generator.tech
 */




#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
pub struct Plan {
    /// Name is the name of the plan.
    #[serde(rename = "name")]
    pub name: String,
    /// Version is the version of the plan. The combination of `name@version` must be unique.
    #[serde(rename = "version")]
    pub version: i64,
}


impl Plan {
    pub fn new(name: String, version: i64) -> Plan {
        Plan {
                name,
                version,
        }
    }
}


