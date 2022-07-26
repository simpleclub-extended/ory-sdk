# NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
# https://openapi-generator.tech
# Do not edit the class manually.

defmodule Ory.Model.IdentitySchema do
  @moduledoc """
  Together the name and identity uuid are a unique index constraint. This prevents a user from having schemas with the same name. This also allows schemas to have the same name across the system.
  """

  @derive [Poison.Encoder]
  defstruct [
    :blob_name,
    :blob_url,
    :content_hash,
    :created_at,
    :id,
    :name,
    :updated_at
  ]

  @type t :: %__MODULE__{
    :blob_name => String.t,
    :blob_url => String.t,
    :content_hash => String.t | nil,
    :created_at => DateTime.t,
    :id => String.t,
    :name => String.t,
    :updated_at => DateTime.t
  }
end

defimpl Poison.Decoder, for: Ory.Model.IdentitySchema do
  def decode(value, _options) do
    value
  end
end

