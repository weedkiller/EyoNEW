#pragma checksum "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\TimeLine.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5d8e743b9be34874fb1999cc4e0dc3ffe2ab2e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ContentView_TimeLine), @"mvc.1.0.view", @"/Views/Shared/Components/ContentView/TimeLine.cshtml")]
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
#line 1 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\_ViewImports.cshtml"
using CMSSite;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5d8e743b9be34874fb1999cc4e0dc3ffe2ab2e4", @"/Views/Shared/Components/ContentView/TimeLine.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f74a5ef60aca8ccb0793e472a7a82919353f59fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ContentView_TimeLine : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\TimeLine.cshtml"
  
    Layout = "_Layout";
    var content = ViewBag.content as ContentPage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\TimeLine.cshtml"
Write(await Component.InvokeAsync("MenuView", new { type = "SubHeader" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div id=\"content\" class=\" no-bottom sm-mt0\">\r\n");
#nullable restore
#line 8 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\TimeLine.cshtml"
     if (content.IsSideMenu == true)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"container\">\r\n            <div class=\"row\">\r\n                ");
#nullable restore
#line 12 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\TimeLine.cshtml"
           Write(await Component.InvokeAsync("MenuView", new { type = "SideMenu" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-9\">\r\n                    <div class=\"row\">\r\n                        <div class=\"col-md-12\">\r\n                            ");
#nullable restore
#line 16 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\TimeLine.cshtml"
                       Write(Html.Raw(content.ContentShort));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 17 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\TimeLine.cshtml"
                       Write(Html.Raw(content.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-md-12\">\r\n                            <div class=\"timeline exp\">\r\n                                ");
#nullable restore
#line 21 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\TimeLine.cshtml"
                           Write(Html.Raw(content.ContentData));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 28 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\TimeLine.cshtml"

    }
    else
    {



#line default
#line hidden
#nullable disable
            WriteLiteral("        <section>\r\n            <div class=\"container\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-12 text-center\">\r\n                        ");
#nullable restore
#line 38 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\TimeLine.cshtml"
                   Write(Html.Raw(content.ContentShort));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 39 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\TimeLine.cshtml"
                   Write(Html.Raw(content.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n                    </div>\r\n                    <div class=\"col-md-6 offset-md-3\">\r\n                        <div class=\"timeline exp\">\r\n                            ");
#nullable restore
#line 43 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\TimeLine.cshtml"
                       Write(Html.Raw(content.ContentData));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </section>\r\n");
#nullable restore
#line 49 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\TimeLine.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
