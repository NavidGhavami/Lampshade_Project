#pragma checksum "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\Product.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e46c449093e72e6c76b05b286d87c76c4e7d9edf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Pages.Pages_Product), @"mvc.1.0.razor-page", @"/Pages/Product.cshtml")]
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
#nullable restore
#line 2 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\Product.cshtml"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e46c449093e72e6c76b05b286d87c76c4e7d9edf", @"/Pages/Product.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d027006424b9e12b1709732f146fce9f1d78e6a1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Product : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/ProductCategory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("img_zoom"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\Product.cshtml"
  
    ViewData["Title"] = "جزییات محصول";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""main-content main-content-details single no-sidebar"">
<div class=""container"">
<div class=""row"">
    <div class=""col-lg-12"">
        <div class=""breadcrumb-trail breadcrumbs"">
            <ul class=""trail-items breadcrumb"">
                <li class=""trail-item trail-begin"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e46c449093e72e6c76b05b286d87c76c4e7d9edf5162", async() => {
                WriteLiteral("صفحه اصلی");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </li>\r\n                <li class=\"trail-item\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e46c449093e72e6c76b05b286d87c76c4e7d9edf6408", async() => {
#nullable restore
#line 18 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\Product.cshtml"
                                                                                         Write(Model.Product.Category);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 18 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\Product.cshtml"
                                                     WriteLiteral(Model.Product.CategorySlug);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </li>\r\n                <li class=\"trail-item trail-end active\">\r\n                    ");
#nullable restore
#line 21 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\Product.cshtml"
               Write(Model.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </li>
            </ul>
        </div>
    </div>
</div>
<br/>
<div class=""row"">
<div class=""content-area content-details full-width col-lg-9 col-md-8 col-sm-12 col-xs-12"">
<div class=""site-main"">
<div class=""details-product"">
    <div class=""details-thumd"">
        <div class=""image-preview-container image-thick-box image_preview_container"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e46c449093e72e6c76b05b286d87c76c4e7d9edf9592", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginWriteTagHelperAttribute();
            WriteLiteral("~/ProductPicture/");
#nullable restore
#line 34 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\Product.cshtml"
                                                             Write(Model.Product.Picture);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("data-zoom-image", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1287, "~/ProductPicture/", 1287, 17, true);
#nullable restore
#line 35 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\Product.cshtml"
AddHtmlAttributeValue("", 1304, Model.Product.Picture, 1304, 22, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 35 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\Product.cshtml"
AddHtmlAttributeValue("", 1333, Model.Product.PictureAlt, 1333, 25, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 35 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\Product.cshtml"
AddHtmlAttributeValue("", 1367, Model.Product.PictureTitle, 1367, 27, false);

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
            WriteLiteral(@"
            <a href=""#img_zoom""></a>
        </div>
        <div class=""product-preview image-small product_preview"">
            <div id=""thumbnails"" class=""thumbnails_carousel owl-carousel"" data-nav=""true""
                 data-autoplay=""false"" data-dots=""false"" data-loop=""false"" data-margin=""10""
                 data-responsive='{""0"":{""items"":3},""480"":{""items"":3},""600"":{""items"":3},""1000"":{""items"":3}}'>
");
#nullable restore
#line 42 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\Product.cshtml"
                 foreach (var item in Model.Product.Pictures)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a href=\"#\" data-image=\"~/ProductPicture/");
#nullable restore
#line 44 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\Product.cshtml"
                                                        Write(item.Picture);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n                       data-zoom-image=\"~/ProductPicture/");
#nullable restore
#line 45 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\Product.cshtml"
                                                    Write(item.Picture);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("class", " class=\"", 2043, "\"", 2051, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e46c449093e72e6c76b05b286d87c76c4e7d9edf14353", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2089, "~/ProductPicture/", 2089, 17, true);
#nullable restore
#line 46 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\Product.cshtml"
AddHtmlAttributeValue("", 2106, item.Picture, 2106, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginWriteTagHelperAttribute();
            WriteLiteral("~/ProductPicture/");
#nullable restore
#line 47 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\Product.cshtml"
                                                           Write(item.Picture);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("data-large-image", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 47 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\Product.cshtml"
AddHtmlAttributeValue("", 2207, item.PictureAlt, 2207, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 47 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\Product.cshtml"
AddHtmlAttributeValue("", 2232, item.PictureTitle, 2232, 18, false);

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
            WriteLiteral("\r\n                    </a>\r\n");
#nullable restore
#line 49 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\Product.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"details-infor RightDirection\">\r\n        <h1 class=\"product-title\">\r\n            ");
#nullable restore
#line 55 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\Product.cshtml"
       Write(Model.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </h1>
        <div class=""stars-rating"">
            <div class=""star-rating"">
                <span class=""star-5""></span>
            </div>
            <div class=""count-star"">
                (7)
            </div>
        </div>
        <div class=""availability"">
            گروه محصول : 
            <a href=""#"">");
#nullable restore
#line 67 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\Product.cshtml"
                   Write(Model.Product.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        </div>\r\n        <div class=\"availability\">\r\n            کد محصول : \r\n            <a href=\"#\">");
#nullable restore
#line 71 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\Product.cshtml"
                   Write(Model.Product.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        </div>\r\n");
#nullable restore
#line 73 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\Product.cshtml"
         if (@Model.Product.InStock)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"availability\">\r\n                <span class=\"text-success\">موجود در انبار</span>\r\n            </div>\r\n");
#nullable restore
#line 78 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\Product.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"availability\">\r\n                <span class=\"text-danger\">در انبار موجود نمی باشد</span>\r\n            </div>\r\n");
#nullable restore
#line 84 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\Product.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br/>\r\n");
#nullable restore
#line 86 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\Product.cshtml"
         if (Model.Product.HasDiscount)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"ProductDetailPrice\">\r\n                <del>\r\n                    ");
#nullable restore
#line 90 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\Product.cshtml"
               Write(Model.Product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </del>\r\n                                    \r\n                __\r\n\r\n                <ins>\r\n                    ");
#nullable restore
#line 96 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\Product.cshtml"
               Write(Model.Product.PriceWithDiscount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان\r\n                </ins>\r\n            </div>\r\n");
#nullable restore
#line 99 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\Product.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"ProductDetailPrice\">\r\n                <ins>\r\n                    ");
#nullable restore
#line 104 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\Product.cshtml"
               Write(Model.Product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان\r\n                </ins>\r\n            </div>\r\n");
#nullable restore
#line 107 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\Product.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <hr />\r\n        <div class=\"product-details-description\">\r\n            <p>\r\n                ");
#nullable restore
#line 111 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\Product.cshtml"
           Write(Model.Product.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </p>
        </div>
        <div class=""group-button"">
            <div class=""yith-wcwl-add-to-wishlist"">
                <div class=""yith-wcwl-add-button"">
                    <a href=""#""> افزودن به علاقه مندی ها </a>
                </div>
            </div>
            <br/>
            <div");
            BeginWriteAttribute("class", " class=\"", 4376, "\"", 4384, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div");
            BeginWriteAttribute("class", " class=\"", 4408, "\"", 4416, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <span>تگ ها :\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e46c449093e72e6c76b05b286d87c76c4e7d9edf22985", async() => {
#nullable restore
#line 124 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\Product.cshtml"
                                         Write(Model.Product.Keywords);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </span>
                </div>
            </div>
            <br/>
            <div class=""quantity-add-to-cart"">
                <div class=""quantity"">
                    <div class=""control"">
                        <a class=""btn-number qtyminus quantity-minus"" href=""#"">-</a>
                        <input type=""text"" data-step=""1"" data-min=""0"" value=""1"" title=""Qty"" class=""input-qty qty"" size=""4"">
                        <a href=""#"" class=""btn-number qtyplus quantity-plus"">+</a>
                    </div>
                </div>
                <button class=""single_add_to_cart_button button"">افزودن به سبد خرید</button>
            </div>
        </div>
    </div>
</div>
<div class=""tab-details-product RightDirection"">
    <ul class=""tab-link"">
        <li class=""active"">
            <a data-toggle=""tab"" aria-expanded=""true"" href=""#product-descriptions"">توضیحات محصول</a>
        </li>
        <li");
            BeginWriteAttribute("class", " class=\"", 5484, "\"", 5492, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <a data-toggle=\"tab\" aria-expanded=\"false\" href=\"#information\">مشخصات محصول </a>\r\n        </li>\r\n        <li");
            BeginWriteAttribute("class", " class=\"", 5616, "\"", 5624, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <a data-toggle=\"tab\" aria-expanded=\"false\" href=\"#reviews\">نظرات: (");
#nullable restore
#line 151 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\Product.cshtml"
                                                                          Write(Model.Product.Comments.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</a>\r\n        </li>\r\n    </ul>\r\n    <div class=\"tab-container\">\r\n        <div id=\"product-descriptions\" class=\"tab-panel active\">\r\n            <p>\r\n                ");
#nullable restore
#line 157 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\Product.cshtml"
           Write(Model.Product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </p>
        </div>
        <div id=""information"" class=""tab-panel"">
            <table class=""table table-bordered"">
                <tbody><tr>
                    <td>Size</td>
                    <td> XS / S / M / L</td>
                </tr>
                <tr>
                    <td>Color</td>
                    <td>White/ Black/ Teal/ Brown</td>
                </tr>
                <tr>
                    <td>Properties</td>
                    <td>Colorful Dress</td>
                </tr>
                </tbody></table>
        </div>
        ");
#nullable restore
#line 176 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\Product.cshtml"
   Write(await Component.InvokeAsync("Comment"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div style=\"clear: left;\"></div>\r\n</div>\r\n</div>\r\n</div>\r\n</div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ServiceHost.Pages.ProductModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ServiceHost.Pages.ProductModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ServiceHost.Pages.ProductModel>)PageContext?.ViewData;
        public ServiceHost.Pages.ProductModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
