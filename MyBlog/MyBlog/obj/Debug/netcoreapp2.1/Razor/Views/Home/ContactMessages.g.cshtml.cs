#pragma checksum "C:\Projects\GitHub\MyBlog\MyBlog\MyBlog\Views\Home\ContactMessages.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0079c158ff76700fbf2bf75a87c116200ff4d55e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ContactMessages), @"mvc.1.0.view", @"/Views/Home/ContactMessages.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ContactMessages.cshtml", typeof(AspNetCore.Views_Home_ContactMessages))]
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
#line 1 "C:\Projects\GitHub\MyBlog\MyBlog\MyBlog\Views\_ViewImports.cshtml"
using MyBlog.Models;

#line default
#line hidden
#line 2 "C:\Projects\GitHub\MyBlog\MyBlog\MyBlog\Views\_ViewImports.cshtml"
using MyBlog.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0079c158ff76700fbf2bf75a87c116200ff4d55e", @"/Views/Home/ContactMessages.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a4e835f177646c50001bddac7fa7bb46f526002", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ContactMessages : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ContactMessagesViewModelcs>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/contactMessages.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Projects\GitHub\MyBlog\MyBlog\MyBlog\Views\Home\ContactMessages.cshtml"
  
	ViewBag.Title = "Contact Messages";

#line default
#line hidden
            BeginContext(80, 193, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44bae786215246a1b39bd94e8f87cea5", async() => {
                BeginContext(86, 66, true);
                WriteLiteral("\r\n\t<meta name=\"viewport\" content=\"width=device-width\" />\r\n\t<title>");
                EndContext();
                BeginContext(153, 13, false);
#line 7 "C:\Projects\GitHub\MyBlog\MyBlog\MyBlog\Views\Home\ContactMessages.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
                EndContext();
                BeginContext(166, 38, true);
                WriteLiteral("</title>\r\n\t<meta charset=\"utf-8\" />\r\n\t");
                EndContext();
                BeginContext(204, 58, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0facc87c8018401db508b1bbf10cee5c", async() => {
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
                BeginContext(262, 4, true);
                WriteLiteral("\r\n\r\n");
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
            BeginContext(273, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 13 "C:\Projects\GitHub\MyBlog\MyBlog\MyBlog\Views\Home\ContactMessages.cshtml"
 if (Model != null)
{
	foreach (var message in Model.Message)
	{

#line default
#line hidden
            BeginContext(346, 108, true);
            WriteLiteral("\t\t<div class=\"row\">\r\n\t\t\t<div class=\"leftcolumn\">\r\n\t\t\t\t<div class=\"card\">\r\n\t\t\t\t\t<h1>Nickname:</h1>\r\n\t\t\t\t\t<h2>");
            EndContext();
            BeginContext(455, 16, false);
#line 21 "C:\Projects\GitHub\MyBlog\MyBlog\MyBlog\Views\Home\ContactMessages.cshtml"
                   Write(message.Nickname);

#line default
#line hidden
            EndContext();
            BeginContext(471, 38, true);
            WriteLiteral("</h2>\r\n\t\t\t\t\t<h2>ID:</h2>\r\n\t\t\t\t\t<p>Id: ");
            EndContext();
            BeginContext(510, 10, false);
#line 23 "C:\Projects\GitHub\MyBlog\MyBlog\MyBlog\Views\Home\ContactMessages.cshtml"
                      Write(message.Id);

#line default
#line hidden
            EndContext();
            BeginContext(520, 58, true);
            WriteLiteral("</p>\r\n\t\t\t\t\t<hr />\r\n\t\t\t\t\t<h2>E-mail:</h2>\r\n\t\t\t\t\t<p>\r\n\t\t\t\t\t\t");
            EndContext();
            BeginContext(579, 13, false);
#line 27 "C:\Projects\GitHub\MyBlog\MyBlog\MyBlog\Views\Home\ContactMessages.cshtml"
                   Write(message.Email);

#line default
#line hidden
            EndContext();
            BeginContext(592, 63, true);
            WriteLiteral("\r\n\t\t\t\t\t</p>\r\n\t\t\t\t\t<hr />\r\n\t\t\t\t\t<h2>Description:</h2>\r\n\t\t\t\t\t<p> ");
            EndContext();
            BeginContext(656, 19, false);
#line 31 "C:\Projects\GitHub\MyBlog\MyBlog\MyBlog\Views\Home\ContactMessages.cshtml"
                   Write(message.Description);

#line default
#line hidden
            EndContext();
            BeginContext(675, 39, true);
            WriteLiteral("</p>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n");
            EndContext();
#line 35 "C:\Projects\GitHub\MyBlog\MyBlog\MyBlog\Views\Home\ContactMessages.cshtml"
	}
}

#line default
#line hidden
            BeginContext(721, 17, true);
            WriteLiteral("\t\t<hr />\r\n<div>\r\n");
            EndContext();
            DefineSection("footer", async() => {
                BeginContext(755, 91, true);
                WriteLiteral("\r\n\t\t<div class=\"footer\">\r\n\t\t\t<h3>&copy; Website made by Dawid Gorla 2018.</h3>\r\n\t\t</div>\r\n\t");
                EndContext();
            }
            );
            BeginContext(849, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContactMessagesViewModelcs> Html { get; private set; }
    }
}
#pragma warning restore 1591
