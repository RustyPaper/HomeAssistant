// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace HomeAssistant_Server.Pages.HomeAp
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
#line 3 "C:\Users\Adrian\source\repos\HomeAssistant\HomeAssistant_Server\Pages\HomeAp\HotelRoomList.razor"
using Business.Repository.IRepository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Adrian\source\repos\HomeAssistant\HomeAssistant_Server\Pages\HomeAp\HotelRoomList.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Adrian\source\repos\HomeAssistant\HomeAssistant_Server\Pages\HomeAp\HotelRoomList.razor"
           [Authorize(Roles = CommonFiles.SD.Role_Admin)]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/home-apartament")]
    public partial class HotelRoomList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 69 "C:\Users\Adrian\source\repos\HomeAssistant\HomeAssistant_Server\Pages\HomeAp\HotelRoomList.razor"
       

    //when page initialised, create list

    private IEnumerable<HomeApDTO> Apartaments { get; set; } = new List<HomeApDTO>();

    private int? DeleteApartamentId { get; set; } = null;

    protected override async Task OnInitializedAsync()
    {
        //populate the apartaments and show them to the user

        Apartaments = await HomeApRepository.GetAllHomeAp();
    }

    private void RedirectTo(int apartamentId)
    {
        NavigationManager.NavigateTo($"home-apartament/edit/{apartamentId}");
    }


    private async Task HandleDelete(int apartamentId)
    {

        DeleteApartamentId = apartamentId;
        await JsRuntime.InvokeVoidAsync("ShowDeleteConfirmationModal");

    }

    public async Task ConfirmDelete_Click(bool isConfirmed)
    {
        if (isConfirmed && DeleteApartamentId != null)
        {

            HomeApDTO homeAp = await HomeApRepository.GetHomeAp(DeleteApartamentId.Value);
            foreach (var image in homeAp.HomeApImages)
            {
                var imageName = image.ApartamentImageURL.Replace($"{NavigationManager.BaseUri}ApartamentImages/", "");
                FileUpload.DeleteFile(imageName);

            }
            //once the images are deleted, delete the home apartament by its id
            await HomeApRepository.DeleteHomeAp(DeleteApartamentId.Value);
            await JsRuntime.ToastrSuccess("Home Apartament Deleted");

            //re-populate the list of apartaments
            Apartaments = await HomeApRepository.GetAllHomeAp();
        }
                await JsRuntime.InvokeVoidAsync("HideDeleteConfirmationModal");

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HomeAssistant_Server.Service.IService.IFileUpload FileUpload { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHomeApRepository HomeApRepository { get; set; }
    }
}
#pragma warning restore 1591
