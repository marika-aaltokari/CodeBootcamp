#pragma checksum "C:\Users\Moppy\CodeBootcamp\DotNet\AspNetMvcDemoMa\AspNetMvcDemoMa\Views\Home\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04bfd41e4881650c853558ff206e2d03540b87a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Search), @"mvc.1.0.view", @"/Views/Home/Search.cshtml")]
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
#line 1 "C:\Users\Moppy\CodeBootcamp\DotNet\AspNetMvcDemoMa\AspNetMvcDemoMa\Views\_ViewImports.cshtml"
using AspNetMvcDemoMa;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Moppy\CodeBootcamp\DotNet\AspNetMvcDemoMa\AspNetMvcDemoMa\Views\_ViewImports.cshtml"
using AspNetMvcDemoMa.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04bfd41e4881650c853558ff206e2d03540b87a8", @"/Views/Home/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d4f8bf3e7884ea0466018c4a7af5e8d31cc7c2b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Moppy\CodeBootcamp\DotNet\AspNetMvcDemoMa\AspNetMvcDemoMa\Views\Home\Search.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Searching the book with the author or the title</h1>
    <p></p>




   

    <br> <br />
    
         <div class=""container"">
             <div class=""row align-items-center justify-content-center"" label="" keyword"">
                 <div class=""col-sm-2"">
                     Keyword:
                 </div>
                 <div class=""col-sm-3"">
                     <input type=""text"" class=""form-control mb-3"" id=""searchstring"" name=""searchstring"" required pattern=""[A-Za-z]{3,}"" title=""At least 3 alphabetic characters"" maxlength=""20"" />
                 </div>
             </div>
             <div class=""row align-items-center justify-content-center"">
                 <div class=""col-sm-2 offset-2"">
                     <button id=""Searching"" class=""btn btn-info"">Search</button>
                 </div>
             </div>


         </div>
</div>");
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
