## Blazor Floating Label - Flowbite Tailwind

Use the floating label style for the input field elements to replicate the Material UI design system from Google and choose from multiple styles and sizes
    
The floating label style was first pioneered by Google in its infamous Material UI design system and it’s basically a label tag which floats just above the input field when it is being focused or already has content inside.

On this page you will find a three different input field styles including a standard, outlined, and filled style including validation styles and sizes coded with Tailwind CSS and supported for dark mode.
    
### Setup
Import the form components from Flowbite.Blazor.Forms
```razor
@using Flowbite.Blazor.Forms
```

### Floating label example
Get started with the following three styles for the floating label component.

```razor
<FloatingLabel Class="mb-4" FloatType="FloatType.Filled" LabelText="Floating filled" @bind-Value="@_defModel.Filled"></FloatingLabel>
<FloatingLabel Class="mb-4" FloatType="FloatType.Outline" LabelText="Floating outlined" @bind-Value="@_defModel.Outlined"></FloatingLabel>
<FloatingLabel Class="mb-4" FloatType="FloatType.Standard" LabelText="Floating standard" @bind-Value="@_defModel.Standard"></FloatingLabel>
```

    
### Disabled state
Apply the disabled attribute to the input fields to disallow the user from changing the content.

```razor
<FloatingLabel Class="mb-4" FloatType="FloatType.Filled" LabelText="Floating filled" @bind-Value="@_disabledModel.Filled" Disabled></FloatingLabel>
<FloatingLabel Class="mb-4" FloatType="FloatType.Outline" LabelText="Floating outlined" @bind-Value="@_disabledModel.Outlined" Disabled></FloatingLabel>
<FloatingLabel Class="mb-4" FloatType="FloatType.Standard" LabelText="Floating standard" @bind-Value="@_disabledModel.Standard" Disabled></FloatingLabel>
```
    
### Validation
Use the following examples of input validation. Wrap the FloatingLabel components in an EditForm and add the DataAnnotationsValidator.

```razor
<EditForm Model="@_model">
    <DataAnnotationsValidator></DataAnnotationsValidator>
    <FloatingLabel Class="mb-4" FloatType="FloatType.Filled" LabelText="Floating filled" @bind-Value="_model.Filled" SuccessMessage="Well done! Some success message."></FloatingLabel>
    <FloatingLabel Class="mb-4" FloatType="FloatType.Outline" LabelText="Floating outlined" @bind-Value="_model.Outlined" SuccessMessage="Well done! Some success message."></FloatingLabel>
    <FloatingLabel Class="mb-4" FloatType="FloatType.Standard" LabelText="Floating standard" @bind-Value="_model.Standard" SuccessMessage="Well done! Some success message."></FloatingLabel>
    <Button type="submit">Submit</Button>
</EditForm>
```
    
### Sizes
Get started with the following three styles for the floating label component.
 
```razor
<div class="grid items-end gap-6 mb-6 md:grid-cols-3">
    <EditForm Model="@_smallmodel">
        <DataAnnotationsValidator></DataAnnotationsValidator>
        <FloatingLabel Class="mb-4" FloatType="FloatType.Filled" LabelText="Small filled" @bind-Value="@_smallmodel.Filled" Size="InputSizes.Small"></FloatingLabel>
        <FloatingLabel Class="mb-4" FloatType="FloatType.Outline" LabelText="Small outlined" @bind-Value="@_smallmodel.Outlined" Size="InputSizes.Small"></FloatingLabel>
        <FloatingLabel Class="mb-4" FloatType="FloatType.Standard" LabelText="Small standard" @bind-Value="@_smallmodel.Standard" Size="InputSizes.Small"></FloatingLabel>
        <Button type="submit">Submit</Button>
    </EditForm>
    <EditForm Model="@_medmodel">
        <DataAnnotationsValidator></DataAnnotationsValidator>
        <FloatingLabel Class="mb-4" FloatType="FloatType.Filled" LabelText="Default filled" @bind-Value="@_medmodel.Filled" Size="InputSizes.Medium"></FloatingLabel>
        <FloatingLabel Class="mb-4" FloatType="FloatType.Outline" LabelText="Default outlined" @bind-Value="@_medmodel.Outlined" Size="InputSizes.Medium"></FloatingLabel>
        <FloatingLabel Class="mb-4" FloatType="FloatType.Standard" LabelText="Default standard" @bind-Value="@_medmodel.Standard" Size="InputSizes.Medium"></FloatingLabel>
        <Button type="submit">Submit</Button>
    </EditForm>
    <EditForm Model="@_largemodel">
        <DataAnnotationsValidator></DataAnnotationsValidator>
        <FloatingLabel Class="mb-4" FloatType="FloatType.Filled" LabelText="Large filled" @bind-Value="@_largemodel.Filled" Size="InputSizes.Large"></FloatingLabel>
        <FloatingLabel Class="mb-4" FloatType="FloatType.Outline" LabelText="Large outlined" @bind-Value="@_largemodel.Outlined" Size="InputSizes.Large"></FloatingLabel>
        <FloatingLabel Class="mb-4" FloatType="FloatType.Standard" LabelText="Large standard" @bind-Value="@_largemodel.Standard" Size="InputSizes.Large"></FloatingLabel>
        <Button type="submit">Submit</Button>
    </EditForm>
</div>
```

### Helper text
Add a helper text in addition to the label if you want to show more information below the input field.

```razor
<FloatingLabel Class="mb-4" FloatType="FloatType.Filled" LabelText="Floating filled" @bind-Value="@_helperModel.Filled"
                DescriptionText="This is some helper text."></FloatingLabel>
<FloatingLabel Class="mb-4" FloatType="FloatType.Outline" LabelText="Floating outlined" @bind-Value="@_helperModel.Outlined">
    <Description>
        <p class="mt-2 text-xs text-neutral-500 dark:text-neutral-400">Remember, contributions to this topic should follow our <Anchor href="#">Community Guidelines</Anchor>.</p>
    </Description>
</FloatingLabel>
<FloatingLabel Class="mb-4" FloatType="FloatType.Standard" LabelText="Floating standard" @bind-Value="@_helperModel.Standard">
    <Description>
        <p class="mt-2 text-xs text-neutral-500 dark:text-neutral-400">Remember, contributions to this topic should follow our <Anchor href="#">Community Guidelines</Anchor>.</p>
    </Description>
</FloatingLabel>
```
    
### OnChanged callback
The Onchanged callback allows you to get the value of the input when it is changed.

            
```razor
<FloatingLabel Class="mb-4" FloatType="FloatType.Filled" LabelText="Floating filled" @bind-Value="@_value" OnChanged="((val) => _callVal = val)"/>
<Paragraph>Value: @_value</Paragraph>
<Paragraph>Callback return: @_callVal</Paragraph>
```