namespace Flowbite.Blazor.Components.ListGroup;

/// <summary>
/// Defines parameters for a ListGroupItem
/// </summary>
public class ListGroupItemModel
{
    /// <summary>
    /// Defines whether the item should be set as active/selected
    /// </summary>
    public bool Current { get; set; }
    
    /// <summary>
    /// Defines whether the item should be disabled and have no state changes
    /// </summary>
    public bool Disabled { get; set; }
    
    /// <summary>
    /// Defines whether the item is a link
    /// </summary>
    public string? Href { get; set; }

    /// <summary>
    /// Defines the name of the item similar to an ID. "Name" is the default value.
    /// </summary>
    public string Name { get; set; } = "Name";

}