#pragma checksum "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\OrderManagement.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6b249be37f640296cc982138fa2d0307876700b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_OrderManagement), @"mvc.1.0.view", @"/Views/Admin/OrderManagement.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6b249be37f640296cc982138fa2d0307876700b", @"/Views/Admin/OrderManagement.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"708e4e3a9a23fd4ed811fb1d18518f4bb2b5726d", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_OrderManagement : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\OrderManagement.cshtml"
  
    ViewData["Title"] = "Dashboard";
    Layout = "~/Views/SharedAdmin/_Layout.cshtml";
    double tongtien = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\OrderManagement.cshtml"
  
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
#line 17 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\OrderManagement.cshtml"
 if(users == null) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h5 class=\"text-danger mt-5 d-flex justify-content-center\">Bạn không có quyền vào trang này. Vui lòng <a class=\"text-light ml-1\"href=\"../../Admin/AccountAdmin\"> đăng nhập</a></h5>\r\n");
#nullable restore
#line 19 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\OrderManagement.cshtml"
} else {  

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"right_col\" role=\"main\">\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 723, "\"", 731, 0);
            EndWriteAttribute();
            WriteLiteral(@">
        <div class=""page-title"">
            <div class=""title_left"">
                <h4>QUẢN LÝ HÓA ĐƠN</h4>
            </div>
            <div class=""title_right"">
                <div class=""col-md-5 col-sm-5   form-group pull-right top_search"">
                    <div class=""input-group"">
                        <select style=""
                                font-size: 21px;
                                font-family: roboto;
                                background: aliceblue;
                                border-radius: 5px;padding: 0 10px;
                            "" id=""statusOrder"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b6b249be37f640296cc982138fa2d0307876700b5274", async() => {
                WriteLiteral("--Chọn trạng thái giao hàng--");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 36 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\OrderManagement.cshtml"
                             foreach (var item in ViewBag.statusOrder)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b6b249be37f640296cc982138fa2d0307876700b6576", async() => {
#nullable restore
#line 38 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\OrderManagement.cshtml"
                                             Write(item);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 38 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\OrderManagement.cshtml"
                               WriteLiteral(item);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 39 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\OrderManagement.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </select>
                    </div>
                </div>
            </div>
        </div>
        <div class=""clearfix""></div>
        <div class=""row"" style=""display: flex;"">
            <div class=""col-md-6 col-sm-6  "" style=""height:100vh"">
                <div class=""x_panel"">
                    <div class=""x_title"">
                        <h2>Hóa Đơn</h2>
                        <div class=""clearfix""></div>
                    </div>
                    <div class=""x_content"">
                        <table class=""table table-striped b-t b-light"">
                            <thead>
                                <tr>
                                    <th data-breakpoints=""xs"" scope=""col"">SHD</th>
                                    <th>Tên khách hàng</th>
                                    <th>Ngày đặt hàng</th>
                                    <th>Địa chỉ</th>
                                    <th>Chi tiết SP</th>
                             ");
            WriteLiteral(@"       <th>Phí ship</th>
                                    <th>Tổng tiền</th>
                                    <th>Trạng thái</th>
                                    <th scope=""col"" style=""width:120px"">Hành động</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 69 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\OrderManagement.cshtml"
                                 foreach (var item in ViewBag.orders)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td scope=\"row\">");
#nullable restore
#line 72 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\OrderManagement.cshtml"
                                               Write(item.idOrder);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td><span class=\"text-ellipsis\">\r\n");
#nullable restore
#line 74 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\OrderManagement.cshtml"
                                         foreach (var cus in ViewBag.customers)
                                        {
                                            if(cus.idCustomer == item.idCustomer) {
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\OrderManagement.cshtml"
                                           Write(cus.nameCustomer);

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\OrderManagement.cshtml"
                                                                 
                                            }
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </span></td>\r\n                                    <td><span class=\"text-ellipsis\">");
#nullable restore
#line 81 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\OrderManagement.cshtml"
                                                               Write(item.dateOrder.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n                                    <td><span class=\"text-ellipsis\">\r\n");
#nullable restore
#line 83 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\OrderManagement.cshtml"
                                         foreach (var cus in ViewBag.customers)
                                        {
                                            if(cus.idCustomer == item.idCustomer) {
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\OrderManagement.cshtml"
                                           Write(cus.addressCustomer);

#line default
#line hidden
#nullable disable
            WriteLiteral("<span> - </span>\r\n");
#nullable restore
#line 87 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\OrderManagement.cshtml"
                                                foreach (var s in ViewBag.shippings)
                                                {
                                                    if(s.idShip == cus.idShip) {
                                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 90 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\OrderManagement.cshtml"
                                                   Write(s.country);

#line default
#line hidden
#nullable disable
#nullable restore
#line 90 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\OrderManagement.cshtml"
                                                                  
                                                    }
                                                }
                                            }
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </span></td>
                                    <td>
                                        <table width=""auto"" border=""0"">
                                            <tr>
                                                <td>Tên sách</td>
                                                <td>Số lượng</td>
                                                <td>Giá</td>
                                            </tr>
");
#nullable restore
#line 103 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\OrderManagement.cshtml"
                                             foreach (var od in ViewBag.orderdetails)
                                            {
                                                if(od.idOrder == item.idOrder) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr>\r\n                                                        <td>\r\n");
#nullable restore
#line 108 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\OrderManagement.cshtml"
                                                             foreach (var b in ViewBag.books)
                                                            {
                                                                if(b.idBook==od.idBook) {
                                                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 111 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\OrderManagement.cshtml"
                                                               Write(b.nameBook);

#line default
#line hidden
#nullable disable
#nullable restore
#line 111 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\OrderManagement.cshtml"
                                                                               
                                                                }
                                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        </td>\r\n                                                        <td>");
#nullable restore
#line 115 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\OrderManagement.cshtml"
                                                       Write(od.quantityBook);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>$");
#nullable restore
#line 116 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\OrderManagement.cshtml"
                                                        Write(od.priceOrder);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 117 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\OrderManagement.cshtml"
                                                          tongtien += od.priceOrder * od.quantityBook;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    </tr>\r\n");
#nullable restore
#line 119 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\OrderManagement.cshtml"
                                                }
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            \r\n                                        </table>\r\n                                    </td>\r\n                                    <td>\r\n");
#nullable restore
#line 125 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\OrderManagement.cshtml"
                                         foreach (var cus in ViewBag.customers)
                                        {
                                            if(cus.idCustomer == item.idCustomer) {
                                                foreach (var s in ViewBag.shippings)
                                                {
                                                    if(s.idShip == cus.idShip) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                       <span>");
#nullable restore
#line 131 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\OrderManagement.cshtml"
                                                        Write(s.charge);

#line default
#line hidden
#nullable disable
            WriteLiteral("$</span> \r\n");
#nullable restore
#line 132 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\OrderManagement.cshtml"
                                                       tongtien += s.charge;
                                                    }
                                                }
                                            }
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </td>\r\n                                    <td>");
#nullable restore
#line 138 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\OrderManagement.cshtml"
                                   Write(tongtien);

#line default
#line hidden
#nullable disable
            WriteLiteral("$</td>\r\n                                    <td>");
#nullable restore
#line 139 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\OrderManagement.cshtml"
                                   Write(item.status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 141 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\OrderManagement.cshtml"
                                     if(item.status == "Đang giao hàng" || item.status == "Đã hủy đơn") {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td><a class=\"btn float-right Invoicedis\" disabled>Hóa Đơn</a></td>\r\n");
#nullable restore
#line 143 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\OrderManagement.cshtml"
                                    } else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td><a class=\"btn float-right Invoice\" data-id=\"");
#nullable restore
#line 144 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\OrderManagement.cshtml"
                                                                                   Write(item.idOrder);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Hóa Đơn</a></td>\r\n");
#nullable restore
#line 145 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\OrderManagement.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tr> \r\n");
#nullable restore
#line 147 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\OrderManagement.cshtml"
                                tongtien=0;
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                \r\n                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 158 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\OrderManagement.cshtml"
}

#line default
#line hidden
#nullable disable
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
