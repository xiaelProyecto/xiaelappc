#pragma checksum "E:\ProyectoFinal\xiaelappc\xiaelappc\Views\Shared\_FichaAnimeModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "082ac9c5642de60f2ae671c3d842499d65ebf5e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__FichaAnimeModal), @"mvc.1.0.view", @"/Views/Shared/_FichaAnimeModal.cshtml")]
namespace AspNetCore
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
#line 1 "E:\ProyectoFinal\xiaelappc\xiaelappc\Views\_ViewImports.cshtml"
using xiaelappc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\ProyectoFinal\xiaelappc\xiaelappc\Views\_ViewImports.cshtml"
using xiaelappc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"082ac9c5642de60f2ae671c3d842499d65ebf5e1", @"/Views/Shared/_FichaAnimeModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d04b6b90274790d24788a6dede1408b8f86abc7c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__FichaAnimeModal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AnimeModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container col-md-12\" id=\"mContent\">\r\n    <div class=\"row col-md-12\" id=\"mcardsfather\">\r\n        <div class=\"mcards\"");
            BeginWriteAttribute("style", " style=\"", 148, "\"", 244, 4);
            WriteAttributeValue("", 156, "background:url(", 156, 15, true);
#nullable restore
#line 5 "E:\ProyectoFinal\xiaelappc\xiaelappc\Views\Shared\_FichaAnimeModal.cshtml"
WriteAttributeValue("", 171, Model.imageurl, 171, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 186, ");background-size:cover;background-position:center", 186, 50, true);
            WriteAttributeValue(" ", 236, "center;", 237, 8, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <div class=\"mcardcont\">\r\n                <h4>");
#nullable restore
#line 7 "E:\ProyectoFinal\xiaelappc\xiaelappc\Views\Shared\_FichaAnimeModal.cshtml"
               Write(Model.titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <p>");
#nullable restore
#line 8 "E:\ProyectoFinal\xiaelappc\xiaelappc\Views\Shared\_FichaAnimeModal.cshtml"
              Write(Model.descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n            </div>\r\n            <input id=\"PVAnimeID\"");
            BeginWriteAttribute("value", " value=\"", 423, "\"", 440, 1);
#nullable restore
#line 11 "E:\ProyectoFinal\xiaelappc\xiaelappc\Views\Shared\_FichaAnimeModal.cshtml"
WriteAttributeValue("", 431, Model.id, 431, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" hidden />
            <div style=""margin-top:5px"">
                <button id=""modalAnimeBtnClose"" class=""mboton"">Cerrar</button>
                <button id=""modalAnimeBtnOpen"" class=""mboton"">Ver Ficha</button>
            </div>
        </div>

    </div>

</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AnimeModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
