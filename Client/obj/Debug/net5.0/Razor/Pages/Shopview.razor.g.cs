#pragma checksum "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\Pages\Shopview.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0208954a4be8a420575d2b807555f9f943ebbbf8"
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
#line 2 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\Pages\Shopview.razor"
using Estore.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\Pages\Shopview.razor"
using Estore.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\Pages\Shopview.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\Pages\Shopview.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\Pages\Shopview.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/shopview")]
    public partial class Shopview : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<section class=""hero-slider""><div class=""single-slider""><div class=""container""><div class=""row no-gutters""><div class=""col-lg-9 offset-lg-3 col-12""><div class=""text-inner""><div class=""row""><div class=""col-lg-7 col-12""><div class=""hero-text""><h1><span>Welcome To   </span>Estore</h1>
                                    <p>Pakistan's best online shopping store with 1+ million  <br>  products at resounding discounts  with cash on delivery (COD).</p>
                                    <div class=""button""><a href=""/shopview"" class=""btn"">Shop Now!</a></div></div></div></div></div></div></div></div></div></section>
");
            __builder.OpenElement(1, "section");
            __builder.AddAttribute(2, "class", "product-area shop-sidebar shop section");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "row");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-lg-3 col-md-4 col-12");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "shop-sidebar");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "single-widget category");
            __builder.AddMarkupContent(13, "<h3 class=\"title\">Categories</h3>\r\n                        ");
            __builder.OpenElement(14, "ul");
            __builder.AddAttribute(15, "class", "categor-list");
#nullable restore
#line 43 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\Pages\Shopview.razor"
                             if (CatagoriesList == null)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(16, "<p>No Catagory is Found</p>");
#nullable restore
#line 46 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\Pages\Shopview.razor"
                            }
                            else
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\Pages\Shopview.razor"
                                 foreach (Catagory SingleCatagory in CatagoriesList)
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(17, "li");
            __builder.OpenElement(18, "a");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 51 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\Pages\Shopview.razor"
                                                     () => ViewCatagoryProduct(SingleCatagory.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(20, 
#nullable restore
#line 51 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\Pages\Shopview.razor"
                                                                                                    SingleCatagory.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 52 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\Pages\Shopview.razor"

                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\Pages\Shopview.razor"
                                 
                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "col-lg-9 col-md-8 col-12");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "row");
#nullable restore
#line 67 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\Pages\Shopview.razor"
                     if (SelectProductList.Length == 0)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(26, "<p>No Product is Found</p>");
#nullable restore
#line 70 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\Pages\Shopview.razor"
                    }
                    else
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\Pages\Shopview.razor"
                         foreach (Product SingleProduct in SelectProductList)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "col-lg-4 col-md-6 col-12");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "single-product");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "product-img");
            __builder.OpenElement(33, "a");
            __builder.AddAttribute(34, "href", "product-details.html");
            __builder.OpenElement(35, "img");
            __builder.AddAttribute(36, "class", "default-img");
            __builder.AddAttribute(37, "src", 
#nullable restore
#line 79 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\Pages\Shopview.razor"
                                                                           SingleProduct.Image

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(38, "alt", "#");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                                            ");
            __builder.OpenElement(40, "img");
            __builder.AddAttribute(41, "class", "hover-img");
            __builder.AddAttribute(42, "src", 
#nullable restore
#line 80 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\Pages\Shopview.razor"
                                                                         SingleProduct.Image

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(43, "alt", "#");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                                        ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "button-head");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "product-action");
            __builder.OpenElement(49, "a");
            __builder.AddAttribute(50, "data-toggle", "modal");
            __builder.AddAttribute(51, "data-target", "#exampleModal");
            __builder.AddAttribute(52, "title", "Quick View");
            __builder.AddAttribute(53, "href", "/singleproductdetail/" + (
#nullable restore
#line 84 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\Pages\Shopview.razor"
                                                                                                                                                  SingleProduct.ID

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(54, "<i class=\" ti-eye\"></i>");
            __builder.AddMarkupContent(55, "<span>Quick Shop</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                                            ");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "product-action-2");
            __builder.OpenElement(59, "a");
            __builder.AddAttribute(60, "title", "Add to cart");
            __builder.AddAttribute(61, "href", "/singleproductdetail/" + (
#nullable restore
#line 88 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\Pages\Shopview.razor"
                                                                                                   SingleProduct.ID

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(62, "View Product");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                                    ");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "product-content");
            __builder.OpenElement(66, "h3");
            __builder.OpenElement(67, "a");
            __builder.AddAttribute(68, "href", "/singleproductdetail/" + (
#nullable restore
#line 93 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\Pages\Shopview.razor"
                                                                           SingleProduct.ID

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(69, 
#nullable restore
#line 93 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\Pages\Shopview.razor"
                                                                                              SingleProduct.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                                        ");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "product-price");
            __builder.OpenElement(73, "span");
            __builder.AddContent(74, "PKr ");
            __builder.AddContent(75, 
#nullable restore
#line 95 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\Pages\Shopview.razor"
                                                       SingleProduct.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 100 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\Pages\Shopview.razor"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 100 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\Pages\Shopview.razor"
                         
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 107 "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\Pages\Shopview.razor"
           
    string currentuserid = "";
    Estore.Shared.Models.Catagory[] CatagoriesList;
    Estore.Shared.Models.Product[] ProductList;
    Estore.Shared.Models.Product[] SelectProductList = Array.Empty<Product>();
    protected override async Task OnInitializedAsync()
    {

        try
        {
            ProductList = await Http.GetFromJsonAsync<Estore.Shared.Models.Product[]>
("/api/Products/Index");
            CatagoriesList = await Http.GetFromJsonAsync<Estore.Shared.Models.Catagory[]>
("api/Catagories/Index");
            SelectProductList = ProductList;

            CurrentUser userdata = await authStateProvider.GetCurrentUser();
            currentuserid = userdata.Claims["http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier"].ToString();

        }
        catch (AccessTokenNotAvailableException exception)
        {
            exception.Redirect();
        }


    }
    protected async Task ViewCatagoryProduct(int id)
    {
        List<Product> SelectedProductList = new List<Product>() { };
        Estore.Shared.Models.Product[] SelectProductListarray = { } ;

        if (ProductList.Length != 0)
        {
            foreach (var singleProduct in ProductList)
            {


                var catagoryarray = singleProduct.CatagoryID.Split(",");
                foreach (var singleCatagory in catagoryarray)
                {
                    if (Convert.ToInt32(singleCatagory) == Convert.ToInt32(id))
                    {
                        SelectedProductList.Add(singleProduct);
                        SelectProductListarray = SelectedProductList.ToArray();
                    }
                }


            }

        }


        SelectProductList = SelectProductListarray;

    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CustomStateProvider authStateProvider { get; set; }
    }
}
#pragma warning restore 1591
