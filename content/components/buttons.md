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
    <Button>Default</Button>
    <Button Color=@Colors.Alternative>Alternative</Button>
    <Button Color=@Colors.Dark>Dark</Button>
    <Button Color=@Colors.Light>Light</Button>
    <Button Color=@Colors.Green>Green</Button>
    <Button Color=@Colors.Red>Red</Button>
    <Button Color=@Colors.Yellow>Yellow</Button>
    <Button Color=@Colors.Purple>Purple</Button>
```

### Pill buttons

#### The button pills can be used as an alternative style by using fully rounded edges.
```razor
    <Button StyleType="ButtonTypes.Pill">Default</Button>
    <Button Color=@Colors.Alternative StyleType="ButtonTypes.Pill">Alternative</Button>
    <Button Color=@Colors.Dark StyleType="ButtonTypes.Pill">Dark</Button>
    <Button Color=@Colors.Light StyleType="ButtonTypes.Pill">Light</Button>
    <Button Color=@Colors.Green StyleType="ButtonTypes.Pill">Green</Button>
    <Button Color=@Colors.Red StyleType="ButtonTypes.Pill">Red</Button>
    <Button Color=@Colors.Yellow StyleType="ButtonTypes.Pill">Yellow</Button>
    <Button Color=@Colors.Purple StyleType="ButtonTypes.Pill">Purple</Button>
    
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
        <Button Outline="true" StyleType="ButtonTypes.Pill">Default</Button>
        <Button Outline="true" StyleType="ButtonTypes.Pill" Color=@Colors.Dark>
            Dark
        </Button>
        <Button Outline="true" StyleType="ButtonTypes.Pill" Color=@Colors.Green>
            Green
        </Button>
        <Button Outline="true" StyleType="ButtonTypes.Pill" Color=@Colors.Red>
            Red
        </Button>
        <Button Outline="true" StyleType="ButtonTypes.Pill" Color=@Colors.Yellow>
            Yellow
        </Button>
        <Button Outline="true" StyleType="ButtonTypes.Pill" Color=@Colors.Purple>
            Purple
        </Button>
    </div>
    <div class="flex gap-2 p-4">
        <Button Outline="true">Default</Button>
        <Button Outline="true" Color=@Colors.Dark>Dark</Button>
        <Button Outline="true" Color=@Colors.Green>Green</Button>
        <Button Outline="true" Color=@Colors.Red>Red</Button>
        <Button Outline="true" Color=@Colors.Yellow>Yellow</Button>
        <Button Outline="true" Color=@Colors.Purple>Purple</Button>
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
        <Button Size="Sizes.ExtraSmall" Class="inline-flex items-center">
             <svg class="w-3 h-3 text-white mr-2" aria-hidden="true" xmlns="http://www.w3.org/2000/svg" fill="currentColor" viewBox="0 0 20 16">
                <path d="m10.036 8.278 9.258-7.79A1.979 1.979 0 0 0 18 0H2A1.987 1.987 0 0 0 .641.541l9.395 7.737Z"/>
                <path d="M11.241 9.817c-.36.275-.801.425-1.255.427-.428 0-.845-.138-1.187-.395L0 2.6V14a2 2 0 0 0 2 2h16a2 2 0 0 0 2-2V2.5l-8.759 7.317Z"/>
              </svg>
            Extra small
        </Button>
        <Button Size="Sizes.Small" Class="inline-flex items-center">
            <svg class="w-3 h-3 text-white mr-2" aria-hidden="true" xmlns="http://www.w3.org/2000/svg" fill="currentColor" viewBox="0 0 20 16">
                <path d="m10.036 8.278 9.258-7.79A1.979 1.979 0 0 0 18 0H2A1.987 1.987 0 0 0 .641.541l9.395 7.737Z"/>
                <path d="M11.241 9.817c-.36.275-.801.425-1.255.427-.428 0-.845-.138-1.187-.395L0 2.6V14a2 2 0 0 0 2 2h16a2 2 0 0 0 2-2V2.5l-8.759 7.317Z"/>
            </svg>
            Small
        </Button>
        <Button Class="inline-flex items-center">
            <svg class="w-3.5 h-3.5 text-white mr-2" aria-hidden="true" xmlns="http://www.w3.org/2000/svg" fill="currentColor" viewBox="0 0 20 16">
                <path d="m10.036 8.278 9.258-7.79A1.979 1.979 0 0 0 18 0H2A1.987 1.987 0 0 0 .641.541l9.395 7.737Z"/>
                <path d="M11.241 9.817c-.36.275-.801.425-1.255.427-.428 0-.845-.138-1.187-.395L0 2.6V14a2 2 0 0 0 2 2h16a2 2 0 0 0 2-2V2.5l-8.759 7.317Z"/>
            </svg>
            Base
        </Button>
        <Button Size="Sizes.Large" Class="inline-flex items-center">
            <svg class="w-4 h-4 text-white mr-2" aria-hidden="true" xmlns="http://www.w3.org/2000/svg" fill="currentColor" viewBox="0 0 20 16">
                <path d="m10.036 8.278 9.258-7.79A1.979 1.979 0 0 0 18 0H2A1.987 1.987 0 0 0 .641.541l9.395 7.737Z"/>
                <path d="M11.241 9.817c-.36.275-.801.425-1.255.427-.428 0-.845-.138-1.187-.395L0 2.6V14a2 2 0 0 0 2 2h16a2 2 0 0 0 2-2V2.5l-8.759 7.317Z"/>
            </svg>
            Large
        </Button>
        <Button Size="Sizes.ExtraLarge" Class="inline-flex items-center">
            <svg class="w-4 h-4 text-white mr-2" aria-hidden="true" xmlns="http://www.w3.org/2000/svg" fill="currentColor" viewBox="0 0 20 16">
                <path d="m10.036 8.278 9.258-7.79A1.979 1.979 0 0 0 18 0H2A1.987 1.987 0 0 0 .641.541l9.395 7.737Z"/>
                <path d="M11.241 9.817c-.36.275-.801.425-1.255.427-.428 0-.845-.138-1.187-.395L0 2.6V14a2 2 0 0 0 2 2h16a2 2 0 0 0 2-2V2.5l-8.759 7.317Z"/>
            </svg>
            Extra large
        </Button>
    </div>
