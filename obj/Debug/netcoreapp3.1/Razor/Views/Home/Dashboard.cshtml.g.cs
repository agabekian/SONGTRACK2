#pragma checksum "/Users/armasconi/CSHARP2024/SONGTRACK2/Views/Home/Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be8f4266e7cc47eb488c348df5d236e4648d677f"
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
#line 2 "/Users/armasconi/CSHARP2024/SONGTRACK2/Views/_ViewImports.cshtml"
using cSharp2022.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/armasconi/CSHARP2024/SONGTRACK2/Views/Home/Dashboard.cshtml"
using FileTypeChecker;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/armasconi/CSHARP2024/SONGTRACK2/Views/Home/Dashboard.cshtml"
using FileTypeChecker.Abstracts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/armasconi/CSHARP2024/SONGTRACK2/Views/Home/Dashboard.cshtml"
using FileTypeChecker.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/armasconi/CSHARP2024/SONGTRACK2/Views/Home/Dashboard.cshtml"
using FileTypeChecker.Types;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/armasconi/CSHARP2024/SONGTRACK2/Views/Home/Dashboard.cshtml"
using System.IO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be8f4266e7cc47eb488c348df5d236e4648d677f", @"/Views/Home/Dashboard.cshtml")]
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
            WriteLiteral(@"
<a class=""text-decoration-none"" id=""scaleContainer"" href=""/new-track"">
    <i class=""fa fa-plus"" style=""color:white""></i>
</a>

<div id=""sortable_table_wrapper"">
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
            <th class=""bg-secondary date"">ACTIONS</th>
        </tr>
        </thead>

        <tbody class=""list"">
");
#nullable restore
#line 29 "/Users/armasconi/CSHARP2024/SONGTRACK2/Views/Home/Dashboard.cshtml"
          
            int i = 1;
            foreach (Recordis t in @Model)
            {
                string sr = null;

                if (t.MediaFilePath != null)
                {
                    var cut = t.MediaFilePath.Split("wwwroot");
                    sr = cut.Length > 1 ? cut[1] : null; // Ensure there is a valid split
                }


#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <th scope=\"row\">\n                        ");
#nullable restore
#line 43 "/Users/armasconi/CSHARP2024/SONGTRACK2/Views/Home/Dashboard.cshtml"
                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1593, "\"", 1625, 2);
            WriteAttributeValue("", 1600, "/track/play/", 1600, 12, true);
#nullable restore
#line 44 "/Users/armasconi/CSHARP2024/SONGTRACK2/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 1612, t.RecordisId, 1612, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                            <i class=\"fas fa-file-export\" aria-hidden=\"true\"></i>\n                        </a>\n");
#nullable restore
#line 47 "/Users/armasconi/CSHARP2024/SONGTRACK2/Views/Home/Dashboard.cshtml"
                         try
                        {
                            using (var fileStream = File.OpenRead(t.MediaFilePath))
                            {
                                var isRecognizableType = FileTypeValidator.IsTypeRecognizable(fileStream);

                                if (!isRecognizableType)
                                {
                                    Console.WriteLine("Tis a weird file - forbidden!");
                                }

                                IFileType fileType = FileTypeValidator.GetFileType(fileStream);

                                // Check for MP3
                                if (fileType.Extension == "mp3")
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <audio controls>\n                                        <source");
            BeginWriteAttribute("src", " src=\"", 2575, "\"", 2597, 1);
#nullable restore
#line 64 "/Users/armasconi/CSHARP2024/SONGTRACK2/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 2581, Url.Content(sr), 2581, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\'audio/mpeg\'>\n                                        Your browser does not support the audio element.\n                                    </audio>\n");
#nullable restore
#line 67 "/Users/armasconi/CSHARP2024/SONGTRACK2/Views/Home/Dashboard.cshtml"
                                }

                                // Check if the file is an image
                                if (fileStream.IsImage())
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a");
            BeginWriteAttribute("href", " href=\"", 2982, "\"", 3014, 2);
            WriteAttributeValue("", 2989, "/track/play/", 2989, 12, true);
#nullable restore
#line 72 "/Users/armasconi/CSHARP2024/SONGTRACK2/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 3001, t.RecordisId, 3001, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 3061, "\"", 3083, 1);
#nullable restore
#line 73 "/Users/armasconi/CSHARP2024/SONGTRACK2/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 3067, Url.Content(sr), 3067, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3084, "\"", 3098, 1);
#nullable restore
#line 73 "/Users/armasconi/CSHARP2024/SONGTRACK2/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 3090, t.title, 3090, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"30\" onerror=\"this.src=\'/images/default-image.png\';\">\n                                    </a>\n");
#nullable restore
#line 75 "/Users/armasconi/CSHARP2024/SONGTRACK2/Views/Home/Dashboard.cshtml"
                                }

                                Console.WriteLine("Type Name: {0}", fileType.Name);
                                Console.WriteLine("Type Extension: {0}", fileType.Extension);
                                Console.WriteLine("Is Image?: {0}", fileStream.IsImage());
                                Console.WriteLine("Is Bitmap?: {0}", fileStream.Is<Bitmap>());
                            }
                        }
                        catch (DirectoryNotFoundException dirEx)
                        {
                            Console.WriteLine("Dashboard error " + dirEx.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"alert alert-danger\" role=\"alert\">\n                                Error loading file. Please try again later.\n                            </div>\n");
#nullable restore
#line 89 "/Users/armasconi/CSHARP2024/SONGTRACK2/Views/Home/Dashboard.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </th>\n                    <td>\n                        <a class=\"text-decoration-none text-white border border-secondary rounded title\"");
            BeginWriteAttribute("href", " href=\"", 4197, "\"", 4224, 2);
            WriteAttributeValue("", 4204, "/track/", 4204, 7, true);
#nullable restore
#line 92 "/Users/armasconi/CSHARP2024/SONGTRACK2/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 4211, t.RecordisId, 4211, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 92 "/Users/armasconi/CSHARP2024/SONGTRACK2/Views/Home/Dashboard.cshtml"
                                                                                                                                Write(t.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                    </td>\n                    <td class=\"font-fancy artist\">");
#nullable restore
#line 94 "/Users/armasconi/CSHARP2024/SONGTRACK2/Views/Home/Dashboard.cshtml"
                                             Write(t.artist);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td class=\"filesize\" style=\"font-size: 0.8rem;\">");
