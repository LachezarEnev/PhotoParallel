#pragma checksum "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Orders\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9ed84a7d351c929056baaf263c0ba08c5391094"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Details), @"mvc.1.0.view", @"/Views/Orders/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Orders/Details.cshtml", typeof(AspNetCore.Views_Orders_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9ed84a7d351c929056baaf263c0ba08c5391094", @"/Views/Orders/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19f56853bc10335ee88806db5846472111bad1fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Photoparallel.Web.Areas.Administration.ViewModels.Orders.OrderDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Invoices", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(87, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Orders\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(132, 313, true);
            WriteLiteral(@"
<div class=""h2 text-center text-info font-weight-bold"">Order Details</div>
<hr class=""w-50"" />
<div class=""col-md-6"">
    <div class=""h4 font-weight-bold text-center text-info"">Order Details:</div>
    <div class=""card card-body bg-transparent"">
        <div><span class=""font-weight-bold"">Order №:</span> ");
            EndContext();
            BeginContext(446, 8, false);
#line 12 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Orders\Details.cshtml"
                                                       Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(454, 71, true);
            WriteLiteral("</div>\r\n        <div><span class=\"font-weight-bold\">Created On:</span> ");
            EndContext();
            BeginContext(526, 15, false);
#line 13 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Orders\Details.cshtml"
                                                          Write(Model.CreatedOn);

#line default
#line hidden
            EndContext();
            BeginContext(541, 73, true);
            WriteLiteral("</div>\r\n        <div><span class=\"font-weight-bold\">Order Status:</span> ");
            EndContext();
            BeginContext(615, 17, false);
#line 14 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Orders\Details.cshtml"
                                                            Write(Model.OrderStatus);

#line default
#line hidden
            EndContext();
            BeginContext(632, 75, true);
            WriteLiteral("</div>\r\n        <div><span class=\"font-weight-bold\">Payment Status:</span> ");
            EndContext();
            BeginContext(708, 19, false);
#line 15 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Orders\Details.cshtml"
                                                              Write(Model.PaymentStatus);

#line default
#line hidden
            EndContext();
            BeginContext(727, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 16 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Orders\Details.cshtml"
         if (Model.OrderStatus == "Delivered")
        {

#line default
#line hidden
            BeginContext(794, 69, true);
            WriteLiteral("            <div><span class=\"font-weight-bold\">Delivered On:</span> ");
            EndContext();
            BeginContext(864, 27, false);
#line 18 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Orders\Details.cshtml"
                                                                Write(Model.EstimatedDeliveryDate);

#line default
#line hidden
            EndContext();
            BeginContext(891, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 19 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Orders\Details.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(935, 80, true);
            WriteLiteral("            <div><span class=\"font-weight-bold\">Estimated Delivery Date:</span> ");
            EndContext();
            BeginContext(1016, 27, false);
#line 22 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Orders\Details.cshtml"
                                                                           Write(Model.EstimatedDeliveryDate);

#line default
#line hidden
            EndContext();
            BeginContext(1043, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 23 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Orders\Details.cshtml"
        }

#line default
#line hidden
            BeginContext(1062, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 24 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Orders\Details.cshtml"
         if (Model.Invoice != "N/A")
        {

#line default
#line hidden
            BeginContext(1111, 101, true);
            WriteLiteral("            <div>\r\n                <span class=\"font-weight-bold\">Invoice №:</span>\r\n                ");
            EndContext();
            BeginContext(1212, 159, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9ed84a7d351c929056baaf263c0ba08c53910948989", async() => {
                BeginContext(1306, 25, true);
                WriteLiteral("\r\n                    <u>");
                EndContext();
                BeginContext(1332, 13, false);
#line 29 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Orders\Details.cshtml"
                  Write(Model.Invoice);

#line default
#line hidden
                EndContext();
                BeginContext(1345, 22, true);
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
#line 28 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Orders\Details.cshtml"
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
            BeginContext(1371, 22, true);
            WriteLiteral("\r\n            </div>\r\n");
            EndContext();
#line 32 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Orders\Details.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(1429, 66, true);
            WriteLiteral("            <div><span class=\"font-weight-bold\">Invoice №:</span> ");
            EndContext();
            BeginContext(1496, 13, false);
#line 35 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Orders\Details.cshtml"
                                                             Write(Model.Invoice);

#line default
#line hidden
            EndContext();
            BeginContext(1509, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 36 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Orders\Details.cshtml"
        }

#line default
#line hidden
            BeginContext(1528, 65, true);
            WriteLiteral("        <div><span class=\"font-weight-bold\">All Products:</span> ");
            EndContext();
            BeginContext(1594, 16, false);
#line 37 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Orders\Details.cshtml"
                                                            Write(Model.TotalPrice);

#line default
#line hidden
            EndContext();
            BeginContext(1610, 73, true);
            WriteLiteral(" lv.</div>\r\n        <div><span class=\"font-weight-bold\">Shipping:</span> ");
            EndContext();
            BeginContext(1684, 14, false);
#line 38 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Orders\Details.cshtml"
                                                        Write(Model.Shipping);

#line default
#line hidden
            EndContext();
            BeginContext(1698, 103, true);
            WriteLiteral(" lv.</div>\r\n        <hr />\r\n        <div class=\"h4\"><span class=\"font-weight-bold\">Grand Total:</span> ");
            EndContext();
            BeginContext(1802, 16, false);
#line 40 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Orders\Details.cshtml"
                                                                      Write(Model.GrandTotal);

#line default
#line hidden
            EndContext();
            BeginContext(1818, 248, true);
            WriteLiteral(" lv.</div>\r\n    </div>\r\n</div>\r\n<div class=\"col-md-6\">\r\n    <div class=\"h4 font-weight-bold text-center text-info\">Recipent Data:</div>\r\n    <div class=\"card card-body bg-transparent\">\r\n        <div><span class=\"font-weight-bold\">Recipient:</span> ");
            EndContext();
            BeginContext(2067, 15, false);
#line 46 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Orders\Details.cshtml"
                                                         Write(Model.Recipient);

#line default
#line hidden
            EndContext();
            BeginContext(2082, 89, true);
            WriteLiteral("</div>\r\n        <hr />\r\n        <div><span class=\"font-weight-bold\">Phone Number:</span> ");
            EndContext();
            BeginContext(2172, 26, false);
#line 48 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Orders\Details.cshtml"
                                                            Write(Model.RecipientPhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(2198, 84, true);
            WriteLiteral("</div>\r\n        <hr />\r\n        <div><span class=\"font-weight-bold\">Address:</span> ");
            EndContext();
            BeginContext(2283, 21, false);
#line 50 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Orders\Details.cshtml"
                                                       Write(Model.ShippingAddress);

#line default
#line hidden
            EndContext();
            BeginContext(2304, 715, true);
            WriteLiteral(@"</div>
    </div>
</div>
<table class=""table"">
    <thead>
        <tr class=""row d-flex justify-content-around"">
            <th scope=""col"" class=""col-md-2 col d-flex justify-content-center""></th>
            <th scope=""col"" class=""col-md-1 col d-flex justify-content-center"">Product №</th>
            <th scope=""col"" class=""col-md-6 col d-flex justify-content-center"">Name</th>
            <th scope=""col"" class=""col-md-1 col d-flex justify-content-center"">Quantity</th>
            <th scope=""col"" class=""col-md-1 col d-flex justify-content-center"">Price</th>
            <th scope=""col"" class=""col-md-1 col d-flex justify-content-center"">Total Price</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 65 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Orders\Details.cshtml"
         foreach (var product in Model.OrderProductsViewModel)
        {

#line default
#line hidden
            BeginContext(3094, 157, true);
            WriteLiteral("            <tr class=\"row d-flex justify-content-around\">\r\n                <td class=\"col-md-2 col d-flex justify-content-center\">\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3251, "\"", 3274, 1);
#line 69 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Orders\Details.cshtml"
WriteAttributeValue("", 3257, product.ImageUrl, 3257, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3275, 142, true);
            WriteLiteral(" width=\"50\" height=\"50\">\r\n                </td>\r\n                <td class=\"col-md-1 col d-flex justify-content-center\">\r\n                    ");
            EndContext();
            BeginContext(3418, 17, false);
#line 72 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Orders\Details.cshtml"
               Write(product.ProductId);

#line default
#line hidden
            EndContext();
            BeginContext(3435, 118, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"col-md-6 col d-flex justify-content-center\">\r\n                    ");
            EndContext();
            BeginContext(3554, 19, false);
#line 75 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Orders\Details.cshtml"
               Write(product.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(3573, 118, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"col-md-1 col d-flex justify-content-center\">\r\n                    ");
            EndContext();
            BeginContext(3692, 13, false);
#line 78 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Orders\Details.cshtml"
               Write(product.Price);

#line default
#line hidden
            EndContext();
            BeginContext(3705, 122, true);
            WriteLiteral(" lv.\r\n                </td>\r\n                <td class=\"col-md-1 col d-flex justify-content-center\">\r\n                    ");
            EndContext();
            BeginContext(3828, 16, false);
#line 81 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Orders\Details.cshtml"
               Write(product.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(3844, 118, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"col-md-1 col d-flex justify-content-center\">\r\n                    ");
            EndContext();
            BeginContext(3964, 32, false);
#line 84 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Orders\Details.cshtml"
                Write(product.Price * product.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(3997, 48, true);
            WriteLiteral(" lv.\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 87 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Orders\Details.cshtml"
        }

#line default
#line hidden
            BeginContext(4056, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Photoparallel.Web.Areas.Administration.ViewModels.Orders.OrderDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
