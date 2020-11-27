#pragma checksum "G:\ComponentLibrary\ComponentLibrary\Components\PeopleInSpace.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6c88f895bc7fa8616cf6976d658b998fe8ee478"
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
#line 1 "G:\ComponentLibrary\ComponentLibrary\Components\PeopleInSpace.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\ComponentLibrary\ComponentLibrary\Components\PeopleInSpace.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
    public partial class PeopleInSpace : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "G:\ComponentLibrary\ComponentLibrary\Components\PeopleInSpace.razor"
       

    /// <summary>
    /// Model
    /// </summary>
    public class PeopleInSpaceModel
    {
        public int Number { get; set; }
        public Person[] People { get; set; }
    }

    /// <summary>
    /// Model
    /// </summary>
    public class Person
    {
        public string Craft { get; set; }
        public string Name { get; set; }
    }

    /// <summary>
    /// Counter
    /// </summary>
    int num = 0;

    PeopleInSpaceModel peopleInSpace;

    protected override async Task OnInitializedAsync() 
    {
        peopleInSpace = await Http.GetFromJsonAsync<PeopleInSpaceModel>("http://api.open-notify.org/astros.json");
        GetTotalPeople();
    }


    public void GetTotalPeople()
    {

        foreach (var person in peopleInSpace.People)
        {
            num++;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
