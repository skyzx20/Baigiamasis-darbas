#pragma checksum "E:\KolegijosFailai\baigiamasis_darbas\fantazijos_lyga\Pages\AddStatistics.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41f2124276e33d079cfc574114a9e07fbbe30c01"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(fantazijos_lyga.Pages.Pages_AddStatistics), @"mvc.1.0.razor-page", @"/Pages/AddStatistics.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41f2124276e33d079cfc574114a9e07fbbe30c01", @"/Pages/AddStatistics.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65b5c17fcd5d184435cf7c13a39d1c3b52684a7d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_AddStatistics : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default statsCreateButton"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/AddPlayerStatistics", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("Styles", async() => {
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""/css/addStatistics.css"" />
    <link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.3.1/css/all.css"" integrity=""sha384-mzrmE5qonljUremFsqc01SB46JvROS7bZs3IO2EmfFsd15uHvIt+Y8vEf7N7fWAU"" crossorigin=""anonymous"">
");
            }
            );
            WriteLiteral(@"<meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
<div id=""main"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xl-12"">
                <h4 style=""margin-top:20px;"" class=""sukurimoText"">Administratoriaus panelė</h4>
                <hr style=""width:30%;"" class=""adminHr"" /><br />
                <h5 style=""margin-top:-20px; margin-bottom:40px;"" class=""sukurimoText"">Statistikos sukūrimas</h5>
");
#nullable restore
#line 17 "E:\KolegijosFailai\baigiamasis_darbas\fantazijos_lyga\Pages\AddStatistics.cshtml"
                 foreach (var item in Model.matches.Where(item => item.RungtyniuStatistikos?.Count == 0))
                {
                    if (item.StartDate < DateTime.Now)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""row"">
                            <div class=""col-md-12"">
                                <div class=""col-md-6 match rungtynes"" style=""overflow: hidden;"">
                                    <div id=""firstMatchColumn"" class=""row justify-content-md-center"" style=""border-bottom: 2px solid black;"">
                                        <div class=""col-md-4 homeTeam"">
                                            <img");
            BeginWriteAttribute("src", " src=\"", 1467, "\"", 1492, 1);
#nullable restore
#line 26 "E:\KolegijosFailai\baigiamasis_darbas\fantazijos_lyga\Pages\AddStatistics.cshtml"
WriteAttributeValue("", 1473, item.AwayTeam.Logo, 1473, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"70px\" class=\"rounded mx-auto d-block\"");
            BeginWriteAttribute("alt", " alt=\"", 1538, "\"", 1544, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <h3 class=\"teamName\">");
#nullable restore
#line 27 "E:\KolegijosFailai\baigiamasis_darbas\fantazijos_lyga\Pages\AddStatistics.cshtml"
                                                            Write(item.AwayTeam.Pavadinimas);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3><br />\r\n                                        </div>\r\n                                        <div class=\"col-md-4 matchDate\">\r\n                                            <h5 id=\"rungtyniuStartText\">Rungtynės vyko: ");
#nullable restore
#line 30 "E:\KolegijosFailai\baigiamasis_darbas\fantazijos_lyga\Pages\AddStatistics.cshtml"
                                                                                   Write(item.StartDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                        </div>\r\n                                        <div class=\"col-md-4 awayTeam\">\r\n                                            <img");
            BeginWriteAttribute("src", " src=\"", 2053, "\"", 2078, 1);
#nullable restore
#line 33 "E:\KolegijosFailai\baigiamasis_darbas\fantazijos_lyga\Pages\AddStatistics.cshtml"
WriteAttributeValue("", 2059, item.HomeTeam.Logo, 2059, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"70px\" class=\"rounded mx-auto d-block\"");
            BeginWriteAttribute("alt", " alt=\"", 2124, "\"", 2130, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <h3 class=\"teamName\">");
#nullable restore
#line 34 "E:\KolegijosFailai\baigiamasis_darbas\fantazijos_lyga\Pages\AddStatistics.cshtml"
                                                            Write(item.HomeTeam.Pavadinimas);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3><br />
                                        </div>
                                    </div>
                                    <div class=""row"">
                                        <div style=""padding:0;"" class=""col-xl-12"">
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41f2124276e33d079cfc574114a9e07fbbe30c018189", async() => {
                WriteLiteral("Sukurti");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-RungtyniuID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 39 "E:\KolegijosFailai\baigiamasis_darbas\fantazijos_lyga\Pages\AddStatistics.cshtml"
                                                                                                                                    WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["RungtyniuID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-RungtyniuID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["RungtyniuID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""empty"" style=""margin-top:20px;margin-bottom""></div>
");
#nullable restore
#line 46 "E:\KolegijosFailai\baigiamasis_darbas\fantazijos_lyga\Pages\AddStatistics.cshtml"
                    }
                    else
                    {

                    }

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<fantazijos_lyga.Pages.AddStatisticsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<fantazijos_lyga.Pages.AddStatisticsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<fantazijos_lyga.Pages.AddStatisticsModel>)PageContext?.ViewData;
        public fantazijos_lyga.Pages.AddStatisticsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
