#pragma checksum "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\PaymentResult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0cbda3a633303f21e1c9dee02c28b738c34c346a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Pages.Pages_PaymentResult), @"mvc.1.0.razor-page", @"/Pages/PaymentResult.cshtml")]
namespace ServiceHost.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\_ViewImports.cshtml"
using ServiceHost;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cbda3a633303f21e1c9dee02c28b738c34c346a", @"/Pages/PaymentResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d027006424b9e12b1709732f146fce9f1d78e6a1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_PaymentResult : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\PaymentResult.cshtml"
  
    ViewData["Title"] = "نتیجه پرداخت";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<br/>
<br/>
<div class=""site-content"">
    <main class=""site-main  main-container no-sidebar"">
        <div class=""container"">
            <div class=""row RightDirection"">
                <div class=""main-content-cart main-content col-sm-12"">
                    <h3 class=""custom_blog_title RightDirection"">
                        نتیجه پرداخت
                    </h3>
                    
");
#nullable restore
#line 18 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\PaymentResult.cshtml"
                     if (Model.Result.IsSuccessful)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"alert alert-success\">\r\n                        \r\n                            <p>\r\n                                ");
#nullable restore
#line 23 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\PaymentResult.cshtml"
                           Write(Model.Result.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n                            <p>\r\n                                شماره پیگیری : <strong> ");
#nullable restore
#line 26 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\PaymentResult.cshtml"
                                                   Write(Model.Result.IssueTrackingNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                            </p>\r\n\r\n                        </div>\r\n");
#nullable restore
#line 30 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\PaymentResult.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"alert alert-danger\">\r\n                        \r\n                            <p>\r\n                                ");
#nullable restore
#line 36 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\PaymentResult.cshtml"
                           Write(Model.Result.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n\r\n                        </div>\r\n");
#nullable restore
#line 40 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\PaymentResult.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    \r\n\r\n                    </div>\r\n            </div>\r\n        </div>\r\n    </main>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ServiceHost.Pages.PaymentResultModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ServiceHost.Pages.PaymentResultModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ServiceHost.Pages.PaymentResultModel>)PageContext?.ViewData;
        public ServiceHost.Pages.PaymentResultModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591