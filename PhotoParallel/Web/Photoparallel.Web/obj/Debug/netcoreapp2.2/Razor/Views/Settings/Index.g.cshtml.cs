#pragma checksum "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Settings\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2470203b08670be06c45b43a3e98f4573bf02e6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Settings_Index), @"mvc.1.0.view", @"/Views/Settings/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Settings/Index.cshtml", typeof(AspNetCore.Views_Settings_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2470203b08670be06c45b43a3e98f4573bf02e6f", @"/Views/Settings/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69cd7a0e2099e547b87af83f987e9f2a0389f2d4", @"/Views/_ViewImports.cshtml")]
    public class Views_Settings_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Photoparallel.Web.ViewModels.Settings.SettingsListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "InsertSetting", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Settings\Index.cshtml"
  
    this.ViewData["Title"] = "Settings";

#line default
#line hidden
            BeginContext(119, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(126, 22, false);
#line 7 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Settings\Index.cshtml"
Write(this.ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(148, 9, true);
            WriteLiteral("</h1>\r\n\r\n");
            EndContext();
#line 9 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Settings\Index.cshtml"
 foreach (var setting in this.Model.Settings)
{

#line default
#line hidden
            BeginContext(207, 9, true);
            WriteLiteral("    <div>");
            EndContext();
            BeginContext(217, 10, false);
#line 11 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Settings\Index.cshtml"
    Write(setting.Id);

#line default
#line hidden
            EndContext();
            BeginContext(227, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(230, 20, false);
#line 11 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Settings\Index.cshtml"
                 Write(setting.NameAndValue);

#line default
#line hidden
            EndContext();
            BeginContext(250, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 12 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Settings\Index.cshtml"
}

#line default
#line hidden
            BeginContext(261, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(263, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2470203b08670be06c45b43a3e98f4573bf02e6f6147", async() => {
                BeginContext(317, 10, true);
                WriteLiteral("Insert new");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Photoparallel.Web.ViewModels.Settings.SettingsListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
