#pragma checksum "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Shared\Components\ContentView\UrunDetay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06e6435581633b1f16511525b663c0682b90930a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ContentView_UrunDetay), @"mvc.1.0.view", @"/Views/Shared/Components/ContentView/UrunDetay.cshtml")]
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
#line 1 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\_ViewImports.cshtml"
using CMSSite;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06e6435581633b1f16511525b663c0682b90930a", @"/Views/Shared/Components/ContentView/UrunDetay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f74a5ef60aca8ccb0793e472a7a82919353f59fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ContentView_UrunDetay : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Shared\Components\ContentView\UrunDetay.cshtml"
  
    Layout = "_Layout";
    var content = ViewBag.content as ContentPage;
    var contents = ViewBag.contents as List<ContentPage>;
    int LanguageID = (int)ViewBag.LanguageID;
    var Specs = ViewBag.Specs as List<Spec>;
    List<int> specList = Specs.Where(x => x.ParentId == 15).Select(s => s.Id).ToList();

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Shared\Components\ContentView\UrunDetay.cshtml"
Write(await Component.InvokeAsync("MenuView", new { type = "SubHeader" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" 
<!-- SECTION CONTENT START -->
<div class=""section-full p-tb80 inner-page-padding stick_in_parent"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-7 col-md-7  sticky_column"">
                <div class=""project-detail-containt"">
                    <div class=""bg-white text-black"">
                        <h3>");
#nullable restore
#line 17 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Shared\Components\ContentView\UrunDetay.cshtml"
                       Write(Html.Raw(content.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        ");
#nullable restore
#line 18 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Shared\Components\ContentView\UrunDetay.cshtml"
                   Write(Html.Raw(content.ContentData));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"product-block\">\r\n                            <ul>\r\n");
#nullable restore
#line 21 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Shared\Components\ContentView\UrunDetay.cshtml"
                                 foreach (var specItem in content.SpecContentValue.Where(x => x.ContentPageId == content.Id && specList.Contains(x.SpecId)).ToList())
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li>\r\n                                        <h4 class=\"m-b10\">");
#nullable restore
#line 24 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Shared\Components\ContentView\UrunDetay.cshtml"
                                                     Write(Specs.FirstOrDefault(x => x.Id == specItem.SpecId).Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                        <p>");
#nullable restore
#line 25 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Shared\Components\ContentView\UrunDetay.cshtml"
                                      Write(specItem.ContentValue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </li>\r\n");
#nullable restore
#line 27 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Shared\Components\ContentView\UrunDetay.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </ul>
                        </div>  
                        <div class=""m-b0"">
                            <div class=""sx-divider divider-1px  bg-black""><i class=""icon-dot c-square""></i></div>
                        </div>
                        <ul class=""social-icons social-square social-darkest m-b0"">
                            <li><a href=""javascript:void(0);"" class=""fa fa-facebook""></a></li>
                            <li><a href=""javascript:void(0);"" class=""fa fa-twitter""></a></li>
                            <li><a href=""javascript:void(0);"" class=""fa fa-linkedin""></a></li>
                            <li><a href=""javascript:void(0);"" class=""fa fa-rss""></a></li>
                            <li><a href=""javascript:void(0);"" class=""fa fa-youtube""></a></li>
                            <li><a href=""javascript:void(0);"" class=""fa fa-instagram""></a></li>
                        </ul>
                    </div>
                </div>
            </div> 
     ");
            WriteLiteral("       <div class=\"col-lg-5 col-md-5 \">\r\n\r\n                <div class=\"project-detail-outer\">\r\n");
#nullable restore
#line 47 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Shared\Components\ContentView\UrunDetay.cshtml"
                     foreach (var item in content.Gallery)
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"project-detail-pic m-b30\">\r\n                            <div class=\"sx-media\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 2801, "\"", 2878, 2);
            WriteAttributeValue("", 2807, "http://interalcms.zonagency.com/fileupload/UserFiles/Folders/", 2807, 61, true);
#nullable restore
#line 52 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Shared\Components\ContentView\UrunDetay.cshtml"
WriteAttributeValue("", 2868, item.Link, 2868, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2879, "\"", 2894, 1);
#nullable restore
#line 52 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Shared\Components\ContentView\UrunDetay.cshtml"
WriteAttributeValue("", 2885, item.Alt, 2885, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 55 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Shared\Components\ContentView\UrunDetay.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n<!-- SECTION CONTENT END  -->\r\n");
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
