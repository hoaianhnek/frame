#pragma checksum "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\UpdateDiscount.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5b901bdd27f6bbc7c8945d1b45f455c14ee1586"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_UpdateDiscount), @"mvc.1.0.view", @"/Views/Admin/UpdateDiscount.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5b901bdd27f6bbc7c8945d1b45f455c14ee1586", @"/Views/Admin/UpdateDiscount.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"708e4e3a9a23fd4ed811fb1d18518f4bb2b5726d", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_UpdateDiscount : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\UpdateDiscount.cshtml"
  
    ViewBag.Title = "Add Customer";
    Layout = "~/Views/SharedAdmin/_Layout.cshtml";
    var discount = ViewBag.discount;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\UpdateDiscount.cshtml"
  
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
#line 17 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\UpdateDiscount.cshtml"
 if(users == null) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h5 class=\"text-danger mt-5 d-flex justify-content-center\">Bạn không có quyền vào trang này. Vui lòng <a class=\"text-light ml-1\"href=\"../../Admin/AccountAdmin\"> đăng nhập</a></h5>\r\n");
#nullable restore
#line 19 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\UpdateDiscount.cshtml"
} else {  

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""right_col"" role=""main"">
    <div class=""EditCategory"">
        <div class=""page-title"">
            <div class=""title_left"">
                <h4>QUẢN LÝ KHUYẾN MÃI</h4>
            </div>
        </div>
        <div class=""clearfix""></div>
        <div class=""row"" style=""display: flex"">
            <div class=""col-md-6 col-sm-6  "" style=""height:100vh"">
                <div class=""x_panel"">
                    <div class=""x_title"">
                        <h2>Sửa Khuyến Mãi</h2>
                        <div class=""clearfix""></div>
                    </div>
");
#nullable restore
#line 35 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\UpdateDiscount.cshtml"
                     using (Html.BeginForm())
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\UpdateDiscount.cshtml"
                   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\UpdateDiscount.cshtml"
                   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""form-row""> 
                            <div class=""form-group col-md-6"">
                                <label class=""font-weight-bold"">Mã</label>
                                <input type=""text"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 1749, "\"", 1777, 1);
#nullable restore
#line 42 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\UpdateDiscount.cshtml"
WriteAttributeValue("", 1757, discount.idDiscount, 1757, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled>\r\n                                <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 1842, "\"", 1870, 1);
#nullable restore
#line 43 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\UpdateDiscount.cshtml"
WriteAttributeValue("", 1850, discount.idDiscount, 1850, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" name=""idDiscount"" />
                            </div> 
                            <div class=""form-group col-md-6"">
                                <label class=""font-weight-bold"">Số(%)</label>
                                <input type=""number""pattern=""[+][0-9]""  class=""form-control""");
            BeginWriteAttribute("value", "value=\"", 2165, "\"", 2196, 1);
#nullable restore
#line 47 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\UpdateDiscount.cshtml"
WriteAttributeValue("", 2172, discount.numberDiscount, 2172, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("  name=\"numberDiscount\"");
            BeginWriteAttribute("required", " required=\"", 2220, "\"", 2231, 0);
            EndWriteAttribute();
            WriteLiteral(@" placeholder=""Nhập số khuyến mãi"">

                            </div>
                        </div>
                        <div class=""form-row"">
                            <div class=""form-group col-md-6"">
                                <label class=""font-weight-bold"">Tên</label>
                                <input type=""text"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 2597, "\"", 2627, 1);
#nullable restore
#line 54 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\UpdateDiscount.cshtml"
WriteAttributeValue("", 2605, discount.nameDiscount, 2605, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"nameDiscount\"");
            BeginWriteAttribute("required", " required=\"", 2648, "\"", 2659, 0);
            EndWriteAttribute();
            WriteLiteral(@" placeholder=""Nhập tên chương trình khuyến mãi"">
                            </div>
                        </div>
                        <div class=""form-row"">
                            <div class=""form-group col-md-6"">
                                <label class=""font-weight-bold"">Số lượng</label>
                                <input type=""number"" pattern=""[+][0-9]"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 3063, "\"", 3092, 1);
#nullable restore
#line 60 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\UpdateDiscount.cshtml"
WriteAttributeValue("", 3071, discount.quantityDis, 3071, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"quantityDis\"");
            BeginWriteAttribute("required", " required=\"", 3112, "\"", 3123, 0);
            EndWriteAttribute();
            WriteLiteral(@" placeholder=""Nhập số lượng khuyến mãi"">
                            </div>
                        </div>
                        <div class=""form-row"">
                            <div class=""form-group col-md-6"">
                                <label class=""font-weight-bold"">Ngày bắt đầu</label>
                                <input type=""date"" class=""form-control""");
            BeginWriteAttribute("value", " value=\'", 3502, "\'", 3552, 1);
#nullable restore
#line 66 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\UpdateDiscount.cshtml"
WriteAttributeValue("", 3510, discount.dateStart.ToString("yyyy-MM-dd"), 3510, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"dateStart\"");
            BeginWriteAttribute("required", " required=\"", 3570, "\"", 3581, 0);
            EndWriteAttribute();
            WriteLiteral(@" placeholder=""Nhập ngày bắt đầu"">
                            </div>
                            <div class=""form-group col-md-6"">
                                <label class=""font-weight-bold"">Ngày kết thúc</label>
                                <input type=""date"" class=""form-control""");
            BeginWriteAttribute("value", " value=\'", 3874, "\'", 3922, 1);
#nullable restore
#line 70 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\UpdateDiscount.cshtml"
WriteAttributeValue("", 3882, discount.dateEnd.ToString("yyyy-MM-dd"), 3882, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"dateEnd\"");
            BeginWriteAttribute("required", " required=\"", 3938, "\"", 3949, 0);
            EndWriteAttribute();
            WriteLiteral(" placeholder=\"Nhập ngày kết thúc\">\r\n                                <div class=\"text-danger\">");
#nullable restore
#line 71 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\UpdateDiscount.cshtml"
                                                    Write(TempData["errorDateEnd"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            </div>\r\n                        </div>\r\n");
            WriteLiteral(@"                        <br>
                        <div class=""modal-footer"">
                            <a href=""/Admin/DiscountManagement"" name=""submit-cancel"" class=""btn btn-danger"">Hủy</a>
                            <input type=""submit"" name=""submit-save"" class=""btn btn-success"" value=""Lưu"" />
                        </div>
");
#nullable restore
#line 80 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\UpdateDiscount.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 86 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\UpdateDiscount.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
