#pragma checksum "C:\Users\Peter\Desktop\Programming\C#\Party Invites\Party Invites\Views\Home\ListResponses.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "461bb746791a919fd87276a4199ffd4a3a59f002"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ListResponses), @"mvc.1.0.view", @"/Views/Home/ListResponses.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ListResponses.cshtml", typeof(AspNetCore.Views_Home_ListResponses))]
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
#line 1 "C:\Users\Peter\Desktop\Programming\C#\Party Invites\Party Invites\Views\_ViewImports.cshtml"
using Party_Invites;

#line default
#line hidden
#line 2 "C:\Users\Peter\Desktop\Programming\C#\Party Invites\Party Invites\Views\_ViewImports.cshtml"
using Party_Invites.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"461bb746791a919fd87276a4199ffd4a3a59f002", @"/Views/Home/ListResponses.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea970a9ec977bd090530a11aa83b192f90a28a41", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ListResponses : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Party_Invites.Models.GuestResponse>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Peter\Desktop\Programming\C#\Party Invites\Party Invites\Views\Home\ListResponses.cshtml"
   
    Layout = null;

#line default
#line hidden
            BeginContext(79, 66, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n");
            EndContext();
            BeginContext(145, 189, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5486246b73884598bf7a52e4e42bab68", async() => {
                BeginContext(151, 65, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    ");
                EndContext();
                BeginContext(216, 71, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "86569c1f33ad4f1daab0bac8bd196c78", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(287, 40, true);
                WriteLiteral("\r\n    <title>Lista uczestników</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(334, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(336, 640, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1fe1e31ad0144ff79dfd5fbe08b0733c", async() => {
                BeginContext(342, 349, true);
                WriteLiteral(@"
    <h2>Lista gości, którzy zadeklarowali swoje przyjście na imprezę:</h2>

    <table class=""table table-striped table-bordered"">
        <thread>
            <tr>
                <th>Imię i nazwisko</th>
                <th>Adres e-mail</th>
                <th>Numer telefony</th>
            </tr>
        </thread>
        <tbody>
");
                EndContext();
#line 27 "C:\Users\Peter\Desktop\Programming\C#\Party Invites\Party Invites\Views\Home\ListResponses.cshtml"
             foreach (var guest in Model)
            {

#line default
#line hidden
                BeginContext(749, 46, true);
                WriteLiteral("                <tr>\r\n                    <td>");
                EndContext();
                BeginContext(796, 10, false);
#line 30 "C:\Users\Peter\Desktop\Programming\C#\Party Invites\Party Invites\Views\Home\ListResponses.cshtml"
                   Write(guest.Name);

#line default
#line hidden
                EndContext();
                BeginContext(806, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(838, 11, false);
#line 31 "C:\Users\Peter\Desktop\Programming\C#\Party Invites\Party Invites\Views\Home\ListResponses.cshtml"
                   Write(guest.Email);

#line default
#line hidden
                EndContext();
                BeginContext(849, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(881, 11, false);
#line 32 "C:\Users\Peter\Desktop\Programming\C#\Party Invites\Party Invites\Views\Home\ListResponses.cshtml"
                   Write(guest.Phone);

#line default
#line hidden
                EndContext();
                BeginContext(892, 30, true);
                WriteLiteral("</td>\r\n                </tr>\r\n");
                EndContext();
#line 34 "C:\Users\Peter\Desktop\Programming\C#\Party Invites\Party Invites\Views\Home\ListResponses.cshtml"
            }

#line default
#line hidden
                BeginContext(937, 32, true);
                WriteLiteral("        </tbody>\r\n    </table>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(976, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Party_Invites.Models.GuestResponse>> Html { get; private set; }
    }
}
#pragma warning restore 1591
