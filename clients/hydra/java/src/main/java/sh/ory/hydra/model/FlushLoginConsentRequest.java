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
import java.time.OffsetDateTime;

/**
 * FlushLoginConsentRequest
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2022-02-21T12:23:57.931041628Z[Etc/UTC]")
public class FlushLoginConsentRequest {
  public static final String SERIALIZED_NAME_NOT_AFTER = "notAfter";
  @SerializedName(SERIALIZED_NAME_NOT_AFTER)
  private OffsetDateTime notAfter;

  public FlushLoginConsentRequest() { 
  }

  public FlushLoginConsentRequest notAfter(OffsetDateTime notAfter) {
    
    this.notAfter = notAfter;
    return this;
  }

   /**
   * NotAfter sets after which point tokens should not be flushed. This is useful when you want to keep a history of recent login and consent database entries for auditing.
   * @return notAfter
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "NotAfter sets after which point tokens should not be flushed. This is useful when you want to keep a history of recent login and consent database entries for auditing.")

  public OffsetDateTime getNotAfter() {
    return notAfter;
  }


  public void setNotAfter(OffsetDateTime notAfter) {
    this.notAfter = notAfter;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    FlushLoginConsentRequest flushLoginConsentRequest = (FlushLoginConsentRequest) o;
    return Objects.equals(this.notAfter, flushLoginConsentRequest.notAfter);
  }

  @Override
  public int hashCode() {
    return Objects.hash(notAfter);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class FlushLoginConsentRequest {\n");
    sb.append("    notAfter: ").append(toIndentedString(notAfter)).append("\n");
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

