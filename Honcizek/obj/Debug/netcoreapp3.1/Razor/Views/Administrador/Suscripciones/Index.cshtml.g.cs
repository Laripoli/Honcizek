#pragma checksum "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Suscripciones\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f2bd9d753853ad3721dad5d5a1e6a5e2484d1dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrador_Suscripciones_Index), @"mvc.1.0.view", @"/Views/Administrador/Suscripciones/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f2bd9d753853ad3721dad5d5a1e6a5e2484d1dd", @"/Views/Administrador/Suscripciones/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb10e3e8ba77754d859a694970f134bb15e1fc57", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrador_Suscripciones_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Honcizek.DAL.Models.Suscripciones>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("honci-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Tickets", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "IndexUsuario", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Suscripciones\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Listado de ");
#nullable restore
#line 7 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Suscripciones\Index.cshtml"
           Write(!(bool)ViewData["general"]?"mis":"");

#line default
#line hidden
#nullable disable
            WriteLiteral(" suscripciones</h1>\r\n");
#nullable restore
#line 8 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Suscripciones\Index.cshtml"
 if (!(bool)ViewData["error"] && !(bool)ViewData["forbidden"])
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <p class=\"float-left\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f2bd9d753853ad3721dad5d5a1e6a5e2484d1dd6593", async() => {
                WriteLiteral("\r\n                <button class=\"btn btn-info\">\r\n                    Crear nuevo\r\n                </button>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </p>\r\n        <p class=\"float-right\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f2bd9d753853ad3721dad5d5a1e6a5e2484d1dd7938", async() => {
                WriteLiteral("\r\n                <button");
                BeginWriteAttribute("class", " class=\"", 600, "\"", 666, 3);
                WriteAttributeValue("", 608, "btn", 608, 3, true);
                WriteAttributeValue(" ", 611, "btn-", 612, 5, true);
#nullable restore
#line 20 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Suscripciones\Index.cshtml"
WriteAttributeValue("", 616, (bool)ViewData["general"] ? "primary":"warning", 616, 50, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    ");
#nullable restore
#line 21 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Suscripciones\Index.cshtml"
                Write((bool)ViewData["general"] ? "Ver mis suscripciones":"Ver todas las suscripciones");

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </button>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 19 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Suscripciones\Index.cshtml"
                WriteLiteral((bool)ViewData["general"] ? "IndexUsuario":"Index");

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-action", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </p>\r\n    </div>\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 30 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Suscripciones\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Tipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 33 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Suscripciones\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 36 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Suscripciones\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.FechaDesde));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 39 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Suscripciones\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.FechaHasta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 42 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Suscripciones\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Renovacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 45 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Suscripciones\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Periodicidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 48 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Suscripciones\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Agente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 51 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Suscripciones\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Cliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 54 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Suscripciones\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Proyecto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 60 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Suscripciones\Index.cshtml"
             if (Model.Count() > 0)
            {

                

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Suscripciones\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 67 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Suscripciones\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Tipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 70 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Suscripciones\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n");
#nullable restore
#line 73 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Suscripciones\Index.cshtml"
                             if (item.FechaDesde != null)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Suscripciones\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.FDesde));

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Suscripciones\Index.cshtml"
                                                                          
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span>Sin especificar</span>\r\n");
#nullable restore
#line 80 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Suscripciones\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                        <td>\r\n");
#nullable restore
#line 83 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Suscripciones\Index.cshtml"
                             if (item.FechaHasta != null)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 85 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Suscripciones\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.FHasta));

#line default
#line hidden
#nullable disable
#nullable restore
#line 85 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Suscripciones\Index.cshtml"
                                                                          
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span>Sin especificar</span>\r\n");
#nullable restore
#line 90 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Suscripciones\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                        <td>\r\n");
#nullable restore
#line 93 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Suscripciones\Index.cshtml"
                             if (item.Renovacion == 1)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span>Activa</span>\r\n");
#nullable restore
#line 96 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Suscripciones\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span>Inactiva</span>\r\n");
#nullable restore
#line 100 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Suscripciones\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 103 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Suscripciones\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Periodicidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 106 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Suscripciones\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Agente.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 109 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Suscripciones\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Cliente.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n");
#nullable restore
#line 112 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Suscripciones\Index.cshtml"
                             if (item.Tipo != "Hardware" && item.ProyectoId != null)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 114 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Suscripciones\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Proyecto.Nombre));

#line default
#line hidden
#nullable disable
#nullable restore
#line 114 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Suscripciones\Index.cshtml"
                                                                                   
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span>Sin proyecto</span>\r\n");
#nullable restore
#line 119 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Suscripciones\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f2bd9d753853ad3721dad5d5a1e6a5e2484d1dd21656", async() => {
                WriteLiteral("\r\n                                <button class=\"btn btn-primary\">\r\n                                    Editar\r\n                                </button>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 122 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Suscripciones\Index.cshtml"
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
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f2bd9d753853ad3721dad5d5a1e6a5e2484d1dd24057", async() => {
                WriteLiteral("\r\n                                <button class=\"btn btn-info\">\r\n                                    Detalles\r\n                                </button>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 127 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Suscripciones\Index.cshtml"
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
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f2bd9d753853ad3721dad5d5a1e6a5e2484d1dd26460", async() => {
                WriteLiteral("\r\n                                <button class=\"btn btn-danger\">\r\n                                    Eliminar\r\n                                </button>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 132 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Suscripciones\Index.cshtml"
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
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 139 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Suscripciones\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 139 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Suscripciones\Index.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 143 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Suscripciones\Index.cshtml"
     if (!(Model.Count() > 0))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h2 style=\"text-align: center;width: 100%\">A&uacute;n no hay registros</h2>\r\n");
#nullable restore
#line 146 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Suscripciones\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 146 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Suscripciones\Index.cshtml"
     
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 148 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Suscripciones\Index.cshtml"
 if ((bool)ViewData["error"])
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4>Est&aacute;s intentando ver los tickets de un usuario que no existe.</h4>\r\n    <hr />\r\n    <h5>Prueba a ver el ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f2bd9d753853ad3721dad5d5a1e6a5e2484d1dd30492", async() => {
                WriteLiteral("Listado completo de tickets");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" e int&eacute;ntalo de nuevo</h5>\r\n    <hr />\r\n    <h5>Tambi&eacute;n puedes probar a ver ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f2bd9d753853ad3721dad5d5a1e6a5e2484d1dd32048", async() => {
                WriteLiteral("Listado de tus tickets");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 154 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Suscripciones\Index.cshtml"
                                                                                                                      WriteLiteral(ViewData["usuario_id"]);

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
            WriteLiteral(" e int&eacute;ntalo de nuevo</h5>\r\n");
#nullable restore
#line 155 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Suscripciones\Index.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 156 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Suscripciones\Index.cshtml"
 if ((bool)ViewData["forbidden"])
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4>Est&aacute;s intentando ver los tickets de otro programador...</h4>\r\n    <hr />\r\n    <h5>Prueba a ver el ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f2bd9d753853ad3721dad5d5a1e6a5e2484d1dd35213", async() => {
                WriteLiteral("Listado completo de tickets");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" e int&eacute;ntalo de nuevo</h5>\r\n");
#nullable restore
#line 161 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Administrador\Suscripciones\Index.cshtml"
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
