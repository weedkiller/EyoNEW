#pragma checksum "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Base\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2b938e564ce81ae3ed46df030df96047513f6e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Base_Index), @"mvc.1.0.view", @"/Views/Base/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2b938e564ce81ae3ed46df030df96047513f6e8", @"/Views/Base/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f74a5ef60aca8ccb0793e472a7a82919353f59fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Base_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Base\Index.cshtml"
  
    Layout = "_Layout";
    var Pages = ViewBag.contentPages as List<ContentPage>;
    int LanguageID = ViewBag.LanguageID;
    var content = ViewBag.currContent as ContentPage;

    string currState = ViewBag.currState;

    ContentPage homeIntro = Pages.FirstOrDefault(x => x.Id == 13);
    var Projects = Pages.Where(x => x.ContentTypesId == 5).ToList();
    var Sliders = Pages.Where(x => x.ContentTypesId == 4).ToList();
    var Blogs = Pages.Where(x => x.ContentTypesId == 2).ToList();
    var Categories = Pages.Where(x => x.ContentTypesId == 3).Take(3).OrderBy(o => o.ContentOrderNo).ToList();

    //   var ProjectFilters = Pages.Where(x => x.ContentTypesId == 5).ToList();
    // var Projects = Pages.Where(x => ProjectFilters.Select(s => s.Id).ToList().Contains(x.ContentPageId ?? 0));

    var x = "asd";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- SLIDER START -->
<div id=""rev_slider_26_1_wrapper"" class=""rev_slider_wrapper fullscreen-container home-rev-slider"" data-alias=""mask-showcase"" data-source=""gallery"">
    <!-- START REVOLUTION SLIDER 5.4.1 fullscreen mode -->
    <div id=""rev_slider_26_1"" class=""rev_slider fullscreenbanner"" style=""display:none;"" data-version=""5.4.1"">
        <ul>
            <!-- SLIDE 1 -->
");
#nullable restore
#line 27 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Base\Index.cshtml"
             if (Sliders.Count() > 0)
            {
                foreach (var item in Sliders)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li data-index=\"rs-");
#nullable restore
#line 31 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Base\Index.cshtml"
                                  Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-transition=\"fade\" data-slotamount=\"default\" data-hideafterloop=\"0\" data-hideslideonmobile=\"off\" data-easein=\"default\" data-easeout=\"default\" data-masterspeed=\"300\" data-thumb=\"");
#nullable restore
#line 31 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Base\Index.cshtml"
                                                                                                                                                                                                                                  Write(item.ThumbImage!=null?item.ThumbImage.Link:"defaultImage");

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" data-rotate=""0"" data-saveperformance=""off"" data-title="""" data-param1=""1"" data-param2="""" data-param3="""" data-param4="""" data-param5="""" data-param6="""" data-param7="""" data-param8="""" data-param9="""" data-param10="""" data-description="""">
                        <!-- MAIN IMAGE -->
                        <img");
            BeginWriteAttribute("src", " src=\"", 1978, "\"", 2038, 1);
#nullable restore
#line 33 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Base\Index.cshtml"
WriteAttributeValue("", 1984, item.Picture!=null?item.Picture.Link:"defaultImage", 1984, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-bgcolor=\'#f8f8f8\'");
            BeginWriteAttribute("style", " style=\'", 2062, "\'", 2070, 0);
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2071, "\"", 2077, 0);
            EndWriteAttribute();
            WriteLiteral(@" data-bgposition=""center center"" data-bgfit=""cover"" data-bgrepeat=""no-repeat"" data-bgparallax=""off"" class=""rev-slidebg"" data-no-retina>
                        <!-- LAYER 1  right image overlay dark-->
                        <div class=""tp-caption tp-shape tp-shapewrapper  rs-parallaxlevel-tobggroup""");
            BeginWriteAttribute("id", "\r\n                             id=\"", 2382, "\"", 2431, 2);
            WriteAttributeValue("", 2417, "slide-", 2417, 6, true);
