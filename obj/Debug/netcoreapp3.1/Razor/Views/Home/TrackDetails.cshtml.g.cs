#pragma checksum "C:\Users\ARA\Desktop\SongTrack-master\Views\Home\TrackDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05b29502b3bec0511d6566b107b16532dd8d3bab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyApp.Namespace.Home.Views_Home_TrackDetails), @"mvc.1.0.view", @"/Views/Home/TrackDetails.cshtml")]
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
#line 1 "C:\Users\ARA\Desktop\SongTrack-master\Views\Home\TrackDetails.cshtml"
using cSharp2022.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05b29502b3bec0511d6566b107b16532dd8d3bab", @"/Views/Home/TrackDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9931c87b96a1dddd3d7ba4f5f1dbbe4a125e298", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_TrackDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Recordis>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_toolbar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_selector", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "FormComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/site.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<div style=\"display:flex\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "05b29502b3bec0511d6566b107b16532dd8d3bab4642", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n<!-- <button onClick=\"test()\">test</button> -->\n<div>\n    <table class=\"table\">\n        <thead style=\"color:white\">\n            <tr>\n                <th>");
#nullable restore
#line 11 "C:\Users\ARA\Desktop\SongTrack-master\Views\Home\TrackDetails.cshtml"
               Write(Model.title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\"anno\">by&nbsp;</span><span class=\"invert\"> ");
#nullable restore
#line 11 "C:\Users\ARA\Desktop\SongTrack-master\Views\Home\TrackDetails.cshtml"
                                                                                    Write(Model.artist);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></th>\n                <th>tools</th>\n                <!-- <th>\n                    <partial name=\"_selector\" model=\"");
#nullable restore
#line 14 "C:\Users\ARA\Desktop\SongTrack-master\Views\Home\TrackDetails.cshtml"
                                                Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" />\n                </th> -->\n            </tr>\n        </thead>\n        <tbody>\n            <tr class=\"background-secondary\">\n                <th scope=\"row\">\n");
#nullable restore
#line 21 "C:\Users\ARA\Desktop\SongTrack-master\Views\Home\TrackDetails.cshtml"
                     if(Model.MediaFilePath!=null)
                    {
                    var sr = Model.MediaFilePath.Split("wwwroot");

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p class=\"date\">");
#nullable restore
#line 24 "C:\Users\ARA\Desktop\SongTrack-master\Views\Home\TrackDetails.cshtml"
                               Write(sr[1]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 24 "C:\Users\ARA\Desktop\SongTrack-master\Views\Home\TrackDetails.cshtml"
                                      Write(Model.length);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    <audio controls>\n                        <source");
            BeginWriteAttribute("src", " src=\"", 901, "\"", 913, 1);
#nullable restore
#line 26 "C:\Users\ARA\Desktop\SongTrack-master\Views\Home\TrackDetails.cshtml"
WriteAttributeValue("", 907, sr[1], 907, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"audio/mpeg\">\n                        Your browser does not support the audio element.\n                    </audio>\n");
#nullable restore
#line 29 "C:\Users\ARA\Desktop\SongTrack-master\Views\Home\TrackDetails.cshtml"
                    }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>no path found</p>\n");
#nullable restore
#line 31 "C:\Users\ARA\Desktop\SongTrack-master\Views\Home\TrackDetails.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </th>\n                <td>\n");
#nullable restore
#line 34 "C:\Users\ARA\Desktop\SongTrack-master\Views\Home\TrackDetails.cshtml"
                     foreach (var g in Model.Gears)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <!-- ");
            WriteLiteral(" -->\n                    <p>\n                        <a link-warning");
            BeginWriteAttribute("href", " href=", 1380, "", 1407, 3);
            WriteAttributeValue("", 1386, "/gear/", 1386, 6, true);
#nullable restore
#line 38 "C:\Users\ARA\Desktop\SongTrack-master\Views\Home\TrackDetails.cshtml"
WriteAttributeValue("", 1392, g.GearId, 1392, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1401, "/info/", 1401, 6, true);
            EndWriteAttribute();
            WriteLiteral("\n                            class=\"border border-info text-warning rounded text-decoration-none\">");
#nullable restore
#line 39 "C:\Users\ARA\Desktop\SongTrack-master\Views\Home\TrackDetails.cshtml"
                                                                                            Write(g.Gear.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </a>\n                        <a class=\"text-white rounded text-decoration-none\"");
            BeginWriteAttribute("href", "\n                            href=\"", 1622, "\"", 1695, 4);
            WriteAttributeValue("", 1657, "/delete/", 1657, 8, true);
