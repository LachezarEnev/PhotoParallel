#pragma checksum "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Shared\Components\ShoppingCartComponent\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4676ed5908829c6d6dae1f2c4630b9147c55fa56"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ShoppingCartComponent_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ShoppingCartComponent/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/ShoppingCartComponent/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_ShoppingCartComponent_Default))]
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
#line 1 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\_ViewImports.cshtml"
using Photoparallel.Web;

#line default
#line hidden
#line 2 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\_ViewImports.cshtml"
using Photoparallel.Web.ViewModels;

#line default
#line hidden
#line 3 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\_ViewImports.cshtml"
using Photoparallel.Web.Components;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4676ed5908829c6d6dae1f2c4630b9147c55fa56", @"/Views/Shared/Components/ShoppingCartComponent/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19f56853bc10335ee88806db5846472111bad1fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ShoppingCartComponent_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Photoparallel.Web.ViewModels.Orders.OpenOrderViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger px-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Orders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item nav-link text-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item nav-link text-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(63, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Shared\Components\ShoppingCartComponent\Default.cshtml"
  
    ViewData["Title"] = "Default";

#line default
#line hidden
            BeginContext(108, 181, true);
            WriteLiteral("<a class=\"\" dropdown-toggle\" href=\"\" id=\"navbarDropdown\" role=\"button\" data-toggle=\"dropdown\" aria-haspopup=\"true\" aria-expanded=\"false\">\r\n    <i class=\"fas fa-shopping-cart\"></i>\r\n");
            EndContext();
#line 8 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Shared\Components\ShoppingCartComponent\Default.cshtml"
     if (Model.Products.Count() != 0)
    {

#line default
#line hidden
            BeginContext(335, 38, true);
            WriteLiteral("        <sup class=\"font-weight-bold\">");
            EndContext();
            BeginContext(374, 22, false);
#line 10 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Shared\Components\ShoppingCartComponent\Default.cshtml"
                                 Write(Model.Products.Count());

#line default
#line hidden
            EndContext();
            BeginContext(396, 8, true);
            WriteLiteral("</sup>\r\n");
            EndContext();
#line 11 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Shared\Components\ShoppingCartComponent\Default.cshtml"
    }

#line default
#line hidden
            BeginContext(411, 112, true);
            WriteLiteral("    Shopping Cart\r\n</a>\r\n<div class=\"dropdown-menu dropdown-content bg-dark\" aria-labelledby=\"navbarDropdown\">\r\n");
            EndContext();
#line 15 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Shared\Components\ShoppingCartComponent\Default.cshtml"
     if (Model.Products.Count() == 0)
    {

#line default
#line hidden
            BeginContext(569, 150, true);
            WriteLiteral("        <div class=\"text-center\">\r\n            <p class=\"mb-0 py-3 font-weight-bold bg-white\">Your Shopping Cart is empty!</p>\r\n        </div>      \r\n");
            EndContext();
#line 20 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Shared\Components\ShoppingCartComponent\Default.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(743, 834, true);
            WriteLiteral(@"        <div class=""container mobile-fondsize-11 bg-white"">
            <table class=""table table-sm table-hover mb-0"">
                <thead>
                    <tr class=""row"">
                        <th scope=""col"" class=""col-2 d-flex justify-content-center"">Product</th>
                        <th scope=""col"" class=""col-3 d-flex justify-content-center""></th>
                        <th scope=""col"" class=""col-2 d-flex justify-content-center"">Price</th>
                        <th scope=""col"" class=""col-2 d-flex justify-content-center"">Quantity</th>
                        <th scope=""col"" class=""col-2 d-flex justify-content-center"">Total</th>
                        <th scope=""col"" class=""col-1 d-flex justify-content-center""></th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 36 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Shared\Components\ShoppingCartComponent\Default.cshtml"
                     foreach (var product in Model.Products)
                    {

#line default
#line hidden
            BeginContext(1662, 156, true);
            WriteLiteral("                        <tr class=\"row\">\r\n                            <td class=\"col-2 d-flex justify-content-center\">\r\n                                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1818, "\"", 1841, 1);
#line 40 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Shared\Components\ShoppingCartComponent\Default.cshtml"
WriteAttributeValue("", 1824, product.ImageUrl, 1824, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1842, 196, true);
            WriteLiteral(" width=\"50\" height=\"50\">\r\n                            </td>\r\n                            <td class=\"col-3 d-flex justify-content-center p-5\">\r\n                                <p class=\"text-dark\">");
            EndContext();
            BeginContext(2040, 29, false);
#line 43 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Shared\Components\ShoppingCartComponent\Default.cshtml"
                                                 Write(product.Name.Substring(0, 10));

#line default
#line hidden
            EndContext();
            BeginContext(2070, 158, true);
            WriteLiteral("...</p>\r\n                            </td>\r\n                            <td class=\"col-2 d-flex justify-content-center p-5\">\r\n                                ");
            EndContext();
            BeginContext(2229, 13, false);
#line 46 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Shared\Components\ShoppingCartComponent\Default.cshtml"
                           Write(product.Price);

#line default
#line hidden
            EndContext();
            BeginContext(2242, 155, true);
            WriteLiteral(" BGN\r\n                            </td>\r\n                            <td class=\"col-2 d-flex justify-content-center p-5\">\r\n                                ");
            EndContext();
            BeginContext(2398, 21, false);
#line 49 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Shared\Components\ShoppingCartComponent\Default.cshtml"
                           Write(product.OrderQuantity);

#line default
#line hidden
            EndContext();
            BeginContext(2419, 151, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td class=\"col-2 d-flex justify-content-center p-5\">\r\n                                ");
            EndContext();
            BeginContext(2571, 18, false);
#line 52 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Shared\Components\ShoppingCartComponent\Default.cshtml"
                           Write(product.TotalPrice);

#line default
#line hidden
            EndContext();
            BeginContext(2589, 151, true);
            WriteLiteral(" BGN\r\n                            </td>\r\n                            <td class=\"col-1 d-flex justify-content-center\">\r\n                                ");
            EndContext();
            BeginContext(2740, 149, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4676ed5908829c6d6dae1f2c4630b9147c55fa5613043", async() => {
                BeginContext(2858, 27, true);
                WriteLiteral("<i class=\"fa fa-trash\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 55 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Shared\Components\ShoppingCartComponent\Default.cshtml"
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
            BeginContext(2889, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 58 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Shared\Components\ShoppingCartComponent\Default.cshtml"
                    }

#line default
#line hidden
            BeginContext(2980, 157, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-4 pr-0 text-center\">\r\n                ");
            EndContext();
            BeginContext(3137, 120, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4676ed5908829c6d6dae1f2c4630b9147c55fa5616555", async() => {
                BeginContext(3236, 17, true);
                WriteLiteral("See Shopping Cart");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3257, 88, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-4 pr-0 text-center\">\r\n                ");
            EndContext();
            BeginContext(3345, 144, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4676ed5908829c6d6dae1f2c4630b9147c55fa5618523", async() => {
                BeginContext(3473, 12, true);
                WriteLiteral("Finish Order");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 67 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Shared\Components\ShoppingCartComponent\Default.cshtml"
                                                                             WriteLiteral(Model.Id);

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
            BeginContext(3489, 229, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-4 pl-0 pr-0 p-4 text-center\">\r\n                <p class=\"font-weight-bold text-white mb-0 pr-4\">Grand Total:</p>\r\n                <p class=\"font-weight-bold text-white mb-0 pr-4\">");
            EndContext();
            BeginContext(3720, 50, false);
#line 71 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Shared\Components\ShoppingCartComponent\Default.cshtml"
                                                             Write(Model.Products.Sum(x => x.Price * x.OrderQuantity));

#line default
#line hidden
            EndContext();
            BeginContext(3771, 46, true);
            WriteLiteral(" BGN</p>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 74 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Shared\Components\ShoppingCartComponent\Default.cshtml"
    }

#line default
#line hidden
            BeginContext(3824, 12, true);
            WriteLiteral("</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Photoparallel.Web.ViewModels.Orders.OpenOrderViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
