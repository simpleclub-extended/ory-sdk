/*
 * Ory APIs
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.2.0-alpha.23
 * Contact: support@ory.sh
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package sh.ory.model;

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
import java.time.OffsetDateTime;

/**
 * OAuth2ConsentSessionExpiresAt
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2022-08-30T09:24:27.674927925Z[Etc/UTC]")
public class OAuth2ConsentSessionExpiresAt {
  public static final String SERIALIZED_NAME_ACCESS_TOKEN = "access_token";
  @SerializedName(SERIALIZED_NAME_ACCESS_TOKEN)
  private OffsetDateTime accessToken;

  public static final String SERIALIZED_NAME_AUTHORIZE_CODE = "authorize_code";
  @SerializedName(SERIALIZED_NAME_AUTHORIZE_CODE)
  private OffsetDateTime authorizeCode;

  public static final String SERIALIZED_NAME_ID_TOKEN = "id_token";
  @SerializedName(SERIALIZED_NAME_ID_TOKEN)
  private OffsetDateTime idToken;

  public static final String SERIALIZED_NAME_PAR_CONTEXT = "par_context";
  @SerializedName(SERIALIZED_NAME_PAR_CONTEXT)
  private OffsetDateTime parContext;

  public static final String SERIALIZED_NAME_REFRESH_TOKEN = "refresh_token";
  @SerializedName(SERIALIZED_NAME_REFRESH_TOKEN)
  private OffsetDateTime refreshToken;

  public OAuth2ConsentSessionExpiresAt() { 
  }

  public OAuth2ConsentSessionExpiresAt accessToken(OffsetDateTime accessToken) {
    
    this.accessToken = accessToken;
    return this;
  }

   /**
   * Get accessToken
   * @return accessToken
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public OffsetDateTime getAccessToken() {
    return accessToken;
  }


  public void setAccessToken(OffsetDateTime accessToken) {
    this.accessToken = accessToken;
  }


  public OAuth2ConsentSessionExpiresAt authorizeCode(OffsetDateTime authorizeCode) {
    
    this.authorizeCode = authorizeCode;
    return this;
  }

   /**
   * Get authorizeCode
   * @return authorizeCode
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public OffsetDateTime getAuthorizeCode() {
    return authorizeCode;
  }


  public void setAuthorizeCode(OffsetDateTime authorizeCode) {
    this.authorizeCode = authorizeCode;
  }


  public OAuth2ConsentSessionExpiresAt idToken(OffsetDateTime idToken) {
    
    this.idToken = idToken;
    return this;
  }

   /**
   * Get idToken
   * @return idToken
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public OffsetDateTime getIdToken() {
    return idToken;
  }


  public void setIdToken(OffsetDateTime idToken) {
    this.idToken = idToken;
  }


  public OAuth2ConsentSessionExpiresAt parContext(OffsetDateTime parContext) {
    
    this.parContext = parContext;
    return this;
  }

   /**
   * Get parContext
   * @return parContext
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public OffsetDateTime getParContext() {
    return parContext;
  }


  public void setParContext(OffsetDateTime parContext) {
    this.parContext = parContext;
  }


  public OAuth2ConsentSessionExpiresAt refreshToken(OffsetDateTime refreshToken) {
    
    this.refreshToken = refreshToken;
    return this;
  }

   /**
   * Get refreshToken
   * @return refreshToken
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public OffsetDateTime getRefreshToken() {
    return refreshToken;
  }


  public void setRefreshToken(OffsetDateTime refreshToken) {
    this.refreshToken = refreshToken;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    OAuth2ConsentSessionExpiresAt oAuth2ConsentSessionExpiresAt = (OAuth2ConsentSessionExpiresAt) o;
    return Objects.equals(this.accessToken, oAuth2ConsentSessionExpiresAt.accessToken) &&
        Objects.equals(this.authorizeCode, oAuth2ConsentSessionExpiresAt.authorizeCode) &&
        Objects.equals(this.idToken, oAuth2ConsentSessionExpiresAt.idToken) &&
        Objects.equals(this.parContext, oAuth2ConsentSessionExpiresAt.parContext) &&
        Objects.equals(this.refreshToken, oAuth2ConsentSessionExpiresAt.refreshToken);
  }

  @Override
  public int hashCode() {
    return Objects.hash(accessToken, authorizeCode, idToken, parContext, refreshToken);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class OAuth2ConsentSessionExpiresAt {\n");
    sb.append("    accessToken: ").append(toIndentedString(accessToken)).append("\n");
    sb.append("    authorizeCode: ").append(toIndentedString(authorizeCode)).append("\n");
    sb.append("    idToken: ").append(toIndentedString(idToken)).append("\n");
    sb.append("    parContext: ").append(toIndentedString(parContext)).append("\n");
    sb.append("    refreshToken: ").append(toIndentedString(refreshToken)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}

