using Microsoft.AspNetCore.Components;

namespace BlazorComponents.ClassLibrary.Components.Pager
{
    public interface ITab
    {
        RenderFragment ChildContent { get; }
    }
}
