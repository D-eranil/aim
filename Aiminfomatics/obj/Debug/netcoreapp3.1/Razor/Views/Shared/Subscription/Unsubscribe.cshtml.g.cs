#pragma checksum "C:\inetpub\wwwroot\AiminfomaticsK13C\Aiminfomatics\Views\Shared\Subscription\Unsubscribe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c1deac0f928809a2b751d086f6ffc7be5242718"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Subscription_Unsubscribe), @"mvc.1.0.view", @"/Views/Shared/Subscription/Unsubscribe.cshtml")]
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
#line 7 "C:\inetpub\wwwroot\AiminfomaticsK13C\Aiminfomatics\Views\_ViewImports.cshtml"
using Kentico.PageBuilder.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\inetpub\wwwroot\AiminfomaticsK13C\Aiminfomatics\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c1deac0f928809a2b751d086f6ffc7be5242718", @"/Views/Shared/Subscription/Unsubscribe.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c961128636d5e4e1ffecd1756816a0c304d52fb4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Subscription_Unsubscribe : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Aiminfomatics.Models.UnsubscriptionModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\inetpub\wwwroot\AiminfomaticsK13C\Aiminfomatics\Views\Shared\Subscription\Unsubscribe.cshtml"
  
    ViewBag.Title = HtmlLocalizer["Newsletter unsubscription"];
    ViewData["PageClass"] = "inverted";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"row text-and-image\">\r\n    <div class=\"col-md-6\">\r\n        <div class=\"text-and-image-text\">\r\n            <img class=\"img-responsive\"");
            BeginWriteAttribute("src", " src=\"", 312, "\"", 364, 1);
#nullable restore
#line 10 "C:\inetpub\wwwroot\AiminfomaticsK13C\Aiminfomatics\Views\Shared\Subscription\Unsubscribe.cshtml"
WriteAttributeValue("", 318, Url.Content("~/Content/Images/empty_cup.jpg"), 318, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </div>\r\n    </div>\r\n    <div class=\"col-md-6\">\r\n        <h2>");
#nullable restore
#line 14 "C:\inetpub\wwwroot\AiminfomaticsK13C\Aiminfomatics\Views\Shared\Subscription\Unsubscribe.cshtml"
       Write(HtmlLocalizer[ViewData.ModelState.IsValid ? "Goodbye!" : "Oops!"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <p>\r\n            <span class=\"InfoLabel\">\r\n");
#nullable restore
#line 17 "C:\inetpub\wwwroot\AiminfomaticsK13C\Aiminfomatics\Views\Shared\Subscription\Unsubscribe.cshtml"
                 if (!string.IsNullOrEmpty(Model.UnsubscriptionResult))
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\inetpub\wwwroot\AiminfomaticsK13C\Aiminfomatics\Views\Shared\Subscription\Unsubscribe.cshtml"
               Write(Model.UnsubscriptionResult);

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\inetpub\wwwroot\AiminfomaticsK13C\Aiminfomatics\Views\Shared\Subscription\Unsubscribe.cshtml"
                                               
                }
                else
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\inetpub\wwwroot\AiminfomaticsK13C\Aiminfomatics\Views\Shared\Subscription\Unsubscribe.cshtml"
               Write(Html.ValidationMessage("ErrorMessage"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\inetpub\wwwroot\AiminfomaticsK13C\Aiminfomatics\Views\Shared\Subscription\Unsubscribe.cshtml"
                                                           ;
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </span>\r\n</p>\r\n    </div>\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Aiminfomatics.Models.UnsubscriptionModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
