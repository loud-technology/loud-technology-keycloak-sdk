#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Returns the organizations associated with the user that has the specified id
        /// </summary>
        /// <param name="memberId"></param>
        /// <param name="briefRepresentation">
        /// Default Value: true
        /// </param>
        /// <param name="realm"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.OrganizationRepresentation>> GetAdminRealmsByRealmOrganizationsMembersByMemberIdOrganizationsAsync(
            string memberId,
            string realm,
            bool? briefRepresentation = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns the organizations associated with the user that has the specified id
        /// </summary>
        /// <param name="memberId"></param>
        /// <param name="briefRepresentation">
        /// Default Value: true
        /// </param>
        /// <param name="realm"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.OrganizationRepresentation>>> GetAdminRealmsByRealmOrganizationsMembersByMemberIdOrganizationsAsResponseAsync(
            string memberId,
            string realm,
            bool? briefRepresentation = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}