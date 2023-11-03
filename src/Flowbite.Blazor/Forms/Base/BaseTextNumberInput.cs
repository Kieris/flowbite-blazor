using Microsoft.AspNetCore.Components;

namespace Flowbite.Blazor.Forms.Base;

public class BaseTextNumberInput<TValue>: BaseInput<TValue>
{
    /// <summary>
    /// Content placed inside the <Icon></Icon> fragment. This will include content on either side of the input based
    /// on <see cref="GroupType"/>
    /// </summary>
    [Parameter] public RenderFragment? Icon { get; set; }
    
    /// <summary>
    /// Used to define the placement of the content inside <see cref="Icon"/> with relation to the input
    /// </summary>
    [Parameter]
    public InputGroupTypes GroupType { get; set; } = InputGroupTypes.Left;
    
    /// <summary>
    /// Defines classes to make the input a custom size. (e.g. p-2 text-sm)
    /// </summary>
    [Parameter] public string? CustomSize { get; set; }
}