#pragma checksum "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\SectionView\ContentDocument.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ded91859d579dced88e920a7928941d90cbfd9c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SectionView_ContentDocument), @"mvc.1.0.view", @"/Views/Shared/Components/SectionView/ContentDocument.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ded91859d579dced88e920a7928941d90cbfd9c7", @"/Views/Shared/Components/SectionView/ContentDocument.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f74a5ef60aca8ccb0793e472a7a82919353f59fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_SectionView_ContentDocument : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\SectionView\ContentDocument.cshtml"
  
    Layout = null;
    var content = ViewBag.content as ContentPage;
    string viewType=ViewBag.viewType as string;
    int LanguageID = (int)ViewBag.LanguageID;
    string docs = "Dökümanlar";
    if(LanguageID==2)
    {
        docs = "Documents";
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\SectionView\ContentDocument.cshtml"
 if (viewType=="Single"){
 

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\SectionView\ContentDocument.cshtml"
Write(await Component.InvokeAsync("MenuView", new { type = "SubHeader" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <!--topMenux-->\r\n<div id=\"content\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            ");
#nullable restore
#line 19 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\SectionView\ContentDocument.cshtml"
       Write(await Component.InvokeAsync("MenuView", new { type = "SideMenu" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            <div class=""col-md-9"">
                <div class=""row"" style=""background-size: cover;"">
                    <div class=""col-md-12"" style=""background-size: cover;"">
                        <div class=""row"" style=""background-size: cover;"">
                            <div class=""col-md-12 wow fadeInUp animated animated animated animated animated"" data-wow-delay="".3s"" style=""visibility: visible; animation-delay: 0.3s; animation-name: fadeInUp; background-size: cover; opacity: 0;"">
                                ");
#nullable restore
#line 25 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\SectionView\ContentDocument.cshtml"
                           Write(Html.Raw(content.ContentShort));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 26 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\SectionView\ContentDocument.cshtml"
                           Write(Html.Raw(content.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>
                    </div><div class=""col-md-12"" style=""background-size: cover;"">
                        <div class=""row"" style=""background-size: cover;"">
                            <div class=""col-md-12 wow fadeInUp animated animated animated animated animated animated animated"" data-wow-delay="".3s"" style=""visibility: visible; animation-delay: 0.3s; animation-name: fadeInUp; background-size: cover; opacity: 0;"">
                                ");
#nullable restore
#line 32 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\SectionView\ContentDocument.cshtml"
                           Write(Html.Raw(content.ContentData));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n\r\n");
#nullable restore
#line 38 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\SectionView\ContentDocument.cshtml"
                 if (content.Documents.Count > 0)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""expand-group mbp-30"" style=""background-size: cover;"">
                        <div class=""mainRep mb30"" style=""background-size: cover;"">
                            <section class=""call-to-action bg-color text-dark pt10 pb10"" data-speed=""5"" data-type=""background"" aria-label=""cta"">
                                <div class=""container"" style=""background-size: cover;"">
                                    <div class=""row"" style=""background-size: cover;"">
                                        <div class=""col-md-12 text-center"" style=""background-size: cover;"">
                                            <h2 class=""wow fadeInUp text-center animated animated"" style=""visibility: visible; animation-name: fadeInUp;"">");
#nullable restore
#line 47 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\SectionView\ContentDocument.cshtml"
                                                                                                                                                     Write(docs);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                                        </div>
                                    </div>
                                </div>
                            </section>
                            <div style=""background-size: cover;"">
                                <div class=""expand item 2020"" style=""background-size: cover;"">
                                    <div class=""row"" style=""background-size: cover;"">
");
#nullable restore
#line 55 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\SectionView\ContentDocument.cshtml"
                                         foreach (var docu in content.Documents)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <div class=\"col-md-6\">\r\n                                                <p>\r\n                                                    <a");
            BeginWriteAttribute("href", " href=\"", 3419, "\"", 3472, 2);
            WriteAttributeValue("", 3426, "https://cms.cuhadaroglu.com/uploads/", 3426, 36, true);
#nullable restore
#line 59 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\SectionView\ContentDocument.cshtml"
WriteAttributeValue("", 3462, docu.Link, 3462, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                        <i class=\"id-color icon-download\"></i>&nbsp;");
#nullable restore
#line 60 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\SectionView\ContentDocument.cshtml"
                                                                                               Write(docu.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </a>\r\n                                                </p>\r\n                                            </div>\r\n");
#nullable restore
#line 64 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\SectionView\ContentDocument.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n\r\n                    </div>\r\n");
#nullable restore
#line 71 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\SectionView\ContentDocument.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 76 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\SectionView\ContentDocument.cshtml"
}
else if(viewType== "List")
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row"" style=""background-size: cover;"">
    <div class=""col-md-12"" style=""background-size: cover;"">
        <div class=""row"" style=""background-size: cover;"">
            <div class=""col-md-12 wow fadeInUp animated animated animated animated animated"" data-wow-delay="".3s"" style=""visibility: visible; animation-delay: 0.3s; animation-name: fadeInUp; background-size: cover; opacity: 0;"">
                ");
#nullable restore
#line 83 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\SectionView\ContentDocument.cshtml"
           Write(Html.Raw(content.ContentShort));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 84 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\SectionView\ContentDocument.cshtml"
           Write(Html.Raw(content.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>
    </div><div class=""col-md-12"" style=""background-size: cover;"">
        <div class=""row"" style=""background-size: cover;"">
            <div class=""col-md-12 wow fadeInUp animated animated animated animated animated animated animated"" data-wow-delay="".3s"" style=""visibility: visible; animation-delay: 0.3s; animation-name: fadeInUp; background-size: cover; opacity: 0;"">
                ");
#nullable restore
#line 90 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\SectionView\ContentDocument.cshtml"
           Write(Html.Raw(content.ContentData));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 95 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\SectionView\ContentDocument.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
