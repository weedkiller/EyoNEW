#pragma checksum "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMS\Views\ContentPage\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a0cc8bb323f7d5d00f9fd260f2c16bdd8927110"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ContentPage_Index), @"mvc.1.0.view", @"/Views/ContentPage/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a0cc8bb323f7d5d00f9fd260f2c16bdd8927110", @"/Views/ContentPage/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf3c12927ab877906462eb43fa69065321a6b025", @"/Views/_ViewImports.cshtml")]
    public class Views_ContentPage_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMS\Views\ContentPage\Index.cshtml"
   
    string control_Name_ContentPage = "ContentPage";
    var dt_ContentPage = "#dt_" + control_Name_ContentPage;
    var selecttype_ContentPage = Context.Request.Query["selecttype"].ToInt();
    var selectname_ContentPage = Context.Request.Query["selectname"].ToStr();
    var descname = Context.Request.Query["descname"].ToStr();
    var list = ViewBag.list as List<ContentPage>; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<script type=\"text/javascript\">\n    var control_Name_ContentPage = \"");
#nullable restore
#line 9 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMS\Views\ContentPage\Index.cshtml"
                               Write(control_Name_ContentPage);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\n    var dt_ContentPage = \"#dt_\" + control_Name_ContentPage;\n    var selecttype_ContentPage = \"");
#nullable restore
#line 11 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMS\Views\ContentPage\Index.cshtml"
                             Write(selecttype_ContentPage);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\n    var selectname_ContentPage = \"");
