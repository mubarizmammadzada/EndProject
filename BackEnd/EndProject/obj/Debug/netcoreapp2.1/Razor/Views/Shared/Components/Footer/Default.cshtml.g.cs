#pragma checksum "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Shared\Components\Footer\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2b031948c3b9caef592b0c893d636d21b868c43"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Footer_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Footer/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Footer/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Footer_Default))]
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
#line 1 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\_ViewImports.cshtml"
using EndProject.Models;

#line default
#line hidden
#line 2 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\_ViewImports.cshtml"
using EndProject.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2b031948c3b9caef592b0c893d636d21b868c43", @"/Views/Shared/Components/Footer/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd43023b9219be13ba0c0f349e62ef93a996bd45", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Footer_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bio>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Shared\Components\Footer\Default.cshtml"
  
    ViewData["Title"] = "Default";

#line default
#line hidden
            BeginContext(55, 327, true);
            WriteLiteral(@"
<!-- Footer Start -->
<footer id=""footer"" style=""background-color: #73767A;"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-4 col-md-4 col-sm-6 col-6 head"">
                <i class=""fas fa-map-marked-alt head-icon""></i>
                <p class=""head-text"">
                    ");
            EndContext();
            BeginContext(383, 13, false);
#line 13 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Shared\Components\Footer\Default.cshtml"
               Write(Model.Address);

#line default
#line hidden
            EndContext();
            BeginContext(396, 286, true);
            WriteLiteral(@"
                </p>
            </div>
            <div class=""col-lg-4 col-md-4 col-sm-6 col-6 head"">
                <i class=""fas fa-phone-square-alt head-icon""></i>
                <p class=""head-text"">
                    Feel Free to Call Us Now <br>
                    ");
            EndContext();
            BeginContext(683, 17, false);
#line 20 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Shared\Components\Footer\Default.cshtml"
               Write(Model.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(700, 282, true);
            WriteLiteral(@"
                </p>
            </div>
            <div class=""col-lg-4 col-md-4 col-sm-6 col-6 head"">
                <i class=""fas fa-truck-moving head-icon""></i>
                <p class=""head-text"">
                    24/7 Roadside Assistance <br>
                    ");
            EndContext();
            BeginContext(983, 26, false);
#line 27 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Shared\Components\Footer\Default.cshtml"
               Write(Model.AsistancePhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1009, 245, true);
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n            <hr class=\"w-100\">\r\n            <div class=\"col-lg-4 col-md-4 col-sm-6 col-6 footer-bio\">\r\n                <h6>ABOUT US</h6>\r\n                <hr>\r\n                <p>\r\n                    ");
            EndContext();
            BeginContext(1255, 13, false);
#line 35 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Shared\Components\Footer\Default.cshtml"
               Write(Model.Address);

#line default
#line hidden
            EndContext();
            BeginContext(1268, 116, true);
            WriteLiteral("\r\n                </p>\r\n                <ul>\r\n                    <li>\r\n                        <span>Modile:</span>");
            EndContext();
            BeginContext(1385, 17, false);
#line 39 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Shared\Components\Footer\Default.cshtml"
                                       Write(Model.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1402, 103, true);
            WriteLiteral("\r\n                    </li>\r\n                    <li>\r\n                        <span>Assistance:</span>");
            EndContext();
            BeginContext(1506, 26, false);
#line 42 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Shared\Components\Footer\Default.cshtml"
                                           Write(Model.AsistancePhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1532, 99, true);
            WriteLiteral("\r\n                    </li>\r\n                    <li>\r\n                        <span>E-mail:</span>");
            EndContext();
            BeginContext(1631, 30, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43453146df54437d97f044ed081a56d9", async() => {
                BeginContext(1646, 11, false);
#line 45 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Shared\Components\Footer\Default.cshtml"
                                                     Write(Model.Email);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1661, 150, true);
            WriteLiteral("\r\n                    </li>\r\n                </ul>\r\n                <ul id=\"footer-socilamedia\">\r\n                    <li>\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1811, "\"", 1840, 1);
#line 50 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Shared\Components\Footer\Default.cshtml"
WriteAttributeValue("", 1818, Model.FacebookAddress, 1818, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1841, 175, true);
            WriteLiteral(">\r\n                            <i class=\"fab fa-facebook-f\"></i>\r\n                        </a>\r\n                    </li>\r\n                    <li>\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2016, "\"", 2044, 1);
#line 55 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Shared\Components\Footer\Default.cshtml"
WriteAttributeValue("", 2023, Model.TwitterAddress, 2023, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2045, 172, true);
            WriteLiteral(">\r\n                            <i class=\"fab fa-twitter\"></i>\r\n                        </a>\r\n                    </li>\r\n                    <li>\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2217, "\"", 2246, 1);
#line 60 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Shared\Components\Footer\Default.cshtml"
WriteAttributeValue("", 2224, Model.LinkedinAddress, 2224, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2247, 176, true);
            WriteLiteral(">\r\n                            <i class=\"fab fa-linkedin-in\"></i>\r\n                        </a>\r\n                    </li>\r\n                    <li>\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2423, "\"", 2453, 1);
#line 65 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Shared\Components\Footer\Default.cshtml"
WriteAttributeValue("", 2430, Model.PinterestAddress, 2430, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2454, 1616, true);
            WriteLiteral(@">
                            <i class=""fab fa-pinterest""></i>
                        </a>
                    </li>
                </ul>
            </div>
            <div class=""col-lg-4 col-md-4 col-sm-6 col-6 footer-bio"">
                <h6>OUR SERVICES</h6>
                <hr>
                <ul>
                    <li><i class=""fas fa-check""></i>Engine Diagnostics</li>
                    <li><i class=""fas fa-check""></i>Lube, Oil and Filters</li>
                    <li><i class=""fas fa-check""></i>Belts and Hoses</li>
                    <li><i class=""fas fa-check""></i>Air Conditioning</li>
                    <li><i class=""fas fa-check""></i>Brake Repair</li>
                    <li><i class=""fas fa-check""></i>Tire and Wheel Services</li>
                    <li><i class=""fas fa-check""></i>Other Car Services</li>
                </ul>
            </div>
            <div class=""col-lg-4 col-md-4 col-sm-6 col-6 footer-bio"">
                <h6>HOURS</h6>
                <hr>
 ");
            WriteLiteral(@"               <ul>
                    <li><span>Monday:</span>7:30am - 5:30pm</li>
                    <li><span>Tuesday:</span>7:30am - 5:30pm</li>
                    <li><span>Wednesday:</span>7:30am - 5:30pm</li>
                    <li><span>Thursday:</span>7:30am - 5:30pm</li>
                    <li><span>Friday:</span>7:30am - 5:30pm</li>
                    <li><span>Saturday:</span>7:30am - 3:00pm</li>
                    <li><span>Sunday:</span>Sunday:Closed</li>
                </ul>
            </div>
        </div>
    </div>
</footer>
<!-- Footer End -->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bio> Html { get; private set; }
    }
}
#pragma warning restore 1591