#nullable restore
#line 95 "/Users/armasconi/CSHARP2024/SONGTRACK2/Views/Home/Dashboard.cshtml"
                                                               Write(t.length);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td class=\"tools\"> ");
            WriteLiteral("\n");
#nullable restore
#line 97 "/Users/armasconi/CSHARP2024/SONGTRACK2/Views/Home/Dashboard.cshtml"
                         foreach (var g in t.Gears)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a");
            BeginWriteAttribute("href", " href=\"", 4586, "\"", 4614, 3);
            WriteAttributeValue("", 4593, "/gear/", 4593, 6, true);
#nullable restore
#line 99 "/Users/armasconi/CSHARP2024/SONGTRACK2/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 4599, g.GearId, 4599, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4608, "/info/", 4608, 6, true);
            EndWriteAttribute();
            WriteLiteral(" \n                               class=\"border border-info rounded link-warning text-decoration-none\">\n                                ");
#nullable restore
#line 101 "/Users/armasconi/CSHARP2024/SONGTRACK2/Views/Home/Dashboard.cshtml"
                           Write(g.Gear.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </a>\n");
#nullable restore
#line 103 "/Users/armasconi/CSHARP2024/SONGTRACK2/Views/Home/Dashboard.cshtml"
                             if (g != t.Gears.Last())
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 105 "/Users/armasconi/CSHARP2024/SONGTRACK2/Views/Home/Dashboard.cshtml"
                           Write(Html.Raw("&nbsp;"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 105 "/Users/armasconi/CSHARP2024/SONGTRACK2/Views/Home/Dashboard.cshtml"
                                                    // Render a non-breaking space
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 106 "/Users/armasconi/CSHARP2024/SONGTRACK2/Views/Home/Dashboard.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\n\n                    <td class=\"comments\"><a> ");
#nullable restore
#line 110 "/Users/armasconi/CSHARP2024/SONGTRACK2/Views/Home/Dashboard.cshtml"
                                        Write(t.Comments.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a></td>\n                    <td>");
#nullable restore
#line 111 "/Users/armasconi/CSHARP2024/SONGTRACK2/Views/Home/Dashboard.cshtml"
                    Write(t.Aversions?.Count ?? 0);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td class=\"date\">");
#nullable restore
#line 112 "/Users/armasconi/CSHARP2024/SONGTRACK2/Views/Home/Dashboard.cshtml"
                                Write(t.CreatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>\n                        <a class=\"btn btn-warning text-decoration-none\"");
            BeginWriteAttribute("href", " href=\"", 5327, "\"", 5355, 2);
#nullable restore
#line 114 "/Users/armasconi/CSHARP2024/SONGTRACK2/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 5334, t.RecordisId, 5334, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5347, "/comment", 5347, 8, true);
            EndWriteAttribute();
            WriteLiteral(">\n                            <i style=\"color:white\" class=\"fa fa-comment\" aria-hidden=\"true\"></i>\n                        </a>\n                        <a");
            BeginWriteAttribute("href", " href=\"", 5510, "\"", 5542, 2);
            WriteAttributeValue("", 5517, "/edit/track/", 5517, 12, true);
#nullable restore
#line 117 "/Users/armasconi/CSHARP2024/SONGTRACK2/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 5529, t.RecordisId, 5529, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success text-decoration-none\">\n                            <i style=\"color: white\" class=\"fa fa-edit\"></i>\n                        </a>\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "be8f4266e7cc47eb488c348df5d236e4648d677f17389", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 120 "/Users/armasconi/CSHARP2024/SONGTRACK2/Views/Home/Dashboard.cshtml"
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
            WriteLiteral("\n                    </td>\n                </tr>\n");
#nullable restore
#line 123 "/Users/armasconi/CSHARP2024/SONGTRACK2/Views/Home/Dashboard.cshtml"
                i++;
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>
    <input class=""search"" style=""display:block; border-radius:5px; text-align:center; margin: 0 auto 10px;"" placeholder=""Filter by keyword"">
</div>

<script>
    
    const options = 
    {
        valueNames: ['title', 'test', 'artist', 'filesize', 'tools', 'comments']
    };
    const sortable_table_wrapper = new List('sortable_table_wrapper', options);
    sortable_table_wrapper.sort(""title"", { order: ""title"" });

</script>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be8f4266e7cc47eb488c348df5d236e4648d677f19750", async() => {
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
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be8f4266e7cc47eb488c348df5d236e4648d677f20834", async() => {
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
