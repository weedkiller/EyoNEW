#pragma checksum "E:\projeler\bitbucketRepos\EyoNewCMS\CMS\Views\ContentPage\InsertOrUpdatePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74b897ec879e2bb33eea8de8dd762b4d16feb793"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ContentPage_InsertOrUpdatePage), @"mvc.1.0.view", @"/Views/ContentPage/InsertOrUpdatePage.cshtml")]
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
#line 1 "E:\projeler\bitbucketRepos\EyoNewCMS\CMS\Views\_ViewImports.cshtml"
using CMS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\projeler\bitbucketRepos\EyoNewCMS\CMS\Views\_ViewImports.cshtml"
using Kendo.Mvc.UI;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b897ec879e2bb33eea8de8dd762b4d16feb793", @"/Views/ContentPage/InsertOrUpdatePage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf3c12927ab877906462eb43fa69065321a6b025", @"/Views/_ViewImports.cshtml")]
    public class Views_ContentPage_InsertOrUpdatePage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\projeler\bitbucketRepos\EyoNewCMS\CMS\Views\ContentPage\InsertOrUpdatePage.cshtml"
   var postModel = ViewBag.postModel as ContentPage;
    var selecttype = Context.Request.Query["selecttype"].ToInt();
    var selectname = Context.Request.Query["selectname"].ToStr();
    var EnumText = selectname;
    var disabled = "BannerText,BannerButtonText,ButtonText,ButtonLink";

    if (postModel == null)
    {
        postModel = new ContentPage();
        postModel.ContentTypesId = selecttype;
        postModel.ContentPageId = null;
    }
    else
    {
        selecttype = postModel.ContentTypesId;
    }
    var TitleName = EnumText + " " + (postModel.Id > 0 ? "Güncelleme" : "Ekleme"); 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--begin::Content-->
<!--begin::Subheader-->
<div class=""subheader py-2 py-lg-6 subheader-transparent"" id=""kt_subheader"">
    <div class=""container-fluid d-flex align-items-center justify-content-between flex-wrap flex-sm-nowrap"">
        <!--begin::Info-->
        <div class=""d-flex align-items-center flex-wrap mr-2"">
            <!--begin::Page Title-->
            <h5 class=""text-dark font-weight-bold mt-2 mb-2 mr-5"">");
#nullable restore
#line 26 "E:\projeler\bitbucketRepos\EyoNewCMS\CMS\Views\ContentPage\InsertOrUpdatePage.cshtml"
                                                             Write(Html.Raw(EnumText));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
            <!--end::Page Title-->
            <!--begin::Action-->
            <div class=""subheader-separator subheader-separator-ver mt-2 mb-2 mr-4 bg-gray-200""></div>
            <span class=""text-muted font-weight-bold mr-4"">Sayfa Bilgisi</span>
            <a href=""#"" class=""btn btn-light-primary font-weight-bolder btn-sm"">Yeni Kayıt</a>
            <!--end::Action-->
        </div>
        <!--end::Info-->

    </div>
</div>
<!--end::Subheader-->
<!--begin::Entry-->
<div class=""d-flex flex-column-fluid"">
    <!--begin::Container-->
    <div class=""container-fluid"">

        <div class=""card card-custom"">
            <div class=""card-header card-header-tabs-line nav-tabs-line-3x"">
                <div class=""card-toolbar"">
                    <ul class=""tabbar nav nav-tabs nav-bold nav-tabs-line nav-tabs-line-3x"">
                        <li class=""nav-item""><a class=""nav-link active"" data-toggle=""tab"" href=""#tab1"">");
#nullable restore
#line 48 "E:\projeler\bitbucketRepos\EyoNewCMS\CMS\Views\ContentPage\InsertOrUpdatePage.cshtml"
                                                                                                  Write(Html.Raw(EnumText + " " + (postModel.Id > 0 ? "Güncelleme" : "Ekleme")));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\n");
