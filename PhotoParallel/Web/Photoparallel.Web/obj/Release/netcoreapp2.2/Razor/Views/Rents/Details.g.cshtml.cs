#pragma checksum "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Rents\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0e7cf8e75fbef0aceeba7fdc9ba698bc3a2eb4e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rents_Details), @"mvc.1.0.view", @"/Views/Rents/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Rents/Details.cshtml", typeof(AspNetCore.Views_Rents_Details))]
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
#line 4 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\_ViewImports.cshtml"
using Photoparallel.Common;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0e7cf8e75fbef0aceeba7fdc9ba698bc3a2eb4e", @"/Views/Rents/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69cd7a0e2099e547b87af83f987e9f2a0389f2d4", @"/Views/_ViewImports.cshtml")]
    public class Views_Rents_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Photoparallel.Web.Areas.Administration.ViewModels.Rents.RentDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Invoices", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RentDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(85, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Rents\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(130, 341, true);
            WriteLiteral(@"
<div class=""h2 text-center text-info font-weight-bold"">Rental Order Details</div>
<hr class=""w-50"" />
<div class=""col-md-6"">
    <div class=""h4 font-weight-bold text-center text-info"">Rental Order Details:</div>
    <div class=""card card-body bg-transparent shadow"">
        <div><span class=""font-weight-bold"">Rental Order №:</span> ");
            EndContext();
            BeginContext(472, 8, false);
#line 12 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Rents\Details.cshtml"
                                                              Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(480, 72, true);
            WriteLiteral("</div>\r\n        <div><span class=\"font-weight-bold\">Rent Status:</span> ");
            EndContext();
            BeginContext(553, 17, false);
#line 13 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Rents\Details.cshtml"
                                                           Write(Model.RentsStatus);

#line default
#line hidden
            EndContext();
            BeginContext(570, 72, true);
            WriteLiteral("</div>\r\n        <div><span class=\"font-weight-bold\">Rental Days:</span> ");
            EndContext();
            BeginContext(643, 37, false);
#line 14 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Rents\Details.cshtml"
                                                           Write(Model.RentDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(680, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(684, 51, false);
#line 14 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Rents\Details.cshtml"
                                                                                                    Write(Model.ReturnDate.AddDays(-1).ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(735, 72, true);
            WriteLiteral("</div>\r\n        <div><span class=\"font-weight-bold\">Return Date:</span> ");
            EndContext();
            BeginContext(808, 39, false);
#line 15 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Rents\Details.cshtml"
                                                           Write(Model.ReturnDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(847, 75, true);
            WriteLiteral("</div>\r\n        <div><span class=\"font-weight-bold\">Payment Status:</span> ");
            EndContext();
            BeginContext(923, 19, false);
#line 16 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Rents\Details.cshtml"
                                                              Write(Model.PaymentStatus);

#line default
#line hidden
            EndContext();
            BeginContext(942, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 17 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Rents\Details.cshtml"
         if (Model.Invoice != "N/A")
        {

#line default
#line hidden
            BeginContext(999, 101, true);
            WriteLiteral("            <div>\r\n                <span class=\"font-weight-bold\">Invoice №:</span>\r\n                ");
            EndContext();
            BeginContext(1100, 163, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0e7cf8e75fbef0aceeba7fdc9ba698bc3a2eb4e8335", async() => {
                BeginContext(1198, 25, true);
                WriteLiteral("\r\n                    <u>");
                EndContext();
                BeginContext(1224, 13, false);
#line 22 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Rents\Details.cshtml"
                  Write(Model.Invoice);

#line default
#line hidden
                EndContext();
                BeginContext(1237, 22, true);
                WriteLiteral("</u>\r\n                ");
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
#line 21 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Rents\Details.cshtml"
                                                                                    WriteLiteral(Model.InvoiceId);

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
            BeginContext(1263, 22, true);
            WriteLiteral("\r\n            </div>\r\n");
            EndContext();
#line 25 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Rents\Details.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(1321, 66, true);
            WriteLiteral("            <div><span class=\"font-weight-bold\">Invoice №:</span> ");
            EndContext();
            BeginContext(1388, 13, false);
#line 28 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Rents\Details.cshtml"
                                                             Write(Model.Invoice);

#line default
#line hidden
            EndContext();
            BeginContext(1401, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 29 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Rents\Details.cshtml"
        }

#line default
#line hidden
            BeginContext(1420, 66, true);
            WriteLiteral("        <div><span class=\"font-weight-bold\">Rental Amount:</span> ");
            EndContext();
            BeginContext(1487, 16, false);
#line 30 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Rents\Details.cshtml"
                                                             Write(Model.TotalPrice);

#line default
#line hidden
            EndContext();
            BeginContext(1503, 12, true);
            WriteLiteral(" BGN</div>\r\n");
            EndContext();
#line 31 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Rents\Details.cshtml"
         if (Model.RentsStatus != "Returned")
        {

#line default
#line hidden
            BeginContext(1573, 66, true);
            WriteLiteral("            <div><span class=\"font-weight-bold\">Guarantee:</span> ");
            EndContext();
            BeginContext(1640, 15, false);
#line 33 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Rents\Details.cshtml"
                                                             Write(Model.Guarantee);

#line default
#line hidden
            EndContext();
            BeginContext(1655, 111, true);
            WriteLiteral(" BGN</div>\r\n            <hr />\r\n            <div class=\"h4\"><span class=\"font-weight-bold\">Grand Total:</span> ");
            EndContext();
            BeginContext(1768, 34, false);
#line 35 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Rents\Details.cshtml"
                                                                           Write(Model.TotalPrice + Model.Guarantee);

#line default
#line hidden
            EndContext();
            BeginContext(1803, 12, true);
            WriteLiteral(" BGN</div>\r\n");
            EndContext();
#line 36 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Rents\Details.cshtml"
        }
        else
        {
            if (Model.Penalty > 0)
            {

#line default
#line hidden
            BeginContext(1902, 68, true);
            WriteLiteral("                <div><span class=\"font-weight-bold\">Penalty:</span> ");
            EndContext();
            BeginContext(1971, 13, false);
#line 41 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Rents\Details.cshtml"
                                                               Write(Model.Penalty);

#line default
#line hidden
            EndContext();
            BeginContext(1984, 12, true);
            WriteLiteral(" BGN</div>\r\n");
            EndContext();
#line 42 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Rents\Details.cshtml"
            }

#line default
#line hidden
            BeginContext(2011, 73, true);
            WriteLiteral("            <div><span class=\"font-weight-bold\">Returned on time:</span> ");
            EndContext();
            BeginContext(2085, 20, false);
#line 43 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Rents\Details.cshtml"
                                                                    Write(Model.ReturnedOnTime);

#line default
#line hidden
            EndContext();
            BeginContext(2105, 107, true);
            WriteLiteral("</div>\r\n            <hr />\r\n            <div class=\"h4\"><span class=\"font-weight-bold\">Grand Total:</span> ");
            EndContext();
            BeginContext(2214, 32, false);
#line 45 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Rents\Details.cshtml"
                                                                           Write(Model.TotalPrice + Model.Penalty);

#line default
#line hidden
            EndContext();
            BeginContext(2247, 12, true);
            WriteLiteral(" BGN</div>\r\n");
            EndContext();
#line 46 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Rents\Details.cshtml"
        }

#line default
#line hidden
            BeginContext(2270, 243, true);
            WriteLiteral("    </div>\r\n</div>\r\n<div class=\"col-md-6\">\r\n    <div class=\"h4 font-weight-bold text-center text-info\">Recipent Data:</div>\r\n    <div class=\"card card-body bg-transparent shadow\">\r\n        <div><span class=\"font-weight-bold\">Recipient:</span> ");
            EndContext();
            BeginContext(2514, 15, false);
#line 52 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Rents\Details.cshtml"
                                                         Write(Model.Recipient);

#line default
#line hidden
            EndContext();
            BeginContext(2529, 89, true);
            WriteLiteral("</div>\r\n        <hr />\r\n        <div><span class=\"font-weight-bold\">Phone Number:</span> ");
            EndContext();
            BeginContext(2619, 26, false);
#line 54 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Rents\Details.cshtml"
                                                            Write(Model.RecipientPhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(2645, 84, true);
            WriteLiteral("</div>\r\n        <hr />\r\n        <div><span class=\"font-weight-bold\">Address:</span> ");
            EndContext();
            BeginContext(2730, 21, false);
#line 56 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Rents\Details.cshtml"
                                                       Write(Model.ShippingAddress);

#line default
#line hidden
            EndContext();
            BeginContext(2751, 719, true);
            WriteLiteral(@"</div>
    </div>
</div>
<table class=""table"">
    <thead>
        <tr class=""row d-flex justify-content-around"">
            <th scope=""col"" class=""col-md-2 col d-flex justify-content-center""></th>
            <th scope=""col"" class=""col-md-1 col d-flex justify-content-center"">Product №</th>
            <th scope=""col"" class=""col-md-5 col d-flex justify-content-center"">Name</th>
            <th scope=""col"" class=""col-md-2 col d-flex justify-content-center"">Price per day</th>
            <th scope=""col"" class=""col-md-1 col d-flex justify-content-center"">Days</th>
            <th scope=""col"" class=""col-md-1 col d-flex justify-content-center"">Total Price</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 71 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Rents\Details.cshtml"
         foreach (var rent in Model.RentProductsViewModel)
        {

#line default
#line hidden
            BeginContext(3541, 157, true);
            WriteLiteral("            <tr class=\"row d-flex justify-content-around\">\r\n                <td class=\"col-md-2 col d-flex justify-content-center\">\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3698, "\"", 3718, 1);
#line 75 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Rents\Details.cshtml"
WriteAttributeValue("", 3704, rent.ImageUrl, 3704, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3719, 142, true);
            WriteLiteral(" width=\"50\" height=\"50\">\r\n                </td>\r\n                <td class=\"col-md-1 col d-flex justify-content-center\">\r\n                    ");
            EndContext();
            BeginContext(3862, 14, false);
#line 78 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Rents\Details.cshtml"
               Write(rent.ProductId);

#line default
#line hidden
            EndContext();
            BeginContext(3876, 118, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"col-md-5 col d-flex justify-content-center\">\r\n                    ");
            EndContext();
            BeginContext(3995, 16, false);
#line 81 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Rents\Details.cshtml"
               Write(rent.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(4011, 118, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"col-md-2 col d-flex justify-content-center\">\r\n                    ");
            EndContext();
            BeginContext(4130, 16, false);
#line 84 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Rents\Details.cshtml"
               Write(rent.PricePerDay);

#line default
#line hidden
            EndContext();
            BeginContext(4146, 122, true);
            WriteLiteral(" BGN\r\n                </td>\r\n                <td class=\"col-md-1 col d-flex justify-content-center\">\r\n                    ");
            EndContext();
            BeginContext(4269, 10, false);
#line 87 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Rents\Details.cshtml"
               Write(Model.Days);

#line default
#line hidden
            EndContext();
            BeginContext(4279, 118, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"col-md-1 col d-flex justify-content-center\">\r\n                    ");
            EndContext();
            BeginContext(4399, 29, false);
#line 90 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Rents\Details.cshtml"
                Write(rent.PricePerDay * Model.Days);

#line default
#line hidden
            EndContext();
            BeginContext(4429, 48, true);
            WriteLiteral(" BGN\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 93 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Rents\Details.cshtml"
        }

#line default
#line hidden
            BeginContext(4488, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Photoparallel.Web.Areas.Administration.ViewModels.Rents.RentDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591