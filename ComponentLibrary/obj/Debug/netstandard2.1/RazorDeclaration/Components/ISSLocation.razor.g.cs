#pragma checksum "g:\ComponentLibrary\ComponentLibrary\Components\ISSLocation.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "edd4a0eca98524c096190760b394e9bf714cc7a3"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ComponentLibrary.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 3 "g:\ComponentLibrary\ComponentLibrary\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "g:\ComponentLibrary\ComponentLibrary\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "g:\ComponentLibrary\ComponentLibrary\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "g:\ComponentLibrary\ComponentLibrary\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "g:\ComponentLibrary\ComponentLibrary\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "g:\ComponentLibrary\ComponentLibrary\_Imports.razor"
using ComponentLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "g:\ComponentLibrary\ComponentLibrary\_Imports.razor"
using ComponentLibrary.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "g:\ComponentLibrary\ComponentLibrary\_Imports.razor"
using ComponentLibrary.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "g:\ComponentLibrary\ComponentLibrary\Components\ISSLocation.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "g:\ComponentLibrary\ComponentLibrary\Components\ISSLocation.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
    public partial class ISSLocation : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "g:\ComponentLibrary\ComponentLibrary\Components\ISSLocation.razor"
       

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
