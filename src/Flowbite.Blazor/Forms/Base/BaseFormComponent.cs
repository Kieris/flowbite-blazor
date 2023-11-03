using Microsoft.AspNetCore.Components;

namespace Flowbite.Blazor.Forms.Base;

public class BaseFormComponent
{
    /// <summary>
    /// The style classes for the top level div of the element.
    /// </summary>
    [Parameter] public string? Class { get; set; }
    
    /// <summary>
    /// Defines whether to show errors before input has had focus. The default is true.
    /// If set to false, errors will only show when a button has had focus independent of
    /// if the submit button has been clicked.
    /// </summary>
    [Parameter]
    public bool ShowError { get; set; } = true;
    
    /// <summary>
    /// The id of the input which is used to connect label and input. The default is Guid.NewGuid().
    /// </summary>
    [Parameter]
    public string? Id { get; set; } = Guid.NewGuid().ToString();
    
    /// <summary>
    /// Used to display a description under the input as more than a simple string like with <see cref="DescriptionText"/>
    /// </summary>
    [Parameter] public RenderFragment? Description { get; set; }
    
    /// <summary>
    /// Defines whether the input is disabled
    /// </summary>
    [Parameter] public bool Disabled { get; set; }
    
    /// <summary>
    /// The text shown as a description under the input. This text will be overridden by any content in
    /// the <see cref="Description"/> fragment. This will use Description from the DisplayAttribute if defined. 
    /// </summary>
    [Parameter] public string? DescriptionText { get; set; }
    
    /// <summary>
    /// Defines a success message for when the input value is valid
    /// </summary>
    [Parameter] public string? SuccessMessage { get; set; }
    
    /// <summary>
    /// Defines the text, if any, shown for the label. This will use Name from the DisplayAttribute if defined.
    /// </summary>
    [Parameter] public string? LabelText { get; set; }
    
    /// <summary>
    /// Defines whether error and success messages should be displayed inside of an Alert component
    /// </summary>
    [Parameter]
    public bool AlertStyle { get; set; }
}