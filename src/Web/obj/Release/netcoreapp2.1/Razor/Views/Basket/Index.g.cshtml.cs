#pragma checksum "C:\Users\mindaugas.kazukauska\Desktop\New folder (4)\eShopOnWeb-master\eShopOnWeb-master\src\Web\Views\Basket\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a6833f929923c057c5565f1792f111805ebb4e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Basket_Index), @"mvc.1.0.view", @"/Views/Basket/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Basket/Index.cshtml", typeof(AspNetCore.Views_Basket_Index))]
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
#line 1 "C:\Users\mindaugas.kazukauska\Desktop\New folder (4)\eShopOnWeb-master\eShopOnWeb-master\src\Web\Views\_ViewImports.cshtml"
using Microsoft.eShopWeb.Web;

#line default
#line hidden
#line 1 "C:\Users\mindaugas.kazukauska\Desktop\New folder (4)\eShopOnWeb-master\eShopOnWeb-master\src\Web\Views\Basket\Index.cshtml"
using Microsoft.eShopWeb.Web.ViewModels;

#line default
#line hidden
#line 3 "C:\Users\mindaugas.kazukauska\Desktop\New folder (4)\eShopOnWeb-master\eShopOnWeb-master\src\Web\Views\_ViewImports.cshtml"
using Microsoft.eShopWeb.Web.ViewModels.Account;

#line default
#line hidden
#line 4 "C:\Users\mindaugas.kazukauska\Desktop\New folder (4)\eShopOnWeb-master\eShopOnWeb-master\src\Web\Views\_ViewImports.cshtml"
using Microsoft.eShopWeb.Web.ViewModels.Manage;

#line default
#line hidden
#line 5 "C:\Users\mindaugas.kazukauska\Desktop\New folder (4)\eShopOnWeb-master\eShopOnWeb-master\src\Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 6 "C:\Users\mindaugas.kazukauska\Desktop\New folder (4)\eShopOnWeb-master\eShopOnWeb-master\src\Web\Views\_ViewImports.cshtml"
using Microsoft.eShopWeb.Infrastructure.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a6833f929923c057c5565f1792f111805ebb4e9", @"/Views/Basket/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"460ba3afd06cdbc59bad0a1ade39ac9c11fc1d78", @"/Views/_ViewImports.cshtml")]
    public class Views_Basket_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BasketViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn esh-basket-checkout"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("updatebutton"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("[ Checkout ]"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("action"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\mindaugas.kazukauska\Desktop\New folder (4)\eShopOnWeb-master\eShopOnWeb-master\src\Web\Views\Basket\Index.cshtml"
  
    ViewData["Title"] = "Basket";

#line default
#line hidden
            BeginContext(103, 190, true);
            WriteLiteral("<section class=\"esh-catalog-hero\">\n    <div class=\"container\">\n        <img class=\"esh-catalog-title\" src=\"../images/main_banner_text.png\" />\n    </div>\n</section>\n\n<div class=\"container\">\n\n");
            EndContext();
