#pragma checksum "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Shared\Components\ContentView\BlogDetay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1a912f334a9f582cb37065049ffb70c9c81db06"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ContentView_BlogDetay), @"mvc.1.0.view", @"/Views/Shared/Components/ContentView/BlogDetay.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1a912f334a9f582cb37065049ffb70c9c81db06", @"/Views/Shared/Components/ContentView/BlogDetay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f74a5ef60aca8ccb0793e472a7a82919353f59fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ContentView_BlogDetay : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Shared\Components\ContentView\BlogDetay.cshtml"
  
    Layout = "_Layout";
    var content = ViewBag.content as ContentPage;
    var contents = ViewBag.contents as List<ContentPage>;  
    int LanguageID = (int)ViewBag.LanguageID; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Shared\Components\ContentView\BlogDetay.cshtml"
Write(await Component.InvokeAsync("MenuView", new { type = "SubHeader" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
 
<div class=""section-full p-t80 p-b50 inner-page-padding"">
    <div class=""container"">
        <div class=""blog-single-space max-w900 ml-auto mr-auto"">
            <!-- BLOG START -->
            <div class=""blog-post blog-detail text-black"">
                <div class=""sx-post-media"">
                    <div class=""portfolio-item"">
                        <img class=""img-responsive""");
            BeginWriteAttribute("src", " src=\"", 659, "\"", 777, 2);
            WriteAttributeValue("", 665, "http://interalcms.zonagency.com/fileupload/UserFiles/Folders/", 665, 61, true);
#nullable restore
#line 16 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Shared\Components\ContentView\BlogDetay.cshtml"
WriteAttributeValue("", 726, content.Picture!=null?content.ThumbImage.Link:"", 726, 51, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 778, "\"", 831, 1);
#nullable restore
#line 16 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Shared\Components\ContentView\BlogDetay.cshtml"
WriteAttributeValue("", 784, content.Picture!=null?content.Picture.Alt:"", 784, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n                 \r\n                <div class=\"sx-post-title \">\r\n                    <h3 class=\"post-title\">");
#nullable restore
#line 21 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Shared\Components\ContentView\BlogDetay.cshtml"
                                      Write(content.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                </div>\r\n\r\n                <div class=\"sx-post-text\">\r\n                    ");
#nullable restore
#line 25 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Shared\Components\ContentView\BlogDetay.cshtml"
               Write(Html.Raw(content.ContentData));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <div class=\"row\">\r\n");
#nullable restore
#line 27 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Shared\Components\ContentView\BlogDetay.cshtml"
                         foreach (var item in content.Gallery)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-md-6\">\r\n                                <div class=\"sx-box m-b30\">\r\n                                    <div class=\"sx-media\">\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 1490, "\"", 1567, 2);
            WriteAttributeValue("", 1496, "http://interalcms.zonagency.com/fileupload/UserFiles/Folders/", 1496, 61, true);
#nullable restore
#line 32 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Shared\Components\ContentView\BlogDetay.cshtml"
WriteAttributeValue("", 1557, item.Link, 1557, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1568, "\"", 1583, 1);
#nullable restore
#line 32 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Shared\Components\ContentView\BlogDetay.cshtml"
WriteAttributeValue("", 1574, item.Alt, 1574, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 36 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Shared\Components\ContentView\BlogDetay.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                         
                    </div>
                </div>

                <div class=""autor-post-tag-share p-a30 bg-gray"">
                    <div class=""row""> 
                        <div class=""col-md-12"">
                            <div class=""clearfix single-post-share"">
                                <h5>Yazıyı Paylaşın:</h5>
                                <div class=""widget_social_inks"">
                                    <ul class=""social-icons social-md social-square social-dark m-b0"">
                                        <li><a href=""javascript:void(0);"" class=""fa fa-facebook""></a></li>
                                        <li><a href=""javascript:void(0);"" class=""fa fa-twitter""></a></li>
                                        <li><a href=""javascript:void(0);"" class=""fa fa-rss""></a></li>
                                        <li><a href=""javascript:void(0);"" class=""fa fa-youtube""></a></li>
                                        <li><a href=""javascript:");
            WriteLiteral(@"void(0);"" class=""fa fa-instagram""></a></li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <div class=""post-controls p-t30"">
                    <div class=""d-flex justify-content-between"">
                        <div class=""prev-post""><a href=""#"">Önceki Yazı</a></div>
                        <div class=""next-post""><a href=""#"">Sonraki Yazı</a></div>
                    </div>
                </div>

            </div>
 
         
             
        </div>
    </div>
</div>
<!-- SECTION CONTENT END -->
        </div>
<!-- CONTENT END -->
");
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
