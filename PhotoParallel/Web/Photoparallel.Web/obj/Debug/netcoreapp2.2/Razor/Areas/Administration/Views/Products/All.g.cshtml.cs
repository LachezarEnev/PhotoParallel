#pragma checksum "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Areas\Administration\Views\Products\All.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ec74ff89897dd45cf34bd13d330d4e8f1dc5890"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Administration_Views_Products_All), @"mvc.1.0.view", @"/Areas/Administration/Views/Products/All.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Administration/Views/Products/All.cshtml", typeof(AspNetCore.Areas_Administration_Views_Products_All))]
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
#line 1 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Areas\Administration\Views\_ViewImports.cshtml"
using Photoparallel.Web;

#line default
#line hidden
#line 2 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Areas\Administration\Views\_ViewImports.cshtml"
using Photoparallel.Web.ViewModels;

#line default
#line hidden
#line 3 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Areas\Administration\Views\_ViewImports.cshtml"
using Photoparallel.Data.Models.Enums;

#line default
#line hidden
#line 1 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Areas\Administration\Views\Products\All.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#line 2 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Areas\Administration\Views\Products\All.cshtml"
using X.PagedList.Mvc.Common;

#line default
#line hidden
#line 3 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Areas\Administration\Views\Products\All.cshtml"
using X.PagedList;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ec74ff89897dd45cf34bd13d330d4e8f1dc5890", @"/Areas/Administration/Views/Products/All.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"535ab78a90d3d3ac0a28955bed18cb5d765d403d", @"/Areas/Administration/Views/_ViewImports.cshtml")]
    public class Areas_Administration_Views_Products_All : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<Photoparallel.Data.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning btn-sm mobile-fondsize-11"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Hide", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-sm mobile-fondsize-11"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Show", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-sm mobile-fondsize-11"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Supply", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm mobile-fondsize-11"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(83, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(141, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Areas\Administration\Views\Products\All.cshtml"
  
    ViewData["Title"] = "All Products";

