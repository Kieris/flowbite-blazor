## Buttons

#### Use the button component inside forms, as links, social login, payment options with support for multiple styles, colors, sizes, gradients, and shadows.
#### The button component is probably the most widely used element in any user interface or website as it can be used to launch an action but also to link to other pages.
#### Flowbite provides a large variety of styles and sizes for the button component including outlined buttons, multiple colors, sizes, buttons with icons, and more.
    
### Setup

#### Import the Buttons and SharedEnums namespaces from Flowbite.Blazor.

```razor
@using Flowbite.Blazor.Components.Buttons
```

### Default Buttons

#### Use these default button styles with multiple colors to indicate an action or link within your website.
```razor
<Button>Primary</Button>
<Button Color=@Colors.Neutral>Neutral</Button>
<Button Color=@Colors.Light>Light</Button>
<Button Color=@Colors.Success>Success</Button>
<Button Color=@Colors.Danger>Danger</Button>
<Button Color=@Colors.Warning>Warning</Button>
<Button Color=@Colors.Supporting>Supporting</Button>
```

### Pill buttons

#### The button pills can be used as an alternative style by using fully rounded edges.
```razor
<Button StyleType="ButtonTypes.Pill">Primary</Button>
<Button Color=@Colors.Neutral StyleType="ButtonTypes.Pill">Alternative</Button>
<Button Color=@Colors.Light StyleType="ButtonTypes.Pill">Light</Button>
<Button Color=@Colors.Success StyleType="ButtonTypes.Pill">Success</Button>
<Button Color=@Colors.Danger StyleType="ButtonTypes.Pill">Danger</Button>
<Button Color=@Colors.Warning StyleType="ButtonTypes.Pill">Warning</Button>
<Button Color=@Colors.Supporting StyleType="ButtonTypes.Pill">Supporting</Button>    
```

### Gradient monochrome
#### These beautifully colored buttons built with the gradient color stops utility classes from Tailwind CSS can be used as a creative alternative to the default button styles.

```razor
    <div class="flex gap-2 p-4">
        <GradientButton>Default</GradientButton>
        <GradientButton Color=@GradientColors.Green>Green</GradientButton>
        <GradientButton Color=@GradientColors.Cyan>Cyan</GradientButton>
        <GradientButton Color=@GradientColors.Teal>Teal</GradientButton>
        <GradientButton Color=@GradientColors.Lime>Lime</GradientButton>
        <GradientButton Color=@GradientColors.Red>Red</GradientButton>
        <GradientButton Color=@GradientColors.Pink>Pink</GradientButton>
        <GradientButton Color=@GradientColors.Purple>Purple</GradientButton>
    </div>
    <div class="flex gap-2 p-4">
        <GradientButton StyleType="ButtonTypes.Pill">Default</GradientButton>
        <GradientButton Color=@GradientColors.Green StyleType="ButtonTypes.Pill">Green</GradientButton>
        <GradientButton Color=@GradientColors.Cyan StyleType="ButtonTypes.Pill">Cyan</GradientButton>
        <GradientButton Color=@GradientColors.Teal StyleType="ButtonTypes.Pill">Teal</GradientButton>
        <GradientButton Color=@GradientColors.Lime StyleType="ButtonTypes.Pill">Lime</GradientButton>
        <GradientButton Color=@GradientColors.Red StyleType="ButtonTypes.Pill">Red</GradientButton>
        <GradientButton Color=@GradientColors.Pink StyleType="ButtonTypes.Pill">Pink</GradientButton>
        <GradientButton Color=@GradientColors.Purple StyleType="ButtonTypes.Pill">Purple</GradientButton>
    </div>
```

