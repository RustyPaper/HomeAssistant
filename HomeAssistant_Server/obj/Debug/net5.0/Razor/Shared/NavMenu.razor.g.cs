#pragma checksum "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Shared\NavMenu.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "dc25d63f94bc469e27384df45e45f82409ddb5dfba96f45ce29d36445695353d"
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
    public partial class NavMenu : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddAttribute(2, "b-l7wq33aqvg");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href b-l7wq33aqvg>HomeAssistant_Server</a>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "b-l7wq33aqvg");
            __builder.AddMarkupContent(8, "<span class=\"navbar-toggler-icon\" b-l7wq33aqvg></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", 
#nullable restore
#line 8 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "b-l7wq33aqvg");
            __builder.OpenElement(14, "ul");
            __builder.AddAttribute(15, "class", "nav flex-column");
            __builder.AddAttribute(16, "b-l7wq33aqvg");
            __builder.OpenElement(17, "li");
            __builder.AddAttribute(18, "class", "nav-item px-3");
            __builder.AddAttribute(19, "b-l7wq33aqvg");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(20);
            __builder.AddAttribute(21, "class", (object)("nav-link"));
            __builder.AddAttribute(22, "href", (object)("home-apartament"));
            __builder.AddAttribute(23, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(24, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-l7wq33aqvg></span> Home Apartaments\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.OpenElement(26, "li");
            __builder.AddAttribute(27, "class", "nav-item px-3");
            __builder.AddAttribute(28, "b-l7wq33aqvg");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(29);
            __builder.AddAttribute(30, "class", (object)("nav-link"));
            __builder.AddAttribute(31, "href", (object)("home-amenity"));
            __builder.AddAttribute(32, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(33, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-l7wq33aqvg></span> Home Amenities\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n        ");
            __builder.OpenElement(35, "li");
            __builder.AddAttribute(36, "class", "nav-item px-3");
            __builder.AddAttribute(37, "b-l7wq33aqvg");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(38);
            __builder.AddAttribute(39, "class", (object)("nav-link"));
            __builder.AddAttribute(40, "href", (object)("apartament-bookings"));
            __builder.AddAttribute(41, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(42, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-l7wq33aqvg></span> Bookings\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable

    }
}
#pragma warning restore 1591
