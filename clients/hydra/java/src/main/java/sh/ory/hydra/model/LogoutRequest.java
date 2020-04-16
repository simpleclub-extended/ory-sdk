/*
 * ORY Hydra
 * Welcome to the ORY Hydra HTTP API documentation. You will find documentation for all HTTP APIs here.
 *
 * The version of the OpenAPI document: latest
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package sh.ory.hydra.model;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.io.IOException;

/**
 * LogoutRequest
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2020-04-16T17:56:41.907972Z[GMT]")
public class LogoutRequest {
  public static final String SERIALIZED_NAME_REQUEST_URL = "request_url";
  @SerializedName(SERIALIZED_NAME_REQUEST_URL)
  private String requestUrl;

  public static final String SERIALIZED_NAME_RP_INITIATED = "rp_initiated";
  @SerializedName(SERIALIZED_NAME_RP_INITIATED)
  private Boolean rpInitiated;

  public static final String SERIALIZED_NAME_SID = "sid";
  @SerializedName(SERIALIZED_NAME_SID)
  private String sid;

  public static final String SERIALIZED_NAME_SUBJECT = "subject";
  @SerializedName(SERIALIZED_NAME_SUBJECT)
  private String subject;


  public LogoutRequest requestUrl(String requestUrl) {
    
    this.requestUrl = requestUrl;
    return this;
  }

   /**
   * RequestURL is the original Logout URL requested.
   * @return requestUrl
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "RequestURL is the original Logout URL requested.")

  public String getRequestUrl() {
    return requestUrl;
  }


  public void setRequestUrl(String requestUrl) {
    this.requestUrl = requestUrl;
  }


  public LogoutRequest rpInitiated(Boolean rpInitiated) {
    
    this.rpInitiated = rpInitiated;
    return this;
  }

   /**
   * RPInitiated is set to true if the request was initiated by a Relying Party (RP), also known as an OAuth 2.0 Client.
   * @return rpInitiated
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "RPInitiated is set to true if the request was initiated by a Relying Party (RP), also known as an OAuth 2.0 Client.")

  public Boolean getRpInitiated() {
    return rpInitiated;
  }


  public void setRpInitiated(Boolean rpInitiated) {
    this.rpInitiated = rpInitiated;
  }


  public LogoutRequest sid(String sid) {
    
    this.sid = sid;
    return this;
  }

   /**
   * SessionID is the login session ID that was requested to log out.
   * @return sid
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "SessionID is the login session ID that was requested to log out.")

  public String getSid() {
    return sid;
  }


  public void setSid(String sid) {
    this.sid = sid;
  }


  public LogoutRequest subject(String subject) {
    
    this.subject = subject;
    return this;
  }

   /**
   * Subject is the user for whom the logout was request.
   * @return subject
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Subject is the user for whom the logout was request.")

  public String getSubject() {
    return subject;
  }


  public void setSubject(String subject) {
    this.subject = subject;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    LogoutRequest logoutRequest = (LogoutRequest) o;
    return Objects.equals(this.requestUrl, logoutRequest.requestUrl) &&
        Objects.equals(this.rpInitiated, logoutRequest.rpInitiated) &&
        Objects.equals(this.sid, logoutRequest.sid) &&
        Objects.equals(this.subject, logoutRequest.subject);
  }

  @Override
  public int hashCode() {
    return Objects.hash(requestUrl, rpInitiated, sid, subject);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class LogoutRequest {\n");
    sb.append("    requestUrl: ").append(toIndentedString(requestUrl)).append("\n");
    sb.append("    rpInitiated: ").append(toIndentedString(rpInitiated)).append("\n");
    sb.append("    sid: ").append(toIndentedString(sid)).append("\n");
    sb.append("    subject: ").append(toIndentedString(subject)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}

