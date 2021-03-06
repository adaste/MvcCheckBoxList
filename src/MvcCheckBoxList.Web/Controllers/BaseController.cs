﻿using System.Web.Mvc;

namespace MvcCheckBoxListSampleApp.Controllers {
  public class BaseController : Controller {
    public BaseController() {
      ViewBag.AuthorUrl = "http://www.codeproject.com/Members/Mikhail-T";

      ViewBag.CodePrejectUrl =
        "http://www.codeproject.com/Articles/292050/CheckBoxList-For-a-missing-MVC-extension";

      ViewBag.GitHubZipSourceUrl =
        "https://github.com/mikhail-tsennykh/MvcCheckBoxList/archive/dev.zip";

      ViewBag.GitHubUrl = "https://github.com/mikhail-tsennykh/MvcCheckBoxList";

      ViewBag.LicenseUrl = "http://www.codeproject.com/info/cpol10.aspx";
    }
  }
}