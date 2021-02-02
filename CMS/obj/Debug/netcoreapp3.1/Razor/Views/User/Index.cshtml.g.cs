#pragma checksum "E:\projeler\bitbucketRepos\EyoNewCMS\CMS\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc08a42ae5b8cc0b991d97de1d41b760c1984513"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc08a42ae5b8cc0b991d97de1d41b760c1984513", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf3c12927ab877906462eb43fa69065321a6b025", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\projeler\bitbucketRepos\EyoNewCMS\CMS\Views\User\Index.cshtml"
  
    var pageName = "User";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!--begin::Content-->
<!--begin::Subheader-->
<div class=""subheader py-2 py-lg-6 subheader-transparent"" id=""kt_subheader"">
    <div class=""container-fluid d-flex align-items-center justify-content-between flex-wrap flex-sm-nowrap"">
        <!--begin::Info-->
        <div class=""d-flex align-items-center flex-wrap mr-2"">
            <!--begin::Page Title-->
            <h5 class=""text-dark font-weight-bold mt-2 mb-2 mr-5"">");
#nullable restore
#line 11 "E:\projeler\bitbucketRepos\EyoNewCMS\CMS\Views\User\Index.cshtml"
                                                             Write(Html.Raw("Kullanıcılar"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
            <!--end::Page Title-->
            <!--begin::Action-->
            <div class=""subheader-separator subheader-separator-ver mt-2 mb-2 mr-4 bg-gray-200""></div>
            <span class=""text-muted font-weight-bold mr-4"">Sayfa Bilgisi</span>
            <a");
            BeginWriteAttribute("href", " href=\"", 753, "\"", 799, 3);
            WriteAttributeValue("", 760, "/", 760, 1, true);
#nullable restore
#line 16 "E:\projeler\bitbucketRepos\EyoNewCMS\CMS\Views\User\Index.cshtml"
WriteAttributeValue("", 761, Html.Raw(pageName), 761, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 780, "/InsertOrUpdatePage", 780, 19, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-light-primary font-weight-bolder btn-sm"">Yeni Kayıt</a>
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
        <div class=""row"">
            <div class=""col-12"">
                ");
#nullable restore
#line 30 "E:\projeler\bitbucketRepos\EyoNewCMS\CMS\Views\User\Index.cshtml"
            Write(Html.Kendo().Grid<User>().Name("grid_"+ pageName)
                .Columns(columns => {
                    columns.Bound(o => o.Id).Groupable(false);
                    columns.Bound(p => p.UserName);
                    columns.Bound(o => o.Name);
                    columns.Bound(p => p.Surname);
                    columns.Bound(p => p.SexType);
                    columns.Bound(p => p.Mail1);
                    columns.Bound(p => p.Mail2);
                    columns.Bound(p => p.Phone1);

                    columns.Bound(p => p.Id)
                    .Sortable(false)
                    .Title("Detay")
                    .ClientTemplate("<a class='btn btn-sm btn-clean btn-icon btn-icon-md' href='/"+pageName+"/InsertOrUpdatePage?id=#=Id#' title='Detay'><i class='la la-edit'></i></a>");
                })
            .Pageable()
            .Sortable()
            .Filterable()
            .Scrollable()
            .Resizable(r => r.Columns(true))
            .Reorderable(r => r.Columns(true))
            .DataSource(dataSource =>
            dataSource
            .Ajax().Events(events => events.Error("error_handler"))
            .Read(read => read.Action("GetPaging", pageName))
            .PageSize(15)
            )
            );

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

            </div>
        </div>


    </div>
    <!--end::Container-->
</div>
<!--end::Entry-->
<!--end::Content-->

<script>
    function error_handler(e) {
        if (e.errors) {
            var message = ""Errors:\n"";
            $.each(e.errors, function (key, value) {
                if ('errors' in value) {
                    $.each(value.errors, function () {
                        message += this + ""\n"";
                    });
                }
            });
            alert(message);
        }
    }

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
