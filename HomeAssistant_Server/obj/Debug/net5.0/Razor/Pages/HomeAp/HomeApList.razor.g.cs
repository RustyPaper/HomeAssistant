#pragma checksum "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeAp\HomeApList.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6a2c283525dd4706f2fada5129c2f5995ec824f75d7d14ee23e2c7e22287ab29"
// <auto-generated/>
#pragma warning disable 1591
namespace HomeAssistant_Server.Pages.HomeAp
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

#nullable disable
    ;
#nullable restore
#line 3 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeAp\HomeApList.razor"
 using Business.Repository.IRepository

#nullable disable
    ;
#nullable restore
#line 4 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeAp\HomeApList.razor"
 using Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Components.RouteAttribute(
    // language=Route,Component
#nullable restore
#line 1 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeAp\HomeApList.razor"
      "/home-apartament"

#line default
#line hidden
#nullable disable
    )]
    #nullable restore
    public partial class HomeApList : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row mt-4");
            __builder.AddMarkupContent(2, "<div class=\"col-8\"><h4 class=\"card-title text-info\">Home Apartaments</h4></div>\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-3 offset-1");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(5);
            __builder.AddAttribute(6, "href", (object)("home-apartament/create"));
            __builder.AddAttribute(7, "class", (object)("btn btn-primary btn-alert-info form-control"));
            __builder.AddAttribute(8, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(9, "Add New Apartament");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n\r\n");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "row mt-4");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "col-12");
            __builder.OpenElement(15, "table");
            __builder.AddAttribute(16, "class", "table table-bordered table-hover");
            __builder.AddMarkupContent(17, "<thead><tr><td>Name</td>\r\n                    <td>Occupancy</td>\r\n                    <td>Price</td>\r\n                    <td>Square Feet</td>\r\n                    <td></td></tr></thead>\r\n            ");
            __builder.OpenElement(18, "tbody");
#nullable restore
#line 34 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeAp\HomeApList.razor"
                try{

              
                

#line default
#line hidden
#nullable disable

#nullable restore
#line 37 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeAp\HomeApList.razor"
                 if (Apartaments.Any())
                {

                    foreach(var apartament in Apartaments)
                    {

#line default
#line hidden
#nullable disable

            __builder.OpenElement(19, "tr");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 43 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeAp\HomeApList.razor"
                                 apartament.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                             ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 44 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeAp\HomeApList.razor"
                                  apartament.Occupancy

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                              ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 45 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeAp\HomeApList.razor"
                                   apartament.Rate.ToString("c")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                               ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 46 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeAp\HomeApList.razor"
                                    apartament.SqFt

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                                  ");
            __builder.OpenElement(32, "td");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(33);
            __builder.AddAttribute(34, "href", (object)(
#nullable restore
#line 47 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeAp\HomeApList.razor"
                                                        $"home-apartament/edit/{apartament.Id}"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "class", (object)("btn btn-primary"));
            __builder.AddAttribute(36, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(37, "Edit");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(38, "\r\n                                ");
            __builder.OpenElement(39, "button");
            __builder.AddAttribute(40, "class", "btn btn-danger");
            __builder.AddAttribute(41, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeAp\HomeApList.razor"
                                                                           ()=>HandleDelete(apartament.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(42, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 50 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeAp\HomeApList.razor"

                    }
                }
                else
                {

#line default
#line hidden
#nullable disable

            __builder.AddMarkupContent(43, "<td colspan 5>No Homes Found!</td>");
#nullable restore
#line 56 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeAp\HomeApList.razor"

                    }

#line default
#line hidden
#nullable disable

#nullable restore
#line 57 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeAp\HomeApList.razor"
                     
                }
                catch(Exception ex){
                    throw ex;
                }

#line default
#line hidden
#nullable disable

            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n\r\n");
            __builder.OpenComponent<global::HomeAssistant_Server.Shared.DeleteConfirmation>(45);
            __builder.AddAttribute(46, "ConfirmationChanged", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.Boolean>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.Boolean>(this, 
#nullable restore
#line 67 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeAp\HomeApList.razor"
                                         ConfirmDelete_Click

#line default
#line hidden
#nullable disable
            ))));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 69 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeAp\HomeApList.razor"
       

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

        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 8 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeAp\HomeApList.razor"
        HomeAssistant_Server.Service.IService.IFileUpload

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 8 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeAp\HomeApList.razor"
                                                          FileUpload

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 7 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeAp\HomeApList.razor"
        IJSRuntime

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 7 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeAp\HomeApList.razor"
                   JsRuntime

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 6 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeAp\HomeApList.razor"
        NavigationManager

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 6 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeAp\HomeApList.razor"
                          NavigationManager

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 5 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeAp\HomeApList.razor"
        IHomeApRepository

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 5 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeAp\HomeApList.razor"
                          HomeApRepository

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
    }
}
#pragma warning restore 1591
