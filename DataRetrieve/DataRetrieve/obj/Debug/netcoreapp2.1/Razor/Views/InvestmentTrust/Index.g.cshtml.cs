#pragma checksum "C:\webproject\WEBPROJ\DataRetrieve\DataRetrieve\Views\InvestmentTrust\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "add2678b1d5c1d8db396d2d18cbf7f5a3ac23d26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_InvestmentTrust_Index), @"mvc.1.0.view", @"/Views/InvestmentTrust/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/InvestmentTrust/Index.cshtml", typeof(AspNetCore.Views_InvestmentTrust_Index))]
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
#line 1 "C:\webproject\WEBPROJ\DataRetrieve\DataRetrieve\Views\_ViewImports.cshtml"
using DataRetrieve;

#line default
#line hidden
#line 1 "C:\webproject\WEBPROJ\DataRetrieve\DataRetrieve\Views\InvestmentTrust\Index.cshtml"
using DataRetrieve.Controllers;

#line default
#line hidden
#line 3 "C:\webproject\WEBPROJ\DataRetrieve\DataRetrieve\Views\_ViewImports.cshtml"
using DataRetrieve.ConfigHelper;

#line default
#line hidden
#line 4 "C:\webproject\WEBPROJ\DataRetrieve\DataRetrieve\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#line 5 "C:\webproject\WEBPROJ\DataRetrieve\DataRetrieve\Views\_ViewImports.cshtml"
using DataRetrieve.Models;

#line default
#line hidden
#line 6 "C:\webproject\WEBPROJ\DataRetrieve\DataRetrieve\Views\_ViewImports.cshtml"
using Capital.Library;

#line default
#line hidden
#line 7 "C:\webproject\WEBPROJ\DataRetrieve\DataRetrieve\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#line 8 "C:\webproject\WEBPROJ\DataRetrieve\DataRetrieve\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#line 9 "C:\webproject\WEBPROJ\DataRetrieve\DataRetrieve\Views\_ViewImports.cshtml"
using System.Dynamic;

#line default
#line hidden
#line 10 "C:\webproject\WEBPROJ\DataRetrieve\DataRetrieve\Views\_ViewImports.cshtml"
using DataRetrieve.DataAccess;

