#pragma checksum "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Areas\Identity\Pages\Account\AccessDenied.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7d1ee7d383eb0cfe7144d80f95ef3f01b7ed1662c5a1992fcf2afa0699af0273"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_AccessDenied), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/AccessDenied.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Areas\Identity\Pages\_ViewImports.cshtml"
using HomeAssistant_Server.Areas.Identity

#nullable disable
    ;
#nullable restore
#line 3 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Areas\Identity\Pages\_ViewImports.cshtml"
using HomeAssistant_Server.Areas.Identity.Pages

#nullable disable
    ;
#nullable restore
#line 1 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using HomeAssistant_Server.Areas.Identity.Pages.Account

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"7d1ee7d383eb0cfe7144d80f95ef3f01b7ed1662c5a1992fcf2afa0699af0273", @"/Areas/Identity/Pages/Account/AccessDenied.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"8fcaec75a685065197bdc3600244a231a1f835b9a3220ba0caaf4232ee8a786d", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"97a016ebd16177b3ce2d3d0692119f1258ebba39b9f3ae3c5267384484801bf2", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Identity_Pages_Account_AccessDenied : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Areas\Identity\Pages\Account\AccessDenied.cshtml"
  
    ViewData["Title"] = "Access denied";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<header>\r\n    <h1 class=\"text-danger\">");
            Write(
#nullable restore
#line 8 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Areas\Identity\Pages\Account\AccessDenied.cshtml"
                             ViewData["Title"]

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h1>\r\n    <p class=\"text-danger\">You do not have access to this resource.</p>\r\n</header>\r\n");
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AccessDeniedModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AccessDeniedModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AccessDeniedModel>)PageContext?.ViewData;
        public AccessDeniedModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
