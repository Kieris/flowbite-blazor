## Blazor Toggle - Flowbite Tailwind

Use the toggle component to switch between a binary state of true or false using a single click available in multiple sizes, variants, and colors

The toggle component can be used to receive a simple “yes” or “no” type of answer from the user by choosing a single option from two options available in multiple sizes, styles, and colors.

The FormToggle version of the component can only be used inside an EditForm, and it includes validation. The version for outside EditForm is the Toggle component.

### Setup
Import the form components from Flowbite.Blazor.Forms
```razor
@using Flowbite.Blazor.Forms
```
### Toggle example

Use this default example of a toggle component in a checked and unchecked state. The label will be the DisplayAtttribute Name if LabelText is not defined.

#### With validation
```razor
<EditForm Model="@_form">
    <DataAnnotationsValidator></DataAnnotationsValidator>
    <div class="grid gap-6 mb-6 md:grid-cols-2">
        <FormToggle @bind-Value="_form.Checked1" LabelText="Default toggle"></FormToggle>
        <div>Default: @_form.Checked1</div>
        <FormToggle @bind-Value="_form.Checked2" SuccessMessage="Correct value!"></FormToggle>
        <div>Checked: @_form.Checked2</div>
    </div>
</EditForm>
```

#### Without validation
```razor
<div class="grid gap-6 mb-6 md:grid-cols-2">
    <Toggle Checked="@_form.Checked1" OnChanged="@((val) => _form.Checked1 = val)"
                LabelText="Default toggle"/>
    <div>Default: @_form.Checked1</div>
    <!-- With label from attribute -->
    <Toggle Checked="@_form.Checked2" OnChanged="@((val) => _form.Checked2 = val)"
                AttributeField="Checked2" AttributeModel="@_form"/>
    <div>Checked: @_form.Checked2</div>
</div>
```
    
```csharp
@code {
    TestFormCheckboxModel _form = new();
} 

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
#### With validation
```razor
<EditForm Model="@_form2">
    <FormToggle Class="mb-2" @bind-Value="_form2.Checked1" LabelText="Disabled toggle" Disabled></FormToggle>
    <FormToggle @bind-Value="_form2.Checked2" LabelText="Disabled checked" Disabled></FormToggle>
</EditForm>
```
#### Without validaton
```razor
<Toggle Class="mb-2" Checked="_form2.Checked1" LabelText="Disabled toggle" Disabled />
<Toggle Checked="_form2.Checked2" LabelText="Disabled checked" Disabled />
```

### Label side
The LabelLeft parameter can be used to define which side of the toggle the label will be. The default is on the right.

#### With validation
```razor
<EditForm Model="@_form3">
    <DataAnnotationsValidator></DataAnnotationsValidator>
    <div class="grid gap-6 mb-6 md:grid-cols-2">
        <FormToggle @bind-Value="_form3.Checked1" LabelLeft>
            <Label>
                <div class="w-32">Default left label</div>
            </Label>
        </FormToggle>
        <FormToggle @bind-Value="_form3.Checked2" LabelLeft>
            <Label>
                <div class="w-32">Checked left label</div>
            </Label>
        </FormToggle>
    </div>
</EditForm>
```

#### Without validation
```razor
<div class="grid gap-6 mb-6 md:grid-cols-2">
    <Toggle Checked="_form3.Checked1" LabelLeft OnChanged="@((val) => _form3.Checked1 = val)">
        <Label>
            <div class="w-32">Default left label</div>
        </Label>
    </Toggle>
    <Toggle Checked="_form3.Checked2" LabelLeft OnChanged="@((val) => _form3.Checked2 = val)">
        <Label>
            <div class="w-32">Checked left label</div>
        </Label>
    </Toggle>
</div>
```

### Colors
                            
Use the Color parameter to change the color of the toggle component.
### With validation
```razor
<EditForm Model="@_colors">
    <DataAnnotationsValidator></DataAnnotationsValidator>
    <List class="flex flex-wrap items-center">
        @foreach (CheckboxLabelColorModel item in _colors)
        {
            <ListItem>
                <FormToggle Class="px-4" Color="@item.Color" @bind-Value="@item.Checked" LabelText="@item.Label"></FormToggle>
            </ListItem>
        }
    </List>
</EditForm>
```

#### Without validation
```razor
<List class="flex flex-wrap items-center">
    @foreach (CheckboxLabelColorModel item in _colors)
    {
        <ListItem>
            <Toggle Class="px-4" Color="@item.Color" Checked="@item.Checked" OnChanged="@((val) => item.Checked = val)"
                    LabelText="@item.Label"></Toggle>
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

#### With validation
```razor
<EditForm Model="@_form3">
    <DataAnnotationsValidator></DataAnnotationsValidator>
    <div class="grid gap-6 mb-6 md:grid-cols-2">
        <FormToggle @bind-Value="_form.Checked1" LabelText="Small right label" Size="InputSizes.Small"/>
        <FormToggle @bind-Value="_form.Checked1" LabelLeft Size="InputSizes.Small">
            <Label>
                <div class="w-32">Small left label</div>
            </Label>
        </FormToggle>
        <FormToggle @bind-Value="_form2.Checked1" LabelText="Small right label" Size="InputSizes.Medium"/>
        <FormToggle @bind-Value="_form2.Checked1" LabelLeft Size="InputSizes.Medium">
            <Label>
                <div class="w-32">Medium left label</div>
            </Label>
        </FormToggle>
        <FormToggle @bind-Value="_form3.Checked1" LabelText="Small right label" Size="InputSizes.Large"/>
        <FormToggle @bind-Value="_form3.Checked1" LabelLeft Size="InputSizes.Large">
            <Label>
                <div class="w-32">Large left label</div>
            </Label>
        </FormToggle>
    </div>
</EditForm>
```
#### Without validation
```razor
<div class="grid gap-6 mb-6 md:grid-cols-2">
    <Toggle Checked="_form.Checked1" LabelText="Small right label" Size="InputSizes.Small" OnChanged="@((val) => _form.Checked1 = val)" />
    <Toggle Checked="_form.Checked1" LabelLeft Size="InputSizes.Small" OnChanged="@((val) => _form.Checked1 = val)">
        <Label>
            <div class="w-32">Small left label</div>
        </Label>
    </Toggle>
    <Toggle Checked="_form2.Checked1" LabelText="Small right label" Size="InputSizes.Medium" OnChanged="@((val) => _form2.Checked1 = val)" />
    <Toggle Checked="_form2.Checked1" LabelLeft Size="InputSizes.Medium" OnChanged="@((val) => _form2.Checked1 = val)">
        <Label>
            <div class="w-32">Medium left label</div>
        </Label>
    </Toggle>
    <Toggle Checked="_form3.Checked1" LabelText="Small right label" Size="InputSizes.Large" OnChanged="@((val) => _form3.Checked1 = val)"/>
    <Toggle Checked="_form3.Checked1" LabelLeft Size="InputSizes.Large" OnChanged="@((val) => _form3.Checked1 = val)">
        <Label>
            <div class="w-32">Large left label</div>
        </Label>
    </Toggle>
</div>
```