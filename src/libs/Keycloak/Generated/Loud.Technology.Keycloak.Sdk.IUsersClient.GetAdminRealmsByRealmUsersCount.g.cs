#nullable enable

namespace Loud.Technology.Keycloak.Sdk
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Returns the number of users that match the given criteria.<br/>
        /// It can be called in three different ways. 1. Don’t specify any criteria and pass {@code null}. The number of all users within that realm will be returned. &lt;p&gt; 2. If {@code search} is specified other criteria such as {@code last} will be ignored even though you set them. The {@code search} string will be matched against the first and last name, the username and the email of a user. &lt;p&gt; 3. If {@code search} is unspecified but any of {@code last}, {@code first}, {@code email} or {@code username} those criteria are matched against their respective fields on a user entity. Combined with a logical and.
        /// </summary>
        /// <param name="createdAfter"></param>
        /// <param name="createdBefore"></param>
        /// <param name="email"></param>
        /// <param name="emailVerified"></param>
        /// <param name="enabled"></param>
        /// <param name="exact"></param>
        /// <param name="firstName"></param>
        /// <param name="idpAlias"></param>
        /// <param name="idpUserId"></param>
        /// <param name="lastName"></param>
        /// <param name="q"></param>
        /// <param name="search"></param>
        /// <param name="username"></param>
        /// <param name="realm"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<int> GetAdminRealmsByRealmUsersCountAsync(
            string realm,
            string? createdAfter = default,
            string? createdBefore = default,
            string? email = default,
            bool? emailVerified = default,
            bool? enabled = default,
            bool? exact = default,
            string? firstName = default,
            string? idpAlias = default,
            string? idpUserId = default,
            string? lastName = default,
            string? q = default,
            string? search = default,
            string? username = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns the number of users that match the given criteria.<br/>
        /// It can be called in three different ways. 1. Don’t specify any criteria and pass {@code null}. The number of all users within that realm will be returned. &lt;p&gt; 2. If {@code search} is specified other criteria such as {@code last} will be ignored even though you set them. The {@code search} string will be matched against the first and last name, the username and the email of a user. &lt;p&gt; 3. If {@code search} is unspecified but any of {@code last}, {@code first}, {@code email} or {@code username} those criteria are matched against their respective fields on a user entity. Combined with a logical and.
        /// </summary>
        /// <param name="createdAfter"></param>
        /// <param name="createdBefore"></param>
        /// <param name="email"></param>
        /// <param name="emailVerified"></param>
        /// <param name="enabled"></param>
        /// <param name="exact"></param>
        /// <param name="firstName"></param>
        /// <param name="idpAlias"></param>
        /// <param name="idpUserId"></param>
        /// <param name="lastName"></param>
        /// <param name="q"></param>
        /// <param name="search"></param>
        /// <param name="username"></param>
        /// <param name="realm"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Keycloak.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Keycloak.Sdk.AutoSDKHttpResponse<int>> GetAdminRealmsByRealmUsersCountAsResponseAsync(
            string realm,
            string? createdAfter = default,
            string? createdBefore = default,
            string? email = default,
            bool? emailVerified = default,
            bool? enabled = default,
            bool? exact = default,
            string? firstName = default,
            string? idpAlias = default,
            string? idpUserId = default,
            string? lastName = default,
            string? q = default,
            string? search = default,
            string? username = default,
            global::Loud.Technology.Keycloak.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}