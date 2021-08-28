#pragma checksum "C:\Users\paulo\VisualStudio\Biblioteca\Views\Usuario\ListaDeUsuarios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc0cac243bbaa02e52af6d114e58a751601c0b66"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_ListaDeUsuarios), @"mvc.1.0.view", @"/Views/Usuario/ListaDeUsuarios.cshtml")]
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
#line 1 "C:\Users\paulo\VisualStudio\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\paulo\VisualStudio\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc0cac243bbaa02e52af6d114e58a751601c0b66", @"/Views/Usuario/ListaDeUsuarios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ea07f0214da259abc315dec5bc842518e8ae187", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_ListaDeUsuarios : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Usuario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\paulo\VisualStudio\Biblioteca\Views\Usuario\ListaDeUsuarios.cshtml"
  
    ViewData["Title"] = "Listagem de Usuarios";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Listagem de Usuarios</h2>\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n");
#nullable restore
#line 8 "C:\Users\paulo\VisualStudio\Biblioteca\Views\Usuario\ListaDeUsuarios.cshtml"
         if(Model.Count != 0){

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table table-striped""> 
            <thead>
                <tr>
                <th>Id</th>
                <th>Nome</th>
                <th>Login</th>
                <th>Tipo</th>
                <th></th>
                <th></th>
                </tr>
            </thead>
            <tbody>
                
");
#nullable restore
#line 22 "C:\Users\paulo\VisualStudio\Biblioteca\Views\Usuario\ListaDeUsuarios.cshtml"
                 foreach(Usuario e in Model)
                {
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 26 "C:\Users\paulo\VisualStudio\Biblioteca\Views\Usuario\ListaDeUsuarios.cshtml"
                   Write(e.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 27 "C:\Users\paulo\VisualStudio\Biblioteca\Views\Usuario\ListaDeUsuarios.cshtml"
                   Write(e.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "C:\Users\paulo\VisualStudio\Biblioteca\Views\Usuario\ListaDeUsuarios.cshtml"
                   Write(e.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 29 "C:\Users\paulo\VisualStudio\Biblioteca\Views\Usuario\ListaDeUsuarios.cshtml"
                         if(e.Tipo ==0){

#line default
#line hidden
#nullable disable
            WriteLiteral("<span class=\"text-danger\">Administrador</span>");
#nullable restore
#line 29 "C:\Users\paulo\VisualStudio\Biblioteca\Views\Usuario\ListaDeUsuarios.cshtml"
                                                                                      }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>Padrão</span>");
#nullable restore
#line 29 "C:\Users\paulo\VisualStudio\Biblioteca\Views\Usuario\ListaDeUsuarios.cshtml"
                                                                                                               }

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 906, "\"", 941, 2);
            WriteAttributeValue("", 913, "/Usuario/EditarUsuario/", 913, 23, true);
#nullable restore
#line 30 "C:\Users\paulo\VisualStudio\Biblioteca\Views\Usuario\ListaDeUsuarios.cshtml"
WriteAttributeValue("", 936, e.Id, 936, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a></td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 986, "\"", 1022, 2);
            WriteAttributeValue("", 993, "/Usuario/ExcluirUsuario/", 993, 24, true);
#nullable restore
#line 31 "C:\Users\paulo\VisualStudio\Biblioteca\Views\Usuario\ListaDeUsuarios.cshtml"
WriteAttributeValue("", 1017, e.Id, 1017, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">X</a></td>\r\n                </tr>\r\n");
#nullable restore
#line 33 "C:\Users\paulo\VisualStudio\Biblioteca\Views\Usuario\ListaDeUsuarios.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 36 "C:\Users\paulo\VisualStudio\Biblioteca\Views\Usuario\ListaDeUsuarios.cshtml"
        }
        else{

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>Sua busca não retornou resultado</p>");
#nullable restore
#line 37 "C:\Users\paulo\VisualStudio\Biblioteca\Views\Usuario\ListaDeUsuarios.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591