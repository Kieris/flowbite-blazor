
## Indicators
#### Use the indicator component to show a number count, account status, or as a loading label positioned relative to the parent component coded with Tailwind CSS
#### The indicator component can be used as a small element positioned absolutely relative to another component such as a button or card and show a number count, account status (red for offline, green for online) and other useful information.
#### Check out the following examples for multiple sizes, colors, positionings, styles, and more all coded with Tailwind CSS and Flowbite.

### Setup
#### Import the Alerts namespaces from Flowbite.Blazor.Indicators

```razor
@using Flowbite.Blazor.Components.Indicators
```

### Default indicator
#### Use the following badge elements to indicate counts or labels inside or outside components.

```razor
<Indicator Color="IndiColors.Light"/>
<Indicator/>
<Indicator Color="IndiColors.Supporting"/>
<Indicator Color="IndiColors.Accent"/>
<Indicator Color="IndiColors.Success"/>
<Indicator Color="IndiColors.Warning"/>
<Indicator Color="IndiColors.Danger"/>
<Indicator Color="IndiColors.Neutral"/>
```

    
### Legend indicator
#### Use the following badge elements to indicate counts or labels inside or outside components.

```razor
<span class="flex items-center text-sm font-medium">
    <Indicator Size="Sizes.Small" Class="mr-1.5"/>Visitors
</span>
<span class="flex items-center text-sm font-medium">
    <Indicator Color="IndiColors.Accent" Size="Sizes.Small" Class="mr-1.5"/>Sessions
</span>
<span class="flex items-center text-sm font-medium">
    <Indicator Color="IndiColors.Warning" Size="Sizes.Small" Class="mr-1.5"/>Customers
</span>
<span class="flex items-center text-sm font-medium">
    <Indicator Color="IndiColors.Supporting" Size="Sizes.Small" Class="mr-1.5"/>Revenue
</span>
```
    
### Indicator count
#### This example can be used to show a number count inside the indicator and position it relative to a button component.

```
<Button Size="Sizes.Large" Class="inline-flex items-center relative">
    <EnvelopeSolid class="w-4 h-4 mr-2 text-white" />
    <span class="sr-only">Notifications</span>
    Messages
    <Indicator Color="IndiColors.Danger" Border="true" Size="Sizes.ExtraLarge" 
                Placement="IndiLocs.TopRight">
        <span class="text-white text-xs font-bold">6</span>
    </Indicator>
</Button>
```

    
### Status indicator
#### Use this example to show a status indicator for the currently logged in user by showing red for offline and green for online.

```razor
<div class="relative">
    <img class="w-10 h-10 rounded-full" src="images/people/profile-picture-5.webp" alt="Neil image">
    <Indicator Color="IndiColors.Success" Placement="IndiLocs.TopRight" Offset="false"
                Border="true"/>
</div>
<div class="relative">
    <img class="w-10 h-10 rounded-full" src="images/people/profile-picture-4.webp" alt="Bonnie image">
    <Indicator Color="IndiColors.Danger" Placement="IndiLocs.TopRight" Offset="false"
                Border="true"/>
</div>
```


### Badge indicator
#### This example can be used to add an indicator inside of a badge component.

```razor
<ul class="max-w-sm divide-y divide-gray-200 dark:divide-gray-700 w-full">
    <li class="py-3 sm:py-4">
        <div class="flex items-center space-x-3">
            <div class="flex-shrink-0">
                <img class="w-10 h-10 rounded-full" src="images/people/profile-picture-5.webp" alt="Neil image">
            </div>
            <div class="flex-1 min-w-0">
                <p class="text-sm font-semibold text-gray-900 truncate dark:text-white">Neil Sims</p>
                <p class="text-sm text-gray-500 truncate dark:text-gray-400">email@flowbite.com</p>
            </div>
            <Badge Color="BadgeColors.Green" Pill="true" Class="px-2.5 py-0.5">
                <Indicator Color="IndiColors.Success" Size="Sizes.ExtraSmall" Class="mr-1"/>Available
            </Badge>
        </div>
    </li>
    <li class="py-3 sm:py-4">
        <div class="flex items-center space-x-3">
            <div class="flex-shrink-0">
                <img class="w-10 h-10 rounded-full" src="images/people/profile-picture-4.webp" alt="Bonnie image">
            </div>
            
            <div class="flex-1 min-w-0">
                <p class="text-sm font-semibold text-gray-900 truncate dark:text-white">Bonnie Green</p>
                <p class="text-sm text-gray-500 truncate dark:text-gray-400">email@flowbite.com</p>
            </div>
            <Badge Color="BadgeColors.Red" Pill="true" Class="px-2.5 py-0.5">
                <Indicator Color="IndiColors.Danger" Size="Sizes.ExtraSmall" Class="mr-1" />Unavailable
            </Badge>
        </div>
    </li>
</ul>
```
    
