#pragma checksum "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\BlogDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bbdd69c8b2a951bdcbf347c1db1bc94c84746fb7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ContentView_BlogDetail), @"mvc.1.0.view", @"/Views/Shared/Components/ContentView/BlogDetail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbdd69c8b2a951bdcbf347c1db1bc94c84746fb7", @"/Views/Shared/Components/ContentView/BlogDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f74a5ef60aca8ccb0793e472a7a82919353f59fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ContentView_BlogDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\BlogDetail.cshtml"
  
    Layout = "_Layout";
    var content = ViewBag.content as ContentPage;
    var contents = ViewBag.contents as List<ContentPage>;
    int LanguageID = (int)ViewBag.LanguageID;


#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\BlogDetail.cshtml"
Write(await Component.InvokeAsync("MenuView", new { type = "SubHeader" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- content begin -->
<div id=""content"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-8"">
                <div class=""blog-read"">
                    <div class=""post-content"">
                        <div class=""post-image"">
                            <img");
            BeginWriteAttribute("src", " src=\"", 570, "\"", 656, 2);
            WriteAttributeValue("", 576, "https://cms.cuhadaroglu.com/uploads/", 576, 36, true);
#nullable restore
#line 18 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\BlogDetail.cshtml"
WriteAttributeValue("", 612, content.Image==null?"":content.Image.Link, 612, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 657, "\"", 676, 1);
#nullable restore
#line 18 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\BlogDetail.cshtml"
WriteAttributeValue("", 663, content.Name, 663, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        </div>\r\n                        <div class=\"date-box\">\r\n                            <div class=\"day\">");
#nullable restore
#line 21 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\BlogDetail.cshtml"
                                         Write(string.IsNullOrEmpty(content.StartDate.ToString())?"":content.StartDate.Day.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            <div class=\"month\">");
#nullable restore
#line 22 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\BlogDetail.cshtml"
                                           Write(string.IsNullOrEmpty(content.StartDate.ToString())?"":content.StartDate.ToString("MMMM").Substring(0, 3).ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        </div>\r\n                        <div class=\"post-text\">\r\n                            <h3><a");
            BeginWriteAttribute("href", " href=\"", 1191, "\"", 1211, 1);
#nullable restore
#line 25 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\BlogDetail.cshtml"
WriteAttributeValue("", 1198, content.Link, 1198, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 25 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\BlogDetail.cshtml"
                                                   Write(Html.Raw(content.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                            ");
#nullable restore
#line 26 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\BlogDetail.cshtml"
                       Write(Html.Raw(content.ContentShort));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 27 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\BlogDetail.cshtml"
                       Write(Html.Raw(content.ContentData));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""spacer-single""></div>
                </div>
            </div>
            <div id=""sidebar"" class=""col-md-4"">
                <div class=""widget widget-post"">
                    <h4>");
#nullable restore
#line 35 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\BlogDetail.cshtml"
                    Write(LanguageID==1?"Son Eklenenler":"Latest Posts");

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h4>\r\n                    <div class=\"small-border\"></div>\r\n                    <ul>\r\n");
#nullable restore
#line 38 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\BlogDetail.cshtml"
                         foreach (var item in contents.Take(5).ToList())
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li><a");
            BeginWriteAttribute("href", " href=\"", 1928, "\"", 1945, 1);
#nullable restore
#line 40 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\BlogDetail.cshtml"
WriteAttributeValue("", 1935, item.Link, 1935, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 40 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\BlogDetail.cshtml"
                                                Write(Html.Raw((item.Name.Length >= 40 ? (item.Name.Substring(0, 40) + "...") : item.Name)));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 41 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\BlogDetail.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n ");
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
