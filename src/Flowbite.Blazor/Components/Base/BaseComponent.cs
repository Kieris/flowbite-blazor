using Microsoft.AspNetCore.Components;

namespace Flowbite.Blazor.Components.Base;

public abstract class BaseComponent : ComponentBase
{
    /// <summary>
    /// Classes for the component's top element to only be used when it is active
    /// </summary>
    [Parameter]
    public string ActiveClass { get; set; } = string.Empty;
    
    /// <summary>
    /// Classes for the component's top element to only be used when it is not active
    /// </summary>
    [Parameter]
    public string InactiveClass { get; set; } = string.Empty;
    
    /// <summary>
    /// Styles for the component's top element
    /// </summary>
    [Parameter]
    public string Style { get; set; } = string.Empty;
    
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
    public Dictionary<string, object> UserAttributes { get; set; } = new ();
    
    /// <summary>
    /// Classes for the component's top element to only be used when it is not active
    /// </summary>
    [Parameter]
    public bool Active { get; set; }
    
    /// <summary>
    /// If the UserAttributes contain an ID make it accessible for WCAG labelling of input fields
    /// </summary>
    public string FieldId => (UserAttributes?.ContainsKey("id") == true ? UserAttributes["id"]?.ToString() ?? $"blaz-{Guid.NewGuid()}" : $"blaz-{Guid.NewGuid()}");

    /// <summary>
    /// Used to set the active flag of the component
    /// </summary>
    public void SetActive(bool active) => Active = active;
}