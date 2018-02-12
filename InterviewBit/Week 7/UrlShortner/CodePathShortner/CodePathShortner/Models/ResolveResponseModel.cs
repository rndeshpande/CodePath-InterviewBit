using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using System.Net;

namespace CodePathShortner.Models
{
    public class ResolveResponseModel
    {        
        public string Url { get; set; }

        public HttpStatusCode Status { get; set; }
    }
}