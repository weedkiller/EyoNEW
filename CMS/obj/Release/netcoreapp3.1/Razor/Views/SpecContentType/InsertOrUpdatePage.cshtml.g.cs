#pragma checksum "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMS\Views\SpecContentType\InsertOrUpdatePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94b3e1a3b6163ef04650ba079e4424c075264a55"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SpecContentType_InsertOrUpdatePage), @"mvc.1.0.view", @"/Views/SpecContentType/InsertOrUpdatePage.cshtml")]
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
#line 1 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMS\Views\_ViewImports.cshtml"
using CMS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMS\Views\_ViewImports.cshtml"
using Kendo.Mvc.UI;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94b3e1a3b6163ef04650ba079e4424c075264a55", @"/Views/SpecContentType/InsertOrUpdatePage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf3c12927ab877906462eb43fa69065321a6b025", @"/Views/_ViewImports.cshtml")]
    public class Views_SpecContentType_InsertOrUpdatePage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMS\Views\SpecContentType\InsertOrUpdatePage.cshtml"
  
    var PageType = "SpecContentType";
    var EnumText = "Spec İçerik Tipi";
    var postModel = ViewBag.postModel as SpecContentType;
    var selecttype = Context.Request.Query["selecttype"].ToInt();



    var dynamicRow = new DynamicModel()
    {
        model = postModel == null ? new SpecContentType() : postModel,
        controllerName = postModel == null ? new SpecContentType().GetType().Name : postModel.GetType().Name,
        PageType = PageType,
        titleName = EnumText + " " + (postModel?.Id > 0 ? "Güncelleme" : "Ekleme"),
        InsertMethodName = "InsertOrUpdate",
        labelClass = "col-md-4",
        inputClass = "col-md-8",
        colClass = "col-md-6",
        nonProp = "",
        orderby = "",
        addBtn = "<input type='submit' value='" + "Kaydet" + "' " + "class='btn btn-primary btn-shadow-hover font-weight-bold mr-2' />",
        removeBtn = $"<input dataid='{postModel?.Id}' type='button' value='Sil' class='btnDelete btn btn-danger btn-shadow-hover font-weight-bold mr-2' />",

    };

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
#line 34 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMS\Views\SpecContentType\InsertOrUpdatePage.cshtml"
                                                             Write(Html.Raw(EnumText));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
            <!--end::Page Title-->
            <!--begin::Action-->
            <div class=""subheader-separator subheader-separator-ver mt-2 mb-2 mr-4 bg-gray-200""></div>
            <span class=""text-muted font-weight-bold mr-4"">Sayfa Bilgisi</span>
            <a href=""#"" class=""btn btn-light-primary font-weight-bolder btn-sm"">");
#nullable restore
#line 39 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMS\Views\SpecContentType\InsertOrUpdatePage.cshtml"
                                                                           Write(Html.Raw("Yeni Kayıt"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
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
                    <ul class=""nav nav-tabs nav-bold nav-tabs-line nav-tabs-line-3x"">
                        <li class=""nav-item""><a class=""nav-link active"" data-toggle=""tab"" href=""#tab1"">");
#nullable restore
#line 56 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMS\Views\SpecContentType\InsertOrUpdatePage.cshtml"
                                                                                                  Write(Html.Raw(EnumText + " " + (postModel?.Id > 0 ? "Güncelleme" : "Ekleme")));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\n                    </ul>\n                </div>\n");
            WriteLiteral("            </div>\n            <div class=\"card-body\">\n                <div class=\"tab-content\">\n                    <div class=\"tab-pane fade show active\" id=\"tab1\" role=\"tabpanel\" aria-labelledby=\"tab1\">\n                        ");
#nullable restore
#line 64 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMS\Views\SpecContentType\InsertOrUpdatePage.cshtml"
                   Write(await Component.InvokeAsync("DynamicInput", dynamicRow));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n\n                </div>\n            </div>\n        </div>\n\n\n\n\n    </div>\n    <!--end::Container-->\n</div>\n<!--end::Entry-->\n<!--end::Content-->");
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