#nullable restore
#line 42 "C:\Users\ARA\Desktop\SongTrack-master\Views\Home\TrackDetails.cshtml"
WriteAttributeValue("", 1665, Model.RecordisId, 1665, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1682, "/", 1682, 1, true);
#nullable restore
#line 42 "C:\Users\ARA\Desktop\SongTrack-master\Views\Home\TrackDetails.cshtml"
WriteAttributeValue("", 1683, g.ConnectId, 1683, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-window-close\"></i>\n                        </a>\n                    </p>\n                    <!-- <text>-</text> -->\n");
#nullable restore
#line 46 "C:\Users\ARA\Desktop\SongTrack-master\Views\Home\TrackDetails.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\n            </tr>\n        </tbody>\n    </table>\n    <div class=\"extra-info\">\n        <p>");
#nullable restore
#line 52 "C:\Users\ARA\Desktop\SongTrack-master\Views\Home\TrackDetails.cshtml"
      Write(Model.desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        <hr/>\n        <p>Date Info</p>\n        <p>\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "05b29502b3bec0511d6566b107b16532dd8d3bab11745", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 56 "C:\Users\ARA\Desktop\SongTrack-master\Views\Home\TrackDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model;

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
            WriteLiteral("\n        </p>\n    \n    </div>\n    \n    <div>\n        <a class=\"btn btn-warning text-decoration-none\"");
            BeginWriteAttribute("href", " href=\"", 2184, "\"", 2217, 3);
            WriteAttributeValue("", 2191, "/", 2191, 1, true);
#nullable restore
#line 62 "C:\Users\ARA\Desktop\SongTrack-master\Views\Home\TrackDetails.cshtml"
WriteAttributeValue("", 2192, Model.RecordisId, 2192, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2209, "/comment", 2209, 8, true);
            EndWriteAttribute();
            WriteLiteral(">\n            <i style=\"color:white\" class=\"fa fa-comment\" aria-hidden=\"true\"></i></a>\n\n        <a class=\"btn btn-success text-decoration-none\"");
            BeginWriteAttribute("href", " href=\"", 2361, "\"", 2397, 2);
            WriteAttributeValue("", 2368, "/edit/track/", 2368, 12, true);
#nullable restore
#line 65 "C:\Users\ARA\Desktop\SongTrack-master\Views\Home\TrackDetails.cshtml"
WriteAttributeValue("", 2380, Model.RecordisId, 2380, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n            <i style=\"color: white\" class=\"fa fa-edit\"></i></a>\n\n        <a class=\"btn btn-success text-decoration-none\"");
            BeginWriteAttribute("href", " href=\"", 2520, "\"", 2569, 3);
            WriteAttributeValue("", 2527, "/edit/track/add-version/", 2527, 24, true);
#nullable restore
#line 68 "C:\Users\ARA\Desktop\SongTrack-master\Views\Home\TrackDetails.cshtml"
WriteAttributeValue("", 2551, Model.RecordisId, 2551, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2568, "/", 2568, 1, true);
            EndWriteAttribute();
            WriteLiteral(">ADD\n            V</i></a>\n\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "05b29502b3bec0511d6566b107b16532dd8d3bab15164", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 71 "C:\Users\ARA\Desktop\SongTrack-master\Views\Home\TrackDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model;

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
            WriteLiteral("\n\n    </div>\n\n\n\n    <div class=\"accordion\" id=\"accordion-1\">\n        <div class=\"head\">\n            <h5>comments (");
#nullable restore
#line 79 "C:\Users\ARA\Desktop\SongTrack-master\Views\Home\TrackDetails.cshtml"
                     Write(Model.Comments.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</h5>\n            <i class=\"fa fa-angle-down plus\"></i>\n\n\n        </div>\n        <div class=\"content collapse\">\n            <button class=\"btn btn-info\" onclick=\"myFunction()\">POST</button>\n\n            <div class=\"pretty-box\">\n");
#nullable restore
#line 88 "C:\Users\ARA\Desktop\SongTrack-master\Views\Home\TrackDetails.cshtml"
                  var x = @Model.RecordisId;
                Comment z = new Comment();
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 91 "C:\Users\ARA\Desktop\SongTrack-master\Views\Home\TrackDetails.cshtml"
                 foreach(var com in @Model.Comments)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"outline\">\n                    <span class=\"date\"><em>");
#nullable restore
#line 94 "C:\Users\ARA\Desktop\SongTrack-master\Views\Home\TrackDetails.cshtml"
                                      Write(com.CreatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</em></span> ");
#nullable restore
#line 94 "C:\Users\ARA\Desktop\SongTrack-master\Views\Home\TrackDetails.cshtml"
                                                                 Write(com.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | ");
#nullable restore
#line 94 "C:\Users\ARA\Desktop\SongTrack-master\Views\Home\TrackDetails.cshtml"
                                                                              Write(com.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | <a");
            BeginWriteAttribute("href", "\n                        href=\"", 3326, "\"", 3388, 5);
            WriteAttributeValue("", 3357, "/tool/delete/", 3357, 13, true);
#nullable restore
#line 95 "C:\Users\ARA\Desktop\SongTrack-master\Views\Home\TrackDetails.cshtml"
WriteAttributeValue("", 3370, x, 3370, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3372, "/", 3372, 1, true);
#nullable restore
#line 95 "C:\Users\ARA\Desktop\SongTrack-master\Views\Home\TrackDetails.cshtml"
WriteAttributeValue("", 3373, com.CommentId, 3373, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3387, "/", 3387, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-window-close\"></i></a>\n                </div>\n                <!-- z = com; -->\n");
#nullable restore
#line 98 "C:\Users\ARA\Desktop\SongTrack-master\Views\Home\TrackDetails.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n        </div>\n        <div id=\"myDIV\" style=\"display:none\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "05b29502b3bec0511d6566b107b16532dd8d3bab19913", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 102 "C:\Users\ARA\Desktop\SongTrack-master\Views\Home\TrackDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = z;

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
            WriteLiteral(";\n        </div>\n    </div>\n    <div id=\"accordion-1\">\n        <div class=\"head\">\n            <h5>versions (");
#nullable restore
#line 107 "C:\Users\ARA\Desktop\SongTrack-master\Views\Home\TrackDetails.cshtml"
                     Write(Model.Aversions.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</h5>\n            <i class=\"fa fa-angle-down arrow\"></i>\n        </div>\n        <div class=\"content\">\n");
#nullable restore
#line 111 "C:\Users\ARA\Desktop\SongTrack-master\Views\Home\TrackDetails.cshtml"
             if(Model.Aversions.Count>0)
            {
            foreach (var v in Model.Aversions)
            {
            if(v.MediaFilePath!=null)
            {
            var trimPath = v.MediaFilePath.Split("wwwroot");

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>");
#nullable restore
#line 118 "C:\Users\ARA\Desktop\SongTrack-master\Views\Home\TrackDetails.cshtml"
          Write(trimPath[1]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 118 "C:\Users\ARA\Desktop\SongTrack-master\Views\Home\TrackDetails.cshtml"
                       Write(Model.length);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            <div class=\"vers\">\n                <div>\n                    ");
#nullable restore
#line 121 "C:\Users\ARA\Desktop\SongTrack-master\Views\Home\TrackDetails.cshtml"
               Write(v.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    ");
#nullable restore
#line 122 "C:\Users\ARA\Desktop\SongTrack-master\Views\Home\TrackDetails.cshtml"
               Write(v.Length);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </div>\n                <div>\n                    <audio controls>\n                        <source");
            BeginWriteAttribute("src", " src=\"", 4369, "\"", 4387, 1);
#nullable restore
#line 126 "C:\Users\ARA\Desktop\SongTrack-master\Views\Home\TrackDetails.cshtml"
WriteAttributeValue("", 4375, trimPath[1], 4375, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\'audio/mpeg\'>\n                        Your browser does not support the audio element.\n                    </audio>\n                </div>\n                <a style=\"color:aliceblue\"");
            BeginWriteAttribute("href", " href=\"", 4575, "\"", 4629, 4);
            WriteAttributeValue("", 4582, "/version/delete/", 4582, 16, true);
#nullable restore
#line 130 "C:\Users\ARA\Desktop\SongTrack-master\Views\Home\TrackDetails.cshtml"
WriteAttributeValue("", 4598, Model.RecordisId, 4598, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4615, "/", 4615, 1, true);
#nullable restore
#line 130 "C:\Users\ARA\Desktop\SongTrack-master\Views\Home\TrackDetails.cshtml"
WriteAttributeValue("", 4616, v.AversionId, 4616, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i\n                        class=\"fa fa-close\"></i></a>\n            </div>\n");
#nullable restore
#line 133 "C:\Users\ARA\Desktop\SongTrack-master\Views\Home\TrackDetails.cshtml"
            }
            }
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>no versions added/exist</p>\n");
#nullable restore
#line 139 "C:\Users\ARA\Desktop\SongTrack-master\Views\Home\TrackDetails.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n    </div>\n\n</div>\n<div>\n    <a");
            BeginWriteAttribute("href", " href=\"", 4882, "\"", 4913, 2);
            WriteAttributeValue("", 4889, "/convert/", 4889, 9, true);
#nullable restore
#line 145 "C:\Users\ARA\Desktop\SongTrack-master\Views\Home\TrackDetails.cshtml"
WriteAttributeValue("", 4898, Model.fileName, 4898, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">convert</a>\n</div>\n\n\n\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05b29502b3bec0511d6566b107b16532dd8d3bab25884", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Recordis> Html { get; private set; }
    }
}
#pragma warning restore 1591