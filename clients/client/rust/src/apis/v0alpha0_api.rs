/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.0.1-alpha.103
 * Contact: support@ory.sh
 * Generated by: https://openapi-generator.tech
 */


use reqwest;

use crate::apis::ResponseContent;
use super::{Error, configuration};


/// struct for typed errors of method `create_project`
#[derive(Debug, Clone, Serialize, Deserialize)]
#[serde(untagged)]
pub enum CreateProjectError {
    Status401(crate::models::GenericError),
    Status403(crate::models::GenericError),
    Status404(crate::models::GenericError),
    DefaultResponse(crate::models::GenericError),
    UnknownValue(serde_json::Value),
}

/// struct for typed errors of method `get_active_project`
#[derive(Debug, Clone, Serialize, Deserialize)]
#[serde(untagged)]
pub enum GetActiveProjectError {
    Status401(crate::models::GenericError),
    DefaultResponse(crate::models::GenericError),
    UnknownValue(serde_json::Value),
}

/// struct for typed errors of method `get_project`
#[derive(Debug, Clone, Serialize, Deserialize)]
#[serde(untagged)]
pub enum GetProjectError {
    Status401(crate::models::GenericError),
    Status403(crate::models::GenericError),
    Status404(crate::models::GenericError),
    DefaultResponse(crate::models::GenericError),
    UnknownValue(serde_json::Value),
}

/// struct for typed errors of method `get_project_members`
#[derive(Debug, Clone, Serialize, Deserialize)]
#[serde(untagged)]
pub enum GetProjectMembersError {
    Status401(crate::models::GenericError),
    Status406(crate::models::GenericError),
    Status500(crate::models::GenericError),
    UnknownValue(serde_json::Value),
}

/// struct for typed errors of method `list_projects`
#[derive(Debug, Clone, Serialize, Deserialize)]
#[serde(untagged)]
pub enum ListProjectsError {
    Status401(crate::models::GenericError),
    Status403(crate::models::GenericError),
    Status404(crate::models::GenericError),
    DefaultResponse(crate::models::GenericError),
    UnknownValue(serde_json::Value),
}

/// struct for typed errors of method `purge_project`
#[derive(Debug, Clone, Serialize, Deserialize)]
#[serde(untagged)]
pub enum PurgeProjectError {
    Status401(crate::models::GenericError),
    Status403(crate::models::GenericError),
    Status404(crate::models::GenericError),
    DefaultResponse(crate::models::GenericError),
    UnknownValue(serde_json::Value),
}

/// struct for typed errors of method `remove_project_member`
#[derive(Debug, Clone, Serialize, Deserialize)]
#[serde(untagged)]
pub enum RemoveProjectMemberError {
    Status400(crate::models::GenericError),
    Status401(crate::models::GenericError),
    Status406(crate::models::GenericError),
    Status500(crate::models::GenericError),
    UnknownValue(serde_json::Value),
}

/// struct for typed errors of method `set_active_project`
#[derive(Debug, Clone, Serialize, Deserialize)]
#[serde(untagged)]
pub enum SetActiveProjectError {
    Status401(crate::models::GenericError),
    DefaultResponse(crate::models::GenericError),
    UnknownValue(serde_json::Value),
}

/// struct for typed errors of method `update_project`
#[derive(Debug, Clone, Serialize, Deserialize)]
#[serde(untagged)]
pub enum UpdateProjectError {
    Status401(crate::models::GenericError),
    Status403(crate::models::GenericError),
    Status404(crate::models::GenericError),
    DefaultResponse(crate::models::GenericError),
    UnknownValue(serde_json::Value),
}

/// struct for typed errors of method `update_project_config`
#[derive(Debug, Clone, Serialize, Deserialize)]
#[serde(untagged)]
pub enum UpdateProjectConfigError {
    Status400(crate::models::GenericError),
    Status401(crate::models::GenericError),
    Status403(crate::models::GenericError),
    Status404(crate::models::GenericError),
    DefaultResponse(crate::models::GenericError),
    UnknownValue(serde_json::Value),
}


