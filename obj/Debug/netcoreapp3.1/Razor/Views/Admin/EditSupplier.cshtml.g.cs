#pragma checksum "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\EditSupplier.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d611abca323cc9f68f3ef1911208d81cbe1cf766"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_EditSupplier), @"mvc.1.0.view", @"/Views/Admin/EditSupplier.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d611abca323cc9f68f3ef1911208d81cbe1cf766", @"/Views/Admin/EditSupplier.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"708e4e3a9a23fd4ed811fb1d18518f4bb2b5726d", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_EditSupplier : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<frame.Models.Supplier>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(" \r\n");
#nullable restore
#line 3 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\EditSupplier.cshtml"
  
    ViewBag.Title = "EditSupplier";
    Layout = "~/Views/SharedAdmin/_Layout.cshtml";
    var name = ViewBag.name;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""right_col"" role=""main"">
    <div class=""EditCategory"">
        <div class=""page-title"">
            <div class=""title_left"">
                <h4>SUPPLIER MANAGEMENT</h4>
            </div>
        </div>
        <div class=""clearfix""></div>
        <div class=""row"" style=""display: flex"">
            <div class=""col-md-6 col-sm-6  "" style=""height:100vh"">
                <div class=""x_panel"">
                    <div class=""x_title"">
                        <h2>Edit Supplier</h2>
                        <div class=""clearfix""></div>
                    </div>
");
#nullable restore
#line 24 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\EditSupplier.cshtml"
                     using (Html.BeginForm())
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\EditSupplier.cshtml"
                   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\EditSupplier.cshtml"
                   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""form-row""> 
                            <div class=""form-group col-md-6"">
                                <label class=""font-weight-bold"">ID Supplier</label>
                                <input type=""text"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 1230, "\"", 1254, 1);
#nullable restore
#line 31 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\EditSupplier.cshtml"
WriteAttributeValue("", 1238, name.idSupplier, 1238, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled>\r\n                                <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 1319, "\"", 1343, 1);
#nullable restore
#line 32 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\EditSupplier.cshtml"
WriteAttributeValue("", 1327, name.idSupplier, 1327, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" name=""idSupplier"" />
                            </div> 
                        </div>
                        <div class=""form-row"">
                            <div class=""form-group col-md-6"">
                                <label class=""font-weight-bold"">Name</label>
                                <input type=""text"" class=""form-control"" pattern=""^[A-Za-z0-9-\s]*"" title=""Name should without accents""");
            BeginWriteAttribute("value", " value=\"", 1759, "\"", 1785, 1);
#nullable restore
#line 38 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\EditSupplier.cshtml"
WriteAttributeValue("", 1767, name.nameSupplier, 1767, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("name=\"nameSupplier\"");
            BeginWriteAttribute("required", " required=\"", 1805, "\"", 1816, 0);
            EndWriteAttribute();
            WriteLiteral(@" placeholder=""Nhập tên nhà cung cấp"">
                            </div>
                        </div>
                        <div class=""form-row"">
                            <div class=""form-group col-md-6"">
                                <label class=""font-weight-bold"">Address</label>
                                <input type=""text"" class=""form-control"" pattern=""^[A-Za-z0-9-\s]*"" title=""Address should without accents""");
            BeginWriteAttribute("value", " value=\"", 2253, "\"", 2282, 1);
#nullable restore
#line 44 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\EditSupplier.cshtml"
WriteAttributeValue("", 2261, name.addressSupplier, 2261, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("name=\"addressSupplier\"");
            BeginWriteAttribute("required", " required=\"", 2305, "\"", 2316, 0);
            EndWriteAttribute();
            WriteLiteral(@" placeholder=""Nhập địa chỉ NCC"">
                            </div>
                        </div>
                        <div class=""form-row"">
                            <div class=""form-group col-md-6"">
                                <label class=""font-weight-bold"">Phone</label>
                                <input type=""tel"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 2679, "\"", 2706, 1);
#nullable restore
#line 50 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\EditSupplier.cshtml"
WriteAttributeValue("", 2687, name.phoneSupplier, 2687, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("name=\"phoneSupplier\"");
            BeginWriteAttribute("required", " required=\"", 2727, "\"", 2738, 0);
            EndWriteAttribute();
            WriteLiteral(" placeholder=\"Nhập SĐT NCC\">\r\n                                ");
#nullable restore
#line 51 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\EditSupplier.cshtml"
                           Write(Html.ValidationMessageFor(model => model.phoneSupplier,"",new {@class = "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>
                        <br>
                        <div class=""modal-footer"">
                            <a href=""../../Admin/SupplierManagement"" name=""submit-cancel"" class=""btn btn-danger"">Cancel</a>
                            <input type=""submit"" name=""submit-save"" class=""btn btn-success"" value=""Save"" />
                        </div>
");
#nullable restore
#line 59 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\EditSupplier.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<frame.Models.Supplier> Html { get; private set; }
    }
}
#pragma warning restore 1591
