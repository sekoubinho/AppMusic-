#pragma checksum "C:\Users\sekou\Documents\288405-AppMusic-ASP\Preject2netAsp\Preject2netAsp\Views\Register\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3cb861b7eefbd4cd32b757ba6a49ad2880c3462f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Register_Register), @"mvc.1.0.view", @"/Views/Register/Register.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Register/Register.cshtml", typeof(AspNetCore.Views_Register_Register))]
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
#line 1 "C:\Users\sekou\Documents\288405-AppMusic-ASP\Preject2netAsp\Preject2netAsp\Views\_ViewImports.cshtml"
using Preject2netAsp;

#line default
#line hidden
#line 2 "C:\Users\sekou\Documents\288405-AppMusic-ASP\Preject2netAsp\Preject2netAsp\Views\_ViewImports.cshtml"
using Preject2netAsp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cb861b7eefbd4cd32b757ba6a49ad2880c3462f", @"/Views/Register/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b06193186cc34e6bda1d5b07faba4f99fae7f449", @"/Views/_ViewImports.cshtml")]
    public class Views_Register_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Preject2netAsp.Models.Users>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/register.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/RegisterJs.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\sekou\Documents\288405-AppMusic-ASP\Preject2netAsp\Preject2netAsp\Views\Register\Register.cshtml"
  
    ViewData["Title"] = "Register";

#line default
#line hidden
            BeginContext(82, 23, true);
            WriteLiteral("\r\n<h2>Register</h2>\r\n\r\n");
            EndContext();
            BeginContext(105, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1c7cd9de84844c61a3a40ccacb34b1b3", async() => {
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
            BeginContext(156, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(160, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88461c0953b04c3384504f72e96b95b2", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(202, 20, true);
            WriteLiteral("\r\n\r\n\r\n\r\n  \r\n        ");
            EndContext();
            BeginContext(222, 1099, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ec80529358f4268b0923c91071e8caf", async() => {
                BeginContext(251, 1063, true);
                WriteLiteral(@"
            <label>
                <label for=""FirstName""> </label>
                <p class=""label-txt"" for=""FirstName"">Enter your FirstName:</p>
                <input type=""text"" name=""FirstName"" id=""FirstName"" required class=""input"">
                <div class=""line-box"">
                    <div class=""line""></div>
                </div>
            </label>
            <label>
                <p class=""label-txt"" for=""LastName"">Enter your LastName:</p>
                <input type=""text"" name=""LastName"" id=""LastName"" required class=""input"">
                <div class=""line-box"">
                    <div class=""line""></div>
                </div>

            </label>

            <label>

                <p class=""label-txt"">Enter your Email:</p>
                <input type=""email"" name=""Email"" id=""Email"" required class=""input"">
                <div class=""line-box"">
                    <div class=""line""></div>
                </div>
            </label>
            <button ty");
                WriteLiteral("pe=\"submit\">Register</button>\r\n\r\n\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1321, 10, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
            EndContext();
#line 50 "C:\Users\sekou\Documents\288405-AppMusic-ASP\Preject2netAsp\Preject2netAsp\Views\Register\Register.cshtml"
 if (!ViewData.ModelState.IsValid && ViewData.ModelState["Error"].Errors.Count > 0)
{

#line default
#line hidden
            BeginContext(1419, 70, true);
            WriteLiteral("    <div class=\"alert alert-<strong>Error!</strong> danger\">\r\n        ");
            EndContext();
            BeginContext(1490, 56, false);
#line 53 "C:\Users\sekou\Documents\288405-AppMusic-ASP\Preject2netAsp\Preject2netAsp\Views\Register\Register.cshtml"
   Write(ViewData.ModelState["Error"].Errors.First().ErrorMessage);

#line default
#line hidden
            EndContext();
            BeginContext(1546, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 55 "C:\Users\sekou\Documents\288405-AppMusic-ASP\Preject2netAsp\Preject2netAsp\Views\Register\Register.cshtml"
}

#line default
#line hidden
            BeginContext(1563, 33, true);
            WriteLiteral("<script type=\"text/javascript\">\r\n");
            EndContext();
#line 57 "C:\Users\sekou\Documents\288405-AppMusic-ASP\Preject2netAsp\Preject2netAsp\Views\Register\Register.cshtml"
         if (!ViewData.ModelState.IsValid && ViewData.ModelState["Error"].Errors.Count > 0)
        {
            

#line default
#line hidden
            BeginContext(1718, 69, true);
            WriteLiteral("\r\n            $(document).ready(function() {\r\n                alert(\'");
            EndContext();
            BeginContext(1788, 56, false);
#line 61 "C:\Users\sekou\Documents\288405-AppMusic-ASP\Preject2netAsp\Preject2netAsp\Views\Register\Register.cshtml"
                  Write(ViewData.ModelState["Error"].Errors.First().ErrorMessage);

#line default
#line hidden
            EndContext();
            BeginContext(1844, 34, true);
            WriteLiteral("\');\r\n            });\r\n            ");
            EndContext();
#line 63 "C:\Users\sekou\Documents\288405-AppMusic-ASP\Preject2netAsp\Preject2netAsp\Views\Register\Register.cshtml"
                   
        }

#line default
#line hidden
            BeginContext(1898, 19, true);
            WriteLiteral("</script>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Preject2netAsp.Models.Users> Html { get; private set; }
    }
}
#pragma warning restore 1591
