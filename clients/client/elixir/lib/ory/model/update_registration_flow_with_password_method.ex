# NOTE: This file is auto generated by OpenAPI Generator 6.2.1 (https://openapi-generator.tech).
# Do not edit this file manually.

defmodule Ory.Model.UpdateRegistrationFlowWithPasswordMethod do
  @moduledoc """
  Update Registration Flow with Password Method
  """

  @derive [Poison.Encoder]
  defstruct [
    :csrf_token,
    :method,
    :password,
    :traits,
    :transient_payload
  ]

  @type t :: %__MODULE__{
    :csrf_token => String.t | nil,
    :method => String.t,
    :password => String.t,
    :traits => map(),
    :transient_payload => map() | nil
  }
end

defimpl Poison.Decoder, for: Ory.Model.UpdateRegistrationFlowWithPasswordMethod do
  def decode(value, _options) do
    value
  end
end

