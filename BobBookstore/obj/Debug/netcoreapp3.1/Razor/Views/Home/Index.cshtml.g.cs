#pragma checksum "D:\Users\yiminp\Desktop\7-20\Frontend-Bobs-Used-Books\BobBookstore\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca5de8cf3ed013aefc2ba0e2cf4dbd65fc05f8e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "D:\Users\yiminp\Desktop\7-20\Frontend-Bobs-Used-Books\BobBookstore\Views\_ViewImports.cshtml"
using BobBookstore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\yiminp\Desktop\7-20\Frontend-Bobs-Used-Books\BobBookstore\Views\_ViewImports.cshtml"
using BobBookstore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca5de8cf3ed013aefc2ba0e2cf4dbd65fc05f8e9", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b73d7a7e58de3936e91fb2e3da5ee758c0cacb46", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-align: center;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Users\yiminp\Desktop\7-20\Frontend-Bobs-Used-Books\BobBookstore\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca5de8cf3ed013aefc2ba0e2cf4dbd65fc05f8e95054", async() => {
                WriteLiteral("\r\n\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\">\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 244, "\"", 254, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 281, "\"", 291, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n    <title>Bob\'s Used Books - Homepage </title>\r\n    \r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca5de8cf3ed013aefc2ba0e2cf4dbd65fc05f8e96603", async() => {
                WriteLiteral("\r\n    <div >\r\n\r\n    </div>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca5de8cf3ed013aefc2ba0e2cf4dbd65fc05f8e96897", async() => {
                    WriteLiteral("\r\n        <p>\r\n            <input type=\"text\" name=\"SearchString\" placeholder=\"Search books...\"/>\r\n            <input type=\"submit\" value=\"Search\" />\r\n        </p>\r\n    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

    <!-- Page Content -->
    <div class=""container"">

        <div class=""row"">

            <div class=""col-lg-3"">

                <h1 class=""my-4"">Bob's Used Books</h1>
                <div class=""list-group"">
                    <a href=""#"" class=""list-group-item"">Category 1</a>
                    <a href=""#"" class=""list-group-item"">Category 2</a>
                    <a href=""#"" class=""list-group-item"">Category 3</a>
                </div>

            </div>
            <!-- /.col-lg-3 -->

            <div class=""col-lg-9"">

                <div id=""carouselExampleIndicators"" class=""carousel slide my-4"" data-ride=""carousel"">
                    <ol class=""carousel-indicators"">
                        <li data-target=""#carouselExampleIndicators"" data-slide-to=""0"" class=""active""></li>
                        <li data-target=""#carouselExampleIndicators"" data-slide-to=""1""></li>
                        <li data-target=""#carouselExampleIndicators"" data-slide-to=""2""></li>
        ");
                WriteLiteral(@"            </ol>
                    <div class=""carousel-inner"" role=""listbox"">
                        <div class=""carousel-item active"">
                            <img class=""d-block img-fluid"" src=""http://placehold.it/900x350"" alt=""First slide"">
                        </div>
                        <div class=""carousel-item"">
                            <img class=""d-block img-fluid"" src=""http://placehold.it/900x350"" alt=""Second slide"">
                        </div>
                        <div class=""carousel-item"">
                            <img class=""d-block img-fluid"" src=""http://placehold.it/900x350"" alt=""Third slide"">
                        </div>
                    </div>
                    <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
                        <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                        <span class=""sr-only"">Previous</span>
                    </a>
       ");
                WriteLiteral(@"             <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
                        <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                        <span class=""sr-only"">Next</span>
                    </a>
                </div>

                <div class=""row"">

                    <div class=""col-lg-4 col-md-6 mb-4"">
                        <div class=""card h-100"">
                            <a href=""#""><img class=""card-img-top"" src=""http://placehold.it/700x400""");
                BeginWriteAttribute("alt", " alt=\"", 3279, "\"", 3285, 0);
                EndWriteAttribute();
                WriteLiteral(@"></a>
                            <div class=""card-body"">
                                <h4 class=""card-title"">
                                    <a href=""#"">Item One</a>
                                </h4>
                                <h5>$24.99</h5>
                                <p class=""card-text"">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Amet numquam aspernatur!</p>
                            </div>
                            <div class=""card-footer"">
                                <small class=""text-muted"">&#9733; &#9733; &#9733; &#9733; &#9734;</small>
                            </div>
                        </div>
                    </div>

                    <div class=""col-lg-4 col-md-6 mb-4"">
                        <div class=""card h-100"">
                            <a href=""#""><img class=""card-img-top"" src=""http://placehold.it/700x400""");
                BeginWriteAttribute("alt", " alt=\"", 4197, "\"", 4203, 0);
                EndWriteAttribute();
                WriteLiteral(@"></a>
                            <div class=""card-body"">
                                <h4 class=""card-title"">
                                    <a href=""#"">Item Two</a>
                                </h4>
                                <h5>$24.99</h5>
                                <p class=""card-text"">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Amet numquam aspernatur! Lorem ipsum dolor sit amet.</p>
                            </div>
                            <div class=""card-footer"">
                                <small class=""text-muted"">&#9733; &#9733; &#9733; &#9733; &#9734;</small>
                            </div>
                        </div>
                    </div>

                    <div class=""col-lg-4 col-md-6 mb-4"">
                        <div class=""card h-100"">
                            <a href=""#""><img class=""card-img-top"" src=""http://placehold.it/700x400""");
                BeginWriteAttribute("alt", " alt=\"", 5143, "\"", 5149, 0);
                EndWriteAttribute();
                WriteLiteral(@"></a>
                            <div class=""card-body"">
                                <h4 class=""card-title"">
                                    <a href=""#"">Item Three</a>
                                </h4>
                                <h5>$24.99</h5>
                                <p class=""card-text"">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Amet numquam aspernatur!</p>
                            </div>
                            <div class=""card-footer"">
                                <small class=""text-muted"">&#9733; &#9733; &#9733; &#9733; &#9734;</small>
                            </div>
                        </div>
                    </div>

                    <div class=""col-lg-4 col-md-6 mb-4"">
                        <div class=""card h-100"">
                            <a href=""#""><img class=""card-img-top"" src=""http://placehold.it/700x400""");
                BeginWriteAttribute("alt", " alt=\"", 6063, "\"", 6069, 0);
                EndWriteAttribute();
                WriteLiteral(@"></a>
                            <div class=""card-body"">
                                <h4 class=""card-title"">
                                    <a href=""#"">Item Four</a>
                                </h4>
                                <h5>$24.99</h5>
                                <p class=""card-text"">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Amet numquam aspernatur!</p>
                            </div>
                            <div class=""card-footer"">
                                <small class=""text-muted"">&#9733; &#9733; &#9733; &#9733; &#9734;</small>
                            </div>
                        </div>
                    </div>

                    <div class=""col-lg-4 col-md-6 mb-4"">
                        <div class=""card h-100"">
                            <a href=""#""><img class=""card-img-top"" src=""http://placehold.it/700x400""");
                BeginWriteAttribute("alt", " alt=\"", 6982, "\"", 6988, 0);
                EndWriteAttribute();
                WriteLiteral(@"></a>
                            <div class=""card-body"">
                                <h4 class=""card-title"">
                                    <a href=""#"">Item Five</a>
                                </h4>
                                <h5>$24.99</h5>
                                <p class=""card-text"">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Amet numquam aspernatur! Lorem ipsum dolor sit amet.</p>
                            </div>
                            <div class=""card-footer"">
                                <small class=""text-muted"">&#9733; &#9733; &#9733; &#9733; &#9734;</small>
                            </div>
                        </div>
                    </div>

                    <div class=""col-lg-4 col-md-6 mb-4"">
                        <div class=""card h-100"">
                            <a href=""#""><img class=""card-img-top"" src=""http://placehold.it/700x400""");
                BeginWriteAttribute("alt", " alt=\"", 7929, "\"", 7935, 0);
                EndWriteAttribute();
                WriteLiteral(@"></a>
                            <div class=""card-body"">
                                <h4 class=""card-title"">
                                    <a href=""#"">Item Six</a>
                                </h4>
                                <h5>$24.99</h5>
                                <p class=""card-text"">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Amet numquam aspernatur!</p>
                            </div>
                            <div class=""card-footer"">
                                <small class=""text-muted"">&#9733; &#9733; &#9733; &#9733; &#9734;</small>
                            </div>
                        </div>
                    </div>

                </div>
                <!-- /.row -->

            </div>
            <!-- /.col-lg-9 -->

        </div>
        <!-- /.row -->

    </div>
    
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
