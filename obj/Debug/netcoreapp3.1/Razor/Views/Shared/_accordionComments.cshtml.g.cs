#pragma checksum "C:\Users\ARA\Desktop\SONGTRACK+\Views\Shared\_accordionComments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1bdbe38960d497654fe55ba44e929f6ff434e391"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyApp.Namespace.Shared.Views_Shared__accordionComments), @"mvc.1.0.view", @"/Views/Shared/_accordionComments.cshtml")]
namespace MyApp.Namespace.Shared
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
#line 2 "C:\Users\ARA\Desktop\SONGTRACK+\Views\_ViewImports.cshtml"
using cSharp2022.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bdbe38960d497654fe55ba44e929f6ff434e391", @"/Views/Shared/_accordionComments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9931c87b96a1dddd3d7ba4f5f1dbbe4a125e298", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__accordionComments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Recordis>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "FormComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"accordion\" id=\"accordion-1\">\r\n    <div class=\"head\">\r\n        <div id=\"xxx\">jquery-data</div>\r\n        <h5>comments (");
#nullable restore
#line 7 "C:\Users\ARA\Desktop\SONGTRACK+\Views\Shared\_accordionComments.cshtml"
                 Write(Model.Comments.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</h5>\r\n\r\n\r\n        <i class=\"fa fa-angle-down plus\"></i>\r\n\r\n\r\n    </div>\r\n\r\n    <div class=\"content collapse\">\r\n        <!-- <div  id=\"xxx\"></div> -->\r\n\r\n        <script>\r\n            var id = \"");
#nullable restore
#line 19 "C:\Users\ARA\Desktop\SONGTRACK+\Views\Shared\_accordionComments.cshtml"
                 Write(Model.RecordisId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""; //passing razor var into js , notice the QUOTES
            $(document).ready(function () {
                function populatePage(data) {
                    $.each(data, function (key, value) {
                        // alert(key + "":"" + value.title);
                        $(""#xxx"").html(value.content)
                    })
                }
                var url = ""/track/comments/"" + id
                $.get(url, data => { //ajax call 
                    console.log(data)
                    populatePage(data);
                })
            });
        </script>

        <button class=""btn btn-info"" onclick=""myFunction()"">POST</button>



        <div id=""Commentlist"" class=""pretty-box"">
");
#nullable restore
#line 40 "C:\Users\ARA\Desktop\SONGTRACK+\Views\Shared\_accordionComments.cshtml"
              var x = @Model.RecordisId;
            Comment z = new Comment();
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\ARA\Desktop\SONGTRACK+\Views\Shared\_accordionComments.cshtml"
             foreach(var com in @Model.Comments)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"outline\">\r\n                <span class=\"date\"><em>");
#nullable restore
#line 46 "C:\Users\ARA\Desktop\SONGTRACK+\Views\Shared\_accordionComments.cshtml"
                                  Write(com.CreatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</em></span>\r\n                <div>\r\n                    ");
#nullable restore
#line 48 "C:\Users\ARA\Desktop\SONGTRACK+\Views\Shared\_accordionComments.cshtml"
               Write(com.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 49 "C:\Users\ARA\Desktop\SONGTRACK+\Views\Shared\_accordionComments.cshtml"
               Write(com.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1510, "\"", 1548, 5);
            WriteAttributeValue("", 1517, "/tool/delete/", 1517, 13, true);
#nullable restore
#line 51 "C:\Users\ARA\Desktop\SONGTRACK+\Views\Shared\_accordionComments.cshtml"
WriteAttributeValue("", 1530, x, 1530, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1532, "/", 1532, 1, true);
#nullable restore
#line 51 "C:\Users\ARA\Desktop\SONGTRACK+\Views\Shared\_accordionComments.cshtml"
WriteAttributeValue("", 1533, com.CommentId, 1533, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1547, "/", 1547, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-window-close\"></i></a>\r\n            </div>\r\n            <!-- z = com; -->\r\n");
#nullable restore
#line 54 "C:\Users\ARA\Desktop\SONGTRACK+\Views\Shared\_accordionComments.cshtml"
            }

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
            <script>
                $(""#clicklink"").click(function () {
                    $.ajax({
                        type: ""get"",
                        url: ""/CommentList?handler=AllComment"",
                        success: function (response) {
                            $(""#commentlist"").html(response);
                        }
                    });
                });
            </script>
            ");
            }
            );
            WriteLiteral("        </div>\r\n    </div>\r\n    <div id=\"myDIV\" style=\"display:none\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1bdbe38960d497654fe55ba44e929f6ff434e3917916", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 72 "C:\Users\ARA\Desktop\SONGTRACK+\Views\Shared\_accordionComments.cshtml"
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
            WriteLiteral(";\r\n    </div>\r\n</div>");
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
