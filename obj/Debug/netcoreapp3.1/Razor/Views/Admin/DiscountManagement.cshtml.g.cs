#pragma checksum "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\DiscountManagement.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78a0508c6b7f0a4ab0b43b66123b3305d4cb3f48"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_DiscountManagement), @"mvc.1.0.view", @"/Views/Admin/DiscountManagement.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78a0508c6b7f0a4ab0b43b66123b3305d4cb3f48", @"/Views/Admin/DiscountManagement.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"708e4e3a9a23fd4ed811fb1d18518f4bb2b5726d", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_DiscountManagement : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\DiscountManagement.cshtml"
  
    ViewData["Title"] = "Dashboard";
    Layout = "~/Views/SharedAdmin/_Layout.cshtml";
    var discount = ViewBag.discount;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\DiscountManagement.cshtml"
  
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
#line 17 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\DiscountManagement.cshtml"
 if(users == null) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h5 class=\"text-danger mt-5 d-flex justify-content-center\">Bạn không có quyền vào trang này. Vui lòng <a class=\"text-light ml-1\"href=\"../../Admin/AccountAdmin\"> đăng nhập</a></h5>\r\n");
#nullable restore
#line 19 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\DiscountManagement.cshtml"
} else {  

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"right_col\" role=\"main\">\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 735, "\"", 743, 0);
            EndWriteAttribute();
            WriteLiteral(@">
        <div class=""page-title"">
            <div class=""title_left"">
                <h4>QUẢN LÝ KHUYẾN MÃI</h4>
            </div>
            <div class=""title_right"">
                <div class=""col-md-5 col-sm-5   form-group pull-right top_search"">
                    <div class=""input-group"">
                        <input type=""text"" class=""form-control"" id=""searchDiscount"" placeholder=""Tên khuyến mãi..."">
                        <span class=""input-group-btn"">
                            <button class=""btn btn-default"" type=""button"">Go!</button>
                        </span>
                    </div>
                </div>
            </div>
        </div>
        <div class=""clearfix""></div>
        <div class=""row"" style=""display: flex;"">
            <div class=""col-md-6 col-sm-6  "" style=""height:100vh"">
                <div class=""x_panel"">
                    <div class=""x_title"">
                        <h2>Khuyến Mãi</h2>
                        <div class=""clearfix""></");
            WriteLiteral("div>\r\n                    </div>\r\n                     <p>\r\n                        ");
#nullable restore
#line 46 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\DiscountManagement.cshtml"
                   Write(Html.ActionLink("Tạo Mới", "AddDiscount"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n");
#nullable restore
#line 48 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\DiscountManagement.cshtml"
                     if(TempData["StatusUpdate"] != null) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"alert alert-success alert-dismissible\">\r\n                        <button type=\"button\" class=\"close\" data-dismiss = \"alert\">&times;</button>\r\n                        ");
#nullable restore
#line 51 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\DiscountManagement.cshtml"
                   Write(TempData["StatusUpdate"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 53 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\DiscountManagement.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\DiscountManagement.cshtml"
                     if(TempData["StatusCreate"] != null) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"alert alert-success alert-dismissible\">\r\n                        <button type=\"button\" class=\"close\" data-dismiss = \"alert\">&times;</button>\r\n                        ");
#nullable restore
#line 57 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\DiscountManagement.cshtml"
                   Write(TempData["StatusCreate"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 59 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\DiscountManagement.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\DiscountManagement.cshtml"
                     if(TempData["StatusDelete"] != null) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"alert alert-success alert-dismissible\">\r\n                        <button type=\"button\" class=\"close\" data-dismiss = \"alert\">&times;</button>\r\n                        ");
#nullable restore
#line 63 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\DiscountManagement.cshtml"
                   Write(TempData["StatusDelete"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 65 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\DiscountManagement.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""x_content"">
                        <table class=""table"">
                            <thead>
                                <tr>
                                    <th>Mã</th>
                                    <th>Tên</th>
                                    <th>Số lượng</th>
                                    <th>Ngày bắt đầu</th>
                                    <th>Ngàu kết thúc</th>
                                    <th>Số(%)</th>
                                    <th>Hành động</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 80 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\DiscountManagement.cshtml"
                                 foreach (var d in discount)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <th scope=\"row\">");
#nullable restore
#line 83 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\DiscountManagement.cshtml"
                                                   Write(d.idDiscount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                        <td>");
#nullable restore
#line 84 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\DiscountManagement.cshtml"
                                       Write(d.nameDiscount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 85 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\DiscountManagement.cshtml"
                                       Write(d.quantityDis);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 86 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\DiscountManagement.cshtml"
                                       Write(d.dateStart.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 87 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\DiscountManagement.cshtml"
                                       Write(d.dateEnd.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 88 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\DiscountManagement.cshtml"
                                       Write(d.numberDiscount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td class=\"actionAdmin\">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 4291, "\"", 4333, 2);
            WriteAttributeValue("", 4298, "/Admin/DiscountDelete/", 4298, 22, true);
#nullable restore
#line 90 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\DiscountManagement.cshtml"
WriteAttributeValue("", 4320, d.idDiscount, 4320, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btnSubmit\">\r\n                                                <i class=\"fa fa-trash\"></i>\r\n                                            </a>\r\n                                            |\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 4575, "\"", 4617, 2);
            WriteAttributeValue("", 4582, "/Admin/UpdateDiscount/", 4582, 22, true);
#nullable restore
#line 94 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\DiscountManagement.cshtml"
WriteAttributeValue("", 4604, d.idDiscount, 4604, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                <i class=\"fa fa-edit\"></i>\r\n                                            </a>\r\n                                        </td>\r\n                                    </tr> \r\n");
#nullable restore
#line 99 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\DiscountManagement.cshtml"
                                   
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 109 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\DiscountManagement.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<script>\r\n\t$(\'.btnSubmit\').click(function() {\r\n\t\tvar x = confirm(\"Bạn thật sự muốn xóa khuyến mãi?\");\r\n\t\tif(x) return true;\r\n\t\telse return false;\r\n\t});\r\n</script>");
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
