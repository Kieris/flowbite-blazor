## Blazor Input Field - Flowbite Tailwind
  
Get started with a collection of input fields built with Tailwind CSS to start accepting data from the user based on multiple sizes, variants, and input types

The input field is an important part of the form element that can be used to create interactive controls to accept data from the user based on multiple input types, such as text, email, number, password, URL, phone number, and more.

On this page you will find all of the input types based on multiple variants, styles, colors, and sizes built with the utility classes from Tailwind CSS and components from Flowbite.
    
### Setup
Import the form components from Flowbite.Blazor.Forms

```razor
@using Flowbite.Blazor.Forms
```
### Input Fields
Use this example as a generic form element which includes multiple input fields types such as text, email, password, number, URL, and phone number and use the grid layout to add multiple columns and rows.

```razor
<div class="grid gap-6 mb-6 md:grid-cols-2">
    <TextInput LabelText="First Name Label" @bind-Value="_form.FirstName"></TextInput>
    <TextInput @bind-Value="_form.LastName"></TextInput>
    <TextInput @bind-Value="_form.Company"></TextInput>
    <TextInput @bind-Value="_form.Phone" Type="tel"></TextInput>
    <TextInput @bind-Value="_form.SiteUrl" Placeholder="https://google.com" Type="url"></TextInput>
    <NumberInput @bind-Value="_form.Visitors"></NumberInput>
</div>
<TextInput Spacing="mb-6" @bind-Value="_form.Email" Type="email"></TextInput>
<TextInput Spacing="mb-6" @bind-Value="_form.NewPassword" Type="password"/>
<TextInput Spacing="mb-6" @bind-Value="_form.ConfirmPassword" Type="password" SuccessMessage="Match!"/>
```
    
### With validation
Wrap the form controls in an EditForm and use the DataAnnotationsValidator component to validate the form. All fields but company and phone have validation.
    
```razor
<EditForm Model="@_form" OnValidSubmit="@ChangePassword">
    <DataAnnotationsValidator></DataAnnotationsValidator>
    <div class="grid gap-6 mb-6 md:grid-cols-2">
        <TextInput LabelText="First Name Label" @bind-Value="_form.FirstName"></TextInput>
        <TextInput @bind-Value="_form.LastName"></TextInput>
        <TextInput @bind-Value="_form.Company"></TextInput>
        <TextInput @bind-Value="_form.Phone" Type="tel"></TextInput>
        <TextInput @bind-Value="_form.SiteUrl" Placeholder="https://google.com" Type="url"></TextInput>
        <NumberInput @bind-Value="_form.Visitors"></NumberInput>
    </div>
    <TextInput Spacing="mb-6" @bind-Value="_form.Email" AlertStyle Type="email"></TextInput>
    <TextInput Spacing="mb-6" @bind-Value="_form.NewPassword" Type="password" MessageTop/>
    <TextInput Spacing="mb-6" @bind-Value="_form.ConfirmPassword" Type="password" MessageTop SuccessMessage="Match!"/>
    <Button type="submit">Submit</Button>
</EditForm>
```
    
