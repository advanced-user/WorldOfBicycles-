#pragma checksum "C:\Users\Home\Desktop\WorldOfBicycles\WorldOfBicycles\WorldOfBicycles\Views\Rent\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dac291b9fac73727042dcfadaa990d5495e63a21"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rent_Index), @"mvc.1.0.view", @"/Views/Rent/Index.cshtml")]
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
#line 2 "C:\Users\Home\Desktop\WorldOfBicycles\WorldOfBicycles\WorldOfBicycles\Views\Rent\Index.cshtml"
using WorldOfBicycles.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dac291b9fac73727042dcfadaa990d5495e63a21", @"/Views/Rent/Index.cshtml")]
    public class Views_Rent_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WorldOfBicycles.ViewModels.RentViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Rent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-category", "Спортивные велосипеды", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-category", "Горные велосипеды", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-category", "Городские велосипеды", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Home\Desktop\WorldOfBicycles\WorldOfBicycles\WorldOfBicycles\Views\Rent\Index.cshtml"
  
    Layout = "_Layout";
    ViewData["Title"] = "Выбор велосипеда в аренду";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id=""carousel-ex"" class=""carousel slideInDown carousel-fade pt-4"" data-ride=""carousel"">
    <div class=""carousel-inner"" role=""listbox"">
        <div class=""carousel-item active"">
            <div class=""view"" style=""background-image: url('https://images.pexels.com/photos/3100835/pexels-photo-3100835.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=650&w=940');
         background-repeat: no-repeat; background-size: cover;"">
                <div class=""mask rgba-black-strong d-flex justify-content-center align-items-center"">
                    <div class=""text-center white-text mx-5 wow fadeIn"">
                        <h1 class=""mb-4"">
                            <strong>Аренда</strong>
                        </h1>

                        <p>
                            <strong>
                                Lorem Lorem Lorem Lorem LoremLorem Lorem Lorem Lorem LoremLorem Lorem Lorem Lorem Lorem
                            </strong>
                        </p>

                        <p cla");
            WriteLiteral(@"ss=""mb-4 d-none d-md-block"">
                            <strong>Lorem Lorem Lorem Lorem LoremLorem Lorem Lorem Lorem LoremLorem Lorem Lorem Lorem LoremLorem Lorem Lorem Lorem Lorem</strong>
                        </p>
                        <a href=""#"" class=""btn btn-outline-white btn-lg"">
                            LoremLoremLOrem
                            <i class=""fa fa-graduation-cap ml-2""></i>
                        </a>
                    </div>
                </div>
            </div>
        </div>

        <div class=""carousel-item"">
            <div class=""view"" style=""background-image: url('https://images.pexels.com/photos/3937174/pexels-photo-3937174.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500');
         background-repeat: no-repeat; background-size: cover;"">
                <div class=""mask rgba-black-strong d-flex justify-content-center align-items-center"">
                    <div class=""text-center white-text mx-5 wow fadeIn"">
                        <h1 class=""mb-4"">");
            WriteLiteral(@"
                            <strong>Shop</strong>
                        </h1>

                        <p>
                            <strong>
                                Lorem Lorem Lorem Lorem LoremLorem Lorem Lorem Lorem LoremLorem Lorem Lorem Lorem Lorem
                            </strong>
                        </p>

                        <p class=""mb-4 d-none d-md-block"">
                            <strong>Lorem Lorem Lorem Lorem LoremLorem Lorem Lorem Lorem LoremLorem Lorem Lorem Lorem LoremLorem Lorem Lorem Lorem Lorem</strong>
                        </p>
                        <a href=""#"" class=""btn btn-outline-white btn-lg"">
                            LoremLoremLOrem
                            <i class=""fa fa-graduation-cap ml-2""></i>
                        </a>
                    </div>
                </div>
            </div>
        </div>

        <div class=""carousel-item "">
            <div class=""view"" style=""background-image: url('https://images.pe");
            WriteLiteral(@"xels.com/photos/2437299/pexels-photo-2437299.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500');
         background-repeat: no-repeat; background-size: cover;"">
                <div class=""mask rgba-black-strong d-flex justify-content-center align-items-center"">
                    <div class=""text-center white-text mx-5 wow fadeIn"">
                        <h1 class=""mb-4"">
                            <strong>Shop</strong>
                        </h1>

                        <p>
                            <strong>
                                Lorem Lorem Lorem Lorem LoremLorem Lorem Lorem Lorem LoremLorem Lorem Lorem Lorem Lorem
                            </strong>
                        </p>

                        <p class=""mb-4 d-none d-md-block"">
                            <strong>Lorem Lorem Lorem Lorem LoremLorem Lorem Lorem Lorem LoremLorem Lorem Lorem Lorem LoremLorem Lorem Lorem Lorem Lorem</strong>
                        </p>
                        <a href=""#"" class=""btn btn");
            WriteLiteral(@"-outline-white btn-lg"">
                            LoremLoremLOrem
                            <i class=""fa fa-graduation-cap ml-2""></i>
                        </a>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <a href=""#carousel-ex"" class=""carousel-control-prev"" role=""button"" data-slide=""prev"">
        <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
    </a>
    <a href=""#carousel-ex"" class=""carousel-control-next"" role=""button"" data-slide=""next"">
        <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
    </a>
</div>

<main>
    <div class=""container"">

        <nav class=""navbar navbar-expand-lg navbar-dark mdb-color lighten-3 mt-3 mb-5"">
            <span class=""navbar-brand"">Categories:</span>

            <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#nextNav""
                    aria-controls=""nextNav"" aria-expanded=""false"" aria-label=""Toggle navigatio");
            WriteLiteral(@"n"">

                <span class=""navbar-toggler-icon""></span>
            </button>
            <div class=""navbar-collapse navbar-collapse"" id=""nextNav"">
                <ul class=""navbar-nav mr-auto"">
                    <li class=""nav-item"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dac291b9fac73727042dcfadaa990d5495e63a2111312", async() => {
                WriteLiteral("Все");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </li>\r\n\r\n                    <li class=\"nav-item\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dac291b9fac73727042dcfadaa990d5495e63a2112858", async() => {
                WriteLiteral("Спортивные велосипеды");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-category", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["category"] = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </li>\r\n\r\n                    <li class=\"nav-item\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dac291b9fac73727042dcfadaa990d5495e63a2114944", async() => {
                WriteLiteral("Горные велосипеды");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-category", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["category"] = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </li>\r\n\r\n                    <li class=\"nav-item\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dac291b9fac73727042dcfadaa990d5495e63a2117026", async() => {
                WriteLiteral("Городские велосипеды");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-category", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["category"] = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </li>\r\n                </ul>\r\n\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dac291b9fac73727042dcfadaa990d5495e63a2119081", async() => {
                WriteLiteral("\r\n                    <div class=\"md-form my-0\">\r\n                        <input type=\"text\" class=\"form-control mr-sm-2\" placeholder=\"Search\" aria-label=\"Search\" />\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n\r\n        </nav>\r\n\r\n        <section class=\"text-center mb-4\">\r\n            <div class=\"row wow fadeIn\">\r\n");
#nullable restore
#line 142 "C:\Users\Home\Desktop\WorldOfBicycles\WorldOfBicycles\WorldOfBicycles\Views\Rent\Index.cshtml"
                  
                    foreach (Product product in Model.Products)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 145 "C:\Users\Home\Desktop\WorldOfBicycles\WorldOfBicycles\WorldOfBicycles\Views\Rent\Index.cshtml"
                   Write(Html.Partial("AllProducts", product));

#line default
#line hidden
#nullable disable
#nullable restore
#line 145 "C:\Users\Home\Desktop\WorldOfBicycles\WorldOfBicycles\WorldOfBicycles\Views\Rent\Index.cshtml"
                                                             
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </section>\r\n\r\n        <nav class=\"d-flex justify-content-center wow fadeIn\">\r\n            <ul class=\"pagination pg-blue\">\r\n                <li class=\"page-item\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 7231, "\"", 7238, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"page-link\" aria-label=\"Previous\">\r\n                        <span aria-hidden=\"true\">&laquo;</span>\r\n                    </a>\r\n                </li>\r\n                <li class=\"page-item \">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 7459, "\"", 7466, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"page-link\" aria-label=\"Previous\">\r\n                        <span aria-hidden=\"true\">1</span>\r\n                    </a>\r\n                </li>\r\n                <li class=\"page-item \">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 7681, "\"", 7688, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"page-link\" aria-label=\"Previous\">\r\n                        <span aria-hidden=\"true\">2</span>\r\n                    </a>\r\n                </li>\r\n                <li class=\"page-item \">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 7903, "\"", 7910, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"page-link\" aria-label=\"Previous\">\r\n                        <span aria-hidden=\"true\">3</span>\r\n                    </a>\r\n                </li>\r\n                <li class=\"page-item \">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 8125, "\"", 8132, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"page-link\" aria-label=\"Previous\">\r\n                        <span aria-hidden=\"true\">4</span>\r\n                    </a>\r\n                </li>\r\n                <li class=\"page-item \">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 8347, "\"", 8354, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"page-link\" aria-label=\"Previous\">\r\n                        <span aria-hidden=\"true\">5</span>\r\n                    </a>\r\n                </li>\r\n                <li class=\"page-item \">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 8569, "\"", 8576, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"page-link\" aria-label=\"Next\">\r\n                        <span aria-hidden=\"true\">&raquo;</span>\r\n                    </a>\r\n                </li>\r\n\r\n            </ul>\r\n        </nav>\r\n    </div>\r\n</main>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WorldOfBicycles.ViewModels.RentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