```

### Buttons with icon
#### Use the following examples to add a SVG icon inside the button either on the left or right side.
```razor
    <div class="flex mt-8 gap-2 p-4">
        <Button>
            <div class="flex items-center">
                <svg class="w-3.5 h-3.5 mr-2" aria-hidden="true" xmlns="http://www.w3.org/2000/svg" fill="currentColor" viewBox="0 0 18 21">
                    <path d="M15 12a1 1 0 0 0 .962-.726l2-7A1 1 0 0 0 17 3H3.77L3.175.745A1 1 0 0 0 2.208 0H1a1 1 0 0 0 0 2h.438l.6 2.255v.019l2 7 .746 2.986A3 3 0 1 0 9 17a2.966 2.966 0 0 0-.184-1h2.368c-.118.32-.18.659-.184 1a3 3 0 1 0 3-3H6.78l-.5-2H15Z"/>
                </svg>
                <span>Buy Now</span>
            </div>
        </Button>
        <Button>
            <div class="flex items-center">
                <span>Choose Plan</span>
                <svg class="w-3.5 h-3.5 ml-2" aria-hidden="true" xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 14 10">
                    <path stroke="currentColor" stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M1 5h12m0 0L9 1m4 4L9 9"/>
                </svg>
            </div>
        </Button>
    </div>