#line 14 "C:\Users\mindaugas.kazukauska\Desktop\New folder (4)\eShopOnWeb-master\eShopOnWeb-master\src\Web\Views\Basket\Index.cshtml"
     if (Model.Items.Any())
    {

#line default
#line hidden
            BeginContext(327, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(335, 3713, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05485db9dd71489982bff4bde36b343a", async() => {
                BeginContext(355, 536, true);
                WriteLiteral(@"
            <article class=""esh-basket-titles row"">
                <br />
                <section class=""esh-basket-title col-xs-3"">Product</section>
                <section class=""esh-basket-title col-xs-3 hidden-lg-down""></section>
                <section class=""esh-basket-title col-xs-2"">Price</section>
                <section class=""esh-basket-title col-xs-2"">Quantity</section>
                <section class=""esh-basket-title col-xs-2"">Cost</section>
            </article>
            <div class=""esh-catalog-items row"">
");
                EndContext();
#line 26 "C:\Users\mindaugas.kazukauska\Desktop\New folder (4)\eShopOnWeb-master\eShopOnWeb-master\src\Web\Views\Basket\Index.cshtml"
                 for (int i=0; i< Model.Items.Count; i++)
                {
                    var item = Model.Items[i];

#line default
#line hidden
                BeginContext(1014, 260, true);
                WriteLiteral(@"                    <article class=""esh-basket-items row"">
                        <div>
                            <section class=""esh-basket-item esh-basket-item--middle col-lg-3 hidden-lg-down"">
                                <img class=""esh-basket-image""");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1274, "\"", 1296, 1);
#line 32 "C:\Users\mindaugas.kazukauska\Desktop\New folder (4)\eShopOnWeb-master\eShopOnWeb-master\src\Web\Views\Basket\Index.cshtml"
WriteAttributeValue("", 1280, item.PictureUrl, 1280, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1297, 137, true);
                WriteLiteral(" />\n                            </section>\n                            <section class=\"esh-basket-item esh-basket-item--middle col-xs-3\">");
                EndContext();
                BeginContext(1435, 16, false);
#line 34 "C:\Users\mindaugas.kazukauska\Desktop\New folder (4)\eShopOnWeb-master\eShopOnWeb-master\src\Web\Views\Basket\Index.cshtml"
                                                                                         Write(item.ProductName);

#line default
#line hidden
                EndContext();
                BeginContext(1451, 107, true);
                WriteLiteral("</section>\n                            <section class=\"esh-basket-item esh-basket-item--middle col-xs-2\">$ ");
                EndContext();
                BeginContext(1559, 29, false);
#line 35 "C:\Users\mindaugas.kazukauska\Desktop\New folder (4)\eShopOnWeb-master\eShopOnWeb-master\src\Web\Views\Basket\Index.cshtml"
                                                                                           Write(item.UnitPrice.ToString("N2"));

#line default
#line hidden
                EndContext();
                BeginContext(1588, 158, true);
                WriteLiteral("</section>\n                            <section class=\"esh-basket-item esh-basket-item--middle col-xs-2\">\n                                <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 1746, "\"", 1778, 1);
#line 37 "C:\Users\mindaugas.kazukauska\Desktop\New folder (4)\eShopOnWeb-master\eShopOnWeb-master\src\Web\Views\Basket\Index.cshtml"
WriteAttributeValue("", 1753, "Items[" + i + "].Key", 1753, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1779, "\"", 1795, 1);
#line 37 "C:\Users\mindaugas.kazukauska\Desktop\New folder (4)\eShopOnWeb-master\eShopOnWeb-master\src\Web\Views\Basket\Index.cshtml"
WriteAttributeValue("", 1787, item.Id, 1787, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1796, 89, true);
                WriteLiteral(" />\n                                <input type=\"number\" class=\"esh-basket-input\" min=\"1\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 1885, "\"", 1919, 1);
#line 38 "C:\Users\mindaugas.kazukauska\Desktop\New folder (4)\eShopOnWeb-master\eShopOnWeb-master\src\Web\Views\Basket\Index.cshtml"
WriteAttributeValue("", 1892, "Items[" + i + "].Value", 1892, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1920, "\"", 1942, 1);
#line 38 "C:\Users\mindaugas.kazukauska\Desktop\New folder (4)\eShopOnWeb-master\eShopOnWeb-master\src\Web\Views\Basket\Index.cshtml"
WriteAttributeValue("", 1928, item.Quantity, 1928, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1943, 161, true);
                WriteLiteral(" />\n                            </section>\n                            <section class=\"esh-basket-item esh-basket-item--middle esh-basket-item--mark col-xs-2\">$ ");
                EndContext();
                BeginContext(2105, 60, false);
#line 40 "C:\Users\mindaugas.kazukauska\Desktop\New folder (4)\eShopOnWeb-master\eShopOnWeb-master\src\Web\Views\Basket\Index.cshtml"
                                                                                                                 Write(Math.Round(item.Quantity * item.UnitPrice, 2).ToString("N2"));

#line default
#line hidden
                EndContext();
                BeginContext(2165, 147, true);
                WriteLiteral("</section>\n                        </div>\n                        <div class=\"row\">\n\n                        </div>\n                    </article>\n");
                EndContext();
                BeginContext(2452, 578, true);
                WriteLiteral(@"                    <div class=""container"">
                        <article class=""esh-basket-titles esh-basket-titles--clean row"">
                            <section class=""esh-basket-title col-xs-10""></section>
                            <section class=""esh-basket-title col-xs-2"">Total</section>
                        </article>

                        <article class=""esh-basket-items row"">
                            <section class=""esh-basket-item col-xs-10""></section>
                            <section class=""esh-basket-item esh-basket-item--mark col-xs-2"">$ ");
                EndContext();
                BeginContext(3031, 13, false);
#line 58 "C:\Users\mindaugas.kazukauska\Desktop\New folder (4)\eShopOnWeb-master\eShopOnWeb-master\src\Web\Views\Basket\Index.cshtml"
                                                                                         Write(Model.Total());

#line default
#line hidden
                EndContext();
                BeginContext(3044, 262, true);
                WriteLiteral(@"</section>
                        </article>

                        <article class=""esh-basket-items row"">
                            <section class=""esh-basket-item col-xs-7""></section>
                            <section class=""esh-basket-item col-xs-2"">
");
                EndContext();
                BeginContext(3437, 101, true);
                WriteLiteral("                            </section>\n                        </article>\n                    </div>\n");
                EndContext();
#line 68 "C:\Users\mindaugas.kazukauska\Desktop\New folder (4)\eShopOnWeb-master\eShopOnWeb-master\src\Web\Views\Basket\Index.cshtml"
                }

#line default
#line hidden
                BeginContext(3556, 93, true);
                WriteLiteral("                <section class=\"esh-basket-item col-xs-push-8 col-xs-4\">\n                    ");
                EndContext();
                BeginContext(3649, 149, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e6532ccb1ac45deb9f703ea4a699b41", async() => {
                    BeginContext(3779, 10, true);
                    WriteLiteral("[ Update ]");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3798, 21, true);
                WriteLiteral("\n                    ");
                EndContext();
                BeginContext(3819, 166, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0f30cbacecb145efb38caccf80629d85", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3985, 56, true);
                WriteLiteral("\n                </section>\n\n            </div>\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4048, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 79 "C:\Users\mindaugas.kazukauska\Desktop\New folder (4)\eShopOnWeb-master\eShopOnWeb-master\src\Web\Views\Basket\Index.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(4070, 88, true);
            WriteLiteral("        <div class=\"esh-catalog-items row\">\n            Basket is empty.\n        </div>\n");
            EndContext();
#line 85 "C:\Users\mindaugas.kazukauska\Desktop\New folder (4)\eShopOnWeb-master\eShopOnWeb-master\src\Web\Views\Basket\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(4164, 7, true);
            WriteLiteral("</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BasketViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591