#pragma checksum "C:\Users\Berkan Çep\Desktop\Folders\Works\Projeler\Tabim_Core\RequestApplication\RequestApplication.WebUI\Views\Request\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5edf0951e27a041ed7b33ac88c4095df226b8b49"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Request_List), @"mvc.1.0.view", @"/Views/Request/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5edf0951e27a041ed7b33ac88c4095df226b8b49", @"/Views/Request/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"880b96dfde1a0a29a429da79ccd78b44aa1814fd", @"/Views/_ViewImports.cshtml")]
    public class Views_Request_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RequestListViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Request", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success mb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Berkan Çep\Desktop\Folders\Works\Projeler\Tabim_Core\RequestApplication\RequestApplication.WebUI\Views\Request\List.cshtml"
  
    ViewData["Title"] = "List";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Taleplerim</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5edf0951e27a041ed7b33ac88c4095df226b8b495181", async() => {
                WriteLiteral("Talep Ekle");
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
            WriteLiteral("\r\n\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n\r\n");
#nullable restore
#line 13 "C:\Users\Berkan Çep\Desktop\Folders\Works\Projeler\Tabim_Core\RequestApplication\RequestApplication.WebUI\Views\Request\List.cshtml"
         if (Model.Count() > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <table class=""table table-hover"">
                <thead>
                    <tr>
                        <th>Başlık</th>
                        <th>Talep Tarihi</th>
                        <th>Değerlendirme Tarihi</th>
                        <th>Durum</th>
                        <th>İşlemler</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 26 "C:\Users\Berkan Çep\Desktop\Folders\Works\Projeler\Tabim_Core\RequestApplication\RequestApplication.WebUI\Views\Request\List.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 29 "C:\Users\Berkan Çep\Desktop\Folders\Works\Projeler\Tabim_Core\RequestApplication\RequestApplication.WebUI\Views\Request\List.cshtml"
                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 30 "C:\Users\Berkan Çep\Desktop\Folders\Works\Projeler\Tabim_Core\RequestApplication\RequestApplication.WebUI\Views\Request\List.cshtml"
                           Write(item.RequestDate.ToString("dd/MM/yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n");
#nullable restore
#line 32 "C:\Users\Berkan Çep\Desktop\Folders\Works\Projeler\Tabim_Core\RequestApplication\RequestApplication.WebUI\Views\Request\List.cshtml"
                                 if (item.ReplyDate == null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p>Cevaplanmadı</p>\r\n");
#nullable restore
#line 35 "C:\Users\Berkan Çep\Desktop\Folders\Works\Projeler\Tabim_Core\RequestApplication\RequestApplication.WebUI\Views\Request\List.cshtml"
                                }
                                else
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\Berkan Çep\Desktop\Folders\Works\Projeler\Tabim_Core\RequestApplication\RequestApplication.WebUI\Views\Request\List.cshtml"
                               Write(Convert.ToDateTime(item.ReplyDate).ToString("dd/MM/yyyy HH:mm"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\Berkan Çep\Desktop\Folders\Works\Projeler\Tabim_Core\RequestApplication\RequestApplication.WebUI\Views\Request\List.cshtml"
                                                                                                    
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n                            <td>\r\n");
#nullable restore
#line 42 "C:\Users\Berkan Çep\Desktop\Folders\Works\Projeler\Tabim_Core\RequestApplication\RequestApplication.WebUI\Views\Request\List.cshtml"
                                 if (item.IsPositive != null)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\Berkan Çep\Desktop\Folders\Works\Projeler\Tabim_Core\RequestApplication\RequestApplication.WebUI\Views\Request\List.cshtml"
                                     if ((bool)item.IsPositive)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <i class=\"fas fa-check-circle\"></i>\r\n");
#nullable restore
#line 47 "C:\Users\Berkan Çep\Desktop\Folders\Works\Projeler\Tabim_Core\RequestApplication\RequestApplication.WebUI\Views\Request\List.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <i class=\"fas fa-times-circle\"></i>\r\n");
#nullable restore
#line 51 "C:\Users\Berkan Çep\Desktop\Folders\Works\Projeler\Tabim_Core\RequestApplication\RequestApplication.WebUI\Views\Request\List.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\Berkan Çep\Desktop\Folders\Works\Projeler\Tabim_Core\RequestApplication\RequestApplication.WebUI\Views\Request\List.cshtml"
                                     
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p>Beklemede</p>\r\n");
#nullable restore
#line 56 "C:\Users\Berkan Çep\Desktop\Folders\Works\Projeler\Tabim_Core\RequestApplication\RequestApplication.WebUI\Views\Request\List.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5edf0951e27a041ed7b33ac88c4095df226b8b4912314", async() => {
                WriteLiteral("Detay");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "C:\Users\Berkan Çep\Desktop\Folders\Works\Projeler\Tabim_Core\RequestApplication\RequestApplication.WebUI\Views\Request\List.cshtml"
                                                                                   WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n\r\n                        </tr>\r\n");
#nullable restore
#line 64 "C:\Users\Berkan Çep\Desktop\Folders\Works\Projeler\Tabim_Core\RequestApplication\RequestApplication.WebUI\Views\Request\List.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n");
#nullable restore
#line 67 "C:\Users\Berkan Çep\Desktop\Folders\Works\Projeler\Tabim_Core\RequestApplication\RequestApplication.WebUI\Views\Request\List.cshtml"
        }

        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-danger\">\r\n                Henüz eklenmiş talebiniz bulunmamaktadır.\r\n            </div>\r\n");
#nullable restore
#line 74 "C:\Users\Berkan Çep\Desktop\Folders\Works\Projeler\Tabim_Core\RequestApplication\RequestApplication.WebUI\Views\Request\List.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RequestListViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