/// Creates a new project.
pub async fn create_project(configuration: &configuration::Configuration, project_revision: Option<crate::models::ProjectRevision>) -> Result<crate::models::Project, Error<CreateProjectError>> {

    let local_var_client = &configuration.client;

    let local_var_uri_str = format!("{}/backoffice/public/projects", configuration.base_path);
    let mut local_var_req_builder = local_var_client.request(reqwest::Method::POST, local_var_uri_str.as_str());

    if let Some(ref local_var_user_agent) = configuration.user_agent {
        local_var_req_builder = local_var_req_builder.header(reqwest::header::USER_AGENT, local_var_user_agent.clone());
    }
    if let Some(ref local_var_token) = configuration.bearer_access_token {
        local_var_req_builder = local_var_req_builder.bearer_auth(local_var_token.to_owned());
    };
    local_var_req_builder = local_var_req_builder.json(&project_revision);

    let local_var_req = local_var_req_builder.build()?;
    let local_var_resp = local_var_client.execute(local_var_req).await?;

    let local_var_status = local_var_resp.status();
    let local_var_content = local_var_resp.text().await?;

    if !local_var_status.is_client_error() && !local_var_status.is_server_error() {
        serde_json::from_str(&local_var_content).map_err(Error::from)
    } else {
        let local_var_entity: Option<CreateProjectError> = serde_json::from_str(&local_var_content).ok();
        let local_var_error = ResponseContent { status: local_var_status, content: local_var_content, entity: local_var_entity };
        Err(Error::ResponseError(local_var_error))
    }
}

/// Use this API to get your active project in the Ory Cloud Console UI.
pub async fn get_active_project(configuration: &configuration::Configuration, ) -> Result<crate::models::ActiveProject, Error<GetActiveProjectError>> {

    let local_var_client = &configuration.client;

    let local_var_uri_str = format!("{}/backoffice/public/console/projects/active", configuration.base_path);
    let mut local_var_req_builder = local_var_client.request(reqwest::Method::GET, local_var_uri_str.as_str());

    if let Some(ref local_var_user_agent) = configuration.user_agent {
        local_var_req_builder = local_var_req_builder.header(reqwest::header::USER_AGENT, local_var_user_agent.clone());
    }
    if let Some(ref local_var_token) = configuration.bearer_access_token {
        local_var_req_builder = local_var_req_builder.bearer_auth(local_var_token.to_owned());
    };

    let local_var_req = local_var_req_builder.build()?;
    let local_var_resp = local_var_client.execute(local_var_req).await?;

    let local_var_status = local_var_resp.status();
    let local_var_content = local_var_resp.text().await?;

    if !local_var_status.is_client_error() && !local_var_status.is_server_error() {
        serde_json::from_str(&local_var_content).map_err(Error::from)
    } else {
        let local_var_entity: Option<GetActiveProjectError> = serde_json::from_str(&local_var_content).ok();
        let local_var_error = ResponseContent { status: local_var_status, content: local_var_content, entity: local_var_entity };
        Err(Error::ResponseError(local_var_error))
    }
}

/// Get a projects you have access to by its ID.
pub async fn get_project(configuration: &configuration::Configuration, project_id: &str) -> Result<crate::models::Project, Error<GetProjectError>> {

    let local_var_client = &configuration.client;

    let local_var_uri_str = format!("{}/backoffice/public/projects/{project_id}", configuration.base_path, project_id=crate::apis::urlencode(project_id));
    let mut local_var_req_builder = local_var_client.request(reqwest::Method::GET, local_var_uri_str.as_str());

    if let Some(ref local_var_user_agent) = configuration.user_agent {
        local_var_req_builder = local_var_req_builder.header(reqwest::header::USER_AGENT, local_var_user_agent.clone());
    }
    if let Some(ref local_var_token) = configuration.bearer_access_token {
        local_var_req_builder = local_var_req_builder.bearer_auth(local_var_token.to_owned());
    };

    let local_var_req = local_var_req_builder.build()?;
    let local_var_resp = local_var_client.execute(local_var_req).await?;

    let local_var_status = local_var_resp.status();
    let local_var_content = local_var_resp.text().await?;

    if !local_var_status.is_client_error() && !local_var_status.is_server_error() {
        serde_json::from_str(&local_var_content).map_err(Error::from)
    } else {
        let local_var_entity: Option<GetProjectError> = serde_json::from_str(&local_var_content).ok();
        let local_var_error = ResponseContent { status: local_var_status, content: local_var_content, entity: local_var_entity };
        Err(Error::ResponseError(local_var_error))
    }
}

