using FluentResults;
using Newtonsoft.Json;
using PetsFile.Application.Common.Constants;
using PetsFile.Application.Owners.Interfaces;
using PetsFile.Application.Owners.Messages.Commands;
using System.Net.Http.Headers;

namespace PetsFIle.Infrastructure.Owners.Http
{
    public sealed class OwnerApi : IOwnerApi
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public OwnerApi(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<Result> CreateOwner(RegisterOwnerCommand request)
        {

            var client = _httpClientFactory.CreateClient(HttpClientNames.PawsMeetingsApi);
            var requestJson = JsonConvert.SerializeObject(request);
            var content = new StringContent(requestJson);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            try
            {
                var response = await client.PostAsync("api/owner", content);
                return response.IsSuccessStatusCode
                    ? Result.Fail("Failed to create Owner")
                    :Result.Ok();
            }
            catch (HttpRequestException ex)
            {
                return Result.Fail(new ExceptionalError(ex));
            }
        }
    }
}
