#pragma checksum "E:\Programare\TalentingSoftware\Scholarship\Exercices\ExercicesTeamWork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\Order\OrderForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f218f4d37e16f407a0f951115fa018caa14a1389"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_OrderForm), @"mvc.1.0.view", @"/Views/Order/OrderForm.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f218f4d37e16f407a0f951115fa018caa14a1389", @"/Views/Order/OrderForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"935027af7b2d4b87c557d90ac685eaa16d8c4a36", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_OrderForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AsociatiaDeTarani.ViewModels.OrderDetailsViewModel>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Programare\TalentingSoftware\Scholarship\Exercices\ExercicesTeamWork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\Order\OrderForm.cshtml"
   ViewBag.Title = "Create";
    Layout = "_ClientLayout"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<link rel=\"stylesheet\" href=\"https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css\" integrity=\"sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh\" crossorigin=\"anonymous\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f218f4d37e16f407a0f951115fa018caa14a13894407", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 8 "E:\Programare\TalentingSoftware\Scholarship\Exercices\ExercicesTeamWork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\Order\OrderForm.cshtml"
     using (Html.BeginForm("OrderForm", "Order", FormMethod.Post, htmlAttributes: new { @class = "form-group row" }))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Programare\TalentingSoftware\Scholarship\Exercices\ExercicesTeamWork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\Order\OrderForm.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        <div class=""container"">
            <div class=""form-group"">
                <fieldset class=""section-border"">
                    <legend class=""section-border"">
                        Detalii personale
                    </legend>
                    ");
#nullable restore
#line 17 "E:\Programare\TalentingSoftware\Scholarship\Exercices\ExercicesTeamWork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\Order\OrderForm.cshtml"
               Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <div class=\"form-row\" style=\"margin-bottom:2em\">\r\n                        ");
#nullable restore
#line 19 "E:\Programare\TalentingSoftware\Scholarship\Exercices\ExercicesTeamWork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\Order\OrderForm.cshtml"
                   Write(Html.LabelFor(model => model.Name, "Nume", new { @class = "control-label col-md-1" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <div class=\"col-md-8\">\r\n                            ");
#nullable restore
#line 21 "E:\Programare\TalentingSoftware\Scholarship\Exercices\ExercicesTeamWork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\Order\OrderForm.cshtml"
                       Write(Html.EditorFor(model => model.Name, new { htmlAttributes = new { placeholder = "Introduceti numele aici", @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 22 "E:\Programare\TalentingSoftware\Scholarship\Exercices\ExercicesTeamWork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\Order\OrderForm.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"form-row\" style=\"margin-bottom:2em\">\r\n                        ");
#nullable restore
#line 26 "E:\Programare\TalentingSoftware\Scholarship\Exercices\ExercicesTeamWork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\Order\OrderForm.cshtml"
                   Write(Html.LabelFor(model => model.Adress, "Adresa", htmlAttributes: new { @class = "control-label col-md-1" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <div class=\"col-md-8\">\r\n                            ");
#nullable restore
#line 28 "E:\Programare\TalentingSoftware\Scholarship\Exercices\ExercicesTeamWork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\Order\OrderForm.cshtml"
                       Write(Html.EditorFor(model => model.Adress, new { htmlAttributes = new { placeholder = "Introduceti adresa aici", @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 29 "E:\Programare\TalentingSoftware\Scholarship\Exercices\ExercicesTeamWork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\Order\OrderForm.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Adress, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"form-row\" style=\"margin-bottom:2em\">\r\n                        ");
#nullable restore
#line 33 "E:\Programare\TalentingSoftware\Scholarship\Exercices\ExercicesTeamWork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\Order\OrderForm.cshtml"
                   Write(Html.LabelFor(model => model.PhoneNumber, "Numar telefon", htmlAttributes: new { @class = "control-label col-md-1" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <div class=\"col-md-6\">\r\n                            ");
#nullable restore
#line 35 "E:\Programare\TalentingSoftware\Scholarship\Exercices\ExercicesTeamWork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\Order\OrderForm.cshtml"
                       Write(Html.EditorFor(model => model.PhoneNumber, new { htmlAttributes = new { placeholder = "Introduceti numarul de telefon aici", @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 36 "E:\Programare\TalentingSoftware\Scholarship\Exercices\ExercicesTeamWork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\Order\OrderForm.cshtml"
                       Write(Html.ValidationMessageFor(model => model.PhoneNumber, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        </div>
                    </div>
                </fieldset>
                <fieldset class=""section-border"">
                    <legend class=""section-border"">
                        Detalii comanda
                    </legend>
                    <div class=""form-row"" style=""margin-bottom:2em"">
                        ");
#nullable restore
#line 45 "E:\Programare\TalentingSoftware\Scholarship\Exercices\ExercicesTeamWork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\Order\OrderForm.cshtml"
                   Write(Html.LabelFor(model => model.PlacementDate, "Data comenzii", htmlAttributes: new { @class = "control-label col-md-1" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <div class=\"col-md-5\">\r\n                            ");
#nullable restore
#line 47 "E:\Programare\TalentingSoftware\Scholarship\Exercices\ExercicesTeamWork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\Order\OrderForm.cshtml"
                       Write(Html.EditorFor(model => model.PlacementDate, new { htmlAttributes = new { @class = "form-control", @disabled = "disabled", @readonly = "readonly", placeholder = DateTime.Now.ToString("dd/MM/yyyy") } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 48 "E:\Programare\TalentingSoftware\Scholarship\Exercices\ExercicesTeamWork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\Order\OrderForm.cshtml"
                       Write(Html.ValidationMessageFor(model => model.PlacementDate, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"form-row\" style=\"margin-bottom:2em\">\r\n                        ");
#nullable restore
#line 52 "E:\Programare\TalentingSoftware\Scholarship\Exercices\ExercicesTeamWork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\Order\OrderForm.cshtml"
                   Write(Html.LabelFor(model => model.TotalPrice, "Pretul total", htmlAttributes: new { @class = "control-label col-md-1" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <div class=\"col-md-5\">\r\n                            ");
#nullable restore
#line 54 "E:\Programare\TalentingSoftware\Scholarship\Exercices\ExercicesTeamWork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\Order\OrderForm.cshtml"
                       Write(Html.EditorFor(model => model.TotalPrice, new { htmlAttributes = new { @class = "form-control", disabled = "disabled", @readonly = "readonly", placeholder = ViewBag.total + " LEI"} }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 55 "E:\Programare\TalentingSoftware\Scholarship\Exercices\ExercicesTeamWork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\Order\OrderForm.cshtml"
                       Write(Html.ValidationMessageFor(model => model.TotalPrice, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </fieldset>\r\n                <div class=\"form-row\" style=\"margin-bottom:3em\">\r\n                    <div class=\"col-md-4\">\r\n                        ");
#nullable restore
#line 61 "E:\Programare\TalentingSoftware\Scholarship\Exercices\ExercicesTeamWork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\Order\OrderForm.cshtml"
                   Write(Html.ActionLink("Vezi cosul", "Index", "ShoppingCart"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        <i class=""fa fa-shopping-cart""></i>
                    </div>
                    <div class=""col-md-4 offset-4"">
                        <input type=""submit"" value=""Trimite comanda spre procesare"" class=""btn btn-block btn-secondary"" />
                    </div>
                </div>
            </div>
        </div>
");
#nullable restore
#line 70 "E:\Programare\TalentingSoftware\Scholarship\Exercices\ExercicesTeamWork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\Order\OrderForm.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AsociatiaDeTarani.ViewModels.OrderDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
