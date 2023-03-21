/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.1.23
 * Contact: support@ory.sh
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Ory.Client.Client;
using Ory.Client.Model;

namespace Ory.Client.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMetadataApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Return Running Software Version.
        /// </summary>
        /// <remarks>
        /// This endpoint returns the version of Ory Kratos.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the version will never refer to the cluster state, only to a single instance.
        /// </remarks>
        /// <exception cref="Ory.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ClientInlineResponse2001</returns>
        ClientInlineResponse2001 GetVersion();

        /// <summary>
        /// Return Running Software Version.
        /// </summary>
        /// <remarks>
        /// This endpoint returns the version of Ory Kratos.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the version will never refer to the cluster state, only to a single instance.
        /// </remarks>
        /// <exception cref="Ory.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ClientInlineResponse2001</returns>
        ApiResponse<ClientInlineResponse2001> GetVersionWithHttpInfo();
        /// <summary>
        /// Check HTTP Server Status
        /// </summary>
        /// <remarks>
        /// This endpoint returns a HTTP 200 status code when Ory Kratos is accepting incoming HTTP requests. This status does currently not include checks whether the database connection is working.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the health status will never refer to the cluster state, only to a single instance.
        /// </remarks>
        /// <exception cref="Ory.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ClientHealthStatus</returns>
        ClientHealthStatus IsAlive();

        /// <summary>
        /// Check HTTP Server Status
        /// </summary>
        /// <remarks>
        /// This endpoint returns a HTTP 200 status code when Ory Kratos is accepting incoming HTTP requests. This status does currently not include checks whether the database connection is working.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the health status will never refer to the cluster state, only to a single instance.
        /// </remarks>
        /// <exception cref="Ory.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ClientHealthStatus</returns>
        ApiResponse<ClientHealthStatus> IsAliveWithHttpInfo();
        /// <summary>
        /// Check HTTP Server and Database Status
        /// </summary>
        /// <remarks>
        /// This endpoint returns a HTTP 200 status code when Ory Kratos is up running and the environment dependencies (e.g. the database) are responsive as well.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of Ory Kratos, the health status will never refer to the cluster state, only to a single instance.
        /// </remarks>
        /// <exception cref="Ory.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ClientInlineResponse200</returns>
        ClientInlineResponse200 IsReady();

        /// <summary>
        /// Check HTTP Server and Database Status
        /// </summary>
        /// <remarks>
        /// This endpoint returns a HTTP 200 status code when Ory Kratos is up running and the environment dependencies (e.g. the database) are responsive as well.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of Ory Kratos, the health status will never refer to the cluster state, only to a single instance.
        /// </remarks>
        /// <exception cref="Ory.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ClientInlineResponse200</returns>
        ApiResponse<ClientInlineResponse200> IsReadyWithHttpInfo();
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMetadataApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Return Running Software Version.
        /// </summary>
        /// <remarks>
        /// This endpoint returns the version of Ory Kratos.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the version will never refer to the cluster state, only to a single instance.
        /// </remarks>
        /// <exception cref="Ory.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ClientInlineResponse2001</returns>
        System.Threading.Tasks.Task<ClientInlineResponse2001> GetVersionAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Return Running Software Version.
        /// </summary>
        /// <remarks>
        /// This endpoint returns the version of Ory Kratos.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the version will never refer to the cluster state, only to a single instance.
        /// </remarks>
        /// <exception cref="Ory.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ClientInlineResponse2001)</returns>
        System.Threading.Tasks.Task<ApiResponse<ClientInlineResponse2001>> GetVersionWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Check HTTP Server Status
        /// </summary>
        /// <remarks>
        /// This endpoint returns a HTTP 200 status code when Ory Kratos is accepting incoming HTTP requests. This status does currently not include checks whether the database connection is working.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the health status will never refer to the cluster state, only to a single instance.
        /// </remarks>
        /// <exception cref="Ory.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ClientHealthStatus</returns>
        System.Threading.Tasks.Task<ClientHealthStatus> IsAliveAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Check HTTP Server Status
        /// </summary>
        /// <remarks>
        /// This endpoint returns a HTTP 200 status code when Ory Kratos is accepting incoming HTTP requests. This status does currently not include checks whether the database connection is working.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the health status will never refer to the cluster state, only to a single instance.
        /// </remarks>
        /// <exception cref="Ory.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ClientHealthStatus)</returns>
        System.Threading.Tasks.Task<ApiResponse<ClientHealthStatus>> IsAliveWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Check HTTP Server and Database Status
        /// </summary>
        /// <remarks>
        /// This endpoint returns a HTTP 200 status code when Ory Kratos is up running and the environment dependencies (e.g. the database) are responsive as well.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of Ory Kratos, the health status will never refer to the cluster state, only to a single instance.
        /// </remarks>
        /// <exception cref="Ory.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ClientInlineResponse200</returns>
        System.Threading.Tasks.Task<ClientInlineResponse200> IsReadyAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Check HTTP Server and Database Status
        /// </summary>
        /// <remarks>
        /// This endpoint returns a HTTP 200 status code when Ory Kratos is up running and the environment dependencies (e.g. the database) are responsive as well.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of Ory Kratos, the health status will never refer to the cluster state, only to a single instance.
        /// </remarks>
        /// <exception cref="Ory.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ClientInlineResponse200)</returns>
        System.Threading.Tasks.Task<ApiResponse<ClientInlineResponse200>> IsReadyWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMetadataApi : IMetadataApiSync, IMetadataApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class MetadataApi : IMetadataApi
    {
        private Ory.Client.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MetadataApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MetadataApi(string basePath)
        {
            this.Configuration = Ory.Client.Client.Configuration.MergeConfigurations(
                Ory.Client.Client.GlobalConfiguration.Instance,
                new Ory.Client.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Ory.Client.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Ory.Client.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Ory.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public MetadataApi(Ory.Client.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Ory.Client.Client.Configuration.MergeConfigurations(
                Ory.Client.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Ory.Client.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Ory.Client.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Ory.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public MetadataApi(Ory.Client.Client.ISynchronousClient client, Ory.Client.Client.IAsynchronousClient asyncClient, Ory.Client.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Ory.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Ory.Client.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Ory.Client.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Ory.Client.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Ory.Client.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Return Running Software Version. This endpoint returns the version of Ory Kratos.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the version will never refer to the cluster state, only to a single instance.
        /// </summary>
        /// <exception cref="Ory.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ClientInlineResponse2001</returns>
        public ClientInlineResponse2001 GetVersion()
        {
            Ory.Client.Client.ApiResponse<ClientInlineResponse2001> localVarResponse = GetVersionWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Return Running Software Version. This endpoint returns the version of Ory Kratos.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the version will never refer to the cluster state, only to a single instance.
        /// </summary>
        /// <exception cref="Ory.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ClientInlineResponse2001</returns>
        public Ory.Client.Client.ApiResponse<ClientInlineResponse2001> GetVersionWithHttpInfo()
        {
            Ory.Client.Client.RequestOptions localVarRequestOptions = new Ory.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Ory.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Ory.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }


            // authentication (oryAccessToken) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<ClientInlineResponse2001>("/version", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetVersion", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Return Running Software Version. This endpoint returns the version of Ory Kratos.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the version will never refer to the cluster state, only to a single instance.
        /// </summary>
        /// <exception cref="Ory.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ClientInlineResponse2001</returns>
        public async System.Threading.Tasks.Task<ClientInlineResponse2001> GetVersionAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Ory.Client.Client.ApiResponse<ClientInlineResponse2001> localVarResponse = await GetVersionWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Return Running Software Version. This endpoint returns the version of Ory Kratos.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the version will never refer to the cluster state, only to a single instance.
        /// </summary>
        /// <exception cref="Ory.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ClientInlineResponse2001)</returns>
        public async System.Threading.Tasks.Task<Ory.Client.Client.ApiResponse<ClientInlineResponse2001>> GetVersionWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Ory.Client.Client.RequestOptions localVarRequestOptions = new Ory.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Ory.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Ory.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }


            // authentication (oryAccessToken) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<ClientInlineResponse2001>("/version", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetVersion", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Check HTTP Server Status This endpoint returns a HTTP 200 status code when Ory Kratos is accepting incoming HTTP requests. This status does currently not include checks whether the database connection is working.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the health status will never refer to the cluster state, only to a single instance.
        /// </summary>
        /// <exception cref="Ory.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ClientHealthStatus</returns>
        public ClientHealthStatus IsAlive()
        {
            Ory.Client.Client.ApiResponse<ClientHealthStatus> localVarResponse = IsAliveWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Check HTTP Server Status This endpoint returns a HTTP 200 status code when Ory Kratos is accepting incoming HTTP requests. This status does currently not include checks whether the database connection is working.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the health status will never refer to the cluster state, only to a single instance.
        /// </summary>
        /// <exception cref="Ory.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ClientHealthStatus</returns>
        public Ory.Client.Client.ApiResponse<ClientHealthStatus> IsAliveWithHttpInfo()
        {
            Ory.Client.Client.RequestOptions localVarRequestOptions = new Ory.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Ory.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Ory.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }


            // authentication (oryAccessToken) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<ClientHealthStatus>("/health/alive", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("IsAlive", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Check HTTP Server Status This endpoint returns a HTTP 200 status code when Ory Kratos is accepting incoming HTTP requests. This status does currently not include checks whether the database connection is working.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the health status will never refer to the cluster state, only to a single instance.
        /// </summary>
        /// <exception cref="Ory.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ClientHealthStatus</returns>
        public async System.Threading.Tasks.Task<ClientHealthStatus> IsAliveAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Ory.Client.Client.ApiResponse<ClientHealthStatus> localVarResponse = await IsAliveWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Check HTTP Server Status This endpoint returns a HTTP 200 status code when Ory Kratos is accepting incoming HTTP requests. This status does currently not include checks whether the database connection is working.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the health status will never refer to the cluster state, only to a single instance.
        /// </summary>
        /// <exception cref="Ory.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ClientHealthStatus)</returns>
        public async System.Threading.Tasks.Task<Ory.Client.Client.ApiResponse<ClientHealthStatus>> IsAliveWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Ory.Client.Client.RequestOptions localVarRequestOptions = new Ory.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Ory.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Ory.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }


            // authentication (oryAccessToken) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<ClientHealthStatus>("/health/alive", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("IsAlive", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Check HTTP Server and Database Status This endpoint returns a HTTP 200 status code when Ory Kratos is up running and the environment dependencies (e.g. the database) are responsive as well.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of Ory Kratos, the health status will never refer to the cluster state, only to a single instance.
        /// </summary>
        /// <exception cref="Ory.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ClientInlineResponse200</returns>
        public ClientInlineResponse200 IsReady()
        {
            Ory.Client.Client.ApiResponse<ClientInlineResponse200> localVarResponse = IsReadyWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Check HTTP Server and Database Status This endpoint returns a HTTP 200 status code when Ory Kratos is up running and the environment dependencies (e.g. the database) are responsive as well.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of Ory Kratos, the health status will never refer to the cluster state, only to a single instance.
        /// </summary>
        /// <exception cref="Ory.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ClientInlineResponse200</returns>
        public Ory.Client.Client.ApiResponse<ClientInlineResponse200> IsReadyWithHttpInfo()
        {
            Ory.Client.Client.RequestOptions localVarRequestOptions = new Ory.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Ory.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Ory.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }


            // authentication (oryAccessToken) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<ClientInlineResponse200>("/health/ready", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("IsReady", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Check HTTP Server and Database Status This endpoint returns a HTTP 200 status code when Ory Kratos is up running and the environment dependencies (e.g. the database) are responsive as well.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of Ory Kratos, the health status will never refer to the cluster state, only to a single instance.
        /// </summary>
        /// <exception cref="Ory.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ClientInlineResponse200</returns>
        public async System.Threading.Tasks.Task<ClientInlineResponse200> IsReadyAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Ory.Client.Client.ApiResponse<ClientInlineResponse200> localVarResponse = await IsReadyWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Check HTTP Server and Database Status This endpoint returns a HTTP 200 status code when Ory Kratos is up running and the environment dependencies (e.g. the database) are responsive as well.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of Ory Kratos, the health status will never refer to the cluster state, only to a single instance.
        /// </summary>
        /// <exception cref="Ory.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ClientInlineResponse200)</returns>
        public async System.Threading.Tasks.Task<Ory.Client.Client.ApiResponse<ClientInlineResponse200>> IsReadyWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Ory.Client.Client.RequestOptions localVarRequestOptions = new Ory.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Ory.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Ory.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }


            // authentication (oryAccessToken) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<ClientInlineResponse200>("/health/ready", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("IsReady", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
