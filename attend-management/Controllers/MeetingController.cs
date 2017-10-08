using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Swashbuckle.Swagger.Annotations;
using attend_data;
using attend_data.Repo;

namespace attend_management.Controllers
{
    [RoutePrefix("api/v1.0/meetings")]
    public class MeetingController : ApiController
    {
        private IMeetingRepository meetingRepo;

        public MeetingController(IMeetingRepository meetingRepo)
        {
            this.meetingRepo = meetingRepo;
        }

        // GET api/v1.0/meetings/{id}
        [Route("{id}")]
        [SwaggerOperation("GetById")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public Meeting Get(string id)
        {
            return meetingRepo.Retrieve(Guid.NewGuid());
        }
    }
}
