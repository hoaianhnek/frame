#pragma checksum "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\CategoryManagement.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4434818fe4afc8e3471c5675a7d1598fb5cd2f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_CategoryManagement), @"mvc.1.0.view", @"/Views/Admin/CategoryManagement.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4434818fe4afc8e3471c5675a7d1598fb5cd2f8", @"/Views/Admin/CategoryManagement.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"708e4e3a9a23fd4ed811fb1d18518f4bb2b5726d", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_CategoryManagement : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\CategoryManagement.cshtml"
  
    ViewData["Title"] = "Dashboard";
    Layout = "~/Views/SharedAdmin/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"right_col\" role=\"main\">\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 142, "\"", 150, 0);
            EndWriteAttribute();
            WriteLiteral(@">
        <div class=""page-title"">
            <div class=""title_left"">
                <h4>CATEGORY MANAGEMENT</h4>
            </div>
            <div class=""title_right"">
                <div class=""col-md-5 col-sm-5   form-group pull-right top_search"">
                    <div class=""input-group"">
                        <input type=""text"" class=""form-control"" id=""searchCategory"" placeholder=""Search for..."">
                        <span class=""input-group-btn"">
                            <button class=""btn btn-default"" type=""button"">Go!</button>
                        </span>
                    </div>
                </div>
            </div>
        </div>
        <div class=""clearfix""></div>
        <div class=""row"" style=""display: flex"">
            <div class=""col-md-6 col-sm-6"" style=""height:100vh"">
                <div class=""x_panel"">
                    <div class=""x_title"">
                        <h2>Category</h2>
                        <div class=""clearfix""></div>
  ");
            WriteLiteral("                  </div>\r\n                        <p>\r\n                          ");
#nullable restore
#line 31 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\CategoryManagement.cshtml"
                     Write(Html.ActionLink("Create New", "CreateCategory"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n");
#nullable restore
#line 33 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\CategoryManagement.cshtml"
                         if(TempData["StatusUpdate"] != null) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"alert alert-success alert-dismissible\">\r\n                            <button type=\"button\" class=\"close\" data-dismiss = \"alert\">&times;</button>\r\n                            ");
#nullable restore
#line 36 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\CategoryManagement.cshtml"
                       Write(TempData["StatusUpdate"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 38 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\CategoryManagement.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\CategoryManagement.cshtml"
                         if(TempData["StatusCreate"] != null) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"alert alert-success alert-dismissible\">\r\n                            <button type=\"button\" class=\"close\" data-dismiss = \"alert\">&times;</button>\r\n                            ");
#nullable restore
#line 42 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\CategoryManagement.cshtml"
                       Write(TempData["StatusCreate"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 44 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\CategoryManagement.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\CategoryManagement.cshtml"
                         if(TempData["StatusDelete"] != null) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"alert alert-success alert-dismissible\">\r\n                            <button type=\"button\" class=\"close\" data-dismiss = \"alert\">&times;</button>\r\n                            ");
#nullable restore
#line 48 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\CategoryManagement.cshtml"
                       Write(TempData["StatusDelete"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 50 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\CategoryManagement.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""x_content"">
                            <table class= ""table"">
                                <thead>
                                    <tr>
                                        <th>
                                            ID Category
                                        </th>
                                        <th>
                                            Name Category
                                        </th>
                                        <th>Manipulation</th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 65 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\CategoryManagement.cshtml"
                                     foreach (var item in Model)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 69 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\CategoryManagement.cshtml"
                                       Write(item.idCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 72 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\CategoryManagement.cshtml"
                                       Write(item.nameCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                            \r\n                                        <td class=\"actionAdmin\">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 3711, "\"", 3756, 2);
            WriteAttributeValue("", 3718, "/Admin/DeleteCategory/", 3718, 22, true);
#nullable restore
#line 76 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\CategoryManagement.cshtml"
WriteAttributeValue("", 3740, item.idCategory, 3740, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btnSubmit\">\r\n                                                <i class=\"fa fa-trash\"></i>\r\n                                            </a>\r\n                                            |\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 3998, "\"", 4046, 2);
            WriteAttributeValue("", 4005, "../../Admin/EditCategory/", 4005, 25, true);
#nullable restore
#line 80 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\CategoryManagement.cshtml"
WriteAttributeValue("", 4030, item.idCategory, 4030, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                <i class=\"fa fa-edit\"></i>\r\n                                            </a>\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 85 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\CategoryManagement.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<script>
	$('.btnSubmit').click(function() {
		var x = confirm(""Are you sure you want to delete?"");
		if(x) return true;
		else return false;
	});
</script>");
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