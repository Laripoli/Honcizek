#pragma checksum "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Clientes\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68d8f978ac57b924518f4069a65bdc851b8a971f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrador_Clientes_Details), @"mvc.1.0.view", @"/Views/Administrador/Clientes/Details.cshtml")]
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
#line 1 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\_ViewImports.cshtml"
using Honcizek;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\_ViewImports.cshtml"
using Honcizek.DAL.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68d8f978ac57b924518f4069a65bdc851b8a971f", @"/Views/Administrador/Clientes/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb10e3e8ba77754d859a694970f134bb15e1fc57", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrador_Clientes_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Honcizek.DAL.Models.Clientes>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Clientes\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Detalles</h1>\r\n\r\n<div>\r\n    <h4>Clientes</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Clientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Login));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-4\">\r\n            ");
#nullable restore
#line 17 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Clientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Login));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Clientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Clave));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-4\">\r\n            ");
#nullable restore
#line 23 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Clientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Clave));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Clientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FechaRegistro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-4\">\r\n            ");
#nullable restore
#line 29 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Clientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Fecha));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Clientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Tipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-4\">\r\n            ");
#nullable restore
#line 35 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Clientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Tipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Clientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RazonSocial));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-4\">\r\n            ");
#nullable restore
#line 41 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Clientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.RazonSocial));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Clientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-4\">\r\n            ");
#nullable restore
#line 47 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Clientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Clientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Apellidos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-4\">\r\n            ");
#nullable restore
#line 53 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Clientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Apellidos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Clientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nifcif));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-4\">\r\n            ");
#nullable restore
#line 59 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Clientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nifcif));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Clientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-4\">\r\n            ");
#nullable restore
#line 65 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Clientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 68 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Clientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Movil));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-4\">\r\n            ");
#nullable restore
#line 71 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Clientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Movil));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 74 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Clientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-4\">\r\n            ");
#nullable restore
#line 77 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Clientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 80 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Clientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-4\">\r\n            ");
#nullable restore
#line 83 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Clientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 86 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Clientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-4\">\r\n            ");
#nullable restore
#line 89 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Clientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 92 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Clientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Observaciones));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-4\">\r\n            ");
#nullable restore
#line 95 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Clientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Observaciones));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 98 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Clientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Localidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-4\">\r\n            ");
#nullable restore
#line 101 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Clientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Localidad.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 104 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Clientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Pais));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-4\">\r\n            ");
#nullable restore
#line 107 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Clientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Pais.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 110 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Clientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Provincia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-4\">\r\n            ");
#nullable restore
#line 113 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Clientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Provincia.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div class=\"pb-3\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68d8f978ac57b924518f4069a65bdc851b8a971f15778", async() => {
                WriteLiteral("\r\n        <button class=\"btn btn-info\">Editar</button>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 118 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Clientes\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68d8f978ac57b924518f4069a65bdc851b8a971f18008", async() => {
                WriteLiteral("\r\n    <button class=\"btn btn-primary\">Volver al listado</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Honcizek.DAL.Models.Clientes> Html { get; private set; }
    }
}
#pragma warning restore 1591
