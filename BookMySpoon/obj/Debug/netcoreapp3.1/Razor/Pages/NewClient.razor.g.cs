#pragma checksum "C:\Repositories\BookMySpoon\BookMySpoon\Pages\NewClient.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7dad39744e4129051ea4f85a34efdddf7134e3d2e47237896ff1bc910a2e8a72"
// <auto-generated/>
#pragma warning disable 1591
namespace BookMySpoon.Pages
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Repositories\BookMySpoon\BookMySpoon\_Imports.razor"
using System.Net.Http

#nullable disable
    ;
#nullable restore
#line 2 "C:\Repositories\BookMySpoon\BookMySpoon\_Imports.razor"
using Microsoft.AspNetCore.Authorization

#nullable disable
    ;
#nullable restore
#line 3 "C:\Repositories\BookMySpoon\BookMySpoon\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization

#nullable disable
    ;
#nullable restore
#line 4 "C:\Repositories\BookMySpoon\BookMySpoon\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms

#nullable disable
    ;
#nullable restore
#line 5 "C:\Repositories\BookMySpoon\BookMySpoon\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing

#nullable disable
    ;
#nullable restore
#line 6 "C:\Repositories\BookMySpoon\BookMySpoon\_Imports.razor"
using Microsoft.AspNetCore.Components.Web

#nullable disable
    ;
#nullable restore
#line 7 "C:\Repositories\BookMySpoon\BookMySpoon\_Imports.razor"
using Microsoft.JSInterop

#nullable disable
    ;
#nullable restore
#line 8 "C:\Repositories\BookMySpoon\BookMySpoon\_Imports.razor"
using BookMySpoon

#nullable disable
    ;
#nullable restore
#line 9 "C:\Repositories\BookMySpoon\BookMySpoon\_Imports.razor"
using BookMySpoon.Shared

#nullable disable
    ;
#nullable restore
#line 2 "C:\Repositories\BookMySpoon\BookMySpoon\Pages\NewClient.razor"
 using Data

#nullable disable
    ;
#nullable restore
#line 3 "C:\Repositories\BookMySpoon\BookMySpoon\Pages\NewClient.razor"
 using Interfaces

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Components.RouteAttribute(
    // language=Route,Component
#nullable restore
#line 1 "C:\Repositories\BookMySpoon\BookMySpoon\Pages\NewClient.razor"
      "/NewClient"

#line default
#line hidden
#nullable disable
    )]
    #nullable restore
    public partial class NewClient : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>New Client</h1>\r\n\r\n");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 8 "C:\Repositories\BookMySpoon\BookMySpoon\Pages\NewClient.razor"
                  client

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "OnInvalidSubmit", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 8 "C:\Repositories\BookMySpoon\BookMySpoon\Pages\NewClient.razor"
                                           HandleValidSubmit