/// This endpoint requires the user to be a member of the project with the role `OWNER` or `DEVELOPER`.
pub async fn get_project_members(configuration: &configuration::Configuration, project_id: &str) -> Result<Vec<crate::models::CloudAccount>, Error<GetProjectMembersError>> {

    let local_var_client = &configuration.client;

    let local_var_uri_str = format!("{}/backoffice/public/projects/{project_id}/members", configuration.base_path, project_id=crate::apis::urlencode(project_id));
    let mut local_var_req_builder = local_var_client.request(reqwest::Method::GET, local_var_uri_str.as_str());

    if let Some(ref local_var_user_agent) = configuration.user_agent {
        local_var_req_builder = local_var_req_builder.header(reqwest::header::USER_AGENT, local_var_user_agent.clone());
    }
    if let Some(ref local_var_token) = configuration.bearer_access_token {
        local_var_req_builder = local_var_req_builder.bearer_auth(local_var_token.to_owned());
    };

    let local_var_req = local_var_req_builder.build()?;
    let local_var_resp = local_var_client.execute(local_var_req).await?;

    let local_var_status = local_var_resp.status();
    let local_var_content = local_var_resp.text().await?;

    if !local_var_status.is_client_error() && !local_var_status.is_server_error() {
        serde_json::from_str(&local_var_content).map_err(Error::from)
    } else {
        let local_var_entity: Option<GetProjectMembersError> = serde_json::from_str(&local_var_content).ok();
        let local_var_error = ResponseContent { status: local_var_status, content: local_var_content, entity: local_var_entity };
        Err(Error::ResponseError(local_var_error))
    }
}

/// Lists all projects you have access to.
pub async fn list_projects(configuration: &configuration::Configuration, ) -> Result<Vec<crate::models::Project>, Error<ListProjectsError>> {

    let local_var_client = &configuration.client;

    let local_var_uri_str = format!("{}/backoffice/public/projects", configuration.base_path);
    let mut local_var_req_builder = local_var_client.request(reqwest::Method::GET, local_var_uri_str.as_str());

    if let Some(ref local_var_user_agent) = configuration.user_agent {
        local_var_req_builder = local_var_req_builder.header(reqwest::header::USER_AGENT, local_var_user_agent.clone());
    }
    if let Some(ref local_var_token) = configuration.bearer_access_token {
        local_var_req_builder = local_var_req_builder.bearer_auth(local_var_token.to_owned());
    };

    let local_var_req = local_var_req_builder.build()?;
    let local_var_resp = local_var_client.execute(local_var_req).await?;

    let local_var_status = local_var_resp.status();
    let local_var_content = local_var_resp.text().await?;

    if !local_var_status.is_client_error() && !local_var_status.is_server_error() {
        serde_json::from_str(&local_var_content).map_err(Error::from)
    } else {
        let local_var_entity: Option<ListProjectsError> = serde_json::from_str(&local_var_content).ok();
        let local_var_error = ResponseContent { status: local_var_status, content: local_var_content, entity: local_var_entity };
        Err(Error::ResponseError(local_var_error))
    }
}

