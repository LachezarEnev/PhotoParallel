#pragma checksum "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Shared\Components\RentCartComponent\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c6f1ac332f405dd2417e8d36fedd2ffead41fcc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_RentCartComponent_Default), @"mvc.1.0.view", @"/Views/Shared/Components/RentCartComponent/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/RentCartComponent/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_RentCartComponent_Default))]
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
#line 2 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Shared\Components\RentCartComponent\Default.cshtml"
using Photoparallel.Common;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c6f1ac332f405dd2417e8d36fedd2ffead41fcc", @"/Views/Shared/Components/RentCartComponent/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69cd7a0e2099e547b87af83f987e9f2a0389f2d4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_RentCartComponent_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Photoparallel.Web.ViewModels.Rents.OpenRentViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger px-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Rents", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Open", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item nav-link text-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Rent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(90, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Shared\Components\RentCartComponent\Default.cshtml"
  
    ViewData["Title"] = "Default";

#line default
#line hidden
            BeginContext(135, 139, true);
            WriteLiteral("<a class=\"\" dropdown-toggle\" href=\"\" id=\"navbarDropdown\" role=\"button\" data-toggle=\"dropdown\" aria-haspopup=\"true\" aria-expanded=\"false\">\r\n");
            EndContext();
#line 8 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Shared\Components\RentCartComponent\Default.cshtml"
     if (Model != null)
    {

#line default
#line hidden
            BeginContext(306, 46, true);
            WriteLiteral("        <i class=\"fas fa-shopping-cart\"></i>\r\n");
            EndContext();
#line 11 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Shared\Components\RentCartComponent\Default.cshtml"
        if (Model.Products.Count() != 0)
        {

#line default
#line hidden
            BeginContext(405, 42, true);
            WriteLiteral("            <sup class=\"font-weight-bold\">");
            EndContext();
            BeginContext(448, 22, false);
#line 13 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Shared\Components\RentCartComponent\Default.cshtml"
                                     Write(Model.Products.Count());

#line default
#line hidden
            EndContext();
            BeginContext(470, 8, true);
            WriteLiteral("</sup>\r\n");
            EndContext();
#line 14 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Shared\Components\RentCartComponent\Default.cshtml"
        }
    }

#line default
#line hidden
            BeginContext(496, 108, true);
            WriteLiteral("    Rent Cart\r\n</a>\r\n<div class=\"dropdown-menu dropdown-content bg-dark\" aria-labelledby=\"navbarDropdown\">\r\n");
            EndContext();
#line 19 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Shared\Components\RentCartComponent\Default.cshtml"
     if (Model == null)
    {

#line default
#line hidden
            BeginContext(636, 140, true);
            WriteLiteral("        <div class=\"text-center\">\r\n            <p class=\"mb-0 py-3 font-weight-bold bg-white\">Your Rent Cart is empty!</p>\r\n        </div>\r\n");
            EndContext();
#line 24 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Shared\Components\RentCartComponent\Default.cshtml"
    }
    else
    {
        if (Model.Products.Count() == 0)
        {

#line default
#line hidden
            BeginContext(853, 152, true);
            WriteLiteral("            <div class=\"text-center\">\r\n                <p class=\"mb-0 py-3 font-weight-bold bg-white\">Your Rent Cart is empty!</p>\r\n            </div>\r\n");
            EndContext();
#line 32 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Shared\Components\RentCartComponent\Default.cshtml"
        }
        else
        {         

#line default
#line hidden
            BeginContext(1050, 898, true);
            WriteLiteral(@"            <div class=""container mobile-fondsize-11 bg-white"">
                <table class=""table table-sm table-hover mb-0"">
                    <thead>
                        <tr class=""row"">
                            <th scope=""col"" class=""col-2 d-flex justify-content-center"">Product</th>
                            <th scope=""col"" class=""col-3 d-flex justify-content-center""></th>
                            <th scope=""col"" class=""col-2 d-flex justify-content-center"">Price per day</th>
                            <th scope=""col"" class=""col-2 d-flex justify-content-center"">Quantity</th>
                            <th scope=""col"" class=""col-2 d-flex justify-content-center"">Guarantee</th>
                            <th scope=""col"" class=""col-1 d-flex justify-content-center""></th>
                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 48 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Shared\Components\RentCartComponent\Default.cshtml"
                         foreach (var product in Model.Products)
                        {

#line default
#line hidden
            BeginContext(2041, 168, true);
            WriteLiteral("                            <tr class=\"row\">\r\n                                <td class=\"col-2 d-flex justify-content-center\">\r\n                                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2209, "\"", 2232, 1);
#line 52 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Shared\Components\RentCartComponent\Default.cshtml"
WriteAttributeValue("", 2215, product.ImageUrl, 2215, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2233, 151, true);
            WriteLiteral(" width=\"50\" height=\"50\">\r\n                                </td>\r\n                                <td class=\"col-3 d-flex justify-content-center p-5\">\r\n");
            EndContext();
#line 55 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Shared\Components\RentCartComponent\Default.cshtml"
                                     if (product.Name.Length <= 10)
                                    {

#line default
#line hidden
            BeginContext(2492, 61, true);
            WriteLiteral("                                        <p class=\"text-dark\">");
            EndContext();
            BeginContext(2554, 12, false);
#line 57 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Shared\Components\RentCartComponent\Default.cshtml"
                                                        Write(product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2566, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 58 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Shared\Components\RentCartComponent\Default.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(2692, 61, true);
            WriteLiteral("                                        <p class=\"text-dark\">");
            EndContext();
            BeginContext(2755, 29, false);
#line 61 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Shared\Components\RentCartComponent\Default.cshtml"
                                                         Write(product.Name.Substring(0, 10));

#line default
#line hidden
            EndContext();
            BeginContext(2785, 9, true);
            WriteLiteral("...</p>\r\n");
            EndContext();
#line 62 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Shared\Components\RentCartComponent\Default.cshtml"
                                    }

#line default
#line hidden
            BeginContext(2833, 123, true);
            WriteLiteral("                                </td>\r\n                                <td class=\"col-2 d-flex justify-content-center p-5\">");
            EndContext();
            BeginContext(2957, 19, false);
#line 64 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Shared\Components\RentCartComponent\Default.cshtml"
                                                                               Write(product.PricePerDay);

#line default
#line hidden
            EndContext();
            BeginContext(2976, 91, true);
            WriteLiteral("</td>\r\n                                <td class=\"col-2 d-flex justify-content-center p-5\">");
            EndContext();
            BeginContext(3068, 20, false);
#line 65 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Shared\Components\RentCartComponent\Default.cshtml"
                                                                               Write(product.RentQuantity);

#line default
#line hidden
            EndContext();
            BeginContext(3088, 91, true);
            WriteLiteral("</td>\r\n                                <td class=\"col-2 d-flex justify-content-center p-5\">");
            EndContext();
            BeginContext(3181, 75, false);
#line 66 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Shared\Components\RentCartComponent\Default.cshtml"
                                                                                Write(Math.Round(product.Price * GlobalConstants.GuaranteePercent).ToString("F2"));

#line default
#line hidden
            EndContext();
            BeginContext(3257, 128, true);
            WriteLiteral(" lv</td>\r\n                                <td class=\"col-1 d-flex justify-content-center\">\r\n                                    ");
            EndContext();
            BeginContext(3385, 148, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c6f1ac332f405dd2417e8d36fedd2ffead41fcc15662", async() => {
                BeginContext(3502, 27, true);
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
#line 68 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Shared\Components\RentCartComponent\Default.cshtml"
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
            BeginContext(3533, 76, true);
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 71 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Shared\Components\RentCartComponent\Default.cshtml"
                        }

#line default
#line hidden
            BeginContext(3636, 181, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-4 pr-0 text-center\">\r\n                    ");
            EndContext();
            BeginContext(3817, 114, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c6f1ac332f405dd2417e8d36fedd2ffead41fcc19205", async() => {
                BeginContext(3914, 13, true);
                WriteLiteral("See Rent Cart");
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
            BeginContext(3931, 100, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-4 pr-0 text-center\">\r\n                    ");
            EndContext();
            BeginContext(4031, 116, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c6f1ac332f405dd2417e8d36fedd2ffead41fcc21182", async() => {
                BeginContext(4131, 12, true);
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4147, 46, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 83 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Shared\Components\RentCartComponent\Default.cshtml"
        }
    }

#line default
#line hidden
            BeginContext(4211, 12, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Photoparallel.Web.ViewModels.Rents.OpenRentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591