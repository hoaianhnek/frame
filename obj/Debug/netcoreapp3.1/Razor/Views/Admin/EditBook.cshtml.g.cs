#pragma checksum "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\EditBook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa47358a76d58ca6a4b76df9402cbb2219291465"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_EditBook), @"mvc.1.0.view", @"/Views/Admin/EditBook.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa47358a76d58ca6a4b76df9402cbb2219291465", @"/Views/Admin/EditBook.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"708e4e3a9a23fd4ed811fb1d18518f4bb2b5726d", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_EditBook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\EditBook.cshtml"
  
    ViewBag.Title = "EditCategory";
    Layout = "~/Views/SharedAdmin/_Layout.cshtml";
    var Category = ViewBag.Category;
    var book = ViewBag.books;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""right_col"" role=""main"">
    <div class=""EditCategory"">
        <div class=""page-title"">
            <div class=""title_left"">
                <h4>BOOK MANAGEMENT</h4>
            </div>
        </div>
        <div class=""clearfix""></div>
        <div class=""row"" style=""display: flex"">
            <div class=""col-md-6 col-sm-6  "" style=""height:100vh"">
                <div class=""x_panel"">
                    <div class=""x_title"">
                        <h2>Edit Book</h2>
                        <div class=""clearfix""></div>
                    </div>
");
#nullable restore
#line 22 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\EditBook.cshtml"
                     using (Html.BeginForm())
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\EditBook.cshtml"
                   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\EditBook.cshtml"
                   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""form-row""> 
                            <div class=""form-group col-md-2"">
                                <label class=""font-weight-bold"">ID Book</label>
                                <input type=""text"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 1222, "\"", 1242, 1);
