#pragma checksum "E:\KolegijosFailai\baigiamasis_darbas\fantazijos_lyga\Pages\APTeams.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b210f737267a01c8562c811645fba2c4965f89ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(fantazijos_lyga.Pages.Pages_APTeams), @"mvc.1.0.razor-page", @"/Pages/APTeams.cshtml")]
namespace fantazijos_lyga.Pages
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
#line 1 "E:\KolegijosFailai\baigiamasis_darbas\fantazijos_lyga\Pages\_ViewImports.cshtml"
using fantazijos_lyga;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b210f737267a01c8562c811645fba2c4965f89ed", @"/Pages/APTeams.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65b5c17fcd5d184435cf7c13a39d1c3b52684a7d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_APTeams : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\KolegijosFailai\baigiamasis_darbas\fantazijos_lyga\Pages\APTeams.cshtml"
  
    ViewData["PageHeading"] = "Teams";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://unpkg.com/bootstrap-table@1.18.1/dist/bootstrap-table.min.css\">\r\n");
            }
            );
            WriteLiteral(@"
<div class=""card"">
    <div class=""col-sm-12"" style=""padding:20px"">
        <a onclick=""jQueryModalGet('?handler=CreateOrEdit','Sukurti komandą')"" class=""btn bg-success"">
            Sukurti komandą
        </a>
    </div>
    <div id=""viewAll"" class=""card-body table-responsive""></div>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""https://unpkg.com/bootstrap-table@1.18.1/dist/bootstrap-table.min.js""></script>

    <script>
        $(document).ready(function () {
            $('#viewAll').load('?handler=ViewAllPartial');
        });
        $(function () {
            $('#reload').on('click', function () {
                $('#viewAll').load('?handler=ViewAllPartial');
            });
        });
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<fantazijos_lyga.Pages.APTeamsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<fantazijos_lyga.Pages.APTeamsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<fantazijos_lyga.Pages.APTeamsModel>)PageContext?.ViewData;
        public fantazijos_lyga.Pages.APTeamsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
