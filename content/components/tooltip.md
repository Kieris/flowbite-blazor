## Tooltip
    
#### Use the following Tailwind CSS powered tooltips to show extra content when hovering or focusing on an element.

Tooltips allow you to show extra information when hovering or focusing over an element in multiple positions, styles, and animations.
### Setup
Import the tooltip namespace from Flowbite.Blazor.Components.Tooltip. Tooltips also require popper.js, so you need to either import the packaged        version or another version of popper into the _Layout.cshtml (.NET 7.0 Blazor Server) or index.html (.NET 7.0 Blazor WASM).

```razor
@using Flowbite.Blazor.Components.Tooltip
```

```razor            
<script type=\"text/javascript\" src=\"_content/Flowbite.Blazor/js/popper.js\"></script>
```

### Default tooltip
The default tooltip trigger is hover and the default position is auto. To change the trigger type to click, add Trigger="click".
        
```razor
<!-- No placement given makes the placement "auto" -->
<Tooltip Text="I'm a tooltip">
    <Button>Hover me</Button>
</Tooltip>
<Tooltip Text="I'm a tooltip from click" Trigger="click" Placement="Positions.Top">
    <Button>Click me</Button>
</Tooltip>
```
    
### Placement
The positioning of the tooltip element relative to the triggering element can be set with the Placement attribute. Based on the Positions enum, there are many position options including auto which will flip the tooltip depending on how close the tooltip is from going off the screen. 
        
```razor
<Tooltip Text="I'm a bottom tooltip" Placement="Positions.Bottom">
    <Button>Bottom</Button>
</Tooltip>
<Tooltip Text="I'm a top tooltip" Placement="Positions.Top">
    <Button>Top</Button>
</Tooltip>
<Tooltip Text="I'm a left tooltip" Placement="Positions.Left">
    <Button>Left</Button>
</Tooltip>
<Tooltip Text="I'm a right tooltip" Placement="Positions.Right">
    <Button>Right</Button>
</Tooltip>
```
    
### Tooltip styles

You can use choose between dark and light version styles for the tooltip component by changing the Theme attribute. By default, the tooltip will change based on whether the element contains the "dark" class like other elements do. If you set a value for the Class attribute, the tooltip can be completely customized.

```razor
<Tooltip Text="I'm a light tooltip" Theme="TooltipTheme.Light">
    <Button>Light Theme</Button>
</Tooltip>
<Tooltip Text="I'm a dark tooltip" Theme="TooltipTheme.Dark">
    <Button>Dark Theme</Button>
</Tooltip>
<Tooltip Text="I'm an auto themed tooltip">
    <Button>Auto theme</Button>
</Tooltip>
<Tooltip Text="I'm a custom blue tooltip"
            Class="bg-blue-300 text-black px-3 py-3 text-lg font-medium rounded-full shadow-sm">
    <Button>Custom Theme</Button>
</Tooltip>
```
    
### Hover delay
The time it takes for the tooltip to show after hovering can be set with the Delay attribute.
        
```razor
<Tooltip Text="I'm a delayed tooltip." Delay="1000">
    <Button>Delayed show</Button>
</Tooltip>
```
    
### Disable arrow
The arrow connected to the tooltip can be hidden by using ShowArrow="false".
   
```razor
<Tooltip Text="I have no arrow." ShowArrow="false">
    <Button>Hidden arrow</Button>
</Tooltip>
<Tooltip Text="I have no arrow." ShowArrow="false" Trigger="click" Placement="Positions.Right">
    <Button>Click Trigger Hidden arrow</Button>
</Tooltip>
```