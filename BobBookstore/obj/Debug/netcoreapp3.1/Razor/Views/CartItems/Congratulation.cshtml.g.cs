#pragma checksum "D:\Users\yiminp\Desktop\7-20\Frontend-Bobs-Used-Books\BobBookstore\Views\CartItems\Congratulation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "755da59871833f8d067c9c32718e335b4680e643"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CartItems_Congratulation), @"mvc.1.0.view", @"/Views/CartItems/Congratulation.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"755da59871833f8d067c9c32718e335b4680e643", @"/Views/CartItems/Congratulation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b73d7a7e58de3936e91fb2e3da5ee758c0cacb46", @"/Views/_ViewImports.cshtml")]
    public class Views_CartItems_Congratulation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "D:\Users\yiminp\Desktop\7-20\Frontend-Bobs-Used-Books\BobBookstore\Views\CartItems\Congratulation.cshtml"
  
    var totalprice = 0.0;
    foreach (var item in ViewData["order"] as List<BobBookstore.Models.ViewModels.OrderDetailViewModel>)
    {
        totalprice += item.price * item.quantity;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<table width=""100%"" height=""100%"" cellpadding=""0"" cellspacing=""0"">
    <tr>
        <td valign=""middle"" align=""center"">
            <h2>Congratulation!</h2>
        </td>
    </tr>
</table>
<table class=""table"" width=""700"">
    <thead>
        <tr>
            <th>
                Cover
            </th>
            <th>
                name
            </th>
            <th>
                price
            </th>
            <th>quantity</th>
            <th>total</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 37 "D:\Users\yiminp\Desktop\7-20\Frontend-Bobs-Used-Books\BobBookstore\Views\CartItems\Congratulation.cshtml"
         foreach (var item in ViewData["order"] as List<BobBookstore.Models.ViewModels.OrderDetailViewModel>)
        {
            double total = item.price * item.quantity;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 1116, "\"", 1131, 1);
#nullable restore
#line 42 "D:\Users\yiminp\Desktop\7-20\Frontend-Bobs-Used-Books\BobBookstore\Views\CartItems\Congratulation.cshtml"
WriteAttributeValue("", 1122, item.Url, 1122, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"80\" width=\"50\" />\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 45 "D:\Users\yiminp\Desktop\7-20\Frontend-Bobs-Used-Books\BobBookstore\Views\CartItems\Congratulation.cshtml"
               Write(item.Bookname);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n\r\n                    $");
#nullable restore
#line 50 "D:\Users\yiminp\Desktop\7-20\Frontend-Bobs-Used-Books\BobBookstore\Views\CartItems\Congratulation.cshtml"
                Write(item.price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                <td>\r\n\r\n                    ");
#nullable restore
#line 54 "D:\Users\yiminp\Desktop\7-20\Frontend-Bobs-Used-Books\BobBookstore\Views\CartItems\Congratulation.cshtml"
               Write(item.quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>$");
#nullable restore
#line 56 "D:\Users\yiminp\Desktop\7-20\Frontend-Bobs-Used-Books\BobBookstore\Views\CartItems\Congratulation.cshtml"
                Write(total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n            </tr>\r\n");
#nullable restore
#line 60 "D:\Users\yiminp\Desktop\7-20\Frontend-Bobs-Used-Books\BobBookstore\Views\CartItems\Congratulation.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<div>\r\n    <h2>Total price :$");
#nullable restore
#line 64 "D:\Users\yiminp\Desktop\7-20\Frontend-Bobs-Used-Books\BobBookstore\Views\CartItems\Congratulation.cshtml"
                 Write(totalprice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "755da59871833f8d067c9c32718e335b4680e6437461", async() => {
                WriteLiteral("Back to home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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