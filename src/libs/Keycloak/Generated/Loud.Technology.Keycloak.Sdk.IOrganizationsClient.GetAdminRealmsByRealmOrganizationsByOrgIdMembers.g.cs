#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Returns a paginated list of organization members filtered according to the specified parameters
        /// </summary>
        /// <param name="briefRepresentation">
        /// Default Value: true
        /// </param>
        /// <param name="exact"></param>
        /// <param name="first">
        /// Default Value: 0
        /// </param>
        /// <param name="max">
        /// Default Value: 10
        /// </param>
        /// <param name="membershipType"></param>
        /// <param name="search"></param>
        /// <param name="realm"></param>
        /// <param name="orgId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.MemberRepresentation>> GetAdminRealmsByRealmOrganizationsByOrgIdMembersAsync(
            string realm,
            string orgId,
            bool? briefRepresentation = default,
            bool? exact = default,
            int? first = default,
            int? max = default,
            string? membershipType = default,
            string? search = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns a paginated list of organization members filtered according to the specified parameters
        /// </summary>
        /// <param name="briefRepresentation">
        /// Default Value: true
        /// </param>
        /// <param name="exact"></param>
        /// <param name="first">
        /// Default Value: 0
        /// </param>
        /// <param name="max">
        /// Default Value: 10
        /// </param>
        /// <param name="membershipType"></param>
        /// <param name="search"></param>
        /// <param name="realm"></param>
        /// <param name="orgId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Loud.Technology.Keycloak.Sdk.MemberRepresentation>>> GetAdminRealmsByRealmOrganizationsByOrgIdMembersAsResponseAsync(
            string realm,
            string orgId,
            bool? briefRepresentation = default,
            bool? exact = default,
            int? first = default,
            int? max = default,
            string? membershipType = default,
            string? search = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}