### Gradient duotone
#### These buttons use a style that includes two contrasted colors creating an impressive mesh gradient effect.
```razor
    <div class="flex flex-wrap gap-2 p-4">
        <GradientButton Color=GradientColors.PurpleToBlue>Purple to blue</GradientButton>
        <GradientButton Color=GradientColors.CyanToBlue>Cyan to blue</GradientButton>
        <GradientButton Color=GradientColors.GreenToBlue>Green to blue</GradientButton>
        <GradientButton Color=GradientColors.PurpleToPink>Purple to pink</GradientButton>
        <GradientButton Color=GradientColors.PinkToOrange>Pink to orange</GradientButton>
        <GradientButton Color=GradientColors.TealToLime>Teal to lime</GradientButton>
        <GradientButton Color=GradientColors.RedToYellow>Red to yellow</GradientButton>
    </div>
    <div class="flex flex-wrap gap-2 p-4">
         <GradientButton Color=GradientColors.PurpleToBlue StyleType="ButtonTypes.Pill">Purple to blue</GradientButton>
        <GradientButton Color=GradientColors.CyanToBlue StyleType="ButtonTypes.Pill">Cyan to blue</GradientButton>
        <GradientButton Color=GradientColors.GreenToBlue StyleType="ButtonTypes.Pill">Green to blue</GradientButton>
        <GradientButton Color=GradientColors.PurpleToPink StyleType="ButtonTypes.Pill">Purple to pink</GradientButton>
        <GradientButton Color=GradientColors.PinkToOrange StyleType="ButtonTypes.Pill">Pink to orange</GradientButton>
        <GradientButton Color=GradientColors.TealToLime StyleType="ButtonTypes.Pill">Teal to lime</GradientButton>
        <GradientButton Color=GradientColors.RedToYellow StyleType="ButtonTypes.Pill">Red to yellow</GradientButton>
    </div>
```

### Gradient outline
#### This is a special button style that incorporates a gradient color for the outline that can be used as a secondary style to the fully colored gradient buttons.
```razor
    <div class="flex flex-wrap gap-2 p-4">
        <GradientButton Outline="true" StyleType=ButtonTypes.Pill Color=GradientColors.PurpleToBlue>
            Purple to blue
        </GradientButton>
        <GradientButton Outline="true" StyleType=ButtonTypes.Pill Color=GradientColors.CyanToBlue>
            Cyan to blue
        </GradientButton>
        <GradientButton Outline="true" StyleType=ButtonTypes.Pill Color=GradientColors.GreenToBlue>
            Green to blue
        </GradientButton>
        <GradientButton Outline="true" StyleType=ButtonTypes.Pill Color=GradientColors.PurpleToPink>
            Purple to pink
        </GradientButton>
        <GradientButton Outline="true" StyleType=ButtonTypes.Pill Color=GradientColors.PinkToOrange>
            Pink to orange
        </GradientButton>
        <GradientButton Outline="true" StyleType=ButtonTypes.Pill Color=GradientColors.TealToLime>
            Teal to lime
        </GradientButton>
        <GradientButton Outline="true" StyleType=ButtonTypes.Pill Color=GradientColors.RedToYellow>
            Red to yellow
        </GradientButton>
    </div>
    <div class="flex flex-wrap gap-2 p-4">
        <GradientButton Outline="true" Color=GradientColors.PurpleToBlue>Purple to blue</GradientButton>
        <GradientButton Outline="true" Color=GradientColors.CyanToBlue>Cyan to blue</GradientButton>
        <GradientButton Outline="true" Color=GradientColors.GreenToBlue>Green to blue</GradientButton>
        <GradientButton Outline="true" Color=GradientColors.PurpleToPink>Purple to pink</GradientButton>
        <GradientButton Outline="true" Color=GradientColors.PinkToOrange>Pink to orange</GradientButton>
        <GradientButton Outline="true" Color=GradientColors.TealToLime>Teal to lime</GradientButton>
        <GradientButton Outline="true" Color=GradientColors.RedToYellow>Red to yellow</GradientButton>
    </div>
```

