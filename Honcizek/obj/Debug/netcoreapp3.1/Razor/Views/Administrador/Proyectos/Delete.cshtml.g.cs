#pragma checksum "C:\Users\alvar\Desktop\Proyectos\Honcizek\Honcizek\Views\Administrador\Proyectos\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73876a8bc7e7984097821347af31aac2bf230eaf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrador_Proyectos_Delete), @"mvc.1.0.view", @"/Views/Administrador/Proyectos/Delete.cshtml")]
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
#line 1 "C:\Users\alvar\Desktop\Proyectos\Honcizek\Honcizek\Views\_ViewImports.cshtml"
using Honcizek;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\alvar\Desktop\Proyectos\Honcizek\Honcizek\Views\_ViewImports.cshtml"
using Honcizek.DAL.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73876a8bc7e7984097821347af31aac2bf230eaf", @"/Views/Administrador/Proyectos/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb10e3e8ba77754d859a694970f134bb15e1fc57", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrador_Proyectos_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Honcizek.DAL.Models.Proyectos>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("pb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\alvar\Desktop\Proyectos\Honcizek\Honcizek\Views\Administrador\Proyectos\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Proyectos</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 16 "C:\Users\alvar\Desktop\Proyectos\Honcizek\Honcizek\Views\Administrador\Proyectos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 19 "C:\Users\alvar\Desktop\Proyectos\Honcizek\Honcizek\Views\Administrador\Proyectos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 22 "C:\Users\alvar\Desktop\Proyectos\Honcizek\Honcizek\Views\Administrador\Proyectos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 25 "C:\Users\alvar\Desktop\Proyectos\Honcizek\Honcizek\Views\Administrador\Proyectos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 28 "C:\Users\alvar\Desktop\Proyectos\Honcizek\Honcizek\Views\Administrador\Proyectos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DescripcionDesarrollo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 31 "C:\Users\alvar\Desktop\Proyectos\Honcizek\Honcizek\Views\Administrador\Proyectos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DescripcionDesarrollo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 34 "C:\Users\alvar\Desktop\Proyectos\Honcizek\Honcizek\Views\Administrador\Proyectos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FechaRegistro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 37 "C:\Users\alvar\Desktop\Proyectos\Honcizek\Honcizek\Views\Administrador\Proyectos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FRegistro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 40 "C:\Users\alvar\Desktop\Proyectos\Honcizek\Honcizek\Views\Administrador\Proyectos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FechaInicio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-4\">\r\n");
#nullable restore
#line 43 "C:\Users\alvar\Desktop\Proyectos\Honcizek\Honcizek\Views\Administrador\Proyectos\Delete.cshtml"
             if (@Model.FechaFinPrevista != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\alvar\Desktop\Proyectos\Honcizek\Honcizek\Views\Administrador\Proyectos\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Finicio));

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\alvar\Desktop\Proyectos\Honcizek\Honcizek\Views\Administrador\Proyectos\Delete.cshtml"
                                                        
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span>Sin especificar</span>\r\n");
#nullable restore
#line 50 "C:\Users\alvar\Desktop\Proyectos\Honcizek\Honcizek\Views\Administrador\Proyectos\Delete.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 53 "C:\Users\alvar\Desktop\Proyectos\Honcizek\Honcizek\Views\Administrador\Proyectos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FechaFinPrevista));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-4\">\r\n");
#nullable restore
#line 56 "C:\Users\alvar\Desktop\Proyectos\Honcizek\Honcizek\Views\Administrador\Proyectos\Delete.cshtml"
             if (@Model.FechaFinPrevista != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\alvar\Desktop\Proyectos\Honcizek\Honcizek\Views\Administrador\Proyectos\Delete.cshtml"
           Write(Html.DisplayFor(model => model.FFinPrevista));

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\alvar\Desktop\Proyectos\Honcizek\Honcizek\Views\Administrador\Proyectos\Delete.cshtml"
                                                             
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span>Sin finalizar</span>\r\n");
#nullable restore
#line 63 "C:\Users\alvar\Desktop\Proyectos\Honcizek\Honcizek\Views\Administrador\Proyectos\Delete.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 66 "C:\Users\alvar\Desktop\Proyectos\Honcizek\Honcizek\Views\Administrador\Proyectos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FechaFinReal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-4\">\r\n");
#nullable restore
#line 69 "C:\Users\alvar\Desktop\Proyectos\Honcizek\Honcizek\Views\Administrador\Proyectos\Delete.cshtml"
             if (@Model.FechaFinReal != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "C:\Users\alvar\Desktop\Proyectos\Honcizek\Honcizek\Views\Administrador\Proyectos\Delete.cshtml"
           Write(Html.DisplayFor(model => model.FFin));

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "C:\Users\alvar\Desktop\Proyectos\Honcizek\Honcizek\Views\Administrador\Proyectos\Delete.cshtml"
                                                     
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span>Sin especificar</span>\r\n");
#nullable restore
#line 76 "C:\Users\alvar\Desktop\Proyectos\Honcizek\Honcizek\Views\Administrador\Proyectos\Delete.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 79 "C:\Users\alvar\Desktop\Proyectos\Honcizek\Honcizek\Views\Administrador\Proyectos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.HorasInternasPrevistas));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 82 "C:\Users\alvar\Desktop\Proyectos\Honcizek\Honcizek\Views\Administrador\Proyectos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.HorasInternasPrevistas));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 85 "C:\Users\alvar\Desktop\Proyectos\Honcizek\Honcizek\Views\Administrador\Proyectos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 88 "C:\Users\alvar\Desktop\Proyectos\Honcizek\Honcizek\Views\Administrador\Proyectos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 91 "C:\Users\alvar\Desktop\Proyectos\Honcizek\Honcizek\Views\Administrador\Proyectos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Fase));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 94 "C:\Users\alvar\Desktop\Proyectos\Honcizek\Honcizek\Views\Administrador\Proyectos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Fase));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 97 "C:\Users\alvar\Desktop\Proyectos\Honcizek\Honcizek\Views\Administrador\Proyectos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Cliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-4\">\r\n");
#nullable restore
#line 100 "C:\Users\alvar\Desktop\Proyectos\Honcizek\Honcizek\Views\Administrador\Proyectos\Delete.cshtml"
             if (Model.Cliente == null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span>El cliente ha sido eliminado</span>\r\n");
#nullable restore
#line 103 "C:\Users\alvar\Desktop\Proyectos\Honcizek\Honcizek\Views\Administrador\Proyectos\Delete.cshtml"
            }
            else
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 106 "C:\Users\alvar\Desktop\Proyectos\Honcizek\Honcizek\Views\Administrador\Proyectos\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Cliente.FullName));

#line default
#line hidden
#nullable disable
#nullable restore
#line 106 "C:\Users\alvar\Desktop\Proyectos\Honcizek\Honcizek\Views\Administrador\Proyectos\Delete.cshtml"
                                                                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </dd>\r\n    </dl>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73876a8bc7e7984097821347af31aac2bf230eaf15879", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "73876a8bc7e7984097821347af31aac2bf230eaf16146", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 112 "C:\Users\alvar\Desktop\Proyectos\Honcizek\Honcizek\Views\Administrador\Proyectos\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Borrar\" class=\"btn btn-danger\" />\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73876a8bc7e7984097821347af31aac2bf230eaf19203", async() => {
                WriteLiteral("\r\n        <button class=\"btn btn-primary\">Volver al listado</button>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Honcizek.DAL.Models.Proyectos> Html { get; private set; }
    }
}
#pragma warning restore 1591
