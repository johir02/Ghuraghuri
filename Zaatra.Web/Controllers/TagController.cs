using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zaatra.Models.ViewModels;
using Zaatra.Services;

namespace Zaatra.Controllers
{
    public class TagController : BaseController
    {
        readonly TagService _tagService = new TagService();

        public ActionResult GetTags()
        {
            var tags = _tagService.GetTagsForFilterPortion();
            return Json(tags, JsonRequestBehavior.AllowGet);
        }
    }
}