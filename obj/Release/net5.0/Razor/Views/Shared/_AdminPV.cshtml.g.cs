#pragma checksum "E:\ProyectoFinal\xiaelappc\xiaelappc\Views\Shared\_AdminPV.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20570d397a0b34747572bcdc4df328d2398ba541"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__AdminPV), @"mvc.1.0.view", @"/Views/Shared/_AdminPV.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20570d397a0b34747572bcdc4df328d2398ba541", @"/Views/Shared/_AdminPV.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d04b6b90274790d24788a6dede1408b8f86abc7c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__AdminPV : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<UserModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div id=""AdminTableContainer"">
    <table id=""AdminTable"">
        <thead>
            <tr>
                <th></th>
                <th>ID</th>
                <th>Usuario</th>
                <th>Email</th>
                <th>Rol</th>
                <th>Información</th>
                <th>Eliminar</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 16 "E:\ProyectoFinal\xiaelappc\xiaelappc\Views\Shared\_AdminPV.cshtml"
             foreach (var u in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    <img height=\"50\" width=\"50\"");
            BeginWriteAttribute("src", " src=\"", 540, "\"", 555, 1);
#nullable restore
#line 20 "E:\ProyectoFinal\xiaelappc\xiaelappc\Views\Shared\_AdminPV.cshtml"
WriteAttributeValue("", 546, u.avatar, 546, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"border-radius:10px\"/>\r\n                </td>\r\n                <td>");
#nullable restore
#line 22 "E:\ProyectoFinal\xiaelappc\xiaelappc\Views\Shared\_AdminPV.cshtml"
               Write(u.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "E:\ProyectoFinal\xiaelappc\xiaelappc\Views\Shared\_AdminPV.cshtml"
               Write(u.nickname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "E:\ProyectoFinal\xiaelappc\xiaelappc\Views\Shared\_AdminPV.cshtml"
               Write(u.mail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "E:\ProyectoFinal\xiaelappc\xiaelappc\Views\Shared\_AdminPV.cshtml"
               Write(u.rol);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><button class=\"AdminControlBtn\"");
            BeginWriteAttribute("onclick", " onclick=\"", 798, "\"", 829, 3);
            WriteAttributeValue("", 808, "FichaUsuario(\'", 808, 14, true);
#nullable restore
#line 26 "E:\ProyectoFinal\xiaelappc\xiaelappc\Views\Shared\_AdminPV.cshtml"
WriteAttributeValue("", 822, u.id, 822, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 827, "\')", 827, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-person-check\"></i></button></td>\r\n                <td><button class=\"AdminControlBtnDelete\"");
            BeginWriteAttribute("onclick", " onclick=\"", 938, "\"", 968, 3);
            WriteAttributeValue("", 948, "deleteUser(\'", 948, 12, true);
#nullable restore
#line 27 "E:\ProyectoFinal\xiaelappc\xiaelappc\Views\Shared\_AdminPV.cshtml"
WriteAttributeValue("", 960, u.id, 960, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 965, "\');", 965, 3, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-person-x\"></i></button></td>\r\n            </tr>\r\n");
#nullable restore
#line 29 "E:\ProyectoFinal\xiaelappc\xiaelappc\Views\Shared\_AdminPV.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<UserModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591