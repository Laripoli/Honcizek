#pragma checksum "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Tickets\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1db60fda014f22cd79fc81d871f009c792c725f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Programador_Tickets_Index), @"mvc.1.0.view", @"/Views/Programador/Tickets/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1db60fda014f22cd79fc81d871f009c792c725f6", @"/Views/Programador/Tickets/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb10e3e8ba77754d859a694970f134bb15e1fc57", @"/Views/_ViewImports.cshtml")]
    public class Views_Programador_Tickets_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Honcizek.DAL.Models.Tickets>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("filtrador"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("float-left pl-3 row"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "PartesP", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("pl-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("honci-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Tickets", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Administrador/Tickets/Listado.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Tickets\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Listado de ");
#nullable restore
#line 7 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Tickets\Index.cshtml"
           Write(!(bool)ViewData["general"]?"mis":"");

#line default
#line hidden
#nullable disable
            WriteLiteral(" tickets</h1>\r\n");
#nullable restore
#line 8 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Tickets\Index.cshtml"
 if(!(bool)ViewData["error"])
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <p class=\"float-right\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1db60fda014f22cd79fc81d871f009c792c725f68996", async() => {
                WriteLiteral("\r\n                <button");
                BeginWriteAttribute("class", " class=\"", 347, "\"", 413, 3);
                WriteAttributeValue("", 355, "btn", 355, 3, true);
                WriteAttributeValue(" ", 358, "btn-", 359, 5, true);
#nullable restore
#line 13 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Tickets\Index.cshtml"
WriteAttributeValue("", 363, (bool)ViewData["general"] ? "primary":"warning", 363, 50, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    ");
#nullable restore
#line 14 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Tickets\Index.cshtml"
                Write((bool)ViewData["general"] ? "Ver mis tickets pendientes":"Ver todos mis tickets");

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
#line 12 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Tickets\Index.cshtml"
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
            WriteLiteral("\r\n        </p>\r\n    </div>\r\n        <div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1db60fda014f22cd79fc81d871f009c792c725f611686", async() => {
                WriteLiteral("\r\n                <div class=\"form-actions no-color px-3\">\r\n                    <label for=\"nombre\">\r\n                        Buscar nombre: <input id=\"filtro\" type=\"text\" name=\"nombre\"");
                BeginWriteAttribute("value", " value=\"", 886, "\"", 919, 1);
#nullable restore
#line 23 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Tickets\Index.cshtml"
WriteAttributeValue("", 894, ViewData["nombreFilter"], 894, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    </label>\r\n                    <label for=\"cliente\">\r\n                        Buscar cliente: <input id=\"filtro\" type=\"text\" name=\"cliente\"");
                BeginWriteAttribute("value", " value=\"", 1083, "\"", 1117, 1);
#nullable restore
#line 26 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Tickets\Index.cshtml"
WriteAttributeValue("", 1091, ViewData["clienteFilter"], 1091, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                    </label>
                </div>
                <div class=""row pl-5 pt-3"">
                    <a class=""pr-2"">
                        <button class=""btn btn-primary"">Buscar</button>
                    </a>
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1db60fda014f22cd79fc81d871f009c792c725f613394", async() => {
                    WriteLiteral("\r\n                        <button class=\"btn btn-dark\" id=\"limpia-filtros\">\r\n                            Limpiar filtro\r\n                        </button>\r\n                    ");
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
                WriteLiteral("\r\n                </div>\r\n            ");
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
            WriteLiteral("\r\n        </div>\r\n");
            WriteLiteral("        <table class=\"table\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        ");
#nullable restore
#line 46 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Tickets\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 49 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Tickets\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 52 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Tickets\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.FechaRegistro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 55 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Tickets\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.HoraRegistro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 58 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Tickets\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.FechaFinalizacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 61 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Tickets\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Cliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 64 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Tickets\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Suscripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 70 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Tickets\Index.cshtml"
                 if (Model.Count() > 0)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Tickets\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 76 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Tickets\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 79 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Tickets\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n");
#nullable restore
#line 82 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Tickets\Index.cshtml"
                                 if (item.FechaRegistro != null)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Tickets\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.FRegistro));

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Tickets\Index.cshtml"
                                                                                 
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span>Sin especificar</span>\r\n");
#nullable restore
#line 89 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Tickets\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 92 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Tickets\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.HoraRegistro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n");
#nullable restore
#line 95 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Tickets\Index.cshtml"
                                 if (item.FechaFinalizacion != null)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 97 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Tickets\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.FFin));

#line default
#line hidden
#nullable disable
#nullable restore
#line 97 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Tickets\Index.cshtml"
                                                                            
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span>Sin finalizar</span>\r\n");
#nullable restore
#line 102 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Tickets\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 105 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Tickets\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Cliente.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 108 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Tickets\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Suscripcion.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1db60fda014f22cd79fc81d871f009c792c725f624525", async() => {
                WriteLiteral("\r\n                                    <button class=\"btn btn-warning\">\r\n                                        Partes de trabajo\r\n                                    </button>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 111 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Tickets\Index.cshtml"
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
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1db60fda014f22cd79fc81d871f009c792c725f627185", async() => {
                WriteLiteral("\r\n                                    <button class=\"btn btn-primary\">\r\n                                        Ver\r\n                                    </button>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 116 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Tickets\Index.cshtml"
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
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 123 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Tickets\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 123 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Tickets\Index.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 128 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Tickets\Index.cshtml"
         if (!(Model.Count() > 0))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h2 style=\"text-align: center;width: 100%\">A&uacute;n no hay registros</h2>\r\n");
#nullable restore
#line 131 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Tickets\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 131 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Tickets\Index.cshtml"
         
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 134 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Tickets\Index.cshtml"
         if ((bool)ViewData["error"])
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row col-12\">\r\n                <h4");
            BeginWriteAttribute("class", " class=\"", 5595, "\"", 5603, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    Parece que ha habido un error con tu usuario, puedes intentar cerrar sesi&oacute;n y volver a entrar.\r\n                </h4>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1db60fda014f22cd79fc81d871f009c792c725f631533", async() => {
                WriteLiteral("\r\n                    <button class=\"btn btn-danger\">Cerrar sesi&oacute;n</button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <hr />\r\n            <h5>O puedes ver el ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1db60fda014f22cd79fc81d871f009c792c725f633630", async() => {
                WriteLiteral("Listado completo de tickets");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(".</h5>\r\n");
#nullable restore
#line 146 "C:\Users\alvar\Desktop\tuto\Proyectos\Honcizek\Honcizek\Views\Programador\Tickets\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1db60fda014f22cd79fc81d871f009c792c725f635399", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <script>\r\n                $(document).ready(function () {\r\n                    Listado.init();\r\n                });\r\n            </script>\r\n        ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Honcizek.DAL.Models.Tickets>> Html { get; private set; }
    }
}
#pragma warning restore 1591
