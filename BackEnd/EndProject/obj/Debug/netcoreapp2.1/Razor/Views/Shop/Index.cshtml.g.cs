#pragma checksum "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Shop\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31bdbd040744fe76361f88f91051c5c0cc09451c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Index), @"mvc.1.0.view", @"/Views/Shop/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shop/Index.cshtml", typeof(AspNetCore.Views_Shop_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31bdbd040744fe76361f88f91051c5c0cc09451c", @"/Views/Shop/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd43023b9219be13ba0c0f349e62ef93a996bd45", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary addToCart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Shop\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(59, 388, true);
            WriteLiteral(@"
    <main>
        <section id=""shopName"">
            <div class=""container"">
                <div class=""row"">
                    <h3>SHOP</h3>
                </div>
            </div>
        </section>
        <section id=""shoppingElements"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-9 shopLeftSide"">
");
            EndContext();
#line 18 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Shop\Index.cshtml"
                         foreach (Product product in Model.Products)
                        {

#line default
#line hidden
            BeginContext(544, 126, true);
            WriteLiteral("                            <div class=\"col-lg-4 col-md-6 col-sm-12 col-12 shoppingElement\">\r\n                                ");
            EndContext();
            BeginContext(670, 187, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b6f6814b66ac4023acdf69c3141870b7", async() => {
                BeginContext(742, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(743, 110, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3e71fe188c6a4195a153145b7d2c471b", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 771, "~/img/shop/", 771, 11, true);
#line 21 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Shop\Index.cshtml"
AddHtmlAttributeValue("", 782, product.ProductImages.FirstOrDefault(p=>p.IsMain==true).Image, 782, 62, false);

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
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 21 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Shop\Index.cshtml"
                                                                               WriteLiteral(product.Id);

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
            BeginContext(857, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(891, 170, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bec742d0ec2a4093a2fc281d031fd7e9", async() => {
                BeginContext(963, 42, true);
                WriteLiteral("\r\n                                    <h4>");
                EndContext();
                BeginContext(1006, 12, false);
#line 23 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Shop\Index.cshtml"
                                   Write(product.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1018, 39, true);
                WriteLiteral("</h4>\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 22 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Shop\Index.cshtml"
                                                                               WriteLiteral(product.Id);

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
            BeginContext(1061, 38, true);
            WriteLiteral("\r\n                                <p>$");
            EndContext();
            BeginContext(1100, 13, false);
#line 25 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Shop\Index.cshtml"
                               Write(product.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1113, 38, true);
            WriteLiteral("</p>\r\n                                ");
            EndContext();
            BeginContext(1151, 177, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d05512e50cf64526abcdd92b89f55932", async() => {
                BeginContext(1313, 11, true);
                WriteLiteral("ADD TO CART");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 26 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Shop\Index.cshtml"
                                                                                  WriteLiteral(product.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 26 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Shop\Index.cshtml"
                                                                                                                      WriteLiteral(Context.Request.QueryString);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["queryString"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-queryString", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["queryString"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1328, 40, true);
            WriteLiteral("\r\n\r\n                            </div>\r\n");
            EndContext();
#line 29 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Shop\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(1395, 293, true);
            WriteLiteral(@"
                    </div>
                    <div class=""col-lg-3 col-md-3 col-sm-12 col-12 ShopRightSide"">
                        <div class=""shopCategories"">
                            <h6>PRODUCT CATEGORIES</h6>
                            <hr>
                            <ul>
");
            EndContext();
#line 37 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Shop\Index.cshtml"
                                 foreach (ProductCategory category in Model.ProductCategories)
                                {

#line default
#line hidden
            BeginContext(1819, 52, true);
            WriteLiteral("                                    <li><a href=\"#\">");
            EndContext();
            BeginContext(1872, 13, false);
#line 39 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Shop\Index.cshtml"
                                               Write(category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1885, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 40 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Shop\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(1931, 212, true);
            WriteLiteral("\r\n                            </ul>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-lg-9 col-md-9 col-sm-12 col-12 shopPagination\">\r\n                        <ul>\r\n");
            EndContext();
#line 47 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Shop\Index.cshtml"
                             for (int i = 1; i <= ViewBag.PageCountShop; i++)
                            {
                                if (ViewBag.PageShop == null)
                                {
                                    if (i == 1)
                                    {

#line default
#line hidden
            BeginContext(2439, 75, true);
            WriteLiteral("                                        <li style=\"pointer-events:none;\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2514, "\"", 2540, 2);
            WriteAttributeValue("", 2521, "/shop/index?page=", 2521, 17, true);
#line 53 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Shop\Index.cshtml"
WriteAttributeValue("", 2538, i, 2538, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2541, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2543, 1, false);
#line 53 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Shop\Index.cshtml"
                                                                                                  Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(2544, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 54 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Shop\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(2675, 46, true);
            WriteLiteral("                                        <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2721, "\"", 2747, 2);
            WriteAttributeValue("", 2728, "/shop/index?page=", 2728, 17, true);
#line 57 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Shop\Index.cshtml"
WriteAttributeValue("", 2745, i, 2745, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2748, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2750, 1, false);
#line 57 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Shop\Index.cshtml"
                                                                     Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(2751, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 58 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Shop\Index.cshtml"
                                    }
                                }
                                else
                                {
                                    if (i == ViewBag.PageShop)
                                    {

#line default
#line hidden
            BeginContext(3012, 75, true);
            WriteLiteral("                                        <li style=\"pointer-events:none;\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3087, "\"", 3113, 2);
            WriteAttributeValue("", 3094, "/shop/index?page=", 3094, 17, true);
#line 64 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Shop\Index.cshtml"
WriteAttributeValue("", 3111, i, 3111, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3114, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(3116, 1, false);
#line 64 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Shop\Index.cshtml"
                                                                                                  Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(3117, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 65 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Shop\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(3248, 46, true);
            WriteLiteral("                                        <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3294, "\"", 3320, 2);
            WriteAttributeValue("", 3301, "/shop/index?page=", 3301, 17, true);
#line 68 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Shop\Index.cshtml"
WriteAttributeValue("", 3318, i, 3318, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3321, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(3323, 1, false);
#line 68 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Shop\Index.cshtml"
                                                                     Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(3324, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 69 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Shop\Index.cshtml"
                                    }
                                }
                            }

#line default
#line hidden
            BeginContext(3440, 5090, true);
            WriteLiteral(@"

                        </ul>
                    </div>


                </div>
            </div>
        </section>
        <section id=""shoppingElementsResponsive"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-9 shopLeftSide"">
                        <div class=""col-lg-4 col-md-6 col-sm-12 col-12 shoppingElement"">
                            <div class=""image"">
                                <a href=""#""> <img class=""img-fluid"" src=""img/shop/hoodie_3_front.jpg"" alt=""""></a>
                            </div>
                            <a href=""#"">
                                <h4>FLYING NINJA</h4>
                            </a>
                            <p>$12.00</p>
                            <a href=""#"" class=""btn btn-primary addToCart"">ADD TO CART</a>
                        </div>
                        <div class=""col-lg-4 col-md-6 col-sm-12 col-12 shoppingElement"">
                            <div cla");
            WriteLiteral(@"ss=""image"">
                                <a href=""#""> <img class=""img-fluid"" src=""img/shop/hoodie_4_front.jpg"" alt=""""></a>
                            </div>
                            <a href=""#"">
                                <h4>FLYING NINJA</h4>
                            </a>
                            <p>$12.00</p>
                            <a href=""#"" class=""btn btn-primary addToCart"">ADD TO CART</a>
                        </div>
                        <div class=""col-lg-4 col-md-6 col-sm-12 col-12 shoppingElement"">
                            <div class=""image"">
                                <a href=""#""> <img class=""img-fluid"" src=""img/shop/hoodie_5_front.jpg"" alt=""""></a>
                            </div>
                            <a href=""#"">
                                <h4>FLYING NINJA</h4>
                            </a>
                            <p>$12.00</p>
                            <a href=""#"" class=""btn btn-primary addToCart"">ADD TO CART</a>
        ");
            WriteLiteral(@"                </div>
                        <div class=""col-lg-4 col-md-6 col-sm-12 col-12 shoppingElement"">
                            <div class=""image"">
                                <a href=""#""> <img class=""img-fluid"" src=""img/shop/poster_2_up.jpg"" alt=""""></a>
                            </div>
                            <a href=""#"">
                                <h4>FLYING NINJA</h4>
                            </a>
                            <p>$12.00</p>
                            <a href=""#"" class=""btn btn-primary addToCart"">ADD TO CART</a>
                        </div>
                        <div class=""col-lg-4 col-md-6 col-sm-12 col-12 shoppingElement"">
                            <div class=""image"">
                                <a href=""#""> <img class=""img-fluid"" src=""img/shop/T_5_front.jpg"" alt=""""></a>
                            </div>
                            <a href=""#"">
                                <h4>FLYING NINJA</h4>
                            </a>
");
            WriteLiteral(@"                            <p>$12.00</p>
                            <a href=""#"" class=""btn btn-primary addToCart"">ADD TO CART</a>
                        </div>
                        <div class=""col-lg-4 col-md-6 col-sm-12 col-12 shoppingElement   "">
                            <div class=""image"">
                                <a href=""#""> <img class=""img-fluid"" src=""img/shop/T_7_front.jpg"" alt=""""></a>
                            </div>
                            <a href=""#"">
                                <h4>FLYING NINJA</h4>
                            </a>
                            <p>$12.00</p>
                            <a href=""#"" class=""btn btn-primary addToCart"">ADD TO CART</a>
                        </div>
                    </div>
                    <div class=""col-lg-9 col-md-9 col-sm-12 col-12 shopPagination"">
                        <ul>
                            <li><a href=""#"">1</a></li>
                            <li><a href=""#"">2</a></li>
                  ");
            WriteLiteral(@"          <li><a href=""#"">3</a></li>
                        </ul>
                    </div>
                    <div class=""col-lg-3 col-md-12 col-sm-12 col-12 ShopRightSide"">
                        <div class=""shopCategories"">
                            <h6>PRODUCT CATEGORIES</h6>
                            <hr>
                            <ul>
                                <li><a href=""#"">ALBUMS</a></li>
                                <li><a href=""#"">CLOTHING</a></li>
                                <li><a href=""#"">HOODIES</a></li>
                                <li><a href=""#"">MUSIC</a></li>
                                <li><a href=""#"">POSTERS</a></li>
                                <li><a href=""#"">SINGLES</a></li>
                                <li><a href=""#"">T-SHIRTS</a></li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </section>
    </main>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
