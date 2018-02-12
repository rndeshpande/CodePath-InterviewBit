using System;
using System.Collections.Generic;
using System.Linq;

namespace CodePathShortner.Providers
{
    using Models;
    using System.Net;

    public static class DataProvider
    {
        private static IDictionary<string, string> Urls = new Dictionary<string, string>();
        private static string UrlPrefix = "http://localhost:50834/api/v1/links/";
        private static Random random = new Random();

        public static ResolveResponseModel ResolveUrl(string linkId)
        {
            var response = new ResolveResponseModel();
            response.Status = HttpStatusCode.Found;

            if (Urls.ContainsKey(linkId))
            {
                response.Url = Urls[linkId];
            }
            else
            {
                response.Status = HttpStatusCode.NotFound;
            }

            return response;
        }

        public static CreateResponseModel CreateShortUrl(CreateRequestModel request)
        {
            var response = new CreateResponseModel()
            {
                ShortUrl = string.Empty,
                Status = HttpStatusCode.Created
            };

            if (!string.IsNullOrEmpty(request.FriendlyId))
            {
                if (!Urls.ContainsKey(request.FriendlyId))
                {
                    Urls.Add(request.FriendlyId, request.Url);
                    response.ShortUrl = UrlPrefix + request.FriendlyId;
                }
                else
                {
                    response.Status = HttpStatusCode.Conflict;
                }
            }
            else
            {
                var shortUrlId = GetShortUrl();
                Urls.Add(shortUrlId, request.Url);
                response.ShortUrl = UrlPrefix + shortUrlId;
            }
            

            return response;
        }

        private static string GetShortUrl()
        {
            return RandomString(6);
        }

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

    }
}