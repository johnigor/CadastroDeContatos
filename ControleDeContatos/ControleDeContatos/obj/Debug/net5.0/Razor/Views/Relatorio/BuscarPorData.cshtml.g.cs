#pragma checksum "C:\Users\John\Desktop\CadastroDeContatos\CadastroDeContatos\ControleDeContatos\ControleDeContatos\Views\Relatorio\BuscarPorData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aad9fe7ac0fd8b6f0382682455593db8b9cde3b1"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aad9fe7ac0fd8b6f0382682455593db8b9cde3b1", @"/Views/Relatorio/BuscarPorData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e15e6b3a3754a4b191426234179754bca81c2c7", @"/Views/_ViewImports.cshtml")]
    public class Views_Relatorio_BuscarPorData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ControleDeContatos.Models.ContatoModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"panel-body\">\r\n    <table class=\"table table-striped table-hover\">\r\n        <thead>\r\n            <tr class=\"success\">\r\n                <th>\r\n                    ");
#nullable restore
#line 8 "C:\Users\John\Desktop\CadastroDeContatos\CadastroDeContatos\ControleDeContatos\ControleDeContatos\Views\Relatorio\BuscarPorData.cshtml"
               Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 11 "C:\Users\John\Desktop\CadastroDeContatos\CadastroDeContatos\ControleDeContatos\ControleDeContatos\Views\Relatorio\BuscarPorData.cshtml"
               Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 14 "C:\Users\John\Desktop\CadastroDeContatos\CadastroDeContatos\ControleDeContatos\ControleDeContatos\Views\Relatorio\BuscarPorData.cshtml"
               Write(Html.DisplayNameFor(model => model.NomeDaEmpresa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 17 "C:\Users\John\Desktop\CadastroDeContatos\CadastroDeContatos\ControleDeContatos\ControleDeContatos\Views\Relatorio\BuscarPorData.cshtml"
               Write(Html.DisplayNameFor(model => model.UF));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 20 "C:\Users\John\Desktop\CadastroDeContatos\CadastroDeContatos\ControleDeContatos\ControleDeContatos\Views\Relatorio\BuscarPorData.cshtml"
               Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 23 "C:\Users\John\Desktop\CadastroDeContatos\CadastroDeContatos\ControleDeContatos\ControleDeContatos\Views\Relatorio\BuscarPorData.cshtml"
               Write(Html.DisplayNameFor(model => model.DataCadastro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 28 "C:\Users\John\Desktop\CadastroDeContatos\CadastroDeContatos\ControleDeContatos\ControleDeContatos\Views\Relatorio\BuscarPorData.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 32 "C:\Users\John\Desktop\CadastroDeContatos\CadastroDeContatos\ControleDeContatos\ControleDeContatos\Views\Relatorio\BuscarPorData.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 35 "C:\Users\John\Desktop\CadastroDeContatos\CadastroDeContatos\ControleDeContatos\ControleDeContatos\Views\Relatorio\BuscarPorData.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 38 "C:\Users\John\Desktop\CadastroDeContatos\CadastroDeContatos\ControleDeContatos\ControleDeContatos\Views\Relatorio\BuscarPorData.cshtml"
                   Write(Html.DisplayFor(modelItem => item.NomeDaEmpresa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 41 "C:\Users\John\Desktop\CadastroDeContatos\CadastroDeContatos\ControleDeContatos\ControleDeContatos\Views\Relatorio\BuscarPorData.cshtml"
                   Write(Html.DisplayFor(modelItem => item.UF));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 44 "C:\Users\John\Desktop\CadastroDeContatos\CadastroDeContatos\ControleDeContatos\ControleDeContatos\Views\Relatorio\BuscarPorData.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 47 "C:\Users\John\Desktop\CadastroDeContatos\CadastroDeContatos\ControleDeContatos\ControleDeContatos\Views\Relatorio\BuscarPorData.cshtml"
                   Write(Html.DisplayFor(modelItem => item.DataCadastro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 50 "C:\Users\John\Desktop\CadastroDeContatos\CadastroDeContatos\ControleDeContatos\ControleDeContatos\Views\Relatorio\BuscarPorData.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ControleDeContatos.Models.ContatoModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
