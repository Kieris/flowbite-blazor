using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using Microsoft.AspNetCore.Components;

namespace Flowbite.Blazor.Forms.Base;

public class FormSelectBase<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] TValue>:BaseInput<TValue>
{
    /// <summary>
    /// Gets or sets the child content to be rendering inside the select element.
    /// </summary>
    [Parameter] public RenderFragment? ChildContent { get; set; }
    
    /// <summary>
    /// Defines if the select uses the underline style
    /// </summary>
    [Parameter]
    public bool Underline { get; set; }
    
    /// <summary>
    /// The number of options shown in the select based on the select size attribute
    /// </summary>
    [Parameter]
    public int? Rows { get; set; } = null;
    
    /// <summary>
    /// Returns the selected value when the value changes
    /// </summary>
    [Parameter]
    public EventCallback<object> OnChanged { get; set; }
    
    /// <summary>
    /// Defines if the select is a multiple select
    /// </summary>
    internal readonly bool IsMultipleSelect;

    /// <summary>
    /// Constructs an instance of <see cref="FormSelectBase{TValue}"/>.
    /// </summary>
    public FormSelectBase()
    {
        if(typeof(TValue).IsArray)
        {
            IsMultipleSelect = true;
            Rows = 0;
        }
    }
    
    /// <inheritdoc />
    protected override bool TryParseValueFromString(string? value, [MaybeNullWhen(false)] out TValue result, [NotNullWhen(false)] out string? validationErrorMessage)
        => this.TryParseSelectableValueFromString(value, this.FieldIdentifier.FieldName, out result, out validationErrorMessage);

    /// <inheritdoc />
    protected override string? FormatValueAsString(TValue? value)
    {
        // We special-case bool values because BindConverter reserves bool conversion for conditional attributes.
        if (typeof(TValue) == typeof(bool))
        {
            return (bool)(object)value! ? "true" : "false";
        }
        else if (typeof(TValue) == typeof(bool?))
        {
            return value is not null && (bool)(object)value ? "true" : "false";
        }

        return base.FormatValueAsString(value);
    }

    /// <summary>
    /// Converts the value to a string array
    /// </summary>
    /// <param name="value"></param>
    internal void SetCurrentValueAsStringArray(string?[]? value)
    {
        CurrentValue = BindConverter.TryConvertTo<TValue>(value, CultureInfo.CurrentCulture, out var result)
            ? result
            : default;
    }
    
}