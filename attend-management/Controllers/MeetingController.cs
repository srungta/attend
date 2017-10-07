using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Swashbuckle.Swagger.Annotations;

namespace attend_management.Controllers
{
    [RoutePrefix("api/v1.0/meetings")]
    public class MeetingController : ApiController
    {
        // GET api/v1.0/meetings/{id}
        [Route("{id}")]
        [SwaggerOperation("GetById")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public string Get(Guid id)
        {
            return "value";
        }
    }
}
