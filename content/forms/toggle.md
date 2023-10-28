## Blazor Toggle - Flowbite Tailwind

Use the toggle component to switch between a binary state of true or false using a single click available in multiple sizes, variants, and colors

The toggle component can be used to receive a simple “yes” or “no” type of answer from the user by choosing a single option from two options available in multiple sizes, styles, and colors.

### Setup
Import the form components from Flowbite.Blazor.Forms

```razor
@using Flowbite.Blazor.Forms
```

### Toggle example
Use this default example of a toggle component in a checked and unchecked state. The label will be the DisplayAtttribute Name if LabelText is not defined.
    
```razor
<div class="grid gap-6 mb-6 md:grid-cols-2">
    <Toggle @bind-Value="_form.Checked1" LabelText="Default toggle"></Toggle>
    <div>Default: @_form.Checked1</div>
    <Toggle @bind-Value="_form.Checked2"></Toggle>
    <div>Checked: @_form.Checked2</div>
</div>
```
    
    
### With validation
Wrap the form controls in an EditForm and use the DataAnnotationsValidator component to validate the form.

```razor
<EditForm Model="@_form">
    <DataAnnotationsValidator></DataAnnotationsValidator>
    <div class="grid gap-6 mb-6 md:grid-cols-2">
        <Toggle @bind-Value="_form.Checked1" LabelText="Default toggle"></Toggle>
        <div>Default: @_form.Checked1</div>
        <Toggle @bind-Value="_form.Checked2" SuccessMessage="Correct value!"></Toggle>
        <div>Checked: @_form.Checked2</div>
    </div>
</EditForm>

@code {
    TestFormCheckboxModel _form = new();
} 
```

```csharp
public class TestFormCheckboxModel
{
    public bool Checked1 { get; set; }

    [Display(Name="Checked state")]
    [Range(typeof(bool), "true", "true", ErrorMessage = "This checkbox must be true.")]
    public bool Checked2 { get; set; } = true;
}
```

### Disabled state
This example can be used for the disabled state of the toggle component by applying the disabled attribute to the input element.
 
```razor
<Toggle Class="mb-2" @bind-Value="_form2.Checked1" LabelText="Disabled toggle" Disabled></Toggle>
<Toggle @bind-Value="_form2.Checked2" LabelText="Disabled checked" Disabled></Toggle>
```

### Label side
The LabelLeft parameter can be used to define which side of the toggle the label will be. The default is on the right.
  
```razor
<div class="grid gap-6 mb-6 md:grid-cols-2">
    <Toggle @bind-Value="_form3.Checked1" LabelLeft>
        <Label>
            <div class="w-32">Default left label</div>
        </Label>
    </Toggle>
    <Toggle @bind-Value="_form3.Checked2" LabelLeft>
        <Label>
            <div class="w-32">Checked left label</div>
        </Label>
    </Toggle>
</div>
```

### Colors
Use the Color parameter to change the color of the toggle component.
    
```razor
<List class="flex flex-wrap items-center">
    @foreach (CheckboxLabelColorModel item in _colors)
    {
        <ListItem>
            <Toggle Class="px-4" Color="@item.Color" @bind-Value="@item.Checked" LabelText="@item.Label"></Toggle>
        </ListItem>
    }
</List>
```
```razor
@code {
    List<FormCheckboxLabelColorModel> _colors = new();

    protected override void OnInitialized()
    {
        _colors.Add(new FormCheckboxLabelColorModel() { Label = "Primary", Color = "primary", Checked = true });
        _colors.Add(new FormCheckboxLabelColorModel() { Label = "Danger", Color = "danger", Checked = true });
        _colors.Add(new FormCheckboxLabelColorModel() { Label = "Warning", Color = "warning", Checked = true });
        _colors.Add(new FormCheckboxLabelColorModel() { Label = "Accent", Color = "accent", Checked = true });
        _colors.Add(new FormCheckboxLabelColorModel() { Label = "Supporting", Color = "supporting", Checked = true });
        _colors.Add(new FormCheckboxLabelColorModel() { Label = "Success", Color = "success", Checked = true });
    }

}
```
```csharp
public class FormCheckboxLabelColorModel
{
    public string Label { get; set; } = "Label";

    public string Color { get; set; } = "primary";
    
    public bool Checked { get; set; }
}
```

### Sizes
The size of the toggle can be adjusted by using the Size parameter.
    
```razor
<div class="grid gap-6 mb-6 md:grid-cols-2">
    <Toggle @bind-Value="_form.Checked1" LabelText="Small right label" Size="InputSizes.Small"/>
    <Toggle @bind-Value="_form.Checked1" LabelLeft Size="InputSizes.Small">
        <Label>
            <div class="w-32">Small left label</div>
        </Label>
    </Toggle>
    <Toggle @bind-Value="_form2.Checked1" LabelText="Small right label" Size="InputSizes.Medium"/>
    <Toggle @bind-Value="_form2.Checked1" LabelLeft Size="InputSizes.Medium">
        <Label>
            <div class="w-32">Medium left label</div>
        </Label>
    </Toggle>
    <Toggle @bind-Value="_form3.Checked1" LabelText="Small right label" Size="InputSizes.Large"/>
    <Toggle @bind-Value="_form3.Checked1" LabelLeft Size="InputSizes.Large">
        <Label>
            <div class="w-32">Large left label</div>
        </Label>
    </Toggle>
</div>
```
    
### OnChanged callback
The OnChanged callback is triggered whenever the checked value of the toggle changes as shown in the example below.
    
```razor
<div class="flex justify-center items-center gap-6">
    <Toggle @bind-Value="_form.Checked1" LabelText="Callback checkbox" OnChanged="@((val) => _callVal = val)" ></Toggle>
    <div class="text-sm">Callback value: @_callVal</div>
</div>
```