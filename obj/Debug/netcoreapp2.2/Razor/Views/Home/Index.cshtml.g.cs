#pragma checksum "/home/satva/Documentos/TecTecTec/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f36a6ce2785c9fd8ae9733b87c5557f1155ce53e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "/home/satva/Documentos/TecTecTec/Views/_ViewImports.cshtml"
using FeedbackMVC;

#line default
#line hidden
#line 2 "/home/satva/Documentos/TecTecTec/Views/_ViewImports.cshtml"
using FeedbackMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f36a6ce2785c9fd8ae9733b87c5557f1155ce53e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9292c0a2471401b491715bf1817513fff62d52d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FeedbackMVC.ViewModels.ClienteViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("FormCriarPost"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ExcluirPost", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DescurtirPost", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CurtirPost", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/home/satva/Documentos/TecTecTec/Views/Home/Index.cshtml"
  

ViewData["Usuario"] = @Model.UsuarioLogado;
var link = "ArquivosDosClientes/"+ViewData["Usuario"]+"/perfil.png";

#line default
#line hidden
            BeginContext(166, 15, true);
            WriteLiteral("        <main>\n");
            EndContext();
#line 8 "/home/satva/Documentos/TecTecTec/Views/Home/Index.cshtml"
             if(Model.UsuarioLogado != "")
            {

#line default
#line hidden
            BeginContext(238, 176, true);
            WriteLiteral("                <div class=\"CriarPost\">\n                    <div class=\"PostHeader\">\n                        <h1></h1>\n                            <img class=\"PostImagemPerfil\"");
            EndContext();
            BeginWriteAttribute("src", " src=", 414, "", 424, 1);
#line 13 "/home/satva/Documentos/TecTecTec/Views/Home/Index.cshtml"
WriteAttributeValue("", 419, link, 419, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(424, 159, true);
            WriteLiteral(">\n                    </div>\n                    <script src=\"https://rawgit.com/jackmoore/autosize/master/dist/autosize.min.js\"></script>\n                    ");
            EndContext();
            BeginContext(583, 967, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f36a6ce2785c9fd8ae9733b87c5557f1155ce53e6560", async() => {
                BeginContext(664, 879, true);
                WriteLiteral(@"
                        
                        <!-- codigo js para limitar caractere
                        
                        $(document).on(""keydown"", ""#TxtObservacoes"", function () {
                    var caracteresRestantes = 255;
                    var caracteresDigitados = parseInt($(this).val().length);
                    var caracteresRestantes = caracteresRestantes - caracteresDigitados;
            
                    $("".caracteres"").text(caracteresRestantes);
                        }); -->

                        <textarea class=""CriarPostMensagem"" minlength=""1"" maxlength=""140"" name=""MensagemDoPost"" placeholder=""Poste uma mensagem...""></textarea>
                        <div class=""BotaoCriarPostDiv"">
                            <input class=""BotaoCriarPost"" type=""submit"" value=""Postar"">
                        </div>
                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 16 "/home/satva/Documentos/TecTecTec/Views/Home/Index.cshtml"
AddHtmlAttributeValue("", 633, Url.Action("Postar", "Home"), 633, 29, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1550, 42, true);
            WriteLiteral("\n\n                </div>\n            <hr>\n");
            EndContext();
#line 36 "/home/satva/Documentos/TecTecTec/Views/Home/Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1606, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 37 "/home/satva/Documentos/TecTecTec/Views/Home/Index.cshtml"
             foreach(Post post in Model.PostsDeTodos){
                var postperfilimagem = "ArquivosDosClientes/"+post.DonoDoPostArroba+"/perfil.png";

#line default
#line hidden
            BeginContext(1760, 137, true);
            WriteLiteral("                <div class=\"Post\">\n                    <div class=\"PostHeader\">\n                            <img class=\"PostImagemPerfil\"");
            EndContext();
            BeginWriteAttribute("src", " src=", 1897, "", 1919, 1);
#line 41 "/home/satva/Documentos/TecTecTec/Views/Home/Index.cshtml"
WriteAttributeValue("", 1902, postperfilimagem, 1902, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1919, 111, true);
            WriteLiteral(">\n                        <div class=\"PostUserInformacao\">\n                            <p class=\"PostDonoNome\">");
            EndContext();
            BeginContext(2031, 15, false);
#line 43 "/home/satva/Documentos/TecTecTec/Views/Home/Index.cshtml"
                                               Write(post.DonoDoPost);

#line default
#line hidden
            EndContext();
            BeginContext(2046, 60, true);
            WriteLiteral("</p>\n                            <p class=\"PostDonoUsuario\">");
            EndContext();
            BeginContext(2107, 21, false);
#line 44 "/home/satva/Documentos/TecTecTec/Views/Home/Index.cshtml"
                                                  Write(post.DonoDoPostArroba);

#line default
#line hidden
            EndContext();
            BeginContext(2128, 36, true);
            WriteLiteral("</p>\n                        </div>\n");
            EndContext();
#line 46 "/home/satva/Documentos/TecTecTec/Views/Home/Index.cshtml"
                         if(@Model.UsuarioLogado == post.DonoDoPostArroba)
                        {

#line default
#line hidden
            BeginContext(2265, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(2293, 386, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f36a6ce2785c9fd8ae9733b87c5557f1155ce53e11914", async() => {
                BeginContext(2360, 53, true);
                WriteLiteral("\n                                <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 2413, "", 2428, 1);
#line 49 "/home/satva/Documentos/TecTecTec/Views/Home/Index.cshtml"
WriteAttributeValue("", 2420, post.ID, 2420, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2428, 244, true);
                WriteLiteral(" name=\"ID\">\n                                <button style=\"border:none;\">\n                                    <i class=\"fas ExcluirPost fa-trash\" style=\"color: white;\"></i>\n                                </button>\n\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2679, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 55 "/home/satva/Documentos/TecTecTec/Views/Home/Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(2706, 118, true);
            WriteLiteral("                    </div>\n                    <div class=\"PostBody\">\n                        <p class=\"PostMensagem\">");
            EndContext();
            BeginContext(2825, 19, false);
#line 58 "/home/satva/Documentos/TecTecTec/Views/Home/Index.cshtml"
                                           Write(post.MensagemDoPost);

#line default
#line hidden
            EndContext();
            BeginContext(2844, 77, true);
            WriteLiteral("</p>\n                    </div>\n                    <div class=\"PostFooter\">\n");
            EndContext();
#line 61 "/home/satva/Documentos/TecTecTec/Views/Home/Index.cshtml"
                         if(Model.UsuarioLogado != "")
                        {


#line default
#line hidden
            BeginContext(3003, 134, true);
            WriteLiteral("                            <i class=\"far fa-14x  fa-comment\"></i>\n                            <i class=\"fas fa-14x  fa-retweet\"></i>\n");
            EndContext();
#line 66 "/home/satva/Documentos/TecTecTec/Views/Home/Index.cshtml"
                            
                            
                            bool achou = false;
                            

                            

#line default
#line hidden
#line 71 "/home/satva/Documentos/TecTecTec/Views/Home/Index.cshtml"
                             foreach (var item in @Model.OQueEuCurti)
                            {
                                

#line default
#line hidden
#line 73 "/home/satva/Documentos/TecTecTec/Views/Home/Index.cshtml"
                                 if(item == @post.ID)
                                {

#line default
#line hidden
            BeginContext(3461, 36, true);
            WriteLiteral("                                    ");
            EndContext();
            BeginContext(3497, 441, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f36a6ce2785c9fd8ae9733b87c5557f1155ce53e16610", async() => {
                BeginContext(3566, 61, true);
                WriteLiteral("\n                                        <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 3627, "", 3642, 1);
#line 76 "/home/satva/Documentos/TecTecTec/Views/Home/Index.cshtml"
WriteAttributeValue("", 3634, post.ID, 3634, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3642, 289, true);
                WriteLiteral(@" name=""ID"">
                                        <button style=""border:none; background: none;"">
                                            <i class=""fas fa-14x fa-heart"" style=""color: yellow;""></i>
                                        </button>
                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3938, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 81 "/home/satva/Documentos/TecTecTec/Views/Home/Index.cshtml"
                                    achou = true;
                                    break;
                                }

#line default
#line hidden
#line 83 "/home/satva/Documentos/TecTecTec/Views/Home/Index.cshtml"
                                 
                            }

#line default
#line hidden
#line 86 "/home/satva/Documentos/TecTecTec/Views/Home/Index.cshtml"
                             if(@achou == false)
                            {

#line default
#line hidden
            BeginContext(4176, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(4208, 395, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f36a6ce2785c9fd8ae9733b87c5557f1155ce53e20057", async() => {
                BeginContext(4274, 57, true);
                WriteLiteral("\n                                    <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 4331, "", 4346, 1);
#line 89 "/home/satva/Documentos/TecTecTec/Views/Home/Index.cshtml"
WriteAttributeValue("", 4338, post.ID, 4338, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4346, 250, true);
                WriteLiteral(" name=\"ID\">\n                                    <button style=\"border:none; background: none;\">\n                                        <i class=\"far fa-14x fa-heart\"></i>\n                                    </button>\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4603, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 94 "/home/satva/Documentos/TecTecTec/Views/Home/Index.cshtml"
                            }

#line default
#line hidden
#line 94 "/home/satva/Documentos/TecTecTec/Views/Home/Index.cshtml"
                             

                        }else{


#line default
#line hidden
            BeginContext(4667, 196, true);
            WriteLiteral("                            <i class=\"far fa-14x fa-comment\"></i>\n                            <i class=\"fas fa-14x fa-retweet\"></i>\n                            <i class=\"far fa-14x fa-heart\"></i>\n");
            EndContext();
#line 101 "/home/satva/Documentos/TecTecTec/Views/Home/Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(4889, 51, true);
            WriteLiteral("                    </div>\n\n                </div>\n");
            EndContext();
#line 105 "/home/satva/Documentos/TecTecTec/Views/Home/Index.cshtml"

            }

#line default
#line hidden
            BeginContext(4955, 216, true);
            WriteLiteral("\n        </main>\n        <!-- <a href=\"#\" class=\"BotaoFlutuanteEscreverMensagem\">\n            <i class=\"fa fa-2x fa-edit BotaoFlutuanteIcone\"></i>\n        </a> -->\n\n        <script src=\"js/main.js\">\n        </script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FeedbackMVC.ViewModels.ClienteViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
