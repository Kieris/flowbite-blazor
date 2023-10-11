### Spinner
Use the spinner component as a loader indicator in your projects when fetching data based on an animated SVG

The spinner component can be used as a loading indicator which comes in multiple colors, sizes, and styles separately or inside elements such as buttons to improve the user experience whenever data is being fetched from your server.
  

### Setup
Import the Spinner namespace from Flowbite.Blazor.Components.Spinner

```razor
@using Flowbite.Blazor.Components.Spinner
```

### Default spinner

Use the following SVG element to show a loading animation.

```razor
    <Spinner />  
```

### Colors
You can change the colors of the spinner element using the Color parameter.
    
```razor
<div class="flex flex-wrap gap-2">
    <Spinner/>
    <Spinner Color="Colors.Supporting"/>
    <Spinner Color="Colors.Accent"/>
    <Spinner Color="Colors.Neutral"/>
    <Spinner Color="Colors.Danger"/>
    <Spinner Color="Colors.Warning"/>
    <Spinner Color="Colors.Success"/>
    <Spinner Color="Colors.Light"/>
    <Spinner Color="Colors.None" CustomColor="fill-pink-600"/>
</div>
```

    
### Sizes
Change the size of the spinner component by using SizeClass and setting the h-{*} and w-{*} utility classes.

```razor
<div class="flex flex-wrap gap-2">
    <Spinner SizeClass="w-4 h-4"/>
    <Spinner SizeClass="w-6 h-6"/>
    <Spinner/>
    <Spinner SizeClass="w-10 h-10"/>
    <Spinner SizeClass="w-12 h-12"/>
</div>
```
    
### Alignment
Because the spinner component is an inline HTML element it can easily be aligned on the left, center, or right side using the text-{left|center|right} utility classes:

```razor
<Spinner Class="text-left"/>
<Spinner Class="text-center"/>
<Spinner Class="text-right"/>
```
    
### Spinner with card
Use this animated loading indicator when content inside of a card is still loading. 

```razor
<div class="relative items-center block max-w-sm p-6 bg-white border border-gray-100 rounded-lg shadow-md dark:bg-gray-800 dark:border-gray-800 dark:hover:bg-gray-700">
    <h5 class="mb-2 text-2xl font-bold tracking-tight text-gray-900 dark:text-white opacity-20">Noteworthy technology acquisitions 2021</h5>
    <p class="font-normal text-gray-700 dark:text-gray-400 opacity-20">Here are the biggest enterprise technology acquisitions of 2021 so far, in reverse chronological order.</p>
    <Spinner Class="absolute -translate-x-1/2 -translate-y-1/2 top-2/4 left-1/2" />
</div>
```
    
### Progress spinner
Use this animated spinner component inside a list of steppers elements.

```razor
<h2 class="mb-2 text-lg font-semibold text-gray-900 dark:text-white">Converting your image:</h2>
<ul class="max-w-md space-y-2 text-gray-500 list-inside dark:text-gray-400">
    <li class="flex items-center">
        <CheckCircleSolid class="w-4 h-4 mr-2 text-green-500 dark:text-green-400 flex-shrink-0"></CheckCircleSolid>
        Upload your file to our website
    </li>
    <li class="flex items-center">
        <CheckCircleSolid class="w-4 h-4 mr-2 text-green-500 dark:text-green-400 flex-shrink-0"></CheckCircleSolid>
        Choose your file format
    </li>
    <li class="flex items-center">
        <Spinner SizeClass="w-4 h-4 mr-2"/>
        Preparing your file
    </li>
</ul>
```
    
### Buttons
The spinner component can also be used inside elements such as buttons when submitting form data:
    
```razor
<div class="flex flex-wrap gap-2">
    <Button>
        <Spinner SizeClass="w-4 h-4 mr-3" Color="Colors.Light"></Spinner>
        Loading...
    </Button>
    <Button Color="Colors.Light">
        <Spinner SizeClass="w-4 h-4 mr-3"></Spinner>
        Loading...
    </Button>
</div>
```