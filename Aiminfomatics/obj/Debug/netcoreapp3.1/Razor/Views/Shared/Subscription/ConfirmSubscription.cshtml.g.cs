#pragma checksum "C:\inetpub\wwwroot\AiminfomaticsK13C\Aiminfomatics\Views\Shared\Subscription\ConfirmSubscription.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c71cb21a60444e5853e59f181a20f134cc2425d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Subscription_ConfirmSubscription), @"mvc.1.0.view", @"/Views/Shared/Subscription/ConfirmSubscription.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c71cb21a60444e5853e59f181a20f134cc2425d0", @"/Views/Shared/Subscription/ConfirmSubscription.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c961128636d5e4e1ffecd1756816a0c304d52fb4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Subscription_ConfirmSubscription : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Aiminfomatics.Models.ConfirmSubscriptionModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\inetpub\wwwroot\AiminfomaticsK13C\Aiminfomatics\Views\Shared\Subscription\ConfirmSubscription.cshtml"
  
    ViewBag.Title = HtmlLocalizer["Newsletter subscription"];
    ViewData["PageClass"] = "inverted";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<section class=\"row text-and-image\">\n    <div class=\"col-md-6\">\n        <div class=\"text-and-image-text\">\n            <img class=\"img-responsive\"");
            BeginWriteAttribute("src", " src=\"", 307, "\"", 433, 1);
#nullable restore
#line 10 "C:\inetpub\wwwroot\AiminfomaticsK13C\Aiminfomatics\Views\Shared\Subscription\ConfirmSubscription.cshtml"
WriteAttributeValue("", 313, Url.Content(ViewData.ModelState.IsValid ? "~/Content/Images/default-image-cafe.jpg" : "~/Content/Images/empty_cup.jpg"), 313, 120, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n        </div>\n    </div>\n    <div class=\"col-md-6\">\n        <h2>");
#nullable restore
#line 14 "C:\inetpub\wwwroot\AiminfomaticsK13C\Aiminfomatics\Views\Shared\Subscription\ConfirmSubscription.cshtml"
       Write(HtmlLocalizer[ViewData.ModelState.IsValid ? "Subscription confirmed" : "Subscription confirmation error"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n        <p>\n            <span class=\"InfoLabel\">\n");
#nullable restore
#line 17 "C:\inetpub\wwwroot\AiminfomaticsK13C\Aiminfomatics\Views\Shared\Subscription\ConfirmSubscription.cshtml"
                 if (ViewData.ModelState.IsValid)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\inetpub\wwwroot\AiminfomaticsK13C\Aiminfomatics\Views\Shared\Subscription\ConfirmSubscription.cshtml"
               Write(Model.ConfirmationResult);

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\inetpub\wwwroot\AiminfomaticsK13C\Aiminfomatics\Views\Shared\Subscription\ConfirmSubscription.cshtml"
                                             
                }
                else
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\inetpub\wwwroot\AiminfomaticsK13C\Aiminfomatics\Views\Shared\Subscription\ConfirmSubscription.cshtml"
               Write(Html.ValidationMessage("ErrorMessage"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\inetpub\wwwroot\AiminfomaticsK13C\Aiminfomatics\Views\Shared\Subscription\ConfirmSubscription.cshtml"
                                                           
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </span>\n        </p>\n    </div>\n</section>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Aiminfomatics.Models.ConfirmSubscriptionModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
