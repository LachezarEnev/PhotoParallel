#pragma checksum "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Credits\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9807d71c26d175d9aae9d7966f63a83276eefeba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Credits_Details), @"mvc.1.0.view", @"/Views/Credits/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Credits/Details.cshtml", typeof(AspNetCore.Views_Credits_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9807d71c26d175d9aae9d7966f63a83276eefeba", @"/Views/Credits/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69cd7a0e2099e547b87af83f987e9f2a0389f2d4", @"/Views/_ViewImports.cshtml")]
    public class Views_Credits_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Photoparallel.Web.ViewModels.Credits.CreditDetailsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(68, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Credits\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(113, 161, true);
            WriteLiteral("\r\n<div class=\"container-fluid bg-light\">\r\n    <h3 class=\"text-center font-weight-bold mt-5\">CREDIT CONTRACT</h3>\r\n    <h5 class=\"text-center font-weight-bold\">№ ");
            EndContext();
            BeginContext(275, 8, false);
#line 9 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Credits\Details.cshtml"
                                          Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(283, 146, true);
            WriteLiteral("</h5>\r\n    <div class=\"row justify-content-between\">\r\n        <div class=\"col-7 mt-2\">\r\n            <div><span class=\"font-weight-bold\">Creditor: ");
            EndContext();
            BeginContext(430, 24, false);
#line 12 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Credits\Details.cshtml"
                                                     Write(Model.CreditCompany.Name);

#line default
#line hidden
            EndContext();
            BeginContext(454, 83, true);
            WriteLiteral("</span></div>\r\n            <div><span class=\"font-weight-bold\">Vat reg. № </span>BG");
            EndContext();
            BeginContext(539, 29, false);
#line 13 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Credits\Details.cshtml"
                                                                Write(Model.CreditCompany.VatNumber);

#line default
#line hidden
            EndContext();
            BeginContext(569, 72, true);
            WriteLiteral("</div>\r\n            <div><span class=\"font-weight-bold\">Address: </span>");
            EndContext();
            BeginContext(642, 27, false);
#line 14 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Credits\Details.cshtml"
                                                           Write(Model.CreditCompany.Address);

#line default
#line hidden
            EndContext();
            BeginContext(669, 112, true);
            WriteLiteral("</div>\r\n        </div>\r\n        <div class=\"col-5\">\r\n            <div><span class=\"font-weight-bold\">Recipient: ");
            EndContext();
            BeginContext(782, 21, false);
#line 17 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Credits\Details.cshtml"
                                                      Write(Model.Order.Recipient);

#line default
#line hidden
            EndContext();
            BeginContext(803, 74, true);
            WriteLiteral("</span></div>\r\n            <div><span class=\"font-weight-bold\">UCN </span>");
            EndContext();
            BeginContext(878, 9, false);
#line 18 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Credits\Details.cshtml"
                                                      Write(Model.Ucn);

#line default
#line hidden
            EndContext();
            BeginContext(887, 68, true);
            WriteLiteral("</div>\r\n            <div><span class=\"font-weight-bold\">ID № </span>");
            EndContext();
            BeginContext(956, 14, false);
#line 19 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Credits\Details.cshtml"
                                                       Write(Model.IdNumber);

#line default
#line hidden
            EndContext();
            BeginContext(970, 72, true);
            WriteLiteral("</div>\r\n            <div><span class=\"font-weight-bold\">Address: </span>");
            EndContext();
            BeginContext(1043, 13, false);
#line 20 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Credits\Details.cshtml"
                                                           Write(Model.Address);

#line default
#line hidden
            EndContext();
            BeginContext(1056, 431, true);
            WriteLiteral(@"</div>
        </div>
    </div>
    <hr />
    <h6 class=""text-center font-weight-bold"">Credit Terms</h6>
    <p>1. Pri tibique omnesque in, velit nobis nam at. At dicunt inermis delicatissimi pri. Nec quidam maiorum deseruisse no, scaevola detraxit mel et. Nostrud detracto accommodare nam ut, ex magna mutat ponderum quo. Corpora evertitur prodesset te pri. Ius omnes affert interpretaris ne <span class=""font-weight-bold"">");
            EndContext();
            BeginContext(1488, 37, false);
#line 25 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Credits\Details.cshtml"
                                                                                                                                                                                                                                                                                                                          Write(Model.IssuedOn.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1525, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(1529, 40, false);
#line 25 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Credits\Details.cshtml"
                                                                                                                                                                                                                                                                                                                                                                   Write(Model.ActiveUntil.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1569, 442, true);
            WriteLiteral(@"</span>.</p>
    <p>2. Ad propriae nominati mea, qui cu quot vocibus volutpat, ut posse imperdiet nam. An vim apeirian sapientem, populo timeam iuvaret et cum, at movet graecis his. Ex quot velit quo, eros doming neglegentur nam cu. Te zril quando nam, eum ut scripta habemus luptatum. Cum ne hinc reprehendunt, te vide eligendi tincidunt per, dolores detracto sensibus eu cum. Erant dolorum torquatos ad eam: <span class=""font-weight-bold"">");
            EndContext();
            BeginContext(2012, 17, false);
#line 26 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Credits\Details.cshtml"
                                                                                                                                                                                                                                                                                                                                                                                                                                       Write(Model.TotalAmount);

#line default
#line hidden
            EndContext();
            BeginContext(2029, 2918, true);
            WriteLiteral(@" BGN</span>.</p>
    <p>3. Eu aperiam bonorum sit, in denique posidonium concludaturque vim, ea sea atomorum accusamus signiferumque. Sed repudiare voluptatibus cu, cu usu prodesset honestatis. Alienum minimum ad eam, te nemore denique vix. Ea brute commodo quo. Sanctus conceptam id eos, commodo meliore argumentum id est. Mea suas evertitur ea, lorem eligendi argumentum ad sea.</p>
    <p>4. No nullam splendide mei, id omnis explicari imperdiet qui. Solum efficiantur ei quo, ex sit dicam atomorum. Ei nec vide nostrum antiopam, ea mel amet postea expetendis. Possim omnium intellegebat est id, aeque suavitate his in. Cu omnes postea bonorum nec.</p>
    <p>5. Adipisci necessitatibus mei ea, has possim omnium ancillae ei. Doming deterruisset qui et, consetetur sadipscing has ad. Alienum recusabo inciderint ad nam, quo no quem facer homero. Sea in illum iuvaret detracto, dico aeque harum cu vis. Ea cibo natum referrentur nec, ea qui tantas laboramus. An mea sumo reformidans.</p>
    <p>6. Ei est choro assueve");
            WriteLiteral(@"rit, sea verear adipisci an. Magna debitis vituperatoribus cum cu, ex tale utroque pro, mea denique conceptam an. Eu detracto imperdiet voluptatibus mei. Ea ius reprimique sadipscing, putent voluptaria in cum, mel id graece scriptorem. No atomorum cotidieque pro, et verear dignissim cum.</p>
    <p>7. Ut enim saepe vel. Sit mutat vitae consetetur at. Affert integre mandamus eos te, eos novum iisque moderatius eu. Te amet idque malis qui, et mel dicunt everti salutatus. Id eam lucilius partiendo evertitur, eum ex partiendo suavitate, mel ubique ponderum no. Tempor discere te his.</p>
    <p>8. In eam falli omnesque. Brute pertinax repudiandae cum cu, sed euismod patrioque conceptam id. Nam legere omnesque at, viderer efficiendi signiferumque sit no. Paulo utinam dolorum vix ex, ne vis debet utinam lobortis.</p>
    <p>9. Adhuc ipsum no quo, putant propriae eum ei, cu brute adipisci est. Fastidii disputationi sed ne. Unum eripuit per ut. Case altera phaedrum pro ut, soleat habemus ius an, sit tempor audire e");
            WriteLiteral(@"x. Homero vidisse ad qui, vis nibh ullum cu. Usu cu philosophia definitiones, no ridens equidem tincidunt eos. Ei ius quod ridens, ad purto minim accusam vel, ei eum quod dictas.</p>
    <h6 class=""text-center font-weight-bold"">Monthly Installments</h6>
    <div class=""mt-5"">
        <table class=""table"">
            <thead>
                <tr class=""d-flex justify-content-around"">
                    <th scope=""col"" class=""col-md-2 col d-flex justify-content-center"">№</th>
                    <th scope=""col"" class=""col-md-3 col d-flex justify-content-center"">Monthly Instalment</th>
                    <th scope=""col"" class=""col-md-4 col d-flex justify-content-center"">Due Date</th>
                    <th scope=""col"" class=""col-md-3 col d-flex justify-content-center"">Remaining</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 46 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Credits\Details.cshtml"
                 for (int i = 0; i < Model.Months; i++)
                {

#line default
#line hidden
            BeginContext(5023, 173, true);
            WriteLiteral("                    <tr class=\"d-flex justify-content-around\">\r\n                        <td class=\"col-md-2 col d-flex justify-content-center\">\r\n                            ");
            EndContext();
            BeginContext(5198, 5, false);
#line 50 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Credits\Details.cshtml"
                        Write(i + 1);

#line default
#line hidden
            EndContext();
            BeginContext(5204, 142, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"col-md-3 col d-flex justify-content-center\">\r\n                            ");
            EndContext();
            BeginContext(5347, 19, false);
#line 53 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Credits\Details.cshtml"
                       Write(Model.PricePerMonth);

#line default
#line hidden
            EndContext();
            BeginContext(5366, 146, true);
            WriteLiteral(" BGN\r\n                        </td>\r\n                        <td class=\"col-md-4 col d-flex justify-content-center\">\r\n                            ");
            EndContext();
            BeginContext(5513, 54, false);
#line 56 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Credits\Details.cshtml"
                       Write(Model.IssuedOn.AddMonths(i + 1).ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(5567, 142, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"col-md-3 col d-flex justify-content-center\">\r\n                            ");
            EndContext();
            BeginContext(5711, 47, false);
#line 59 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Credits\Details.cshtml"
                        Write(Model.TotalAmount - (Model.PricePerMonth * (i)));

#line default
#line hidden
            EndContext();
            BeginContext(5759, 64, true);
            WriteLiteral(" BGN\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 62 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Credits\Details.cshtml"
                }

#line default
#line hidden
            BeginContext(5842, 455, true);
            WriteLiteral(@"            </tbody>
        </table>
    </div>
    <div class=""row justify-content-between mt-5"">
        <div class=""col-1""></div>
        <div class=""col-7"">
            <div class=""font-weight-bold"">Creditor Signature:.........................</div>
        </div>
        <div class=""col-4"">
            <div class=""font-weight-bold"">Recipient Signature:.........................</div>
            <div class=""mb-5 font-weight-bold"">Date: ");
            EndContext();
            BeginContext(6298, 37, false);
#line 73 "D:\SoftUni\C# Web\MyProject\PhotoParallel\Web\Photoparallel.Web\Views\Credits\Details.cshtml"
                                                Write(Model.IssuedOn.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(6335, 44, true);
            WriteLiteral("</div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Photoparallel.Web.ViewModels.Credits.CreditDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591