### Colored Shadows
#### These beautiful button elements with color shadows can be used since the release of Tailwind v3.0.
```razor
    <div class="flex gap-2 p-4">
        <GradientButton Shadow="true">Default</GradientButton>
        <GradientButton Shadow="true" Color=@GradientColors.Green>Green</GradientButton>
        <GradientButton Shadow="true" Color=@GradientColors.Cyan>Cyan</GradientButton>
        <GradientButton Shadow="true" Color=@GradientColors.Teal>Teal</GradientButton>
        <GradientButton Shadow="true" Color=@GradientColors.Lime>Lime</GradientButton>
        <GradientButton Shadow="true" Color=@GradientColors.Red>Red</GradientButton>
        <GradientButton Shadow="true" Color=@GradientColors.Pink>Pink</GradientButton>
        <GradientButton Shadow="true" Color=@GradientColors.Purple>Purple</GradientButton>
    </div>
```

### Outline Buttons
#### Use the following button styles to show the colors only for the border of the element.
```razor
<div class="flex gap-2 p-4">
    <Button Outline="true" StyleType="ButtonTypes.Pill">Primary</Button>
    <Button Outline="true" StyleType="ButtonTypes.Pill" Color=@Colors.Success>
        Success
    </Button>
    <Button Outline="true" StyleType="ButtonTypes.Pill" Color=@Colors.Danger>
        Danger
    </Button>
    <Button Outline="true" StyleType="ButtonTypes.Pill" Color=@Colors.Warning>
        Warning
    </Button>
    <Button Outline="true" StyleType="ButtonTypes.Pill" Color=@Colors.Supporting>
        Supporting
    </Button>
</div>
<div class="flex gap-2 p-4">
    <Button Outline="true">Primary</Button>
    <Button Outline="true" Color=@Colors.Success>Success</Button>
    <Button Outline="true" Color=@Colors.Danger>Danger</Button>
    <Button Outline="true" Color=@Colors.Warning>Warning</Button>
    <Button Outline="true" Color=@Colors.Supporting>Supporting</Button>
</div>
```

### Button sizes
#### Use these examples if you want to use smaller or larger buttons.
```razor
<div class="flex gap-2 p-4">
    <Button Size="Sizes.ExtraSmall">Extra small</Button>
    <Button Size="Sizes.Small">Small</Button>
    <Button>Base</Button>
    <Button Size="Sizes.Large">Large</Button>
    <Button Size="Sizes.ExtraLarge">Extra large</Button>
</div>
```

### Button sizes with icon
#### Use these examples if you want to use smaller or larger buttons.
```razor
<div class="flex gap-2 p-4">
    <Button Size="Sizes.ExtraSmall">
        <EnvelopeSolid class="w-3 h-3 text-white mr-2"></EnvelopeSolid>
        Extra small
    </Button>
    <Button Size="Sizes.Small">
        <EnvelopeSolid class="w-3 h-3 text-white mr-2"></EnvelopeSolid>
        Small
    </Button>
    <Button>
        <EnvelopeSolid class="w-3.5 h-3.5 text-white mr-2"></EnvelopeSolid>
        Base
    </Button>
    <Button Size="Sizes.Large">
        <EnvelopeSolid class="w-4 h-4 text-white mr-2"></EnvelopeSolid>
        Large
    </Button>
    <Button Size="Sizes.ExtraLarge">
        <EnvelopeSolid class="w-4 h-4 text-white mr-2"></EnvelopeSolid>
        Extra large
    </Button>
</div>
```

### Buttons with icon
#### Use the following examples to add a SVG icon inside the button either on the left or right side.
```razor
<Button>
    <ShoppingCartSolid class="w-3.5 h-3.5 mr-2"></ShoppingCartSolid>
    <span>Buy Now</span>
</Button>
<Button>
    <span>Choose Plan</span>
    <ArrowRightSolid class="w-3.5 h-3.5 ml-2"></ArrowRightSolid>
</Button>
```


