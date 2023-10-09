## Progress Bar
Use the progress bar component to show the completion rate of a data indicator or use it as a loader element
        
The progress bar component can be used as an indicator to show the completion rate of data sets or it can be used as an animated loader component. There are multiple sizes, colors, and styles available.

### Setup
Import the Progress namespace from Flowbite.Blazor.Components.Progress

```razor
@using Flowbite.Blazor.Components.Progress
```

### Default progress bar
Use the following example of a progress bar element to show a completion rate of 45%.
 
```razor
<ProgressBar Progress="45" />
```
    
    
### Sizes
You can also use different sizes by using various sizes in SharedEnums.Sizes.

```razor
<div class="mb-1 text-base font-medium dark:text-white">Extra small</div>
<ProgressBar Progress="25" Size="Sizes.ExtraSmall" OuterClass="mb-3"/>
<div class="mb-1 text-base font-medium dark:text-white">Small</div>
<ProgressBar Progress="45" Size="Sizes.Small" OuterClass="mb-3"/>
<div class="mb-1 text-base font-medium dark:text-white">Default</div>
<ProgressBar Progress="55" Size="Sizes.Base" OuterClass="mb-3"/>
<div class="mb-1 text-base font-medium dark:text-white">Large</div>
<ProgressBar Progress="75" Size="Sizes.Large" OuterClass="mb-3"/>
<div class="mb-1 text-base font-medium dark:text-white">Extra large</div>
<ProgressBar Progress="100" Size="Sizes.ExtraLarge" OuterClass="mb-3"/>
```
    
### With label inside
Here is an example of using a progress bar with the label inside the bar.

```razor
<ProgressBar Progress="45" Size="Sizes.Large" LabelInside="45%"/>
```

### With label outside
And this is an example of using a progress bar outside the bar.
            
```razor
<div class="flex justify-between mb-1">
    <span class="text-base font-medium text-primary-700 dark:text-white">Flowbite</span>
    <span class="text-sm font-medium text-primary-700 dark:text-white">45%</span>
</div>
<ProgressBar Progress="45"/>
```
    
### Colors
Various colors can be used for the progress bar.

```razor
<div>
    <div class="mb-1 text-base font-medium text-primary-600 dark:text-white">Primary</div>
    <ProgressBar Progress="65" Color="Colors.Primary"/>
</div>
<div>
    <div class="mb-1 text-base font-medium text-danger-600 dark:text-white">Danger</div>
    <ProgressBar Progress="65" Color="Colors.Danger"/>
</div>
<div>
    <div class="mb-1 text-base font-medium text-success-600 dark:text-white">Success</div>
    <ProgressBar Progress="65" Color="Colors.Success"/>
</div>
<div>
    <div class="mb-1 text-base font-medium text-warning-400 dark:text-white">Warning</div>
    <ProgressBar Progress="65" Color="Colors.Warning"/>
</div>
<div>
    <div class="mb-1 text-base font-medium text-supporting-600 dark:text-white">Supporting</div>
    <ProgressBar Progress="65" Color="Colors.Supporting"/>
</div>
<div>
    <div class="mb-1 text-base font-medium text-accent-600 dark:text-white">Accent</div>
    <ProgressBar Progress="65" Color="Colors.Accent"/>
</div>
<div>
    <div class="mb-1 text-base font-medium text-neutral-600 dark:text-white">Neutral</div>
    <ProgressBar Progress="65" Color="Colors.Neutral"/>
</div>
```
    
### Animate progress
Here is an example of progress bar with animate-pulse and with incrementing progress.

```razor
<div class="flex flex-col justify-center items-center gap-4">
    <ProgressBar Progress="75" InnerClass="animate-pulse"/>
    <ProgressBar Progress="@_progress" Size="Sizes.Large" LabelInside="@($"{_progress}%")"/>
    <Button OnClick="@CountProgress" Class="w-48">Start Progress</Button>
</div>
```
```csharp
private int _progress = 0;
private async void CountProgress()
{
    _progress = 0;
    for (int i = 0; i < 100; i+=10)
    {
        await Task.Delay(200);
        _progress+=10;
        await InvokeAsync(StateHasChanged);
    }
}
```