#pragma checksum "C:\Users\ms327\Desktop\estacionamento\Estacionamento\TesteEstacionamento\Views\Cliente\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a8753cc3a573d225644630645962c3e670ee240"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Index), @"mvc.1.0.view", @"/Views/Cliente/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cliente/Index.cshtml", typeof(AspNetCore.Views_Cliente_Index))]
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
#line 1 "C:\Users\ms327\Desktop\estacionamento\Estacionamento\TesteEstacionamento\Views\_ViewImports.cshtml"
using TesteEstacionamento;

#line default
#line hidden
#line 2 "C:\Users\ms327\Desktop\estacionamento\Estacionamento\TesteEstacionamento\Views\_ViewImports.cshtml"
using TesteEstacionamento.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a8753cc3a573d225644630645962c3e670ee240", @"/Views/Cliente/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a7ab0e071855616bf2ccaaa1405b3018b74d0a4", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TesteEstacionamento.Models.ClienteModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/indexCliente.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(61, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ms327\Desktop\estacionamento\Estacionamento\TesteEstacionamento\Views\Cliente\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(104, 460, true);
            WriteLiteral(@"

<p>
    <a class=""btn btn-primary"" href=""#"" id=""novaEntrada"">Nova Entrada</a>
</p>
<h2>Veículos no Estacionamento</h2>
<div class=""col-md-12 row form-inline"">
    <div class=""col-md-7""></div>
    <label for=""filtro"" class=""col-md-2"">Buscar Placa:</label>
    <input id=""filtro"" class=""form-control col-md-3"" type=""text""/>
    
</div>
<br />
<table class=""table estacionamentoAtivo"">
    <thead>
        <tr>
            <th>
                ");
            EndContext();
            BeginContext(565, 41, false);
#line 23 "C:\Users\ms327\Desktop\estacionamento\Estacionamento\TesteEstacionamento\Views\Cliente\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Placa));

#line default
#line hidden
            EndContext();
            BeginContext(606, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(662, 47, false);
#line 26 "C:\Users\ms327\Desktop\estacionamento\Estacionamento\TesteEstacionamento\Views\Cliente\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DataEntrada));

#line default
#line hidden
            EndContext();
            BeginContext(709, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 32 "C:\Users\ms327\Desktop\estacionamento\Estacionamento\TesteEstacionamento\Views\Cliente\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#line 33 "C:\Users\ms327\Desktop\estacionamento\Estacionamento\TesteEstacionamento\Views\Cliente\Index.cshtml"
          if (item.DataSaida == DateTime.MinValue)
            {

#line default
#line hidden
            BeginContext(900, 19, true);
            WriteLiteral("                <tr");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 919, "\"", 932, 1);
#line 35 "C:\Users\ms327\Desktop\estacionamento\Estacionamento\TesteEstacionamento\Views\Cliente\Index.cshtml"
WriteAttributeValue("", 924, item.Id, 924, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(933, 64, true);
            WriteLiteral(">\r\n                    <td id=\"placa\">\r\n                        ");
            EndContext();
            BeginContext(998, 40, false);
#line 37 "C:\Users\ms327\Desktop\estacionamento\Estacionamento\TesteEstacionamento\Views\Cliente\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Placa));

#line default
#line hidden
            EndContext();
            BeginContext(1038, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1118, 46, false);
#line 40 "C:\Users\ms327\Desktop\estacionamento\Estacionamento\TesteEstacionamento\Views\Cliente\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.DataEntrada));

#line default
#line hidden
            EndContext();
            BeginContext(1164, 55, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
            EndContext();
            BeginContext(1393, 123, true);
            WriteLiteral("                        <button class=\"btn btn-primary\" id=\"btnMarcarSaida\">Marcar Saída</button>\r\n                        ");
            EndContext();
            BeginContext(1516, 81, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a8753cc3a573d225644630645962c3e670ee2408301", async() => {
                BeginContext(1586, 7, true);
                WriteLiteral("Deletar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 46 "C:\Users\ms327\Desktop\estacionamento\Estacionamento\TesteEstacionamento\Views\Cliente\Index.cshtml"
                                                                        WriteLiteral(item.Id);

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
            BeginContext(1597, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 49 "C:\Users\ms327\Desktop\estacionamento\Estacionamento\TesteEstacionamento\Views\Cliente\Index.cshtml"
            }

#line default
#line hidden
#line 49 "C:\Users\ms327\Desktop\estacionamento\Estacionamento\TesteEstacionamento\Views\Cliente\Index.cshtml"
             
    }

#line default
#line hidden
            BeginContext(1671, 473, true);
            WriteLiteral(@"    </tbody>
</table>

<div id=""wraperTableHistorico"">
    <h2>Histórico</h2>
    <div class=""col-md-12 row form-inline"">
        <div class=""col-md-7""></div>
        <label for=""filtroHistorico"" class=""col-md-2"">Buscar Placa:</label>
        <input id=""filtroHistorico"" class=""form-control col-md-3"" type=""text"" />

    </div>  
    <br />
    <table class=""table tabelaHistorico"">
        <thead>
            <tr>
                <th>
                    ");
            EndContext();
            BeginContext(2145, 41, false);
#line 67 "C:\Users\ms327\Desktop\estacionamento\Estacionamento\TesteEstacionamento\Views\Cliente\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Placa));

#line default
#line hidden
            EndContext();
            BeginContext(2186, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(2254, 47, false);
#line 70 "C:\Users\ms327\Desktop\estacionamento\Estacionamento\TesteEstacionamento\Views\Cliente\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.DataEntrada));

#line default
#line hidden
            EndContext();
            BeginContext(2301, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(2369, 45, false);
#line 73 "C:\Users\ms327\Desktop\estacionamento\Estacionamento\TesteEstacionamento\Views\Cliente\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.DataSaida));

#line default
#line hidden
            EndContext();
            BeginContext(2414, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(2482, 41, false);
#line 76 "C:\Users\ms327\Desktop\estacionamento\Estacionamento\TesteEstacionamento\Views\Cliente\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(2523, 106, true);
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 82 "C:\Users\ms327\Desktop\estacionamento\Estacionamento\TesteEstacionamento\Views\Cliente\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#line 83 "C:\Users\ms327\Desktop\estacionamento\Estacionamento\TesteEstacionamento\Views\Cliente\Index.cshtml"
              if (item.DataSaida != DateTime.MinValue)
                {

#line default
#line hidden
            BeginContext(2746, 23, true);
            WriteLiteral("                    <tr");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2769, "\"", 2782, 1);
#line 85 "C:\Users\ms327\Desktop\estacionamento\Estacionamento\TesteEstacionamento\Views\Cliente\Index.cshtml"
WriteAttributeValue("", 2774, item.Id, 2774, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2783, 72, true);
            WriteLiteral(">\r\n                        <td id=\"placa\">\r\n                            ");
            EndContext();
            BeginContext(2856, 40, false);
#line 87 "C:\Users\ms327\Desktop\estacionamento\Estacionamento\TesteEstacionamento\Views\Cliente\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Placa));

#line default
#line hidden
            EndContext();
            BeginContext(2896, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2988, 46, false);
#line 90 "C:\Users\ms327\Desktop\estacionamento\Estacionamento\TesteEstacionamento\Views\Cliente\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.DataEntrada));

#line default
#line hidden
            EndContext();
            BeginContext(3034, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3126, 44, false);
#line 93 "C:\Users\ms327\Desktop\estacionamento\Estacionamento\TesteEstacionamento\Views\Cliente\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.DataSaida));

#line default
#line hidden
            EndContext();
            BeginContext(3170, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3262, 40, false);
#line 96 "C:\Users\ms327\Desktop\estacionamento\Estacionamento\TesteEstacionamento\Views\Cliente\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(3302, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3393, 81, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a8753cc3a573d225644630645962c3e670ee24016586", async() => {
                BeginContext(3463, 7, true);
                WriteLiteral("Deletar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 99 "C:\Users\ms327\Desktop\estacionamento\Estacionamento\TesteEstacionamento\Views\Cliente\Index.cshtml"
                                                                            WriteLiteral(item.Id);

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
            BeginContext(3474, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 102 "C:\Users\ms327\Desktop\estacionamento\Estacionamento\TesteEstacionamento\Views\Cliente\Index.cshtml"
                }

#line default
#line hidden
#line 102 "C:\Users\ms327\Desktop\estacionamento\Estacionamento\TesteEstacionamento\Views\Cliente\Index.cshtml"
                 
        }

#line default
#line hidden
            BeginContext(3564, 2938, true);
            WriteLiteral(@"        </tbody>
    </table>
</div>

<div id=""modalSaidaVeiculo"" class=""modal fade"" role=""dialog"">
    <div class=""modal-dialog modal-xl"">
        <!-- Modal content-->
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"">Confirmar Saída</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
            </div>
            <div class=""modal-body "">
                <div class=""row col-md-12 form-inline"">
                    <div class=""form-group col-md-3"">
                        <label for=""placaInputSaida"">Placa:</label>
                        <input readonly=""readonly"" type=""text"" class=""form-control"" id=""placaInputSaida"">
                    </div>
                    <div class=""form-group col-md-3"">
                        <label for=""entrada"">Entrada:</label>
                        <input readonly=""readonly"" type=""datetime-local"" class=""form-control"" id=""entrada"">
               ");
            WriteLiteral(@"     </div>
                    <div class=""form-group col-md-3"">
                        <label for=""saida"">Saida:</label>
                        <input readonly=""readonly"" type=""datetime-local"" class=""form-control"" id=""saida"">
                    </div>
                    <div class=""form-group col-md-3"">
                        <label for=""total"">Total:</label>
                        <input readonly=""readonly"" type=""text"" class=""form-control"" id=""total"">
                    </div>
                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-primary"" id=""btnConfirmarSaida"">Confirmar Saída</button>
                <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"">Fechar</button>
            </div>
        </div>

    </div>
</div>

<div id=""entradaVeiculo"" class=""modal fade"" role=""dialog"">
    <div class=""modal-dialog"">
        <!-- Modal content-->
        <div class=""modal-content"">
         ");
            WriteLiteral(@"   <div class=""modal-header"">
                <h4 class=""modal-title"">Entrada de Veículo</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
            </div>
            <div class=""modal-body "">
                <div class=""row col-md-12 form-inline"">
                    <div class=""form-group col-md-3"">
                        <label for=""text"">Placa:</label>
                        <input type=""text"" maxlength=""7"" class=""form-control"" id=""placaEntrada"">
                    </div>
                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-primary"" id=""btnConfirmarEntrada"">Confirmar</button>
                <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"">Fechar</button>
            </div>
        </div>

    </div>
</div>
");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(6520, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(6526, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a8753cc3a573d225644630645962c3e670ee24022877", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6570, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(6575, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TesteEstacionamento.Models.ClienteModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
