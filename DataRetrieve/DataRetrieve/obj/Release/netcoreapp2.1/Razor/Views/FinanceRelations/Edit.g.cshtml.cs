#pragma checksum "D:\TFS\TDM\DataRetrieve\DataRetrieve\Views\FinanceRelations\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9dd7a8ab981bb42c74ac356b44f5d85503d2fee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FinanceRelations_Edit), @"mvc.1.0.view", @"/Views/FinanceRelations/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/FinanceRelations/Edit.cshtml", typeof(AspNetCore.Views_FinanceRelations_Edit))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\TFS\TDM\DataRetrieve\DataRetrieve\Views\_ViewImports.cshtml"
using Kendo.Mvc.UI;

#line default
#line hidden
#line 2 "D:\TFS\TDM\DataRetrieve\DataRetrieve\Views\_ViewImports.cshtml"
using DataRetrieve;

#line default
#line hidden
#line 3 "D:\TFS\TDM\DataRetrieve\DataRetrieve\Views\_ViewImports.cshtml"
using DataRetrieve.Controllers;

#line default
#line hidden
#line 4 "D:\TFS\TDM\DataRetrieve\DataRetrieve\Views\_ViewImports.cshtml"
using DataRetrieve.ConfigHelper;

#line default
#line hidden
#line 5 "D:\TFS\TDM\DataRetrieve\DataRetrieve\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#line 6 "D:\TFS\TDM\DataRetrieve\DataRetrieve\Views\_ViewImports.cshtml"
using DataRetrieve.Models;

#line default
#line hidden
#line 7 "D:\TFS\TDM\DataRetrieve\DataRetrieve\Views\_ViewImports.cshtml"
using Capital.Library;

#line default
#line hidden
#line 8 "D:\TFS\TDM\DataRetrieve\DataRetrieve\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#line 9 "D:\TFS\TDM\DataRetrieve\DataRetrieve\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#line 10 "D:\TFS\TDM\DataRetrieve\DataRetrieve\Views\_ViewImports.cshtml"
using PagedList.Core.Mvc;

#line default
#line hidden
#line 11 "D:\TFS\TDM\DataRetrieve\DataRetrieve\Views\_ViewImports.cshtml"
using System.Dynamic;

#line default
#line hidden
#line 12 "D:\TFS\TDM\DataRetrieve\DataRetrieve\Views\_ViewImports.cshtml"
using DataRetrieve.DataAccess;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9dd7a8ab981bb42c74ac356b44f5d85503d2fee", @"/Views/FinanceRelations/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfcd64fc1d80f86ec2603a1f6687cbff9b45b562", @"/Views/_ViewImports.cshtml")]
    public class Views_FinanceRelations_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\TFS\TDM\DataRetrieve\DataRetrieve\Views\FinanceRelations\Edit.cshtml"
  
    ViewData["Title"] = "財務關係人";
    ViewBag.SiteMapHead = "財務關係人";

#line default
#line hidden
            BeginContext(77, 18, true);
            WriteLiteral("<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(95, 442, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "358e071b144448468e99b2d1806246ba", async() => {
                BeginContext(101, 429, true);
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <title>Metronic Admin Theme #1 | Bootstrap Form Wizard</title>
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta content=""width=device-width, initial-scale=1"" name=""viewport"" />
    <meta content=""Preview page of Metronic Admin Theme #1 for bootstrap form wizard demos using Twitter Bootstrap Wizard Plugin"" name=""description"" />
    <meta content="""" name=""author"" />

");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(537, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(539, 3187, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67097b41ac2d4ee4bf3c15f6a8825f2e", async() => {
                BeginContext(545, 3174, true);
                WriteLiteral(@"
    <div id=""ViewAccount"" style=""font-family:'微軟正黑體';color:#4F4F4F	"">
        <div class=""col-md-7 portlet light portlet-fit portlet-form bordered"">
            <div class=""portlet-body"">
                <div class=""form-body"">

                    <div class=""form-group form-md-line-input"">
                        <label class=""col-md-4 control-label"" style=""text-align:right"" for=""form_control_1"">
                            編號
                            <span class=""required"" aria-required=""true"">*</span>
                        </label>
                        <div class=""col-md-3 col-xs-12"">
                            <input type=""text"" class=""form-control"" placeholder="""" name=""name"" aria-required=""true"" aria-invalid=""false"" aria-describedby=""name-error""><span id=""name-error"" class=""help-block help-block-error""></span>
                            <div class=""form-control-focus""> </div>
                            <span class=""help-block"">請輸入編號</span>
                        </div>
     ");
                WriteLiteral(@"               </div>
                    <div class=""form-group form-md-line-input"">
                        <label class=""col-md-4 control-label"" style=""text-align:right"" for=""form_control_1"">
                            客戶名稱
                            <span class=""required"" aria-required=""true"">*</span>
                        </label>
                        <div class=""col-md-3 col-xs-12"">
                            <input type=""text"" class=""form-control"" placeholder="""" name=""name"" aria-required=""true"" aria-invalid=""false"" aria-describedby=""name-error""><span id=""name-error"" class=""help-block help-block-error""></span>
                            <div class=""form-control-focus""> </div>
                            <span class=""help-block"">請輸入客戶名稱</span>
                        </div>
                    </div>
                    <div class=""form-group form-md-line-input"">
                        <label class=""col-md-4 control-label"" style=""text-align:right"" for=""form_control_1"">
           ");
                WriteLiteral(@"                 身分證字號或營利事業統一編號
                            <span class=""required"" aria-required=""true"">*</span>
                        </label>
                        <div class=""col-md-3 col-xs-12"">
                            <input type=""text"" class=""form-control"" placeholder="""" name=""name"" aria-required=""true"" aria-invalid=""false"" aria-describedby=""name-error""><span id=""name-error"" class=""help-block help-block-error""></span>
                            <div class=""form-control-focus""> </div>
                            <span class=""help-block"">請輸入身分證字號或營利事業統一編號</span>
                        </div>
                    </div>
                </div>
                <div class=""form-actions"">
                    <div class=""row"">
                        <div class=""col-md-offset-5 col-md-7"">
                            <button type=""submit"" class=""btn green"">Validate</button>
                            <button type=""reset"" class=""btn default"">Reset</button>
                        </div>
");
                WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
