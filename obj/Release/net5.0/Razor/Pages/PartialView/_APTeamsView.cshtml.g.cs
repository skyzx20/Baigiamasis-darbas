#pragma checksum "E:\KolegijosFailai\baigiamasis_darbas\fantazijos_lyga\Pages\PartialView\_APTeamsView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9986e711ae772583cb8cf898a65ec724722f8d49"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(fantazijos_lyga.Pages.PartialView.Pages_PartialView__APTeamsView), @"mvc.1.0.view", @"/Pages/PartialView/_APTeamsView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9986e711ae772583cb8cf898a65ec724722f8d49", @"/Pages/PartialView/_APTeamsView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65b5c17fcd5d184435cf7c13a39d1c3b52684a7d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_PartialView__APTeamsView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<fantazijos_lyga.Duomenu_baze.Komanda>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "APTeams", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
    <h5 style=""margin-top:-20px; margin-bottom:40px; text-align:center;"" class=""sukurimoText"">Komandos</h5>
    <table class=""table table-bordered"" id=""customerTable"">
        <thead>
            <tr>
                <th>
                    Pavadinimas
                </th>
                <th>
                    Sutrumpinimas
                </th>
                <th>
                    Logo
                </th>
                <th>
                    Regionas
                </th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 24 "E:\KolegijosFailai\baigiamasis_darbas\fantazijos_lyga\Pages\PartialView\_APTeamsView.cshtml"
             if (Model.Count() != 0)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "E:\KolegijosFailai\baigiamasis_darbas\fantazijos_lyga\Pages\PartialView\_APTeamsView.cshtml"
                 foreach (var team in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <th>\r\n                            ");
#nullable restore
#line 30 "E:\KolegijosFailai\baigiamasis_darbas\fantazijos_lyga\Pages\PartialView\_APTeamsView.cshtml"
                       Write(team.Pavadinimas);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 33 "E:\KolegijosFailai\baigiamasis_darbas\fantazijos_lyga\Pages\PartialView\_APTeamsView.cshtml"
                       Write(team.ShortName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 1204, "\"", 1220, 1);
#nullable restore
#line 36 "E:\KolegijosFailai\baigiamasis_darbas\fantazijos_lyga\Pages\PartialView\_APTeamsView.cshtml"
WriteAttributeValue("", 1210, team.Logo, 1210, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100px\" />\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 39 "E:\KolegijosFailai\baigiamasis_darbas\fantazijos_lyga\Pages\PartialView\_APTeamsView.cshtml"
                       Write(team.Region);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <td text-right\">\r\n                            <a");
            BeginWriteAttribute("onclick", " onclick=\"", 1446, "\"", 1520, 5);
            WriteAttributeValue("", 1456, "jQueryModalGet(\'?handler=CreateOrEdit&id=", 1456, 41, true);
#nullable restore
#line 42 "E:\KolegijosFailai\baigiamasis_darbas\fantazijos_lyga\Pages\PartialView\_APTeamsView.cshtml"
WriteAttributeValue("", 1497, team.ID, 1497, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1505, "\',", 1505, 2, true);
            WriteAttributeValue(" ", 1507, "\'Edit", 1508, 6, true);
            WriteAttributeValue(" ", 1513, "Team\')", 1514, 7, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info text-white\"> Redaguoti</a>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9986e711ae772583cb8cf898a65ec724722f8d498470", async() => {
                WriteLiteral("\r\n                                <button type=\"submit\" class=\"btn btn-danger text-white\"> Trinti</button>\r\n                            ");
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
#line 43 "E:\KolegijosFailai\baigiamasis_darbas\fantazijos_lyga\Pages\PartialView\_APTeamsView.cshtml"
                                                                     WriteLiteral(team.ID);

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
#line 48 "E:\KolegijosFailai\baigiamasis_darbas\fantazijos_lyga\Pages\PartialView\_APTeamsView.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "E:\KolegijosFailai\baigiamasis_darbas\fantazijos_lyga\Pages\PartialView\_APTeamsView.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<fantazijos_lyga.Duomenu_baze.Komanda>> Html { get; private set; }
    }
}
#pragma warning restore 1591
