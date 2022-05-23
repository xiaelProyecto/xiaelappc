#pragma checksum "E:\ProyectoFinal\xiaelappc\xiaelappc\Views\Anime\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4be071ae49bd7a3db623c2b3384f8385a1a25536"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Anime_Index), @"mvc.1.0.view", @"/Views/Anime/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4be071ae49bd7a3db623c2b3384f8385a1a25536", @"/Views/Anime/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d04b6b90274790d24788a6dede1408b8f86abc7c", @"/Views/_ViewImports.cshtml")]
    public class Views_Anime_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AnimeModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<h1 id=""atitulo"">Últimos Animes</h1>
<div class=""aBusquedaFather"">
    <input id=""busquedaAnime"" type=""text"" placeholder=""Busqueda de Animes!"" />
</div>


<div class=""container col-md-12"" id=""aContent"">
    <div class=""row col-md-12"" id=""acardsfather"">
");
#nullable restore
#line 10 "E:\ProyectoFinal\xiaelappc\xiaelappc\Views\Anime\Index.cshtml"
         foreach (var m in Model)
        {
            var id = m.id;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"acards\"");
            BeginWriteAttribute("style", " style=\"", 391, "\"", 483, 4);
            WriteAttributeValue("", 399, "background:url(", 399, 15, true);
#nullable restore
#line 13 "E:\ProyectoFinal\xiaelappc\xiaelappc\Views\Anime\Index.cshtml"
WriteAttributeValue("", 414, m.imageurl, 414, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 425, ");background-size:cover;background-position:center", 425, 50, true);
            WriteAttributeValue(" ", 475, "center;", 476, 8, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class=\"acardcont\">\r\n                    <h4>");
#nullable restore
#line 15 "E:\ProyectoFinal\xiaelappc\xiaelappc\Views\Anime\Index.cshtml"
                   Write(m.titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <p>");
#nullable restore
#line 16 "E:\ProyectoFinal\xiaelappc\xiaelappc\Views\Anime\Index.cshtml"
                  Write(m.descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <a class=\"aboton btn-primary\"");
            BeginWriteAttribute("onclick", " onclick=\'", 660, "\'", 685, 3);
            WriteAttributeValue("", 670, "verFicha(\"", 670, 10, true);
#nullable restore
#line 17 "E:\ProyectoFinal\xiaelappc\xiaelappc\Views\Anime\Index.cshtml"
WriteAttributeValue("", 680, id, 680, 3, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 683, "\")", 683, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Ver Ficha</a>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 20 "E:\ProyectoFinal\xiaelappc\xiaelappc\Views\Anime\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n</div>\r\n<div class=\"container col-md-12\" id=\"asearch\">\r\n    <div class=\"row col-md-12\" id=\"aSearchResult\">\r\n    </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>

        const URI = window.location.href;

        $(document).ready(() => {
            $(""#asearch"").hide();
        })
        function verFicha(id) {
            $.ajax({
                url: ""/Anime/FichaAnime"",
                type: ""GET"",
                data: { id: id },
                success: (view) => {
                    var newUri = URI + ""/FichaAnime/"" + id;
                    window.location.replace(newUri);

                }
            })
        }
        $('#busquedaAnime').keypress(function (e) {
            var value = $('#busquedaAnime').val();
            var keycode = (e.keyCode ? e.keyCode : e.which);
            if (keycode == '13') {
                $.ajax({
                    url: ""/Anime/PVFichaAnime"",
                    type: ""GET"",
                    data: { name: value },
                    success: (partialViewResult) => {
                        $(""#aContent"").hide();
                        $(""#asearch"").show();
         ");
                WriteLiteral(@"               $(""#aSearchResult"").html(partialViewResult);
                        let id = $(""#PVAnimeID"").val();
                        $(""#modalAnimeBtnClose"").on('click', (e) => {
                            location.reload();
                        })
                        $(""#modalAnimeBtnOpen"").on('click', (e) => {
                            verFicha(id)
                        })
                    }
                });
            }
        });



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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AnimeModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591