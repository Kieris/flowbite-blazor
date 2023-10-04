## Badges
#### Use Tailwind CSS badges as elements to show counts or labels separately or inside other components

#### The badge component can be used to complement other elements such as buttons or text elements as a label or to show the count of a given data, such as the number of comments for an article or how much time has passed by since a comment has been made.

#### Alternatively, badges can also be used as standalone elements that link to a certain page by using the anchor tag instead of a span element.

### Setup
#### Import the Badges namespaces from Flowbite.Blazor.

```razor
@using Flowbite.Blazor.Components.Badge
```

### Default badge
#### Use the following badge elements to indicate counts or labels inside or outside components.

```razor
    <div class="flex flex-wrap p-4 gap-2">
        <Badge>Default</Badge>
        <Badge Color="BadgeColors.Dark">Dark</Badge>
        <Badge Color="BadgeColors.Green">Green</Badge>
        <Badge Color="BadgeColors.Red">Red</Badge>
        <Badge Color="BadgeColors.Yellow">Yellow</Badge>
        <Badge Color="BadgeColors.Indigo">Indigo</Badge>
        <Badge Color="BadgeColors.Purple">Purple</Badge>
        <Badge Color="BadgeColors.Pink">Pink</Badge>
    </div>
```

### Large badges
#### Use the large attribute or set size to BadgeSizes.Custom and increase the paddings to create a larger variant of the badges.

```razor
    <div class="flex flex-wrap p-4 gap-2">
        <Badge Size="BadgeSizes.Large">Default</Badge>
        <Badge Size="BadgeSizes.Large" Color="BadgeColors.Dark">Dark</Badge>
        <Badge Size="BadgeSizes.Large" Color="BadgeColors.Green">Green</Badge>
        <Badge Size="BadgeSizes.Large" Color="BadgeColors.Red">Red</Badge>
        <Badge Size="BadgeSizes.Large" Color="BadgeColors.Yellow">Yellow</Badge>
        <Badge Size="BadgeSizes.Large" Color="BadgeColors.Indigo">Indigo</Badge>
        <Badge Size="BadgeSizes.Large" Color="BadgeColors.Purple">Purple</Badge>
        <Badge Size="BadgeSizes.Large" Color="BadgeColors.Pink">Pink</Badge>
    </div>
```

### Bordered badges
#### This example can be used to add a border accent to the badge component.

```razor
    <div class="flex flex-wrap p-4 gap-2">
        <Badge Bordered="true">Default</Badge>
        <Badge Bordered="true" Color="BadgeColors.Dark">Dark</Badge>
        <Badge Bordered="true" Color="BadgeColors.Green">Green</Badge>
        <Badge Bordered="true" Color="BadgeColors.Red">Red</Badge>
        <Badge Bordered="true" Color="BadgeColors.Yellow">Yellow</Badge>
        <Badge Bordered="true" Color="BadgeColors.Indigo">Indigo</Badge>
        <Badge Bordered="true" Color="BadgeColors.Purple">Purple</Badge>
        <Badge Bordered="true" Color="BadgeColors.Pink">Pink</Badge>
    </div>
```

### Pill badges
#### Use this example to make the corners even more rounded like pills for the badge component.

```razor
    <div class="flex flex-wrap p-4 gap-2">
        <Badge Pill="true">Default</Badge>
        <Badge Pill="true" Color="BadgeColors.Dark">Dark</Badge>
        <Badge Pill="true" Color="BadgeColors.Green">Green</Badge>
        <Badge Pill="true" Color="BadgeColors.Red">Red</Badge>
        <Badge Pill="true" Color="BadgeColors.Yellow">Yellow</Badge>
        <Badge Pill="true" Color="BadgeColors.Indigo">Indigo</Badge>
        <Badge Pill="true" Color="BadgeColors.Purple">Purple</Badge>
        <Badge Pill="true" Color="BadgeColors.Pink">Pink</Badge>
    </div>
```

### Badges as links
#### You can also use badges as anchor elements to link to another page.

