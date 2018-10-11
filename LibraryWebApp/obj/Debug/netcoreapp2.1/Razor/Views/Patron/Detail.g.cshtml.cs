#pragma checksum "C:\Users\Nick\source\repos\LibraryWebApp\LibraryWebApp\Views\Patron\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3cbdd77d51a688f3061c8bcca001c07afcba9790"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patron_Detail), @"mvc.1.0.view", @"/Views/Patron/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Patron/Detail.cshtml", typeof(AspNetCore.Views_Patron_Detail))]
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
#line 1 "C:\Users\Nick\source\repos\LibraryWebApp\LibraryWebApp\Views\_ViewImports.cshtml"
using LibraryWebApp;

#line default
#line hidden
#line 2 "C:\Users\Nick\source\repos\LibraryWebApp\LibraryWebApp\Views\_ViewImports.cshtml"
using LibraryWebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cbdd77d51a688f3061c8bcca001c07afcba9790", @"/Views/Patron/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90e93c59d968b59b56c26f21090a31cb846cc108", @"/Views/_ViewImports.cshtml")]
    public class Views_Patron_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LibraryWebApp.Models.PatronDetailModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Nick\source\repos\LibraryWebApp\LibraryWebApp\Views\Patron\Detail.cshtml"
  
    ViewBag.Title = @Model.LastName + ", " + @Model.FirstName;

