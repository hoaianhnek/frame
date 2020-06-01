#pragma checksum "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\CreateSupplier.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2665c61b00544b45e093ce96dbc44264e451e87"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_CreateSupplier), @"mvc.1.0.view", @"/Views/Admin/CreateSupplier.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2665c61b00544b45e093ce96dbc44264e451e87", @"/Views/Admin/CreateSupplier.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"708e4e3a9a23fd4ed811fb1d18518f4bb2b5726d", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_CreateSupplier : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<frame.Models.Supplier>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(" \r\n");
#nullable restore
#line 3 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\CreateSupplier.cshtml"
  
    ViewBag.Title = "CreateSupplier";
    Layout = "~/Views/SharedAdmin/_Layout.cshtml";
    var id = ViewBag.id;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""right_col"" role=""main"">
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
                        <h2>Add Supplier</h2>
                        <div class=""clearfix""></div>
                    </div>
");
#nullable restore
#line 23 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\CreateSupplier.cshtml"
                     using (Html.BeginForm())
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\CreateSupplier.cshtml"
                   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\CreateSupplier.cshtml"
                   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""form-row""> 
                            <div class=""form-group col-md-6"">
                                <label class=""font-weight-bold"">ID Supplier</label>
                                <input type=""text"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 1225, "\"", 1236, 1);
#nullable restore
#line 30 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\CreateSupplier.cshtml"
WriteAttributeValue("", 1233, id, 1233, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled>\r\n                                <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 1301, "\"", 1312, 1);
#nullable restore
#line 31 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\CreateSupplier.cshtml"
WriteAttributeValue("", 1309, id, 1309, 3, false);

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
                                <input type=""text"" class=""form-control"" pattern=""^[A-Za-z0-9-\s]*"" title=""Name should without accents"" name=""nameSupplier""");
            BeginWriteAttribute("required", " required=\"", 1748, "\"", 1759, 0);
            EndWriteAttribute();
            WriteLiteral(@" placeholder=""Enter name supplier"">
                            </div>
                        </div>
                        <div class=""form-row"">
                            <div class=""form-group col-md-6"">
                                <label class=""font-weight-bold"">Address</label>
                                <input type=""text"" class=""form-control"" name=""addressSupplier"" pattern=""^[A-Za-z0-9-\s]*"" title=""Address should without accents""");
            BeginWriteAttribute("required", " required=\"", 2217, "\"", 2228, 0);
            EndWriteAttribute();
            WriteLiteral(@" placeholder=""Enter address supplier"">
                            </div>
                        </div>
                        <div class=""form-row"">
                            <div class=""form-group col-md-6"">
                                <label class=""font-weight-bold"">Phone</label>
                                <input type=""tel"" class=""form-control"" name=""phoneSupplier""");
            BeginWriteAttribute("required", " required=\"", 2618, "\"", 2629, 0);
            EndWriteAttribute();
            WriteLiteral(" placeholder=\"Enter phone supplier\">\r\n                                ");
#nullable restore
#line 50 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\CreateSupplier.cshtml"
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
#line 58 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\CreateSupplier.cshtml"
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
