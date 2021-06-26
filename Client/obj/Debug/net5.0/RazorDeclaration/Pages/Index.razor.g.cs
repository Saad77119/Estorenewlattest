// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\Pages\Index.razor"
using Estore.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\Pages\Index.razor"
using Estore.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\Pages\Index.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\Pages\Index.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\Pages\Index.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\Pages\Index.razor"
using Estore.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\Pages\Index.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 302 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\Pages\Index.razor"
           
    int i = 0;
    int y = 0;
    string currentuserid = "";
    Estore.Shared.Models.Shop[] ShopList;
    Estore.Shared.Models.Catagory[] CatagoriesList;
    Estore.Shared.Models.Product[] ProductList;
    protected override async Task OnInitializedAsync()
    {

        try
        {
            ProductList = await Http.GetFromJsonAsync<Estore.Shared.Models.Product[]>
("/api/Products/Index");
            CatagoriesList = await Http.GetFromJsonAsync<Estore.Shared.Models.Catagory[]>
("api/Catagories/Index");
            CatagoriesList.Take(7);
            ShopList = await Http.GetFromJsonAsync<Estore.Shared.Models.Shop[]>
("api/Shops/Index");
            CurrentUser userdata = await authStateProvider.GetCurrentUser();
            currentuserid = userdata.Claims["http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier"].ToString();

        }
        catch (AccessTokenNotAvailableException exception)
        {
            exception.Redirect();
        }


    }
    public string[] getcatagoryarray(String catagory_id)
    {
        string[] catagoryarray = catagory_id.Split(",");
        return catagoryarray;
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CustomStateProvider authStateProvider { get; set; }
    }
}
#pragma warning restore 1591