#pragma checksum "C:\Users\ARA\Desktop\SongTrack-master\Views\Shared\_delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c71361c14dd3453e6bc8fcf641d5eecbf4fd437c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyApp.Namespace.Shared.Views_Shared__delete), @"mvc.1.0.view", @"/Views/Shared/_delete.cshtml")]
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
#line 1 "C:\Users\ARA\Desktop\SongTrack-master\Views\Shared\_delete.cshtml"
using cSharp2022.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c71361c14dd3453e6bc8fcf641d5eecbf4fd437c", @"/Views/Shared/_delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9931c87b96a1dddd3d7ba4f5f1dbbe4a125e298", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Recordis>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!-- <h1>Id = ");
#nullable restore
#line 3 "C:\Users\ARA\Desktop\SongTrack-master\Views\Shared\_delete.cshtml"
         Write(Model.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n<h1>Id = ");
#nullable restore
#line 4 "C:\Users\ARA\Desktop\SongTrack-master\Views\Shared\_delete.cshtml"
    Write(Model.RecordisId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1> -->\n<span");
            BeginWriteAttribute("id", " id=\"", 114, "\"", 154, 2);
            WriteAttributeValue("", 119, "confirmDeleteSpan_", 119, 18, true);
#nullable restore
#line 5 "C:\Users\ARA\Desktop\SongTrack-master\Views\Shared\_delete.cshtml"
WriteAttributeValue("", 137, Model.RecordisId, 137, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"display:none\">\n    <span><span style=\"color:red\">Delete?&nbsp;</span>\n    </span>\n    <a");
            BeginWriteAttribute("href", " href=\"", 251, "\"", 289, 2);
            WriteAttributeValue("", 258, "/delete/track/", 258, 14, true);
#nullable restore
#line 8 "C:\Users\ARA\Desktop\SongTrack-master\Views\Shared\_delete.cshtml"
WriteAttributeValue("", 272, Model.RecordisId, 272, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Yes</a>\n    <a href=\"#\"");
            BeginWriteAttribute("onClick", " onClick=\"", 337, "\"", 387, 3);
            WriteAttributeValue("", 347, "confirmDelete(\'", 347, 15, true);
#nullable restore
#line 9 "C:\Users\ARA\Desktop\SongTrack-master\Views\Shared\_delete.cshtml"
WriteAttributeValue("", 362, Model.RecordisId, 362, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 379, "\',false)", 379, 8, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">No</a>\n</span>\n\n<span");
            BeginWriteAttribute("id", " id=\"", 434, "\"", 467, 2);
            WriteAttributeValue("", 439, "deleteSpan_", 439, 11, true);
#nullable restore
#line 12 "C:\Users\ARA\Desktop\SongTrack-master\Views\Shared\_delete.cshtml"
WriteAttributeValue("", 450, Model.RecordisId, 450, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n    <a href=\"#\" class=\"btn btn-danger\"");
            BeginWriteAttribute("onClick", " onClick=\"", 508, "\"", 557, 3);
            WriteAttributeValue("", 518, "confirmDelete(\'", 518, 15, true);
#nullable restore
#line 13 "C:\Users\ARA\Desktop\SongTrack-master\Views\Shared\_delete.cshtml"
WriteAttributeValue("", 533, Model.RecordisId, 533, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 550, "\',true)", 550, 7, true);
            EndWriteAttribute();
            WriteLiteral("><i\n            class=\"fa fa-trash\" aria-hidden=\"true\"></i></a>\n</span>\n\n");
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