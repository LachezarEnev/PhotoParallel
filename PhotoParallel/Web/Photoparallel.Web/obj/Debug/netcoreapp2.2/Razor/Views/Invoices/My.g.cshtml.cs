#pragma checksum "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Invoices\My.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0f892ca353017b33bdc5ae288100a011f95d6ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Invoices_My), @"mvc.1.0.view", @"/Views/Invoices/My.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Invoices/My.cshtml", typeof(AspNetCore.Views_Invoices_My))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0f892ca353017b33bdc5ae288100a011f95d6ab", @"/Views/Invoices/My.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19f56853bc10335ee88806db5846472111bad1fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Invoices_My : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Photoparallel.Web.ViewModels.Invoices.MyInvoicesViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Invoices", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(79, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Invoices\My.cshtml"
  
    ViewData["Title"] = "My";

#line default
#line hidden
            BeginContext(119, 956, true);
            WriteLiteral(@"
    <div class=""row"">
        <div class=""col-xl-6"">
            <div class=""container mobile-fondsize-11"">
                <div class=""h2 text-center text-info font-weight-bold"">My Invoices</div>
                <table class=""table"">
                    <thead>
                        <tr class=""row"">
                            <th scope=""col"" class=""col-md-2 col d-flex justify-content-center"">№</th>
                            <th scope=""col"" class=""col-md-2 col d-flex justify-content-center"">Invoice Number</th>
                            <th scope=""col"" class=""col-md-3 col d-flex justify-content-center"">Issued On</th>
                            <th scope=""col"" class=""col-md-3 col d-flex justify-content-center"">Total Amount</th>
                            <th scope=""col"" class=""col-md-2 col d-flex justify-content-center"">Actions</th>
                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 22 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Invoices\My.cshtml"
                          
                            var invoices = Model.ToArray();
                        

#line default
#line hidden
            BeginContext(1191, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 25 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Invoices\My.cshtml"
                         for (int i = 0; i < invoices.Length; i++)
                        {
                            var invoice = invoices[i];


#line default
#line hidden
            BeginContext(1344, 171, true);
            WriteLiteral("                            <tr class=\"row\">\r\n                                <td class=\"col-md-2 col d-flex justify-content-center\">\r\n                                    ");
            EndContext();
            BeginContext(1517, 5, false);
#line 31 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Invoices\My.cshtml"
                                Write(i + 1);

#line default
#line hidden
            EndContext();
            BeginContext(1523, 166, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td class=\"col-md-2 col d-flex justify-content-center\">\r\n                                    ");
            EndContext();
            BeginContext(1690, 21, false);
#line 34 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Invoices\My.cshtml"
                               Write(invoice.InvoiceNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1711, 166, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td class=\"col-md-3 col d-flex justify-content-center\">\r\n                                    ");
            EndContext();
            BeginContext(1878, 16, false);
#line 37 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Invoices\My.cshtml"
                               Write(invoice.IssuedOn);

#line default
#line hidden
            EndContext();
            BeginContext(1894, 166, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td class=\"col-md-3 col d-flex justify-content-center\">\r\n                                    ");
            EndContext();
            BeginContext(2061, 19, false);
#line 40 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Invoices\My.cshtml"
                               Write(invoice.TotalAmount);

#line default
#line hidden
            EndContext();
            BeginContext(2080, 230, true);
            WriteLiteral(" BGN\r\n                                </td>\r\n                                <td class=\"col-md-2 col d-flex justify-content-around\">\r\n                                    <div class=\"mr-2\">\r\n                                        ");
            EndContext();
            BeginContext(2310, 128, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0f892ca353017b33bdc5ae288100a011f95d6ab9120", async() => {
                BeginContext(2427, 7, true);
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
#line 44 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Invoices\My.cshtml"
                                                                                                        WriteLiteral(invoice.Id);

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
            BeginContext(2438, 120, true);
            WriteLiteral("\r\n                                    </div>\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 48 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Invoices\My.cshtml"
                        }

#line default
#line hidden
            BeginContext(2585, 104, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Photoparallel.Web.ViewModels.Invoices.MyInvoicesViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
