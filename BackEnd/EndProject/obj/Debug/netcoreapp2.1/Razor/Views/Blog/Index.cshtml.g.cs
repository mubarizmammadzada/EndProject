#pragma checksum "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6dd1a2760176a0d7b67954cccc4783ee29686d7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blog/Index.cshtml", typeof(AspNetCore.Views_Blog_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6dd1a2760176a0d7b67954cccc4783ee29686d7a", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd43023b9219be13ba0c0f349e62ef93a996bd45", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("a-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Blog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary readButton"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("a-image-side"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("a-paragraf"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(56, 353, true);
            WriteLiteral(@"
<main>
    <section id=""blogname"">
        <div class=""container"">
            <div class=""row"">
                <h3>Blog</h3>
            </div>
        </div>
    </section>
    <section id=""blogabout"">
        <div class=""container"">
            <div class=""row"">

                <div class=""col-lg-9 col-md-9 col-sm-12 col-12 blog"">
");
            EndContext();
#line 19 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Blog\Index.cshtml"
                     foreach (Blog blog in Model.Blogs)
                    {

#line default
#line hidden
            BeginContext(489, 77, true);
            WriteLiteral("                        <div class=\"blogIndex\">\r\n                            ");
            EndContext();
            BeginContext(566, 214, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbac823ce80a40709cf9d2b1a2607c2e", async() => {
                BeginContext(651, 56, true);
                WriteLiteral("\r\n                                <img class=\"img-fluid\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 707, "\"", 737, 2);
                WriteAttributeValue("", 713, "img/services/", 713, 13, true);
#line 23 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Blog\Index.cshtml"
WriteAttributeValue("", 726, blog.Image, 726, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(738, 38, true);
                WriteLiteral(" alt=\"\">\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 22 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Blog\Index.cshtml"
                                                                                           WriteLiteral(blog.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(780, 109, true);
            WriteLiteral("\r\n                            <div class=\"blog-about\">\r\n                                <span id=\"firstspan\">");
            EndContext();
            BeginContext(890, 9, false);
#line 26 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Blog\Index.cshtml"
                                                Write(blog.Date);

#line default
#line hidden
            EndContext();
            BeginContext(899, 50, true);
            WriteLiteral("</span>\r\n                                <span>By ");
            EndContext();
            BeginContext(950, 15, false);
#line 27 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Blog\Index.cshtml"
                                    Write(blog.AuthorName);

#line default
#line hidden
            EndContext();
            BeginContext(965, 107, true);
            WriteLiteral("</span>\r\n                            </div>\r\n                            <hr>\r\n                            ");
            EndContext();
            BeginContext(1072, 156, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b08aad27a0e4621b09d85c39312ebde", async() => {
                BeginContext(1141, 38, true);
                WriteLiteral("\r\n                                <h3>");
                EndContext();
                BeginContext(1180, 9, false);
#line 31 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Blog\Index.cshtml"
                               Write(blog.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1189, 35, true);
                WriteLiteral("</h3>\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 30 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Blog\Index.cshtml"
                                                                           WriteLiteral(blog.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1228, 113, true);
            WriteLiteral("\r\n                            <hr id=\"bluehr\">\r\n                            <p>\r\n                                ");
            EndContext();
            BeginContext(1342, 16, false);
#line 35 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Blog\Index.cshtml"
                           Write(blog.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1358, 64, true);
            WriteLiteral("\r\n                            </p>\r\n                            ");
            EndContext();
            BeginContext(1422, 117, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6c7b1bcf7b54b638481b0ce1459b315", async() => {
                BeginContext(1526, 9, true);
                WriteLiteral("READ MORE");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 37 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Blog\Index.cshtml"
                                                                           WriteLiteral(blog.Id);

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
            BeginContext(1539, 34, true);
            WriteLiteral("\r\n                        </div>\r\n");
            EndContext();
#line 39 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Blog\Index.cshtml"


                    }

#line default
#line hidden
            BeginContext(1600, 294, true);
            WriteLiteral(@"                </div>
                <div class=""col-lg-3 col-md-3 col-sm-12 col-12 "">
                    <div class=""blogLatestPost"">
                        <h6>LATEST POSTS</h6>
                        <hr class=""afterh6blog"">
                        <div class=""rightSidebarBlog"">
");
            EndContext();
#line 48 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Blog\Index.cshtml"
                             foreach (Blog blog in Model.LatestBlogs)
                            {

#line default
#line hidden
            BeginContext(1996, 153, true);
            WriteLiteral("                                <div class=\"elements\">\r\n                                    <div class=\"col-6\">\r\n                                        ");
            EndContext();
            BeginContext(2149, 244, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ce6ad4e0399460dbd92001698ee358c", async() => {
                BeginContext(2238, 46, true);
                WriteLiteral("\r\n                                            ");
                EndContext();
                BeginContext(2284, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0177ddac5e7d4ff18072430c165fa681", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2312, "~/img/services/", 2312, 15, true);
#line 53 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Blog\Index.cshtml"
AddHtmlAttributeValue("", 2327, blog.Image, 2327, 11, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2347, 42, true);
                WriteLiteral("\r\n                                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 52 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Blog\Index.cshtml"
                                                                                                           WriteLiteral(blog.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2393, 143, true);
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"col-6\">\r\n                                        ");
            EndContext();
            BeginContext(2536, 196, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa03732207984893bfca0b066fad1029", async() => {
                BeginContext(2623, 49, true);
                WriteLiteral("\r\n                                            <p>");
                EndContext();
                BeginContext(2673, 9, false);
#line 58 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Blog\Index.cshtml"
                                          Write(blog.Name);

#line default
#line hidden
                EndContext();
                BeginContext(2682, 46, true);
                WriteLiteral("</p>\r\n                                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 57 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Blog\Index.cshtml"
                                                                                                         WriteLiteral(blog.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2732, 86, true);
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n");
            EndContext();
#line 62 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Blog\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(2849, 219, true);
            WriteLiteral("\r\n\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"categoriesBlog\">\r\n                        <h6>CATEGORIES</h6>\r\n                        <hr>\r\n                        <ul>\r\n");
            EndContext();
#line 71 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Blog\Index.cshtml"
                             foreach (BlogCategory category in Model.BlogCategories)
                            {


#line default
#line hidden
            BeginContext(3187, 48, true);
            WriteLiteral("                                <li><a href=\"#\">");
            EndContext();
            BeginContext(3236, 13, false);
#line 74 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Blog\Index.cshtml"
                                           Write(category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3249, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 75 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Blog\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(3291, 196, true);
            WriteLiteral("\r\n                        </ul>\r\n                    </div>\r\n\r\n                </div>\r\n\r\n                <div class=\"col-lg-9 col-md-9 col-sm-12 col-12 paginationBlog\">\r\n                    <ul>\r\n");
            EndContext();
#line 84 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Blog\Index.cshtml"
                         for (int i = 1; i <= ViewBag.PageCount; i++)
                        {
                            if (ViewBag.Page == null)
                            {
                                if (i == 1)
                                {

#line default
#line hidden
            BeginContext(3751, 71, true);
            WriteLiteral("                                    <li style=\"pointer-events:none;\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3822, "\"", 3848, 2);
            WriteAttributeValue("", 3829, "/blog/index?page=", 3829, 17, true);
#line 90 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Blog\Index.cshtml"
WriteAttributeValue("", 3846, i, 3846, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3849, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(3851, 1, false);
#line 90 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Blog\Index.cshtml"
                                                                                              Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(3852, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 91 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Blog\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(3971, 42, true);
            WriteLiteral("                                    <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4013, "\"", 4039, 2);
            WriteAttributeValue("", 4020, "/blog/index?page=", 4020, 17, true);
#line 94 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Blog\Index.cshtml"
WriteAttributeValue("", 4037, i, 4037, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4040, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(4042, 1, false);
#line 94 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Blog\Index.cshtml"
                                                                 Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(4043, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 95 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Blog\Index.cshtml"
                                }
                            }
                            else
                            {
                                if (i == ViewBag.Page)
                                {

#line default
#line hidden
            BeginContext(4276, 72, true);
            WriteLiteral("                                    <li  style=\"pointer-events:none;\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4348, "\"", 4374, 2);
            WriteAttributeValue("", 4355, "/blog/index?page=", 4355, 17, true);
#line 101 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Blog\Index.cshtml"
WriteAttributeValue("", 4372, i, 4372, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4375, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(4377, 1, false);
#line 101 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Blog\Index.cshtml"
                                                                                               Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(4378, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 102 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Blog\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(4497, 42, true);
            WriteLiteral("                                    <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4539, "\"", 4565, 2);
            WriteAttributeValue("", 4546, "/blog/index?page=", 4546, 17, true);
#line 105 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Blog\Index.cshtml"
WriteAttributeValue("", 4563, i, 4563, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4566, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(4568, 1, false);
#line 105 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Blog\Index.cshtml"
                                                                 Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(4569, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 106 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Blog\Index.cshtml"
                                }
                            }

                        }

#line default
#line hidden
            BeginContext(4675, 118, true);
            WriteLiteral("\r\n\r\n                    </ul>\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </section>\r\n</main>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
