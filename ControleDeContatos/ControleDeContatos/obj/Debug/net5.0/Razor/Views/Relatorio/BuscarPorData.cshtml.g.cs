#pragma checksum "C:\Users\John\Desktop\CadastroDeContatos\CadastroDeContatos\ControleDeContatos\ControleDeContatos\Views\Relatorio\BuscarPorData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2996b71de7568e4f2875e2b96d0b43053836991"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Relatorio_BuscarPorData), @"mvc.1.0.view", @"/Views/Relatorio/BuscarPorData.cshtml")]
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
#line 1 "C:\Users\John\Desktop\CadastroDeContatos\CadastroDeContatos\ControleDeContatos\ControleDeContatos\Views\_ViewImports.cshtml"
using ControleDeContatos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\John\Desktop\CadastroDeContatos\CadastroDeContatos\ControleDeContatos\ControleDeContatos\Views\_ViewImports.cshtml"
using ControleDeContatos.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2996b71de7568e4f2875e2b96d0b43053836991", @"/Views/Relatorio/BuscarPorData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e15e6b3a3754a4b191426234179754bca81c2c7", @"/Views/_ViewImports.cshtml")]
    public class Views_Relatorio_BuscarPorData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ControleDeContatos.Models.ContatoModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
    <div class=""panel panel-primary"">
        <div class=""panel-body"">
            <table class=""table table-striped table-hover"">
                <thead>
                    <tr class=""success"">
                        <th>
                            ");
#nullable restore
#line 9 "C:\Users\John\Desktop\CadastroDeContatos\CadastroDeContatos\ControleDeContatos\ControleDeContatos\Views\Relatorio\BuscarPorData.cshtml"
                       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 12 "C:\Users\John\Desktop\CadastroDeContatos\CadastroDeContatos\ControleDeContatos\ControleDeContatos\Views\Relatorio\BuscarPorData.cshtml"
                       Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 15 "C:\Users\John\Desktop\CadastroDeContatos\CadastroDeContatos\ControleDeContatos\ControleDeContatos\Views\Relatorio\BuscarPorData.cshtml"
                       Write(Html.DisplayNameFor(model => model.NomeDaEmpresa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 18 "C:\Users\John\Desktop\CadastroDeContatos\CadastroDeContatos\ControleDeContatos\ControleDeContatos\Views\Relatorio\BuscarPorData.cshtml"
                       Write(Html.DisplayNameFor(model => model.UF));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 21 "C:\Users\John\Desktop\CadastroDeContatos\CadastroDeContatos\ControleDeContatos\ControleDeContatos\Views\Relatorio\BuscarPorData.cshtml"
                       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 24 "C:\Users\John\Desktop\CadastroDeContatos\CadastroDeContatos\ControleDeContatos\ControleDeContatos\Views\Relatorio\BuscarPorData.cshtml"
                       Write(Html.DisplayNameFor(model => model.DataCadastro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 29 "C:\Users\John\Desktop\CadastroDeContatos\CadastroDeContatos\ControleDeContatos\ControleDeContatos\Views\Relatorio\BuscarPorData.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 33 "C:\Users\John\Desktop\CadastroDeContatos\CadastroDeContatos\ControleDeContatos\ControleDeContatos\Views\Relatorio\BuscarPorData.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 36 "C:\Users\John\Desktop\CadastroDeContatos\CadastroDeContatos\ControleDeContatos\ControleDeContatos\Views\Relatorio\BuscarPorData.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 39 "C:\Users\John\Desktop\CadastroDeContatos\CadastroDeContatos\ControleDeContatos\ControleDeContatos\Views\Relatorio\BuscarPorData.cshtml"
                           Write(Html.DisplayFor(modelItem => item.NomeDaEmpresa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 42 "C:\Users\John\Desktop\CadastroDeContatos\CadastroDeContatos\ControleDeContatos\ControleDeContatos\Views\Relatorio\BuscarPorData.cshtml"
                           Write(Html.DisplayFor(modelItem => item.UF));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 45 "C:\Users\John\Desktop\CadastroDeContatos\CadastroDeContatos\ControleDeContatos\ControleDeContatos\Views\Relatorio\BuscarPorData.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 48 "C:\Users\John\Desktop\CadastroDeContatos\CadastroDeContatos\ControleDeContatos\ControleDeContatos\Views\Relatorio\BuscarPorData.cshtml"
                           Write(Html.DisplayFor(modelItem => item.DataCadastro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 51 "C:\Users\John\Desktop\CadastroDeContatos\CadastroDeContatos\ControleDeContatos\ControleDeContatos\Views\Relatorio\BuscarPorData.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ControleDeContatos.Models.ContatoModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
