#pragma checksum "C:\Users\vladi\Downloads\Project-Mine\Bookstore\Bookstore.Web\Views\Books\Book.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39aaae52d138973561236765ff730c4db3cbb251"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Books_Book), @"mvc.1.0.view", @"/Views/Books/Book.cshtml")]
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
#line 1 "C:\Users\vladi\Downloads\Project-Mine\Bookstore\Bookstore.Web\Views\_ViewImports.cshtml"
using Bookstore.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vladi\Downloads\Project-Mine\Bookstore\Bookstore.Web\Views\_ViewImports.cshtml"
using Bookstore.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39aaae52d138973561236765ff730c4db3cbb251", @"/Views/Books/Book.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cdce51814eb3846bd510a105fe1249674635d03", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Books_Book : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bookstore.Catalog.Api.Dto.Books.BookResponse>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BookPurchase", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 3 "C:\Users\vladi\Downloads\Project-Mine\Bookstore\Bookstore.Web\Views\Books\Book.cshtml"
Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<p>ISBN: ");
#nullable restore
#line 5 "C:\Users\vladi\Downloads\Project-Mine\Bookstore\Bookstore.Web\Views\Books\Book.cshtml"
    Write(Model.ISBN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<p>");
#nullable restore
#line 7 "C:\Users\vladi\Downloads\Project-Mine\Bookstore\Bookstore.Web\Views\Books\Book.cshtml"
Write(Model.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<p>");
#nullable restore
#line 9 "C:\Users\vladi\Downloads\Project-Mine\Bookstore\Bookstore.Web\Views\Books\Book.cshtml"
Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<p>Number of pages: ");
#nullable restore
#line 11 "C:\Users\vladi\Downloads\Project-Mine\Bookstore\Bookstore.Web\Views\Books\Book.cshtml"
               Write(ViewBag.OpenLibraryBook.NumberOfPages);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<img");
            BeginWriteAttribute("src", " src=\"", 223, "\"", 277, 1);
#nullable restore
#line 13 "C:\Users\vladi\Downloads\Project-Mine\Bookstore\Bookstore.Web\Views\Books\Book.cshtml"
WriteAttributeValue("", 229, ViewBag.OpenLibraryBook.Cover.Medium.ToString(), 229, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 278, "\"", 284, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39aaae52d138973561236765ff730c4db3cbb2515679", async() => {
                WriteLiteral("\r\n    <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 374, "\"", 395, 1);
#nullable restore
#line 16 "C:\Users\vladi\Downloads\Project-Mine\Bookstore\Bookstore.Web\Views\Books\Book.cshtml"
WriteAttributeValue("", 382, Model.BookID, 382, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <button type=\"submit\" class=\"btn btn-primary\">Purchase</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bookstore.Catalog.Api.Dto.Books.BookResponse> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591