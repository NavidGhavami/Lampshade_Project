#pragma checksum "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\Shared\Components\Slider\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f55892fd1f10c0d3fa71144955229bf17aecf492"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Pages.Shared.Components.Slider.Pages_Shared_Components_Slider_Default), @"mvc.1.0.view", @"/Pages/Shared/Components/Slider/Default.cshtml")]
namespace ServiceHost.Pages.Shared.Components.Slider
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f55892fd1f10c0d3fa71144955229bf17aecf492", @"/Pages/Shared/Components/Slider/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d027006424b9e12b1709732f146fce9f1d78e6a1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared_Components_Slider_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<_01_LampshadeQuery.Contracts.Slider.SliderQueryModel>>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div class=""home-slider style1 rows-space-30"">
            <div class=""container"">
                <div class=""slider-owl owl-slick equal-container nav-center""
                     data-slick='{""autoplay"":true, ""autoplaySpeed"":9000, ""arrows"":true, ""dots"":false, ""infinite"":true, ""speed"":1000, ""rows"":1}'
                     data-responsive='[{""breakpoint"":""2000"",""settings"":{""slidesToShow"":1}}]'>

");
#nullable restore
#line 12 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\Shared\Components\Slider\Default.cshtml"
                     foreach (var item in Model)
                    {
                        
                        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""slider-item "">
                            
                            <div class=""slider-inner equal-element"">
                                <div class=""slider-infor"">
                                    <h5 class=""title-small"">
                                        ");
#nullable restore
#line 21 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\Shared\Components\Slider\Default.cshtml"
                                   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </h5>\r\n                                    <h3 class=\"title-big\">\r\n                                        ");
#nullable restore
#line 24 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\Shared\Components\Slider\Default.cshtml"
                                   Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br/>\r\n\r\n                                    </h3>\r\n                                    <div class=\"price\">\r\n                                        ");
#nullable restore
#line 28 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\Shared\Components\Slider\Default.cshtml"
                                   Write(item.Heading);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        <span class=\"number-price\">\r\n\r\n                                        </span>\r\n                                    </div>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1454, "\"", 1474, 1);
#nullable restore
#line 33 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\Shared\Components\Slider\Default.cshtml"
WriteAttributeValue("", 1461, item.UrlLink, 1461, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"button btn-shop-the-look bgroud-style\">");
#nullable restore
#line 33 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\Shared\Components\Slider\Default.cshtml"
                                                                                                     Write(item.BtnText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </div>\r\n                            </div>\r\n                            <div");
            BeginWriteAttribute("class", " class=\"", 1649, "\"", 1657, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f55892fd1f10c0d3fa71144955229bf17aecf4926747", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1703, "~/ProductPicture/", 1703, 17, true);
#nullable restore
#line 37 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\Shared\Components\Slider\Default.cshtml"
AddHtmlAttributeValue("", 1720, item.Picture, 1720, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 37 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\Shared\Components\Slider\Default.cshtml"
AddHtmlAttributeValue("", 1740, item.PictureAlt, 1740, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 37 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\Shared\Components\Slider\Default.cshtml"
AddHtmlAttributeValue("", 1765, item.PictureTitle, 1765, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 40 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\Shared\Components\Slider\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<_01_LampshadeQuery.Contracts.Slider.SliderQueryModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
