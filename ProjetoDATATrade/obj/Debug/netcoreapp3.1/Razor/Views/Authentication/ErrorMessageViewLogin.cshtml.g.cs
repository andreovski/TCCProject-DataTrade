#pragma checksum "C:\Users\leona\Documents\TCCProject-DataTrade-master\ProjetoDATATrade\Views\Authentication\ErrorMessageViewLogin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf4aed0c28846f46b98792b6884b64c331b574af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Authentication_ErrorMessageViewLogin), @"mvc.1.0.view", @"/Views/Authentication/ErrorMessageViewLogin.cshtml")]
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
#line 1 "C:\Users\leona\Documents\TCCProject-DataTrade-master\ProjetoDATATrade\Views\_ViewImports.cshtml"
using ProjetoDATATrade;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\leona\Documents\TCCProject-DataTrade-master\ProjetoDATATrade\Views\_ViewImports.cshtml"
using ProjetoDATATrade.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf4aed0c28846f46b98792b6884b64c331b574af", @"/Views/Authentication/ErrorMessageViewLogin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4523aea35e889be5846da66ed4067f2a00eb0c5b", @"/Views/_ViewImports.cshtml")]
    public class Views_Authentication_ErrorMessageViewLogin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<script src=""https://ajax.googleapis.com/ajax/libs/jquery/1.12.3/jquery.min.js""></script>

<script type=""text/javascript"">
    $(function () {
        $('.modal').modal('show');
    });
</script>
<style>
    * {
        color: #1b1b1b;
    }

    .modal {
        background: #1b1b1b; 
        position: absolute;
    }

    .modal-content {
        background: #c61919;
        padding: 10px;
        font-size: 18px;
        width: fit-content;
        border-radius: 7px;
        position: relative;
        top: 10px;
        left: 10px;
        border: solid #8b0000 2.5px;
    }

    .modal-header {
        margin-bottom: 8px;
    }
</style>
<div class=""modal fade"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"">Erro ao fazer login</h4>
            </div>
            <div class=""modal-body"">
                ");
#nullable restore
#line 41 "C:\Users\leona\Documents\TCCProject-DataTrade-master\ProjetoDATATrade\Views\Authentication\ErrorMessageViewLogin.cshtml"
           Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
