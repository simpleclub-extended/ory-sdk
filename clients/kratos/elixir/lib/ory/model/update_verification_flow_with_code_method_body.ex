# NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
# https://openapi-generator.tech
# Do not edit the class manually.

defmodule Ory.Model.UpdateVerificationFlowWithCodeMethodBody do
  @moduledoc """
  
  """

  @derive [Poison.Encoder]
  defstruct [
    :code,
    :csrf_token,
    :email,
    :flow,
    :method
  ]

  @type t :: %__MODULE__{
    :code => String.t | nil,
    :csrf_token => String.t | nil,
    :email => String.t | nil,
    :flow => String.t | nil,
    :method => String.t | nil
  }
end

defimpl Poison.Decoder, for: Ory.Model.UpdateVerificationFlowWithCodeMethodBody do
  def decode(value, _options) do
    value
  end
end

