#pragma checksum "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeAp\HomeApUpsert.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "387c7c443359ac321bee70fbd73b4d2bab32d49f2da0bda9a018974cb75fd62f"
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
#line 3 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeAp\HomeApUpsert.razor"
 using Models

#nullable disable
    ;
#nullable restore
#line 4 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeAp\HomeApUpsert.razor"
 using Business.Repository.IRepository

#nullable disable
    ;
#nullable restore
#line 5 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeAp\HomeApUpsert.razor"
 using HomeAssistant_Server.Service.IService

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Components.RouteAttribute(
    // language=Route,Component
#nullable restore
#line 1 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeAp\HomeApUpsert.razor"
      "/home-apartament/create"

#line default
#line hidden
#nullable disable
    )]
    [global::Microsoft.AspNetCore.Components.RouteAttribute(
    // language=Route,Component
#nullable restore
#line 2 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeAp\HomeApUpsert.razor"
      "/home-apartament/edit/{Id:int}"

#line default
#line hidden
#nullable disable
    )]
    #nullable restore
    public partial class HomeApUpsert : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row mt-2 mb-5");
            __builder.OpenElement(2, "h3");
            __builder.AddAttribute(3, "class", "card-title text-info mb-3 ml-3");
            __builder.AddContent(4, 
#nullable restore
#line 14 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeAp\HomeApUpsert.razor"
                                                Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(5, " Home Apartament");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-md-12");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "card");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card-body");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(13);
            __builder.AddAttribute(14, "Model", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 18 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeAp\HomeApUpsert.razor"
                                 HomeApModel

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(15, "OnValidSubmit", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 18 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeAp\HomeApUpsert.razor"
                                                             HandleHomeApUpsert

#line default
#line hidden
#nullable disable
            ))));
            __builder.AddAttribute(16, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(17);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n                    ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "form-group");
                __builder2.AddMarkupContent(21, "<label>Name</label>\r\n                        ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(22);
                __builder2.AddAttribute(23, "class", (object)("form-control"));
                __builder2.AddAttribute(24, "Value", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 23 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeAp\HomeApUpsert.razor"
                                                HomeApModel.Name

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(25, "ValueChanged", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => HomeApModel.Name = __value, HomeApModel.Name)))));
                __builder2.AddAttribute(26, "ValueExpression", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => HomeApModel.Name)));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\r\n                        ");
                global::__Blazor.HomeAssistant_Server.Pages.HomeAp.HomeApUpsert.TypeInference.CreateValidationMessage_0(__builder2, 28, 29, 
#nullable restore
#line 24 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeAp\HomeApUpsert.razor"
                                                ()=>HomeApModel.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n                    ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "form-group");
                __builder2.AddMarkupContent(33, "<label>Occupancy</label>\r\n                        ");
                global::__Blazor.HomeAssistant_Server.Pages.HomeAp.HomeApUpsert.TypeInference.CreateInputNumber_1(__builder2, 34, 35, "form-control", 36, 
#nullable restore
#line 28 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeAp\HomeApUpsert.razor"
                                                  HomeApModel.Occupancy

#line default
#line hidden
#nullable disable
                , 37, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => HomeApModel.Occupancy = __value, HomeApModel.Occupancy)), 38, () => HomeApModel.Occupancy);
                __builder2.AddMarkupContent(39, "\r\n                        ");
                global::__Blazor.HomeAssistant_Server.Pages.HomeAp.HomeApUpsert.TypeInference.CreateValidationMessage_2(__builder2, 40, 41, 
#nullable restore
#line 29 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeAp\HomeApUpsert.razor"
                                                ()=>HomeApModel.Occupancy

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n                    ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "form-group");
                __builder2.AddMarkupContent(45, "<label>Rate</label>\r\n                        ");
                global::__Blazor.HomeAssistant_Server.Pages.HomeAp.HomeApUpsert.TypeInference.CreateInputNumber_3(__builder2, 46, 47, "form-control", 48, 
#nullable restore
#line 33 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeAp\HomeApUpsert.razor"
                                                  HomeApModel.Rate

#line default
#line hidden
#nullable disable
                , 49, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => HomeApModel.Rate = __value, HomeApModel.Rate)), 50, () => HomeApModel.Rate);
                __builder2.AddMarkupContent(51, "\r\n                        ");
                global::__Blazor.HomeAssistant_Server.Pages.HomeAp.HomeApUpsert.TypeInference.CreateValidationMessage_4(__builder2, 52, 53, 
#nullable restore
#line 34 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeAp\HomeApUpsert.razor"
                                                ()=>HomeApModel.Rate

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n                    ");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "form-group");
                __builder2.AddMarkupContent(57, "<label>Sq ft.</label>\r\n                        ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(58);
                __builder2.AddAttribute(59, "class", (object)("form-control"));
                __builder2.AddAttribute(60, "Value", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 38 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeAp\HomeApUpsert.razor"
                                                HomeApModel.SqFt

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(61, "ValueChanged", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => HomeApModel.SqFt = __value, HomeApModel.SqFt)))));
                __builder2.AddAttribute(62, "ValueExpression", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => HomeApModel.SqFt)));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n                    ");
                __builder2.OpenElement(64, "div");
                __builder2.AddAttribute(65, "class", "form-group");
                __builder2.AddAttribute(66, "style", "height:250px");
                __builder2.AddMarkupContent(67, "<label>Details</label>\r\n                        ");
                __builder2.OpenComponent<global::Blazored.TextEditor.BlazoredTextEditor>(68);
                __builder2.AddAttribute(69, "Placeholder", (object)("Enter Apartament Details"));
                __builder2.AddAttribute(70, "ToolbarContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(71, "select");
                    __builder3.AddAttribute(72, "class", "ql-header");
                    __builder3.OpenElement(73, "option");
                    __builder3.AddAttribute(74, "selected");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(75, "\r\n                                    ");
                    __builder3.OpenElement(76, "option");
                    __builder3.AddAttribute(77, "value", "1");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(78, "\r\n                                    ");
                    __builder3.OpenElement(79, "option");
                    __builder3.AddAttribute(80, "value", "2");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(81, "\r\n                                    ");
                    __builder3.OpenElement(82, "option");
                    __builder3.AddAttribute(83, "value", "3");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(84, "\r\n                                    ");
                    __builder3.OpenElement(85, "option");
                    __builder3.AddAttribute(86, "value", "4");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(87, "\r\n                                    ");
                    __builder3.OpenElement(88, "option");
                    __builder3.AddAttribute(89, "value", "5");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(90, "\r\n                                ");
                    __builder3.AddMarkupContent(91, @"<span class=""ql-formats""><button class=""ql-bold""></button>
                                    <button class=""ql-italic""></button>
                                    <button class=""ql-underline""></button>
                                    <button class=""ql-strike""></button></span>
                                ");
                    __builder3.AddMarkupContent(92, "<span class=\"ql-formats\"><select class=\"ql-color\"></select>\r\n                                    <select class=\"ql-background\"></select></span>\r\n                                ");
                    __builder3.AddMarkupContent(93, "<span class=\"ql-formats\"><button class=\"ql-list\" value=\"ordered\"></button>\r\n                                    <button class=\"ql-list\" value=\"bullet\"></button></span>\r\n                                ");
                    __builder3.AddMarkupContent(94, "<span class=\"ql-formats\"><button class=\"ql-link\"></button></span>");
                }
                ));
                __builder2.AddAttribute(95, "EditorContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                }
                ));
                __builder2.AddComponentReferenceCapture(96, (__value) => {
#nullable restore
#line 42 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeAp\HomeApUpsert.razor"
                                                   QuillHtml

#line default
#line hidden
#nullable disable
                     = (Blazored.TextEditor.BlazoredTextEditor)__value;
                }
                );
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(97, "\r\n                    ");
                __builder2.OpenElement(98, "div");
                __builder2.AddAttribute(99, "class", "form-group");
                __builder2.AddAttribute(100, "style", "padding-top:70px");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputFile>(101);
                __builder2.AddAttribute(102, "OnChange", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 76 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeAp\HomeApUpsert.razor"
                                             HandleImageUpload

#line default
#line hidden
#nullable disable
                ))));
                __builder2.AddAttribute(103, "multiple", (object)(true));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(104, "\r\n                        ");
                __builder2.OpenElement(105, "div");
                __builder2.AddAttribute(106, "class", "row");
