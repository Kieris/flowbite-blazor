using Microsoft.AspNetCore.Components;

namespace Flowbite.Blazor.Components.Base;

/// <summary>
/// The base/parent class for typography components
/// </summary>
public abstract class BaseTypography: ComponentBase
{
    /// <summary>
    /// Gets or sets the reference to the rendered element.
    /// </summary>
    public ElementReference ElementRef { get; set; }
    
    /// <summary>
    /// Used to add other classes to the component or override existing classes of the component's top element
    /// </summary>
    [Parameter]
    public string Class { get; set; } = string.Empty;
    
    /// <summary>
    /// Attributes added to the component that don't match any of its parameters. Attributes with name style or class
    /// will be appended to Style and Class attributes if they are a string
    /// </summary>
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object> UserAttributes { get; set; } = new();
    
    /// <summary>
    /// The content
    /// </summary>
    [Parameter]
    public RenderFragment? ChildContent { get; set; }
    
    /// <summary>
    /// If the UserAttributes contain an ID, make it accessible
    /// </summary>
    public string ElementId => (UserAttributes?.ContainsKey("id") == true ? UserAttributes["id"]?.ToString() ?? $"blaz-{Guid.NewGuid()}" : $"blaz-{Guid.NewGuid()}");

}