#line default
#line hidden
#nullable disable
            ))));
            __builder.AddAttribute(4, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n\r\n    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "row content");
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.AddMarkupContent(11, "<div class=\"col-md-1\"><label for=\"Name\">Name</label></div>\r\n        ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "col-md-2");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(14);
                __builder2.AddAttribute(15, "id", (object)("Name"));
                __builder2.AddAttribute(16, "Value", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 13 "C:\Repositories\BookMySpoon\BookMySpoon\Pages\NewClient.razor"
                                                                client.Name

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(17, "ValueChanged", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => client.Name = __value, client.Name)))));
                __builder2.AddAttribute(18, "ValueExpression", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => client.Name)));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n        ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "col-md-4");
                global::__Blazor.BookMySpoon.Pages.NewClient.TypeInference.CreateValidationMessage_0(__builder2, 22, 23, 
#nullable restore
#line 14 "C:\Repositories\BookMySpoon\BookMySpoon\Pages\NewClient.razor"
                                                        () => client.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n    ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "row content");
                __builder2.AddMarkupContent(28, "\r\n        ");
                __builder2.AddMarkupContent(29, "<div class=\"col-md-1\"><label for=\"Email\">Email</label></div>\r\n        ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "col-md-2");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(32);
                __builder2.AddAttribute(33, "id", (object)("EmailAdress"));
                __builder2.AddAttribute(34, "Value", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 18 "C:\Repositories\BookMySpoon\BookMySpoon\Pages\NewClient.razor"
                                                                       client.Email

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(35, "ValueChanged", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => client.Email = __value, client.Email)))));
                __builder2.AddAttribute(36, "ValueExpression", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => client.Email)));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n        ");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "col-md-4");
                global::__Blazor.BookMySpoon.Pages.NewClient.TypeInference.CreateValidationMessage_1(__builder2, 40, 41, 
#nullable restore
#line 19 "C:\Repositories\BookMySpoon\BookMySpoon\Pages\NewClient.razor"
                                                        () => client.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n    ");
                __builder2.OpenElement(44, "div");
                __builder2.AddAttribute(45, "class", "row content");
                __builder2.AddMarkupContent(46, "\r\n        ");
                __builder2.AddMarkupContent(47, "<div class=\"col-md-1\"><label for=\"PhoneNumber\">PhoneNumber</label></div>\r\n        ");
                __builder2.OpenElement(48, "div");
                __builder2.AddAttribute(49, "class", "col-md-2");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(50);
                __builder2.AddAttribute(51, "id", (object)("PhoneNumber"));
                __builder2.AddAttribute(52, "Value", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 23 "C:\Repositories\BookMySpoon\BookMySpoon\Pages\NewClient.razor"
                                                                       client.PhoneNumber

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(53, "ValueChanged", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => client.PhoneNumber = __value, client.PhoneNumber)))));
                __builder2.AddAttribute(54, "ValueExpression", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => client.PhoneNumber)));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n        ");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "col-md-4");
                global::__Blazor.BookMySpoon.Pages.NewClient.TypeInference.CreateValidationMessage_2(__builder2, 58, 59, 
#nullable restore
#line 24 "C:\Repositories\BookMySpoon\BookMySpoon\Pages\NewClient.razor"
                                                        () => client.PhoneNumber

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n    ");
                __builder2.OpenElement(62, "div");
                __builder2.AddAttribute(63, "class", "row content");
                __builder2.AddMarkupContent(64, "\r\n        ");
                __builder2.OpenElement(65, "div");
                __builder2.AddAttribute(66, "class", "col-md-1");
                __builder2.OpenElement(67, "input");
                __builder2.AddAttribute(68, "type", "submit");
                __builder2.AddAttribute(69, "class", "btn btn-primary");
                __builder2.AddAttribute(70, "value", "Save");
                __builder2.AddAttribute(71, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Repositories\BookMySpoon\BookMySpoon\Pages\NewClient.razor"
                                                                                                  Save

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\r\n        ");
                __builder2.OpenElement(73, "div");
                __builder2.AddAttribute(74, "class", "col-md-2");
                __builder2.AddContent(75, " ");
                __builder2.OpenElement(76, "input");
                __builder2.AddAttribute(77, "type", "button");
                __builder2.AddAttribute(78, "value", "Cancel");
                __builder2.AddAttribute(79, "class", "btn btn-danger");
                __builder2.AddAttribute(80, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Repositories\BookMySpoon\BookMySpoon\Pages\NewClient.razor"
                                                                                                    Cancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Repositories\BookMySpoon\BookMySpoon\Pages\NewClient.razor"
       
    Client client = new Client();

    protected async Task Save()
    {
        await ClientsService.SaveClient(client);
    }
    protected void Cancel()
    {

    }

    private void HandleValidSubmit() => Console.WriteLine("OnValidSubmit");

#line default
#line hidden
#nullable disable

        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 4 "C:\Repositories\BookMySpoon\BookMySpoon\Pages\NewClient.razor"
        IClientsServices

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 4 "C:\Repositories\BookMySpoon\BookMySpoon\Pages\NewClient.razor"
                         ClientsService

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
    }
}
namespace __Blazor.BookMySpoon.Pages.NewClient
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
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", (object)__arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", (object)__arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
