#pragma checksum "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\Pages\IAuthentication.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22b0f16b7f1f52aee3e1dfe785c69e93c78ad062"
// <auto-generated/>
#pragma warning disable 1591
namespace Estore.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\_Imports.razor"
using Estore.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\_Imports.razor"
using Estore.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\_Imports.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\_Imports.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\Pages\IAuthentication.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/authentication/{action}")]
    public partial class IAuthentication : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.WebAssembly.Authentication.RemoteAuthenticatorView>(0);
            __builder.AddAttribute(1, "Action", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 5 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\Pages\IAuthentication.razor"
                                  Action

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\Pages\IAuthentication.razor"
      
    [Parameter] public string Action { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
