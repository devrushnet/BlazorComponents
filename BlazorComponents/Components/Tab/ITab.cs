using Microsoft.AspNetCore.Components;

namespace BlazorComponents.Components.Tab
{
    public interface ITab
    {
        RenderFragment ChildContent { get; }
    }
}
