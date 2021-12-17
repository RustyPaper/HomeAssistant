// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace HomeAssistant_Server.Pages.HomeAmenity
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
#line 2 "C:\Users\Adrian\source\repos\HomeAssistant\HomeAssistant_Server\Pages\HomeAmenity\HotelAmenityList.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Adrian\source\repos\HomeAssistant\HomeAssistant_Server\Pages\HomeAmenity\HotelAmenityList.razor"
using Business.Repository.IRepository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Adrian\source\repos\HomeAssistant\HomeAssistant_Server\Pages\HomeAmenity\HotelAmenityList.razor"
using CommonFiles;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Adrian\source\repos\HomeAssistant\HomeAssistant_Server\Pages\HomeAmenity\HotelAmenityList.razor"
           [Authorize(Roles = CommonFiles.SD.Role_Admin)]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/home-amenity")]
    public partial class HotelAmenityList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "C:\Users\Adrian\source\repos\HomeAssistant\HomeAssistant_Server\Pages\HomeAmenity\HotelAmenityList.razor"
       
    internal IEnumerable<HomeAmenityDTO> HomeAmenities { get; set; } = new List<HomeAmenityDTO>();

    internal int? DeleteAmenityId { get; set; } = null;
    private bool IsProcessing { get; set; } = false;


    protected override async Task OnInitializedAsync()
    {

        HomeAmenities = await AmenityRepository.GetAllHomeAmenity();
    }

    public async Task HandleDelete(int amenityId)
    {
        DeleteAmenityId = amenityId;
        await JsRuntime.InvokeVoidAsync("ShowDeleteConfirmationModal");
    }

    public async Task ConfirmDelete_Click(bool isConfirmed)
    {
        IsProcessing = true;
        if (isConfirmed && DeleteAmenityId != null)
        {
            try
            {
                var result = await AmenityRepository.DeleteHomeAmenity(DeleteAmenityId.Value, "");
                await JsRuntime.ToastrSuccess("Amenity Deleted successfully");
            }
            catch (Exception e)
            {
                await JsRuntime.ToastrError(e.Message);
            }
            //Update the list 
            HomeAmenities = await AmenityRepository.GetAllHomeAmenity();

        }

        await JsRuntime.InvokeVoidAsync("HideDeleteConfirmationModal");
        IsProcessing = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHomeAmenityRepository AmenityRepository { get; set; }
    }
}
#pragma warning restore 1591