#nullable restore
#line 49 "E:\projeler\bitbucketRepos\EyoNewCMS\CMS\Views\ContentPage\InsertOrUpdatePage.cshtml"
                         if (postModel.Id > 0)
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"nav-item\"><a class=\"nav-link\" data-toggle=\"tab\" href=\"#tab2\">");
#nullable restore
#line 52 "E:\projeler\bitbucketRepos\EyoNewCMS\CMS\Views\ContentPage\InsertOrUpdatePage.cshtml"
                                                                               Write(Html.Raw("Medya"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\n                            <li class=\"nav-item\"><a class=\"nav-link\" data-toggle=\"tab\" href=\"#tab3\">");
#nullable restore
#line 53 "E:\projeler\bitbucketRepos\EyoNewCMS\CMS\Views\ContentPage\InsertOrUpdatePage.cshtml"
                                                                                               Write(Html.Raw("Spec"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>");
#nullable restore
#line 53 "E:\projeler\bitbucketRepos\EyoNewCMS\CMS\Views\ContentPage\InsertOrUpdatePage.cshtml"
                                                                                                                              }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\n                </div>\n");
            WriteLiteral("            </div>\n");
            WriteLiteral("            <div class=\"card-body\">\n                <div class=\"tab-content\">\n                    <div class=\"tab-pane fade show active\" id=\"tab1\" role=\"tabpanel\" aria-labelledby=\"tab1\">\n                        ");
#nullable restore
#line 62 "E:\projeler\bitbucketRepos\EyoNewCMS\CMS\Views\ContentPage\InsertOrUpdatePage.cshtml"
                   Write(await Component.InvokeAsync("DynamicInput", new DynamicModel()
                        {
                            model = postModel,
                            controllerName = postModel.GetType().Name,
                            PageType = "ContentPage",
                            titleName = TitleName,
                            InsertMethodName = "InsertOrUpdate",
                            labelClass = "col-md-4",
                            inputClass = "col-md-8",
                            colClass = "col-md-6",
                            nonProp = disabled,
                            orderby = "",
                            addBtn = "<input type='submit' value='" + "Kaydet" + "' " + "class='btn btn-primary btn-shadow-hover font-weight-bold mr-2' />",
                            removeBtn = $"<input dataid='{postModel.Id}' type='button' value='Sil' class='btnDelete btn btn-danger btn-shadow-hover font-weight-bold mr-2' />",

                        }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n                    <div class=\"tab-pane fade\" id=\"tab2\" role=\"tabpanel\" aria-labelledby=\"tab2\">\n                        ");
#nullable restore
#line 80 "E:\projeler\bitbucketRepos\EyoNewCMS\CMS\Views\ContentPage\InsertOrUpdatePage.cshtml"
                   Write(await Component.InvokeAsync("DynamicInput", new DynamicModel()
                        {
                            model = postModel,
                            controllerName = postModel.GetType().Name,
                            PageType = "Documents",
                            titleName = "Medya",
                            InsertMethodName = "InsertOrUpdate",
                            labelClass = "col-md-4",
                            inputClass = "col-md-8",
                            colClass = "col-md-6",
                            nonProp = disabled,
                            orderby = "",
                            addBtn = "<input type='submit' value='" + "Ekle" + "' " + "class='btn btn-primary btn-shadow-hover font-weight-bold mr-2' />",
                            removeBtn = "",

                        }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n                    <div class=\"tab-pane fade\" id=\"tab3\" role=\"tabpanel\" aria-labelledby=\"tab3\">\n                        ");
#nullable restore
#line 98 "E:\projeler\bitbucketRepos\EyoNewCMS\CMS\Views\ContentPage\InsertOrUpdatePage.cshtml"
                   Write(await Component.InvokeAsync("DynamicInput", new DynamicModel()
                        {
                            model = postModel,
                            controllerName = postModel.GetType().Name,
                            PageType = "SpecDynamic",
                            titleName = TitleName,
                            InsertMethodName = "InsertOrUpdate",
                            labelClass = "col-md-4",
                            inputClass = "col-md-8",
                            colClass = "col-md-6",
                            nonProp = disabled,
                            orderby = "",
                            addBtn = "<input type='submit' value='" + "Kaydet" + "' " + "class='btn btn-primary btn-shadow-hover font-weight-bold mr-2' />",
                            removeBtn = "",

                        }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>




    </div>
    <!--end::Container-->
</div>
<!--end::Entry-->
<!--end::Content-->
<script>
    $(function () {
        $($('.tabbar li a')[0]).click();
    });
</script>");
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
