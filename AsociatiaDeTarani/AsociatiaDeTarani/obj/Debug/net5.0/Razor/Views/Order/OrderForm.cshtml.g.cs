#pragma checksum "C:\Users\tecu_\Desktop\Scholarship-Internship\Teamwork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\Order\OrderForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "216ef20cae619bf3b9adbad928c49b87166f9fe0"
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
#line 1 "C:\Users\tecu_\Desktop\Scholarship-Internship\Teamwork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\_ViewImports.cshtml"
using AsociatiaDeTarani;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tecu_\Desktop\Scholarship-Internship\Teamwork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\_ViewImports.cshtml"
using AsociatiaDeTarani.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tecu_\Desktop\Scholarship-Internship\Teamwork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\_ViewImports.cshtml"
using AsociatiaDeTarani.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\tecu_\Desktop\Scholarship-Internship\Teamwork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\_ViewImports.cshtml"
using AsociatiaDeTarani.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"216ef20cae619bf3b9adbad928c49b87166f9fe0", @"/Views/Order/OrderForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"935027af7b2d4b87c557d90ac685eaa16d8c4a36", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_OrderForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AsociatiaDeTarani.ViewModels.OrderDetailsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\tecu_\Desktop\Scholarship-Internship\Teamwork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\Order\OrderForm.cshtml"
   ViewBag.Title = "Create";
    Layout = "_ClientLayout"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<link rel=\"stylesheet\" href=\"https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css\" integrity=\"sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh\" crossorigin=\"anonymous\">\r\n\r\n");
#nullable restore
#line 8 "C:\Users\tecu_\Desktop\Scholarship-Internship\Teamwork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\Order\OrderForm.cshtml"
 using (Html.BeginForm("OrderForm", "Order", FormMethod.Post, htmlAttributes: new { @class = "form-group row" }))
{

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\tecu_\Desktop\Scholarship-Internship\Teamwork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\Order\OrderForm.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""container"">
                    <div class=""form-horizontal"">
                        <fieldset class=""section-border"">
                            <legend class=""section-border"">
                                Detalii personale
                            </legend>
                            ");
#nullable restore
#line 17 "C:\Users\tecu_\Desktop\Scholarship-Internship\Teamwork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\Order\OrderForm.cshtml"
                       Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <div class=\"form-group\">\r\n                                ");
#nullable restore
#line 19 "C:\Users\tecu_\Desktop\Scholarship-Internship\Teamwork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\Order\OrderForm.cshtml"
                           Write(Html.LabelFor(model => model.Name, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <div class=\"col-md-8\">\r\n                                    ");
#nullable restore
#line 21 "C:\Users\tecu_\Desktop\Scholarship-Internship\Teamwork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\Order\OrderForm.cshtml"
                               Write(Html.EditorFor(model => model.Name, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    ");
#nullable restore
#line 22 "C:\Users\tecu_\Desktop\Scholarship-Internship\Teamwork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\Order\OrderForm.cshtml"
                               Write(Html.ValidationMessageFor(model => model.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                ");
#nullable restore
#line 26 "C:\Users\tecu_\Desktop\Scholarship-Internship\Teamwork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\Order\OrderForm.cshtml"
                           Write(Html.LabelFor(model => model.Adress, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <div class=\"col-md-8\">\r\n                                    ");
#nullable restore
#line 28 "C:\Users\tecu_\Desktop\Scholarship-Internship\Teamwork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\Order\OrderForm.cshtml"
                               Write(Html.EditorFor(model => model.Adress, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    ");
#nullable restore
#line 29 "C:\Users\tecu_\Desktop\Scholarship-Internship\Teamwork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\Order\OrderForm.cshtml"
                               Write(Html.ValidationMessageFor(model => model.Adress, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                ");
#nullable restore
#line 33 "C:\Users\tecu_\Desktop\Scholarship-Internship\Teamwork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\Order\OrderForm.cshtml"
                           Write(Html.LabelFor(model => model.PhoneNumber, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <div class=\"col-md-8\">\r\n                                    ");
#nullable restore
#line 35 "C:\Users\tecu_\Desktop\Scholarship-Internship\Teamwork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\Order\OrderForm.cshtml"
                               Write(Html.EditorFor(model => model.PhoneNumber, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    ");
#nullable restore
#line 36 "C:\Users\tecu_\Desktop\Scholarship-Internship\Teamwork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\Order\OrderForm.cshtml"
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
                            <div class=""form-group"">
                                ");
#nullable restore
#line 45 "C:\Users\tecu_\Desktop\Scholarship-Internship\Teamwork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\Order\OrderForm.cshtml"
                           Write(Html.LabelFor(model => model.PlacementDate, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <div class=\"col-md-8\">\r\n                                    ");
#nullable restore
#line 47 "C:\Users\tecu_\Desktop\Scholarship-Internship\Teamwork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\Order\OrderForm.cshtml"
                               Write(Html.EditorFor(model => model.PlacementDate, new { htmlAttributes = new { @class = "form-control", type = "date", @placeholder = "invoice date", disabled = "disabled" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    ");
#nullable restore
#line 48 "C:\Users\tecu_\Desktop\Scholarship-Internship\Teamwork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\Order\OrderForm.cshtml"
                               Write(Html.ValidationMessageFor(model => model.PlacementDate, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                ");
#nullable restore
#line 52 "C:\Users\tecu_\Desktop\Scholarship-Internship\Teamwork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\Order\OrderForm.cshtml"
                           Write(Html.LabelFor(model => model.TotalPrice, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <div class=\"col-md-8\">\r\n                                    ");
#nullable restore
#line 54 "C:\Users\tecu_\Desktop\Scholarship-Internship\Teamwork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\Order\OrderForm.cshtml"
                               Write(Html.EditorFor(model => model.TotalPrice, new { htmlAttributes = new { @class = "form-control", disabled = "disabled", @readonly = "readonly", } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    ");
#nullable restore
#line 55 "C:\Users\tecu_\Desktop\Scholarship-Internship\Teamwork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\Order\OrderForm.cshtml"
                               Write(Html.ValidationMessageFor(model => model.TotalPrice, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                        </fieldset>
                        <div class=""col-md-6"">
                            <input type=""submit"" value=""Trimite comanda"" class=""btn btn-block btn-primary"" />
                        </div>
                    </div>
                </div>");
#nullable restore
#line 63 "C:\Users\tecu_\Desktop\Scholarship-Internship\Teamwork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\Order\OrderForm.cshtml"
                      }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    ");
#nullable restore
#line 66 "C:\Users\tecu_\Desktop\Scholarship-Internship\Teamwork\teamwork\AsociatiaDeTarani\AsociatiaDeTarani\Views\Order\OrderForm.cshtml"
Write(Html.ActionLink("Vezi cosul", "Index","ShoppingCart"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
