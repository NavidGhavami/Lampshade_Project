#pragma checksum "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\ProductCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78bdeaad88221f853b33ea03bf8ef9708987ba5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Pages.Pages_ProductCategory), @"mvc.1.0.razor-page", @"/Pages/ProductCategory.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78bdeaad88221f853b33ea03bf8ef9708987ba5f", @"/Pages/ProductCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d027006424b9e12b1709732f146fce9f1d78e6a1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ProductCategory : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "4", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "5", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("select-item select-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\ProductCategory.cshtml"
  
    ViewData["Title"] = " گروه محصولات";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""main-content main-content-product no-sidebar"">
    <div class=""container"">
        <div class=""row"">
        </div>
        <div class=""row RightDirection"">
            <div class=""content-area shop-grid-content full-width col-lg-12 col-md-12 col-sm-12 col-xs-12"">
                <div class=""site-main"">
                    <h3 class=""custom_blog_title MarginTop"">
                        ");
#nullable restore
#line 15 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\ProductCategory.cshtml"
                   Write(Model.ProductCategory.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </h3>\r\n                    <div class=\"shop-top-control row-col-1\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78bdeaad88221f853b33ea03bf8ef9708987ba5f6504", async() => {
                WriteLiteral("\r\n                            <span class=\"title\">نمایش تعداد محصول :</span>\r\n                            <select title=\"sort\" data-placeholder=\"9 Products/Page\" class=\"chosen-select\">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78bdeaad88221f853b33ea03bf8ef9708987ba5f6990", async() => {
                    WriteLiteral("9 Products/Page");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78bdeaad88221f853b33ea03bf8ef9708987ba5f8254", async() => {
                    WriteLiteral("12 Products/Page");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78bdeaad88221f853b33ea03bf8ef9708987ba5f9519", async() => {
                    WriteLiteral("10 Products/Page");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78bdeaad88221f853b33ea03bf8ef9708987ba5f10784", async() => {
                    WriteLiteral("8 Products/Page");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78bdeaad88221f853b33ea03bf8ef9708987ba5f12049", async() => {
                    WriteLiteral("6 Products/Page");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            </select>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <ul class=\"trail-items breadcrumb\">\r\n                            <li class=\"trail-item trail-begin\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78bdeaad88221f853b33ea03bf8ef9708987ba5f14569", async() => {
                WriteLiteral("خانه");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </li>\r\n                            <li class=\"trail-item trail-end active\">\r\n                                ");
#nullable restore
#line 33 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\ProductCategory.cshtml"
                           Write(Model.ProductCategory.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </li>\r\n                        </ul>\r\n                    </div>\r\n                    <ul class=\"row list-products auto-clear equal-container product-grid\">\r\n");
#nullable restore
#line 38 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\ProductCategory.cshtml"
                         foreach (var item in Model.ProductCategory.Products)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"product-item  col-lg-3 col-md-4 col-sm-6 col-xs-6 col-ts-12 style-1\">\r\n                            <div class=\"product-inner equal-element\">\r\n                                <div class=\"product-top\">\r\n");
#nullable restore
#line 43 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\ProductCategory.cshtml"
                                    if (item.HasDiscount)
                                   {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                       <div class=\"onDiscount\">\r\n                                           <span");
            BeginWriteAttribute("class", " class=\"", 2436, "\"", 2444, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                               <span class=\"text\">\r\n                                                   ");
#nullable restore
#line 48 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\ProductCategory.cshtml"
                                              Write(item.DiscountRate);

#line default
#line hidden
#nullable disable
            WriteLiteral(" % تخفیف\r\n                                               </span>\r\n                                           </span>\r\n                                       </div>\r\n");
#nullable restore
#line 52 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\ProductCategory.cshtml"
                                   }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </div>
                                <div class=""product-thumb"">
                                    <div class=""thumb-inner"">
                                        <a href=""#"">
                                            <img");
            BeginWriteAttribute("src", " src=\"", 3054, "\"", 3073, 1);
#nullable restore
#line 57 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\ProductCategory.cshtml"
WriteAttributeValue("", 3060, item.Picture, 3060, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3074, "\"", 3096, 1);
#nullable restore
#line 57 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\ProductCategory.cshtml"
WriteAttributeValue("", 3080, item.PictureAlt, 3080, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 3097, "\"", 3123, 1);
#nullable restore
#line 57 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\ProductCategory.cshtml"
WriteAttributeValue("", 3105, item.PictureTitle, 3105, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                        </a>
                                    </div>
                                </div>
                                <div class=""product-info"">
                                    <h5 class=""product-name product_title"">
                                        <a href=""#"">");
#nullable restore
#line 63 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\ProductCategory.cshtml"
                                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                                    </h5>
                                    <div class=""group-info"">
                                        <div class=""stars-rating CategoryList"">
                                            <div class=""star-rating"">
                                                <span class=""star-3""></span>
                                            </div>
                                            <div class=""count-star"">
                                                (3)
                                            </div>
                                        </div>
");
#nullable restore
#line 74 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\ProductCategory.cshtml"
                                         if (item.HasDiscount)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <div class=\"price CategoryList\">\r\n                                                <del>\r\n                                                    ");
#nullable restore
#line 78 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\ProductCategory.cshtml"
                                               Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </del>\r\n                                                __\r\n\r\n                                                <ins>\r\n                                                    ");
#nullable restore
#line 83 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\ProductCategory.cshtml"
                                               Write(item.PriceWithDiscount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان\r\n                                                </ins>\r\n                                            </div>\r\n");
#nullable restore
#line 86 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\ProductCategory.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <div class=\"price CategoryList\">\r\n                                                <ins>\r\n                                                    ");
#nullable restore
#line 91 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\ProductCategory.cshtml"
                                               Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان\r\n                                                </ins>\r\n                                            </div>\r\n");
#nullable restore
#line 94 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\ProductCategory.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"CategoryListButton\">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 5340, "\"", 5347, 0);
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 5348, "\"", 5356, 0);
            EndWriteAttribute();
            WriteLiteral(">خرید کنید</a>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </li>\r\n");
#nullable restore
#line 102 "F:\Programming\Codes and projects\Lampshade\Lampshade\ServiceHost\Pages\ProductCategory.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </ul>
                    <div class=""pagination clearfix style2"">
                        <div class=""nav-link"">
                            <a href=""#"" class=""page-numbers current""><i class=""icon fa fa-angle-left"" aria-hidden=""true""></i></a>
                            <a href=""#"" class=""page-numbers"">1</a>
                            <a href=""#"" class=""page-numbers"">2</a>
                            <a href=""#"" class=""page-numbers"">3</a>
                            <a href=""#"" class=""page-numbers""><i class=""icon fa fa-angle-right"" aria-hidden=""true""></i></a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ServiceHost.Pages.ProductCategoryModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ServiceHost.Pages.ProductCategoryModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ServiceHost.Pages.ProductCategoryModel>)PageContext?.ViewData;
        public ServiceHost.Pages.ProductCategoryModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
