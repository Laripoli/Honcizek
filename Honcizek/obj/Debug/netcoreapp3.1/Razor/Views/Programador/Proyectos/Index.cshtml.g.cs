#pragma checksum "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Proyectos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "700fa951ec410b354999c12c51ab7f1da06c43df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Programador_Proyectos_Index), @"mvc.1.0.view", @"/Views/Programador/Proyectos/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"700fa951ec410b354999c12c51ab7f1da06c43df", @"/Views/Programador/Proyectos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb10e3e8ba77754d859a694970f134bb15e1fc57", @"/Views/_ViewImports.cshtml")]
    public class Views_Programador_Proyectos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Honcizek.DAL.Models.Proyectos>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("filtrador"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("float-left pl-3 row"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "TrabajosP", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "IndexUsuario", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("honci-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Proyectos\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Listado de mis proyectos</h1>\r\n");
#nullable restore
#line 8 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Proyectos\Index.cshtml"
 if (!(bool)ViewData["error"])
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "700fa951ec410b354999c12c51ab7f1da06c43df6870", async() => {
                WriteLiteral("\r\n        <div class=\"form-actions no-color px-3\">\r\n            <label for=\"nombre\">\r\n                Buscar nombre: <input id=\"filtro\" type=\"text\" name=\"nombre\"");
                BeginWriteAttribute("value", " value=\"", 412, "\"", 445, 1);
#nullable restore
#line 13 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Proyectos\Index.cshtml"
WriteAttributeValue("", 420, ViewData["nombreFilter"], 420, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            </label>\r\n            <label for=\"cliente\">\r\n                Buscar cliente: <input id=\"filtro\" type=\"text\" name=\"cliente\"");
                BeginWriteAttribute("value", " value=\"", 585, "\"", 619, 1);
#nullable restore
#line 16 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Proyectos\Index.cshtml"
WriteAttributeValue("", 593, ViewData["clienteFilter"], 593, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            </label>\r\n        </div>\r\n        <div class=\"row pl-5 pt-3\">\r\n            <a class=\"pr-2\">\r\n                <button class=\"btn btn-primary\">Buscar</button>\r\n            </a>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "700fa951ec410b354999c12c51ab7f1da06c43df8486", async() => {
                    WriteLiteral("\r\n                <button class=\"btn btn-dark\" id=\"limpia-filtros\">\r\n                    Limpiar filtro\r\n                </button>\r\n            ");
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
                WriteLiteral("\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 34 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Proyectos\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 37 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Proyectos\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.FechaInicio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 40 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Proyectos\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.FechaFinPrevista));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 43 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Proyectos\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.FechaFinReal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 46 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Proyectos\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.HorasInternasPrevistas));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 49 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Proyectos\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 52 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Proyectos\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Fase));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 55 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Proyectos\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Cliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th class=\"w-auto\"></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 61 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Proyectos\Index.cshtml"
             if (Model.Count() > 0)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Proyectos\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 67 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Proyectos\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n");
#nullable restore
#line 70 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Proyectos\Index.cshtml"
                             if (item.FechaFinPrevista != null)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Proyectos\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Finicio));

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Proyectos\Index.cshtml"
                                                                           
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span>Sin especificar</span>\r\n");
#nullable restore
#line 77 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Proyectos\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                        <td>\r\n");
#nullable restore
#line 80 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Proyectos\Index.cshtml"
                             if (item.FechaFinPrevista != null)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Proyectos\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.FFinPrevista));

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Proyectos\Index.cshtml"
                                                                                
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span>Sin especificar</span>\r\n");
#nullable restore
#line 87 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Proyectos\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                        <td>\r\n");
#nullable restore
#line 90 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Proyectos\Index.cshtml"
                             if (item.FechaFinReal != null)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Proyectos\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.FFin));

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Proyectos\Index.cshtml"
                                                                        
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span>Sin finalizar</span>\r\n");
#nullable restore
#line 97 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Proyectos\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 100 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Proyectos\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.HorasInternasPrevistas));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 103 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Proyectos\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 106 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Proyectos\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Fase));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n");
#nullable restore
#line 109 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Proyectos\Index.cshtml"
                             if (item.Cliente == null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span>El cliente ha sido eliminado</span>\r\n");
#nullable restore
#line 112 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Proyectos\Index.cshtml"
                            }
                            else
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 115 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Proyectos\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Cliente.FullName));

#line default
#line hidden
#nullable disable
#nullable restore
#line 115 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Proyectos\Index.cshtml"
                                                                                    
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                        <td class=\"w-auto\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "700fa951ec410b354999c12c51ab7f1da06c43df21872", async() => {
                WriteLiteral("\r\n                                <button class=\"btn btn-primary\">\r\n                                    Ver\r\n                                </button>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 119 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Proyectos\Index.cshtml"
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "700fa951ec410b354999c12c51ab7f1da06c43df24264", async() => {
                WriteLiteral("\r\n                                <button class=\"btn btn-warning\">\r\n                                    Trabajos\r\n                                </button>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 124 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Proyectos\Index.cshtml"
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
#line 131 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Proyectos\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 131 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Proyectos\Index.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 135 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Proyectos\Index.cshtml"
     if (!(Model.Count() > 0))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h2 style=\"text-align: center;width: 100%\">No participas en ning&uacute;n proyecto</h2>\r\n");
#nullable restore
#line 138 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Proyectos\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 138 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Proyectos\Index.cshtml"
     
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 140 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Proyectos\Index.cshtml"
 if ((bool)ViewData["error"])
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4>Parece que ha habido un error al cargar tus proyectos...</h4>\r\n    <hr />\r\n    <h5>Prueba a volver al ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "700fa951ec410b354999c12c51ab7f1da06c43df28497", async() => {
                WriteLiteral("Login");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" e int&eacute;ntalo de nuevo</h5>\r\n");
#nullable restore
#line 145 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Proyectos\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Honcizek.DAL.Models.Proyectos>> Html { get; private set; }
    }
}
#pragma warning restore 1591
