﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace VisitorsProjectAPI.Controllers
{
    public class GuardController : ApiController
    {
        SQLAccess sqlAccess = new SQLAccess();
        public bool CheckIfGuardExists(string GuardId, string Password)
        {
            return sqlAccess.UserValidation(GuardId, Password); 
        }
    }
}
