#pragma checksum "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\Content.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9394724ec04c1fc7341e91391eb3576d0dea689"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ContentView_Content), @"mvc.1.0.view", @"/Views/Shared/Components/ContentView/Content.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9394724ec04c1fc7341e91391eb3576d0dea689", @"/Views/Shared/Components/ContentView/Content.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f74a5ef60aca8ccb0793e472a7a82919353f59fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ContentView_Content : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\Content.cshtml"
  
    Layout = "_Layout";
    var content = ViewBag.content as ContentPage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\Content.cshtml"
Write(await Component.InvokeAsync("MenuView", new { type = "SubHeader" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div id=\"content\">\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n                <div class=\"col-md-12\">\r\n                    ");
#nullable restore
#line 10 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\Content.cshtml"
               Write(Html.Raw(content.ContentShort));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 11 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\Content.cshtml"
               Write(Html.Raw(content.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 12 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\Content.cshtml"
               Write(Html.Raw(content.ContentData));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div> \r\n");
#nullable restore
#line 16 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\Content.cshtml"
         if (content.Gallery != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"container\">\r\n                <div class=\"row\">\r\n                    <div id=\"gallery\" class=\"gallery grid_gallery full-gallery de-gallery folio-style2\">\r\n\r\n");
#nullable restore
#line 22 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\Content.cshtml"
                         foreach (var galleryItem in content.Gallery)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div");
            BeginWriteAttribute("class", " class=\"", 860, "\"", 899, 4);
            WriteAttributeValue(" ", 868, "col-md-4", 869, 9, true);
            WriteAttributeValue(" ", 877, "mb30", 878, 5, true);
            WriteAttributeValue(" ", 882, "item", 883, 5, true);
#nullable restore
#line 24 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\Content.cshtml"
WriteAttributeValue(" ", 887, content.Id, 888, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <div class=\"picframe\">\r\n                                    <a class=\"image-popup-gallery\"");
            BeginWriteAttribute("title", " title=\"", 1025, "\"", 1046, 1);
#nullable restore
#line 26 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\Content.cshtml"
WriteAttributeValue("", 1033, content.Name, 1033, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 1047, "\"", 1107, 2);
            WriteAttributeValue("", 1054, "https://cms.cuhadaroglu.com/uploads/", 1054, 36, true);
#nullable restore
#line 26 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\Content.cshtml"
WriteAttributeValue("", 1090, galleryItem.Link, 1090, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                        <span class=""overlay"">
                                            <span class=""pf_text"">
                                                <span class=""project-name""><i class=""fa fa-search""></i></span>
                                            </span>
                                        </span>
                                    </a>
                                    <img");
            BeginWriteAttribute("src", " src=\"", 1539, "\"", 1635, 2);
            WriteAttributeValue("", 1545, "https://cms.cuhadaroglu.com/uploads/", 1545, 36, true);
#nullable restore
#line 33 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\Content.cshtml"
WriteAttributeValue("", 1581, galleryItem.Link!=""?galleryItem.Link:"default.jpg", 1581, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 36 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\Content.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n\r\n\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 42 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\Content.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>");
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