#nullable restore
#line 12 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMS\Views\ContentPage\Index.cshtml"
                             Write(selectname_ContentPage);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""";
</script>
<style>
    .hideMe {
        display: none
    }
</style>
<script>
    $(function () {
        var table = $(dt_ContentPage).DataTable({
            ""language"": {
                ""url"": ""https://cdn.datatables.net/plug-ins/1.10.19/i18n/Turkish.json"",
            },
            ""dom"": ""<'row'<'col-sm-12 col-md-6'l><'col-sm-12 hideMe col-md-6'B><'col-sm-12 col-md-6'f>><'row'><'row'<'col-sm-12'tr>><'row'<'col-sm-12 col-md-10'i><'col-sm-12 col-md-2'p>>"",
            fixedHeader: true,
            buttons: ['copyHtml5', 'excelHtml5', 'csvHtml5', 'pdfHtml5'],
            ""pageLength"": 100,
            ""DisplayLength"": 100,
            ""lengthMenu"": [[100, 500, 5000], [100, 500, 5000]],
            ""lengthChange"": true,
            ""fnDrawCallback"": function (settings, json) { 
                $("".buttons-excel-top"").click(function () {
                    $("".buttons-excel"").click(); $("".buttons-excel"").trigger('click'); 
                    return false;
                })
                $("".buttons");
            WriteLiteral(@"-copy-top"").click(function () {
                    $("".buttons-copy"").click(); $("".buttons-copy"").trigger('click');
                    return false;
                })
                $("".buttons-csv-top"").click(function () {
                    $("".buttons-csv"").click(); $("".buttons-csv"").trigger('click');
                    return false;
                })
                $("".buttons-pdf-top"").click(function () {
                    $("".buttons-pdf"").click(); $("".buttons-pdf"").trigger('click');
                    return false;
                })
                //ayarlar() lBfrtip;
            },
        });
        //$(dt_ContentPage).DataTable({ responsive: !0,  columns: [{ data: ""OrderID"" }, { data: ""Country"" }, { data: ""ShipCity"" }, { data: ""CompanyName"" }, { data: ""ShipDate"" }, { data: ""Status"" }, { data: ""Type"" }, { data: ""Actions"", responsivePriority: -1 }], columnDefs: [{ targets: -1, title: ""Actions"", orderable: !1, render: function (t, a, l, e) { return '\t\t\t\t\t\t\t<div class=""dropdown drop");
            WriteLiteral(@"down-inline"">\t\t\t\t\t\t\t\t<a href=""javascript:;"" class=""btn btn-sm btn-clean btn-icon"" data-toggle=""dropdown"">\t                                <i class=""la la-cog""></i>\t                            </a>\t\t\t\t\t\t\t  \t<div class=""dropdown-menu dropdown-menu-sm dropdown-menu-right"">\t\t\t\t\t\t\t\t\t<ul class=""nav nav-hoverable flex-column"">\t\t\t\t\t\t\t    \t\t<li class=""nav-item""><a class=""nav-link"" href=""#""><i class=""nav-icon la la-edit""></i><span class=""nav-text"">Edit Details</span></a></li>\t\t\t\t\t\t\t    \t\t<li class=""nav-item""><a class=""nav-link"" href=""#""><i class=""nav-icon la la-leaf""></i><span class=""nav-text"">Update Status</span></a></li>\t\t\t\t\t\t\t    \t\t<li class=""nav-item""><a class=""nav-link"" href=""#""><i class=""nav-icon la la-print""></i><span class=""nav-text"">Print</span></a></li>\t\t\t\t\t\t\t\t\t</ul>\t\t\t\t\t\t\t  \t</div>\t\t\t\t\t\t\t</div>\t\t\t\t\t\t\t<a href=""javascript:;"" class=""btn btn-sm btn-clean btn-icon"" title=""Edit details"">\t\t\t\t\t\t\t\t<i class=""la la-edit""></i>\t");
            WriteLiteral(@"\t\t\t\t\t\t</a>\t\t\t\t\t\t\t<a href=""javascript:;"" class=""btn btn-sm btn-clean btn-icon"" title=""Delete"">\t\t\t\t\t\t\t\t<i class=""la la-trash""></i>\t\t\t\t\t\t\t</a>\t\t\t\t\t\t' } }, { width: ""75px"", targets: -3, render: function (t, a, l, e) { var s = { 1: { title: ""Pending"", class: ""label-light-primary"" }, 2: { title: ""Delivered"", class: "" label-light-danger"" }, 3: { title: ""Canceled"", class: "" label-light-primary"" }, 4: { title: ""Success"", class: "" label-light-success"" }, 5: { title: ""Info"", class: "" label-light-info"" }, 6: { title: ""Danger"", class: "" label-light-danger"" }, 7: { title: ""Warning"", class: "" label-light-warning"" } }; return void 0 === s[t] ? t : '<span class=""label label-lg font-weight-bold' + s[t].class + ' label-inline"">' + s[t].title + ""</span>"" } }, { width: ""75px"", targets: -2, render: function (t, a, l, e) { var s = { 1: { title: ""Online"", state: ""danger"" }, 2: { title: ""Retail"", state: ""primary"" }, 3: { title: ""Direct"", state: ""success"" } }; return void 0 === s[t] ? t : '<span class");
            WriteLiteral(@"=""label label-' + s[t].state + ' label-dot mr-2""></span><span class=""font-weight-bold text-' + s[t].state + '"">' + s[t].title + ""</span>"" } }] })

        //jQuery(document).ready((function () { KTDatatablesDataSourceAjaxClient.init() })); 
    }); 
    $(document).ready(function () {
        $("".buttons-excel-top"").click(function () {
            $("".buttons-excel"").click(); $("".buttons-excel"").trigger('click');
            return false;
        })
        $("".buttons-copy-top"").click(function () {
            $("".buttons-copy"").click(); $("".buttons-copy"").trigger('click');
            return false;
        })
        $("".buttons-csv-top"").click(function () {
            $("".buttons-csv"").click(); $("".buttons-csv"").trigger('click');
            return false;
        })
        $("".buttons-pdf-top"").click(function () {
            $("".buttons-pdf"").click(); $("".buttons-pdf"").trigger('click');
            return false;
        })
    })
</script> 
");
            WriteLiteral(@"<div class=""subheader py-2 py-lg-6 subheader-transparent"" id=""kt_subheader"">
    <div class=""container-fluid d-flex align-items-center justify-content-between flex-wrap flex-sm-nowrap"">
        <div class=""d-flex align-items-center flex-wrap mr-2"">
            <h5 class=""text-dark font-weight-bold mt-2 mb-2 mr-5"">");
#nullable restore
#line 176 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMS\Views\ContentPage\Index.cshtml"
                                                             Write(Html.Raw(selectname_ContentPage + " Sayfası"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
            <div class=""subheader-separator subheader-separator-ver mt-2 mb-2 mr-4 bg-gray-200""></div>
            <span class=""text-muted font-weight-bold mr-4"">Sayfa Bilgisi</span>
        </div>
    </div>
</div>
<div class=""d-flex flex-column-fluid"">
    <div class=""container"">
        <div class=""alert alert-custom alert-white alert-shadow gutter-b"" role=""alert"">
            <div class=""alert-icon"">
                <span class=""svg-icon svg-icon-primary svg-icon-xl"">
                    <!--begin::Svg Icon | path:/metronic/theme/html/demo1/dist/assets/media/svg/icons/Tools/Compass.svg-->
                    <svg xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"" width=""24px"" height=""24px"" viewBox=""0 0 24 24"" version=""1.1"">
                        <g stroke=""none"" stroke-width=""1"" fill=""none"" fill-rule=""evenodd"">
                            <rect x=""0"" y=""0"" width=""24"" height=""24"" />
                            <path d=""M7.07744993,12.3040451 C7.72444571,13.0716094 8.54044");
            WriteLiteral(@"565,13.6920474 9.46808594,14.1079953 L5,23 L4.5,18 L7.07744993,12.3040451 Z M14.5865511,14.2597864 C15.5319561,13.9019016 16.375416,13.3366121 17.0614026,12.6194459 L19.5,18 L19,23 L14.5865511,14.2597864 Z M12,3.55271368e-14 C12.8284271,3.53749572e-14 13.5,0.671572875 13.5,1.5 L13.5,4 L10.5,4 L10.5,1.5 C10.5,0.671572875 11.1715729,3.56793164e-14 12,3.55271368e-14 Z"" fill=""#000000"" opacity=""0.3"" />
                            <path d=""M12,10 C13.1045695,10 14,9.1045695 14,8 C14,6.8954305 13.1045695,6 12,6 C10.8954305,6 10,6.8954305 10,8 C10,9.1045695 10.8954305,10 12,10 Z M12,13 C9.23857625,13 7,10.7614237 7,8 C7,5.23857625 9.23857625,3 12,3 C14.7614237,3 17,5.23857625 17,8 C17,10.7614237 14.7614237,13 12,13 Z"" fill=""#000000"" fill-rule=""nonzero"" />
                        </g>
                    </svg>
                </span>
            </div>
            <div class=""alert-text"">
                ");
#nullable restore
#line 198 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMS\Views\ContentPage\Index.cshtml"
           Write(Html.Raw(descname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n        <div class=\"card card-custom\">\n            <div class=\"card-header flex-wrap border-0 pt-6 pb-0\">\n                <div class=\"card-title\">\n                    <h3 class=\"card-label\">\n                        ");
#nullable restore
#line 205 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMS\Views\ContentPage\Index.cshtml"
                   Write(Html.Raw(selectname_ContentPage));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        <span class=""text-muted pt-2 font-size-sm d-block"">Sayfa Bilgisi</span>
                    </h3>
                </div>
                <div class=""card-toolbar"">
                    <div class=""dropdown dropdown-inline mr-2"">
                        <button type=""button"" class=""btn btn-light-primary font-weight-bolder dropdown-toggle"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                            <span class=""svg-icon svg-icon-md"">
                                <!--begin::Svg Icon | path:/metronic/theme/html/demo1/dist/assets/media/svg/icons/Design/PenAndRuller.svg-->
                                <svg xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"" width=""24px"" height=""24px"" viewBox=""0 0 24 24"" version=""1.1"">
                                    <g stroke=""none"" stroke-width=""1"" fill=""none"" fill-rule=""evenodd"">
                                        <rect x=""0"" y=""0"" width=""24"" height=""24"" />
                        ");
            WriteLiteral(@"                <path d=""M3,16 L5,16 C5.55228475,16 6,15.5522847 6,15 C6,14.4477153 5.55228475,14 5,14 L3,14 L3,12 L5,12 C5.55228475,12 6,11.5522847 6,11 C6,10.4477153 5.55228475,10 5,10 L3,10 L3,8 L5,8 C5.55228475,8 6,7.55228475 6,7 C6,6.44771525 5.55228475,6 5,6 L3,6 L3,4 C3,3.44771525 3.44771525,3 4,3 L10,3 C10.5522847,3 11,3.44771525 11,4 L11,19 C11,19.5522847 10.5522847,20 10,20 L4,20 C3.44771525,20 3,19.5522847 3,19 L3,16 Z"" fill=""#000000"" opacity=""0.3"" />
                                        <path d=""M16,3 L19,3 C20.1045695,3 21,3.8954305 21,5 L21,15.2485298 C21,15.7329761 20.8241635,16.200956 20.5051534,16.565539 L17.8762883,19.5699562 C17.6944473,19.7777745 17.378566,19.7988332 17.1707477,19.6169922 C17.1540423,19.602375 17.1383289,19.5866616 17.1237117,19.5699562 L14.4948466,16.565539 C14.1758365,16.200956 14,15.7329761 14,15.2485298 L14,5 C14,3.8954305 14.8954305,3 16,3 Z"" fill=""#000000"" />
                                    </g>
                                </svg>
                          ");
            WriteLiteral(@"      <!--end::Svg Icon-->
                            </span>Export
                        </button>
                        <!--begin::Dropdown Menu-->
                        <div class=""dropdown-menu dropdown-menu-sm dropdown-menu-right"">
                            <!--begin::Navigation-->
                            <ul class=""navi flex-column navi-hover py-2"">
                                <li class=""navi-header font-weight-bolder text-uppercase font-size-sm text-primary pb-2"">Choose an option:</li>
                                <li class=""navi-item"">
                                    <a href=""#"" class=""navi-link buttons-copy-top"">
                                        <span class=""navi-icon"">
                                            <i class=""la la-copy""></i>
                                        </span>
                                        <span class=""navi-text"">Copy</span>
                                    </a>
                                </li>
                               ");
            WriteLiteral(@" <li class=""navi-item"">
                                    <a href=""#"" class=""navi-link buttons-excel-top"">
                                        <span class=""navi-icon"">
                                            <i class=""la la-file-excel-o""></i>
                                        </span>
                                        <span class=""navi-text"">Excel</span>
                                    </a>
                                </li>
                                <li class=""navi-item"">
                                    <a href=""#"" class=""navi-link buttons-csv-top"">
                                        <span class=""navi-icon"">
                                            <i class=""la la-file-text-o""></i>
                                        </span>
                                        <span class=""navi-text"">CSV</span>
                                    </a>
                                </li>
                                <li class=""navi-item"">
                             ");
            WriteLiteral(@"       <a href=""#"" class=""navi-link buttons-pdf-top"">
                                        <span class=""navi-icon"">
                                            <i class=""la la-file-pdf-o""></i>
                                        </span>
                                        <span class=""navi-text"">PDF</span>
                                    </a>
                                </li>
                            </ul>
                            <!--end::Navigation-->
                        </div>
                        <!--end::Dropdown Menu-->
                    </div>
                    <!--end::Dropdown-->
                    <!--begin::Button-->

                    <a");
            BeginWriteAttribute("href", " href=\"", 18294, "\"", 18426, 6);
            WriteAttributeValue("", 18301, "/", 18301, 1, true);
#nullable restore
#line 269 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMS\Views\ContentPage\Index.cshtml"
WriteAttributeValue("", 18302, Html.Raw(control_Name_ContentPage), 18302, 35, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 18337, "/InsertOrUpdatePage?selecttype=", 18337, 31, true);
#nullable restore
#line 269 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMS\Views\ContentPage\Index.cshtml"
WriteAttributeValue("", 18368, selecttype_ContentPage, 18368, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 18391, "&selectname=", 18391, 12, true);
#nullable restore
#line 269 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMS\Views\ContentPage\Index.cshtml"
WriteAttributeValue("", 18403, selectname_ContentPage, 18403, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-primary font-weight-bolder"">
                        <span class=""svg-icon svg-icon-md"">
                            <!--begin::Svg Icon | path:/metronic/theme/html/demo1/dist/assets/media/svg/icons/Design/Flatten.svg-->
                            <svg xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"" width=""24px"" height=""24px"" viewBox=""0 0 24 24"" version=""1.1"">
                                <g stroke=""none"" stroke-width=""1"" fill=""none"" fill-rule=""evenodd"">
                                    <rect x=""0"" y=""0"" width=""24"" height=""24"" />
                                    <circle fill=""#000000"" cx=""9"" cy=""15"" r=""6"" />
                                    <path d=""M8.8012943,7.00241953 C9.83837775,5.20768121 11.7781543,4 14,4 C17.3137085,4 20,6.6862915 20,10 C20,12.2218457 18.7923188,14.1616223 16.9975805,15.1987057 C16.9991904,15.1326658 17,15.0664274 17,15 C17,10.581722 13.418278,7 9,7 C8.93357256,7 8.86733422,7.00080962 8.8012943,7.00241953 Z"" fill=""#000000"" opac");
            WriteLiteral("ity=\"0.3\" />\n                                </g>\n                            </svg>\n                        </span>Yeni Kayıt\n                    </a>\n                </div>\n            </div>\n            <div class=\"card-body\">\n                <table");
            BeginWriteAttribute("id", " id=\"", 19703, "\"", 19736, 2);
            WriteAttributeValue("", 19708, "dt_", 19708, 3, true);
#nullable restore
#line 284 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMS\Views\ContentPage\Index.cshtml"
WriteAttributeValue("", 19711, control_Name_ContentPage, 19711, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""table table-bordered table-hover table-checkable"" style=""margin-top: 13px !important"">

                    <thead>
                        <tr>
                            <th>ID</th>
                            <th>Başlık</th>
                            <th>Üst Kategori</th>
                            <th>İçerik Tipi</th>
                            <th>Şablon Tipi</th>
                            <th>Tarih</th>
                            <th>Durum</th>
                            <th>Detail</th>

                        </tr>
                    </thead>

                    <tbody>
");
#nullable restore
#line 301 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMS\Views\ContentPage\Index.cshtml"
                         foreach (var item in list)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td style=\"vertical-align:middle\">");
#nullable restore
#line 304 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMS\Views\ContentPage\Index.cshtml"
                                             Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td style=\"vertical-align:middle\">");
#nullable restore
#line 305 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMS\Views\ContentPage\Index.cshtml"
                                             Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td style=\"vertical-align:middle\">");
#nullable restore
#line 306 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMS\Views\ContentPage\Index.cshtml"
                                             Write(item.Parent?.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td style=\"vertical-align:middle\">");
#nullable restore
#line 307 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMS\Views\ContentPage\Index.cshtml"
                                             Write(item.ContentTypes?.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td style=\"vertical-align:middle\">");
#nullable restore
#line 308 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMS\Views\ContentPage\Index.cshtml"
                                             Write(item.TemplateType.ExGetDescription());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td style=\"vertical-align:middle\">");
#nullable restore
#line 309 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMS\Views\ContentPage\Index.cshtml"
                                             Write(item.CreaDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td style=\"vertical-align:middle\">\n");
#nullable restore
#line 311 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMS\Views\ContentPage\Index.cshtml"
                     if (item.IsActive == true)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <span class=\"label label-success label-dot mr-2\"></span>\n                        <span class=\"font-weight-bold text-success\">Yayında</span> ");
#nullable restore
#line 314 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMS\Views\ContentPage\Index.cshtml"
                                                                                   }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <span class=\"label label-danger label-dot mr-2\"></span>\n                        <span class=\"font-weight-bold text-danger\">Yayında Değil</span>");
#nullable restore
#line 318 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMS\Views\ContentPage\Index.cshtml"
                                                                                       }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td style=\"vertical-align:middle\">\n                    <a class=\"btn btn-sm btn-clean btn-icon btn-icon-md\"");
            BeginWriteAttribute("href", " href=\"", 21492, "\"", 21556, 4);
            WriteAttributeValue("", 21499, "/", 21499, 1, true);
#nullable restore
#line 322 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMS\Views\ContentPage\Index.cshtml"
WriteAttributeValue("", 21500, control_Name_ContentPage, 21500, 25, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 21525, "/InsertOrUpdatePage?id=", 21525, 23, true);
#nullable restore
#line 322 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMS\Views\ContentPage\Index.cshtml"
WriteAttributeValue("", 21548, item.Id, 21548, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" title=\"Düzenle\">\n                        <i class=\"la la-edit\"></i>\n                    </a>\n                </td>\n            </tr>\n");
#nullable restore
#line 327 "E:\projeler\bitbucketRepos\CuhadarogluInteral\CMS\Views\ContentPage\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\n                </table>\n            </div>\n        </div>\n    </div>\n</div>\n");
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