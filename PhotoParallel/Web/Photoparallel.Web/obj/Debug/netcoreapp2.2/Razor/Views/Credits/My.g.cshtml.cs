#pragma checksum "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Credits\My.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9cdf27b00ff30fa89bd26cb5b0ed146a57e7db8e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Credits_My), @"mvc.1.0.view", @"/Views/Credits/My.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Credits/My.cshtml", typeof(AspNetCore.Views_Credits_My))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cdf27b00ff30fa89bd26cb5b0ed146a57e7db8e", @"/Views/Credits/My.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19f56853bc10335ee88806db5846472111bad1fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Credits_My : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Photoparallel.Web.ViewModels.Credits.MyCreditssViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Credits", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(78, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Credits\My.cshtml"
  
    ViewData["Title"] = "My";

#line default
#line hidden
            BeginContext(118, 891, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-xl-6"">
        <div class=""container mobile-fondsize-11"">
            <div class=""h2 text-center text-info font-weight-bold"">My Orders</div>
            <table class=""table"">
                <thead>
                    <tr class=""row"">
                        <th scope=""col"" class=""col-md-2 col d-flex justify-content-center"">№</th>
                        <th scope=""col"" class=""col-md-2 col d-flex justify-content-center"">Credit Number</th>
                        <th scope=""col"" class=""col-md-3 col d-flex justify-content-center"">Creation Date</th>
                        <th scope=""col"" class=""col-md-3 col d-flex justify-content-center"">Status</th>
                        <th scope=""col"" class=""col-md-2 col d-flex justify-content-center"">Actions</th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 22 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Credits\My.cshtml"
                      
                        var credits = Model.ToArray();
                    

#line default
#line hidden
            BeginContext(1112, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 25 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Credits\My.cshtml"
                     for (int i = 0; i < credits.Length; i++)
                    {
                        var credit = credits[i];


#line default
#line hidden
            BeginContext(1250, 159, true);
            WriteLiteral("                        <tr class=\"row\">\r\n                            <td class=\"col-md-2 col d-flex justify-content-center\">\r\n                                ");
            EndContext();
            BeginContext(1411, 5, false);
#line 31 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Credits\My.cshtml"
                            Write(i + 1);

#line default
#line hidden
            EndContext();
            BeginContext(1417, 154, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td class=\"col-md-2 col d-flex justify-content-center\">\r\n                                ");
            EndContext();
            BeginContext(1572, 9, false);
#line 34 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Credits\My.cshtml"
                           Write(credit.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1581, 154, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td class=\"col-md-3 col d-flex justify-content-center\">\r\n                                ");
            EndContext();
            BeginContext(1736, 38, false);
#line 37 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Credits\My.cshtml"
                           Write(credit.IssuedOn.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1774, 154, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td class=\"col-md-3 col d-flex justify-content-center\">\r\n                                ");
            EndContext();
            BeginContext(1929, 19, false);
#line 40 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Credits\My.cshtml"
                           Write(credit.CreditStatus);

#line default
#line hidden
            EndContext();
            BeginContext(1948, 210, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td class=\"col-md-2 col d-flex justify-content-around\">\r\n                                <div class=\"mr-2\">\r\n                                    ");
            EndContext();
            BeginContext(2158, 126, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9cdf27b00ff30fa89bd26cb5b0ed146a57e7db8e8932", async() => {
                BeginContext(2273, 7, true);
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
#line 44 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Credits\My.cshtml"
                                                                                                   WriteLiteral(credit.Id);

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
            BeginContext(2284, 108, true);
            WriteLiteral("\r\n                                </div>\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 48 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Credits\My.cshtml"
                    }

#line default
#line hidden
            BeginContext(2415, 84, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Photoparallel.Web.ViewModels.Credits.MyCreditssViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
