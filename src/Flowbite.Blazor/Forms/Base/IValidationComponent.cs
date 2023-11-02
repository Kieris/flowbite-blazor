using Microsoft.AspNetCore.Components;

namespace Flowbite.Blazor.Forms.Base;

public interface IValidationComponent<TValue>
{
    public bool AlertStyle { get; set; }
    public string? DescriptionText { get; set; }
    public string? SuccessMessage { get; set; }
    public bool ShowError { get; set; }
    public RenderFragment? Description { get; set; }
    public bool Success();
    public bool Errors();
}