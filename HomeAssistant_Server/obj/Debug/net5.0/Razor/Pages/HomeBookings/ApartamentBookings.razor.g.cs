#pragma checksum "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeBookings\ApartamentBookings.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "52da4572ae6ba599bc2cdd45c278d91b7c7a38476f28f6c5fd2c106d6c5e4e99"
// <auto-generated/>
#pragma warning disable 1591
namespace HomeAssistant_Server.Pages.HomeBookings
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
#line 2 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeBookings\ApartamentBookings.razor"
 using Models

#nullable disable
    ;
#nullable restore
#line 3 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeBookings\ApartamentBookings.razor"
 using Business.Repository.IRepository

#nullable disable
    ;
#nullable restore
#line 4 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeBookings\ApartamentBookings.razor"
 using Radzen

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Components.RouteAttribute(
    // language=Route,Component
#nullable restore
#line 1 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeBookings\ApartamentBookings.razor"
      "/apartament-bookings"

#line default
#line hidden
#nullable disable
    )]
    #nullable restore
    public partial class ApartamentBookings : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 10 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeBookings\ApartamentBookings.razor"
 if (!isLoading)
{

#line default
#line hidden
#nullable disable

            __builder.AddMarkupContent(0, "<h4 class=\"card-title text-info\">Bookings</h4>\r\n    ");
            __builder.OpenComponent<global::Radzen.Blazor.RadzenGrid<ApartamentOrderDetailsDTO>>(1);
            __builder.AddAttribute(2, "AllowFiltering", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 13 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeBookings\ApartamentBookings.razor"
                                true

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "FilterCaseSensitivity", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Radzen.FilterCaseSensitivity>(
#nullable restore
#line 14 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeBookings\ApartamentBookings.razor"
                                       FilterCaseSensitivity.CaseInsensitive

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "FilterMode", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Radzen.FilterMode>(
#nullable restore
#line 15 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeBookings\ApartamentBookings.razor"
                            FilterMode.Advanced

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "AllowPaging", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 15 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeBookings\ApartamentBookings.razor"
                                                              true

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(6, "PageSize", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 15 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeBookings\ApartamentBookings.razor"
                                                                              15

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(7, "AllowSorting", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 16 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeBookings\ApartamentBookings.razor"
                              true

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "Data", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<ApartamentOrderDetailsDTO>>(
#nullable restore
#line 16 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeBookings\ApartamentBookings.razor"
                                           ApartamentOrders

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "ColumnWidth", (object)("200px"));
            __builder.AddAttribute(10, "Columns", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<global::Radzen.Blazor.RadzenGridColumn<ApartamentOrderDetailsDTO>>(11);
                __builder2.AddAttribute(12, "Property", (object)("Name"));
                __builder2.AddAttribute(13, "Title", (object)("Customer Name"));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n            ");
                __builder2.OpenComponent<global::Radzen.Blazor.RadzenGridColumn<ApartamentOrderDetailsDTO>>(15);
                __builder2.AddAttribute(16, "Property", (object)("Phone"));
                __builder2.AddAttribute(17, "Title", (object)("Phone Number"));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n            ");
                __builder2.OpenComponent<global::Radzen.Blazor.RadzenGridColumn<ApartamentOrderDetailsDTO>>(19);
                __builder2.AddAttribute(20, "Property", (object)("ApartamentId"));
                __builder2.AddAttribute(21, "Title", (object)("Apartament Identifer"));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\r\n            ");
                __builder2.OpenComponent<global::Radzen.Blazor.RadzenGridColumn<ApartamentOrderDetailsDTO>>(23);
                __builder2.AddAttribute(24, "Property", (object)("HomeApDTO.Name"));
                __builder2.AddAttribute(25, "Title", (object)("Apartament"));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "\r\n            ");
                __builder2.OpenComponent<global::Radzen.Blazor.RadzenGridColumn<ApartamentOrderDetailsDTO>>(27);
                __builder2.AddAttribute(28, "Property", (object)("Status"));
                __builder2.AddAttribute(29, "Title", (object)("Status"));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\r\n            ");
                __builder2.OpenComponent<global::Radzen.Blazor.RadzenGridColumn<ApartamentOrderDetailsDTO>>(31);
                __builder2.AddAttribute(32, "Property", (object)("CheckInDate"));
                __builder2.AddAttribute(33, "Title", (object)("Check-in Date"));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(34, "\r\n              ");
                __builder2.OpenComponent<global::Radzen.Blazor.RadzenGridColumn<ApartamentOrderDetailsDTO>>(35);
                __builder2.AddAttribute(36, "Property", (object)("CheckOutDate"));
                __builder2.AddAttribute(37, "Title", (object)("Check-out Date"));
                __builder2.AddAttribute(38, "Template", (global::Microsoft.AspNetCore.Components.RenderFragment<ApartamentOrderDetailsDTO>)((data) => (__builder3) => {
                    __builder3.AddContent(39, 
#nullable restore
#line 26 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeBookings\ApartamentBookings.razor"
                     String.Format("{0:d}", data.CheckInDate)

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(40, "\r\n\r\n            ");
                __builder2.OpenComponent<global::Radzen.Blazor.RadzenGridColumn<ApartamentOrderDetailsDTO>>(41);
                __builder2.AddAttribute(42, "Property", (object)("Id"));
                __builder2.AddAttribute(43, "Title", (object)(""));
                __builder2.AddAttribute(44, "Template", (global::Microsoft.AspNetCore.Components.RenderFragment<ApartamentOrderDetailsDTO>)((data) => (__builder3) => {
                    __builder3.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(45);
                    __builder3.AddAttribute(46, "class", (object)("btn btn-primary"));
                    __builder3.AddAttribute(47, "href", (object)(
#nullable restore
#line 32 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeBookings\ApartamentBookings.razor"
                                                             $"apartament-bookings/details/{data.Id}"

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(48, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(49, "Details");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(50, "\r\n                    ");
                    __builder3.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(51);
                    __builder3.AddAttribute(52, "class", (object)("btn btn-danger text-white cursor-pointer"));
                    __builder3.AddAttribute(53, "onclick", (object)(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeBookings\ApartamentBookings.razor"
                                                                                        ()=>BookingDelete(data.Id)

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(54, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(55, "Delete");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 38 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeBookings\ApartamentBookings.razor"
}
else
{

#line default
#line hidden
#nullable disable

            __builder.AddMarkupContent(56, "<p>loading...</p>");
#nullable restore
#line 42 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeBookings\ApartamentBookings.razor"
}

#line default
#line hidden
#nullable disable

        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeBookings\ApartamentBookings.razor"
       
    //List of apartament orders of type ApartamentOrderDetailsDTO
    private IEnumerable<ApartamentOrderDetailsDTO> ApartamentOrders { get; set; } = new List<ApartamentOrderDetailsDTO>();
    private bool isLoading { get; set; } = false;
    internal int? DeleteBookingId { get; set; } = null;

    protected override async Task OnInitializedAsync()
    {
        isLoading = true;
        //Get all the apartament order details from the apartamentOrderDetails repo which contains the GetAllApartamentOrderDetail method
        ApartamentOrders = await apartamentOrderDetailsrepository.GetAllApartamentOrderDetail();
        isLoading = false;
    }

    public async Task BookingDelete(int bookingId){

        DeleteBookingId = bookingId;

        if(DeleteBookingId != null)
        {

            try
            {
                await apartamentOrderDetailsrepository.DeleteBooking(bookingId);
                await jsRuntime.ToastrSuccess("Booking Deleted");

            } catch (Exception ex){
                throw ex;
            }
            ApartamentOrders = await apartamentOrderDetailsrepository.GetAllApartamentOrderDetail();
        }

    }

#line default
#line hidden
#nullable disable

        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 7 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeBookings\ApartamentBookings.razor"
        NavigationManager

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 7 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeBookings\ApartamentBookings.razor"
                          NavigationManager

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 6 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeBookings\ApartamentBookings.razor"
        IJSRuntime

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 6 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeBookings\ApartamentBookings.razor"
                   jsRuntime

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 5 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeBookings\ApartamentBookings.razor"
        IApartamentOrderDetailsRepository

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 5 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeBookings\ApartamentBookings.razor"
                                          apartamentOrderDetailsrepository

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
    }
}
#pragma warning restore 1591
