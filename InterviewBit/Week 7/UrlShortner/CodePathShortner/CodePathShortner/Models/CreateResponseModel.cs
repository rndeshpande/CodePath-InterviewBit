using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using System.Net;

namespace CodePathShortner.Models
{
    public class CreateResponseModel
    {        
        public string ShortUrl { get; set; }

        public HttpStatusCode Status { get; set; }
    }
}