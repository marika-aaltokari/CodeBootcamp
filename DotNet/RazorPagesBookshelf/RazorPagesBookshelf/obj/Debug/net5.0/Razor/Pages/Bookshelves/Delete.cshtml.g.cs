#pragma checksum "C:\Users\Moppy\CodeBootcamp\DotNet\RazorPagesBookshelf\RazorPagesBookshelf\Pages\Bookshelves\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b10ba147fcc39a3a91abd9de4c553c6c881bd550"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Bookshelves_Delete), @"mvc.1.0.razor-page", @"/Pages/Bookshelves/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id:int?}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b10ba147fcc39a3a91abd9de4c553c6c881bd550", @"/Pages/Bookshelves/Delete.cshtml")]
    public class Pages_Bookshelves_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Moppy\CodeBootcamp\DotNet\RazorPagesBookshelf\RazorPagesBookshelf\Pages\Bookshelves\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Bookshelf</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 16 "C:\Users\Moppy\CodeBootcamp\DotNet\RazorPagesBookshelf\RazorPagesBookshelf\Pages\Bookshelves\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Bookshelf.AuthorNames));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 19 "C:\Users\Moppy\CodeBootcamp\DotNet\RazorPagesBookshelf\RazorPagesBookshelf\Pages\Bookshelves\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Bookshelf.AuthorNames));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 22 "C:\Users\Moppy\CodeBootcamp\DotNet\RazorPagesBookshelf\RazorPagesBookshelf\Pages\Bookshelves\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Bookshelf.AuthorSurname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 25 "C:\Users\Moppy\CodeBootcamp\DotNet\RazorPagesBookshelf\RazorPagesBookshelf\Pages\Bookshelves\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Bookshelf.AuthorSurname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 28 "C:\Users\Moppy\CodeBootcamp\DotNet\RazorPagesBookshelf\RazorPagesBookshelf\Pages\Bookshelves\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Bookshelf.BookTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 31 "C:\Users\Moppy\CodeBootcamp\DotNet\RazorPagesBookshelf\RazorPagesBookshelf\Pages\Bookshelves\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Bookshelf.BookTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 34 "C:\Users\Moppy\CodeBootcamp\DotNet\RazorPagesBookshelf\RazorPagesBookshelf\Pages\Bookshelves\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Bookshelf.Favorite));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 37 "C:\Users\Moppy\CodeBootcamp\DotNet\RazorPagesBookshelf\RazorPagesBookshelf\Pages\Bookshelves\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Bookshelf.Favorite));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 40 "C:\Users\Moppy\CodeBootcamp\DotNet\RazorPagesBookshelf\RazorPagesBookshelf\Pages\Bookshelves\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Bookshelf.SavingDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 43 "C:\Users\Moppy\CodeBootcamp\DotNet\RazorPagesBookshelf\RazorPagesBookshelf\Pages\Bookshelves\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Bookshelf.SavingDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n    <form method=\"post\">\r\n        <input type=\"hidden\" asp-for=\"Bookshelf.ID\" />\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        <a asp-page=\"./Index\">Back to List</a>\r\n    </form>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RazorPagesBookshelf.Pages.Bookshelves.DeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPagesBookshelf.Pages.Bookshelves.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPagesBookshelf.Pages.Bookshelves.DeleteModel>)PageContext?.ViewData;
        public RazorPagesBookshelf.Pages.Bookshelves.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
