#pragma checksum "D:\TuringPrueba\TuringTest\TuringTest\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15949f5398d2c6866e4f35a326ca7252c131ebba"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TuringTest.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\TuringPrueba\TuringTest\TuringTest\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\TuringPrueba\TuringTest\TuringTest\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\TuringPrueba\TuringTest\TuringTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\TuringPrueba\TuringTest\TuringTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\TuringPrueba\TuringTest\TuringTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\TuringPrueba\TuringTest\TuringTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\TuringPrueba\TuringTest\TuringTest\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\TuringPrueba\TuringTest\TuringTest\_Imports.razor"
using TuringTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\TuringPrueba\TuringTest\TuringTest\_Imports.razor"
using TuringTest.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\TuringPrueba\TuringTest\TuringTest\Pages\Index.razor"
using TuringTest.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\TuringPrueba\TuringTest\TuringTest\Pages\Index.razor"
using TuringTest.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "D:\TuringPrueba\TuringTest\TuringTest\Pages\Index.razor"
       
    string _input;
    string Intents;
    string Entities;
    string SentimentalRate;

    TextUtility textUtility;

    protected override async Task OnInitializedAsync()
    {
        textUtility = new TextUtility();
    }

    private async Task AddItem()
    {
        textUtility = await _TextUtilitiesService.GetAsync(_input);
        Intents = string.Join(",", textUtility.Intents);
        Entities = string.Join(",", textUtility.Entities);
        SentimentalRate = textUtility.SentimentalRate.ToString();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TextUtilitiesService _TextUtilitiesService { get; set; }
    }
}
#pragma warning restore 1591
