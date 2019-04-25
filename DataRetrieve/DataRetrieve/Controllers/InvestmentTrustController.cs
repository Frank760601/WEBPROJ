using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using Dapper;
using System.Net;
using System.Collections.Specialized;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.IO;
using System.Reflection;
using System.ComponentModel.DataAnnotations;
using PagedList.Core;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using Microsoft.AspNetCore.Hosting;
using DataRetrieve;
using DataRetrieve.LogHelper;
using Capital.Library;
using DataRetrieve.Filter;
using DataRetrieve.BusinessLogic;
using System.Dynamic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using NPOI.HSSF.Util;
using NPOI.SS.Util;
using System.Globalization;

namespace DataRetrieve.Controllers
{
    //[TypeFilter(typeof(ProgramIDAuthorizeAttribute), Arguments= new object[] { 376400 })]
    public class InvestmentTrustController : IController
    {
        private IHostingEnvironment _hostingEnvironment;
        private IEmployee _emp;

        int AddSign = 0;
        ILog _log = ILogHelper.GetLog("Nlog");
        public InvestmentTrustController(IEmployee employee, IHostingEnvironment hostingEnvironment) : base(employee, hostingEnvironment)
        {
            _emp = employee;
            _hostingEnvironment = hostingEnvironment;
        }
        //private GoPlusContext _db;
        public ActionResult Index()
        {
            _log.Debug("aabbccdd");
            //var a = _db.TblStatus.Select(s => s.ContractNo);
            return View();
        }
        public ActionResult ReIndex(bool MsgCode, string MsgName)
        {
            ViewBag.Msg = new { MsgCode = MsgCode, MsgName = MsgName };
            //_log.Debug("aabbccdd");
            //var a = _db.TblStatus.Select(s => s.ContractNo);
            return View("~/Views/InvestmentTrust/Index.cshtml");
        }
        
        [HttpPost]
        public async Task<PartialViewResult> PartialIndex()
        {

            IFormCollection form = await HttpContext.Request.ReadFormAsync();

            int pageIndex = 1;
            int pageSize = 10;
            pageIndex = Int32.Parse(form["page"]);

            var data = InvestmentTrustBL.getInstance().Query(form["vNO"].ToString(), form["vNAME"], form["vIDNO"], pageIndex, pageSize);

            return PartialView("~/Views/InvestmentTrust/_PartialIndex.cshtml", data);
        }
        [HttpPost]
        public async Task<JsonResult> Update()
        {
            dynamic model = new ExpandoObject();
            IFormCollection form = await HttpContext.Request.ReadFormAsync();
            (model.MsgCode, model.MsgName) = InvestmentTrustBL.getInstance().UpdateInvestmentTrust(form["NO"].ToString(), form["NAME"], form["IDNO"]);

            return Json(model);
        }
    }
}