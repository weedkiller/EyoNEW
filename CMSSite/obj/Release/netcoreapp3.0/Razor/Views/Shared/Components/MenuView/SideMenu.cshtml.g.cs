#pragma checksum "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\MenuView\SideMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1eed493134e94dfa2145ec54622693a32b2e897a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_MenuView_SideMenu), @"mvc.1.0.view", @"/Views/Shared/Components/MenuView/SideMenu.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1eed493134e94dfa2145ec54622693a32b2e897a", @"/Views/Shared/Components/MenuView/SideMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f74a5ef60aca8ccb0793e472a7a82919353f59fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_MenuView_SideMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\MenuView\SideMenu.cshtml"
  
    Layout = null;
    var SideMenu = ViewBag.SideMenu as List<ContentPage>;
    var content = ViewBag.content as ContentPage;
    List<int> childRemove = new List<int>();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"sidebar\" class=\"col-md-3 wow fadeInUp\">\r\n    <ul id=\"services-list\">\r\n");
#nullable restore
#line 10 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\MenuView\SideMenu.cshtml"
         foreach (var item in SideMenu)
        {
            if (!childRemove.Contains(item.Id))
            {

                

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\MenuView\SideMenu.cshtml"
                 if (item.ContentPageChilds.Count > 0 && SideMenu.Any(a => item.ContentPageChilds.Select(d => d.Id).Contains(a.Id)))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>\r\n                        <div class=\"expand-group\">\r\n                            <div class=\"expand\">\r\n");
#nullable restore
#line 20 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\MenuView\SideMenu.cshtml"
                                 if (item.IsClickable==true)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <h4><a");
            BeginWriteAttribute("href", " href=\"", 802, "\"", 819, 1);
#nullable restore
#line 22 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\MenuView\SideMenu.cshtml"
WriteAttributeValue("", 809, item.Link, 809, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("style", " style=\"", 820, "\"", 919, 4);
            WriteAttributeValue("", 828, "padding:", 828, 8, true);
            WriteAttributeValue(" ", 836, "0px", 837, 4, true);
            WriteAttributeValue(" ", 840, "!important;", 841, 12, true);
#nullable restore
#line 22 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\MenuView\SideMenu.cshtml"
WriteAttributeValue(" ", 852, item.Link==content.Link?" border-bottom: 1px solid #FAB702;":"", 853, 66, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 22 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\MenuView\SideMenu.cshtml"
                                                                                                                                                            Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n");
#nullable restore
#line 23 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\MenuView\SideMenu.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <h4><p class=\"m-0\">");
#nullable restore
#line 26 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\MenuView\SideMenu.cshtml"
                                                  Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></h4>\r\n");
#nullable restore
#line 27 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\MenuView\SideMenu.cshtml"

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <div");
            BeginWriteAttribute("class", " class=\"", 1201, "\"", 1301, 1);
#nullable restore
#line 30 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\MenuView\SideMenu.cshtml"
WriteAttributeValue("", 1209, SideMenu.Any(x => x.ContentPageId == item.Id && x.Link==content.Link)?"":"hidden-content", 1209, 92, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 31 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\MenuView\SideMenu.cshtml"
                                     foreach (var itemC in SideMenu.Where(x => x.ContentPageId == item.Id))
                                    {
                                        if (string.IsNullOrEmpty(itemC.OutLink))
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <a ");
#nullable restore
#line 35 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\MenuView\SideMenu.cshtml"
                                           Write(itemC.Link == content.Link ? "class=active" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(" href=\"");
#nullable restore
#line 35 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\MenuView\SideMenu.cshtml"
                                                                                                    Write(itemC.Link);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 35 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\MenuView\SideMenu.cshtml"
                                                                                                                 Write(itemC.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 36 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\MenuView\SideMenu.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <a");
            BeginWriteAttribute("href", " href=\"", 1891, "\"", 1912, 1);
#nullable restore
#line 39 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\MenuView\SideMenu.cshtml"
WriteAttributeValue("", 1898, itemC.OutLink, 1898, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("target", " target=\"", 1913, "\"", 1974, 1);
#nullable restore
#line 39 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\MenuView\SideMenu.cshtml"
WriteAttributeValue("", 1922, itemC.OutLink.StartsWith("http")?"_blank":"_self", 1922, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 39 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\MenuView\SideMenu.cshtml"
                                                                                                                              Write(itemC.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 40 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\MenuView\SideMenu.cshtml"
                                        }
                                        childRemove.Add(itemC.Id);
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </li>\r\n");
#nullable restore
#line 47 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\MenuView\SideMenu.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li ");
#nullable restore
#line 50 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\MenuView\SideMenu.cshtml"
                    Write(content.Link == item.Link ? "class=active" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n");
#nullable restore
#line 51 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\MenuView\SideMenu.cshtml"
                         if (string.IsNullOrEmpty(item.OutLink))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a");
            BeginWriteAttribute("href", " href=\"", 2538, "\"", 2555, 1);
#nullable restore
#line 53 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\MenuView\SideMenu.cshtml"
WriteAttributeValue("", 2545, item.Link, 2545, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 53 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\MenuView\SideMenu.cshtml"
                                            Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 54 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\MenuView\SideMenu.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a");
            BeginWriteAttribute("href", " href=\"", 2687, "\"", 2707, 1);
#nullable restore
#line 57 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\MenuView\SideMenu.cshtml"
WriteAttributeValue("", 2694, item.OutLink, 2694, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("target", " target=\"", 2708, "\"", 2768, 1);
#nullable restore
#line 57 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\MenuView\SideMenu.cshtml"
WriteAttributeValue("", 2717, item.OutLink.StartsWith("http")?"_blank":"_self", 2717, 51, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 57 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\MenuView\SideMenu.cshtml"
                                                                                                            Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 58 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\MenuView\SideMenu.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </li>\r\n");
#nullable restore
#line 61 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\MenuView\SideMenu.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "E:\projeler\bitbucketRepos\cuhadaroglu\CMSSite\Views\Shared\Components\MenuView\SideMenu.cshtml"
                 

            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</div>\r\n");
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