#line default
#line hidden
            BeginContext(191, 869, true);
            WriteLiteral(@"
<div class=""container mobile-fondsize-11"">
    <div class=""h2 text-center text-info font-weight-bold"">All Products</div>
    <table class=""table"">
        <thead>
            <tr class=""row"">
                <th scope=""col"" class=""col-1 d-flex justify-content-center""></th>
                <th scope=""col"" class=""col-3 d-flex justify-content-center"">Name</th>
                <th scope=""col"" class=""col-1 d-flex justify-content-center"">Price</th>
                <th scope=""col"" class=""col-2 d-flex justify-content-center"">Brand</th>
                <th scope=""col"" class=""col-1 d-flex justify-content-center"">Status</th>
                <th scope=""col"" class=""col-1 d-flex justify-content-center"">Quantity</th>
                <th scope=""col"" class=""col-3 d-flex justify-content-center"">Actions</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 27 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Areas\Administration\Views\Products\All.cshtml"
             foreach (var product in Model)
            {

#line default
#line hidden
            BeginContext(1120, 128, true);
            WriteLiteral("                <tr class=\"row\">\r\n                    <td class=\"col-1 d-flex justify-content-center\">\r\n                        ");
            EndContext();
            BeginContext(1248, 226, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ec74ff89897dd45cf34bd13d330d4e8f1dc58909959", async() => {
                BeginContext(1337, 34, true);
                WriteLiteral("\r\n                            <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1371, "\"", 1419, 1);
#line 32 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Areas\Administration\Views\Products\All.cshtml"
WriteAttributeValue("", 1377, product.Images.FirstOrDefault()?.ImageUrl, 1377, 42, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1420, 50, true);
                WriteLiteral(" width=\"50\" height=\"50\">\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 31 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Areas\Administration\Views\Products\All.cshtml"
                                                                                        WriteLiteral(product.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(1474, 123, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"col-3 d-flex justify-content-center\">\r\n                        ");
            EndContext();
            BeginContext(1597, 162, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ec74ff89897dd45cf34bd13d330d4e8f1dc589013467", async() => {
                BeginContext(1686, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(1717, 12, false);
#line 37 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Areas\Administration\Views\Products\All.cshtml"
                       Write(product.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1729, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 36 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Areas\Administration\Views\Products\All.cshtml"
                                                                                        WriteLiteral(product.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(1759, 29, true);
            WriteLiteral("\r\n                    </td>\r\n");
            EndContext();
#line 40 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Areas\Administration\Views\Products\All.cshtml"
                     if (product.ProductStatus == ProductStatus.Sale)
                    {

#line default
#line hidden
            BeginContext(1882, 102, true);
            WriteLiteral("                        <td class=\"col-1 d-flex justify-content-center\">\r\n                            ");
            EndContext();
            BeginContext(1985, 13, false);
#line 43 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Areas\Administration\Views\Products\All.cshtml"
                       Write(product.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1998, 37, true);
            WriteLiteral(" lv.\r\n                        </td>\r\n");
            EndContext();
#line 45 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Areas\Administration\Views\Products\All.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(2107, 102, true);
            WriteLiteral("                        <td class=\"col-1 d-flex justify-content-center\">\r\n                            ");
            EndContext();
            BeginContext(2210, 19, false);
#line 49 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Areas\Administration\Views\Products\All.cshtml"
                       Write(product.PricePerDay);

#line default
#line hidden
            EndContext();
            BeginContext(2229, 37, true);
            WriteLiteral(" lv.\r\n                        </td>\r\n");
            EndContext();
#line 51 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Areas\Administration\Views\Products\All.cshtml"
                    }

#line default
#line hidden
            BeginContext(2289, 94, true);
            WriteLiteral("                    <td class=\"col-2 d-flex justify-content-center\">\r\n                        ");
            EndContext();
            BeginContext(2384, 13, false);
#line 53 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Areas\Administration\Views\Products\All.cshtml"
                   Write(product.Brand);

#line default
#line hidden
            EndContext();
            BeginContext(2397, 123, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"col-1 d-flex justify-content-center\">\r\n                        ");
            EndContext();
            BeginContext(2521, 21, false);
#line 56 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Areas\Administration\Views\Products\All.cshtml"
                   Write(product.ProductStatus);

#line default
#line hidden
            EndContext();
            BeginContext(2542, 123, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"col-1 d-flex justify-content-center\">\r\n                        ");
            EndContext();
            BeginContext(2666, 16, false);
#line 59 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Areas\Administration\Views\Products\All.cshtml"
                   Write(product.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(2682, 174, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"col-md-3 d-flex justify-content-around\">\r\n                        <div class=\"mr-2\">\r\n                            ");
            EndContext();
            BeginContext(2856, 128, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ec74ff89897dd45cf34bd13d330d4e8f1dc589020426", async() => {
                BeginContext(2973, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 63 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Areas\Administration\Views\Products\All.cshtml"
                                                                                            WriteLiteral(product.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2984, 106, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"mr-2\">\r\n                            ");
            EndContext();
            BeginContext(3090, 133, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ec74ff89897dd45cf34bd13d330d4e8f1dc589023445", async() => {
                BeginContext(3188, 31, true);
                WriteLiteral("<i class=\"fas fa-cog\"></i> Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 66 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Areas\Administration\Views\Products\All.cshtml"
                                                   WriteLiteral(product.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3223, 34, true);
            WriteLiteral("\r\n                        </div>\r\n");
            EndContext();
#line 68 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Areas\Administration\Views\Products\All.cshtml"
                         if (product.Hide == false)
                        {

#line default
#line hidden
            BeginContext(3337, 80, true);
            WriteLiteral("                            <div class=\"mr-2\">\r\n                                ");
            EndContext();
            BeginContext(3417, 105, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ec74ff89897dd45cf34bd13d330d4e8f1dc589026386", async() => {
                BeginContext(3514, 4, true);
                WriteLiteral("Hide");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 71 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Areas\Administration\Views\Products\All.cshtml"
                                                       WriteLiteral(product.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3522, 38, true);
            WriteLiteral("\r\n                            </div>\r\n");
            EndContext();
#line 73 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Areas\Administration\Views\Products\All.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(3644, 80, true);
            WriteLiteral("                            <div class=\"mr-2\">\r\n                                ");
            EndContext();
            BeginContext(3724, 106, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ec74ff89897dd45cf34bd13d330d4e8f1dc589029309", async() => {
                BeginContext(3822, 4, true);
                WriteLiteral("Show");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 77 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Areas\Administration\Views\Products\All.cshtml"
                                                       WriteLiteral(product.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3830, 38, true);
            WriteLiteral("\r\n                            </div>\r\n");
            EndContext();
#line 79 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Areas\Administration\Views\Products\All.cshtml"
                        }

#line default
#line hidden
            BeginContext(3895, 72, true);
            WriteLiteral("                        <div class=\"mr-2\">\r\n                            ");
            EndContext();
            BeginContext(3967, 110, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ec74ff89897dd45cf34bd13d330d4e8f1dc589032167", async() => {
                BeginContext(4067, 6, true);
                WriteLiteral("Supply");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 81 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Areas\Administration\Views\Products\All.cshtml"
                                                     WriteLiteral(product.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4077, 84, true);
            WriteLiteral("\r\n                        </div>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 85 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Areas\Administration\Views\Products\All.cshtml"
            }

#line default
#line hidden
            BeginContext(4176, 94, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n    <div class=\"mt-3 d-flex justify-content-around\">\r\n        ");
            EndContext();
            BeginContext(4271, 760, false);
#line 89 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Areas\Administration\Views\Products\All.cshtml"
   Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("All",
                                                new
                                                     {
                                                    PageNumber = page
                                                }),
                                                new PagedListRenderOptions
                                                {
                                                    MaximumPageNumbersToDisplay = 5,
                                                    LiElementClasses = new string[] { "page-item" },
                                                    PageClasses = new string[] { "page-link" }
                                                }));

#line default
#line hidden
            EndContext();
            BeginContext(5031, 22, true);
            WriteLiteral("\r\n\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<Photoparallel.Data.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