/// !! Use with extreme caution !!  Using this API endpoint you can purge (completely delete) a project and its data. This action can not be undone and will delete ALL your data.  !! Use with extreme caution !!
pub async fn purge_project(configuration: &configuration::Configuration, project_id: &str) -> Result<(), Error<PurgeProjectError>> {

    let local_var_client = &configuration.client;

    let local_var_uri_str = format!("{}/backoffice/public/projects/{project_id}", configuration.base_path, project_id=crate::apis::urlencode(project_id));
    let mut local_var_req_builder = local_var_client.request(reqwest::Method::DELETE, local_var_uri_str.as_str());

    if let Some(ref local_var_user_agent) = configuration.user_agent {
        local_var_req_builder = local_var_req_builder.header(reqwest::header::USER_AGENT, local_var_user_agent.clone());
    }
    if let Some(ref local_var_token) = configuration.bearer_access_token {
        local_var_req_builder = local_var_req_builder.bearer_auth(local_var_token.to_owned());
    };

    let local_var_req = local_var_req_builder.build()?;
    let local_var_resp = local_var_client.execute(local_var_req).await?;

    let local_var_status = local_var_resp.status();
    let local_var_content = local_var_resp.text().await?;

    if !local_var_status.is_client_error() && !local_var_status.is_server_error() {
        Ok(())
    } else {
        let local_var_entity: Option<PurgeProjectError> = serde_json::from_str(&local_var_content).ok();
        let local_var_error = ResponseContent { status: local_var_status, content: local_var_content, entity: local_var_entity };
        Err(Error::ResponseError(local_var_error))
    }
}

/// This endpoint requires the user to be a member of the project with the role `OWNER`.
pub async fn remove_project_member(configuration: &configuration::Configuration, project_id: &str, member_id: &str) -> Result<(), Error<RemoveProjectMemberError>> {

    let local_var_client = &configuration.client;

    let local_var_uri_str = format!("{}/backoffice/public/projects/{project_id}/members/{member_id}", configuration.base_path, project_id=crate::apis::urlencode(project_id), member_id=crate::apis::urlencode(member_id));
    let mut local_var_req_builder = local_var_client.request(reqwest::Method::DELETE, local_var_uri_str.as_str());

    if let Some(ref local_var_user_agent) = configuration.user_agent {
        local_var_req_builder = local_var_req_builder.header(reqwest::header::USER_AGENT, local_var_user_agent.clone());
    }
    if let Some(ref local_var_token) = configuration.bearer_access_token {
        local_var_req_builder = local_var_req_builder.bearer_auth(local_var_token.to_owned());
    };

    let local_var_req = local_var_req_builder.build()?;
    let local_var_resp = local_var_client.execute(local_var_req).await?;

    let local_var_status = local_var_resp.status();
    let local_var_content = local_var_resp.text().await?;

    if !local_var_status.is_client_error() && !local_var_status.is_server_error() {
        Ok(())
    } else {
        let local_var_entity: Option<RemoveProjectMemberError> = serde_json::from_str(&local_var_content).ok();
        let local_var_error = ResponseContent { status: local_var_status, content: local_var_content, entity: local_var_entity };
        Err(Error::ResponseError(local_var_error))
    }
}

/// Use this API to set your active project in the Ory Cloud Console UI.
pub async fn set_active_project(configuration: &configuration::Configuration, inline_object: Option<crate::models::InlineObject>) -> Result<(), Error<SetActiveProjectError>> {

    let local_var_client = &configuration.client;

    let local_var_uri_str = format!("{}/backoffice/public/console/projects/active", configuration.base_path);
    let mut local_var_req_builder = local_var_client.request(reqwest::Method::PUT, local_var_uri_str.as_str());

    if let Some(ref local_var_user_agent) = configuration.user_agent {
        local_var_req_builder = local_var_req_builder.header(reqwest::header::USER_AGENT, local_var_user_agent.clone());
    }
    if let Some(ref local_var_token) = configuration.bearer_access_token {
        local_var_req_builder = local_var_req_builder.bearer_auth(local_var_token.to_owned());
    };
    local_var_req_builder = local_var_req_builder.json(&inline_object);

    let local_var_req = local_var_req_builder.build()?;
    let local_var_resp = local_var_client.execute(local_var_req).await?;

    let local_var_status = local_var_resp.status();
    let local_var_content = local_var_resp.text().await?;

    if !local_var_status.is_client_error() && !local_var_status.is_server_error() {
        Ok(())
    } else {
        let local_var_entity: Option<SetActiveProjectError> = serde_json::from_str(&local_var_content).ok();
        let local_var_error = ResponseContent { status: local_var_status, content: local_var_content, entity: local_var_entity };
        Err(Error::ResponseError(local_var_error))
    }
}

