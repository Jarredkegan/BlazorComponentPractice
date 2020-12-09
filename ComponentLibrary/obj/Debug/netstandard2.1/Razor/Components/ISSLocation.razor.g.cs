#pragma checksum "G:\ComponentLibrary\ComponentLibrary\Components\ISSLocation.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "edd4a0eca98524c096190760b394e9bf714cc7a3"
// <auto-generated/>
#pragma warning disable 1591
namespace ComponentLibrary.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 3 "G:\ComponentLibrary\ComponentLibrary\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\ComponentLibrary\ComponentLibrary\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\ComponentLibrary\ComponentLibrary\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "G:\ComponentLibrary\ComponentLibrary\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "G:\ComponentLibrary\ComponentLibrary\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "G:\ComponentLibrary\ComponentLibrary\_Imports.razor"
using ComponentLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "G:\ComponentLibrary\ComponentLibrary\_Imports.razor"
using ComponentLibrary.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "G:\ComponentLibrary\ComponentLibrary\_Imports.razor"
using ComponentLibrary.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "G:\ComponentLibrary\ComponentLibrary\_Imports.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "G:\ComponentLibrary\ComponentLibrary\Components\ISSLocation.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\ComponentLibrary\ComponentLibrary\Components\ISSLocation.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
    public partial class ISSLocation : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>API Call - ISS Location</h3>\r\n");
            __builder.AddMarkupContent(1, "<p><em>Demonstrates an API call that returns a JSON response.</em></p>\r\n<hr class=\"my-4\">\r\n");
            __builder.AddMarkupContent(2, "<p>Current location of the International Space Station</p>\r\n\r\n");
#nullable restore
#line 11 "G:\ComponentLibrary\ComponentLibrary\Components\ISSLocation.razor"
 if (location == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.AddMarkupContent(4, "<p>Loading...</p>\r\n");
#nullable restore
#line 14 "G:\ComponentLibrary\ComponentLibrary\Components\ISSLocation.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "    ");
            __builder.OpenElement(6, "table");
            __builder.AddAttribute(7, "class", "table table-striped");
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.AddMarkupContent(9, "<thead>\r\n            <tr>\r\n                <th>Longitude</th>\r\n                <th>Latitude</th>\r\n                <th>Time Stamp</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(10, "tbody");
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "tr");
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 27 "G:\ComponentLibrary\ComponentLibrary\Components\ISSLocation.razor"
                     location.iss_position.longitude

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 28 "G:\ComponentLibrary\ComponentLibrary\Components\ISSLocation.razor"
                     location.iss_position.latitude

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 29 "G:\ComponentLibrary\ComponentLibrary\Components\ISSLocation.razor"
                     location.timestamp

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n    <hr class=\"my-4\">\r\n");
#nullable restore
#line 34 "G:\ComponentLibrary\ComponentLibrary\Components\ISSLocation.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "G:\ComponentLibrary\ComponentLibrary\Components\ISSLocation.razor"
       

    public class ISSLocationModel
    {
        public string message { get; set; }
        public Iss_Position iss_position { get; set; }
        public int timestamp { get; set; }
    }

    public class Iss_Position
    {
        public string longitude { get; set; }
        public string latitude { get; set; }
    }

    ISSLocationModel location;

    protected override async Task OnInitializedAsync()
    {
        location = await Http.GetFromJsonAsync<ISSLocationModel>("http://api.open-notify.org/iss-now.json");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