```razor
    <div class="flex flex-wrap p-4 gap-2">
        <Badge Link="#" Bordered="true" Color="BadgeColors.Dark">
            Badge link
        </Badge>
        <Badge href="#" Bordered="true">
            Badge link
        </Badge>
    </div>
```

### Badges with icon
#### You can also use SVG icons inside the badge elements.
```razor
    <div class="flex flex-wrap p-4 gap-2">
        <Badge Bordered="true" Color="BadgeColors.Dark">
            <svg class="mr-1.5" width=".75rem" height=".75rem" aria-hidden="true" xmlns="http://www.w3.org/2000/svg" fill="currentColor" viewBox="0 0 20 20">
                <path d="M10 0a10 10 0 1 0 10 10A10.011 10.011 0 0 0 10 0Zm3.982 13.982a1 1 0 0 1-1.414 0l-3.274-3.274A1.012 1.012 0 0 1 9 10V6a1 1 0 0 1 2 0v3.586l2.982 2.982a1 1 0 0 1 0 1.414Z"/>
            </svg>
            3 days ago
        </Badge>
        <Badge Bordered="true">
            <svg class="mr-1.5" width=".75rem" height=".75rem" aria-hidden="true" xmlns="http://www.w3.org/2000/svg" fill="currentColor" viewBox="0 0 20 20">
                <path d="M10 0a10 10 0 1 0 10 10A10.011 10.011 0 0 0 10 0Zm3.982 13.982a1 1 0 0 1-1.414 0l-3.274-3.274A1.012 1.012 0 0 1 9 10V6a1 1 0 0 1 2 0v3.586l2.982 2.982a1 1 0 0 1 0 1.414Z"/>
            </svg>
            2 minutes ago
        </Badge>
    </div>
```

### Button with badge
#### Use this example to add a badge inside a button component for a count indicator.

```razor
    <div class="flex flex-wrap p-4 gap-2">
        <Button Class="inline-flex items-center">
            Messages
            <Badge Class="ml-2" Pill="true">2</Badge>
        </Button>
        <Button Class="inline-flex items-center">
            Messages
            <Badge Color="BadgeColors.None" Size="BadgeSizes.Custom"
                    Class="justify-center w-4 h-4 ml-2 p-0 font-semibold text-blue-800 bg-blue-200" Pill="true">
                <span>2</span>
            </Badge>
        </Button>
    </div>
```

### Badge with icon only
#### Alternatively you can also use badges which indicate only a SVG icon.

