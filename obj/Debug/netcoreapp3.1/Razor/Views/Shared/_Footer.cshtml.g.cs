#pragma checksum "C:\Users\QuachPhuong\Documents\GitHub\frame\Views\Shared\_Footer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e410bbdd6a469b97622565afd6185d9f67586f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Footer), @"mvc.1.0.view", @"/Views/Shared/_Footer.cshtml")]
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
#line 1 "C:\Users\QuachPhuong\Documents\GitHub\frame\Views\_ViewImports.cshtml"
using frame;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\QuachPhuong\Documents\GitHub\frame\Views\_ViewImports.cshtml"
using frame.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e410bbdd6a469b97622565afd6185d9f67586f8", @"/Views/Shared/_Footer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"708e4e3a9a23fd4ed811fb1d18518f4bb2b5726d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Footer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Home"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Sky Book"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<footer>\r\n    <div class=\"footer-nav\">\r\n        <div class=\"container\">\r\n            <div class=\"footer-nav-wrapper row\">\r\n                <div class=\"col-sm-3\">\r\n                    <div class=\"title-footer\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e410bbdd6a469b97622565afd6185d9f67586f84368", async() => {
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2e410bbdd6a469b97622565afd6185d9f67586f84651", async() => {
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
                WriteLiteral("\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <div class=""text-footer title-footer"">
                        <ul>
                            <li>
                                <div class=""icon-footer"">
                                    <i class=""fab fa-telegram-plane""></i>
                                </div>
                                <div class=""content-icon"">
                                    KTX khu B
                                </div>
                            </li>
                        </ul>
                        <ul>
                            <li>
                                <div class=""icon-footer"">
                                    <i class=""fas fa-phone-volume""></i>
                                </div>
                                <div class=""content-icon"">
                                    0376-206-***
                                </div>
                            </li>
                        </ul>
                        <ul>
 ");
            WriteLiteral(@"                           <li>
                                <div class=""icon-footer"">
                                    <i class=""fas fa-envelope""></i>
                                </div>
                                <div class=""content-icon"">
                                    17520257@gm.uit.edu.vn
                                </div>
                            </li>
                        </ul>
                    </div>
                </div>
                <div class=""col-sm-3"">
                    <div class=""title-footer"">
                        <h2>Shopping Guide</h2>
                        <div class=""menu-footer"">
                            <ul>
                                <li>
                                    <i class=""far fa-circle""></i>
                                    <a href=""#"">How to buy</a>
                                </li>
                                <li>
                                    <i class=""far fa-circle""></i>
          ");
            WriteLiteral(@"                          <a href=""#"">Faq</a>
                                </li>
                                <li>
                                    <i class=""far fa-circle""></i>
                                    <a href=""#"">Store Locations</a>
                                </li>
                                <li>
                                    <i class=""far fa-circle""></i>
                                    <a href=""#"">Return Policy</a>
                                </li>
                                <li>
                                    <i class=""far fa-circle""></i>
                                    <a href=""#"">Payment</a>
                                </li>
                                <li>
                                    <i class=""far fa-circle""></i>
                                    <a href=""#"">Shipment</a>
                                </li>
                            </ul>
                        </div>
                    </div>
        ");
            WriteLiteral(@"        </div>
                <div class=""col-sm-3"">
                    <div class=""title-footer"">
                        <h2>Information</h2>
                        <div class=""menu-footer"">
                            <ul>
                                <li>
                                    <i class=""far fa-circle""></i>
                                    <a href=""#"">About Us</a>
                                </li>
                                <li>
                                    <i class=""far fa-circle""></i>
                                    <a href=""#"">Delivery information</a>
                                </li>
                                <li>
                                    <i class=""far fa-circle""></i>
                                    <a href=""#"">Privacy policy</a>
                                </li>
                                <li>
                                    <i class=""far fa-circle""></i>
                                    <a href=""#"">");
            WriteLiteral(@"Discount</a>
                                </li>
                                <li>
                                    <i class=""far fa-circle""></i>
                                    <a href=""#"">Customer service</a>
                                </li>
                                <li>
                                    <i class=""far fa-circle""></i>
                                    <a href=""#"">Terms & condition</a>
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
                <div class=""col-sm-3"">
                    <div class=""title-footer"">
                        <h2>My Account</h2>
                        <div class=""menu-footer"">
                            <ul>
                                <li>
                                    <i class=""far fa-circle""></i>
                                    <a href=""#"">My Account</a>
                                </li");
            WriteLiteral(@">
                                <li>
                                    <i class=""far fa-circle""></i>
                                    <a href=""#"">My Cart</a>
                                </li>
                                <li>
                                    <i class=""far fa-circle""></i>
                                    <a href=""#"">Login</a>
                                </li>
                                <li>
                                    <i class=""far fa-circle""></i>
                                    <a href=""#"">Wishlist</a>
                                </li>
                                <li>
                                    <i class=""far fa-circle""></i>
                                    <a href=""#"">Perchases</a>
                                </li>
                                <li>
                                    <i class=""far fa-circle""></i>
                                    <a href=""#"">Logout</a>
                                </l");
            WriteLiteral(@"i>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""copyright"">
        <div class=""container"">
            <span>
                Copyright © 2020
                <a href=""#"">SkyBook</a>
            </span>
        </div>
    </div>
</footer>");
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
