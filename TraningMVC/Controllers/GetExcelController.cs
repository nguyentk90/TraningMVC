using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TraningMVC.CustomActionResults;

namespace TraningMVC.Controllers
{
    public class GetExcelController : Controller
    {
        // GET: GetExcel
        public ExcelResult Index()
        {
            var result = new ExcelResult();
            result.Path = "~/Download/Book1.xlsx";
            
            return result;
        }
    }
}