#pragma checksum "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\SupplierManagement.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ded7f7102dc21d680343c591a3a5443a4bef9055"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_SupplierManagement), @"mvc.1.0.view", @"/Views/Admin/SupplierManagement.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ded7f7102dc21d680343c591a3a5443a4bef9055", @"/Views/Admin/SupplierManagement.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"708e4e3a9a23fd4ed811fb1d18518f4bb2b5726d", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_SupplierManagement : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<frame.Models.Supplier>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\SupplierManagement.cshtml"
  
    ViewData["Title"] = "Dashboard";
    Layout = "~/Views/SharedAdmin/_Layout.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\SupplierManagement.cshtml"
  
    var sessionName = new Byte[20];
    bool ok = Context.Session.TryGetValue("login", out sessionName);
    string result = "";
    User users = null;
    if (ok)
    {
        result = System.Text.Encoding.UTF8.GetString(sessionName);
        users = Newtonsoft.Json.JsonConvert.DeserializeObject<User>(result);
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\SupplierManagement.cshtml"
 if(users == null) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h5 class=\"text-danger mt-5 d-flex justify-content-center\">Bạn không có quyền vào trang này. Vui lòng <a class=\"text-light ml-1\"href=\"../../Admin/AccountAdmin\"> đăng nhập</a></h5>\r\n");
#nullable restore
#line 19 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\SupplierManagement.cshtml"
} else {  

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"right_col\" role=\"main\">\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 740, "\"", 748, 0);
            EndWriteAttribute();
            WriteLiteral(@">
        <div class=""page-title"">
            <div class=""title_left"">
                <h4>QUẢN LÝ NHÀ CUNG CẤP</h4>
            </div>
            <div class=""title_right"">
                <div class=""col-md-5 col-sm-5 form-group pull-right top_search"">
                    <div class=""input-group"">
                        <input type=""text"" class=""form-control"" id=""searchSupplier""placeholder=""Tên NCC..."">
                        <span class=""input-group-btn"">
                            <button class=""btn btn-default"" type=""button"">Go!</button>
                        </span>
                    </div>
                </div>
            </div>
        </div>
        <div class=""clearfix""></div>
        <div class=""row"" style=""display: flex"">
            <div class=""col-md-6 col-sm-6  "" style=""height:100vh"">
                <div class=""x_panel"">
                    <div class=""x_title"">
                        <h2>Nhà Cung Cấp</h2>
                        <div class=""clearfix""></div>
 ");
            WriteLiteral("                   </div>\r\n                    <p>\r\n                    ");
#nullable restore
#line 46 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\SupplierManagement.cshtml"
               Write(Html.ActionLink("Tạo Mới", "CreateSupplier"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n");
#nullable restore
#line 48 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\SupplierManagement.cshtml"
                     if(TempData["StatusUpdate"] != null) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"alert alert-success alert-dismissible\">\r\n                        <button type=\"button\" class=\"close\" data-dismiss = \"alert\">&times;</button>\r\n                        ");
#nullable restore
#line 51 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\SupplierManagement.cshtml"
                   Write(TempData["StatusUpdate"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 53 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\SupplierManagement.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\SupplierManagement.cshtml"
                     if(TempData["StatusCreate"] != null) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"alert alert-success alert-dismissible\">\r\n                        <button type=\"button\" class=\"close\" data-dismiss = \"alert\">&times;</button>\r\n                        ");
#nullable restore
#line 57 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\SupplierManagement.cshtml"
                   Write(TempData["StatusCreate"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 59 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\SupplierManagement.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\SupplierManagement.cshtml"
                     if(TempData["StatusDelete"] != null) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"alert alert-success alert-dismissible\">\r\n                        <button type=\"button\" class=\"close\" data-dismiss = \"alert\">&times;</button>\r\n                        ");
#nullable restore
#line 63 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\SupplierManagement.cshtml"
                   Write(TempData["StatusDelete"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 65 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\SupplierManagement.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""x_content"">
                        <table class= ""table"">
                            <thead>
                                <tr>
                                    <th>Mã NCC</th>
                                    <th>Tên</th>
                                    <th>Địa Chỉ</th>
                                    <th>SĐT</th>
                                    <th>Hành Động</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 78 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\SupplierManagement.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 82 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\SupplierManagement.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.idSupplier));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 85 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\SupplierManagement.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.nameSupplier));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 88 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\SupplierManagement.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.addressSupplier));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 91 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\SupplierManagement.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.phoneSupplier));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n\r\n                                        \r\n                                     <td class=\"actionAdmin\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 4460, "\"", 4505, 2);
            WriteAttributeValue("", 4467, "/Admin/DeleteSupplier/", 4467, 22, true);
#nullable restore
#line 96 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\SupplierManagement.cshtml"
WriteAttributeValue("", 4489, item.idSupplier, 4489, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btnSubmit\">\r\n                                            <i class=\"fa fa-trash\"></i>\r\n                                        </a>\r\n                                        |\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 4731, "\"", 4779, 2);
            WriteAttributeValue("", 4738, "../../Admin/EditSupplier/", 4738, 25, true);
#nullable restore
#line 100 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\SupplierManagement.cshtml"
WriteAttributeValue("", 4763, item.idSupplier, 4763, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <i class=\"fa fa-edit\"></i>\r\n                                        </a>\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 105 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\SupplierManagement.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 114 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\SupplierManagement.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script>\r\n\t$(\'.btnSubmit\').click(function() {\r\n\t\tvar x = confirm(\"Bạn thật sự muốn xóa NCC?\");\r\n\t\tif(x) return true;\r\n\t\telse return false;\r\n\t});\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<frame.Models.Supplier>> Html { get; private set; }
    }
}
#pragma warning restore 1591
