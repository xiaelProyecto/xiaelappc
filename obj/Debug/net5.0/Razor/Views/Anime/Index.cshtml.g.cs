#pragma checksum "D:\Proyecto Final\xiaelappc\Views\Anime\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ffc946c972ac2e12f8d6dcce63263d45ac0ea45"
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
#line 1 "D:\Proyecto Final\xiaelappc\Views\_ViewImports.cshtml"
using xiaelappc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Proyecto Final\xiaelappc\Views\_ViewImports.cshtml"
using xiaelappc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ffc946c972ac2e12f8d6dcce63263d45ac0ea45", @"/Views/Anime/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d04b6b90274790d24788a6dede1408b8f86abc7c", @"/Views/_ViewImports.cshtml")]
    public class Views_Anime_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Proyecto Final\xiaelappc\Views\Anime\Index.cshtml"
  
    ViewData["Title"] = "Anime";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    <div>
        <h1>Anime</h1>
    </div>


    <div class=""anime-recomendadas"">
        <div class=""acontenedor-titulo-controles"">
            <h3>Anime Recomendadas</h3>
            <div class=""indicadores"">


            </div>
        </div>

        <div class=""acontenedor-principal"">
            <button role=""button"" id=""flecha-izquierda"" class=""flecha-izquierda"">
                <i class=""fa-solid fa-angle-left""></i>
            </button>

            <div class=""acontenedor-carousel"">
                <div class=""carousel"">
                    <div class=""anime"">
                        <a href=""#""><img src=""https://i.ibb.co/mFRFbxd/1917.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 726, "\"", 732, 0);
            EndWriteAttribute();
            WriteLiteral(@" /></a>
                    </div>


                </div>
            </div>

            <button role=""button"" id=""flecha-derecha"" class=""flecha-derecha"">
                <i class=""fa-solid fa-angle-right""></i>
            </button>
        </div>
    </div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
