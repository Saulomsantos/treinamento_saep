#pragma checksum "C:\Users\39893838843\Downloads\treinamento_saep\treinamento-razor-lanhouse-resolvido\codigo\Senai.LanHouse.Web.Razor\Senai.LanHouse.Web.Razor\Views\Defeitos\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3cd52b902effe9fa29ff99e1faef57fd4bb44746"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Defeitos_Details), @"mvc.1.0.view", @"/Views/Defeitos/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Defeitos/Details.cshtml", typeof(AspNetCore.Views_Defeitos_Details))]
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
#line 1 "C:\Users\39893838843\Downloads\treinamento_saep\treinamento-razor-lanhouse-resolvido\codigo\Senai.LanHouse.Web.Razor\Senai.LanHouse.Web.Razor\Views\_ViewImports.cshtml"
using Senai.LanHouse.Web.Razor;

#line default
#line hidden
#line 2 "C:\Users\39893838843\Downloads\treinamento_saep\treinamento-razor-lanhouse-resolvido\codigo\Senai.LanHouse.Web.Razor\Senai.LanHouse.Web.Razor\Views\_ViewImports.cshtml"
using Senai.LanHouse.Web.Razor.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cd52b902effe9fa29ff99e1faef57fd4bb44746", @"/Views/Defeitos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47b4454cc0c78a6dda1cb48c0bbee78e97740168", @"/Views/_ViewImports.cshtml")]
    public class Views_Defeitos_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Senai.LanHouse.Web.Razor.Dominios.Defeito>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\39893838843\Downloads\treinamento_saep\treinamento-razor-lanhouse-resolvido\codigo\Senai.LanHouse.Web.Razor\Senai.LanHouse.Web.Razor\Views\Defeitos\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(142, 121, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Defeito</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(264, 47, false);
#line 15 "C:\Users\39893838843\Downloads\treinamento_saep\treinamento-razor-lanhouse-resolvido\codigo\Senai.LanHouse.Web.Razor\Senai.LanHouse.Web.Razor\Views\Defeitos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DataDefeito));

#line default
#line hidden
            EndContext();
            BeginContext(311, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(355, 43, false);
#line 18 "C:\Users\39893838843\Downloads\treinamento_saep\treinamento-razor-lanhouse-resolvido\codigo\Senai.LanHouse.Web.Razor\Senai.LanHouse.Web.Razor\Views\Defeitos\Details.cshtml"
       Write(Html.DisplayFor(model => model.DataDefeito));

#line default
#line hidden
            EndContext();
            BeginContext(398, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(442, 46, false);
#line 21 "C:\Users\39893838843\Downloads\treinamento_saep\treinamento-razor-lanhouse-resolvido\codigo\Senai.LanHouse.Web.Razor\Senai.LanHouse.Web.Razor\Views\Defeitos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Observacao));

#line default
#line hidden
            EndContext();
            BeginContext(488, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(532, 42, false);
#line 24 "C:\Users\39893838843\Downloads\treinamento_saep\treinamento-razor-lanhouse-resolvido\codigo\Senai.LanHouse.Web.Razor\Senai.LanHouse.Web.Razor\Views\Defeitos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Observacao));

#line default
#line hidden
            EndContext();
            BeginContext(574, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(618, 47, false);
#line 27 "C:\Users\39893838843\Downloads\treinamento_saep\treinamento-razor-lanhouse-resolvido\codigo\Senai.LanHouse.Web.Razor\Senai.LanHouse.Web.Razor\Views\Defeitos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Equipamento));

#line default
#line hidden
            EndContext();
            BeginContext(665, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(709, 57, false);
#line 30 "C:\Users\39893838843\Downloads\treinamento_saep\treinamento-razor-lanhouse-resolvido\codigo\Senai.LanHouse.Web.Razor\Senai.LanHouse.Web.Razor\Views\Defeitos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Equipamento.EquipamentoId));

#line default
#line hidden
            EndContext();
            BeginContext(766, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(810, 47, false);
#line 33 "C:\Users\39893838843\Downloads\treinamento_saep\treinamento-razor-lanhouse-resolvido\codigo\Senai.LanHouse.Web.Razor\Senai.LanHouse.Web.Razor\Views\Defeitos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TipoDefeito));

#line default
#line hidden
            EndContext();
            BeginContext(857, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(901, 50, false);
#line 36 "C:\Users\39893838843\Downloads\treinamento_saep\treinamento-razor-lanhouse-resolvido\codigo\Senai.LanHouse.Web.Razor\Senai.LanHouse.Web.Razor\Views\Defeitos\Details.cshtml"
       Write(Html.DisplayFor(model => model.TipoDefeito.Titulo));

#line default
#line hidden
            EndContext();
            BeginContext(951, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(998, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25dfc7e5ed174ac798f38efd24684060", async() => {
                BeginContext(1051, 4, true);
                WriteLiteral("Edit");
                EndContext();
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
#line 41 "C:\Users\39893838843\Downloads\treinamento_saep\treinamento-razor-lanhouse-resolvido\codigo\Senai.LanHouse.Web.Razor\Senai.LanHouse.Web.Razor\Views\Defeitos\Details.cshtml"
                           WriteLiteral(Model.DefeitoId);

#line default
#line hidden
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
            EndContext();
            BeginContext(1059, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1067, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce4cf4cb12dc4eecaff5bffbcce824cd", async() => {
                BeginContext(1089, 12, true);
                WriteLiteral("Back to List");
                EndContext();
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
            EndContext();
            BeginContext(1105, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Senai.LanHouse.Web.Razor.Dominios.Defeito> Html { get; private set; }
    }
}
#pragma warning restore 1591