#nullable restore
#line 36 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Base\Index.cshtml"
WriteAttributeValue("", 2423, item.Id, 2423, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                             data-x=""['right','right','right','center']"" data-hoffset=""['0','0','0','0']""
                             data-y=""['middle','middle','middle','middle']"" data-voffset=""['0','0','0','0']""
                             data-fontweight=""['100','100','400','400']""
                             data-width=""['full','full','full','full']""
                             data-height=""['full','full','full','full']""
                             data-whitespace=""nowrap""
                             data-type=""shape""
                             data-basealign=""slide""
                             data-responsive_offset=""off""
                             data-responsive=""off""
                             data-frames='[{""from"":""opacity:0;"",""speed"":1500,""to"":""o:1;"",""delay"":150,""ease"":""Power2.easeInOut""},{""delay"":""wait"",""speed"":1500,""to"":""opacity:0;"",""ease"":""Power2.easeInOut""}]'
                             data-textAlign=""['left','left','left','left']""
                             data-p");
            WriteLiteral(@"addingtop=""[0,0,0,0]""
                             data-paddingright=""[0,0,0,0]""
                             data-paddingbottom=""[0,0,0,0]""
                             data-paddingleft=""[0,0,0,0]""
                             style=""z-index: 6;background-color:rgba(0,0,0,0.7);"">
                        </div>

                        <!-- LAYER 3  Thin text title-->
                        <div class=""tp-caption   tp-resizeme slider-tag-line""
                             id=""slide-72-layer-3""
                             data-x=""['left','left','center','center']"" data-hoffset=""['50','50','0','0']""
                             data-y=""['top','top','top','top']"" data-voffset=""['150','150','150','100']""
                             data-fontsize=""['22',22','20','16']""
                             data-lineheight=""['26','26','26','22']""
                             data-width=""['700','600','600','380']""
                             data-height=""none""
                             data-whitespace=");
            WriteLiteral(@"""nowrap""
                             data-type=""text""
                             data-responsive_offset=""on""
                             data-frames='[{""delay"":300,""speed"":750,""sfxcolor"":""#fff"",""sfx_effect"":""blockfromleft"",""frame"":""0"",""from"":""z:0;"",""to"":""o:1;"",""ease"":""Power3.easeInOut""},
                                {""delay"":""wait"",""speed"":500,""sfxcolor"":""#ffffff"",""sfx_effect"":""blocktoleft"",""frame"":""999"",""to"":""z:0;"",""ease"":""Power4.easeOut""}]'
                             data-textAlign=""['left','left','center','center']""
                             data-paddingtop=""[0,0,0,0]""
                             data-paddingright=""[0,0,0,0]""
                             data-paddingbottom=""[0,0,0,0]""
                             data-paddingleft=""[0,0,0,0]""
                             style=""z-index: 10; font-weight:500; letter-spacing:10px; color: #fff;font-family: 'Poppins', sans-serif; text-transform:uppercase""></div>

                        <!-- LAYER 4  Bold Title-->
                      ");
            WriteLiteral(@"  <div class=""tp-caption   tp-resizeme""
                             id=""slide-72-layer-4""
                             data-x=""['left','left','center','center']"" data-hoffset=""['46','46','0','0']""
                             data-y=""['top','top','top','top']"" data-voffset=""['190','190','190','150']""
                             data-fontsize=""['64','54','44','34']""
                             data-lineheight=""['80','70','60','50']""
                             data-width=""['700','600','500','380']""
                             data-height=""none""
                             data-whitespace=""normal""
                             data-type=""text""
                             data-responsive_offset=""on""
                             data-frames='[{""delay"":200,""speed"":750,""sfxcolor"":""#fff"",""sfx_effect"":""blockfromleft"",""frame"":""0"",""from"":""z:0;"",""to"":""o:1;"",""ease"":""Power3.easeInOut""},
                                {""delay"":""wait"",""speed"":500,""sfxcolor"":""#ffffff"",""sfx_effect"":""blocktoleft"",""frame"":""99");
            WriteLiteral(@"9"",""to"":""z:0;"",""ease"":""Power4.easeOut""}]'
                             data-textAlign=""['left','left','center','center']""
                             data-paddingtop=""[0,0,0,0]""
                             data-paddingright=""[0,0,0,0]""
                             data-paddingbottom=""[0,0,0,0]""
                             data-paddingleft=""[0,0,0,0]""
                             style=""z-index: 10;white-space: normal;font-weight: 800; color: #fff;font-family: 'Poppins', sans-serif;"">");
#nullable restore
#line 96 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Base\Index.cshtml"
                                                                                                                                  Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>

                            <!-- LAYER 5  Paragraph-->
                            <div class=""tp-caption   tp-resizeme""
                                 id=""slide-72-layer-5""
                                 data-x=""['left','left','center','center']"" data-hoffset=""['50','50','0','0']""
                                 data-y=""['middle','middle','middle','middle']"" data-voffset=""['30','60','50','70']""
                                 data-fontsize=""['18','18','18','16']""
                                 data-lineheight=""['30','30','30','30']""
                                 data-width=""['600','600','500','380']""
                                 data-height=""none""
                                 data-whitespace=""normal""
                                 data-type=""text""
                                 data-responsive_offset=""on""
                                 data-frames='[{""delay"":200,""speed"":750,""sfxcolor"":""#fff"",""sfx_effect"":""blockfromleft"",""frame"":""0"",""from"":""z:0;"",""to"":""o:1;"",""eas");
            WriteLiteral(@"e"":""Power3.easeInOut""},
                                {""delay"":""wait"",""speed"":500,""sfxcolor"":""#ffffff"",""sfx_effect"":""blocktoleft"",""frame"":""999"",""to"":""z:0;"",""ease"":""Power4.easeOut""}]'
                                 data-textAlign=""['left','left','center','center']""
                                 data-paddingtop=""[0,0,0,0]""
                                 data-paddingright=""[0,0,0,0]""
                                 data-paddingbottom=""[0,0,0,0]""
                                 data-paddingleft=""[0,0,0,0]""
                                 style=""z-index: 10; white-space: normal; color: #fff; font-family: 'Poppins', sans-serif;"">");
#nullable restore
#line 117 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Base\Index.cshtml"
                                                                                                                       Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 118 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Base\Index.cshtml"
                                 if (!string.IsNullOrEmpty(item.ExternalLink))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <!-- LAYER 6  Read More-->
                                    <div class=""tp-caption rev-btn  tp-resizeme""
                                         id=""slide-72-layer-6""
                                         data-x=""['left','left','center','center']"" data-hoffset=""['50','50','0','0']""
                                         data-y=""['middle','middle','middle','middle']"" data-voffset=""['120','140','140','150']""
                                         data-width=""none""
                                         data-height=""none""
                                         data-whitespace=""nowrap""
                                         data-type=""button""
                                         data-responsive_offset=""on""
                                         data-frames='[{""from"":""y:[-100%];z:0;rX:0deg;rY:0;rZ:0;sX:1;sY:1;skX:0;skY:0;"",""mask"":""x:0px;y:0px;s:inherit;e:inherit;"",
                                ""speed"":1500,""to"":""o:1;"",""delay"":1000,""ease"":""Pow");
            WriteLiteral(@"er3.easeInOut""},
                                {""delay"":""wait"",""speed"":500,""to"":""y:[-100%];"",""mask"":""x:inherit;y:inherit;s:inherit;e:inherit;"",""ease"":""Power1.easeIn""}]'
                                         data-textAlign=""['left','left','center','center']""
                                         data-paddingtop=""[0,0,0,0]""
                                         data-paddingright=""[0,0,0,0]""
                                         data-paddingbottom=""[0,0,0,0]""
                                         data-paddingleft=""[0,0,0,0]""
                                         style=""z-index:9; line-height:30px;""><a");
            BeginWriteAttribute("href", " href=\"", 10505, "\"", 10532, 1);
#nullable restore
#line 138 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Base\Index.cshtml"
WriteAttributeValue("", 10512, item.ExternalLink, 10512, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"site-button btn-half\"><span> ");
#nullable restore
#line 138 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Base\Index.cshtml"
                                                                                                                                            Write(item.ContentShort);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></a></div>\r\n");
#nullable restore
#line 139 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Base\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <!-- Border left Part -->
                                <div class=""tp-caption tp-shape tp-shapewrapper ""
                                     id=""slide-72-layer-8""
                                     data-x=""['center','center','center','center']"" data-hoffset=""['0','0','0','0']""
                                     data-y=""['middle','middle','middle','middle']"" data-voffset=""['0','0','0','0']""
                                     data-width=""full""
                                     data-height=""full""
                                     data-whitespace=""nowrap""
                                     data-visibility=""['on','off','off','off']""
                                     data-type=""shape""
                                     data-basealign=""slide""
                                     data-responsive_offset=""off""
                                     data-responsive=""off""
                                     data-frames='[{""delay"":50,""speed"":100,""frame"":""0");
            WriteLiteral(@""",""from"":""opacity:0;"",""to"":""o:1;"",""ease"":""Power3.easeInOut""},{""delay"":""wait"",""speed"":1000,""frame"":""999"",""to"":""opacity:0;"",""ease"":""Power3.easeIn""}]'
                                     data-textAlign=""['inherit','inherit','inherit','inherit']""
                                     data-paddingtop=""[0,0,0,0]""
                                     data-paddingright=""[0,0,0,0]""
                                     data-paddingbottom=""[0,0,0,0]""
                                     data-paddingleft=""[0,0,0,0]""
                                     style=""z-index:8;background-color:rgba(0, 0, 0, 0);border-left:40px solid #eef1f2;""> </div>

                                <!-- Border bottom Part -->
                                <div class=""tp-caption tp-shape tp-shapewrapper ""
                                     id=""slide-72-layer-7""
                                     data-x=""['center','center','center','center']"" data-hoffset=""['0','0','0','0']""
                                     data-y=""['middle'");
            WriteLiteral(@",'middle','middle','middle']"" data-voffset=""['0','0','0','0']""
                                     data-width=""full""
                                     data-height=""full""
                                     data-whitespace=""nowrap""
                                     data-visibility=""['on','on','off','off']""
                                     data-type=""shape""
                                     data-basealign=""slide""
                                     data-responsive_offset=""off""
                                     data-responsive=""off""
                                     data-frames='[{""delay"":50,""speed"":100,""frame"":""0"",""from"":""opacity:0;"",""to"":""o:1;"",""ease"":""Power3.easeInOut""},{""delay"":""wait"",""speed"":1000,""frame"":""999"",""to"":""opacity:0;"",""ease"":""Power3.easeIn""}]'
                                     data-textAlign=""['inherit','inherit','inherit','inherit']""
                                     data-paddingtop=""[0,0,0,0]""
                                     data-paddingright=""[0,0,0,");
            WriteLiteral(@"0]""
                                     data-paddingbottom=""[0,0,0,0]""
                                     data-paddingleft=""[0,0,0,0]""
                                     style=""z-index:8;background-color:rgba(0, 0, 0, 0);border-bottom:80px solid #eef1f2;""> </div>
                            </li>
");
#nullable restore
#line 182 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Base\Index.cshtml"

                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </ul>
        <div class=""tp-bannertimer""></div>
        <!-- left side social bar-->
        <div class=""slide-left-social"">
            <ul class=""clearfix"">
                <li><a href=""#"" class=""sx-title-swip"" data-hover=""Linkedin"">Linkedin</a></li>
                <li><a href=""#"" class=""sx-title-swip"" data-hover=""Twitter"">Twitter</a></li>
                <li><a href=""#"" class=""sx-title-swip"" data-hover=""Facebook"">Facebook</a></li>
            </ul>
        </div>

    </div>
</div>
<!-- SLIDER END -->

");
#nullable restore
#line 200 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Base\Index.cshtml"
 if (homeIntro != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <!-- ABOUT COMPANY START -->
    <div class=""section-full mobile-page-padding p-t80 p-b80 bg-white bg-no-repeat bg-bottom-left"" style=""background-image:url(images/background/bg-4.png)"">
        <div class=""container"">
            <!-- TITLE START -->
            <div class=""section-head"">
                <div class=""sx-separator-outer separator-left"">
                    <div class=""sx-separator bg-white bg-moving bg-repeat-x"" style=""background-image:url(images/background/cross-line2.png)"">
                        <h3 class=""sep-line-one"">");
#nullable restore
#line 209 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Base\Index.cshtml"
                                            Write(homeIntro.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                    </div>
                </div>
            </div>
            <!-- TITLE END -->

            <div class=""section-content"">
                <div class=""row"">

                    <div class=""col-lg-5 col-md-12 col-sm-12"">
                        <div class=""about-home-left"">
                            <h3 class=""m-t0 sx-tilte"">");
#nullable restore
#line 220 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Base\Index.cshtml"
                                                 Write(homeIntro.ContentShort);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            <p>");
#nullable restore
#line 221 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Base\Index.cshtml"
                          Write(homeIntro.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                            <div class=""text-left"">
                                <a href=""javascript:;"" class=""site-button-secondry btn-half""><span>Devamı</span></a>
                            </div>
                        </div>
                    </div>

                    <div class=""col-lg-7 col-md-12 col-sm-12"">
                        <div class=""about-home-right"">
                            <div class=""owl-carousel about-home number-slider owl-btn-vertical-center"">

");
#nullable restore
#line 232 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Base\Index.cshtml"
                                 foreach (var item in homeIntro.Gallery.ToList())
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <!-- COLUMNS 1 -->
                                    <div class=""item "">
                                        <div class=""sx-img-effect zoom-slow"">
                                            <a href=""javascript:void(0);""><img");
            BeginWriteAttribute("src", " src=\"", 16552, "\"", 16568, 1);
#nullable restore
#line 237 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Base\Index.cshtml"
WriteAttributeValue("", 16558, item.Link, 16558, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 16569, "\"", 16584, 1);
#nullable restore
#line 237 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Base\Index.cshtml"
WriteAttributeValue("", 16575, item.Alt, 16575, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                                        </div>\r\n                                    </div>\r\n");
#nullable restore
#line 240 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Base\Index.cshtml"

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                            </div>\r\n                            <div class=\"about-home-before\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 16858, "\"", 16928, 1);
#nullable restore
#line 246 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Base\Index.cshtml"
WriteAttributeValue("", 16864, homeIntro.Picture!=null?homeIntro.Picture.Link:"defaultImage", 16864, 64, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 16929, "\"", 16935, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n");
#nullable restore
#line 257 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Base\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- ABOUT COMPANY END -->
<!-- WHAT WE DO START -->
<div class=""section-full  mobile-page-padding bg-white  p-t80 p-b30 bg-repeat overflow-hide"" style=""background-image:url(images/background/bg-5.png);"">

    <div class=""container right-half-bg-image-outer"">
        <div class=""right-half-bg-image bg-parallax bg-fixed bg-top-right"" data-stellar-background-ratio=""0"" style=""background-image:url(images/background/bg-2.jpg)""></div>
        <!-- TITLE START -->
        <div class=""section-head"">
            <div class=""sx-separator-outer separator-left"">
                <div class=""sx-separator bg-white bg-moving bg-repeat-x"" style=""background-image:url(images/background/cross-line2.png)"">
                    <h3 class=""sep-line-one"">What We Offer</h3>
                </div>
            </div>
        </div>
        <!-- TITLE END -->
        <div class=""section-content"">
            <div class=""row number-block-one-outer justify-content-center"">
");
#nullable restore
#line 275 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Base\Index.cshtml"
                   var i = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 276 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Base\Index.cshtml"
                 foreach (var item in Categories)
                {
                    i++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-4 col-md-6 col-sm-6 m-b30\">\r\n\r\n                        <div class=\"number-block-one animate-in-to-top\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 18394, "\"", 18460, 1);
#nullable restore
#line 282 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Base\Index.cshtml"
WriteAttributeValue("", 18400, item.ThumbImage!=null?item.ThumbImage.Link:"defaultImage", 18400, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 18461, "\"", 18514, 1);
#nullable restore
#line 282 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Base\Index.cshtml"
WriteAttributeValue("", 18467, item.ThumbImage!=null?item.ThumbImage.Alt:"", 18467, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                            <div class=\"figcaption bg-white text-center p-a20\">\r\n                                <h4 class=\"m-a0\">");
#nullable restore
#line 284 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Base\Index.cshtml"
                                            Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                            </div>\r\n                            <div class=\"figcaption-number text-center sx-text-primary animate-in-to-top-content\">\r\n                                <span>0");
#nullable restore
#line 287 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Base\Index.cshtml"
                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                        </div>\r\n\r\n                    </div>\r\n");
#nullable restore
#line 292 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Base\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n            </div>\r\n\r\n\r\n");
            WriteLiteral(@"        </div>
    </div>
</div>
<!-- WHAT WE DO END -->
<!-- PROJECTS START -->
<div class=""section-full mobile-page-padding  p-t80 p-b50 bg-white"">
    <div class=""section-content"">
        <div class=""container"">
            <!-- TITLE START -->
            <div class=""section-head"">
                <div class=""sx-separator-outer separator-center"">
                    <div class=""sx-separator bg-white bg-moving bg-repeat-x"" style=""background-image:url(images/background/cross-line2.png)"">
                        <h3 class=""sep-line-one"">Projeler</h3>
                    </div>
                </div>
            </div>
            <!-- TITLE END -->
        </div>

        <div class="" filter-carousal-1-outer relative z-index1"">
            <!-- TITLE END -->
            <div class=""filter-carousal-1  container-fluid p-b30"">
                <!-- IMAGE CAROUSEL START -->
                <div class=""section-content "">
                    <div class=""owl-carousel owl-carousel-filter  owl");
            WriteLiteral("-btn-bottom-center mfp-gallery navigation-with-name\">\r\n");
#nullable restore
#line 343 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Base\Index.cshtml"
                         foreach (var item in Projects)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <!-- COLUMNS 1 -->
                            <div class=""item fadingcol col-one overflow-hide"">
                                <div class=""sx-box   image-hover-block"">
                                    <div class=""sx-thum-bx"">
                                        <img");
            BeginWriteAttribute("src", " src=\"", 21480, "\"", 21580, 1);
#nullable restore
#line 349 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Base\Index.cshtml"
WriteAttributeValue("", 21486, item.ThumbImage!=null?item.ThumbImage.Link:"/assets-site/images/projects/portrait/pic1.jpg", 21486, 94, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 21581, "\"", 21587, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    </div>\r\n                                    <div class=\"sx-info  p-t20 text-white\">\r\n                                        <h4 class=\"sx-tilte\"><a");
            BeginWriteAttribute("href", " href=\"", 21775, "\"", 21792, 1);
#nullable restore
#line 352 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Base\Index.cshtml"
WriteAttributeValue("", 21782, item.Link, 21782, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 352 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Base\Index.cshtml"
                                                                             Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                                        <p class=\"m-b0\"></p>\r\n                                    </div>\r\n");
            WriteLiteral("                                </div>\r\n                            </div>\r\n                            <!-- COLUMNS 2 -->\r\n");
#nullable restore
#line 361 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Base\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- PROJECTS  END -->
<!-- OUR BLOG START -->
<div class=""section-full mobile-page-padding bg-white p-t80 p-b50 mobile-page-padding"">
    <div class=""container"">

        <!-- TITLE START -->
        <div class=""section-head"">
            <div class=""sx-separator-outer separator-center"">
                <div class=""sx-separator bg-white bg-moving bg-repeat-x"" style=""background-image:url(images/background/cross-line2.png)"">
                    <h3 class=""sep-line-one"">Blog</h3>
                </div>
            </div>
        </div>
        <!-- TITLE END -->
        <!-- IMAGE CAROUSEL START -->
        <div class=""section-content"">
            <div class=""row justify-content-center"">
");
#nullable restore
#line 385 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Base\Index.cshtml"
                 foreach (var item in Blogs)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""col-lg-4 col-md-6 col-sm-12"">
                        <div class=""blog-post blog-grid date-style-2"">

                            <div class=""sx-post-media sx-img-effect img-reflection"">
                                <a href=""javascript:void(0);""><img");
            BeginWriteAttribute("src", " src=\"", 23451, "\"", 23551, 1);
#nullable restore
#line 391 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Base\Index.cshtml"
WriteAttributeValue("", 23457, item.ThumbImage!=null?item.ThumbImage.Link:"/assets-site/images/projects/portrait/pic1.jpg", 23457, 94, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 23552, "\"", 23612, 1);
#nullable restore
#line 391 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Base\Index.cshtml"
WriteAttributeValue("", 23558, item.ThumbImage!=null?item.ThumbImage.Alt:item.Name, 23558, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                            </div>\r\n\r\n                            <div class=\"sx-post-info p-t30\">\r\n                                <!--<div class=\"sx-post-meta \">\r\n                                    <ul>\r\n");
            WriteLiteral("                                        <li class=\"post-date\"><strong>");
#nullable restore
#line 398 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Base\Index.cshtml"
                                                                  Write(string.IsNullOrEmpty(item.CreaDate.ToString())?"": item.CreaDate.Day.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> <span>");
#nullable restore
#line 398 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Base\Index.cshtml"
                                                                                                                                                                    Write(string.IsNullOrEmpty(item.CreaDate.ToString())?"": item.CreaDate.ToString("MMMM").Substring(0, 3).ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span> </li>
                                    </ul>
                                </div>
                                                                  -->
                                <div class=""sx-post-title "">
                                    <h4 class=""post-title""><a href=""javascript:void(0);"">");
#nullable restore
#line 403 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Base\Index.cshtml"
                                                                                    Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                                </div>\r\n\r\n                                <div class=\"sx-post-readmore\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 24653, "\"", 24670, 1);
#nullable restore
#line 407 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Base\Index.cshtml"
WriteAttributeValue("", 24660, item.Link, 24660, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" title=\"READ MORE\" rel=\"bookmark\" class=\"site-button-link\">Devamı</a>\r\n                                </div>\r\n\r\n                            </div>\r\n\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 414 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMSSite\Views\Base\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"hilite-title text-left p-l50 text-uppercase\">\r\n        <strong>Blog</strong>\r\n    </div>\r\n</div>\r\n<!-- OUR BLOG END -->\r\n");
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
