#pragma checksum "E:\projeler\bitbucketRepos\EyoNewCMS\CMS\Views\FileManagerData\FileManager.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f68adc99ebd995006372f57fd573af01fa9d5c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FileManagerData_FileManager), @"mvc.1.0.view", @"/Views/FileManagerData/FileManager.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f68adc99ebd995006372f57fd573af01fa9d5c9", @"/Views/FileManagerData/FileManager.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf3c12927ab877906462eb43fa69065321a6b025", @"/Views/_ViewImports.cshtml")]
    public class Views_FileManagerData_FileManager : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\projeler\bitbucketRepos\EyoNewCMS\CMS\Views\FileManagerData\FileManager.cshtml"
   Layout = null;
                var DocName = Context.Request.Query["name"].ToStr();
                var ids = Context.Request.Query["id"].ToStr();
                var cont = Context.Request.Query["cont"].ToStr(); 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <script>\n    var DocName = \"");
#nullable restore
#line 7 "E:\projeler\bitbucketRepos\EyoNewCMS\CMS\Views\FileManagerData\FileManager.cshtml"
              Write(DocName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\n    var ids = \"");
#nullable restore
#line 8 "E:\projeler\bitbucketRepos\EyoNewCMS\CMS\Views\FileManagerData\FileManager.cshtml"
          Write(ids);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\n    var cont = \"");
