#pragma checksum "C:\Users\batis\OneDrive\Documentos\Visual Studio 2019\Projects\PedidosGarcomMvc\PedidosGarcomMvc\Views\Pedidos\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c808db53d303d64c9dc2bbc40933f6698549b7c1"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c808db53d303d64c9dc2bbc40933f6698549b7c1", @"/Views/Pedidos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a2babe7af9a605869a9ba44111546a7c77fa9d0", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedidos_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PedidosGarcomMvc.Models.Pedido>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
  
    ViewData["Title"] = "Detalhes";

#line default
#line hidden
            BeginContext(85, 112, true);
            WriteLiteral("\r\n<h2>Detalhes do pedido</h2>\r\n\r\n<div>\r\n\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(198, 40, false);
#line 14 "C:\Users\batis\OneDrive\Documentos\Visual Studio 2019\Projects\PedidosGarcomMvc\PedidosGarcomMvc\Views\Pedidos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Mesa));

#line default
#line hidden
            EndContext();
            BeginContext(238, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(282, 36, false);
#line 17 "C:\Users\batis\OneDrive\Documentos\Visual Studio 2019\Projects\PedidosGarcomMvc\PedidosGarcomMvc\Views\Pedidos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Mesa));

#line default
#line hidden
            EndContext();
            BeginContext(318, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(362, 47, false);
#line 20 "C:\Users\batis\OneDrive\Documentos\Visual Studio 2019\Projects\PedidosGarcomMvc\PedidosGarcomMvc\Views\Pedidos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Solicitante));

#line default
#line hidden
            EndContext();
            BeginContext(409, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(453, 43, false);
#line 23 "C:\Users\batis\OneDrive\Documentos\Visual Studio 2019\Projects\PedidosGarcomMvc\PedidosGarcomMvc\Views\Pedidos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Solicitante));

#line default
#line hidden
            EndContext();
            BeginContext(496, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(540, 41, false);
#line 26 "C:\Users\batis\OneDrive\Documentos\Visual Studio 2019\Projects\PedidosGarcomMvc\PedidosGarcomMvc\Views\Pedidos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Prato));

#line default
#line hidden
            EndContext();
            BeginContext(581, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(625, 37, false);
#line 29 "C:\Users\batis\OneDrive\Documentos\Visual Studio 2019\Projects\PedidosGarcomMvc\PedidosGarcomMvc\Views\Pedidos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Prato));

#line default
#line hidden
            EndContext();
            BeginContext(662, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(706, 52, false);
#line 32 "C:\Users\batis\OneDrive\Documentos\Visual Studio 2019\Projects\PedidosGarcomMvc\PedidosGarcomMvc\Views\Pedidos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Quantidade_Prato));

#line default
#line hidden
            EndContext();
            BeginContext(758, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(802, 48, false);
#line 35 "C:\Users\batis\OneDrive\Documentos\Visual Studio 2019\Projects\PedidosGarcomMvc\PedidosGarcomMvc\Views\Pedidos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Quantidade_Prato));

#line default
#line hidden
            EndContext();
            BeginContext(850, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(894, 42, false);
#line 38 "C:\Users\batis\OneDrive\Documentos\Visual Studio 2019\Projects\PedidosGarcomMvc\PedidosGarcomMvc\Views\Pedidos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Bebida));

#line default
#line hidden
            EndContext();
            BeginContext(936, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(980, 38, false);
#line 41 "C:\Users\batis\OneDrive\Documentos\Visual Studio 2019\Projects\PedidosGarcomMvc\PedidosGarcomMvc\Views\Pedidos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Bebida));

#line default
#line hidden
            EndContext();
            BeginContext(1018, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1062, 53, false);
#line 44 "C:\Users\batis\OneDrive\Documentos\Visual Studio 2019\Projects\PedidosGarcomMvc\PedidosGarcomMvc\Views\Pedidos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Quantidade_Bebida));

#line default
#line hidden
            EndContext();
            BeginContext(1115, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1159, 49, false);
#line 47 "C:\Users\batis\OneDrive\Documentos\Visual Studio 2019\Projects\PedidosGarcomMvc\PedidosGarcomMvc\Views\Pedidos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Quantidade_Bebida));

#line default
#line hidden
            EndContext();
            BeginContext(1208, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1255, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35424049d2fd44e1a92dc72c7f373674", async() => {
                BeginContext(1301, 8, true);
                WriteLiteral("Retornar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1313, 10, true);
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
