#pragma checksum "C:\Users\Berkan Çep\Desktop\Folders\Works\Projeler\Tabim_Core\RequestApplication\RequestApplication.WebUI\Views\Account\Completed.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ff427fa8aedcd897617f5e5234f6ddf72508f3a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Completed), @"mvc.1.0.view", @"/Views/Account/Completed.cshtml")]
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
#line 1 "C:\Users\Berkan Çep\Desktop\Folders\Works\Projeler\Tabim_Core\RequestApplication\RequestApplication.WebUI\Views\_ViewImports.cshtml"
using RequestApplication.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Berkan Çep\Desktop\Folders\Works\Projeler\Tabim_Core\RequestApplication\RequestApplication.WebUI\Views\_ViewImports.cshtml"
using RequestApplication.WebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ff427fa8aedcd897617f5e5234f6ddf72508f3a", @"/Views/Account/Completed.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"880b96dfde1a0a29a429da79ccd78b44aa1814fd", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Completed : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RegisterViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-lg mt-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\Berkan Çep\Desktop\Folders\Works\Projeler\Tabim_Core\RequestApplication\RequestApplication.WebUI\Views\Account\Completed.cshtml"
  
    ViewData["Title"] = "Completed";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""alert alert-success"" role=""alert"">
        <h4 class=""alert-heading"">Tebrikler!</h4>
        <p>Üyeliğinizi başarıyla oluşturduğunuz,artık talep oluşturabilirsiniz. Hemen yeni bir talep oluşturmak için bilgileriniz ile giriş yapın. <br />  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ff427fa8aedcd897617f5e5234f6ddf72508f3a4785", async() => {
                WriteLiteral("Giriş Yap");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" </p>\r\n        <hr>\r\n        <dl class=\"dl-horizontal m-1 p-1\">\r\n            <dt>Ad Soyad</dt>\r\n            <dd>");
#nullable restore
#line 12 "C:\Users\Berkan Çep\Desktop\Folders\Works\Projeler\Tabim_Core\RequestApplication\RequestApplication.WebUI\Views\Account\Completed.cshtml"
           Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n            <dt>Eposta</dt>\r\n            <dd>");
#nullable restore
#line 15 "C:\Users\Berkan Çep\Desktop\Folders\Works\Projeler\Tabim_Core\RequestApplication\RequestApplication.WebUI\Views\Account\Completed.cshtml"
           Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n            <dt>Telefon</dt>\r\n            <dd>");
#nullable restore
#line 18 "C:\Users\Berkan Çep\Desktop\Folders\Works\Projeler\Tabim_Core\RequestApplication\RequestApplication.WebUI\Views\Account\Completed.cshtml"
           Write(Model.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n        </dl>\r\n    </div>  \r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
