#pragma checksum "C:\Users\Wilmer\source\repos\AppTransferencia\Views\Transaccion\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04f115bc5c4173dfe01335c9db830e2af8f6f529"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Transaccion_Index), @"mvc.1.0.view", @"/Views/Transaccion/Index.cshtml")]
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
#line 1 "C:\Users\Wilmer\source\repos\AppTransferencia\Views\_ViewImports.cshtml"
using AppTransferencia;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Wilmer\source\repos\AppTransferencia\Views\_ViewImports.cshtml"
using AppTransferencia.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04f115bc5c4173dfe01335c9db830e2af8f6f529", @"/Views/Transaccion/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89f8413cbd819b5bf8296b0436f55a81132e5e74", @"/Views/_ViewImports.cshtml")]
    public class Views_Transaccion_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AppTransferencia.Models.Transaccion>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CrearTransaccion", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Wilmer\source\repos\AppTransferencia\Views\Transaccion\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04f115bc5c4173dfe01335c9db830e2af8f6f5293699", async() => {
                WriteLiteral("Create Nueva Transacción");
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
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\Wilmer\source\repos\AppTransferencia\Views\Transaccion\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ValorGmf));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\Wilmer\source\repos\AppTransferencia\Views\Transaccion\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ValorRetiro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\Wilmer\source\repos\AppTransferencia\Views\Transaccion\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FechaTransacción));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\Wilmer\source\repos\AppTransferencia\Views\Transaccion\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IdClienteNavigation.Nombres));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\Wilmer\source\repos\AppTransferencia\Views\Transaccion\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IdCuentaDestinoNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\Wilmer\source\repos\AppTransferencia\Views\Transaccion\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IdCuentaOrigenNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Users\Wilmer\source\repos\AppTransferencia\Views\Transaccion\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IdTipoTransaccionNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 40 "C:\Users\Wilmer\source\repos\AppTransferencia\Views\Transaccion\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\Wilmer\source\repos\AppTransferencia\Views\Transaccion\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ValorGmf));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\Wilmer\source\repos\AppTransferencia\Views\Transaccion\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ValorRetiro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\Wilmer\source\repos\AppTransferencia\Views\Transaccion\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FechaTransacción));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Users\Wilmer\source\repos\AppTransferencia\Views\Transaccion\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdClienteNavigation.Apellidos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "C:\Users\Wilmer\source\repos\AppTransferencia\Views\Transaccion\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdCuentaDestinoNavigation.NumCuenta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 58 "C:\Users\Wilmer\source\repos\AppTransferencia\Views\Transaccion\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdCuentaOrigenNavigation.NumCuenta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 61 "C:\Users\Wilmer\source\repos\AppTransferencia\Views\Transaccion\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdTipoTransaccionNavigation.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n         \r\n        </tr>\r\n");
#nullable restore
#line 65 "C:\Users\Wilmer\source\repos\AppTransferencia\Views\Transaccion\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AppTransferencia.Models.Transaccion>> Html { get; private set; }
    }
}
#pragma warning restore 1591