using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using common;
using Microsoft.AspNet.SignalR;

namespace api.Controllers
{
    public class NotificationController : ApiController
    {
        public IHttpActionResult Post()
        {
            var hub = GlobalHost.ConnectionManager.GetHubContext<NotificationHub>();
            hub.Clients.All.notify();
            return Ok();
        }
    }
}