#nullable restore
#line 78 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeAp\HomeApUpsert.razor"
                             if (IsImageUploadProcessStarted)
                            {

#line default
#line hidden
#nullable disable

                __builder2.AddMarkupContent(107, "<div class=\"col-md-12\"><span><i class=\"fa fa-spin fa-spinner\"></i> Please wait.. Images are uploading...</span></div>");
#nullable restore
#line 83 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeAp\HomeApUpsert.razor"
                            }

#line default
#line hidden
#nullable disable

#nullable restore
#line 84 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeAp\HomeApUpsert.razor"
                             if (HomeApModel.ImageUrls != null && HomeApModel.ImageUrls.Count > 0)
                            {
                                int serial = 1;
                                foreach (var apartamentImage in HomeApModel.ImageUrls)
                                {

#line default
#line hidden
#nullable disable

                __builder2.OpenElement(108, "div");
                __builder2.AddAttribute(109, "class", "col-md-2 mt-3");
                __builder2.OpenElement(110, "div");
                __builder2.AddAttribute(111, "class", "apartament-image");
                __builder2.AddAttribute(112, "style", "background:" + " url(\'" + (
#nullable restore
#line 90 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeAp\HomeApUpsert.razor"
                                                                                               apartamentImage

#line default
#line hidden
#nullable disable
                ) + "\')" + " 50%" + " 50%;" + " ");
                __builder2.OpenElement(113, "span");
                __builder2.AddAttribute(114, "class", "apartament-image-title");
                __builder2.AddContent(115, 
#nullable restore
#line 91 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeAp\HomeApUpsert.razor"
                                                                                  serial

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(116, "\r\n\r\n                                        ");
                __builder2.OpenElement(117, "button");
                __builder2.AddAttribute(118, "type", "button");
                __builder2.AddAttribute(119, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 94 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeAp\HomeApUpsert.razor"
                                                                        ()=>DeletePhoto(apartamentImage)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(120, "class", "btn btn-outline-danger btn-block mt-4");
                __builder2.AddMarkupContent(121, "\r\n                                            Delete\r\n                                        ");
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 98 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeAp\HomeApUpsert.razor"
                                    serial++;
                                }
                            }

#line default
#line hidden
#nullable disable

                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(122, "\r\n                    ");
                __builder2.OpenElement(123, "div");
                __builder2.AddAttribute(124, "class", "form-group");
                __builder2.OpenElement(125, "button");
                __builder2.AddAttribute(126, "class", "btn btn-primary");
                __builder2.AddContent(127, 
#nullable restore
#line 104 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeAp\HomeApUpsert.razor"
                                                         Title

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(128, " Apartament");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(129, "\r\n                        ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(130);
                __builder2.AddAttribute(131, "href", (object)("home-apartament"));
                __builder2.AddAttribute(132, "class", (object)("btn btn-secondary"));
                __builder2.AddAttribute(133, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(134, "Back to Index");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 113 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeAp\HomeApUpsert.razor"
       

    [Parameter]
    //determines whether create or edit
    public int? Id { get; set; }

    private HomeApDTO HomeApModel { get; set; } = new HomeApDTO();

    private string Title { get; set; } = "Create";

    private HomeApImageDTO ApartamentImage { get; set; } = new HomeApImageDTO();

    private List<string> DeletedImageNames { get; set; }

    public BlazoredTextEditor QuillHtml { get; set; } = new BlazoredTextEditor();

    [CascadingParameter]
    public Task<AuthenticationState> AuthenticationState{ get; set; }


    private bool IsImageUploadProcessStarted { get; set; } = false;


    protected override async Task OnInitializedAsync()
    {
        var authenticationState = await AuthenticationState;

        //check if admin is logged in
        if (!authenticationState.User.IsInRole(CommonFiles.SD.Role_Admin))
        {
            var uri = new Uri(NavigationManager.Uri);
            NavigationManager.NavigateTo($"/identity/account/login?returnUrl={uri.LocalPath}");
        }

        if (Id != null)
        {
            //updating
            Title = "Update";
            HomeApModel = await HomeApRepository.GetHomeAp(Id.Value);
            if (HomeApModel?.HomeApImages != null)
            {
                HomeApModel.ImageUrls = HomeApModel.HomeApImages.Select(u => u.ApartamentImageURL).ToList();
            }
        }
        else
        {
            //create
            HomeApModel = new HomeApDTO();
        }

    }

    protected async override Task OnAfterRenderAsync(bool firstRender)
    {
        if (!firstRender)
        {
            return;
        }
        bool loading = true;
        while (loading)
        {
            try
            {
                if (!string.IsNullOrEmpty(HomeApModel.Details))
                {
                    await this.QuillHtml.LoadHTMLContent(HomeApModel.Details);
                }
                loading = false;
            }
            catch
            {
                await Task.Delay(10);
                loading = false;
            }

        }
        if (!string.IsNullOrEmpty(HomeApModel.Details))
        {
            await this.QuillHtml.LoadHTMLContent(HomeApModel.Details);
        }
    }

    private async Task HandleHomeApUpsert()
    {
        try
        {


            if (HomeApModel.Id != 0 && Title == "Update")
            {

                //if the Id is not null, we're updating the home apartament
                HomeApModel.Details = await QuillHtml.GetHTML();


                //update

                var updateApartamentResult = await HomeApRepository.UpdateHomeAp(HomeApModel.Id, HomeApModel);

                if (HomeApModel.ImageUrls != null && HomeApModel.ImageUrls.Any())
                {
                    if (DeletedImageNames != null && DeletedImageNames.Any())
                    {
                        foreach (var deletedImageName in DeletedImageNames)
                        {
                            var imageName = deletedImageName.Replace($"{NavigationManager.BaseUri}ApartamentImages/", "");

                            var result = FileUpload.DeleteFile(imageName);
                            await HomeImagesRepository.DeleteHomeImageByImageUrl(deletedImageName);
                        }
                    }



                    await AddHomeApImage(updateApartamentResult);
                }
                await JsRuntime.ToastrSuccess("Home apartament updated successfully.");
            }
            else
            {
                //create
                HomeApModel.Details = await QuillHtml.GetHTML();
                var createdResult = await HomeApRepository.CreateHomeAp(HomeApModel);
                await AddHomeApImage(createdResult);
                await JsRuntime.ToastrSuccess("Home apartament created successfully.");
            }
        }
        catch (Exception ex)
        {
            //log exceptions
        }



        NavigationManager.NavigateTo("home-apartament");
    }

    private async Task HandleImageUpload(InputFileChangeEventArgs e)
    {
        IsImageUploadProcessStarted = true;
        try
        {
            var images = new List<string>();
            if (e.GetMultipleFiles().Count > 0)
            {
                foreach (var file in e.GetMultipleFiles())
                {
                    System.IO.FileInfo fileInfo = new System.IO.FileInfo(file.Name);
                    if (fileInfo.Extension.ToLower() == ".jpg" ||
                        fileInfo.Extension.ToLower() == ".png" ||
                        fileInfo.Extension.ToLower() == ".jpeg")
                    {
                        var uploadedImagePath = await FileUpload.UploadFile(file);
                        images.Add(uploadedImagePath);
                    }
                    else
                    {
                        await JsRuntime.ToastrError("Please select .jpg/.jpeg/.png file only");
                        return;
                    }
                }

                if (images.Any())
                {
                    if (HomeApModel.ImageUrls != null && HomeApModel.ImageUrls.Any())
                    {
                        HomeApModel.ImageUrls.AddRange(images);
                    }
                    else
                    {
                        HomeApModel.ImageUrls = new List<string>();
                        HomeApModel.ImageUrls.AddRange(images);
                    }
                }
                else
                {
                    await JsRuntime.ToastrError("Image uploading failed");
                    return;
                }
            }
            IsImageUploadProcessStarted = false;
        }
        catch (Exception ex)
        {
            await JsRuntime.ToastrError(ex.Message);
        }



    }

    private async Task AddHomeApImage(HomeApDTO apartamentDetails)
    {
        foreach (var imageUrl in HomeApModel.ImageUrls)
        {
            if (HomeApModel.HomeApImages.Where(x => x.ApartamentImageURL == imageUrl).Count() == 0)
            {

                ApartamentImage = new HomeApImageDTO()
                    {
                        ApartamentId = apartamentDetails.Id,
                        ApartamentImageURL = imageUrl
                    };
                await HomeImagesRepository.CreateHomeApImage(ApartamentImage);
            }
        }
    }

    private async Task DeletePhoto(string imageUrl)
    {
        try
        {
            var imageIndex = HomeApModel.ImageUrls.FindIndex(x => x == imageUrl);
            var imageName = imageUrl.Replace($"{NavigationManager.BaseUri}ApartamentImages/", "");
            if (HomeApModel.Id == 0 && Title == "Create")
            {
                var result = FileUpload.DeleteFile(imageName);
            }
            else
            {
                //update
                DeletedImageNames ??= new List<string>();
                DeletedImageNames.Add(imageUrl);
            }
            HomeApModel.ImageUrls.RemoveAt(imageIndex);
        }
        catch (Exception ex)
        {
            await JsRuntime.ToastrError(ex.Message);
        }
    }

#line default
#line hidden
#nullable disable

        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 10 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeAp\HomeApUpsert.razor"
        IFileUpload

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 10 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeAp\HomeApUpsert.razor"
                    FileUpload

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 9 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeAp\HomeApUpsert.razor"
        IJSRuntime

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 9 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeAp\HomeApUpsert.razor"
                   JsRuntime

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 8 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeAp\HomeApUpsert.razor"
        NavigationManager

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 8 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeAp\HomeApUpsert.razor"
                          NavigationManager

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 7 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeAp\HomeApUpsert.razor"
        IHomeImagesRepository

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 7 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeAp\HomeApUpsert.razor"
                              HomeImagesRepository

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 6 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeAp\HomeApUpsert.razor"
        IHomeApRepository

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 6 "C:\Users\Adrian\Desktop\KodBlazor\HomeAssistant\HomeAssistant_Server\Pages\HomeAp\HomeApUpsert.razor"
                          HomeApRepository

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
    }
}
namespace __Blazor.HomeAssistant_Server.Pages.HomeAp.HomeApUpsert
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", (object)__arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", (object)__arg0);
        __builder.AddAttribute(__seq1, "Value", (object)__arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", (object)__arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", (object)__arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", (object)__arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", (object)__arg0);
        __builder.AddAttribute(__seq1, "Value", (object)__arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", (object)__arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", (object)__arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", (object)__arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