### Icon Buttons
#### Sometimes you need a button to indicate an action using only an icon.
```razor
<div class="flex flex-wrap gap-2 p-4">
    <Button Size="Sizes.Icon">
        <ArrowRightSolid class="w-5 h-5"></ArrowRightSolid>
        <span class="sr-only">Icon description</span>
    </Button>
    <Button StyleType="ButtonTypes.Pill" Size="Sizes.Icon">
        <ArrowRightSolid class="w-5 h-5"></ArrowRightSolid>
        <span class="sr-only">Icon description</span>
    </Button>
    <Button Outline="true" Size="Sizes.Icon">
        <ThumbsUpSolid class="w-5 h-5"></ThumbsUpSolid>
        <span class="sr-only">Icon description</span>
    </Button>
    <Button StyleType="ButtonTypes.Pill" Size="Sizes.Icon" Outline="true">
        <ThumbsUpSolid class="w-5 h-5"></ThumbsUpSolid>
        <span class="sr-only">Icon description</span>
    </Button>
</div>
```

### Loader 
#### Use the following spinner components from Flowbite to indicate a loader animation inside buttons:
```razor
   <div class="flex flex-wrap gap-2 p-4">
        <Button Class="inline-flex items-center">
            <svg aria-hidden="true" role="status" class="inline w-4 h-4 mr-3 text-white animate-spin" viewBox="0 0 100 101" fill="none" xmlns="http://www.w3.org/2000/svg">
                <path d="M100 50.5908C100 78.2051 77.6142 100.591 50 100.591C22.3858 100.591 0 78.2051 0 50.5908C0 22.9766 22.3858 0.59082 50 0.59082C77.6142 0.59082 100 22.9766 100 50.5908ZM9.08144 50.5908C9.08144 73.1895 27.4013 91.5094 50 91.5094C72.5987 91.5094 90.9186 73.1895 90.9186 50.5908C90.9186 27.9921 72.5987 9.67226 50 9.67226C27.4013 9.67226 9.08144 27.9921 9.08144 50.5908Z" fill="#E5E7EB"/>
                <path d="M93.9676 39.0409C96.393 38.4038 97.8624 35.9116 97.0079 33.5539C95.2932 28.8227 92.871 24.3692 89.8167 20.348C85.8452 15.1192 80.8826 10.7238 75.2124 7.41289C69.5422 4.10194 63.2754 1.94025 56.7698 1.05124C51.7666 0.367541 46.6976 0.446843 41.7345 1.27873C39.2613 1.69328 37.813 4.19778 38.4501 6.62326C39.0873 9.04874 41.5694 10.4717 44.0505 10.1071C47.8511 9.54855 51.7191 9.52689 55.5402 10.0491C60.8642 10.7766 65.9928 12.5457 70.6331 15.2552C75.2735 17.9648 79.3347 21.5619 82.5849 25.841C84.9175 28.9121 86.7997 32.2913 88.1811 35.8758C89.083 38.2158 91.5421 39.6781 93.9676 39.0409Z" fill="currentColor"/>
            </svg>
            Loading...
        </Button>
        <Button Class="inline-flex items-center" Color="Colors.Alternative">
            <svg aria-hidden="true" role="status" class="inline w-4 h-4 mr-3 text-gray-200 animate-spin dark:text-gray-600" viewBox="0 0 100 101" fill="none" xmlns="http://www.w3.org/2000/svg">
                <path d="M100 50.5908C100 78.2051 77.6142 100.591 50 100.591C22.3858 100.591 0 78.2051 0 50.5908C0 22.9766 22.3858 0.59082 50 0.59082C77.6142 0.59082 100 22.9766 100 50.5908ZM9.08144 50.5908C9.08144 73.1895 27.4013 91.5094 50 91.5094C72.5987 91.5094 90.9186 73.1895 90.9186 50.5908C90.9186 27.9921 72.5987 9.67226 50 9.67226C27.4013 9.67226 9.08144 27.9921 9.08144 50.5908Z" fill="currentColor"/>
                <path d="M93.9676 39.0409C96.393 38.4038 97.8624 35.9116 97.0079 33.5539C95.2932 28.8227 92.871 24.3692 89.8167 20.348C85.8452 15.1192 80.8826 10.7238 75.2124 7.41289C69.5422 4.10194 63.2754 1.94025 56.7698 1.05124C51.7666 0.367541 46.6976 0.446843 41.7345 1.27873C39.2613 1.69328 37.813 4.19778 38.4501 6.62326C39.0873 9.04874 41.5694 10.4717 44.0505 10.1071C47.8511 9.54855 51.7191 9.52689 55.5402 10.0491C60.8642 10.7766 65.9928 12.5457 70.6331 15.2552C75.2735 17.9648 79.3347 21.5619 82.5849 25.841C84.9175 28.9121 86.7997 32.2913 88.1811 35.8758C89.083 38.2158 91.5421 39.6781 93.9676 39.0409Z" fill="#1C64F2"/>
            </svg>
            Loading...
        </Button>
    </div>
```    

