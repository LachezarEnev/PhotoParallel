#pragma checksum "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Areas\Administration\Views\Orders\Waiting.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da4000738e478c3e7d5636469b738b00d9a91a68"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Administration_Views_Orders_Waiting), @"mvc.1.0.view", @"/Areas/Administration/Views/Orders/Waiting.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Administration/Views/Orders/Waiting.cshtml", typeof(AspNetCore.Areas_Administration_Views_Orders_Waiting))]
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
#line 4 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Areas\Administration\Views\_ViewImports.cshtml"
using Photoparallel.Web.Components;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da4000738e478c3e7d5636469b738b00d9a91a68", @"/Areas/Administration/Views/Orders/Waiting.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fba7f6b1e4c2e1685eb266ffdc0c0ed0501e469", @"/Areas/Administration/Views/_ViewImports.cshtml")]
    public class Areas_Administration_Views_Orders_Waiting : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Photoparallel.Web.Areas.Administration.ViewModels.Home.AllOrdersViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Administration", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Orders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Approve", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(95, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Areas\Administration\Views\Orders\Waiting.cshtml"
  
    ViewData["Title"] = "Waiting";

#line default
#line hidden
            BeginContext(140, 896, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-xl-6"">
        <div class=""container mobile-fondsize-11 "">
            <div class=""h2 text-center text-info font-weight-bold"">Waiting Orders</div>
            <table class=""table"">
                <thead>
                    <tr class=""row"">
                        <th scope=""col"" class=""col-md-2 col d-flex justify-content-center"">№</th>
                        <th scope=""col"" class=""col-md-2 col d-flex justify-content-center"">Order Number</th>
                        <th scope=""col"" class=""col-md-2 col d-flex justify-content-center"">Creation Date</th>
                        <th scope=""col"" class=""col-md-2 col d-flex justify-content-center"">Status</th>
                        <th scope=""col"" class=""col-md-4 col d-flex justify-content-center"">Actions</th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 22 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Areas\Administration\Views\Orders\Waiting.cshtml"
                      
                        var orders = Model.ToArray();
                    

#line default
#line hidden
            BeginContext(1138, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 25 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Areas\Administration\Views\Orders\Waiting.cshtml"
                     for (int i = 0; i < orders.Length; i++)
                    {
                        var order = orders[i];


#line default
#line hidden
            BeginContext(1273, 159, true);
            WriteLiteral("                        <tr class=\"row\">\r\n                            <td class=\"col-md-2 col d-flex justify-content-center\">\r\n                                ");
            EndContext();
            BeginContext(1434, 5, false);
#line 31 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Areas\Administration\Views\Orders\Waiting.cshtml"
                            Write(i + 1);

#line default
#line hidden
            EndContext();
            BeginContext(1440, 154, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td class=\"col-md-2 col d-flex justify-content-center\">\r\n                                ");
            EndContext();
            BeginContext(1595, 8, false);
#line 34 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Areas\Administration\Views\Orders\Waiting.cshtml"
                           Write(order.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1603, 154, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td class=\"col-md-2 col d-flex justify-content-center\">\r\n                                ");
            EndContext();
            BeginContext(1758, 15, false);
#line 37 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Areas\Administration\Views\Orders\Waiting.cshtml"
                           Write(order.CreatedOn);

#line default
#line hidden
            EndContext();
            BeginContext(1773, 154, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td class=\"col-md-2 col d-flex justify-content-center\">\r\n                                ");
            EndContext();
            BeginContext(1928, 17, false);
#line 40 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Areas\Administration\Views\Orders\Waiting.cshtml"
                           Write(order.OrderStatus);

#line default
#line hidden
            EndContext();
            BeginContext(1945, 210, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td class=\"col-md-4 col d-flex justify-content-around\">\r\n                                <div class=\"mr-2\">\r\n                                    ");
            EndContext();
            BeginContext(2155, 138, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da4000738e478c3e7d5636469b738b00d9a91a6810233", async() => {
                BeginContext(2282, 7, true);
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
#line 44 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Areas\Administration\Views\Orders\Waiting.cshtml"
                                                                                                                WriteLiteral(order.Id);

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
            BeginContext(2293, 130, true);
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"mr-2\">\r\n                                    ");
            EndContext();
            BeginContext(2423, 141, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da4000738e478c3e7d5636469b738b00d9a91a6813296", async() => {
                BeginContext(2553, 7, true);
                WriteLiteral("Approve");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 47 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Areas\Administration\Views\Orders\Waiting.cshtml"
                                                                                                                WriteLiteral(order.Id);

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
            BeginContext(2564, 108, true);
            WriteLiteral("\r\n                                </div>\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 51 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Areas\Administration\Views\Orders\Waiting.cshtml"
                    }

#line default
#line hidden
            BeginContext(2695, 48, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n");
            EndContext();
#line 54 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Areas\Administration\Views\Orders\Waiting.cshtml"
             if (orders.Count() == 0)
            {

#line default
#line hidden
            BeginContext(2797, 87, true);
            WriteLiteral("                <h3 class=\"text-center text-danger\">There are no Waiting Orders!</h3>\r\n");
            EndContext();
#line 57 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Areas\Administration\Views\Orders\Waiting.cshtml"
            }

#line default
#line hidden
            BeginContext(2899, 36, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Photoparallel.Web.Areas.Administration.ViewModels.Home.AllOrdersViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
