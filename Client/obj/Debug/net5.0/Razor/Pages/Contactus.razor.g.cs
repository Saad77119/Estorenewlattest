#pragma checksum "C:\Users\saadr\Downloads\estorenew-master\estorenew-master\Client\Pages\Contactus.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae46d2eb14a3b5c78f5dc406b82a2fc3636ba340"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/contactus")]
    public partial class Contactus : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<section class=""hero-slider""><div class=""single-slider""><div class=""container""><div class=""row no-gutters""><div class=""col-lg-9 offset-lg-3 col-12""><div class=""text-inner""><div class=""row""><div class=""col-lg-7 col-12""><div class=""hero-text""><h1><span>Welcome To   </span>Estore</h1>
                                    <p>Pakistan's best online shopping store with 1+ million  <br>  products at resounding discounts  with cash on delivery (COD).</p>
                                    <div class=""button""><a href=""/shopview"" class=""btn"">Shop Now!</a></div></div></div></div></div></div></div></div></div></section>
");
            __builder.AddMarkupContent(1, "<section id=\"contact-us\" class=\"contact-us section\"><div class=\"container\"><div class=\"contact-head\"><div class=\"row\"><div class=\"col-lg-8 col-12\"><div class=\"form-main\"><div class=\"title\"><h4>Get in touch</h4>\r\n                            <h3>Write us a message</h3></div>\r\n                        <form class=\"form\" method=\"post\" action=\"mail/mail.php\"><div class=\"row\"><div class=\"col-lg-6 col-12\"><div class=\"form-group\"><label>Your Name<span>*</span></label>\r\n                                        <input name=\"name\" type=\"text\" placeholder></div></div>\r\n                                <div class=\"col-lg-6 col-12\"><div class=\"form-group\"><label>Your Subjects<span>*</span></label>\r\n                                        <input name=\"subject\" type=\"text\" placeholder></div></div>\r\n                                <div class=\"col-lg-6 col-12\"><div class=\"form-group\"><label>Your Email<span>*</span></label>\r\n                                        <input name=\"email\" type=\"email\" placeholder></div></div>\r\n                                <div class=\"col-lg-6 col-12\"><div class=\"form-group\"><label>Your Phone<span>*</span></label>\r\n                                        <input name=\"company_name\" type=\"text\" placeholder></div></div>\r\n                                <div class=\"col-12\"><div class=\"form-group message\"><label>your message<span>*</span></label>\r\n                                        <textarea name=\"message\" placeholder></textarea></div></div>\r\n                                <div class=\"col-12\"><div class=\"form-group button\"><button type=\"submit\" class=\"btn \">Send Message</button></div></div></div></form></div></div>\r\n                <div class=\"col-lg-4 col-12\"><div class=\"single-head\"><div class=\"single-info\"><i class=\"fa fa-phone\"></i>\r\n                            <h4 class=\"title\">Call us Now:</h4>\r\n                            <ul><li>+123 456-789-1120</li>\r\n                                <li>+522 672-452-1120</li></ul></div>\r\n                        <div class=\"single-info\"><i class=\"fa fa-envelope-open\"></i>\r\n                            <h4 class=\"title\">Email:</h4>\r\n                            <ul><li><a href=\"mailto:info@yourwebsite.com\">info@yourwebsite.com</a></li>\r\n                                <li><a href=\"mailto:info@yourwebsite.com\">support@yourwebsite.com</a></li></ul></div>\r\n                        <div class=\"single-info\"><i class=\"fa fa-location-arrow\"></i>\r\n                            <h4 class=\"title\">Our Address:</h4>\r\n                            <ul><li>KA-62/1, Travel Agency, 45 Grand Central Terminal, New York.</li></ul></div></div></div></div></div></div></section>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
