#pragma checksum "E:\ProyectoFinal\xiaelappc\xiaelappc\Views\Anime\FichaAnime.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44c5a80fd15403414a4c4247ac7b55c4f3675882"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Anime_FichaAnime), @"mvc.1.0.view", @"/Views/Anime/FichaAnime.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44c5a80fd15403414a4c4247ac7b55c4f3675882", @"/Views/Anime/FichaAnime.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d04b6b90274790d24788a6dede1408b8f86abc7c", @"/Views/_ViewImports.cshtml")]
    public class Views_Anime_FichaAnime : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AnimeModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div id=\"fsta\"");
            BeginWriteAttribute("style", " style=\"", 33, "\"", 363, 17);
            WriteAttributeValue("", 41, "background:", 41, 11, true);
            WriteAttributeValue(" ", 52, "linear-gradient(rgba(0,0,0,0.50)", 53, 33, true);
            WriteAttributeValue(" ", 85, "0%,rgba(0,0,0,0.50)100%),url(", 86, 30, true);
#nullable restore
#line 2 "E:\ProyectoFinal\xiaelappc\xiaelappc\Views\Anime\FichaAnime.cshtml"
WriteAttributeValue("", 115, Model.imageurl, 115, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 130, ");background-size:", 130, 18, true);
            WriteAttributeValue(" ", 148, "cover;", 149, 7, true);
            WriteAttributeValue("\r\n        ", 155, "background-position:center", 165, 36, true);
            WriteAttributeValue(" ", 191, "center;", 192, 8, true);
            WriteAttributeValue("\r\n        ", 199, "font-size:", 209, 20, true);
            WriteAttributeValue(" ", 219, "16px;", 220, 6, true);
            WriteAttributeValue("\r\n        ", 225, "min-height:", 235, 21, true);
            WriteAttributeValue(" ", 246, "40.62em;", 247, 9, true);
            WriteAttributeValue("\r\n        ", 255, "color:", 265, 16, true);
            WriteAttributeValue(" ", 271, "white;", 272, 7, true);
            WriteAttributeValue("\r\n        ", 278, "display:flex;", 288, 23, true);
            WriteAttributeValue("\r\n        ", 301, "justify-content:center;", 311, 33, true);
            WriteAttributeValue("\r\n        ", 334, "align-items:center;", 344, 29, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div id=\"fstaa\">\r\n        <div id=\"fstaaa\">\r\n            <h1 id=\"fstitulo\">");
#nullable restore
#line 12 "E:\ProyectoFinal\xiaelappc\xiaelappc\Views\Anime\FichaAnime.cshtml"
                         Write(Model.titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            <p><b>Estrenada:</b> ");
#nullable restore
#line 13 "E:\ProyectoFinal\xiaelappc\xiaelappc\Views\Anime\FichaAnime.cshtml"
                            Write(Model.lanzamiento.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p><b>Director:</b> ");
#nullable restore
#line 14 "E:\ProyectoFinal\xiaelappc\xiaelappc\Views\Anime\FichaAnime.cshtml"
                           Write(Model.director);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
            <p><b>Favoritos:</b> <button class=""btnLike""><i class=""bi bi-arrow-through-heart""></i></button></p>
        </div>
    </div>
</div>
<div id=""fichaanimefather"">

    <div class=""FichaAnime"">
        <h2>FICHA</h2>
        <div id=""FichaAnimeIframe"">
            <iframe");
            BeginWriteAttribute("src", " src=\"", 871, "\"", 894, 1);
#nullable restore
#line 24 "E:\ProyectoFinal\xiaelappc\xiaelappc\Views\Anime\FichaAnime.cshtml"
WriteAttributeValue("", 877, Model.trailerurl, 877, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                    frameborder=\"0\"\r\n                    allowfullscreen\r\n                    style=\"border-radius:5px\"></iframe>\r\n        </div>\r\n        <div id=\"FichaAnimeContenido\">\r\n            <h3>Sipnosis</h3>\r\n            <p>");
#nullable restore
#line 31 "E:\ProyectoFinal\xiaelappc\xiaelappc\Views\Anime\FichaAnime.cshtml"
          Write(Model.descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <h3>Categorias</h3>\r\n");
#nullable restore
#line 33 "E:\ProyectoFinal\xiaelappc\xiaelappc\Views\Anime\FichaAnime.cshtml"
             foreach (var categoria in Model.categoria)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>");
#nullable restore
#line 35 "E:\ProyectoFinal\xiaelappc\xiaelappc\Views\Anime\FichaAnime.cshtml"
              Write(categoria);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 36 "E:\ProyectoFinal\xiaelappc\xiaelappc\Views\Anime\FichaAnime.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n    <input hidden");
            BeginWriteAttribute("value", " value=\'", 1354, "\'", 1380, 1);
#nullable restore
#line 39 "E:\ProyectoFinal\xiaelappc\xiaelappc\Views\Anime\FichaAnime.cshtml"
WriteAttributeValue("", 1362, ViewData["token"], 1362, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"FPATokenValue\" />\r\n    <input hidden");
            BeginWriteAttribute("value", " value=\'", 1422, "\'", 1439, 1);
#nullable restore
#line 40 "E:\ProyectoFinal\xiaelappc\xiaelappc\Views\Anime\FichaAnime.cshtml"
WriteAttributeValue("", 1430, Model.id, 1430, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"FPAidAnimeValue\" />\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        var tkn = $(""#FPATokenValue"").val();
        var a= $(""#FPAidAnimeValue"").val();

        $("".btnLike"").on('click', (e) => {
            if (!tkn == null || !tkn == """") {
                $.ajax({
                    url: ""/Login/updateFava"",
                    type: ""PUT"",
                    data: {
                        anime: a
                    },
                    success: (e) => {
                        alert(""Anime guardado en favoritos"")
                    }
                });
            } else {
                alert(""Debe tener iniciado una sesi??n"")
            }
        })



    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AnimeModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
