/*
 * Ory Oathkeeper API
 * Documentation for all of Ory Oathkeeper's APIs. 
 *
 * The version of the OpenAPI document: v1.11.5
 * Contact: hi@ory.sh
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
import sh.ory.hydra.model.ConsentRequestSession;

/**
 * RefreshTokenHookResponse
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2022-02-21T12:23:57.931041628Z[Etc/UTC]")
public class RefreshTokenHookResponse {
  public static final String SERIALIZED_NAME_SESSION = "session";
  @SerializedName(SERIALIZED_NAME_SESSION)
  private ConsentRequestSession session;

  public RefreshTokenHookResponse() { 
  }

  public RefreshTokenHookResponse session(ConsentRequestSession session) {
    
    this.session = session;
    return this;
  }

   /**
   * Get session
   * @return session
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public ConsentRequestSession getSession() {
    return session;
  }


  public void setSession(ConsentRequestSession session) {
    this.session = session;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    RefreshTokenHookResponse refreshTokenHookResponse = (RefreshTokenHookResponse) o;
    return Objects.equals(this.session, refreshTokenHookResponse.session);
  }

  @Override
  public int hashCode() {
    return Objects.hash(session);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class RefreshTokenHookResponse {\n");
    sb.append("    session: ").append(toIndentedString(session)).append("\n");
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

