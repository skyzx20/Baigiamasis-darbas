#pragma checksum "E:\KolegijosFailai\baigiamasis_darbas\fantazijos_lyga\Pages\APPlayers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b034eb38f3236806339c1ed4693bbd6d75885d8c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(fantazijos_lyga.Pages.Pages_APPlayers), @"mvc.1.0.razor-page", @"/Pages/APPlayers.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b034eb38f3236806339c1ed4693bbd6d75885d8c", @"/Pages/APPlayers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65b5c17fcd5d184435cf7c13a39d1c3b52684a7d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_APPlayers : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\KolegijosFailai\baigiamasis_darbas\fantazijos_lyga\Pages\APPlayers.cshtml"
  
    ViewData["PageHeading"] = "Players";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card"">
    <div class=""col-sm-12"" style=""padding:20px"">
        <a onclick=""jQueryModalGet('?handler=CreateOrEdit','Sukurti žaidėją')"" class=""btn bg-success"">
            Sukurti žaidėją
        </a>
    </div>
    <div id=""viewAll""></div>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<fantazijos_lyga.Pages.APPlayersModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<fantazijos_lyga.Pages.APPlayersModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<fantazijos_lyga.Pages.APPlayersModel>)PageContext?.ViewData;
        public fantazijos_lyga.Pages.APPlayersModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
