#pragma checksum "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\ProjectListItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91995e1c17eb04aabae96321f1596c72fec7fd66"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ContentView_ProjectListItem), @"mvc.1.0.view", @"/Views/Shared/Components/ContentView/ProjectListItem.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91995e1c17eb04aabae96321f1596c72fec7fd66", @"/Views/Shared/Components/ContentView/ProjectListItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f74a5ef60aca8ccb0793e472a7a82919353f59fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ContentView_ProjectListItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\ProjectListItem.cshtml"
  
    Layout = "_Layout";
    var content = ViewBag.content as ContentPage;
    var contents = ViewBag.contents as List<ContentPage>;
    var filters = ViewBag.filters as List<ContentPage>;
    var currDoc = string.IsNullOrEmpty(Context.Request.Query["p"]) ? contents.FirstOrDefault().Parent.ContentShort : Context.Request.Query["p"].ToString();

    int LanguageID = (int)ViewBag.LanguageID;
    var showAllStr = "Tümü";
    if (LanguageID == 2)
    {
        showAllStr = "All";
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\ProjectListItem.cshtml"
Write(await Component.InvokeAsync("MenuView", new { type = "SubHeader" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"content\">\r\n    <div class=\"container\">\r\n        ");
#nullable restore
#line 18 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\ProjectListItem.cshtml"
   Write(Html.Raw(content.ContentShort));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 19 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\ProjectListItem.cshtml"
   Write(Html.Raw(content.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 20 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\ProjectListItem.cshtml"
   Write(Html.Raw(content.ContentData));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"row\">\r\n            ");
#nullable restore
#line 22 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\ProjectListItem.cshtml"
       Write(await Component.InvokeAsync("MenuView", new { type = "SideMenu" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-9\">\r\n                <div class=\"expand-group\" style=\"max-width: 300px;\">\r\n                    <div class=\"expand\">\r\n                        <h4 class=\"galHeader\">");
#nullable restore
#line 26 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\ProjectListItem.cshtml"
                                         Write(Html.Raw(currDoc == "*" ? showAllStr : currDoc));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        <div class=\"hidden-content\">\r\n                            <ul id=\"filters\">\r\n");
#nullable restore
#line 29 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\ProjectListItem.cshtml"
                                 foreach (var item in filters)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li><a href=\"#\" data-filter=\".");
#nullable restore
#line 31 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\ProjectListItem.cshtml"
                                                              Write("catID_"+item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("class", " class=", 1387, "", 1437, 1);
#nullable restore
#line 31 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\ProjectListItem.cshtml"
WriteAttributeValue("", 1394, item.ContentShort==currDoc?"selected":"", 1394, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 31 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\ProjectListItem.cshtml"
                                                                                                                                    Write(item.ContentShort);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 32 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\ProjectListItem.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </ul>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <br />\r\n                <div id=\"gallery\" class=\"gallery grid_gallery full-gallery de-gallery folio-style2\">\r\n");
#nullable restore
#line 39 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\ProjectListItem.cshtml"
                     foreach (var item in contents)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div");
            BeginWriteAttribute("class", " class=\"", 1851, "\"", 1899, 3);
            WriteAttributeValue("", 1859, "col-md-4", 1859, 8, true);
            WriteAttributeValue(" ", 1867, "item", 1868, 5, true);
#nullable restore
#line 41 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\ProjectListItem.cshtml"
WriteAttributeValue(" ", 1872, "catID_"+item.Parent.Id, 1873, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("style", " style=", 1900, "", 1996, 1);
#nullable restore
#line 41 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\ProjectListItem.cshtml"
WriteAttributeValue("", 1907, string.IsNullOrEmpty(currDoc)?"":(item.Parent.ContentShort!=currDoc?"display:none":""), 1907, 89, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <a class=\"simple-ajax-popup-align-top\"");
            BeginWriteAttribute("href", " href=\"", 2065, "\"", 2085, 2);
            WriteAttributeValue("", 2072, "/", 2072, 1, true);
#nullable restore
#line 42 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\ProjectListItem.cshtml"
WriteAttributeValue("", 2073, item.Link, 2073, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <div class=\"folio-image\">\r\n");
#nullable restore
#line 44 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\ProjectListItem.cshtml"
                                     if (item.ThumbImage != null)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <img");
            BeginWriteAttribute("src", " src=\"", 2298, "\"", 2361, 2);
            WriteAttributeValue("", 2304, "https://cms.cuhadaroglu.com/uploads/", 2304, 36, true);
#nullable restore
#line 46 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\ProjectListItem.cshtml"
WriteAttributeValue("", 2340, item.ThumbImage.Link, 2340, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2362, "\"", 2388, 1);
#nullable restore
#line 46 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\ProjectListItem.cshtml"
WriteAttributeValue("", 2368, item.ThumbImage.Alt, 2368, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 47 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\ProjectListItem.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n                                <div class=\"folio-info\">\r\n                                    <h3>");
#nullable restore
#line 50 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\ProjectListItem.cshtml"
                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                    ");
#nullable restore
#line 51 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\ProjectListItem.cshtml"
                               Write(Html.Raw(item.ContentShort));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </a>\r\n                        </div>\r\n");
#nullable restore
#line 55 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\ContentView\ProjectListItem.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