### Social buttons
#### Use these button styles when building social media login forms using Facebook, Twitter, GitHub, Google, and Apple. These buttons override button colors with the Style attribute.

```razor
<div class="flex flex-wrap gap-2 p-4">
    <Button Style="background-color:#3b5998;">
        <FacebookSolid class="w-4 h-4 mr-2"></FacebookSolid>
        Sign in with Facebook
    </Button>
    <Button Style="background-color:#1da1f2;" >
        <TwitterSolid class="w-4 h-4 mr-2"></TwitterSolid>
        Sign in with Twitter
    </Button>
    <Button Style="background:#24292F;">
        <GithubSolid class="w-4 h-4 mr-2"></GithubSolid>
        Sign in with Github
    </Button>
    <Button Style="background: #4285F4;">
        <GoogleSolid class="w-4 h-4 mr-2"></GoogleSolid>
        Sign in with Google
    </Button>
    <Button Color="Colors.None" Style="background:#050708;">
        <AppleSolid class="w-4 h-4 mr-2"></AppleSolid>
        Sign in with Apple
    </Button>
</div>
```

### Disabled attribute
#### Using the disabled attribute will disable the button. Click to toggle whether or not the default colored buttons are disabled.
```razor
    <div class="flex flex-wrap gap-2 p-4">
        <Button Disabled="@_defBtnDisabled">@(_defBtnDisabled ? "Disabled" : "Enabled") Button</Button>
        <Button Disabled="@_defBtnDisabled" Outline="true">@(_defBtnDisabled ? "Disabled" : "Enabled") Button</Button>
        <Button OnClick="@ToggleDisabled">Toggle Disabled</Button>
    </div>
```
```csharp
@code {
    private bool _defBtnDisabled = true;
    
    private void ToggleDisabled()
    {
        _defBtnDisabled = !_defBtnDisabled;
    }
}
```

### Type attribute
#### The type or Type attribute can be set to submit, reset, button, etc. The default is automatically set to button.

```razor
    <div class="flex flex-wrap gap-2 p-4">
        <Button type="submit">Submit Button</Button>
        <Button Type="reset">Reset Button</Button>
    </div>
```
### Click events
#### The click events will be triggered for functions assigned to the OnClick attribute.

```razor
    <div class="flex flex-wrap gap-2 p-4">
        <Button OnClick="@ButtonClick">Button 1 Count is @_btn1Count</Button>
        <Button OnClick="@(() => ButtonClickValue(_vals[_btn2Index]))">Button 2 index is @_btn2Index</Button>
        <Button disabled>Value: @_btn2Val</Button>
    </div>
```

```csharp
@code {    
    private int _btn1Count = 0;
    private int _btn2Index = 0;
    private string? _btn2Val;
    private string[] _vals=
    {
        "Hello,",
        "This",
        "is",
        "how",
        "to",
        "pass",
        "a",
        "value."
    };
    private void ButtonClick()
    {
        _btn1Count++;
    }
    
    private void ButtonClickValue(string value)
    {
        if (_btn2Index < 7)
        {
            _btn2Index++;    
        }
        else
        {
            _btn2Index = 0;
        }
        _btn2Val = value;
    }
}
```