#line default
#line hidden
#line 2 "C:\webproject\WEBPROJ\DataRetrieve\DataRetrieve\Views\InvestmentTrust\Index.cshtml"
using System.Reflection;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"add2678b1d5c1d8db396d2d18cbf7f5a3ac23d26", @"/Views/InvestmentTrust/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7992886cb7fcdbd2cb29ee2a8b5442915981e51", @"/Views/_ViewImports.cshtml")]
    public class Views_InvestmentTrust_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/package/AccountAudit.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "InvestmentTrust", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PartialIndex", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-method", new global::Microsoft.AspNetCore.Html.HtmlString("POST"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-mode", new global::Microsoft.AspNetCore.Html.HtmlString("replace"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-update", new global::Microsoft.AspNetCore.Html.HtmlString("#content"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\webproject\WEBPROJ\DataRetrieve\DataRetrieve\Views\InvestmentTrust\Index.cshtml"
  
    ViewData["Title"] = "群益投信客戶維護";
    ViewBag.SiteMapHead = "群益投信客戶維護";
    PropertyInfo[] temp = ViewBag.Msg != null ? ViewBag.Msg.GetType().GetProperties() : null;
    string MsgCode = (temp == null?string.Empty:(temp[0].GetValue(ViewBag.Msg)).ToString());
    string MsgName = (temp == null?string.Empty:(temp[1].GetValue(ViewBag.Msg)).ToString());


#line default
#line hidden
            BeginContext(427, 18, true);
            WriteLiteral("<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(445, 731, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d62649785ebc43ddb4048cce6f4ef43f", async() => {
                BeginContext(451, 431, true);
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <title>Metronic Admin Theme #1 | Bootstrap Form Wizard</title>
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta content=""width=device-width, initial-scale=1"" name=""viewport"" />
    <meta content=""Preview page of Metronic Admin Theme #1 for bootstrap form wizard demos using Twitter Bootstrap Wizard Plugin"" name=""description"" />
    <meta content="""" name=""author"" />
    ");
                EndContext();
                BeginContext(882, 59, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d2b697f770fc4ddcb96f081b78da4f04", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(941, 228, true);
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/bootstrap-select/1.7.5/css/bootstrap-select.min.css\">\r\n    <script src=\"https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/js/bootstrap.min.js\"></script>\r\n\r\n");
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
            BeginContext(1176, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1178, 3160, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "737cbaa5c5e44040999344c47af4a4ba", async() => {
                BeginContext(1184, 33, true);
                WriteLiteral("\r\n    <div class=\"row\">\r\n        ");
                EndContext();
                BeginContext(1217, 3038, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92d5b88e4ffd4dc5a4543f3744b5c322", async() => {
                    BeginContext(1406, 2651, true);
                    WriteLiteral(@"
            <input type=""hidden"" name=""SDate"" value="""">
            <input type=""hidden"" name=""EDate"" value="""">
            <input type=""hidden"" name=""MarketCode"" value="""">
            <input type=""hidden"" name=""strKind"" value="""">
            <div class=""col-md-8"">
                <div class=""panel panel-primary"">
                    <div class=""panel-heading"">
                        <h3 class=""panel-title"">查詢條件</h3>
                    </div>
                    <div class=""panel-body"">
                        <div>
                            <div>
                                <div class=""col-md-2 col-xs-12"" style=""padding:0%!important"">
                                    <div class=""col-md-4 col-xs-12"" style=""float:left;margin-top:5px;padding:0%"">編號：</div>
                                    <div class=""col-md-8 col-xs-12"" style=""padding:0%"">
                                        <input type=""text"" class=""form-control"" name=""NO"">
                                    </div>
        ");
                    WriteLiteral(@"                        </div>
                                <div class=""col-md-5 col-xs-12"" style=""padding:0%!important"">
                                    <div class=""col-md-6 col-xs-12"" style=""float:left;margin-top:5px;padding:0%"">身份證字號或營利事業統一編號：</div>
                                    <div class=""col-md-6 col-xs-12"" style=""padding:0%"">
                                        <div class=""col-md-11 col-xs-12"" style=""padding:0%!important"">
                                            <input type=""text"" class=""form-control"" name=""IDNO"">
                                        </div>
                                    </div>
                                </div>
                                <div class=""col-md-4 col-xs-12"" style=""padding:0%!important"">
                                    <div class=""col-md-3 col-xs-12"" style=""float:left;margin-top:5px;padding:0%"">客戶名稱：</div>
                                    <div class=""col-md-7 col-xs-12"" style=""padding:0%"">
                            ");
                    WriteLiteral(@"            <input type=""text"" class=""form-control"" name=""NAME"">
                                    </div>
                                </div>
                            </div>
                            <div class=""col-md-12 col-xs-12"" style=""margin-top:5px;padding:0px!important"">
                                <input type=""submit"" name=""txbSearch"" id=""txbSearch"" value=""查詢"" class=""btn btn-default"">
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <input type=""hidden"" name=""page"">
");
                    EndContext();
                    BeginContext(4136, 112, true);
                    WriteLiteral("            <input type=\"submit\" name=\"test\" value=\"Search Books\" style=\"display:none\" onclick=\"\" />\r\n\r\n        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4255, 76, true);
                WriteLiteral("\r\n    </div>\r\n    \r\n    <div id=\"content\" style=\"margin-top:10px\"></div>\r\n\r\n");
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
            BeginContext(4338, 106, true);
            WriteLiteral("\r\n\r\n</html>\r\n\r\n<script>\r\n    var FirstTime = true;\r\n    var code = \"\";\r\n    $(function () {\r\n        if (\'");
            EndContext();
            BeginContext(4445, 17, false);
#line 84 "C:\webproject\WEBPROJ\DataRetrieve\DataRetrieve\Views\InvestmentTrust\Index.cshtml"
        Write(Html.Raw(MsgCode));

#line default
#line hidden
            EndContext();
            BeginContext(4462, 23, true);
            WriteLiteral("\') {\r\n            if (\'");
            EndContext();
            BeginContext(4486, 17, false);
#line 85 "C:\webproject\WEBPROJ\DataRetrieve\DataRetrieve\Views\InvestmentTrust\Index.cshtml"
            Write(Html.Raw(MsgCode));

#line default
#line hidden
            EndContext();
            BeginContext(4503, 310, true);
            WriteLiteral(@"'.toUpperCase() == ""TRUE"")
                swal(""群益投信客戶"", ""新增成功！"", ""success"");
            else
                swal(""群益投信客戶"", ""新增失敗！"", ""error"");
        }
        $(""[name=txbSearch]"").click(function (event) {
            $(""[name=page]"").val(1)
        }).click();
        
    })
    
</script>
");
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
