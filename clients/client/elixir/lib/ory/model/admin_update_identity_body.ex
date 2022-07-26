# NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
# https://openapi-generator.tech
# Do not edit the class manually.

defmodule Ory.Model.AdminUpdateIdentityBody do
  @moduledoc """
  
  """

  @derive [Poison.Encoder]
  defstruct [
    :credentials,
    :metadata_admin,
    :metadata_public,
    :schema_id,
    :state,
    :traits
  ]

  @type t :: %__MODULE__{
    :credentials => Ory.Model.AdminIdentityImportCredentials.t | nil,
    :metadata_admin => AnyType | nil,
    :metadata_public => AnyType | nil,
    :schema_id => String.t,
    :state => Ory.Model.IdentityState.t,
    :traits => map()
  }
end

defimpl Poison.Decoder, for: Ory.Model.AdminUpdateIdentityBody do
  import Ory.Deserializer
  def decode(value, options) do
    value
    |> deserialize(:credentials, :struct, Ory.Model.AdminIdentityImportCredentials, options)
    |> deserialize(:metadata_admin, :struct, Ory.Model.AnyType, options)
    |> deserialize(:metadata_public, :struct, Ory.Model.AnyType, options)
    |> deserialize(:state, :struct, Ory.Model.IdentityState, options)
  end
end

