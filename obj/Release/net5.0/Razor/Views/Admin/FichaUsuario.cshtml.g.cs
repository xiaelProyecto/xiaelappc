#pragma checksum "E:\ProyectoFinal\xiaelappc\xiaelappc\Views\Admin\FichaUsuario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c92c44e157c801050fd6d1f32a9744184e45b6d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_FichaUsuario), @"mvc.1.0.view", @"/Views/Admin/FichaUsuario.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c92c44e157c801050fd6d1f32a9744184e45b6d4", @"/Views/Admin/FichaUsuario.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d04b6b90274790d24788a6dede1408b8f86abc7c", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_FichaUsuario : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/FichaUsuario.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<input hidden");
            BeginWriteAttribute("value", " value=\"", 31, "\"", 48, 1);
#nullable restore
#line 2 "E:\ProyectoFinal\xiaelappc\xiaelappc\Views\Admin\FichaUsuario.cshtml"
WriteAttributeValue("", 39, Model.id, 39, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"FUId\"/>\r\n<div class=\"FIUAbuelo\">\r\n    <div class=\"FIUPadre\">\r\n        <h2>Información del usuario: ");
#nullable restore
#line 5 "E:\ProyectoFinal\xiaelappc\xiaelappc\Views\Admin\FichaUsuario.cshtml"
                                Write(Model.nickname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <table id=\"AdminTable\">\r\n            <tbody>\r\n\r\n                <tr>\r\n                    <td>Nombre del usuario</td>\r\n                    <td><input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 344, "\"", 367, 1);
#nullable restore
#line 11 "E:\ProyectoFinal\xiaelappc\xiaelappc\Views\Admin\FichaUsuario.cshtml"
WriteAttributeValue("", 352, Model.nickname, 352, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" required class=""FUIUser""/></td>
                    <td><button class=""FIUBtnSwap FUBNick""><i class=""bi bi-gear""></i></button></td>
                </tr>

                <tr>
                    <td>Contraseña usuario</td>
                    <td><input type=""password""");
            BeginWriteAttribute("value", " value=\"", 645, "\"", 653, 0);
            EndWriteAttribute();
            WriteLiteral(@" required class=""FUIPass""/></td>
                    <td><button class=""FIUBtnSwap FUBpass""><i class=""bi bi-gear""></i></button></td>
                </tr>
                <tr>
                    <td>Edad del usuario</td>
                    <td><input type=""number""");
            BeginWriteAttribute("value", " value=\"", 925, "\"", 943, 1);
#nullable restore
#line 22 "E:\ProyectoFinal\xiaelappc\xiaelappc\Views\Admin\FichaUsuario.cshtml"
WriteAttributeValue("", 933, Model.age, 933, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" required class=""FUIAge""/></td>
                    <td><button class=""FIUBtnSwap FUBAge""><i class=""bi bi-gear""></i></button></td>
                </tr>
                <tr>
                    <td>Mail del usuario</td>
                    <td><input type=""email""");
            BeginWriteAttribute("value", " value=\"", 1212, "\"", 1231, 1);
#nullable restore
#line 27 "E:\ProyectoFinal\xiaelappc\xiaelappc\Views\Admin\FichaUsuario.cshtml"
WriteAttributeValue("", 1220, Model.mail, 1220, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" required class=""FUIMail""/></td>
                    <td><button class=""FIUBtnSwap FUBMail""><i class=""bi bi-gear""></i></button></td>
                </tr>

            </tbody>
        </table>
    </div>
</div>
<div class=""FUAuxRespinsive"">
    <h4>Información del usuario: ");
#nullable restore
#line 36 "E:\ProyectoFinal\xiaelappc\xiaelappc\Views\Admin\FichaUsuario.cshtml"
                            Write(Model.nickname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <table>\r\n        <tbody>\r\n            <tr>\r\n                <td>Nombre del usuario</td>\r\n                <td><input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 1669, "\"", 1692, 1);
#nullable restore
#line 41 "E:\ProyectoFinal\xiaelappc\xiaelappc\Views\Admin\FichaUsuario.cshtml"
WriteAttributeValue("", 1677, Model.nickname, 1677, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" required class=""FUIUser"" /></td>
                <td><button class=""FIUBtnSwap FUBNick""><i class=""bi bi-gear""></i></button></td>
            </tr>

            <tr>
                <td>Contraseña usuario</td>
                <td><input type=""password""");
            BeginWriteAttribute("value", " value=\"", 1951, "\"", 1959, 0);
            EndWriteAttribute();
            WriteLiteral(" required class=\"FUIPass\" /></td>\r\n                <td><button class=\"FIUBtnSwap FUBpass\"><i class=\"bi bi-gear\"></i></button></td>\r\n            </tr>\r\n            <tr>\r\n                <td>Edad del usuario</td>\r\n                <td><input type=\"number\"");
            BeginWriteAttribute("value", " value=\"", 2212, "\"", 2230, 1);
#nullable restore
#line 52 "E:\ProyectoFinal\xiaelappc\xiaelappc\Views\Admin\FichaUsuario.cshtml"
WriteAttributeValue("", 2220, Model.age, 2220, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" required class=\"FUIAge\" /></td>\r\n                <td><button class=\"FIUBtnSwap FUBAge\"><i class=\"bi bi-gear\"></i></button></td>\r\n            </tr>\r\n            <tr>\r\n                <td>Mail del usuario</td>\r\n                <td><input type=\"email\"");
            BeginWriteAttribute("value", " value=\"", 2480, "\"", 2499, 1);
#nullable restore
#line 57 "E:\ProyectoFinal\xiaelappc\xiaelappc\Views\Admin\FichaUsuario.cshtml"
WriteAttributeValue("", 2488, Model.mail, 2488, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" required class=\"FUIMail\" /></td>\r\n                <td><button class=\"FIUBtnSwap FUBMail\"><i class=\"bi bi-gear\"></i></button></td>\r\n            </tr>\r\n\r\n        </tbody>\r\n    </table>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c92c44e157c801050fd6d1f32a9744184e45b6d49714", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserModel> Html { get; private set; }
    }
}
#pragma warning restore 1591