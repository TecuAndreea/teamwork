#pragma checksum "E:\Programare\TalentingSoftware\Scholarship\Exercices\ExercicesTeamWork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\Client\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eaedbb5821027813f926cd77d10750c9e0b0e096"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Client_Index), @"mvc.1.0.view", @"/Views/Client/Index.cshtml")]
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
#line 1 "E:\Programare\TalentingSoftware\Scholarship\Exercices\ExercicesTeamWork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\_ViewImports.cshtml"
using AsociatiaDeTarani;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Programare\TalentingSoftware\Scholarship\Exercices\ExercicesTeamWork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\_ViewImports.cshtml"
using AsociatiaDeTarani.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Programare\TalentingSoftware\Scholarship\Exercices\ExercicesTeamWork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\_ViewImports.cshtml"
using AsociatiaDeTarani.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Programare\TalentingSoftware\Scholarship\Exercices\ExercicesTeamWork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\_ViewImports.cshtml"
using AsociatiaDeTarani.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eaedbb5821027813f926cd77d10750c9e0b0e096", @"/Views/Client/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"935027af7b2d4b87c557d90ac685eaa16d8c4a36", @"/Views/_ViewImports.cshtml")]
    public class Views_Client_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductsAndProducersListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Cauta.."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "default", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-right: 1em"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-row"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-bottom:2em; margin-top:2em"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("addToCart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString(@"background: rgb(75,129,157); background: linear-gradient(180deg, rgba(75,129,157,1) 0%, rgba(122,160,169,1) 13%, rgba(178,186,171,1) 22%, rgba(218,205,153,1) 30%, rgba(240,214,129,1) 34%, rgba(245,207,110,1) 36%, rgba(236,202,98,1) 38%, rgba(238,205,65,1) 42%, rgba(243,197,51,1) 46%, rgba(232,180,58,1) 47%, rgba(208,115,36,1) 52%, rgba(169,111,31,1) 54%, rgba(151,97,25,1) 57%, rgba(196,134,29,1) 69%, rgba(182,107,13,1) 100%); "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\Programare\TalentingSoftware\Scholarship\Exercices\ExercicesTeamWork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\Client\Index.cshtml"
  

    Layout = "_ClientLayout";
    

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eaedbb5821027813f926cd77d10750c9e0b0e0969943", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eaedbb5821027813f926cd77d10750c9e0b0e09610205", async() => {
                    WriteLiteral("\r\n        <div class=\"col-sm-7\">\r\n            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "eaedbb5821027813f926cd77d10750c9e0b0e09610520", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 10 "E:\Programare\TalentingSoftware\Scholarship\Exercices\ExercicesTeamWork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\Client\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SearchTerm);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                    BeginWriteTagHelperAttribute();
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __tagHelperExecutionContext.AddHtmlAttribute("margin-right:1em\"", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"col-sm-2\">\r\n            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eaedbb5821027813f926cd77d10750c9e0b0e09612951", async() => {
                        WriteLiteral("\r\n                ");
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eaedbb5821027813f926cd77d10750c9e0b0e09613244", async() => {
                            WriteLiteral("Toti producatorii");
                        }
                        );
                        __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                        __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                        __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        WriteLiteral("\r\n");
#nullable restore
#line 16 "E:\Programare\TalentingSoftware\Scholarship\Exercices\ExercicesTeamWork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\Client\Index.cshtml"
                 foreach (var producer in Model.Producers)
                {

#line default
#line hidden
#nullable disable
                        WriteLiteral("                    ");
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eaedbb5821027813f926cd77d10750c9e0b0e09614973", async() => {
#nullable restore
#line 18 "E:\Programare\TalentingSoftware\Scholarship\Exercices\ExercicesTeamWork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\Client\Index.cshtml"
                                              Write(producer.Name);

#line default
#line hidden
#nullable disable
                        }
                        );
                        __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                        __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                        BeginWriteTagHelperAttribute();
#nullable restore
#line 18 "E:\Programare\TalentingSoftware\Scholarship\Exercices\ExercicesTeamWork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\Client\Index.cshtml"
                       WriteLiteral(producer.Name);

#line default
#line hidden
#nullable disable
                        __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                        __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                        __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        WriteLiteral("\r\n");
#nullable restore
#line 19 "E:\Programare\TalentingSoftware\Scholarship\Exercices\ExercicesTeamWork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\Client\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                        WriteLiteral("            ");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 14 "E:\Programare\TalentingSoftware\Scholarship\Exercices\ExercicesTeamWork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\Client\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.FilterTerm);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"col-sm-3\">\r\n            <button type=\"submit\" class=\"btn btn-dark\"><i class=\"fa fa-search\">  Cauta</i></button>\r\n        </div>\r\n    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n\r\n    <div class=\"card-columns\">\r\n");
#nullable restore
#line 30 "E:\Programare\TalentingSoftware\Scholarship\Exercices\ExercicesTeamWork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\Client\Index.cshtml"
         foreach (var product in Model.Products)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"card\">\r\n                <img class=\"card-img\"");
                BeginWriteAttribute("src", " src=\"", 1517, "\"", 1553, 1);
