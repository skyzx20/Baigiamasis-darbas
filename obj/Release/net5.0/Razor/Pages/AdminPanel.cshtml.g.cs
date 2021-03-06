#pragma checksum "E:\KolegijosFailai\baigiamasis_darbas\fantazijos_lyga\Pages\AdminPanel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f23ba5510a5ae2f0b21a948f0b3f6dbdefd5865"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(fantazijos_lyga.Pages.Pages_AdminPanel), @"mvc.1.0.razor-page", @"/Pages/AdminPanel.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f23ba5510a5ae2f0b21a948f0b3f6dbdefd5865", @"/Pages/AdminPanel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65b5c17fcd5d184435cf7c13a39d1c3b52684a7d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_AdminPanel : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("Styles", async() => {
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""/css/adminPanel.css"" />
    <link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.3.1/css/all.css"" integrity=""sha384-mzrmE5qonljUremFsqc01SB46JvROS7bZs3IO2EmfFsd15uHvIt+Y8vEf7N7fWAU"" crossorigin=""anonymous"">
");
            }
            );
            WriteLiteral(@"<meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">

<div id=""main"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg"">
                <h4 style=""margin-top:20px;"" class=""sukurimoText"">Administratoriaus panelė</h4>
                <hr style=""width:30%;"" class=""adminHr"" /><br />
                <h5 style=""margin-top:-20px; margin-bottom:40px;"" class=""sukurimoText"">Galimi veiksmai</h5>
");
#nullable restore
#line 18 "E:\KolegijosFailai\baigiamasis_darbas\fantazijos_lyga\Pages\AdminPanel.cshtml"
                 if (Model.displayData != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""card-group"" style=""width:90%;"">
                <div class=""card"" style=""width: 18rem;"">
                    <img class=""card-img-top"" src=""/img/basketball-court.png"" alt=""Card image cap"">
                    <div class=""card-body"">
                        <hr />
                        <a class=""btn btn-default adminPanelButton"" href=""/APMatch"">Rungtynių sukurimas</a>
                    </div>
                </div>
                <div class=""card"" style=""width: 18rem;"">
                    <img class=""card-img-top"" src=""/img/basketball-player.png"" alt=""Card image cap"">
                    <div class=""card-body"">
                        <hr />
                        <a class=""btn btn-default adminPanelButton"" href=""/APPlayers"">Žaidėjo sukūrimas</a>
                    </div>
                </div>
                <div class=""card"" style=""width: 18rem;"">
                    <img class=""card-img-top"" src=""/img/stats.png"" alt=""Card image cap"">
                    <div");
            WriteLiteral(@" class=""card-body"">
                        <hr />
                        <a class=""btn btn-default adminPanelButton"" href=""/AddStatistics"">Statistikos sukūrimas</a>
                    </div>
                </div>
                <div class=""card"" style=""width: 18rem;"">
                    <img class=""card-img-top"" src=""/img/basketball-court.png"" alt=""Card image cap"">
                    <div class=""card-body"">
                        <hr />
                        <a class=""btn btn-default adminPanelButton"" href=""/APTeams"">Komandos sukūrimas</a>
                    </div>
                </div>
            </div>
");
#nullable restore
#line 50 "E:\KolegijosFailai\baigiamasis_darbas\fantazijos_lyga\Pages\AdminPanel.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
  </div>
</div>
    <script>
        function openNav() {
            document.getElementById(""mySidenav"").style.width = ""300px"";
        }

        function closeNav() {
            document.getElementById(""mySidenav"").style.width = ""0"";
        }
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<fantazijos_lyga.Pages.AdminPanelModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<fantazijos_lyga.Pages.AdminPanelModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<fantazijos_lyga.Pages.AdminPanelModel>)PageContext?.ViewData;
        public fantazijos_lyga.Pages.AdminPanelModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
