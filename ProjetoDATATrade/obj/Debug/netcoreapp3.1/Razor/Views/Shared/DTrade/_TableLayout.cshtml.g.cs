#pragma checksum "A:\Documentos\TCC\Project\ProjetoDATATrade\Views\Shared\DTrade\_TableLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0348c83e8ba2b3f98ea0ff772f9571624e65d591"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_DTrade__TableLayout), @"mvc.1.0.view", @"/Views/Shared/DTrade/_TableLayout.cshtml")]
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
#line 1 "A:\Documentos\TCC\Project\ProjetoDATATrade\Views\_ViewImports.cshtml"
using ProjetoDATATrade;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "A:\Documentos\TCC\Project\ProjetoDATATrade\Views\_ViewImports.cshtml"
using ProjetoDATATrade.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0348c83e8ba2b3f98ea0ff772f9571624e65d591", @"/Views/Shared/DTrade/_TableLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4523aea35e889be5846da66ed4067f2a00eb0c5b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_DTrade__TableLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/img/graphic_extend.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!-- Inicio do card 1 -->\n<div class=\"card\">\n  <div class=\"card-header\">\n    <p>01 DE JANEIRO</p>\n    <button type=\"button\" class=\"button remove-btn\">Excluir</button>\n  </div>\n  \n  \n  <div class=\"card-body\">\n    <div class=\"day-graphic-img\">\n      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0348c83e8ba2b3f98ea0ff772f9571624e65d5913781", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
    <div class=""main-table"">
      <table class=""iTable"">
        <tr>
          <th class=""iTable-title"">Ativo</th>
          <th class=""iTable-data"">EURU$D</th>
        </tr>
        
        <tr>
          <th class=""iTable-title"">Estratégia</th>
          <th class=""iTable-data"">CTFIBO</th>
        </tr>
        
        <tr>
          <th class=""iTable-title"">Data/Hora</th>
          <th class=""iTable-data"">23/04  15:00h</th>
        </tr>
        
        <tr>
          <th class=""iTable-title"">Carteira</th>
          <th class=""iTable-data"">R$ 350,00</th>
        </tr>
        
        <tr>
          <th class=""iTable-title"">Risco</th>
          <th class=""iTable-data"">14,2%</th>
        </tr>
        
        <tr>
          <th class=""iTable-title"">Preço de entrada</th>
          <th class=""iTable-data"">R$ 5,34</th>
        </tr>
      </table>
      
      <table class=""iTable"">
        <tr>
          <th class=""iTable-title"">Take Profit:</th>
          <th class=""iTable-data"">R$ +20</th>");
            WriteLiteral(@"
        </tr>
        
        <tr>
          <th class=""iTable-title"">Stop Loss:</th>
          <th class=""iTable-data"">R$ -10</th>
        </tr>
        
        <tr>
          <th class=""iTable-title"">Resultado:</th>
          <th class=""iTable-data"">R$ 10,00</th>
        </tr>
        
        <tr>
          <th class=""iTable-title"">Ordem:</th>
          <th class=""iTable-data"">Venda</th>
        </tr>
        
        <tr>
          <th class=""iTable-title"">Lote:</th>
          <th class=""iTable-data"">0,3</th>
        </tr>
        
        <tr>
          <th class=""iTable-title"">Num. Oper:</th>
          <th class=""iTable-data"">1</th>
        </tr>
        
      </table>
    </div>
  </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591