```csharp
public class TestForm
{
    [Display(Prompt = "John")]
    [Required(ErrorMessage = "First name is required.")]
    public string? FirstName { get; set; }
    
    [Display(Prompt = "Doe", Name = "Last Name")]
    [Required(ErrorMessage = "Last name is required.")]
    public string? LastName { get; set; }
    
    [Display(Prompt = "Microsoft", Name = "Company")]
    public string? Company { get; set; }
    
    [Display(Prompt = "123 Mockingbird", Name = "Helper text from DisplayAttribute", Description = "This is the mailing address.")]
    public string? MailingAddress { get; set; }
    
    [Display(Prompt = "123-45-6789", Name = "Phone")]
    [Phone]
    public string? Phone { get; set; }
    
    [Display(Prompt = "johndoe@company.com", Name= "Email")]
    [EmailAddress]
    [Required(ErrorMessage = "Email is required.")]
    public string? Email { get; set; }
    
    [Display(Name = "Visitors")]
    [Range(0, 1000000, ErrorMessage = "The number of visitors must be reasonable.")]
    public int Visitors { get; set; }
    
    [Display(Prompt = "blazor.com", Name= "Website Url")]
    [Url]
    [Required(ErrorMessage = "Site url is required.")]
    public string? SiteUrl { get; set; }

    [MinLength(10, ErrorMessage = "Password must be minimum of 10 characters.")]
    [Display(Name = "New Password")]
    [DataType(DataType.Password)]
    [Required(ErrorMessage = "Give new password.")]
    public string? NewPassword { get; set; }
    
    [Compare("NewPassword", ErrorMessage = "Passwords do not match.")]
    [Display(Name = "Confirm Password")]
    [DataType(DataType.Password)]
    [Required(ErrorMessage = "Confirm new password.")]
    public string? ConfirmPassword { get; set; }
}
```
    
### Input sizes
Use the following examples to apply various sizes for the input fields.
   
```razor
<TextInput Size="InputSizes.Large" ShowError="false" @bind-Value="_form.FirstName" LabelText="Large input"></TextInput>
<TextInput Size="InputSizes.Medium" ShowError="false" @bind-Value="_form.LastName" LabelText="Medium input (Default)"></TextInput>
<TextInput Size="InputSizes.Small" ShowError="false" @bind-Value="_form.Company" LabelText="Small input"></TextInput>
<TextInput CustomSize="p-1 text-xs" ShowError="false" @bind-Value="_form.SiteUrl" LabelText="Custom size"></TextInput>
```
    
### Disabled
Use the following examples to disable the input.

```razor
<TextInput Disabled @bind-Value="_form.Company" IncludeLabel="false" Placeholder="Disabled" Spacing="mb-6"></TextInput>
<TextInput Disabled readonly @bind-Value="_form.SiteUrl" IncludeLabel="false" Placeholder="Disabled read only"></TextInput>
```
    
### Input group
Use the following examples to disable the input.
    
```razor
<TextInput @bind-Value="_form.FirstName">
    <Icon>
        <UserSolid class="w-4 h-4 text-gray-500 dark:text-gray-400"></UserSolid>
    </Icon>
</TextInput>
<TextInput @bind-Value="_form.Email" Type="email" GroupType="InputGroupTypes.Right">
    <Icon>
        <EnvelopeSolid class="w-4 h-4 text-gray-500 dark:text-gray-400"></EnvelopeSolid>
    </Icon>
</TextInput>
<TextInput @bind-Value="_form.Email" Type="email" GroupType="InputGroupTypes.LeftWithBg">
    <Icon>
        <EnvelopeSolid class="w-4 h-4 text-gray-500 dark:text-gray-400"></EnvelopeSolid>
    </Icon>
</TextInput>
<TextInput @bind-Value="_form.LastName" GroupType="InputGroupTypes.RightWithBg">
    <Icon>
        <UserSolid class="w-4 h-4 text-gray-500 dark:text-gray-400"></UserSolid>
    </Icon>
</TextInput>
```
    
### Helper text
Use this example to show a helper text below the input field for additional explanation and links.

```razor
<TextInput @bind-Value="_form.MailingAddress"></TextInput>
<TextInput @bind-Value="_form.Company" LabelText="Helper text from parameter" DescriptionText="This is the company name."></TextInput>
<TextInput @bind-Value="_form.Email">
    <Description>
        <Paragraph class="text-sm text-gray-500 dark:text-gray-400">We’ll never share your details. Read our <Anchor href="#">Privacy Policy</Anchor></Paragraph>
    </Description>
</TextInput>
```

### OnChanged callback
                
The Onchanged callback allows you to get the value of the input when it is changed.

```razor            
<TextInput @bind-Value="_value" OnChanged="((val) => _callVal = val)"/>
<Paragraph>Value: @_value</Paragraph>
<Paragraph>Callback return: @_callVal</Paragraph>
```