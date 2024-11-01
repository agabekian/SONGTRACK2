#pragma checksum "/Users/armasconi/CSHARP2024/SONGTRACK2/Views/Gearz/Tools.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d1b0a6e6d3e96d1adccddcdd060748b34e7a890"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyApp.Namespace.Gearz.Views_Gearz_Tools), @"mvc.1.0.view", @"/Views/Gearz/Tools.cshtml")]
namespace MyApp.Namespace.Gearz
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
#line 1 "/Users/armasconi/CSHARP2024/SONGTRACK2/Views/Gearz/Tools.cshtml"
using cSharp2022.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d1b0a6e6d3e96d1adccddcdd060748b34e7a890", @"/Views/Gearz/Tools.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9931c87b96a1dddd3d7ba4f5f1dbbe4a125e298", @"/Views/_ViewImports.cshtml")]
    public class Views_Gearz_Tools : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Gear>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/site.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
    <a class=""text-decoration-none"" id=""scaleContainer"" href=""/new-tool-form/""><i class=""fa fa-plus ""
            style=""color:white""></i>
    </a>

    <div id=""sortable_table_wrapper"">
<table class=""table"" style=""color:white"">
    <thead>
        <tr>
            <th class=""bg-secondary date sort"">NAME</th>
            <th class=""bg-secondary date sort"">NOTES</th>
            <th class=""bg-secondary date sort"">ROLE</th>
            <th class=""bg-secondary date sort""><i class=""fa fa-wrench""></i></th>
        </tr>
    </thead>
    <tbody style=""color:white"">
");
#nullable restore
#line 19 "/Users/armasconi/CSHARP2024/SONGTRACK2/Views/Gearz/Tools.cshtml"
         foreach (var tool in @Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>\n                    <a class=\"link-warning text-decoration-none\"");
            BeginWriteAttribute("href", " href=\"", 760, "\"", 791, 3);
            WriteAttributeValue("", 767, "/gear/", 767, 6, true);
#nullable restore
#line 23 "/Users/armasconi/CSHARP2024/SONGTRACK2/Views/Gearz/Tools.cshtml"
WriteAttributeValue("", 773, tool.GearId, 773, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 785, "/info/", 785, 6, true);
            EndWriteAttribute();
            WriteLiteral(">\n                        <b>");
#nullable restore
#line 24 "/Users/armasconi/CSHARP2024/SONGTRACK2/Views/Gearz/Tools.cshtml"
                      Write(tool.Make.ToLower());

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\n                        <b>");
#nullable restore
#line 25 "/Users/armasconi/CSHARP2024/SONGTRACK2/Views/Gearz/Tools.cshtml"
                      Write(tool.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\n                    </a>\n                </td>\n                <td>");
#nullable restore
#line 28 "/Users/armasconi/CSHARP2024/SONGTRACK2/Views/Gearz/Tools.cshtml"
               Write(tool.desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 29 "/Users/armasconi/CSHARP2024/SONGTRACK2/Views/Gearz/Tools.cshtml"
               Write(tool.role);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <!-- <a onClick = \"return confirm(\'Sure to delete ");
#nullable restore
#line 30 "/Users/armasconi/CSHARP2024/SONGTRACK2/Views/Gearz/Tools.cshtml"
                                                             Write(tool.title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ?\')\" href=\"/tools/");
#nullable restore
#line 30 "/Users/armasconi/CSHARP2024/SONGTRACK2/Views/Gearz/Tools.cshtml"
                                                                                           Write(tool.GearId);

#line default
#line hidden
#nullable disable
            WriteLiteral("/del\"><i class=\"fa fa-trash\" aria-hidden=\"true\"></i></a> -->\n");
            WriteLiteral("                <td>\n                    <a class=\"btn btn-info text-decoration-none\"");
            BeginWriteAttribute("href", " href=\"", 1321, "\"", 1347, 3);
            WriteAttributeValue("", 1328, "/gear/", 1328, 6, true);
#nullable restore
#line 33 "/Users/armasconi/CSHARP2024/SONGTRACK2/Views/Gearz/Tools.cshtml"
WriteAttributeValue("", 1334, tool.GearId, 1334, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1346, "/", 1346, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\n                        <i style=\"color:green\" class=\"fa fa-edit\" aria-hidden=\"true\"></i>\n                    </a>\n                    <span");
            BeginWriteAttribute("id", " id=\"", 1490, "\"", 1525, 2);
            WriteAttributeValue("", 1495, "confirmDeleteSpan_", 1495, 18, true);
#nullable restore
#line 36 "/Users/armasconi/CSHARP2024/SONGTRACK2/Views/Gearz/Tools.cshtml"
WriteAttributeValue("", 1513, tool.GearId, 1513, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"display:none\">\n                        <span style=\"color:red\">DELETE</span> the tool ");
#nullable restore
#line 37 "/Users/armasconi/CSHARP2024/SONGTRACK2/Views/Gearz/Tools.cshtml"
                                                                  Write(tool.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("?\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1659, "\"", 1689, 3);
            WriteAttributeValue("", 1666, "/tools/", 1666, 7, true);
#nullable restore
#line 38 "/Users/armasconi/CSHARP2024/SONGTRACK2/Views/Gearz/Tools.cshtml"
WriteAttributeValue("", 1673, tool.GearId, 1673, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1685, "/del", 1685, 4, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Yes</a>\n                        <a href=\"#\"");
            BeginWriteAttribute("onClick", " onClick=\"", 1757, "\"", 1802, 3);
            WriteAttributeValue("", 1767, "confirmDelete(\'", 1767, 15, true);
#nullable restore
#line 39 "/Users/armasconi/CSHARP2024/SONGTRACK2/Views/Gearz/Tools.cshtml"
WriteAttributeValue("", 1782, tool.GearId, 1782, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1794, "\',false)", 1794, 8, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">No</a>\n                    </span>\n\n                    <span");
            BeginWriteAttribute("id", " id=\"", 1889, "\"", 1917, 2);
            WriteAttributeValue("", 1894, "deleteSpan_", 1894, 11, true);
#nullable restore
#line 42 "/Users/armasconi/CSHARP2024/SONGTRACK2/Views/Gearz/Tools.cshtml"
WriteAttributeValue("", 1905, tool.GearId, 1905, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                        <a href=\"#\" class=\"btn btn-danger\"");
            BeginWriteAttribute("onClick", " onClick=\"", 1978, "\"", 2022, 3);
            WriteAttributeValue("", 1988, "confirmDelete(\'", 1988, 15, true);
#nullable restore
#line 43 "/Users/armasconi/CSHARP2024/SONGTRACK2/Views/Gearz/Tools.cshtml"
WriteAttributeValue("", 2003, tool.GearId, 2003, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2015, "\',true)", 2015, 7, true);
            EndWriteAttribute();
            WriteLiteral("><i\n                                class=\"fa fa-trash\" aria-hidden=\"true\"></i></a>\n                    </span>\n                </td>\n            </tr>\n");
#nullable restore
#line 48 "/Users/armasconi/CSHARP2024/SONGTRACK2/Views/Gearz/Tools.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n    </div>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d1b0a6e6d3e96d1adccddcdd060748b34e7a89010374", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Gear>> Html { get; private set; }
    }
}
#pragma warning restore 1591
