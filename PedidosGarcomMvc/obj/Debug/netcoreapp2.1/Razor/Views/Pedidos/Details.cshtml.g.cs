#pragma checksum "C:\Users\batis\OneDrive\Documentos\Visual Studio 2019\Projects\PedidosGarcomMvc\PedidosGarcomMvc\Views\Pedidos\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4fa5c6e5f448c479e2e972a54a1dc8a59dea8e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedidos_Details), @"mvc.1.0.view", @"/Views/Pedidos/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pedidos/Details.cshtml", typeof(AspNetCore.Views_Pedidos_Details))]
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
#line 1 "C:\Users\batis\OneDrive\Documentos\Visual Studio 2019\Projects\PedidosGarcomMvc\PedidosGarcomMvc\Views\_ViewImports.cshtml"
using PedidosGarcomMvc;

#line default
#line hidden
#line 2 "C:\Users\batis\OneDrive\Documentos\Visual Studio 2019\Projects\PedidosGarcomMvc\PedidosGarcomMvc\Views\_ViewImports.cshtml"
using PedidosGarcomMvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4fa5c6e5f448c479e2e972a54a1dc8a59dea8e6", @"/Views/Pedidos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a2babe7af9a605869a9ba44111546a7c77fa9d0", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedidos_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PedidosGarcomMvc.Models.Pedido>
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
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\batis\OneDrive\Documentos\Visual Studio 2019\Projects\PedidosGarcomMvc\PedidosGarcomMvc\Views\Pedidos\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(84, 120, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Pedido</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(205, 40, false);
#line 14 "C:\Users\batis\OneDrive\Documentos\Visual Studio 2019\Projects\PedidosGarcomMvc\PedidosGarcomMvc\Views\Pedidos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Mesa));

#line default
#line hidden
            EndContext();
            BeginContext(245, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(289, 36, false);
#line 17 "C:\Users\batis\OneDrive\Documentos\Visual Studio 2019\Projects\PedidosGarcomMvc\PedidosGarcomMvc\Views\Pedidos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Mesa));

#line default
#line hidden
            EndContext();
            BeginContext(325, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(369, 47, false);
#line 20 "C:\Users\batis\OneDrive\Documentos\Visual Studio 2019\Projects\PedidosGarcomMvc\PedidosGarcomMvc\Views\Pedidos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Solicitante));

#line default
#line hidden
            EndContext();
            BeginContext(416, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(460, 43, false);
#line 23 "C:\Users\batis\OneDrive\Documentos\Visual Studio 2019\Projects\PedidosGarcomMvc\PedidosGarcomMvc\Views\Pedidos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Solicitante));

#line default
#line hidden
            EndContext();
            BeginContext(503, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(547, 41, false);
#line 26 "C:\Users\batis\OneDrive\Documentos\Visual Studio 2019\Projects\PedidosGarcomMvc\PedidosGarcomMvc\Views\Pedidos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Prato));

#line default
#line hidden
            EndContext();
            BeginContext(588, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(632, 37, false);
#line 29 "C:\Users\batis\OneDrive\Documentos\Visual Studio 2019\Projects\PedidosGarcomMvc\PedidosGarcomMvc\Views\Pedidos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Prato));

#line default
#line hidden
            EndContext();
            BeginContext(669, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(713, 52, false);
#line 32 "C:\Users\batis\OneDrive\Documentos\Visual Studio 2019\Projects\PedidosGarcomMvc\PedidosGarcomMvc\Views\Pedidos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Quantidade_Prato));

#line default
#line hidden
            EndContext();
            BeginContext(765, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(809, 48, false);
#line 35 "C:\Users\batis\OneDrive\Documentos\Visual Studio 2019\Projects\PedidosGarcomMvc\PedidosGarcomMvc\Views\Pedidos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Quantidade_Prato));

#line default
#line hidden
            EndContext();
            BeginContext(857, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(901, 42, false);
#line 38 "C:\Users\batis\OneDrive\Documentos\Visual Studio 2019\Projects\PedidosGarcomMvc\PedidosGarcomMvc\Views\Pedidos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Bebida));

#line default
#line hidden
            EndContext();
            BeginContext(943, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(987, 38, false);
#line 41 "C:\Users\batis\OneDrive\Documentos\Visual Studio 2019\Projects\PedidosGarcomMvc\PedidosGarcomMvc\Views\Pedidos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Bebida));

#line default
#line hidden
            EndContext();
            BeginContext(1025, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1069, 53, false);
#line 44 "C:\Users\batis\OneDrive\Documentos\Visual Studio 2019\Projects\PedidosGarcomMvc\PedidosGarcomMvc\Views\Pedidos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Quantidade_Bebida));

#line default
#line hidden
            EndContext();
            BeginContext(1122, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1166, 49, false);
#line 47 "C:\Users\batis\OneDrive\Documentos\Visual Studio 2019\Projects\PedidosGarcomMvc\PedidosGarcomMvc\Views\Pedidos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Quantidade_Bebida));

#line default
#line hidden
            EndContext();
            BeginContext(1215, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1262, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52e70afa43204247b9023418bc19d13b", async() => {
                BeginContext(1308, 4, true);
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
#line 52 "C:\Users\batis\OneDrive\Documentos\Visual Studio 2019\Projects\PedidosGarcomMvc\PedidosGarcomMvc\Views\Pedidos\Details.cshtml"
                           WriteLiteral(Model.Id);

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
            BeginContext(1316, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1324, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9679116cfd6140d992e16cf597d09464", async() => {
                BeginContext(1346, 12, true);
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
            BeginContext(1362, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PedidosGarcomMvc.Models.Pedido> Html { get; private set; }
    }
}
#pragma warning restore 1591