#nullable restore
#line 33 "E:\Programare\TalentingSoftware\Scholarship\Exercices\ExercicesTeamWork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\Client\Index.cshtml"
WriteAttributeValue("", 1523, Url.Content(product.PhotoUrl), 1523, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                <div class=\"card-body\">\r\n                    <h3 class=\"card-title\">");
#nullable restore
#line 35 "E:\Programare\TalentingSoftware\Scholarship\Exercices\ExercicesTeamWork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\Client\Index.cshtml"
                                      Write(product.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                    <h5 class=\"card-text\">");
#nullable restore
#line 36 "E:\Programare\TalentingSoftware\Scholarship\Exercices\ExercicesTeamWork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\Client\Index.cshtml"
                                     Write(product.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(" lei/ ");
#nullable restore
#line 36 "E:\Programare\TalentingSoftware\Scholarship\Exercices\ExercicesTeamWork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\Client\Index.cshtml"
                                                         Write(product.Weight);

#line default
#line hidden
#nullable disable
                WriteLiteral(" kg</h5>\r\n                    <h6>");
#nullable restore
#line 37 "E:\Programare\TalentingSoftware\Scholarship\Exercices\ExercicesTeamWork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\Client\Index.cshtml"
                   Write(product.Producer.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                    <p> Comanda minima /producator: ");
#nullable restore
#line 38 "E:\Programare\TalentingSoftware\Scholarship\Exercices\ExercicesTeamWork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\Client\Index.cshtml"
                                               Write(product.Producer.MinimumOrder);

#line default
#line hidden
#nullable disable
                WriteLiteral(" lei</p>\r\n                    <p>Stoc disponibil: ");
#nullable restore
#line 39 "E:\Programare\TalentingSoftware\Scholarship\Exercices\ExercicesTeamWork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\Client\Index.cshtml"
                                    Write(product.AvailableStock * product.Weight);

#line default
#line hidden
#nullable disable
                WriteLiteral(" kg</p>\r\n");
#nullable restore
#line 40 "E:\Programare\TalentingSoftware\Scholarship\Exercices\ExercicesTeamWork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\Client\Index.cshtml"
                     if (product.AvailableStock != 0)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eaedbb5821027813f926cd77d10750c9e0b0e09624124", async() => {
                    WriteLiteral("Adauga in cos");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_11.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_12.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "E:\Programare\TalentingSoftware\Scholarship\Exercices\ExercicesTeamWork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\Client\Index.cshtml"
                                                                                                                                          WriteLiteral(product.ProductId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 43 "E:\Programare\TalentingSoftware\Scholarship\Exercices\ExercicesTeamWork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\Client\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <button type=\"button\" class=\"btn btn-danger\" disabled id=\"addToCartInavailable\">Stoc indisponibil</button>\r\n");
#nullable restore
#line 47 "E:\Programare\TalentingSoftware\Scholarship\Exercices\ExercicesTeamWork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\Client\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 52 "E:\Programare\TalentingSoftware\Scholarship\Exercices\ExercicesTeamWork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\Client\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductsAndProducersListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
