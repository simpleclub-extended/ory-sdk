=begin
#Ory APIs

#Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 

The version of the OpenAPI document: v1.1.2
Contact: support@ory.sh
Generated by: https://openapi-generator.tech
OpenAPI Generator version: 6.0.1

=end

require 'spec_helper'
require 'json'
require 'date'

# Unit tests for OryClient::IdentityState
# Automatically generated by openapi-generator (https://openapi-generator.tech)
# Please update as you see appropriate
describe OryClient::IdentityState do
  let(:instance) { OryClient::IdentityState.new }

  describe 'test an instance of IdentityState' do
    it 'should create an instance of IdentityState' do
      expect(instance).to be_instance_of(OryClient::IdentityState)
    end
  end
end
