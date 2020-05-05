#pragma checksum "C:\Users\QuachPhuong\Documents\GitHub\frame\Views\Admin\BookManagement.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92169f76919fb0cdc1fa7f4ffc3786372423c745"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_BookManagement), @"mvc.1.0.view", @"/Views/Admin/BookManagement.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92169f76919fb0cdc1fa7f4ffc3786372423c745", @"/Views/Admin/BookManagement.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"708e4e3a9a23fd4ed811fb1d18518f4bb2b5726d", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_BookManagement : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<frame.Models.Book>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\QuachPhuong\Documents\GitHub\frame\Views\Admin\BookManagement.cshtml"
  
    ViewData["Title"] = "Dashboard";
    Layout = "~/Views/SharedAdmin/_Layout.cshtml";
    var categories = ViewBag.categories;
    var  authors = ViewBag.authors ;
    var discounts = ViewBag.discounts;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <!-- /top navigation -->\r\n    <!-- page content -->\r\n    <div class=\"right_col\" role=\"main\">\r\n        <div");
            BeginWriteAttribute("class", " class=\"", 368, "\"", 376, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            <div class=""page-title"">
                <div class=""title_left"">
                    <h4>BOOKS MANAGEMENT</h4>
                </div>
                <div class=""title_right"">
                    <div class=""col-md-5 col-sm-5   form-group pull-right top_search"">
                        <div class=""input-group"">
                            <input type=""text"" class=""form-control"" placeholder=""Search for..."">
                            <span class=""input-group-btn"">
                                <button class=""btn btn-default"" type=""button"">Go!</button>
                            </span>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""clearfix""></div>
            <div class=""row"" style=""display: block;"">
                <div class=""col-md-6 col-sm-6  "">
                    <div class=""x_panel"">
                        <div class=""x_title"">
                            <h2> BOOKS <small>Book Manageme");
            WriteLiteral(@"nt Tables</small></h2>
                            <ul class=""nav navbar-right panel_toolbox"">
                                <li>
                                    <a class=""collapse-link""><i class=""fa fa-chevron-up""></i></a>
                                </li>
                                <li class=""dropdown"">
                                    <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"" role=""button"" aria-expanded=""false""><i class=""fa fa-wrench""></i></a>
                                    <div class=""dropdown-menu"" aria-labelledby=""dropdownMenuButton"">
                                        <a class=""dropdown-item"" href=""#"">Settings 1</a>
                                        <a class=""dropdown-item"" href=""#"">Settings 2</a>
                                    </div>
                                </li>
                                <li>
                                    <a class=""close-link""><i class=""fa fa-close""></i></a>
                                </li>");
            WriteLiteral(@"
                            </ul>
                            <div class=""clearfix""></div>
                        </div>
                        <div class =""Create"">
                            <button name=""button_Create"" type=""button"">Create</button>
                        </div>
                        
                        <div class=""x_content"">
                            <table class= ""table"">
	<tr>
		<th>
			ID
		</th>
		<th>
			Name 
		</th>
        <th>
			Image
		</th>
        <th>
			Describe
		</th>
        <th>
			Summary
		</th>
        <th>
			Price
		</th>
        <th>
			Category
		</th>
        <th>
			Amount
		</th>
        <th>
			Publishing Year
		</th>
        <th>
			PageCount
		</th>
        <th>
			Publisher
		</th>
        <th>
			Author
		</th>
        <th>
			Discount
		</th>
        <th>
			Image Back Book
		</th>
		<th></th>
	</tr>

");
#nullable restore
#line 104 "C:\Users\QuachPhuong\Documents\GitHub\frame\Views\Admin\BookManagement.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<tr>\r\n\t\t<td>\r\n\t\t\t");
#nullable restore
#line 108 "C:\Users\QuachPhuong\Documents\GitHub\frame\Views\Admin\BookManagement.cshtml"
       Write(Html.DisplayFor(modelItem => item.idBook));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</td>\r\n\t\t<td>\r\n\t\t\t");
#nullable restore
#line 111 "C:\Users\QuachPhuong\Documents\GitHub\frame\Views\Admin\BookManagement.cshtml"
       Write(Html.DisplayFor(modelItem => item.nameBook));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</td>\r\n        <td>\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 3564, "\"", 3596, 2);
            WriteAttributeValue("", 3570, "../../images/", 3570, 13, true);
#nullable restore
#line 114 "C:\Users\QuachPhuong\Documents\GitHub\frame\Views\Admin\BookManagement.cshtml"
WriteAttributeValue("", 3583, item.imgBook, 3583, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 3597, "\"", 3617, 1);
#nullable restore
#line 114 "C:\Users\QuachPhuong\Documents\GitHub\frame\Views\Admin\BookManagement.cshtml"
WriteAttributeValue("", 3603, item.nameBook, 3603, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"64\"\r\n            height=\"92\">\r\n\t\t</td>\r\n        <td>\r\n            <p class = \"content_DesBook\">\r\n                ");
#nullable restore
#line 119 "C:\Users\QuachPhuong\Documents\GitHub\frame\Views\Admin\BookManagement.cshtml"
           Write(Html.DisplayFor(modelItem => item.desBook));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\t\t\r\n\t\t</td>\r\n        <td>\r\n            <p class =\"content_SumBook\">\r\n                ");
#nullable restore
#line 124 "C:\Users\QuachPhuong\Documents\GitHub\frame\Views\Admin\BookManagement.cshtml"
           Write(Html.DisplayFor(modelItem => item.summaryBook));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\t\t\t\r\n\t\t</td>\r\n        <td>\r\n\t\t\t");
#nullable restore
#line 128 "C:\Users\QuachPhuong\Documents\GitHub\frame\Views\Admin\BookManagement.cshtml"
       Write(Html.DisplayFor(modelItem => item.priceBook));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</td>\r\n        <td>\r\n");
#nullable restore
#line 131 "C:\Users\QuachPhuong\Documents\GitHub\frame\Views\Admin\BookManagement.cshtml"
             foreach(var c in categories) {
                if(c.idCategory == item.idCategory) {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 133 "C:\Users\QuachPhuong\Documents\GitHub\frame\Views\Admin\BookManagement.cshtml"
               Write(c.nameCategory);

#line default
#line hidden
#nullable disable
#nullable restore
#line 133 "C:\Users\QuachPhuong\Documents\GitHub\frame\Views\Admin\BookManagement.cshtml"
                                   ;
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t</td>\r\n        <td>\r\n\t\t\t");
#nullable restore
#line 138 "C:\Users\QuachPhuong\Documents\GitHub\frame\Views\Admin\BookManagement.cshtml"
       Write(Html.DisplayFor(modelItem => item.amountBook));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</td>\r\n        <td>\r\n\t\t\t");
#nullable restore
#line 141 "C:\Users\QuachPhuong\Documents\GitHub\frame\Views\Admin\BookManagement.cshtml"
       Write(Html.DisplayFor(modelItem => item.publishingYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</td>\r\n        <td>\r\n\t\t\t");
#nullable restore
#line 144 "C:\Users\QuachPhuong\Documents\GitHub\frame\Views\Admin\BookManagement.cshtml"
       Write(Html.DisplayFor(modelItem => item.pageCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</td>\r\n        <td>\r\n\t\t\t");
#nullable restore
#line 147 "C:\Users\QuachPhuong\Documents\GitHub\frame\Views\Admin\BookManagement.cshtml"
       Write(Html.DisplayFor(modelItem => item.publisherBook));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</td>\r\n        <td>\r\n");
#nullable restore
#line 150 "C:\Users\QuachPhuong\Documents\GitHub\frame\Views\Admin\BookManagement.cshtml"
             foreach(var a in authors) {
                if(a.idAuthor == item.idAuthor) {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 152 "C:\Users\QuachPhuong\Documents\GitHub\frame\Views\Admin\BookManagement.cshtml"
               Write(a.nameAuthor);

#line default
#line hidden
#nullable disable
#nullable restore
#line 152 "C:\Users\QuachPhuong\Documents\GitHub\frame\Views\Admin\BookManagement.cshtml"
                                 ;
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t</td>\r\n        <td>\r\n");
#nullable restore
#line 157 "C:\Users\QuachPhuong\Documents\GitHub\frame\Views\Admin\BookManagement.cshtml"
             foreach(var d in discounts) {
                if(d.idDiscount == item.idDiscount) {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 159 "C:\Users\QuachPhuong\Documents\GitHub\frame\Views\Admin\BookManagement.cshtml"
               Write(d.nameDiscount);

#line default
#line hidden
#nullable disable
#nullable restore
#line 159 "C:\Users\QuachPhuong\Documents\GitHub\frame\Views\Admin\BookManagement.cshtml"
                                   ;
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </td>\r\n            \r\n        <td>\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 4955, "\"", 4991, 2);
            WriteAttributeValue("", 4961, "../../images/", 4961, 13, true);
#nullable restore
#line 165 "C:\Users\QuachPhuong\Documents\GitHub\frame\Views\Admin\BookManagement.cshtml"
WriteAttributeValue("", 4974, item.imgBackBook, 4974, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 4992, "\"", 5012, 1);
#nullable restore
#line 165 "C:\Users\QuachPhuong\Documents\GitHub\frame\Views\Admin\BookManagement.cshtml"
WriteAttributeValue("", 4998, item.nameBook, 4998, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"64\"\r\n            height=\"92\">\r\n\t\t</td>\r\n\t\t\t\r\n\t\t<td>\r\n\t\t\t");
#nullable restore
#line 170 "C:\Users\QuachPhuong\Documents\GitHub\frame\Views\Admin\BookManagement.cshtml"
       Write(Html.ActionLink("Edit", "Edit", new {idBook=item.idBook}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n\t\t\t");
#nullable restore
#line 171 "C:\Users\QuachPhuong\Documents\GitHub\frame\Views\Admin\BookManagement.cshtml"
       Write(Html.ActionLink("Details", "Details", new {idBook=item.idBook}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n\t\t\t");
#nullable restore
#line 172 "C:\Users\QuachPhuong\Documents\GitHub\frame\Views\Admin\BookManagement.cshtml"
       Write(Html.ActionLink("Delete", "Delete", new { idBook = item.idBook}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n\t\t</td>\r\n\t</tr>\r\n");
#nullable restore
#line 175 "C:\Users\QuachPhuong\Documents\GitHub\frame\Views\Admin\BookManagement.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <!-- /page content -->\r\n    <!-- footer content -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<frame.Models.Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