```razor
      <div class="flex flex-wrap gap-2">
          <Badge Size="BadgeSizes.Custom" Class="p-2">
              <svg class="w-3 h-3" aria-hidden="true" xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 16 12">
                  <path stroke="currentColor" stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M1 5.917 5.724 10.5 15 1.5"/>
              </svg>
              <span class="sr-only">Icon description</span>
          </Badge>
          <Badge Pill="true" Size="BadgeSizes.Custom" Class="p-2">
              <svg class="w-3 h-3" aria-hidden="true" xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 16 12">
                  <path stroke="currentColor" stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M1 5.917 5.724 10.5 15 1.5"/>
              </svg>
              <span class="sr-only">Icon description</span>
          </Badge>
            <Badge Pill="true" Bordered="true" Size="BadgeSizes.Custom" Class="p-2">
                  <svg class="w-3 h-3" aria-hidden="true" xmlns="http://www.w3.org/2000/svg" fill="currentColor" viewBox="0 0 20 20">
                     <path fill="currentColor" d="m18.774 8.245-.892-.893a1.5 1.5 0 0 1-.437-1.052V5.036a2.484 2.484 0 0 0-2.48-2.48H13.7a1.5 1.5 0 0 1-1.052-.438l-.893-.892a2.484 2.484 0 0 0-3.51 0l-.893.892a1.5 1.5 0 0 1-1.052.437H5.036a2.484 2.484 0 0 0-2.48 2.481V6.3a1.5 1.5 0 0 1-.438 1.052l-.892.893a2.484 2.484 0 0 0 0 3.51l.892.893a1.5 1.5 0 0 1 .437 1.052v1.264a2.484 2.484 0 0 0 2.481 2.481H6.3a1.5 1.5 0 0 1 1.052.437l.893.892a2.484 2.484 0 0 0 3.51 0l.893-.892a1.5 1.5 0 0 1 1.052-.437h1.264a2.484 2.484 0 0 0 2.481-2.48V13.7a1.5 1.5 0 0 1 .437-1.052l.892-.893a2.484 2.484 0 0 0 0-3.51Z"/>
                     <path fill="#fff" d="M8 13a1 1 0 0 1-.707-.293l-2-2a1 1 0 1 1 1.414-1.414l1.42 1.42 5.318-3.545a1 1 0 0 1 1.11 1.664l-6 4A1 1 0 0 1 8 13Z"/>
                   </svg>
                   <span class="sr-only">Icon description</span>
              </Badge>
          <Badge Pill="true" Color="BadgeColors.Dark" Size="BadgeSizes.Custom" Class="p-2">
              <svg class="w-3 h-3" aria-hidden="true" xmlns="http://www.w3.org/2000/svg" fill="currentColor" viewBox="0 0 20 20">
                  <path d="M10 0a10 10 0 1 0 10 10A10.011 10.011 0 0 0 10 0Zm0 5a3 3 0 1 1 0 6 3 3 0 0 1 0-6Zm0 13a8.949 8.949 0 0 1-4.951-1.488A3.987 3.987 0 0 1 9 13h2a3.987 3.987 0 0 1 3.951 3.512A8.949 8.949 0 0 1 10 18Z"/>
              </svg>
              <span class="sr-only">Icon description</span>
          </Badge>
              <Badge Pill="true" Color="BadgeColors.Dark" Size="BadgeSizes.Custom" Class="p-2">
                  <svg class="w-3 h-3" aria-hidden="true" xmlns="http://www.w3.org/2000/svg" fill="currentColor" viewBox="0 0 20 20">
                      <path d="M10 .5a9.5 9.5 0 1 0 9.5 9.5A9.51 9.51 0 0 0 10 .5ZM9.5 4a1.5 1.5 0 1 1 0 3 1.5 1.5 0 0 1 0-3ZM12 15H8a1 1 0 0 1 0-2h1v-3H8a1 1 0 0 1 0-2h2a1 1 0 0 1 1 1v4h1a1 1 0 0 1 0 2Z"/>
                    </svg>
                    <span class="sr-only">Icon description</span>
              </Badge>
      </div>
```

### Chips (dismissable badges)
#### Use the dismissable attribute to allow the badge to be removed when the x icon is clicked.

```razor
      <div class="flex flex-wrap p-4 gap-2">
          <Badge Dismissable="true" Size="BadgeSizes.Large">Blue</Badge>
          <Badge Dismissable="true" Size="BadgeSizes.Large" Color="BadgeColors.Dark">Dark</Badge>
          <Badge Dismissable="true" Size="BadgeSizes.Large" Color="BadgeColors.Green">Green</Badge>
          <Badge Dismissable="true" Size="BadgeSizes.Large" Color="BadgeColors.Red">Red</Badge>
          <Badge Dismissable="true" Size="BadgeSizes.Large" Color="BadgeColors.Yellow">Yellow</Badge>
          <Badge Dismissable="true" Size="BadgeSizes.Large" Color="BadgeColors.Indigo">Indigo</Badge>
          <Badge Dismissable="true" Size="BadgeSizes.Large" Color="BadgeColors.Purple">Purple</Badge>
          <Badge Dismissable="true" Size="BadgeSizes.Large" Color="BadgeColors.Pink">Pink</Badge>
      </div>
```

### Alternative syntax
#### The border attribute will set Bordered=true. The rounded attribute will set Pill=true. The large attribute will make the badge Size=Large. The dismissable attribute makes the badge dismissable.


```razor
    <div class="flex flex-wrap p-4 gap-2">
        <Badge border>Bordered</Badge>
        <Badge rounded>Pill</Badge>
        <Badge large>Large</Badge>
        <Badge dismissable>Dismissable</Badge>
    </div>
```