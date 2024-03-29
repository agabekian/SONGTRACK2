#pragma checksum "/Users/armasconi/401/SONGTRACK2/Views/Home/Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fef6e80830f440e37f7c678ef43bf7b19a6e95b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyApp.Namespace.Home.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
namespace MyApp.Namespace.Home
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
#line 2 "/Users/armasconi/401/SONGTRACK2/Views/_ViewImports.cshtml"
using cSharp2022.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/armasconi/401/SONGTRACK2/Views/Home/Dashboard.cshtml"
using FileTypeChecker;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/armasconi/401/SONGTRACK2/Views/Home/Dashboard.cshtml"
using FileTypeChecker.Abstracts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/armasconi/401/SONGTRACK2/Views/Home/Dashboard.cshtml"
using FileTypeChecker.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/armasconi/401/SONGTRACK2/Views/Home/Dashboard.cshtml"
using FileTypeChecker.Types;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/armasconi/401/SONGTRACK2/Views/Home/Dashboard.cshtml"
using System.IO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fef6e80830f440e37f7c678ef43bf7b19a6e95b", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9931c87b96a1dddd3d7ba4f5f1dbbe4a125e298", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Recordis>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/site.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/list.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral(@"<a class=""text-decoration-none"" id=""scaleContainer"" href=""/new-track""><i class=""fa fa-plus"" style=""color:white""></i></a>
<div id=""sortable_table_wrapper"">
    <!-- for list.js SEARCH to work encapsulate table into div with appropriate main id (""stw"") -->
    <table class=""table"" style=""color:white"">
        <thead>
            <tr>
                <th class=""bg-secondary sort"" data-sort=""nums"">#</th>
                <th class=""bg-secondary date sort"" data-sort=""title"">TITLE/INFO</th>
                <th class=""bg-secondary date sort"" data-sort=""artist"">ARTIST</th>
                <th class=""bg-secondary date sort"" data-sort=""filesize"">FILESIZE</th>
                <th class=""bg-secondary date sort"" data-sort=""tools"">TOOLS</th>
                <th class=""bg-secondary date sort"" data-sort=""comments"">COMMENTS</th>
                <th class=""bg-secondary date"">VERSIONS</th>
                <th class=""bg-secondary date sort"" data-sort=""postdate"">POST DATE</th>
                <th class=""bg-secondary date"">ACTIONS<");
            WriteLiteral("/th>\n            </tr>\n        </thead>\n\n        <tbody class=\"list\">\n");
#nullable restore
#line 28 "/Users/armasconi/401/SONGTRACK2/Views/Home/Dashboard.cshtml"
              
                var sr = ""; int i = 1;
                foreach (Recordis t in @Model)
                {
                    if (t.MediaFilePath != null)
                    {
                        var cut = t.MediaFilePath.Split("wwwroot");
                        sr = cut[1];
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <th scope=\"row\">");
#nullable restore
#line 38 "/Users/armasconi/401/SONGTRACK2/Views/Home/Dashboard.cshtml"
                                       Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1729, "\"", 1761, 2);
            WriteAttributeValue("", 1736, "/track/play/", 1736, 12, true);
#nullable restore
#line 39 "/Users/armasconi/401/SONGTRACK2/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 1748, t.RecordisId, 1748, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                                    <i class=\"fas fa-file-export\" aria-hidden=\"true\"></i>\n                                </a>\n");
#nullable restore
#line 42 "/Users/armasconi/401/SONGTRACK2/Views/Home/Dashboard.cshtml"
                             try
                            {
                                using (var fileStream = File.OpenRead(@t.MediaFilePath))
                                {
                                    var isRecognizableType = FileTypeValidator.IsTypeRecognizable(fileStream);
                                    if (!isRecognizableType) Console.WriteLine("Tis a weird file - forbidden ! ");
                                    IFileType fileType = FileTypeValidator.GetFileType(fileStream);
                                    if (fileType.Extension == "mp3")
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <audio controls>\n                                            <source");
            BeginWriteAttribute("src", " src=\"", 2618, "\"", 2627, 1);
#nullable restore
#line 52 "/Users/armasconi/401/SONGTRACK2/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 2624, sr, 2624, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\'audio/mpeg\'>\n                                            Your browser does not support the audio element.\n                                        </audio>\n");
#nullable restore
#line 55 "/Users/armasconi/401/SONGTRACK2/Views/Home/Dashboard.cshtml"
                                    }
                                    if (fileStream.IsImage())
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a");
            BeginWriteAttribute("href", " href=\"", 2970, "\"", 3002, 2);
            WriteAttributeValue("", 2977, "/track/play/", 2977, 12, true);
#nullable restore
#line 58 "/Users/armasconi/401/SONGTRACK2/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 2989, t.RecordisId, 2989, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=", 3008, "", 3016, 1);
#nullable restore
#line 58 "/Users/armasconi/401/SONGTRACK2/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 3013, sr, 3013, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=", 3016, "", 3029, 1);
#nullable restore
#line 58 "/Users/armasconi/401/SONGTRACK2/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 3021, t.title, 3021, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=30px></a>\n");
#nullable restore
#line 59 "/Users/armasconi/401/SONGTRACK2/Views/Home/Dashboard.cshtml"
                                    }
                                    Console.WriteLine("Type Name: {0}", fileType.Name);
                                    Console.WriteLine("Type Extension: {0}", fileType.Extension);
                                    Console.WriteLine("Is Image?: {0}", fileStream.IsImage());
                                    Console.WriteLine("Is Bitmap?: {0}", fileStream.Is<Bitmap>());
                                }
                            } 
                            catch (DirectoryNotFoundException dirEx)
                            {
                            Console.WriteLine("error " + dirEx.Message);
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </th>\n");
#nullable restore
#line 71 "/Users/armasconi/401/SONGTRACK2/Views/Home/Dashboard.cshtml"
                                  
                                    i++;
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>\n                                <a class=\"text-decoration-none text-white border border-secondary rounded title\"");
            BeginWriteAttribute("href", " href=\"", 4021, "\"", 4048, 2);
            WriteAttributeValue("", 4028, "/track/", 4028, 7, true);
