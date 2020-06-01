#pragma checksum "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\AddDiscount.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f10723f53918b207e78c2e6d677e18dbcd41b83"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AddDiscount), @"mvc.1.0.view", @"/Views/Admin/AddDiscount.cshtml")]
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
#line 1 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\_ViewImports.cshtml"
using frame;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\_ViewImports.cshtml"
using frame.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f10723f53918b207e78c2e6d677e18dbcd41b83", @"/Views/Admin/AddDiscount.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"708e4e3a9a23fd4ed811fb1d18518f4bb2b5726d", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_AddDiscount : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\AddDiscount.cshtml"
   
    ViewBag.Title = "Add Customer";
    Layout = "~/Views/SharedAdmin/_Layout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""right_col"" role=""main"">
    <div class=""EditCategory"">
        <div class=""page-title"">
            <div class=""title_left"">
                <h4>DISCOUNT MANAGEMENT</h4>
            </div>
        </div>
        <div class=""clearfix""></div>
        <div class=""row"" style=""display: flex"">
            <div class=""col-md-6 col-sm-6  "" style=""height:100vh"">
                <div class=""x_panel"">
                    <div class=""x_title"">
                        <h2>Add Discount</h2>
                        <div class=""clearfix""></div>
                    </div>
");
#nullable restore
#line 21 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\AddDiscount.cshtml"
                     using (Html.BeginForm())
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\AddDiscount.cshtml"
                   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\AddDiscount.cshtml"
                   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""form-row""> 
                            <div class=""form-group col-md-6"">
                                <label class=""font-weight-bold"">ID</label>
                                <input type=""text"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 1158, "\"", 1177, 1);
#nullable restore
#line 28 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\AddDiscount.cshtml"
WriteAttributeValue("", 1166, ViewBag.id, 1166, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled>\r\n                                <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 1242, "\"", 1261, 1);
#nullable restore
#line 29 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\AddDiscount.cshtml"
WriteAttributeValue("", 1250, ViewBag.id, 1250, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" name=""idDiscount"" name=""idDiscount"" />
                            </div> 
                            <div class=""form-group col-md-6"">
                                <label class=""font-weight-bold"">Quantity</label>
                                <input type=""number""pattern=""[+][0-9]"" class=""form-control"" name=""quantityDis"" min=""1""");
            BeginWriteAttribute("required", "required=\"", 1603, "\"", 1613, 0);
            EndWriteAttribute();
            WriteLiteral(@" placeholder=""Enter quantity discount"">
                            </div>
                           
                        </div>
                        <div class=""form-row"">
                            <div class=""form-group col-md-6"">
                                <label class=""font-weight-bold"">Name</label>
                                <input type=""text"" class=""form-control"" pattern=""^[A-Za-z0-9-\s]*"" title=""Name should without accents"" name=""nameDiscount""");
            BeginWriteAttribute("required", " required=\"", 2095, "\"", 2106, 0);
            EndWriteAttribute();
            WriteLiteral(@" placeholder=""Enter name discount"">
                            </div>
                        </div>
                        <div class=""form-row"">
                            <div class=""form-group col-md-6"">
                                <label class=""font-weight-bold"">Date start</label>
                                <input type=""date"" class=""form-control"" name=""dateStart""");
            BeginWriteAttribute("required", " required=\"", 2495, "\"", 2506, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <div class=\"text-danger\">");
#nullable restore
#line 47 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\AddDiscount.cshtml"
                                                    Write(TempData["errorDateStart"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                            </div>
                            <div class=""form-group col-md-6"">
                                <label class=""font-weight-bold"">Date end</label>
                                <input type=""date"" class=""form-control"" name=""dateEnd""");
            BeginWriteAttribute("required", " required=\"", 2869, "\"", 2880, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <div class=\"text-danger\">");
#nullable restore
#line 52 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\AddDiscount.cshtml"
                                                    Write(TempData["errorDateEnd"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                            </div>
                        </div>
                         <div class=""form-row"">
                            <div class=""form-group col-md-6"">
                                <label class=""font-weight-bold"">Number(%)</label>
                                <input type=""number"" pattern=""[+][0-9]"" class=""form-control"" min = ""1""name=""numberDiscount""");
            BeginWriteAttribute("required", " required=\"", 3360, "\"", 3371, 0);
            EndWriteAttribute();
            WriteLiteral(@" placeholder=""Enter number discount"">
                            </div>
                        </div>
                        <br>
                        <div class=""modal-footer"">
                            <a href=""../../Admin/DiscountManagement"" name=""submit-cancel"" class=""btn btn-danger"">Cancel</a>
                            <input type=""submit"" name=""submit-save"" class=""btn btn-success"" value=""Save"" />
                        </div>
");
#nullable restore
#line 66 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\AddDiscount.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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