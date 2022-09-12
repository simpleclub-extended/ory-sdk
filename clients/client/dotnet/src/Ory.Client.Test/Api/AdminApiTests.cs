/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.2.0-alpha.38
 * Contact: support@ory.sh
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Ory.Client.Client;
using Ory.Client.Api;
// uncomment below to import models
//using Ory.Client.Model;

namespace Ory.Client.Test.Api
{
    /// <summary>
    ///  Class for testing AdminApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AdminApiTests : IDisposable
    {
        private AdminApi instance;

        public AdminApiTests()
        {
            instance = new AdminApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AdminApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AdminApi
            //Assert.IsType<AdminApi>(instance);
        }

        /// <summary>
        /// Test AcceptConsentRequest
        /// </summary>
        [Fact]
        public void AcceptConsentRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string consentChallenge = null;
            //ClientAcceptConsentRequest clientAcceptConsentRequest = null;
            //var response = instance.AcceptConsentRequest(consentChallenge, clientAcceptConsentRequest);
            //Assert.IsType<ClientCompletedRequest>(response);
        }

        /// <summary>
        /// Test AcceptLoginRequest
        /// </summary>
        [Fact]
        public void AcceptLoginRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string loginChallenge = null;
            //ClientAcceptLoginRequest clientAcceptLoginRequest = null;
            //var response = instance.AcceptLoginRequest(loginChallenge, clientAcceptLoginRequest);
            //Assert.IsType<ClientCompletedRequest>(response);
        }

        /// <summary>
        /// Test AcceptLogoutRequest
        /// </summary>
        [Fact]
        public void AcceptLogoutRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string logoutChallenge = null;
            //var response = instance.AcceptLogoutRequest(logoutChallenge);
            //Assert.IsType<ClientCompletedRequest>(response);
        }

        /// <summary>
        /// Test CreateJsonWebKeySet
        /// </summary>
        [Fact]
        public void CreateJsonWebKeySetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string set = null;
            //ClientJsonWebKeySetGeneratorRequest clientJsonWebKeySetGeneratorRequest = null;
            //var response = instance.CreateJsonWebKeySet(set, clientJsonWebKeySetGeneratorRequest);
            //Assert.IsType<ClientJSONWebKeySet>(response);
        }

        /// <summary>
        /// Test CreateOAuth2Client
        /// </summary>
        [Fact]
        public void CreateOAuth2ClientTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ClientOAuth2Client clientOAuth2Client = null;
            //var response = instance.CreateOAuth2Client(clientOAuth2Client);
            //Assert.IsType<ClientOAuth2Client>(response);
        }

        /// <summary>
        /// Test DeleteJsonWebKey
        /// </summary>
        [Fact]
        public void DeleteJsonWebKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string kid = null;
            //string set = null;
            //instance.DeleteJsonWebKey(kid, set);
        }

        /// <summary>
        /// Test DeleteJsonWebKeySet
        /// </summary>
        [Fact]
        public void DeleteJsonWebKeySetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string set = null;
            //instance.DeleteJsonWebKeySet(set);
        }

        /// <summary>
        /// Test DeleteOAuth2Client
        /// </summary>
        [Fact]
        public void DeleteOAuth2ClientTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.DeleteOAuth2Client(id);
        }

        /// <summary>
        /// Test DeleteOAuth2Token
        /// </summary>
        [Fact]
        public void DeleteOAuth2TokenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string clientId = null;
            //instance.DeleteOAuth2Token(clientId);
        }

        /// <summary>
        /// Test DeleteTrustedJwtGrantIssuer
        /// </summary>
        [Fact]
        public void DeleteTrustedJwtGrantIssuerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.DeleteTrustedJwtGrantIssuer(id);
        }

        /// <summary>
        /// Test FlushInactiveOAuth2Tokens
        /// </summary>
        [Fact]
        public void FlushInactiveOAuth2TokensTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ClientFlushInactiveOAuth2TokensRequest clientFlushInactiveOAuth2TokensRequest = null;
            //instance.FlushInactiveOAuth2Tokens(clientFlushInactiveOAuth2TokensRequest);
        }

        /// <summary>
        /// Test GetConsentRequest
        /// </summary>
        [Fact]
        public void GetConsentRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string consentChallenge = null;
            //var response = instance.GetConsentRequest(consentChallenge);
            //Assert.IsType<ClientConsentRequest>(response);
        }

        /// <summary>
        /// Test GetJsonWebKey
        /// </summary>
        [Fact]
        public void GetJsonWebKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string kid = null;
            //string set = null;
            //var response = instance.GetJsonWebKey(kid, set);
            //Assert.IsType<ClientJSONWebKeySet>(response);
        }

        /// <summary>
        /// Test GetJsonWebKeySet
        /// </summary>
        [Fact]
        public void GetJsonWebKeySetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string set = null;
            //var response = instance.GetJsonWebKeySet(set);
            //Assert.IsType<ClientJSONWebKeySet>(response);
        }

        /// <summary>
        /// Test GetLoginRequest
        /// </summary>
        [Fact]
        public void GetLoginRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string loginChallenge = null;
            //var response = instance.GetLoginRequest(loginChallenge);
            //Assert.IsType<ClientLoginRequest>(response);
        }

        /// <summary>
        /// Test GetLogoutRequest
        /// </summary>
        [Fact]
        public void GetLogoutRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string logoutChallenge = null;
            //var response = instance.GetLogoutRequest(logoutChallenge);
            //Assert.IsType<ClientLogoutRequest>(response);
        }

        /// <summary>
        /// Test GetOAuth2Client
        /// </summary>
        [Fact]
        public void GetOAuth2ClientTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetOAuth2Client(id);
            //Assert.IsType<ClientOAuth2Client>(response);
        }

        /// <summary>
        /// Test GetTrustedJwtGrantIssuer
        /// </summary>
        [Fact]
        public void GetTrustedJwtGrantIssuerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetTrustedJwtGrantIssuer(id);
            //Assert.IsType<ClientTrustedJwtGrantIssuer>(response);
        }

        /// <summary>
        /// Test IntrospectOAuth2Token
        /// </summary>
        [Fact]
        public void IntrospectOAuth2TokenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string token = null;
            //string scope = null;
            //var response = instance.IntrospectOAuth2Token(token, scope);
            //Assert.IsType<ClientOAuth2TokenIntrospection>(response);
        }

        /// <summary>
        /// Test ListOAuth2Clients
        /// </summary>
        [Fact]
        public void ListOAuth2ClientsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? limit = null;
            //long? offset = null;
            //string clientName = null;
            //string owner = null;
            //var response = instance.ListOAuth2Clients(limit, offset, clientName, owner);
            //Assert.IsType<List<ClientOAuth2Client>>(response);
        }

        /// <summary>
        /// Test ListSubjectConsentSessions
        /// </summary>
        [Fact]
        public void ListSubjectConsentSessionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string subject = null;
            //long? limit = null;
            //long? offset = null;
            //var response = instance.ListSubjectConsentSessions(subject, limit, offset);
            //Assert.IsType<List<ClientPreviousConsentSession>>(response);
        }

        /// <summary>
        /// Test ListTrustedJwtGrantIssuers
        /// </summary>
        [Fact]
        public void ListTrustedJwtGrantIssuersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string issuer = null;
            //long? limit = null;
            //long? offset = null;
            //var response = instance.ListTrustedJwtGrantIssuers(issuer, limit, offset);
            //Assert.IsType<List<ClientTrustedJwtGrantIssuer>>(response);
        }

        /// <summary>
        /// Test PatchOAuth2Client
        /// </summary>
        [Fact]
        public void PatchOAuth2ClientTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<ClientPatchDocument> clientPatchDocument = null;
            //var response = instance.PatchOAuth2Client(id, clientPatchDocument);
            //Assert.IsType<ClientOAuth2Client>(response);
        }

        /// <summary>
        /// Test RejectConsentRequest
        /// </summary>
        [Fact]
        public void RejectConsentRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string consentChallenge = null;
            //ClientRejectRequest clientRejectRequest = null;
            //var response = instance.RejectConsentRequest(consentChallenge, clientRejectRequest);
            //Assert.IsType<ClientCompletedRequest>(response);
        }

        /// <summary>
        /// Test RejectLoginRequest
        /// </summary>
        [Fact]
        public void RejectLoginRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string loginChallenge = null;
            //ClientRejectRequest clientRejectRequest = null;
            //var response = instance.RejectLoginRequest(loginChallenge, clientRejectRequest);
            //Assert.IsType<ClientCompletedRequest>(response);
        }

        /// <summary>
        /// Test RejectLogoutRequest
        /// </summary>
        [Fact]
        public void RejectLogoutRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string logoutChallenge = null;
            //ClientRejectRequest clientRejectRequest = null;
            //instance.RejectLogoutRequest(logoutChallenge, clientRejectRequest);
        }

        /// <summary>
        /// Test RevokeAuthenticationSession
        /// </summary>
        [Fact]
        public void RevokeAuthenticationSessionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string subject = null;
            //instance.RevokeAuthenticationSession(subject);
        }

        /// <summary>
        /// Test RevokeConsentSessions
        /// </summary>
        [Fact]
        public void RevokeConsentSessionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string subject = null;
            //string _client = null;
            //bool? all = null;
            //instance.RevokeConsentSessions(subject, _client, all);
        }

        /// <summary>
        /// Test TrustJwtGrantIssuer
        /// </summary>
        [Fact]
        public void TrustJwtGrantIssuerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ClientTrustJwtGrantIssuerBody clientTrustJwtGrantIssuerBody = null;
            //var response = instance.TrustJwtGrantIssuer(clientTrustJwtGrantIssuerBody);
            //Assert.IsType<ClientTrustedJwtGrantIssuer>(response);
        }

        /// <summary>
        /// Test UpdateJsonWebKey
        /// </summary>
        [Fact]
        public void UpdateJsonWebKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string kid = null;
            //string set = null;
            //ClientJSONWebKey clientJSONWebKey = null;
            //var response = instance.UpdateJsonWebKey(kid, set, clientJSONWebKey);
            //Assert.IsType<ClientJSONWebKey>(response);
        }

        /// <summary>
        /// Test UpdateJsonWebKeySet
        /// </summary>
        [Fact]
        public void UpdateJsonWebKeySetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string set = null;
            //ClientJSONWebKeySet clientJSONWebKeySet = null;
            //var response = instance.UpdateJsonWebKeySet(set, clientJSONWebKeySet);
            //Assert.IsType<ClientJSONWebKeySet>(response);
        }

        /// <summary>
        /// Test UpdateOAuth2Client
        /// </summary>
        [Fact]
        public void UpdateOAuth2ClientTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //ClientOAuth2Client clientOAuth2Client = null;
            //var response = instance.UpdateOAuth2Client(id, clientOAuth2Client);
            //Assert.IsType<ClientOAuth2Client>(response);
        }
    }
}