/// Creates a new configuration revision for a project.
pub async fn update_project(configuration: &configuration::Configuration, project_id: &str, project_revision: Option<crate::models::ProjectRevision>) -> Result<crate::models::Project, Error<UpdateProjectError>> {

    let local_var_client = &configuration.client;

    let local_var_uri_str = format!("{}/backoffice/public/projects/{project_id}", configuration.base_path, project_id=crate::apis::urlencode(project_id));
    let mut local_var_req_builder = local_var_client.request(reqwest::Method::PUT, local_var_uri_str.as_str());

    if let Some(ref local_var_user_agent) = configuration.user_agent {
        local_var_req_builder = local_var_req_builder.header(reqwest::header::USER_AGENT, local_var_user_agent.clone());
    }
    if let Some(ref local_var_token) = configuration.bearer_access_token {
        local_var_req_builder = local_var_req_builder.bearer_auth(local_var_token.to_owned());
    };
    local_var_req_builder = local_var_req_builder.json(&project_revision);

    let local_var_req = local_var_req_builder.build()?;
    let local_var_resp = local_var_client.execute(local_var_req).await?;

    let local_var_status = local_var_resp.status();
    let local_var_content = local_var_resp.text().await?;

    if !local_var_status.is_client_error() && !local_var_status.is_server_error() {
        serde_json::from_str(&local_var_content).map_err(Error::from)
    } else {
        let local_var_entity: Option<UpdateProjectError> = serde_json::from_str(&local_var_content).ok();
        let local_var_error = ResponseContent { status: local_var_status, content: local_var_content, entity: local_var_entity };
        Err(Error::ResponseError(local_var_error))
    }
}

/// This endpoints allows you to update the Ory Cloud Project configuration for individual services (identity, permission, ...). The configuration is fully compatible with the open source projects for the respective services (e.g. Ory Kratos for Identity, Ory Keto for Permissions).  This endpoint expects the `version` key to be set in the payload. If it is unset, it will try to import the config as if it is from the most recent version.  If you have an older version of a configuration, you should set the version key in the payload!  While this endpoint is able to process all configuration items related to features (e.g. password reset), it does not support operational configuration items (e.g. port, tracing, logging) otherwise available in the open source.  For configuration items that can not be translated to Ory Cloud, this endpoint will return a list of warnings to help you understand which parts of your config could not be processed.  Be aware that updating any service's configuration will completely override your current configuration for that service!
pub async fn update_project_config(configuration: &configuration::Configuration, project_id: &str, update_project_config_config: Option<crate::models::UpdateProjectConfigConfig>) -> Result<crate::models::SuccessfulProjectConfigUpdate, Error<UpdateProjectConfigError>> {

    let local_var_client = &configuration.client;

    let local_var_uri_str = format!("{}/backoffice/public/projects/{project_id}/configs", configuration.base_path, project_id=crate::apis::urlencode(project_id));
    let mut local_var_req_builder = local_var_client.request(reqwest::Method::PUT, local_var_uri_str.as_str());

    if let Some(ref local_var_user_agent) = configuration.user_agent {
        local_var_req_builder = local_var_req_builder.header(reqwest::header::USER_AGENT, local_var_user_agent.clone());
    }
    if let Some(ref local_var_token) = configuration.bearer_access_token {
        local_var_req_builder = local_var_req_builder.bearer_auth(local_var_token.to_owned());
    };
    local_var_req_builder = local_var_req_builder.json(&update_project_config_config);

    let local_var_req = local_var_req_builder.build()?;
    let local_var_resp = local_var_client.execute(local_var_req).await?;

    let local_var_status = local_var_resp.status();
    let local_var_content = local_var_resp.text().await?;

    if !local_var_status.is_client_error() && !local_var_status.is_server_error() {
        serde_json::from_str(&local_var_content).map_err(Error::from)
    } else {
        let local_var_entity: Option<UpdateProjectConfigError> = serde_json::from_str(&local_var_content).ok();
        let local_var_error = ResponseContent { status: local_var_status, content: local_var_content, entity: local_var_entity };
        Err(Error::ResponseError(local_var_error))
    }
}

