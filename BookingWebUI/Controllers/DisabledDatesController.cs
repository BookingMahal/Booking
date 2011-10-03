﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ploeh.Samples.Booking.WebUI.Controllers
{
    public class DisabledDatesController : Controller
    {
        public JsonResult Get(int year, int month)
        {
            return this.Json(new string[0]);
        }
    }
}