#pragma checksum "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Cliente\Suscripciones\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66e07f26cb2b491dedb673211a82c6f9023f7062"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Suscripciones_Index), @"mvc.1.0.view", @"/Views/Cliente/Suscripciones/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66e07f26cb2b491dedb673211a82c6f9023f7062", @"/Views/Cliente/Suscripciones/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb10e3e8ba77754d859a694970f134bb15e1fc57", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Suscripciones_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Honcizek.DAL.Models.Suscripciones>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Ver", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Cliente\Suscripciones\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"py-3\">Listado de Suscripciones</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Cliente\Suscripciones\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th class=\"mobile\">\r\n                ");
#nullable restore
#line 16 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Cliente\Suscripciones\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FechaDesde));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Cliente\Suscripciones\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FechaHasta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Cliente\Suscripciones\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Renovacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Cliente\Suscripciones\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Periodicidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th class=\"mobile-suscripciones\">\r\n                ");
#nullable restore
#line 28 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Cliente\Suscripciones\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Agente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th class=\"mobile-suscripciones\">\r\n                ");
#nullable restore
#line 31 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Cliente\Suscripciones\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Proyecto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 37 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Cliente\Suscripciones\Index.cshtml"
         if (Model.Count() > 0)
        {

            

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Cliente\Suscripciones\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 44 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Cliente\Suscripciones\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"mobile\">\r\n");
#nullable restore
#line 47 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Cliente\Suscripciones\Index.cshtml"
                         if (item.FechaDesde != null)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Cliente\Suscripciones\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.FDesde));

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Cliente\Suscripciones\Index.cshtml"
                                                                      
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span>Sin especificar</span>\r\n");
#nullable restore
#line 54 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Cliente\Suscripciones\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 57 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Cliente\Suscripciones\Index.cshtml"
                         if (item.FechaHasta != null)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Cliente\Suscripciones\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.FHasta));

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Cliente\Suscripciones\Index.cshtml"
                                                                      
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span>Sin especificar</span>\r\n");
#nullable restore
#line 64 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Cliente\Suscripciones\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 67 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Cliente\Suscripciones\Index.cshtml"
                         if (item.Renovacion == 1)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span>Activa</span>\r\n");
#nullable restore
#line 70 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Cliente\Suscripciones\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span>Inactiva</span>\r\n");
#nullable restore
#line 74 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Cliente\Suscripciones\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 77 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Cliente\Suscripciones\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Periodicidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"mobile-suscripciones\">\r\n                        ");
#nullable restore
#line 80 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Cliente\Suscripciones\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Agente.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"mobile-suscripciones\">\r\n");
#nullable restore
#line 83 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Cliente\Suscripciones\Index.cshtml"
                         if (item.Tipo != "Hardware" && item.ProyectoId != null)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 85 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Cliente\Suscripciones\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Proyecto.Nombre));

#line default
#line hidden
#nullable disable
#nullable restore
#line 85 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Cliente\Suscripciones\Index.cshtml"
                                                                               
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span>Sin proyecto</span>\r\n");
#nullable restore
#line 90 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Cliente\Suscripciones\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66e07f26cb2b491dedb673211a82c6f9023f706212922", async() => {
                WriteLiteral("\r\n                            <button class=\"btn btn-primary\">\r\n                                Ver\r\n                            </button>\r\n                        ");
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
#line 93 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Cliente\Suscripciones\Index.cshtml"
                                              WriteLiteral(item.Id);

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
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 100 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Cliente\Suscripciones\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 100 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Cliente\Suscripciones\Index.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
#nullable restore
#line 104 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Cliente\Suscripciones\Index.cshtml"
 if (!(Model.Count() > 0))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2 style=\"text-align: center;width: 100%\">A&uacute;n no hay registros</h2>\r\n");
#nullable restore
#line 107 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Cliente\Suscripciones\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Honcizek.DAL.Models.Suscripciones>> Html { get; private set; }
    }
}
#pragma warning restore 1591