#nullable restore
#line 75 "/Users/armasconi/401/SONGTRACK2/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 4035, t.RecordisId, 4035, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 75 "/Users/armasconi/401/SONGTRACK2/Views/Home/Dashboard.cshtml"
                                                                                                                                        Write(t.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                            </td>\n                            <td class=\"font-fancy artist\">");
#nullable restore
#line 77 "/Users/armasconi/401/SONGTRACK2/Views/Home/Dashboard.cshtml"
                                                     Write(t.artist);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td class=\"filesize\" style=\"font-size: 0.8 rem;\">");
#nullable restore
#line 78 "/Users/armasconi/401/SONGTRACK2/Views/Home/Dashboard.cshtml"
                                                                        Write(t.length);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td class=\"tools\">\n");
#nullable restore
#line 80 "/Users/armasconi/401/SONGTRACK2/Views/Home/Dashboard.cshtml"
                             foreach (var g in t.Gears)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a");
            BeginWriteAttribute("href", " href=", 4429, "", 4456, 3);
            WriteAttributeValue("", 4435, "/gear/", 4435, 6, true);
#nullable restore
#line 82 "/Users/armasconi/401/SONGTRACK2/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 4441, g.GearId, 4441, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4450, "/info/", 4450, 6, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"border border-info rounded link-warning text-decoration-none\">\n                                ");
#nullable restore
#line 83 "/Users/armasconi/401/SONGTRACK2/Views/Home/Dashboard.cshtml"
                           Write(g.Gear.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                                ");
            WriteLiteral("&nbsp;\n");
#nullable restore
#line 85 "/Users/armasconi/401/SONGTRACK2/Views/Home/Dashboard.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\n                            <td class=\"comments\">\n                                <a>");
#nullable restore
#line 88 "/Users/armasconi/401/SONGTRACK2/Views/Home/Dashboard.cshtml"
                              Write(t.Comments.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                            </td>\n                            <td>");
#nullable restore
#line 90 "/Users/armasconi/401/SONGTRACK2/Views/Home/Dashboard.cshtml"
                            Write(t.Aversions != null ? t.Aversions.Count : 0);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td class=\"date\">");
#nullable restore
#line 91 "/Users/armasconi/401/SONGTRACK2/Views/Home/Dashboard.cshtml"
                                    Write(t.CreatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>\n                            <a class=\"btn btn-warning text-decoration-none\"");
            BeginWriteAttribute("href", " href=\"", 5070, "\"", 5098, 2);
#nullable restore
#line 93 "/Users/armasconi/401/SONGTRACK2/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 5077, t.RecordisId, 5077, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5090, "/comment", 5090, 8, true);
            EndWriteAttribute();
            WriteLiteral(">\n                                <i style=\"color:white\" class=\"fa fa-comment\" aria-hidden=\"true\"></i></a>\n                            <a");
            BeginWriteAttribute("href", " href=\"", 5236, "\"", 5268, 2);
            WriteAttributeValue("", 5243, "/edit/track/", 5243, 12, true);
#nullable restore
#line 95 "/Users/armasconi/401/SONGTRACK2/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 5255, t.RecordisId, 5255, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success text-decoration-none\"><i\n                                    style=\"color: white\" class=\"fa fa-edit\"></i></a>\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6fef6e80830f440e37f7c678ef43bf7b19a6e95b16398", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 97 "/Users/armasconi/401/SONGTRACK2/Views/Home/Dashboard.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = t;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        </td>\n                    </tr>\n");
#nullable restore
#line 100 "/Users/armasconi/401/SONGTRACK2/Views/Home/Dashboard.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>
    <input class=""search"" style=""margin: 0 auto;display:block;border-radius:5px;text-align:center;margin-bottom:10px""
placeholder=""Filter by keyword"">

</div>
<!-- <a href=""/new-track"">Add a Track</a> -->
<script>
    var options = {
        valueNames: ['title', 'test', 'artist', 'filesize', 'tools', 'comments']
        // get id named correctly , th - add ""data-sort"" attrib and class name(as in valNames) also matching class for td
    };
    var sortable_table_wrapper = new List('sortable_table_wrapper', options);
    sortable_table_wrapper.sort(""title"", {
        order: ""title""
    });
</script>


");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fef6e80830f440e37f7c678ef43bf7b19a6e95b18927", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fef6e80830f440e37f7c678ef43bf7b19a6e95b20019", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Recordis>> Html { get; private set; }
    }
}
#pragma warning restore 1591
