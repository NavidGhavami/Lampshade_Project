#pragma checksum "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29c80bde206e1a8b9b2451aa00bfcf7f805b12e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29c80bde206e1a8b9b2451aa00bfcf7f805b12e4", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d027006424b9e12b1709732f146fce9f1d78e6a1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\Index.cshtml"
  
    ViewData["Title"] = "فروشگاه اینترنتی دکومال";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"main-content\">\r\n<div class=\"fullwidth-template\">\r\n\r\n<!--Slider -->\r\n\r\n");
#nullable restore
#line 12 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\Index.cshtml"
Write(await Component.InvokeAsync("Slider"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!-- End Slider-->\r\n\r\n<!--Category Area-->\r\n\r\n");
#nullable restore
#line 18 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\Index.cshtml"
Write(await Component.InvokeAsync("ProductCategory"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!-- End Category Area-->\r\n\r\n<!--Show Products By Categories -->\r\n\r\n");
#nullable restore
#line 24 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\Index.cshtml"
Write(await Component.InvokeAsync("ProductCategoryWithProduct"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!-- End Show Products By Categories-->\r\n\r\n\r\n<!--Big banner Starts -->\r\n\r\n");
#nullable restore
#line 31 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\Index.cshtml"
Write(await Component.InvokeAsync("BigBanner"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!--Big banner End -->\r\n\r\n\r\n\r\n<!--Latest Products Starts -->\r\n\r\n");
#nullable restore
#line 39 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\Index.cshtml"
Write(await Component.InvokeAsync("LatestProducts"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!-- End Latest Products-->\r\n\r\n\r\n<!--Small banner Starts -->\r\n\r\n");
#nullable restore
#line 46 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\Index.cshtml"
Write(await Component.InvokeAsync("SmallBanner"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<!--Small banner End -->\r\n\r\n<!-- Product Discount Start -->\r\n\r\n");
#nullable restore
#line 53 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\Index.cshtml"
Write(await Component.InvokeAsync("ProductDiscount"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!-- Product Discount End -->\r\n\r\n<!-- Articles Start -->\r\n\r\n");
#nullable restore
#line 59 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\Index.cshtml"
Write(await Component.InvokeAsync("Articles"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!-- Articles End -->\r\n\r\n</div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