### Indicator position

#### Use these examples to position the indicator component anywhere relative to the parent element.

```razor
<div class="relative w-56 h-56 bg-gray-100 border border-gray-200 rounded-lg dark:bg-gray-800 dark:border-gray-700">
    <Indicator Size="Sizes.None" Placement="IndiLocs.TopRight">
        <span class="text-white text-xs py-0.5 px-2">top-right</span>
    </Indicator>
    <Indicator Size="Sizes.None" Placement="IndiLocs.TopCenter">
        <span class="text-white text-xs py-0.5 px-2">top-center</span>
    </Indicator>
    <Indicator Size="Sizes.None" Placement="IndiLocs.TopLeft">
        <span class="text-white text-xs py-0.5 px-2">top-left</span>
    </Indicator>
    <Indicator Size="Sizes.None" Placement="IndiLocs.CenterLeft">
        <span class="text-white text-xs py-0.5 px-2">center-left</span>
    </Indicator>
    <Indicator Size="Sizes.None" Placement="IndiLocs.Center">
        <span class="text-white text-xs py-0.5 px-2">center</span>
    </Indicator>
    <Indicator Size="Sizes.None" Placement="IndiLocs.CenterRight">
        <span class="text-white text-xs py-0.5 px-2">center-right</span>
    </Indicator>
    <Indicator Size="Sizes.None" Placement="IndiLocs.BottomLeft">
        <span class="text-white text-xs py-0.5 px-2">bottom-left</span>
    </Indicator>
    <Indicator Size="Sizes.None" Placement="IndiLocs.BottomCenter">
        <span class="text-white text-xs py-0.5 px-2">bottom-center</span>
    </Indicator>
    <Indicator Size="Sizes.None" Placement="IndiLocs.BottomRight">
        <span class="text-white text-xs py-0.5 px-2">bottom-right</span>
    </Indicator>
</div>
```

    
### Stepper indicator

#### You can also use the indicators inside of a stepper component when completing a form element.