#nullable restore
#line 9 "E:\projeler\bitbucketRepos\EyoNewCMS\CMS\Views\FileManagerData\FileManager.cshtml"
           Write(cont);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""";
    
</script>

    <script>
        var DocList = [];
        function onOpen(el) {
            console.log(el);

            try {
                if (DocName == ""Documents"") {


                }
                else {
                    $('#file_image_' + DocName + '').css('background', ""url('/fileupload/UserFiles/Folders/"" + el.entry.path + ""')"");
                    $('#file_link_' + DocName + '').val(el.entry.path);
                }

            } catch (e) {
                console.log(e);
            }

            return;
        }



        function onDataBound(e) {
        }

        function onDrop(e) {
        }

        function onExecute(e) {
        }

        function onNavigate(e) {
        }


        function onSelect(e) {
            DocList = [];
            $.each(e.entries, function (i, item) {
                DocList.push(
                    {
                        Link: item.path,
                        Name: item.name,
                        DocumentId: DocName == ""Docum");
            WriteLiteral(@"ents"" ? ids : null,
                        ThumbImageId: DocName == ""ThumbImage"" ? ids : null,
                        BannerImageId: DocName == ""BannerImage"" ? ids : null,
                        PictureId: DocName == ""Picture"" ? ids : null,

                    }
                );

            });

        }



    </script>


<div class=""row"">
    <div class=""col-12"">

        ");
#nullable restore
#line 77 "E:\projeler\bitbucketRepos\EyoNewCMS\CMS\Views\FileManagerData\FileManager.cshtml"
    Write(Html.Kendo().Window()
        .Name("window")
        .Title("Önizleme")

        .Visible(false)
        .Draggable()
        .Resizable()
        .Actions(actions => actions.Pin().Minimize().Maximize().Close())
    );

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 86 "E:\projeler\bitbucketRepos\EyoNewCMS\CMS\Views\FileManagerData\FileManager.cshtml"
    Write(Html.Kendo().FileManager().Name("filemanager")
        .DataSource(ds =>
        {
            ds.Read(operation => operation
            .Type(HttpVerbs.Post)
            .Action("Read", "FileManagerData")
        );
            ds.Destroy(operation => operation
                .Type(HttpVerbs.Post)
                .Action("Destroy", "FileManagerData")
            );
            ds.Create(operation => operation
                .Type(HttpVerbs.Post)
                .Action("Create", "FileManagerData")
            );
            ds.Update(operation => operation
                .Type(HttpVerbs.Post)
                .Action("Update", "FileManagerData")
            );
        })
        .ContextMenu(context => context.Items(items =>
        {
            items.Add("rename");
            items.Add("delete");
            items.Add("custom").Name("GetInfo").Text("Detay").Command("MyCustomCommand").SpriteCssClass("k-icon k-i-info");
            items.Add("download").Name("DownloadCommand").Text("İndir").Command("DownloadCommand").SpriteCssClass("k-icon k-i-download");
            //items.Add("download");
        }))
        .UploadUrl("Upload", "FileManagerData")
        .Toolbar(tb => tb.Items(items =>
        {
            items.Add("createFolder");
            items.Add("upload");
            items.Add("sortField");
            items.Add("changeView");
            items.Add("spacer");
            items.Add("details");
            items.Add("search");

            items.Add("download").Command("DownloadCommand").Text("Download").SpriteCssClass("k-icon k-i-download");

        }))
        .Draggable(true)
        .Resizable(true)
        .Events(events => events
            .DataBound("onDataBound")
            .Drop("onDrop")
            .Execute("onExecute")
            .Navigate("onNavigate")
            .Open("onOpen")
            .Select("onSelect")
    )
    );

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

        <div class=""btn btn-light-success font-weight-bolder btn-hover-bg-secondary"" style=""float: right; margin: 20px;  margin-bottom: 0px;"">
            <a href=""#"" id=""btnFileAdd"" class=""btn-bg-success"">
                Kaydet
            </a>
        </div>
        <script>
            $(document).ready(function () {
                var filemanager = $(""#filemanager"").getKendoFileManager();

                filemanager.executeCommand({ command: ""TogglePaneCommand"", options: { type: ""preview"" } });
                filemanager.toolbar.fileManagerDetailsToggle.switchInstance.toggle();
               
                    $('#btnFileAdd').click(function () {
                        debugger;
                        try {
                            if (DocName == ""Documents"") {
                                $.ajx('/' + cont + '/SaveMultiDoc', { DocList: DocList, }, function (resultData) {
                                    alert('Başarıyla yüklendi');
                                    location.reload();");
            WriteLiteral(@"
                                });
                            } 
                            else {
                                $.ajx('/' + cont + '/SaveMultiDoc', { DocList: DocList, }, function (resultData) {
                                    console.log(resultData);
                                    if (resultData.indexOf(""Err-"") > -1) {
                                        if (resultData.indexOf(""duplicate"")) {
                                            alert(""Görsel Adı zaten mevcut."");
                                        }
                                        else {
                                            alert(""Hata"");
                                        }
                                       
                                    }
                                    else {
                                        alert('Başarıyla yüklendi');
                                        location.reload();
                                    }

                          ");
            WriteLiteral(@"          
                                });
                              //$('#file_image_' + DocName + '').css('background', ""url('/fileupload/UserFiles/Folders/"" + el.entry.path + ""')"");
                              //$('#file_link_' + DocName + '').val(el.entry.path);
                            }

                        } catch (e) {
                            console.log(e);

                        }
                    });

                })
        </script>

        <script>
            var filemanagerNS = kendo.ui.filemanager;
            function downloadURI(uri, name) {
                var link = document.createElement(""a"");
                // If you don't know the name or want to use
                // the webserver default set name = ''
                link.setAttribute('download', name);
                link.href = uri;
                document.body.appendChild(link);
                link.click();
                link.remove();
            }


            filemanagerNS.commands.Download");
            WriteLiteral(@"Command = filemanagerNS.FileManagerCommand.extend({
                exec: function () {
                    var that = this,
                        filemanager = that.filemanager, // get the kendo.ui.FileManager instance
                        options = that.options, // get the options passed through the tool
                        target = options.target // options.target is available only when command is executed from the context menu
                    selectedFiles = filemanager.getSelected(); // get the selected files

                    downloadURI(""../fileupload/UserFiles/Folders/"" + selectedFiles[0].path, selectedFiles[0].path.split('/')[selectedFiles[0].path.split('/').length - 1]);

                }
            });

            filemanagerNS.commands.MyCustomCommand = filemanagerNS.FileManagerCommand.extend({
                exec: function () {
                    var that = this,
                        filemanager = that.filemanager, // get the kendo.ui.FileManager instance
                 ");
            WriteLiteral(@"       options = that.options, // get the options passed through the tool
                        target = options.target, // options.target is available only when command is executed from the context menu
                        selectedFiles = filemanager.getSelected(); // get the selected files

                    var totalSize = 0;
                    selectedFiles.forEach(function (fileEntry) {
                        totalSize += fileEntry.size;
                    });

                    kendo.alert(selectedFiles.length + ' file(s) selected; Total size: ' + kendo.getFileSizeMessage(totalSize))
                }
            });

            
        </script>

    </div>
</div>");
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
