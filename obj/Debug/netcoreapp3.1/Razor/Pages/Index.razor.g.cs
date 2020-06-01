#pragma checksum "C:\repos\TestBlazor\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2baa35f347a61fbd71e9a2736c190469f6f4e430"
// <auto-generated/>
#pragma warning disable 1591
namespace TestBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\repos\TestBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\repos\TestBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\repos\TestBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\repos\TestBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\repos\TestBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\repos\TestBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\repos\TestBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\repos\TestBlazor\_Imports.razor"
using TestBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\repos\TestBlazor\_Imports.razor"
using TestBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\repos\TestBlazor\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\repos\TestBlazor\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\repos\TestBlazor\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\r\n\r\nWelcome to your new app.\r\n\r\n");
            __builder.OpenComponent<TestBlazor.Shared.SurveyPrompt>(1);
            __builder.AddAttribute(2, "Title", "How is Blazor working for you?");
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "btn btn-primary");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\repos\TestBlazor\Pages\Index.razor"
                                            async () => await ShowModal(5)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(7, "Open modal");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "C:\repos\TestBlazor\Pages\Index.razor"
       

    public async Task ShowModal(int idToPassToModal)
    {
        var parameters = new ModalParameters();
        parameters.Add(nameof(TestModal.Id), idToPassToModal);

        var options = new ModalOptions
        {
            HideCloseButton = false,
            DisableBackgroundCancel = false
        };
        
        var modalRef = ModalService.Show<TestModal>(idToPassToModal.ToString(), parameters, options);
        var result = await modalRef.Result;
        Console.WriteLine($"Modal finished with data: {result.Data}, dataType: {result.DataType} cancelled: {result.Cancelled}");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModalService ModalService { get; set; }
    }
}
#pragma warning restore 1591
