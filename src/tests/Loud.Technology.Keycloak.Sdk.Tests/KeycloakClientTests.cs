using System.Net;
using System.Net.Http.Headers;
using System.Text;

namespace Loud.Technology.Keycloak.Sdk.Tests;

[TestClass]
public sealed class KeycloakClientTests
{
    [TestMethod]
    public async Task GetRealmsUsesConfiguredBaseUrlAndBearerToken()
    {
        var handler = new RecordingHandler();
        using var httpClient = new HttpClient(handler);
        using var client = new KeycloakClient(
            apiKey: "test-access-token",
            httpClient: httpClient,
            baseUri: new Uri("https://identity.example.com/keycloak/"),
            disposeHttpClient: false);

        var realms = await client.RealmsAdmin.GetAdminRealmsAsync();

        Assert.AreEqual(0, realms.Count);
        Assert.AreEqual(HttpMethod.Get, handler.Method);
        Assert.AreEqual(
            new Uri("https://identity.example.com/keycloak/admin/realms"),
            handler.RequestUri);
        Assert.AreEqual("Bearer", handler.Authorization?.Scheme);
        Assert.AreEqual("test-access-token", handler.Authorization?.Parameter);
    }

    [TestMethod]
    public void DefaultBaseUrlIsAppliedToTheClient()
    {
        using var client = new KeycloakClient("test-access-token");

        Assert.AreEqual(new Uri("http://localhost:8080/"), client.BaseUri);
    }

    private sealed class RecordingHandler : HttpMessageHandler
    {
        public HttpMethod? Method { get; private set; }

        public Uri? RequestUri { get; private set; }

        public AuthenticationHeaderValue? Authorization { get; private set; }

        protected override Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            Method = request.Method;
            RequestUri = request.RequestUri;
            Authorization = request.Headers.Authorization;

            return Task.FromResult(
                new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent("[]", Encoding.UTF8, "application/json"),
                });
        }
    }
}
