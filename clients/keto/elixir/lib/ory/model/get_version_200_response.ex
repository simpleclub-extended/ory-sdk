# NOTE: This file is auto generated by OpenAPI Generator 6.2.1 (https://openapi-generator.tech).
# Do not edit this file manually.

defmodule Ory.Model.GetVersion200Response do
  @moduledoc """
  
  """

  @derive [Poison.Encoder]
  defstruct [
    :version
  ]

  @type t :: %__MODULE__{
    :version => String.t
  }
end

defimpl Poison.Decoder, for: Ory.Model.GetVersion200Response do
  def decode(value, _options) do
    value
  end
end

