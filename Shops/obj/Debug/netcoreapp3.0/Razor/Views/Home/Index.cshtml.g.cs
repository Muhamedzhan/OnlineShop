#pragma checksum "/Users/muhamedzhan/Projects/Shops/Shops/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26075a48b8fd94f2544909ace6349918c6316891"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 3 "/Users/muhamedzhan/Projects/Shops/Shops/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26075a48b8fd94f2544909ace6349918c6316891", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55821ee3d7b57facb12d1455aaf17227f3c30cca", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h1>The best cars</h1>\n<div class=\"row mt-5 mb2\">\n");
#nullable restore
#line 5 "/Users/muhamedzhan/Projects/Shops/Shops/Views/Home/Index.cshtml"
      
        foreach (Car car in Model.favCars)
        {
           

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/muhamedzhan/Projects/Shops/Shops/Views/Home/Index.cshtml"
      Write(Html.Partial("AllCars", car));

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/muhamedzhan/Projects/Shops/Shops/Views/Home/Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
