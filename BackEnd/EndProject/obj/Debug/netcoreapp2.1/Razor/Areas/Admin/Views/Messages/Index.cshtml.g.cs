#pragma checksum "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Areas\Admin\Views\Messages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0349caa4550d892f165135efd583282d23d4b40"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Messages_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Messages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Messages/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Messages_Index))]
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
#line 1 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Areas\Admin\Views\_ViewImports.cshtml"
using EndProject.Models;

#line default
#line hidden
#line 2 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Areas\Admin\Views\_ViewImports.cshtml"
using EndProject.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0349caa4550d892f165135efd583282d23d4b40", @"/Areas/Admin/Views/Messages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd43023b9219be13ba0c0f349e62ef93a996bd45", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Messages_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Message>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Messages", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Areas\Admin\Views\Messages\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(70, 938, true);
            WriteLiteral(@"
<div class=""container"">
    <div>
        <div class=""col-lg-12 grid-margin stretch-card"">
            <div class=""card"">
                <div class=""card-body"">
                    <h4 class=""card-title"">Category Table</h4>
                    <div class=""table-responsive"">
                        <table class=""table table-striped"">

                            <thead>
                                <tr>
                                    <th>
                                        Name
                                    </th>

                                    <th>
                                        Email
                                    </th>
                                    <th>
                                        Setting
                                    </th>

                                </tr>
                            </thead>
                            <tbody>
");
            EndContext();
#line 31 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Areas\Admin\Views\Messages\Index.cshtml"
                                 foreach (Message message in Model)
                                {

#line default
#line hidden
            BeginContext(1112, 149, true);
            WriteLiteral("                                    <tr>\r\n                                        <td class=\"py-1\">\r\n                                            <h4>");
            EndContext();
            BeginContext(1262, 12, false);
#line 35 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Areas\Admin\Views\Messages\Index.cshtml"
                                           Write(message.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1274, 161, true);
            WriteLiteral("</h4>\r\n                                        </td>\r\n                                        <td class=\"py-1\">\r\n                                            <h4>");
            EndContext();
            BeginContext(1436, 13, false);
#line 38 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Areas\Admin\Views\Messages\Index.cshtml"
                                           Write(message.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1449, 144, true);
            WriteLiteral("</h4>\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(1593, 145, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf224d766b4f4eecb32e578c38123b1c", async() => {
                BeginContext(1694, 40, true);
                WriteLiteral("<i class=\"mdi mdi-table-edit\">Detail</i>");
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 41 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Areas\Admin\Views\Messages\Index.cshtml"
                                                                                               WriteLiteral(message.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1738, 92, true);
            WriteLiteral("\r\n                                        </td>\r\n                                    </tr>\r\n");
            EndContext();
#line 44 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Areas\Admin\Views\Messages\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(1865, 184, true);
            WriteLiteral("\r\n                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Message>> Html { get; private set; }
    }
}
#pragma warning restore 1591
