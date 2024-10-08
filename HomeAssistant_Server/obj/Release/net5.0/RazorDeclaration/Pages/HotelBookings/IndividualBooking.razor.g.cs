// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace HomeAssistant_Server.Pages.HotelBookings
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Adrian\source\repos\HomeAssistant\HomeAssistant_Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Adrian\source\repos\HomeAssistant\HomeAssistant_Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Adrian\source\repos\HomeAssistant\HomeAssistant_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Adrian\source\repos\HomeAssistant\HomeAssistant_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Adrian\source\repos\HomeAssistant\HomeAssistant_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Adrian\source\repos\HomeAssistant\HomeAssistant_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Adrian\source\repos\HomeAssistant\HomeAssistant_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Adrian\source\repos\HomeAssistant\HomeAssistant_Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Adrian\source\repos\HomeAssistant\HomeAssistant_Server\_Imports.razor"
using HomeAssistant_Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Adrian\source\repos\HomeAssistant\HomeAssistant_Server\_Imports.razor"
using HomeAssistant_Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Adrian\source\repos\HomeAssistant\HomeAssistant_Server\_Imports.razor"
using HomeAssistant_Server.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Adrian\source\repos\HomeAssistant\HomeAssistant_Server\_Imports.razor"
using Blazored.TextEditor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Adrian\source\repos\HomeAssistant\HomeAssistant_Server\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Adrian\source\repos\HomeAssistant\HomeAssistant_Server\Pages\HotelBookings\IndividualBooking.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Adrian\source\repos\HomeAssistant\HomeAssistant_Server\Pages\HotelBookings\IndividualBooking.razor"
using Business.Repository.IRepository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Adrian\source\repos\HomeAssistant\HomeAssistant_Server\Pages\HotelBookings\IndividualBooking.razor"
using CommonFiles;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/apartament-bookings/details/{Id:int}")]
    public partial class IndividualBooking : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 167 "C:\Users\Adrian\source\repos\HomeAssistant\HomeAssistant_Server\Pages\HotelBookings\IndividualBooking.razor"
       
    [Parameter]
    public int Id { get; set; }

    private ApartamentOrderDetailsDTO HomeBooking { get; set; } = new ApartamentOrderDetailsDTO() { HomeApDTO = new HomeApDTO() };
    private bool IsLoading { get; set; } = false;

    protected override async Task OnInitializedAsync()
    {
        IsLoading = true;

        if (Id != 0)
        {
            HomeBooking = await apartamentOrderDetailsRepository.GetApartamentOrderDetail(Id);
        }
        else
        {
            //error
        }

        IsLoading = false;
    }

    private async Task ConfirmCheckIn()
    {
        await apartamentOrderDetailsRepository.OrderStatus(HomeBooking.Id, SD.Status_CheckedIn);
        HomeBooking = await apartamentOrderDetailsRepository.GetApartamentOrderDetail(Id);
    }

    private async Task ConfirmCheckOut()
    {
        await apartamentOrderDetailsRepository.OrderStatus(HomeBooking.Id, SD.Status_CheckedOut_Completed);
        HomeBooking = await apartamentOrderDetailsRepository.GetApartamentOrderDetail(Id);
    }

    private async Task CancelBooking()
    {
        await apartamentOrderDetailsRepository.OrderStatus(HomeBooking.Id, SD.Status_Cancelled);
        HomeBooking = await apartamentOrderDetailsRepository.GetApartamentOrderDetail(Id);
    }

    private async Task NoShowBooking()
    {
        await apartamentOrderDetailsRepository.OrderStatus(HomeBooking.Id, SD.Status_NoShow);
        HomeBooking = await apartamentOrderDetailsRepository.GetApartamentOrderDetail(Id);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IApartamentOrderDetailsRepository apartamentOrderDetailsRepository { get; set; }
    }
}
#pragma warning restore 1591
