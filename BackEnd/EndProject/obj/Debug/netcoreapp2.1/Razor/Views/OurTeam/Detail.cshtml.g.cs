#pragma checksum "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\OurTeam\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e502dd8d731cf2005ca9110d88f9b7e8379ba42a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OurTeam_Detail), @"mvc.1.0.view", @"/Views/OurTeam/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/OurTeam/Detail.cshtml", typeof(AspNetCore.Views_OurTeam_Detail))]
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
#line 1 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\_ViewImports.cshtml"
using EndProject.Models;

#line default
#line hidden
#line 2 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\_ViewImports.cshtml"
using EndProject.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e502dd8d731cf2005ca9110d88f9b7e8379ba42a", @"/Views/OurTeam/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7aab7042ebd9a4d395ab334bdb4bcc8b4e7979ba", @"/_ViewImports.cshtml")]
    public class Views_OurTeam_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OurTeam>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\OurTeam\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
            BeginContext(58, 405, true);
            WriteLiteral(@"
<main>
    <section id=""ourteamdetailName"">
        <div class=""container"">
            <div class=""row"">
                <h3>MARK WHILBERG</h3>
            </div>
        </div>
    </section>
    <section id=""ourteamdetail"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-4 col-md-4 col-sm-12 col-12 ourteamdetailImg"">
                    ");
            EndContext();
            BeginContext(463, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "97f075ab183b44fab6136c1398014e43", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 491, "~/img/OurTeam/", 491, 14, true);
#line 18 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\OurTeam\Detail.cshtml"
AddHtmlAttributeValue("", 505, Model.Image, 505, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(526, 80, true);
            WriteLiteral("\r\n                    <div class=\"ourteamdetails\">\r\n                        <h4>");
            EndContext();
            BeginContext(607, 14, false);
#line 20 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\OurTeam\Detail.cshtml"
                       Write(Model.Fullname);

#line default
#line hidden
            EndContext();
            BeginContext(621, 37, true);
            WriteLiteral("</h4>\r\n                        <span>");
            EndContext();
            BeginContext(659, 16, false);
#line 21 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\OurTeam\Detail.cshtml"
                         Write(Model.Profession);

#line default
#line hidden
            EndContext();
            BeginContext(675, 161, true);
            WriteLiteral("</span>\r\n                    </div>\r\n                    <div class=\"ourteamdetailsoicalmedia\">\r\n                        <ul>\r\n                            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 836, "\"", 865, 1);
#line 25 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\OurTeam\Detail.cshtml"
WriteAttributeValue("", 843, Model.FacebookAddress, 843, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(866, 79, true);
            WriteLiteral("><i class=\"fab fa-facebook-f\"></i></a></li>\r\n                            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 945, "\"", 973, 1);
#line 26 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\OurTeam\Detail.cshtml"
WriteAttributeValue("", 952, Model.TwitterAddress, 952, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(974, 76, true);
            WriteLiteral("><i class=\"fab fa-twitter\"></i></a></li>\r\n                            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1050, "\"", 1079, 1);
#line 27 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\OurTeam\Detail.cshtml"
WriteAttributeValue("", 1057, Model.LinkedinAddress, 1057, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1080, 519, true);
            WriteLiteral(@"> <i class=""fab fa-linkedin-in""></i></a></li>
                        </ul>
                    </div>
                </div>
                <div class=""col-lg-8 col-md-8 col-sm-12 col-12 ourteamdetailInform"">
                    <div class=""col-6 leftside"">
                        <h3>RESUME</h3>
                        <hr>
                        <table class=""table table-striped"">
                            <tbody>
                                <tr>
                                    <td>Name: ");
            EndContext();
            BeginContext(1600, 14, false);
#line 38 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\OurTeam\Detail.cshtml"
                                         Write(Model.Fullname);

#line default
#line hidden
            EndContext();
            BeginContext(1614, 139, true);
            WriteLiteral("</td>\r\n                                </tr>\r\n                                <tr>\r\n                                    <td>Date of birth: ");
            EndContext();
            BeginContext(1754, 17, false);
#line 41 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\OurTeam\Detail.cshtml"
                                                  Write(Model.DateOfBirth);

#line default
#line hidden
            EndContext();
            BeginContext(1771, 133, true);
            WriteLiteral("</td>\r\n                                </tr>\r\n                                <tr>\r\n                                    <td>Address: ");
            EndContext();
            BeginContext(1905, 13, false);
#line 44 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\OurTeam\Detail.cshtml"
                                            Write(Model.Address);

#line default
#line hidden
            EndContext();
            BeginContext(1918, 143, true);
            WriteLiteral("</td>\r\n                                </tr>\r\n                                <tr>\r\n                                    <td>Email: <a href=\"#\">");
            EndContext();
            BeginContext(2062, 11, false);
#line 47 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\OurTeam\Detail.cshtml"
                                                      Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(2073, 135, true);
            WriteLiteral("</a></td>\r\n                                </tr>\r\n                                <tr>\r\n                                    <td>Phone: ");
            EndContext();
            BeginContext(2209, 17, false);
#line 50 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\OurTeam\Detail.cshtml"
                                          Write(Model.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(2226, 326, true);
            WriteLiteral(@"</td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                    <div class=""col-6 rightside"">
                        <h3>PROFILE</h3>
                        <hr>
                        <p>
                            ");
            EndContext();
            BeginContext(2553, 17, false);
#line 59 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\OurTeam\Detail.cshtml"
                       Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(2570, 1865, true);
            WriteLiteral(@"
                        </p>

                    </div>
                </div>
            </div>
        </div>
    </section>
    <hr>
    <section id=""ourteamdetailabout"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-4 col-md-4 col-sm-12 col-12"">
                    <h5>TURNKEY</h5>
                    <div class=""about"">
                        <i class=""far fa-clock""></i>
                        <p>We combine quality workmanship, superior knowledge and low prices.</p>
                    </div>
                </div>
                <div class=""col-lg-4 col-md-4 col-sm-12 col-12"">
                    <h5>RESOURCES</h5>
                    <div class=""about"">
                        <i class=""far fa-user""></i>
                        <p>We combine quality workmanship, superior knowledge and low prices.</p>
                    </div>
                </div>
                <div class=""col-lg-4 col-md-4 col-sm-12 col-12"">
      ");
            WriteLiteral(@"              <h5>SUPPLY</h5>
                    <div class=""about"">
                        <i class=""far fa-file-alt""></i>
                        <p>We combine quality workmanship, superior knowledge and low prices.</p>
                    </div>
                </div>
            </div>
        </div>

    </section>
    <section id=""myskills"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12 col-md-12 col-sm-12 col-12"">

                    <h3>MY SKILLS</h3>
                    <hr>
                </div>
                <div class=""col-lg-6 col-md-6 col-sm-12 col-12 progressourtesmdetail"">
                    <div id=""bar1"" class=""barfiller"">
                        <span class=""tip""></span>
                        <span class=""fill"" data-percentage=""");
            EndContext();
            BeginContext(4436, 26, false);
#line 107 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\OurTeam\Detail.cshtml"
                                                       Write(Model.TireandWheelServices);

#line default
#line hidden
            EndContext();
            BeginContext(4462, 261, true);
            WriteLiteral(@"""></span>
                        <p>Tire and Wheel Services</p>
                    </div>
                    <div id=""bar2"" class=""barfiller"">
                        <span class=""tip""></span>
                        <span class=""fill"" data-percentage=""");
            EndContext();
            BeginContext(4724, 23, false);
#line 112 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\OurTeam\Detail.cshtml"
                                                       Write(Model.LubeOilandFilters);

#line default
#line hidden
            EndContext();
            BeginContext(4747, 259, true);
            WriteLiteral(@"""></span>
                        <p>Lube, Oil and Filters</p>
                    </div>
                    <div id=""bar3"" class=""barfiller"">
                        <span class=""tip""></span>
                        <span class=""fill"" data-percentage=""");
            EndContext();
            BeginContext(5007, 19, false);
#line 117 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\OurTeam\Detail.cshtml"
                                                       Write(Model.BeltsandHoses);

#line default
#line hidden
            EndContext();
            BeginContext(5026, 367, true);
            WriteLiteral(@"""></span>
                        <p>Belts and Hoses</p>
                    </div>

                </div>
                <div class=""col-lg-6 col-md-6 col-sm-12 col-12 progressourtesmdetail"">
                    <div id=""bar4"" class=""barfiller"">
                        <span class=""tip""></span>
                        <span class=""fill"" data-percentage=""");
            EndContext();
            BeginContext(5394, 23, false);
#line 125 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\OurTeam\Detail.cshtml"
                                                       Write(Model.EngineDiagnostics);

#line default
#line hidden
            EndContext();
            BeginContext(5417, 256, true);
            WriteLiteral(@"""></span>
                        <p>Engine Diagnostics</p>
                    </div>
                    <div id=""bar5"" class=""barfiller"">
                        <span class=""tip""></span>
                        <span class=""fill"" data-percentage=""");
            EndContext();
            BeginContext(5674, 17, false);
#line 130 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\OurTeam\Detail.cshtml"
                                                       Write(Model.BrakeRepair);

#line default
#line hidden
            EndContext();
            BeginContext(5691, 250, true);
            WriteLiteral("\"></span>\r\n                        <p>Brake Repair</p>\r\n                    </div>\r\n                    <div id=\"bar6\" class=\"barfiller\">\r\n                        <span class=\"tip\"></span>\r\n                        <span class=\"fill\" data-percentage=\"");
            EndContext();
            BeginContext(5942, 21, false);
#line 135 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\OurTeam\Detail.cshtml"
                                                       Write(Model.AirConditioning);

#line default
#line hidden
            EndContext();
            BeginContext(5963, 175, true);
            WriteLiteral("\"></span>\r\n                        <p>Air Conditioning</p>\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n</main>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(6155, 1047, true);
                WriteLiteral(@"
    <script>
        $(window).scroll(function () {
            var ad = $(window).scrollTop()
            if (ad > 355 && ad < 912) {
                $('#bar1').barfiller({
                    barColor: ""#1E69B8"",
                    duration: ""2000""
                });
                $('#bar2').barfiller({
                    barColor: ""#1E69B8"",
                    duration: ""2000""
                });
                $('#bar3').barfiller({
                    barColor: ""#1E69B8"",
                    duration: ""2000""
                });
                $('#bar4').barfiller({
                    barColor: ""#1E69B8"",
                    duration: ""2000""
                });
                $('#bar5').barfiller({
                    barColor: ""#1E69B8"",
                    duration: ""2000""
                });
                $('#bar6').barfiller({
                    barColor: ""#1E69B8"",
                    duration: ""2000""
                });
            }






        })");
                WriteLiteral("\r\n\r\n\r\n\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(7205, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OurTeam> Html { get; private set; }
    }
}
#pragma warning restore 1591
