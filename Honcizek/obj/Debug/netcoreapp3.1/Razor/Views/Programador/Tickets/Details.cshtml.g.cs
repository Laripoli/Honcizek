#pragma checksum "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Tickets\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1aec453adaafe2793ce90eb5a65f0ecd81dac040"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Programador_Tickets_Details), @"mvc.1.0.view", @"/Views/Programador/Tickets/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1aec453adaafe2793ce90eb5a65f0ecd81dac040", @"/Views/Programador/Tickets/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb10e3e8ba77754d859a694970f134bb15e1fc57", @"/Views/_ViewImports.cshtml")]
    public class Views_Programador_Tickets_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Honcizek.DAL.Models.Tickets>
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
#line 3 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Tickets\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Detalles</h1>\r\n\r\n<div>\r\n    <h4>Tickets</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-4\">\r\n            ");
#nullable restore
#line 17 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-4\">\r\n            ");
#nullable restore
#line 23 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FechaRegistro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-4\">\r\n            ");
#nullable restore
#line 29 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.FechaRegistro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HoraRegistro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-4\">\r\n            ");
#nullable restore
#line 35 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.HoraRegistro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-4\">\r\n            ");
#nullable restore
#line 41 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FechaFinalizacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-4\">\r\n            ");
#nullable restore
#line 47 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.FechaFinalizacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HoraFinalizacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-4\">\r\n            ");
#nullable restore
#line 53 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.HoraFinalizacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Agente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-4\">\r\n            ");
#nullable restore
#line 59 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Agente.Clave));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-4\">\r\n            ");
#nullable restore
#line 65 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cliente.Clave));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 68 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Suscripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-4\">\r\n            ");
#nullable restore
#line 71 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Suscripcion.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <div class=\"pb-3\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1aec453adaafe2793ce90eb5a65f0ecd81dac04011014", async() => {
                WriteLiteral("\r\n      <button class=\"btn btn-info\">Editar</button>\r\n    ");
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
#line 77 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Tickets\Details.cshtml"
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
            WriteLiteral("\r\n\t</div>\r\n\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1aec453adaafe2793ce90eb5a65f0ecd81dac04013242", async() => {
                WriteLiteral("\r\n\t\t<button class=\"btn btn-primary\">Volver al listado</button>\r\n\t");
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
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Honcizek.DAL.Models.Tickets> Html { get; private set; }
    }
}
#pragma warning restore 1591
