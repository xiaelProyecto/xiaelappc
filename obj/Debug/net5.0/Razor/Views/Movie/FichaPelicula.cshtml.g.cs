#pragma checksum "D:\Proyecto Final\xiaelappc\Views\Movie\FichaPelicula.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3265c4ebd50a01d66c614c7940c43b7081736bf3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_FichaPelicula), @"mvc.1.0.view", @"/Views/Movie/FichaPelicula.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3265c4ebd50a01d66c614c7940c43b7081736bf3", @"/Views/Movie/FichaPelicula.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d04b6b90274790d24788a6dede1408b8f86abc7c", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_FichaPelicula : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MovieModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <div id=\"fsta\"");
            BeginWriteAttribute("style", " style=\"", 37, "\"", 367, 17);
            WriteAttributeValue("", 45, "background:", 45, 11, true);
            WriteAttributeValue(" ", 56, "linear-gradient(rgba(0,0,0,0.50)", 57, 33, true);
            WriteAttributeValue(" ", 89, "0%,rgba(0,0,0,0.50)100%),url(", 90, 30, true);
#nullable restore
#line 2 "D:\Proyecto Final\xiaelappc\Views\Movie\FichaPelicula.cshtml"
WriteAttributeValue("", 119, Model.imageurl, 119, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 134, ");background-size:", 134, 18, true);
            WriteAttributeValue(" ", 152, "cover;", 153, 7, true);
            WriteAttributeValue("\r\n        ", 159, "background-position:center", 169, 36, true);
            WriteAttributeValue(" ", 195, "center;", 196, 8, true);
            WriteAttributeValue("\r\n        ", 203, "font-size:", 213, 20, true);
            WriteAttributeValue(" ", 223, "16px;", 224, 6, true);
            WriteAttributeValue("\r\n        ", 229, "min-height:", 239, 21, true);
            WriteAttributeValue(" ", 250, "40.62em;", 251, 9, true);
            WriteAttributeValue("\r\n        ", 259, "color:", 269, 16, true);
            WriteAttributeValue(" ", 275, "white;", 276, 7, true);
            WriteAttributeValue("\r\n        ", 282, "display:flex;", 292, 23, true);
            WriteAttributeValue("\r\n        ", 305, "justify-content:center;", 315, 33, true);
            WriteAttributeValue("\r\n        ", 338, "align-items:center;", 348, 29, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div id=\"fstaa\">\r\n            <div id=\"fstaaa\">\r\n                <h1 id=\"fstitulo\">");
#nullable restore
#line 12 "D:\Proyecto Final\xiaelappc\Views\Movie\FichaPelicula.cshtml"
                             Write(Model.titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            </div>\r\n        </div>\r\n    </div>\r\n<div class=\"container\">    \r\n     <div class=\"row col-md-12\">\r\n         <div class=\"FichaPelicula\">\r\n             <iframe width=\"1000\"\r\n                     height=\"400\"");
            BeginWriteAttribute("src", "\r\n                     src=\"", 699, "\"", 744, 1);
#nullable restore
#line 21 "D:\Proyecto Final\xiaelappc\Views\Movie\FichaPelicula.cshtml"
WriteAttributeValue("", 727, Model.trailerurl, 727, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                     frameborder=\"0\"\r\n                     allowfullscreen></iframe>\r\n             <h3>Trama</h3>\r\n             <p>");
#nullable restore
#line 25 "D:\Proyecto Final\xiaelappc\Views\Movie\FichaPelicula.cshtml"
           Write(Model.descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n             <h3>Reparto principal</h3>\r\n");
#nullable restore
#line 27 "D:\Proyecto Final\xiaelappc\Views\Movie\FichaPelicula.cshtml"
              foreach (var actor in Model.reparto)
             {

#line default
#line hidden
#nullable disable
            WriteLiteral("               <p>");
#nullable restore
#line 29 "D:\Proyecto Final\xiaelappc\Views\Movie\FichaPelicula.cshtml"
             Write(actor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 30 "D:\Proyecto Final\xiaelappc\Views\Movie\FichaPelicula.cshtml"
             }

#line default
#line hidden
#nullable disable
            WriteLiteral("         </div>\r\n     </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MovieModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