```razor
<ol class="flex items-center">
    <li class="relative w-full mb-6">
        <div class="flex items-center">
            <Indicator Size="Sizes.ExtraLarge" Color="IndiColors.None" Class="bg-primary-200 dark:bg-primary-900 z-10 ring-0 ring-white sm:ring-8 dark:ring-gray-900 shrink-0">
                <CheckCircleSolid class="w-6 h-6 text-primary-600 dark:text-primary-300"/>
            </Indicator>
            <div class="flex w-full bg-gray-200 h-0.5 dark:bg-gray-700"/>
        </div>
        <div class="mt-3">
            <h3 class="font-medium text-gray-900 dark:text-white">Step 1</h3>
        </div>
    </li>
    <li class="relative w-full mb-6">
        <div class="flex items-center">
            <Indicator Size="Sizes.ExtraLarge" Color="IndiColors.None" Class="bg-primary-200 dark:bg-primary-900 z-10 ring-0 ring-white sm:ring-8 dark:ring-gray-900 shrink-0">
                <CheckCircleSolid class="w-6 h-6 text-primary-600 dark:text-primary-300"/>
            </Indicator>
            <div class="flex w-full bg-gray-200 h-0.5 dark:bg-gray-700"/>
        </div>
        <div class="mt-3">
            <h3 class="font-medium text-gray-900 dark:text-white">Step 2</h3>
        </div>
    </li>
    <li class="relative w-full mb-6">
        <div class="flex items-center">
            <Indicator Size="Sizes.ExtraLarge" Color="IndiColors.None" Class="bg-primary-200 dark:bg-primary-900 z-10 ring-0 ring-white sm:ring-8 dark:ring-gray-900 shrink-0">
                <CheckCircleSolid class="w-6 h-6 text-primary-600 dark:text-primary-300"/>
            </Indicator>
            <div class="flex w-full bg-gray-200 h-0.5 dark:bg-gray-700"/>
        </div>
        <div class="mt-3">
            <h3 class="font-medium text-gray-900 dark:text-white">Step 2</h3>
        </div>
    </li>
    <li class="relative w-full mb-6">
        <div class="flex items-center">
            <Indicator Size="Sizes.ExtraLarge" Color="IndiColors.None" Class="z-10 w-6 h-6 bg-gray-200 ring-0 ring-white dark:bg-gray-700 sm:ring-8 dark:ring-gray-900 shrink-0">
                <CheckCircleSolid class="w-6 h-6 text-gray-600 dark:text-white"/>
            </Indicator>
        </div>
        <div class="mt-3">
            <h3 class="font-medium text-gray-900 dark:text-white">Step 3</h3>
        </div>
    </li>
</ol>
<ol class="flex items-center">
    <li class="relative w-full mb-6">
        <div class="flex items-center">
            <Indicator Size="Sizes.ExtraLarge" Color="IndiColors.None" Class="bg-primary-200 dark:bg-primary-900 z-10 ring-0 ring-white sm:ring-8 dark:ring-gray-900 shrink-0">
                <Indicator/>
            </Indicator>
            <div class="flex w-full bg-gray-200 h-0.5 dark:bg-gray-700"/>
        </div>
        <div class="mt-3">
            <h3 class="font-medium text-gray-900 dark:text-white">Step 1</h3>
        </div>
    </li>
    <li class="relative w-full mb-6">
        <div class="flex items-center">
            <Indicator Size="Sizes.ExtraLarge" Color="IndiColors.None" Class="bg-primary-200 dark:bg-primary-900 z-10 ring-0 ring-white sm:ring-8 dark:ring-gray-900 shrink-0">
                <Indicator/>
            </Indicator>
            <div class="flex w-full bg-gray-200 h-0.5 dark:bg-gray-700"/>
        </div>
        <div class="mt-3">
            <h3 class="font-medium text-gray-900 dark:text-white">Step 2</h3>
        </div>
    </li>
    <li class="relative w-full mb-6">
        <div class="flex items-center">
            <Indicator Size="Sizes.ExtraLarge" Color="IndiColors.None" Class="bg-primary-200 dark:bg-primary-900 z-10 ring-0 ring-white sm:ring-8 dark:ring-gray-900 shrink-0">
                <Indicator/>
            </Indicator>
            <div class="flex w-full bg-gray-200 h-0.5 dark:bg-gray-700"/>
        </div>
        <div class="mt-3">
            <h3 class="font-medium text-gray-900 dark:text-white">Step 2</h3>
        </div>
    </li>
    <li class="relative w-full mb-6">
        <div class="flex items-center">
            <Indicator Size="Sizes.ExtraLarge" Color="IndiColors.None" Class="bg-neutral-100 dark:bg-neutral-700 z-10 ring-0 ring-white sm:ring-8 dark:ring-gray-900 shrink-0">
                <Indicator Color="IndiColors.None" Class="bg-neutral-600 dark:bg-neutral-100"/>
            </Indicator>
        </div>
        <div class="mt-3">
            <h3 class="font-medium text-gray-900 dark:text-white">Step 3</h3>
        </div>
    </li>
</ol>
```

### Loading indicator
#### Use this animated loading indicator when content inside of a card is still loading.

```razor
<div class="flex items-center justify-center w-56 h-56 border border-gray-200 rounded-lg bg-gray-50 dark:bg-gray-800 dark:border-gray-700">
    <Indicator Class="animate-pulse px-3 py-2" Size="Sizes.None" Pill="false">
        <span class="text-xs font-medium leading-none text-primary-200">Loading...</span>
    </Indicator>
</div>
 ```