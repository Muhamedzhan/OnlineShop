#pragma checksum "/Users/muhamedzhan/Projects/Shops/Shops/Views/Cars/List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f4c9e92ac8cdc8a6283c410688e6ddb8a8f2aea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cars_List), @"mvc.1.0.view", @"/Views/Cars/List.cshtml")]
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
#line 1 "/Users/muhamedzhan/Projects/Shops/Shops/Views/_ViewImports.cshtml"
using Shops.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/muhamedzhan/Projects/Shops/Shops/Views/_ViewImports.cshtml"
using Shops.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f4c9e92ac8cdc8a6283c410688e6ddb8a8f2aea", @"/Views/Cars/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1031305bd524ab2846c034c84ccfa32671fc0f0b", @"/Views/_ViewImports.cshtml")]
    public class Views_Cars_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>All Cars</h1>\n<h3>");
#nullable restore
#line 2 "/Users/muhamedzhan/Projects/Shops/Shops/Views/Cars/List.cshtml"
Write(Model.currCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n<div class=\"row mt-5 mb2\">\n");
#nullable restore
#line 4 "/Users/muhamedzhan/Projects/Shops/Shops/Views/Cars/List.cshtml"
      
        foreach (Car car in Model.allCars)
        {
           

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/muhamedzhan/Projects/Shops/Shops/Views/Cars/List.cshtml"
      Write(Html.Partial("AllCars", car));

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/muhamedzhan/Projects/Shops/Shops/Views/Cars/List.cshtml"
                                        ;
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
