#pragma checksum "E:\KolegijosFailai\baigiamasis_darbas\fantazijos_lyga\Pages\PartialView\_APPlayersView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2eb5d976c3e9ccc71463d53688eb67f304059f9a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(fantazijos_lyga.Pages.PartialView.Pages_PartialView__APPlayersView), @"mvc.1.0.view", @"/Pages/PartialView/_APPlayersView.cshtml")]
namespace fantazijos_lyga.Pages.PartialView
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2eb5d976c3e9ccc71463d53688eb67f304059f9a", @"/Pages/PartialView/_APPlayersView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65b5c17fcd5d184435cf7c13a39d1c3b52684a7d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_PartialView__APPlayersView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<fantazijos_lyga.Duomenu_baze.Zaidejas>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "APPlayers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return jQueryModalDelete(this)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    <h4 style=""margin-top:20px; text-align:center;"" class=""sukurimoText"">Administratoriaus panelė</h4>
    <hr style=""width:30%;"" class=""adminHr"" />
    <br />
    <h5 style=""margin-top:-20px; margin-bottom:40px; text-align:center;"" class=""sukurimoText"">Žaidėjai</h5>
    <table id=""table"" data-toggle=""table"" data-search=""true"" style=""table-layout: fixed; text-align:center;"">
        <thead>
            <tr>
                <th data-field=""Vardas"" data-width=""10"" data-width-unit=""%"">
                    Vardas
                </th>
                <th data-width=""5"" data-width-unit=""%"">
                    Foto
                </th>
                <th data-width=""5"" data-width-unit=""%"">
                    Taškai
                </th>
                <th data-width=""12"" data-width-unit=""%"">
                    Atkovoti kamuoliai
                </th>
                <th data-width=""12"" data-width-unit=""%"">
                    Rezultatyvūs perdavimai
                </th>
                ");
            WriteLiteral(@"<th data-width=""12"" data-width-unit=""%"">
                    Blokuoti kamuoliai
                </th>
                <th data-width=""12"" data-width-unit=""%"">
                    Prarasti kamuoliai
                </th>
                <th data-width=""7"" data-width-unit=""%"">
                    Pražangos
                </th>
                <th data-width=""7"" data-width-unit=""%"">
                    Sužaista rungtynių
                </th>
                <th data-width=""10"" data-width-unit=""%"">
                    Komanda
                </th>
                <th data-width=""8"" data-width-unit=""%"">

                </th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 45 "E:\KolegijosFailai\baigiamasis_darbas\fantazijos_lyga\Pages\PartialView\_APPlayersView.cshtml"
             if (Model.Count() != 0)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "E:\KolegijosFailai\baigiamasis_darbas\fantazijos_lyga\Pages\PartialView\_APPlayersView.cshtml"
                 foreach (var player in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 51 "E:\KolegijosFailai\baigiamasis_darbas\fantazijos_lyga\Pages\PartialView\_APPlayersView.cshtml"
                       Write(player.Vardas);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 2099, "\"", 2121, 1);
#nullable restore
#line 54 "E:\KolegijosFailai\baigiamasis_darbas\fantazijos_lyga\Pages\PartialView\_APPlayersView.cshtml"
WriteAttributeValue("", 2105, player.FotoPath, 2105, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"60px\" />\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 57 "E:\KolegijosFailai\baigiamasis_darbas\fantazijos_lyga\Pages\PartialView\_APPlayersView.cshtml"
                       Write(player.TotalPoints);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 60 "E:\KolegijosFailai\baigiamasis_darbas\fantazijos_lyga\Pages\PartialView\_APPlayersView.cshtml"
                       Write(player.TotalAssist);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 63 "E:\KolegijosFailai\baigiamasis_darbas\fantazijos_lyga\Pages\PartialView\_APPlayersView.cshtml"
                       Write(player.TotalRebounds);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 66 "E:\KolegijosFailai\baigiamasis_darbas\fantazijos_lyga\Pages\PartialView\_APPlayersView.cshtml"
                       Write(player.TotalBlocks);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 69 "E:\KolegijosFailai\baigiamasis_darbas\fantazijos_lyga\Pages\PartialView\_APPlayersView.cshtml"
                       Write(player.TotalTurnovers);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 72 "E:\KolegijosFailai\baigiamasis_darbas\fantazijos_lyga\Pages\PartialView\_APPlayersView.cshtml"
                       Write(player.TotalPersonalFouls);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 75 "E:\KolegijosFailai\baigiamasis_darbas\fantazijos_lyga\Pages\PartialView\_APPlayersView.cshtml"
                       Write(player.GamesPlayer);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 78 "E:\KolegijosFailai\baigiamasis_darbas\fantazijos_lyga\Pages\PartialView\_APPlayersView.cshtml"
                       Write(player.Komanda?.Pavadinimas);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td text-right\">\r\n                            <a style=\"margin-bottom:10px;\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3172, "\"", 3250, 5);
            WriteAttributeValue("", 3182, "jQueryModalGet(\'?handler=CreateOrEdit&id=", 3182, 41, true);
#nullable restore
#line 81 "E:\KolegijosFailai\baigiamasis_darbas\fantazijos_lyga\Pages\PartialView\_APPlayersView.cshtml"
WriteAttributeValue("", 3223, player.ID, 3223, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3233, "\',", 3233, 2, true);
            WriteAttributeValue(" ", 3235, "\'Edit", 3236, 6, true);
            WriteAttributeValue(" ", 3241, "Player\')", 3242, 9, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info text-white\"> Redaguoti</a>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2eb5d976c3e9ccc71463d53688eb67f304059f9a11775", async() => {
                WriteLiteral("\r\n                                <button type=\"submit\" class=\"btn btn-danger text-white\"> Ištrinti</button>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 82 "E:\KolegijosFailai\baigiamasis_darbas\fantazijos_lyga\Pages\PartialView\_APPlayersView.cshtml"
                                                                       WriteLiteral(player.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 87 "E:\KolegijosFailai\baigiamasis_darbas\fantazijos_lyga\Pages\PartialView\_APPlayersView.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "E:\KolegijosFailai\baigiamasis_darbas\fantazijos_lyga\Pages\PartialView\_APPlayersView.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n    <script>\r\n        var $table = $(\'#table\');\r\n\r\n        $table.bootstrapTable();\r\n    </script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<fantazijos_lyga.Duomenu_baze.Zaidejas>> Html { get; private set; }
    }
}
#pragma warning restore 1591