```


### Icon Buttons
#### Sometimes you need a button to indicate an action using only an icon.
```razor
    <div class="flex flex-wrap gap-2 p-4">
        <Button Class="inline-flex items-center" Size="Sizes.Icon">
            <svg class="w-5 h-5" aria-hidden="true" xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 14 10">
                <path stroke="currentColor" stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M1 5h12m0 0L9 1m4 4L9 9"/>
            </svg>
            <span class="sr-only">Icon description</span>
        </Button>
        <Button StyleType="ButtonTypes.Pill" Class="inline-flex items-center" Size="Sizes.Icon">
            <svg class="w-5 h-5" aria-hidden="true" xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 14 10">
                <path stroke="currentColor" stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M1 5h12m0 0L9 1m4 4L9 9"/>
            </svg>
            <span class="sr-only">Icon description</span>
        </Button>
        <Button Class="inline-flex items-center" Outline="true" Size="Sizes.Icon">
            <svg class="w-4 h-4" aria-hidden="true" xmlns="http://www.w3.org/2000/svg" fill="currentColor" viewBox="0 0 18 18">
                <path d="M3 7H1a1 1 0 0 0-1 1v8a2 2 0 0 0 4 0V8a1 1 0 0 0-1-1Zm12.954 0H12l1.558-4.5a1.778 1.778 0 0 0-3.331-1.06A24.859 24.859 0 0 1 6 6.8v9.586h.114C8.223 16.969 11.015 18 13.6 18c1.4 0 1.592-.526 1.88-1.317l2.354-7A2 2 0 0 0 15.954 7Z"/>
            </svg>
            <span class="sr-only">Icon description</span>
        </Button>
        <Button StyleType="ButtonTypes.Pill" Class="inline-flex items-center" Size="Sizes.Icon" Outline="true">
            <svg class="w-4 h-4" aria-hidden="true" xmlns="http://www.w3.org/2000/svg" fill="currentColor" viewBox="0 0 18 18">
                <path d="M3 7H1a1 1 0 0 0-1 1v8a2 2 0 0 0 4 0V8a1 1 0 0 0-1-1Zm12.954 0H12l1.558-4.5a1.778 1.778 0 0 0-3.331-1.06A24.859 24.859 0 0 1 6 6.8v9.586h.114C8.223 16.969 11.015 18 13.6 18c1.4 0 1.592-.526 1.88-1.317l2.354-7A2 2 0 0 0 15.954 7Z"/>
            </svg>
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
       <Button Class="inline-flex items-center" Style="background-color:#3b5998;">
            <svg class="w-4 h-4 mr-2" aria-hidden="true" xmlns="http://www.w3.org/2000/svg" fill="currentColor" viewBox="0 0 8 19">
                <path fill-rule="evenodd" d="M6.135 3H8V0H6.135a4.147 4.147 0 0 0-4.142 4.142V6H0v3h2v9.938h3V9h2.021l.592-3H5V3.591A.6.6 0 0 1 5.592 3h.543Z" clip-rule="evenodd"/>
            </svg>
            Sign in with Facebook
        </Button>
        <Button Class="inline-flex items-center" Style="background-color:#1da1f2;" >
            <svg class="w-4 h-4 mr-2" aria-hidden="true" xmlns="http://www.w3.org/2000/svg" fill="currentColor" viewBox="0 0 20 17">
                <path fill-rule="evenodd" d="M20 1.892a8.178 8.178 0 0 1-2.355.635 4.074 4.074 0 0 0 1.8-2.235 8.344 8.344 0 0 1-2.605.98A4.13 4.13 0 0 0 13.85 0a4.068 4.068 0 0 0-4.1 4.038 4 4 0 0 0 .105.919A11.705 11.705 0 0 1 1.4.734a4.006 4.006 0 0 0 1.268 5.392 4.165 4.165 0 0 1-1.859-.5v.05A4.057 4.057 0 0 0 4.1 9.635a4.19 4.19 0 0 1-1.856.07 4.108 4.108 0 0 0 3.831 2.807A8.36 8.36 0 0 1 0 14.184 11.732 11.732 0 0 0 6.291 16 11.502 11.502 0 0 0 17.964 4.5c0-.177 0-.35-.012-.523A8.143 8.143 0 0 0 20 1.892Z" clip-rule="evenodd"/>
            </svg>
            Sign in with Twitter
        </Button>
        <Button Class="inline-flex items-center" Style="background:#24292F;">
            <svg class="w-4 h-4 mr-2" aria-hidden="true" xmlns="http://www.w3.org/2000/svg" fill="currentColor" viewBox="0 0 20 20">
                <path fill-rule="evenodd" d="M10 .333A9.911 9.911 0 0 0 6.866 19.65c.5.092.678-.215.678-.477 0-.237-.01-1.017-.014-1.845-2.757.6-3.338-1.169-3.338-1.169a2.627 2.627 0 0 0-1.1-1.451c-.9-.615.07-.6.07-.6a2.084 2.084 0 0 1 1.518 1.021 2.11 2.11 0 0 0 2.884.823c.044-.503.268-.973.63-1.325-2.2-.25-4.516-1.1-4.516-4.9A3.832 3.832 0 0 1 4.7 7.068a3.56 3.56 0 0 1 .095-2.623s.832-.266 2.726 1.016a9.409 9.409 0 0 1 4.962 0c1.89-1.282 2.717-1.016 2.717-1.016.366.83.402 1.768.1 2.623a3.827 3.827 0 0 1 1.02 2.659c0 3.807-2.319 4.644-4.525 4.889a2.366 2.366 0 0 1 .673 1.834c0 1.326-.012 2.394-.012 2.72 0 .263.18.572.681.475A9.911 9.911 0 0 0 10 .333Z" clip-rule="evenodd"/>
            </svg>
            Sign in with Github
        </Button>
        <Button Class="inline-flex items-center" Style="background: #4285F4;">
            <svg class="w-4 h-4 mr-2" aria-hidden="true" xmlns="http://www.w3.org/2000/svg" fill="currentColor" viewBox="0 0 18 19">
                <path fill-rule="evenodd" d="M8.842 18.083a8.8 8.8 0 0 1-8.65-8.948 8.841 8.841 0 0 1 8.8-8.652h.153a8.464 8.464 0 0 1 5.7 2.257l-2.193 2.038A5.27 5.27 0 0 0 9.09 3.4a5.882 5.882 0 0 0-.2 11.76h.124a5.091 5.091 0 0 0 5.248-4.057L14.3 11H9V8h8.34c.066.543.095 1.09.088 1.636-.086 5.053-3.463 8.449-8.4 8.449l-.186-.002Z" clip-rule="evenodd"/>
            </svg>
            Sign in with Google
        </Button>
        <Button Color="Colors.None" Class="inline-flex items-center" Style="background:#050708;">
            <svg class="w-5 h-5 mr-2 -ml-1" aria-hidden="true" focusable="false" data-prefix="fab" data-icon="apple" role="img" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 384 512"><path fill="currentColor" d="M318.7 268.7c-.2-36.7 16.4-64.4 50-84.8-18.8-26.9-47.2-41.7-84.7-44.6-35.5-2.8-74.3 20.7-88.5 20.7-15 0-49.4-19.7-76.4-19.7C63.3 141.2 4 184.8 4 273.5q0 39.3 14.4 81.2c12.8 36.7 59 126.7 107.2 125.2 25.2-.6 43-17.9 75.8-17.9 31.8 0 48.3 17.9 76.4 17.9 48.6-.7 90.4-82.5 102.6-119.3-65.2-30.7-61.7-90-61.7-91.9zm-56.6-164.2c27.3-32.4 24.8-61.9 24-72.5-24.1 1.4-52 16.4-67.9 34.9-17.5 19.8-27.8 44.3-25.6 71.9 26.1 2 49.9-11.4 69.5-34.3z"></path></svg>
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
