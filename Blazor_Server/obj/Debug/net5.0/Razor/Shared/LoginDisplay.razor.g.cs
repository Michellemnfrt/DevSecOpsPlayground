#pragma checksum "E:\Swen 670 overflow\swen670\playground\Blazor_Server\Shared\LoginDisplay.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e53c5d099c408e8b911fe087df890dd3de54b46"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor_Server.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Swen 670 overflow\swen670\playground\Blazor_Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Swen 670 overflow\swen670\playground\Blazor_Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Swen 670 overflow\swen670\playground\Blazor_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Swen 670 overflow\swen670\playground\Blazor_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Swen 670 overflow\swen670\playground\Blazor_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Swen 670 overflow\swen670\playground\Blazor_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Swen 670 overflow\swen670\playground\Blazor_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Swen 670 overflow\swen670\playground\Blazor_Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Swen 670 overflow\swen670\playground\Blazor_Server\_Imports.razor"
using Blazor_Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Swen 670 overflow\swen670\playground\Blazor_Server\_Imports.razor"
using Blazor_Server.Shared;

#line default
#line hidden
#nullable disable
    public partial class LoginDisplay : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n        Hello, ");
                __builder2.AddContent(3, 
#nullable restore
#line 3 "E:\Swen 670 overflow\swen670\playground\Blazor_Server\Shared\LoginDisplay.razor"
                context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(4, "!\r\n        ");
                __builder2.AddMarkupContent(5, "<a href=\"MicrosoftIdentity/Account/SignOut\">Log out</a>");
            }
            ));
            __builder.AddAttribute(6, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(7, "<a href=\"MicrosoftIdentity/Account/SignIn\">Log in</a>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