#line default
#line hidden
            BeginContext(118, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(137, 607, true);
                WriteLiteral(@"
    <script src=""https://code.jquery.com/jquery-3.1.1.slim.min.js"" integrity=""sha384-A7FZj7v+d/sdmMqp/nOQwliLvUsJfDHW+k9Omg/a/EheAdgtzNs3hpfag6Ed950n"" crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/tether/1.4.0/js/tether.min.js"" integrity=""sha384-DztdAPBWPRXSA/3eYEEUWrWCy7G5KFbe8fFjk5JAIxUYHKkDx6Qin1DkWx51bBrb"" crossorigin=""anonymous""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-alpha.6/js/bootstrap.min.js"" integrity=""sha384-vBWWzlZJ8ea9aCX4pEW3rVHjgjt7zpkNpZk+02D9phzyeVkE+jo0ieGizqPLForn"" crossorigin=""anonymous""></script>
");
                EndContext();
            }
            );
            BeginContext(747, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Styles", async() => {
                BeginContext(765, 224, true);
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-alpha.6/css/bootstrap.min.css\" integrity=\"sha384-rwoIResjU2yc3z8GV/NPeZWAv56rSmLldC3R/AZzGRnGxQQKnKkoFVhFQhNUwEyJ\" crossorigin=\"anonymous\">\r\n");
                EndContext();
            }
            );
            BeginContext(992, 283, true);
            WriteLiteral(@"
<div class=""container"">
    <div class=""header clearfix detailHeading"">
        <h2 class=""text-muted"">Patron Information</h2>
    </div>
    <div class=""jumbotron"">
        <div class=""row"">
            <div class=""col-md-4"">
                <div>
                    <h2>");
            EndContext();
            BeginContext(1276, 14, false);
#line 24 "C:\Users\Nick\source\repos\LibraryWebApp\LibraryWebApp\Views\Patron\Detail.cshtml"
                   Write(Model.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(1290, 117, true);
            WriteLiteral("</h2>\r\n                    <div class=\"patronContact\">\r\n                        <div id=\"patronTel\">Library Card ID: ");
            EndContext();
            BeginContext(1408, 19, false);
#line 26 "C:\Users\Nick\source\repos\LibraryWebApp\LibraryWebApp\Views\Patron\Detail.cshtml"
                                                        Write(Model.LibraryCardId);

#line default
#line hidden
            EndContext();
            BeginContext(1427, 65, true);
            WriteLiteral("</div>\r\n                        <div id=\"patronAddress\">Address: ");
            EndContext();
            BeginContext(1493, 13, false);
#line 27 "C:\Users\Nick\source\repos\LibraryWebApp\LibraryWebApp\Views\Patron\Detail.cshtml"
                                                    Write(Model.Address);

#line default
#line hidden
            EndContext();
            BeginContext(1506, 63, true);
            WriteLiteral("</div>\r\n                        <div id=\"patronTel\">Telephone: ");
            EndContext();
            BeginContext(1570, 21, false);
#line 28 "C:\Users\Nick\source\repos\LibraryWebApp\LibraryWebApp\Views\Patron\Detail.cshtml"
                                                  Write(Model.TelephoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1591, 67, true);
            WriteLiteral("</div>\r\n                        <div id=\"patronDate\">Member Since: ");
            EndContext();
            BeginContext(1659, 17, false);
#line 29 "C:\Users\Nick\source\repos\LibraryWebApp\LibraryWebApp\Views\Patron\Detail.cshtml"
                                                      Write(Model.MemberSince);

#line default
#line hidden
            EndContext();
            BeginContext(1676, 70, true);
            WriteLiteral("</div>\r\n                        <div id=\"patronLibrary\">Home Library: ");
            EndContext();
            BeginContext(1747, 23, false);
#line 30 "C:\Users\Nick\source\repos\LibraryWebApp\LibraryWebApp\Views\Patron\Detail.cshtml"
                                                         Write(Model.HomeLibraryBranch);

#line default
#line hidden
            EndContext();
            BeginContext(1770, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 31 "C:\Users\Nick\source\repos\LibraryWebApp\LibraryWebApp\Views\Patron\Detail.cshtml"
                         if (@Model.OverdueFees > 0)
                        {

#line default
#line hidden
            BeginContext(1859, 71, true);
            WriteLiteral("                            <div id=\"patronHasFees\">Current Fees Due: $");
            EndContext();
            BeginContext(1931, 17, false);
#line 33 "C:\Users\Nick\source\repos\LibraryWebApp\LibraryWebApp\Views\Patron\Detail.cshtml"
                                                                  Write(Model.OverdueFees);

#line default
#line hidden
            EndContext();
            BeginContext(1948, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 34 "C:\Users\Nick\source\repos\LibraryWebApp\LibraryWebApp\Views\Patron\Detail.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(2040, 81, true);
            WriteLiteral("                            <div id=\"patronNoFees\">No Fees Currently Due.</div>\r\n");
            EndContext();
#line 38 "C:\Users\Nick\source\repos\LibraryWebApp\LibraryWebApp\Views\Patron\Detail.cshtml"

                        }

#line default
#line hidden
            BeginContext(2150, 163, true);
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-4\">\r\n                <h4>Assets Currently Checked Out</h4>\r\n");
            EndContext();
#line 45 "C:\Users\Nick\source\repos\LibraryWebApp\LibraryWebApp\Views\Patron\Detail.cshtml"
                 if (@Model.AssetsCheckedOut.Any())
                {

#line default
#line hidden
            BeginContext(2385, 75, true);
            WriteLiteral("                    <div id=\"patronAssets\">\r\n                        <ul>\r\n");
            EndContext();
#line 49 "C:\Users\Nick\source\repos\LibraryWebApp\LibraryWebApp\Views\Patron\Detail.cshtml"
                             foreach (var checkout in @Model.AssetsCheckedOut)
                            {

#line default
#line hidden
            BeginContext(2571, 74, true);
            WriteLiteral("                                <li>\r\n                                    ");
            EndContext();
            BeginContext(2646, 27, false);
#line 52 "C:\Users\Nick\source\repos\LibraryWebApp\LibraryWebApp\Views\Patron\Detail.cshtml"
                               Write(checkout.LibraryAsset.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2673, 22, true);
            WriteLiteral(" - (Library Asset ID: ");
            EndContext();
            BeginContext(2696, 24, false);
#line 52 "C:\Users\Nick\source\repos\LibraryWebApp\LibraryWebApp\Views\Patron\Detail.cshtml"
                                                                                 Write(checkout.LibraryAsset.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2720, 142, true);
            WriteLiteral(")\r\n                                    <ul>\r\n                                        <li>\r\n                                            Since: ");
            EndContext();
            BeginContext(2863, 14, false);
#line 55 "C:\Users\Nick\source\repos\LibraryWebApp\LibraryWebApp\Views\Patron\Detail.cshtml"
                                              Write(checkout.Since);

#line default
#line hidden
            EndContext();
            BeginContext(2877, 144, true);
            WriteLiteral("\r\n                                        </li>\r\n                                        <li>\r\n                                            Due: ");
            EndContext();
            BeginContext(3022, 14, false);
#line 58 "C:\Users\Nick\source\repos\LibraryWebApp\LibraryWebApp\Views\Patron\Detail.cshtml"
                                            Write(checkout.Until);

#line default
#line hidden
            EndContext();
            BeginContext(3036, 131, true);
            WriteLiteral("\r\n                                        </li>\r\n                                    </ul>\r\n                                </li>\r\n");
            EndContext();
#line 62 "C:\Users\Nick\source\repos\LibraryWebApp\LibraryWebApp\Views\Patron\Detail.cshtml"
                            }

#line default
#line hidden
            BeginContext(3198, 59, true);
            WriteLiteral("                        </ul>\r\n                    </div>\r\n");
            EndContext();
#line 65 "C:\Users\Nick\source\repos\LibraryWebApp\LibraryWebApp\Views\Patron\Detail.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(3317, 64, true);
            WriteLiteral("                    <div>No items currently checked out.</div>\r\n");
            EndContext();
#line 69 "C:\Users\Nick\source\repos\LibraryWebApp\LibraryWebApp\Views\Patron\Detail.cshtml"

                }

#line default
#line hidden
            BeginContext(3402, 109, true);
            WriteLiteral("            </div>\r\n\r\n            <div class=\"col-md-4\">\r\n                <h4>Assets Currently On Hold</h4>\r\n");
            EndContext();
#line 75 "C:\Users\Nick\source\repos\LibraryWebApp\LibraryWebApp\Views\Patron\Detail.cshtml"
                 if (@Model.Holds.Any())
                {

#line default
#line hidden
            BeginContext(3572, 74, true);
            WriteLiteral("                    <div id=\"patronHolds\">\r\n                        <ul>\r\n");
            EndContext();
#line 79 "C:\Users\Nick\source\repos\LibraryWebApp\LibraryWebApp\Views\Patron\Detail.cshtml"
                             foreach (var hold in @Model.Holds)
                            {

#line default
#line hidden
            BeginContext(3742, 36, true);
            WriteLiteral("                                <li>");
            EndContext();
            BeginContext(3779, 23, false);
#line 81 "C:\Users\Nick\source\repos\LibraryWebApp\LibraryWebApp\Views\Patron\Detail.cshtml"
                               Write(hold.LibraryAsset.Title);

#line default
#line hidden
            EndContext();
            BeginContext(3802, 10, true);
            WriteLiteral(" - Placed ");
            EndContext();
            BeginContext(3813, 44, false);
#line 81 "C:\Users\Nick\source\repos\LibraryWebApp\LibraryWebApp\Views\Patron\Detail.cshtml"
                                                                 Write(hold.HoldPlaced.ToString("yy-dd-MM - HH:mm"));

#line default
#line hidden
            EndContext();
            BeginContext(3857, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 82 "C:\Users\Nick\source\repos\LibraryWebApp\LibraryWebApp\Views\Patron\Detail.cshtml"
                            }

#line default
#line hidden
            BeginContext(3895, 59, true);
            WriteLiteral("                        </ul>\r\n                    </div>\r\n");
            EndContext();
#line 85 "C:\Users\Nick\source\repos\LibraryWebApp\LibraryWebApp\Views\Patron\Detail.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(4014, 50, true);
            WriteLiteral("                    <div>No items on hold.</div>\r\n");
            EndContext();
#line 89 "C:\Users\Nick\source\repos\LibraryWebApp\LibraryWebApp\Views\Patron\Detail.cshtml"
                }

#line default
#line hidden
            BeginContext(4083, 54, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LibraryWebApp.Models.PatronDetailModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
