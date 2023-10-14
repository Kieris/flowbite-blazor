## Flowbite Blazor - Avatar
Use the avatar component to show a visual representation of a user profile using an image element or SVG object based on multiple styles and sizes

The avatar component can be used as a visual identifier for a user profile on your website and you can use the examples from Flowbite to modify the styles and sizes of these components using the utility classes from Tailwind CSS.


### Setup
Import the Avatar namespace from Flowbite.Blazor.Avatar.

```razor
@using Flowbite.Blazor.Components.Avatar
```

### Default avatar
Use this example to create a circle and rounded avatar on an image element.

```razor
<Avatar Src="/images/people/profile-picture-2.webp" />
<Avatar Src="/images/people/profile-picture-5.webp" rounded />
```
    
### Bordered
You can apply a border around the avatar component.

You can use the ring-{color} class from Tailwind CSS to modify ring color.

```razor
<Avatar Src="/images/people/profile-picture-4.webp" border/>
<Avatar Src="/images/people/profile-picture-5.webp" border class="ring-primary-400 dark:ring-primary-300" />
```
    
### Placeholder icon
Use this example as a placeholder icon for the user profile when there is no custom image available.

```razor
<div class="flex justify-center space-x-4">
    <Avatar />
    <Avatar rounded />
    <Avatar border />
    <Avatar rounded border PlaceholderClass="ring-primary-400 dark:ring-primary-300" />
</div>
```
    
### Placeholder initials
Use this example as a placeholder icon for the user profile when there is no custom image available.

```razor
<Avatar>JG</Avatar>
```
    
### Avatar tooltip
Use this example to show a tooltip when hovering over the avatar.

```razor
<div class="flex justify-center space-x-4">
    <Tooltip Text="Jese Leos" Placement="Positions.Top">
        <Avatar Src="/images/people/profile-picture-5.webp" rounded />
    </Tooltip>
    <Tooltip Text="Roberta Casas" Placement="Positions.Top">
        <Avatar Src="/images/people/profile-picture-4.webp" rounded />
    </Tooltip>
    <Tooltip Text="Bonnie Green" Placement="Positions.Top">
        <Avatar Src="/images/people/profile-picture-3.webp" rounded />
    </Tooltip>
</div>
```
    
### Dot indicator
Use a dot element relative to the avatar component as an indicator for the user (eg. online or offline status).

```razor
<div class="flex justify-center space-x-4">
    <Avatar dot DotColor="IndiColors.Success" Src="/images/people/profile-picture-1.webp"/>
    <Avatar dot rounded DotColor="IndiColors.Danger" Src="/images/people/profile-picture-2.webp" />
    <Avatar dot DotColor="IndiColors.Danger" DotPlacement="IndiLocs.BottomRight" Src="/images/people/profile-picture-3.webp" />
    <Avatar dot DotColor="IndiColors.Success" DotPlacement="IndiLocs.BottomRight" rounded Src="/images/people/profile-picture-4.webp" />
    <Avatar dot DotColor="IndiColors.Danger" DotPlacement="IndiLocs.TopLeft" />
    <Avatar dot DotColor="IndiColors.Success" Rounded="true" />
    <Avatar dot DotColor="IndiColors.Success">JL</Avatar>
    <Avatar dot DotColor="IndiColors.Danger" DotPlacement="IndiLocs.BottomRight" rounded>JL</Avatar>
</div>
```
    
### Stacked
Use this example if you want to stack a group of users by overlapping the avatar components.

```razor
<div class="flex mb-5">
    <Avatar src="/images/people/profile-picture-1.webp" stacked/>
    <Avatar src="/images/people/profile-picture-2.webp" stacked/>
    <Avatar src="/images/people/profile-picture-3.webp" stacked/>
    <Avatar stacked PlaceholderClass="border-2 border-white dark:border-neutral-800"/>
    <Avatar src="/images/people/profile-picture-4.webp" stacked/>
    
</div>
<div class="flex">
    <Avatar src="/images/people/profile-picture-1.webp" stacked/>
    <Avatar src="/images/people/profile-picture-2.webp" stacked/>
    <Avatar src="/images/people/profile-picture-3.webp" stacked/>
    <Avatar stacked href="/" class="bg-gray-700 text-white hover:bg-gray-600 text-sm">+99</Avatar>
</div>
```
    
### Avatar text
This example can be used if you want to show additional information in the form of text elements such as the user’s name and join date.

```
<div class="flex items-center space-x-4">
    <Avatar Src="/images/people/profile-picture-1.webp" rounded />
    <div class="space-y-1 font-medium dark:text-white">
        <div>Jese Leos</div>
        <div class="text-sm text-gray-500 dark:text-gray-400">Joined in August 2014</div>
    </div>
</div>
```

### User dropdown
Use this example if you want to show a dropdown menu when clicking on the avatar component.

```razor
<div class="p-4 flex justify-center">
    <Dropdown Placement="Positions.BottomStart" ItemsClass="text-neutral-700 dark:text-neutral-200">
        <DropdownTrigger>
            <button type="button">
                <Avatar src="/images/people/profile-picture-3.webp" />
            </button>
        </DropdownTrigger>
        <Header>
            <div class="px-4">
                <span class="block text-sm">Bonnie Green</span>
                <span class="block truncate text-sm font-medium">name@flowbite.com</span>
            </div>
        </Header>
        <DropdownItems>
            <DropdownDivider></DropdownDivider>
            <DropdownItem href="#">Dashboard</DropdownItem>
            <DropdownItem href="#">Settings</DropdownItem>
            <DropdownItem href="#">Earnings</DropdownItem>
            <DropdownItem href="#">Sign out</DropdownItem>
        </DropdownItems>
    </Dropdown>
</div>
```

    
### Sizes
Choose from multiple sizing options for the avatar component from this example.

```razor
<div class="flex flex-wrap justify-center space-x-4">
    <Avatar Src="/images/people/profile-picture-3.webp" rounded Size="Sizes.ExtraSmall" />
    <Avatar Src="/images/people/profile-picture-3.webp" rounded Size="Sizes.Small" />
    <Avatar Src="/images/people/profile-picture-3.webp" rounded Size="Sizes.Base" />
    <Avatar Src="/images/people/profile-picture-3.webp" rounded Size="Sizes.Large" />
    <Avatar Src="/images/people/profile-picture-3.webp" rounded Size="Sizes.ExtraLarge" />
</div>
```