using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Swashbuckle.Swagger.Annotations;
using attend_data;

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
        public MeetingRetrieve Get(Guid id)
        {
            return new MeetingRetrieve { Id = Guid.NewGuid() };
        }
    }
}
