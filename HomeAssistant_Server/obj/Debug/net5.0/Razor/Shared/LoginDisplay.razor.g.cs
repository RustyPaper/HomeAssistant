#pragma checksum "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Shared\LoginDisplay.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3d2f26a9cd3e6960d31d887800f44f4c9a2e1313de2eda9cfba37003c73b3056"
// <auto-generated/>
#pragma warning disable 1591
namespace HomeAssistant_Server.Shared
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\_Imports.razor"
using System.Net.Http

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization

#nullable disable
    ;
#nullable restore
#line 3 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization

#nullable disable
    ;
#nullable restore
#line 4 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms

#nullable disable
    ;
#nullable restore
#line 5 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing

#nullable disable
    ;
#nullable restore
#line 6 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web

#nullable disable
    ;
#nullable restore
#line 7 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization

#nullable disable
    ;
#nullable restore
#line 8 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\_Imports.razor"
using Microsoft.JSInterop

#nullable disable
    ;
#nullable restore
#line 9 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\_Imports.razor"
using HomeAssistant_Server

#nullable disable
    ;
#nullable restore
#line 10 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\_Imports.razor"
using HomeAssistant_Server.Shared

#nullable disable
    ;
#nullable restore
#line 11 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\_Imports.razor"
using HomeAssistant_Server.Helper

#nullable disable
    ;
#nullable restore
#line 12 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\_Imports.razor"
using Blazored.TextEditor

#nullable disable
    ;
#nullable restore
#line 13 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\_Imports.razor"
using Radzen.Blazor

#line default
#line hidden
#nullable disable
    ;
    #nullable restore
    public partial class LoginDisplay : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "<a href=\"Identity/Account/Logout\" class=\"ml-1\">Logout</a>\r\n        <p></p>\r\n        Hello, ");
                __builder2.AddContent(3, 
#nullable restore
#line 6 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Shared\LoginDisplay.razor"
                context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
            }
            ));
            __builder.AddAttribute(4, "NotAuthorized", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "<a href=\"Identity/Account/Register\">Register</a>\r\n        ");
                __builder2.AddMarkupContent(6, "<a href=\"Identity/Account/Login\">Login</a>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