#nullable restore
#line 29 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\EditBook.cshtml"
WriteAttributeValue("", 1230, book.idBook, 1230, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled>\r\n                                <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 1307, "\"", 1327, 1);
#nullable restore
#line 30 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\EditBook.cshtml"
WriteAttributeValue("", 1315, book.idBook, 1315, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" name=""idBook""/>
                            </div> 
                            <div class=""form-group col-md-5"">
                                <div class=""form-group col-md-5"">
                                    <label class=""font-weight-bold"">Image Front</label>
                                    <input type=""file"" style = ""width:117px""class=""form-control hinhanhsach border-0""name=""imgBook"" id=""imageTruoc"">
                                </div>
                                <div class=""form-group col-md-6"">
                                    <img");
            BeginWriteAttribute("src", " src=\"", 1899, "\"", 1931, 2);
            WriteAttributeValue("", 1905, "../../images/", 1905, 13, true);
#nullable restore
#line 38 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\EditBook.cshtml"
WriteAttributeValue("", 1918, book.imgBook, 1918, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" id = ""show-mattruoc"" width=""auto""
                                    height=""90px"">
                                </div>
                            </div>
                            <div class=""form-group col-md-5"">
                                <div class=""form-group col-md-5"">
                                    <label class=""font-weight-bold"">Image Back</label>
                                    <input type=""file"" style = ""width:117px"" class=""form-control hinhanhsach border-0"" name=""imgBackBook"" id=""imageSau"">
                                </div>
                                <div class=""form-group col-md-6"">
                                    <img");
            BeginWriteAttribute("src", " src=\"", 2615, "\"", 2651, 2);
            WriteAttributeValue("", 2621, "../../images/", 2621, 13, true);
#nullable restore
#line 48 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\EditBook.cshtml"
WriteAttributeValue("", 2634, book.imgBackBook, 2634, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" id = ""show-sau"" width=""auto""
                                    height=""90px"">
                                </div>
                            </div>
                        </div>  
                        <div class=""form-row"">
                            <div class=""form-group col-md-4"">
                                <label class=""font-weight-bold"">Name Book</label>
                                <input type=""text"" class=""form-control"" pattern=""^[A-Za-z0-9-\s]*"" title=""Name should without accents""");
            BeginWriteAttribute("value", "value=\"", 3173, "\"", 3194, 1);
#nullable restore
#line 56 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\EditBook.cshtml"
WriteAttributeValue("", 3180, book.nameBook, 3180, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("required", "required=\"", 3195, "\"", 3205, 0);
            EndWriteAttribute();
            WriteLiteral(@" name=""nameBook"" placeholder=""Nhập tên sách"">
                            </div>   
                            <div class=""form-group col-md-4"">
                                <label class=""font-weight-bold"">Price</label>
                                <input type=""number""pattern=""[+][0-9]""");
            BeginWriteAttribute("value", " value=\"", 3504, "\"", 3527, 1);
#nullable restore
#line 60 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\EditBook.cshtml"
WriteAttributeValue("", 3512, book.priceBook, 3512, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("min=\'1\'class=\"form-control\"");
            BeginWriteAttribute("required", "required=\"", 3555, "\"", 3565, 0);
            EndWriteAttribute();
            WriteLiteral(@" name=""priceBook"" placeholder=""Nhập giá sách"">
                            </div>   
                            <div class=""form-group col-md-4"">
                                <label class=""font-weight-bold"">Quantity</label>
                                <input type=""number""pattern=""[+][0-9]""");
            BeginWriteAttribute("value", " value=\"", 3868, "\"", 3892, 1);
#nullable restore
#line 64 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\EditBook.cshtml"
WriteAttributeValue("", 3876, book.amountBook, 3876, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("class=\"form-control\"");
            BeginWriteAttribute("required", "required=\"", 3913, "\"", 3923, 0);
            EndWriteAttribute();
            WriteLiteral(@" name=""amountBook"" placeholder=""Nhập số lượng"">
                            </div>   
                        </div>
                        <div class=""form-row"">
                            <div class=""form-group col-md-6"">
                                <label class=""font-weight-bold"">Category</label>
                                <select class=""form-control m-bot15"" name=""idCategory"">
");
#nullable restore
#line 71 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\EditBook.cshtml"
                                     foreach (var item in ViewBag.categories )
                                    {
                                        if(item.idCategory == book.idCategory) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa47358a76d58ca6a4b76df9402cbb221929146511455", async() => {
#nullable restore
#line 74 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\EditBook.cshtml"
                                                                        Write(item.nameCategory);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 74 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\EditBook.cshtml"
                                               WriteLiteral(item.idCategory);

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
#line 75 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\EditBook.cshtml"
                                        } else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa47358a76d58ca6a4b76df9402cbb221929146513574", async() => {
#nullable restore
#line 76 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\EditBook.cshtml"
                                                                        Write(item.nameCategory);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 76 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\EditBook.cshtml"
                                               WriteLiteral(item.idCategory);

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
#line 77 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\EditBook.cshtml"
                                        }
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    \r\n                                   \r\n                                </select>\r\n                                <div class=\"text-danger\">");
#nullable restore
#line 82 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\EditBook.cshtml"
                                                    Write(TempData["ErrorCategory"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                            </div>   
                            <div class=""form-group col-md-6"">
                                <label class=""font-weight-bold"">Author</label>
                                <select class=""form-control m-bot15"" name=""idAuthor"">
");
#nullable restore
#line 87 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\EditBook.cshtml"
                                     foreach (var item in ViewBag.authors)
                                    {
                                       if(item.idAuthor == book.idAuthor) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                           ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa47358a76d58ca6a4b76df9402cbb221929146516838", async() => {
#nullable restore
#line 90 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\EditBook.cshtml"
                                                                     Write(item.nameAuthor);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 90 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\EditBook.cshtml"
                                              WriteLiteral(item.idAuthor);

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
#line 91 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\EditBook.cshtml"
                                       } else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                           ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa47358a76d58ca6a4b76df9402cbb221929146518947", async() => {
#nullable restore
#line 92 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\EditBook.cshtml"
                                                                     Write(item.nameAuthor);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 92 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\EditBook.cshtml"
                                              WriteLiteral(item.idAuthor);

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
#line 93 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\EditBook.cshtml"
                                       }
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    \r\n                                    \r\n                                </select>\r\n                                <div class=\"text-danger\">");
#nullable restore
#line 98 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\EditBook.cshtml"
                                                    Write(TempData["ErrorAuthor"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                            </div>   
                        </div>
                        <div class=""form-row"">
                            <div class=""form-group col-md-8"">
                                <div class=""form-row"">
                                    <div class=""form-group col-md-6"">
                                        <label class=""col-form-label font-weight-bold des"">Descripe</label>
                                        <textarea class=""form-control des""");
            BeginWriteAttribute("required", " required=\"", 6573, "\"", 6584, 0);
            EndWriteAttribute();
            WriteLiteral("rows=\"3\" pattern=\"^[A-Za-z0-9-\\s]*\" title=\"Describe should without accents\" name=\"desBook\" style=\"width:100%\">");
#nullable restore
#line 106 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\EditBook.cshtml"
                                                                                                                                                                                               Write(book.desBook);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</textarea>
                                    </div>
                                    <div class=""form-group col-md-6"">
                                        <label class=""col-form-label font-weight-bold des"">Summary</label>
                                        <textarea class=""form-control des""");
            BeginWriteAttribute("required", " required=\"", 7018, "\"", 7029, 0);
            EndWriteAttribute();
            WriteLiteral("rows=\"3\" pattern=\"^[A-Za-z0-9-\\s]*\" title=\"Summary should without accents\"name=\"summaryBook\" style=\"width:100%\">");
#nullable restore
#line 110 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\EditBook.cshtml"
                                                                                                                                                                                                 Write(book.summaryBook);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</textarea>
                                    </div>
                                </div>
                                <div class=""form-row"">
                                    <div class=""form-group col-md-4"">
                                        <label class=""font-weight-bold"">Published Year</label>
                                        <input type=""number""pattern=""[+][0-9]"" min='1'");
            BeginWriteAttribute("value", "value=\"", 7565, "\"", 7592, 1);
#nullable restore
#line 116 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\EditBook.cshtml"
WriteAttributeValue("", 7572, book.publishingYear, 7572, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\"");
            BeginWriteAttribute("required", "required=\"", 7614, "\"", 7624, 0);
            EndWriteAttribute();
            WriteLiteral(@" name=""publishingYear"" placeholder=""Nhập tên tác giả"">
                                    </div>
                                    <div class=""form-group col-md-4"">
                                        <label class=""font-weight-bold"">Page Count</label>
                                        <input type=""number""pattern=""[+][0-9]"" min='1'");
            BeginWriteAttribute("value", "value=\"", 7974, "\"", 7996, 1);
#nullable restore
#line 120 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\EditBook.cshtml"
WriteAttributeValue("", 7981, book.pageCount, 7981, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("class=\"form-control\"");
            BeginWriteAttribute("required", "required=\"", 8017, "\"", 8027, 0);
            EndWriteAttribute();
            WriteLiteral(@" name=""pageCount"" placeholder=""Nhập tên tác giả"">
                                    </div> 
                                    <div class=""form-group col-md-4"">
                                        <label class=""font-weight-bold"">Publisher</label>
                                        <input type=""text"" class=""form-control""");
            BeginWriteAttribute("value", "value=\"", 8365, "\"", 8391, 1);
#nullable restore
#line 124 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\EditBook.cshtml"
WriteAttributeValue("", 8372, book.publisherBook, 8372, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" pattern=\"^[A-Za-z0-9-\\s]*\" title=\"Publisher should without accents\"");
            BeginWriteAttribute("required", "required=\"", 8460, "\"", 8470, 0);
            EndWriteAttribute();
            WriteLiteral(@" name=""publisherBook"" placeholder=""Nhập tên tác giả"">
                                    </div>  
                                </div>
                            </div>
                            <div class=""form-group col-md-4 mt-5 pl-5"">
                                <a href=""../../Admin/BookManagement"" name=""submit-cancel"" class=""btn btn-danger"">Cancel</a>
                                <input type=""submit"" name=""submit-save"" class=""btn btn-success"" value=""Save"" />
                            </div>
                        </div>
");
#nullable restore
#line 133 "C:\Users\hoaia\OneDrive\Máy tính\Git\frame\Views\Admin\EditBook.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
        </div>
    </div>
</div>

<script type=""text/javascript"">
    function readURLTruoc(input){
        if(input.files && input.files[0]){
            var reader = new FileReader();

            reader.onload = function(e){
                $('#show-mattruoc').attr('src',e.target.result);
            }
            reader.readAsDataURL(input.files[0]);
        }
    }
    $('#imageTruoc').change(function(){
        readURLTruoc(this);
    });
    function readURLSau(input){
        if(input.files && input.files[0]){
            var reader = new FileReader();

            reader.onload = function(e){
                $('#show-sau').attr('src',e.target.result);
            }
            reader.readAsDataURL(input.files[0]);
        }
    }
    $('#imageSau').change(function(){
        readURLSau(this);
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
