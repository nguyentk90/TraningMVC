using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TraningMVC.CustomActionResults
{
    public class ExcelResult : ActionResult
    {
        public string Path { get; set; }
        public override void ExecuteResult(ControllerContext context)
        {
            var response = context.HttpContext.Response;
            var request = context.HttpContext.Request;

            var canProcess = request.AcceptTypes.Contains("application/vnd.ms-excel");

            if (canProcess)
            {
                response.Clear();
                response.AddHeader("content-disposition", "attachment; filename=dl");

                response.WriteFile(context.HttpContext.Server.MapPath(Path));
            }
        }
    }
}