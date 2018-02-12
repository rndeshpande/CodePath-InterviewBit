namespace CodePathShortner.Controllers.Api
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;
    using Models;
    using Providers;

    [RoutePrefix("api/v1/links")]
    public class LinksController : ApiController
    {
        [HttpGet]
        [Route("{linkId}")]
        public HttpResponseMessage Resolve(string linkId)
        {
            var result = DataProvider.ResolveUrl(linkId);
            var response = new HttpResponseMessage
            {
                StatusCode = result.Status,
                Content = new StringContent(linkId)
            };

            if (!string.IsNullOrEmpty(result.Url))
            {
                response.Headers.Location = new Uri(result.Url);
            }
            return response;
        }

        [HttpPost]
        [Route("")]
        public HttpResponseMessage Create(CreateRequestModel request)
        {
            var result = DataProvider.CreateShortUrl(request);
            var response = new HttpResponseMessage
            {
                StatusCode = result.Status
            };  

            if(!string.IsNullOrEmpty(result.ShortUrl))
            {
                response.Headers.Location = new Uri(result.ShortUrl);
            }            

            return response;
        }


    }
}
