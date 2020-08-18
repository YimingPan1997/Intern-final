#pragma checksum "D:\Users\yiminp\Desktop\8-6\Frontend-Bobs-Used-Books\BobBookstore\Views\CartItems\ConfirmCheckout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d9f2a70059b2a4089a00e68412c40a222553724"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CartItems_ConfirmCheckout), @"mvc.1.0.view", @"/Views/CartItems/ConfirmCheckout.cshtml")]
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
#line 1 "D:\Users\yiminp\Desktop\8-6\Frontend-Bobs-Used-Books\BobBookstore\Views\_ViewImports.cshtml"
using BobBookstore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\yiminp\Desktop\8-6\Frontend-Bobs-Used-Books\BobBookstore\Views\_ViewImports.cshtml"
using BobBookstore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d9f2a70059b2a4089a00e68412c40a222553724", @"/Views/CartItems/ConfirmCheckout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b73d7a7e58de3936e91fb2e3da5ee758c0cacb46", @"/Views/_ViewImports.cshtml")]
    public class Views_CartItems_ConfirmCheckout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BobBookstore.Models.Customer.Address>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("PrimeryAddressEdit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Manage/PrimeryAddressEdit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditAddress", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddAddressAtChechout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 9 "D:\Users\yiminp\Desktop\8-6\Frontend-Bobs-Used-Books\BobBookstore\Views\CartItems\ConfirmCheckout.cshtml"
  
    var totalprice = 0.0;
    foreach (var item in ViewData["order"] as List<BobBookstore.Models.ViewModels.OrderDetailViewModel>)
    {
        totalprice += item.price * item.quantity;
    }

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d9f2a70059b2a4089a00e68412c40a2225537245454", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <title>>Book Store</title>
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
    <meta name=""theme-color"" content=""#03a6f3"">
    <link rel=""stylesheet"" href=""https://dtdt6j0vhq1rq.cloudfront.net/bootstrap.min.css"">

    <link href=""https://fonts.googleapis.com/css?family=Montserrat:200,300,400,500,600,700,800,900"" rel=""stylesheet"">
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""https://dtdt6j0vhq1rq.cloudfront.net/owl.carousel.min.css"">
    <link rel=""stylesheet"" href=""https://dtdt6j0vhq1rq.cloudfront.net/styles.css"">
    <style>

        .time-horizontal {
            list-style-type: none;
            border-top: 4px solid #2282ca;
            max-width: 600px;
            padding: 2px;
            margin: 0px;
        }

            .time-horizontal li {
                float: left;
                position:");
                WriteLiteral(@" relative;
                text-align: center;
                width: 33%;
                padding-top: 10px;
            }

                .time-horizontal li b:before {
                    content: '';
                    position: absolute;
                    top: -10px;
                    left: 47%;
                    width: 18px;
                    height: 18px;
                    border: 2px solid #2282ca;
                    border-radius: 8px;
                    background: #ff0000
                }

                .time-horizontal li p:before {
                    content: '';
                    position: absolute;
                    top: -10px;
                    left: 47%;
                    width: 18px;
                    height: 18px;
                    border: 2px solid #2282ca;
                    border-radius: 8px;
                    background: #110fe5
                }
    </style>
");
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
            WriteLiteral(@"
<h1>Finish your order</h1>
<br />
<br />
<div class=""container"" style=""text-align: center"">

    <ul class=""time-horizontal"">
        <li style=""color:red""><b></b>Cart</li>
        <li style=""color:red""><b></b>Choose Address</li>
        <li><p></p>Finish</li>

    </ul>
</div>
<br />
<br />
<br />
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d9f2a70059b2a4089a00e68412c40a2225537248792", async() => {
                WriteLiteral("\r\n\r\n    <div>\r\n        <h2>Total price :$");
#nullable restore
#line 88 "D:\Users\yiminp\Desktop\8-6\Frontend-Bobs-Used-Books\BobBookstore\Views\CartItems\ConfirmCheckout.cshtml"
                     Write(totalprice);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h2>
    </div>

    <table class=""table"">
        <thead>
            <tr>
                <th>

                </th>
                <th>

                    addressline1
                </th>
                <th>
                    AddressLine2
                </th>
                <th>
                    City
                </th>
                <th>
                    State
                </th>
                <th>
                    Country
                </th>
                <th>
                    ZipCode
                </th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 120 "D:\Users\yiminp\Desktop\8-6\Frontend-Bobs-Used-Books\BobBookstore\Views\CartItems\ConfirmCheckout.cshtml"
             using (Html.BeginForm(new { action = "ConfirmOrderAddress" }))
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 122 "D:\Users\yiminp\Desktop\8-6\Frontend-Bobs-Used-Books\BobBookstore\Views\CartItems\ConfirmCheckout.cshtml"
                 foreach (var item in Model)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 124 "D:\Users\yiminp\Desktop\8-6\Frontend-Bobs-Used-Books\BobBookstore\Views\CartItems\ConfirmCheckout.cshtml"
                     if (item.IsPrimary == true)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n                            <td>\r\n                                <input type=\"radio\" id=\"primary\" name=\"addressID\"");
                BeginWriteAttribute("value", " value=\"", 4041, "\"", 4095, 1);
#nullable restore
#line 128 "D:\Users\yiminp\Desktop\8-6\Frontend-Bobs-Used-Books\BobBookstore\Views\CartItems\ConfirmCheckout.cshtml"
WriteAttributeValue("", 4049, Html.DisplayFor(modelItem => item.Address_Id), 4049, 46, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" checked />\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 131 "D:\Users\yiminp\Desktop\8-6\Frontend-Bobs-Used-Books\BobBookstore\Views\CartItems\ConfirmCheckout.cshtml"
                           Write(Html.DisplayFor(modelItem => item.AddressLine1));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 134 "D:\Users\yiminp\Desktop\8-6\Frontend-Bobs-Used-Books\BobBookstore\Views\CartItems\ConfirmCheckout.cshtml"
                           Write(Html.DisplayFor(modelItem => item.AddressLine2));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 137 "D:\Users\yiminp\Desktop\8-6\Frontend-Bobs-Used-Books\BobBookstore\Views\CartItems\ConfirmCheckout.cshtml"
                           Write(Html.DisplayFor(modelItem => item.City));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 140 "D:\Users\yiminp\Desktop\8-6\Frontend-Bobs-Used-Books\BobBookstore\Views\CartItems\ConfirmCheckout.cshtml"
                           Write(Html.DisplayFor(modelItem => item.State));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 143 "D:\Users\yiminp\Desktop\8-6\Frontend-Bobs-Used-Books\BobBookstore\Views\CartItems\ConfirmCheckout.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Country));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 146 "D:\Users\yiminp\Desktop\8-6\Frontend-Bobs-Used-Books\BobBookstore\Views\CartItems\ConfirmCheckout.cshtml"
                           Write(Html.DisplayFor(modelItem => item.ZipCode));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d9f2a70059b2a4089a00e68412c40a22255372414063", async() => {
                    WriteLiteral("Edit");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" |\r\n\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 153 "D:\Users\yiminp\Desktop\8-6\Frontend-Bobs-Used-Books\BobBookstore\Views\CartItems\ConfirmCheckout.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n                            <td>\r\n                                <input type=\"radio\" id=\"primary\" name=\"addressID\"");
                BeginWriteAttribute("value", " value=\"", 5481, "\"", 5535, 1);
#nullable restore
#line 158 "D:\Users\yiminp\Desktop\8-6\Frontend-Bobs-Used-Books\BobBookstore\Views\CartItems\ConfirmCheckout.cshtml"
WriteAttributeValue("", 5489, Html.DisplayFor(modelItem => item.Address_Id), 5489, 46, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 161 "D:\Users\yiminp\Desktop\8-6\Frontend-Bobs-Used-Books\BobBookstore\Views\CartItems\ConfirmCheckout.cshtml"
                           Write(Html.DisplayFor(modelItem => item.AddressLine1));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 164 "D:\Users\yiminp\Desktop\8-6\Frontend-Bobs-Used-Books\BobBookstore\Views\CartItems\ConfirmCheckout.cshtml"
                           Write(Html.DisplayFor(modelItem => item.AddressLine2));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 167 "D:\Users\yiminp\Desktop\8-6\Frontend-Bobs-Used-Books\BobBookstore\Views\CartItems\ConfirmCheckout.cshtml"
                           Write(Html.DisplayFor(modelItem => item.City));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 170 "D:\Users\yiminp\Desktop\8-6\Frontend-Bobs-Used-Books\BobBookstore\Views\CartItems\ConfirmCheckout.cshtml"
                           Write(Html.DisplayFor(modelItem => item.State));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 173 "D:\Users\yiminp\Desktop\8-6\Frontend-Bobs-Used-Books\BobBookstore\Views\CartItems\ConfirmCheckout.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Country));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 176 "D:\Users\yiminp\Desktop\8-6\Frontend-Bobs-Used-Books\BobBookstore\Views\CartItems\ConfirmCheckout.cshtml"
                           Write(Html.DisplayFor(modelItem => item.ZipCode));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d9f2a70059b2a4089a00e68412c40a22255372419113", async() => {
                    WriteLiteral("Edit");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 179 "D:\Users\yiminp\Desktop\8-6\Frontend-Bobs-Used-Books\BobBookstore\Views\CartItems\ConfirmCheckout.cshtml"
                                                              WriteLiteral(item.Address_Id);

#line default
#line hidden
#nullable disable
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
                WriteLiteral("\r\n\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 183 "D:\Users\yiminp\Desktop\8-6\Frontend-Bobs-Used-Books\BobBookstore\Views\CartItems\ConfirmCheckout.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 183 "D:\Users\yiminp\Desktop\8-6\Frontend-Bobs-Used-Books\BobBookstore\Views\CartItems\ConfirmCheckout.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                <input type=\"hidden\" name=\"OrderId\"");
                BeginWriteAttribute("value", " value=\"", 6754, "\"", 6782, 1);
#nullable restore
#line 185 "D:\Users\yiminp\Desktop\8-6\Frontend-Bobs-Used-Books\BobBookstore\Views\CartItems\ConfirmCheckout.cshtml"
WriteAttributeValue("", 6762, ViewData["orderId"], 6762, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                <input type=\"submit\" value=\"Finish your order\" style=\"background-color: #0b71ca ;color: #FFFFFF\" />\r\n");
#nullable restore
#line 187 "D:\Users\yiminp\Desktop\8-6\Frontend-Bobs-Used-Books\BobBookstore\Views\CartItems\ConfirmCheckout.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n\r\n\r\n    </table>\r\n    <div>\r\n        <p style=\"text-align: center\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d9f2a70059b2a4089a00e68412c40a22255372422894", async() => {
                    WriteLiteral("add address");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"</p>
    </div>
    <table class=""table"">
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
#line 212 "D:\Users\yiminp\Desktop\8-6\Frontend-Bobs-Used-Books\BobBookstore\Views\CartItems\ConfirmCheckout.cshtml"
             foreach (var item in ViewData["order"] as List<BobBookstore.Models.ViewModels.OrderDetailViewModel>)
            {
                double total = item.price * item.quantity;

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        <img");
                BeginWriteAttribute("src", " src=\"", 7739, "\"", 7754, 1);
#nullable restore
#line 217 "D:\Users\yiminp\Desktop\8-6\Frontend-Bobs-Used-Books\BobBookstore\Views\CartItems\ConfirmCheckout.cshtml"
WriteAttributeValue("", 7745, item.Url, 7745, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" height=\"80\" width=\"50\" />\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 220 "D:\Users\yiminp\Desktop\8-6\Frontend-Bobs-Used-Books\BobBookstore\Views\CartItems\ConfirmCheckout.cshtml"
                   Write(item.Bookname);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n\r\n                        $");
#nullable restore
#line 225 "D:\Users\yiminp\Desktop\8-6\Frontend-Bobs-Used-Books\BobBookstore\Views\CartItems\ConfirmCheckout.cshtml"
                    Write(item.price);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                    <td>\r\n\r\n                        ");
#nullable restore
#line 229 "D:\Users\yiminp\Desktop\8-6\Frontend-Bobs-Used-Books\BobBookstore\Views\CartItems\ConfirmCheckout.cshtml"
                   Write(item.quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>$");
#nullable restore
#line 231 "D:\Users\yiminp\Desktop\8-6\Frontend-Bobs-Used-Books\BobBookstore\Views\CartItems\ConfirmCheckout.cshtml"
                    Write(total);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\r\n\r\n                </tr>\r\n");
#nullable restore
#line 235 "D:\Users\yiminp\Desktop\8-6\Frontend-Bobs-Used-Books\BobBookstore\Views\CartItems\ConfirmCheckout.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n    </table>\r\n");
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
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BobBookstore.Models.Customer.Address>> Html { get; private set; }
    }
}
#pragma warning restore 1591
