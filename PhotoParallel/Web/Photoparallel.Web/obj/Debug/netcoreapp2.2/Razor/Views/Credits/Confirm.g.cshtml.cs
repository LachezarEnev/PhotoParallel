#pragma checksum "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Credits\Confirm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d2d154afaf23f54cba9fb9a34f640518be93433"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Credits_Confirm), @"mvc.1.0.view", @"/Views/Credits/Confirm.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Credits/Confirm.cshtml", typeof(AspNetCore.Views_Credits_Confirm))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d2d154afaf23f54cba9fb9a34f640518be93433", @"/Views/Credits/Confirm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19f56853bc10335ee88806db5846472111bad1fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Credits_Confirm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Photoparallel.Web.ViewModels.Credits.ConfirmCreditViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Credits", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-direct", "true", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("myButton-orange btn-lg btn-block text-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Finish", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("myButton-olive btn-lg btn-block text-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(68, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Credits\Confirm.cshtml"
  
    ViewData["Title"] = "Confirm";

#line default
#line hidden
            BeginContext(113, 425, true);
            WriteLiteral(@"
<div class=""progress pt-1"">
    <div class=""progress-bar"" role=""progressbar"" style=""width: 100%;"" aria-valuenow=""100"" aria-valuemin=""0"" aria-valuemax=""100"">100%</div>
</div>

<div class=""row"">
    <div class=""col-md-6"">
        <div class=""h4 font-weight-bold text-center text-info"">Recipent Data:</div>
        <div class=""card card-body bg-info"">
            <div><span class=""font-weight-bold"">Recipient:</span> ");
            EndContext();
            BeginContext(539, 21, false);
#line 15 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Credits\Confirm.cshtml"
                                                             Write(Model.Order.Recipient);

#line default
#line hidden
            EndContext();
            BeginContext(560, 77, true);
            WriteLiteral("</div>\r\n            <div><span class=\"font-weight-bold\">Phone Number:</span> ");
            EndContext();
            BeginContext(638, 32, false);
#line 16 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Credits\Confirm.cshtml"
                                                                Write(Model.Order.RecipientPhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(670, 72, true);
            WriteLiteral("</div>\r\n            <div><span class=\"font-weight-bold\">Address:</span> ");
            EndContext();
            BeginContext(743, 13, false);
#line 17 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Credits\Confirm.cshtml"
                                                           Write(Model.Address);

#line default
#line hidden
            EndContext();
            BeginContext(756, 74, true);
            WriteLiteral("</div>\r\n            <div><span class=\"font-weight-bold\">Id Number:</span> ");
            EndContext();
            BeginContext(831, 14, false);
#line 18 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Credits\Confirm.cshtml"
                                                             Write(Model.IdNumber);

#line default
#line hidden
            EndContext();
            BeginContext(845, 68, true);
            WriteLiteral("</div>\r\n            <div><span class=\"font-weight-bold\">UCN:</span> ");
            EndContext();
            BeginContext(914, 9, false);
#line 19 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Credits\Confirm.cshtml"
                                                       Write(Model.Ucn);

#line default
#line hidden
            EndContext();
            BeginContext(923, 72, true);
            WriteLiteral("</div>\r\n            <div><span class=\"font-weight-bold\">Address:</span> ");
            EndContext();
            BeginContext(996, 13, false);
#line 20 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Credits\Confirm.cshtml"
                                                           Write(Model.Address);

#line default
#line hidden
            EndContext();
            BeginContext(1009, 225, true);
            WriteLiteral("</div>\r\n        </div>\r\n        <div class=\"h4 font-weight-bold text-center text-info\">Credit Terms:</div>\r\n        <div class=\"card card-body bg-info\">\r\n            <div><span class=\"font-weight-bold\">Credit Company:</span> ");
            EndContext();
            BeginContext(1235, 24, false);
#line 24 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Credits\Confirm.cshtml"
                                                                  Write(Model.CreditCompany.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1259, 80, true);
            WriteLiteral("</div>\r\n            <div><span class=\"font-weight-bold\">Price per Month:</span> ");
            EndContext();
            BeginContext(1340, 19, false);
#line 25 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Credits\Confirm.cshtml"
                                                                   Write(Model.PricePerMonth);

#line default
#line hidden
            EndContext();
            BeginContext(1359, 85, true);
            WriteLiteral("</div>\r\n            <div><span class=\"font-weight-bold\">Monthly installments:</span> ");
            EndContext();
            BeginContext(1445, 12, false);
#line 26 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Credits\Confirm.cshtml"
                                                                        Write(Model.Months);

#line default
#line hidden
            EndContext();
            BeginContext(1457, 77, true);
            WriteLiteral("</div>\r\n            <div><span class=\"font-weight-bold\">Credit Value:</span> ");
            EndContext();
            BeginContext(1535, 17, false);
#line 27 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Credits\Confirm.cshtml"
                                                                Write(Model.TotalAmount);

#line default
#line hidden
            EndContext();
            BeginContext(1552, 76, true);
            WriteLiteral("</div>\r\n            <div><span class=\"font-weight-bold\">Valid Until:</span> ");
            EndContext();
            BeginContext(1629, 40, false);
#line 28 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Credits\Confirm.cshtml"
                                                               Write(Model.ActiveUntil.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1669, 145, true);
            WriteLiteral("</div>\r\n        </div>\r\n        <div class=\"container-fluid d-flex justify-content-around m-5\">\r\n            <div class=\"mb-2\">\r\n                ");
            EndContext();
            BeginContext(1814, 160, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d2d154afaf23f54cba9fb9a34f640518be9343311685", async() => {
                BeginContext(1939, 31, true);
                WriteLiteral("<i class=\"fas fa-cog\"></i> Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-direct", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["direct"] = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1974, 70, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"mb-2\">\r\n                ");
            EndContext();
            BeginContext(2044, 163, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d2d154afaf23f54cba9fb9a34f640518be9343313969", async() => {
                BeginContext(2168, 35, true);
                WriteLiteral("<i class=\"fas fa-check\"></i> Finish");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-direct", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["direct"] = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2207, 129, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-md-6\">\r\n        <div class=\"container-fluid\">\r\n            ");
            EndContext();
            BeginContext(2337, 55, false);
#line 41 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Credits\Confirm.cshtml"
       Write(await Component.InvokeAsync(typeof(OpenOrderComponent)));

#line default
#line hidden
            EndContext();
            BeginContext(2392, 126, true);
            WriteLiteral("\r\n            <div class=\"text-center\">\r\n                <p class=\"font-weight-bold text-danger h4 text-right\">Cost of goods: ");
            EndContext();
            BeginContext(2520, 22, false);
#line 43 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Credits\Confirm.cshtml"
                                                                                 Write(Model.Order.TotalPrice);

#line default
#line hidden
            EndContext();
            BeginContext(2543, 75, true);
            WriteLiteral(" BGN</p>\r\n            </div>         \r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Photoparallel.Web.ViewModels.Credits.ConfirmCreditViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
