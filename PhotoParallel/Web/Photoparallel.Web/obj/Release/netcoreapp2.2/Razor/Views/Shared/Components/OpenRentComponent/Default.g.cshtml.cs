#pragma checksum "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Shared\Components\OpenRentComponent\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e789931b54f30220728a37941c2f4e29b2984cc2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_OpenRentComponent_Default), @"mvc.1.0.view", @"/Views/Shared/Components/OpenRentComponent/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/OpenRentComponent/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_OpenRentComponent_Default))]
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
#line 2 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Shared\Components\OpenRentComponent\Default.cshtml"
using Photoparallel.Common;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e789931b54f30220728a37941c2f4e29b2984cc2", @"/Views/Shared/Components/OpenRentComponent/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69cd7a0e2099e547b87af83f987e9f2a0389f2d4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_OpenRentComponent_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Photoparallel.Web.ViewModels.Rents.OpenRentViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(90, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Shared\Components\OpenRentComponent\Default.cshtml"
  
    ViewData["Title"] = "Default";

#line default
#line hidden
            BeginContext(135, 536, true);
            WriteLiteral(@"<table class=""table"">
    <thead>
        <tr class=""row"">
            <th scope=""col"" class=""col-2 d-flex justify-content-center"">Product</th>
            <th scope=""col"" class=""col-4 d-flex justify-content-center""></th>
            <th scope=""col"" class=""col-2 d-flex justify-content-center"">Price per day</th>
            <th scope=""col"" class=""col-2 d-flex justify-content-center"">Quantity</th>
            <th scope=""col"" class=""col-2 d-flex justify-content-center"">Guarantee</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 18 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Shared\Components\OpenRentComponent\Default.cshtml"
         foreach (var product in Model.Products)
        {

#line default
#line hidden
            BeginContext(732, 120, true);
            WriteLiteral("            <tr class=\"row\">\r\n                <td class=\"col-2 d-flex justify-content-center\">\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 852, "\"", 875, 1);
#line 22 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Shared\Components\OpenRentComponent\Default.cshtml"
WriteAttributeValue("", 858, product.ImageUrl, 858, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(876, 135, true);
            WriteLiteral(" width=\"50\" height=\"50\">\r\n                </td>\r\n                <td class=\"col-4 d-flex justify-content-center\">\r\n                    ");
            EndContext();
            BeginContext(1012, 12, false);
#line 25 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Shared\Components\OpenRentComponent\Default.cshtml"
               Write(product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1024, 89, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"col-2 d-flex justify-content-center\">");
            EndContext();
            BeginContext(1114, 19, false);
#line 27 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Shared\Components\OpenRentComponent\Default.cshtml"
                                                           Write(product.PricePerDay);

#line default
#line hidden
            EndContext();
            BeginContext(1133, 71, true);
            WriteLiteral("</td>\r\n                <td class=\"col-2 d-flex justify-content-center\">");
            EndContext();
            BeginContext(1205, 20, false);
#line 28 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Shared\Components\OpenRentComponent\Default.cshtml"
                                                           Write(product.RentQuantity);

#line default
#line hidden
            EndContext();
            BeginContext(1225, 71, true);
            WriteLiteral("</td>\r\n                <td class=\"col-2 d-flex justify-content-center\">");
            EndContext();
            BeginContext(1298, 75, false);
#line 29 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Shared\Components\OpenRentComponent\Default.cshtml"
                                                            Write(Math.Round(product.Price * GlobalConstants.GuaranteePercent).ToString("F2"));

#line default
#line hidden
            EndContext();
            BeginContext(1374, 29, true);
            WriteLiteral(" lv</td>\r\n            </tr>\r\n");
            EndContext();
#line 31 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Shared\Components\OpenRentComponent\Default.cshtml"
        }

#line default
#line hidden
            BeginContext(1414, 26, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Photoparallel.Web.ViewModels.Rents.OpenRentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591