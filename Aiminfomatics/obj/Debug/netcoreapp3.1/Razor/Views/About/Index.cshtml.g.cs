#pragma checksum "C:\inetpub\wwwroot\AiminfomaticsK13C\Aiminfomatics\Views\About\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fef4109cd4caee297b5bca36734f2e9b307e4383"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Index), @"mvc.1.0.view", @"/Views/About/Index.cshtml")]
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
#line 1 "C:\inetpub\wwwroot\AiminfomaticsK13C\Aiminfomatics\Views\_ViewImports.cshtml"
using Aiminfomatics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\inetpub\wwwroot\AiminfomaticsK13C\Aiminfomatics\Views\_ViewImports.cshtml"
using CMS.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\inetpub\wwwroot\AiminfomaticsK13C\Aiminfomatics\Views\_ViewImports.cshtml"
using Kentico.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\inetpub\wwwroot\AiminfomaticsK13C\Aiminfomatics\Views\_ViewImports.cshtml"
using Kentico.Content.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\inetpub\wwwroot\AiminfomaticsK13C\Aiminfomatics\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\inetpub\wwwroot\AiminfomaticsK13C\Aiminfomatics\Views\About\Index.cshtml"
using Aiminfomatics.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\inetpub\wwwroot\AiminfomaticsK13C\Aiminfomatics\Views\About\Index.cshtml"
using Kentico.PageBuilder.Web.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fef4109cd4caee297b5bca36734f2e9b307e4383", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c961128636d5e4e1ffecd1756816a0c304d52fb4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Aiminfomatics.Models.AboutIndexViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Home"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/About"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Kentico.Content.Web.Mvc.PageBuilderStylesTagHelper __Kentico_Content_Web_Mvc_PageBuilderStylesTagHelper;
        private global::Kentico.Content.Web.Mvc.PageBuilderScriptsTagHelper __Kentico_Content_Web_Mvc_PageBuilderScriptsTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\inetpub\wwwroot\AiminfomaticsK13C\Aiminfomatics\Views\About\Index.cshtml"
  
    ViewData["Title"] = HtmlLocalizer["Home"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("styles", async() => {
                WriteLiteral("\r\n");
                WriteLiteral("    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("page-builder-styles", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fef4109cd4caee297b5bca36734f2e9b307e43835473", async() => {
                }
                );
                __Kentico_Content_Web_Mvc_PageBuilderStylesTagHelper = CreateTagHelper<global::Kentico.Content.Web.Mvc.PageBuilderStylesTagHelper>();
                __tagHelperExecutionContext.Add(__Kentico_Content_Web_Mvc_PageBuilderStylesTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n");
                WriteLiteral("    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("page-builder-scripts", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fef4109cd4caee297b5bca36734f2e9b307e43836606", async() => {
                }
                );
                __Kentico_Content_Web_Mvc_PageBuilderScriptsTagHelper = CreateTagHelper<global::Kentico.Content.Web.Mvc.PageBuilderScriptsTagHelper>();
                __tagHelperExecutionContext.Add(__Kentico_Content_Web_Mvc_PageBuilderScriptsTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n");
#nullable restore
#line 22 "C:\inetpub\wwwroot\AiminfomaticsK13C\Aiminfomatics\Views\About\Index.cshtml"
 foreach (var aboutSection in Model.AboutSections)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"inr_banr\">\r\n      <div class=\"container\">\r\n        <div class=\"banner_ttl\">");
#nullable restore
#line 26 "C:\inetpub\wwwroot\AiminfomaticsK13C\Aiminfomatics\Views\About\Index.cshtml"
                           Write(aboutSection.AboutUs);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div class=\"banner_txt\">");
#nullable restore
#line 27 "C:\inetpub\wwwroot\AiminfomaticsK13C\Aiminfomatics\Views\About\Index.cshtml"
                           Write(aboutSection.AboutSatisfaction);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n      </div>\r\n    </div>\r\n    <div class=\"harki\">\r\n      <div class=\"container\">\r\n        <ul class=\"hrky\">\r\n          <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fef4109cd4caee297b5bca36734f2e9b307e43838682", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n          <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fef4109cd4caee297b5bca36734f2e9b307e43839774", async() => {
                WriteLiteral("> About Us");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n        </ul>\r\n      </div>\r\n    </div>\r\n  <section class=\"main_con\">\r\n    <div class=\"container\">\r\n      <div class=\"row\">    \r\n        <div class=\"span9\">\r\n           ");
#nullable restore
#line 42 "C:\inetpub\wwwroot\AiminfomaticsK13C\Aiminfomatics\Views\About\Index.cshtml"
      Write(Html.Kentico().ResolveUrls(aboutSection.AboutAimInfomatics));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n      </div>\r\n    </div>\r\n  </section>\r\n");
#nullable restore
#line 47 "C:\inetpub\wwwroot\AiminfomaticsK13C\Aiminfomatics\Views\About\Index.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHtmlLocalizer<SharedResources> HtmlLocalizer { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Aiminfomatics.Models.AboutIndexViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
