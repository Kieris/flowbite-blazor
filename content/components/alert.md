
## Alerts
#### Show contextual information to your users using alert elements based on Tailwind CSS

#### The alert component can be used to provide information to your users such as success or error messages, but also highlighted information complementing the normal flow of paragraphs and headers on a page.
#### Flowbite also includes dismissable alerts which can be hidden by the users by clicking on the close icon.


### Setup
#### Import the Alerts namespaces from Flowbite.Blazor.Alerts
```razor
@using Flowbite.Blazor.Components.Alerts
```
### Default alert
#### Use the following examples of alert components to show messages as feedback to your users.

```razor
<Alert>Primary alert! Change a few things up and try submitting again.</Alert>
<Alert Color="AlertColors.Supporting">Supporting alert! Change a few things up and try submitting again.</Alert>
<Alert Color="AlertColors.Accent">Accent alert! Change a few things up and try submitting again.</Alert>
<Alert Color="AlertColors.Danger">Danger alert! Change a few things up and try submitting again.</Alert>
<Alert Color="AlertColors.Warning">Warning alert! Change a few things up and try submitting again.</Alert>
<Alert Color="AlertColors.Success">Success alert! Change a few things up and try submitting again.</Alert>
<Alert Color="AlertColors.Neutral">Neutral alert! Change a few things up and try submitting again.</Alert>
```


### Alerts with Icon
#### You can also include a descriptive icon to complement the message inside the alert component with the following example.

```razor
<Alert>
    <Icon><InfoCircleSolid class="flex-shrink-0 inline w-4 h-4 mr-3"></InfoCircleSolid></Icon>
    <ChildContent>Primary alert! Change a few things up and try submitting again.</ChildContent>
</Alert>
<Alert Color="AlertColors.Supporting">
    <Icon><InfoCircleSolid class="flex-shrink-0 inline w-4 h-4 mr-3"></InfoCircleSolid></Icon>
    <ChildContent>Supporting alert! Change a few things up and try submitting again.</ChildContent>
</Alert>
<Alert Color="AlertColors.Accent">
    <Icon><InfoCircleSolid class="flex-shrink-0 inline w-4 h-4 mr-3"></InfoCircleSolid></Icon>
    <ChildContent>Accent alert! Change a few things up and try submitting again.</ChildContent>
</Alert>
<Alert Color="AlertColors.Danger">
    <Icon><InfoCircleSolid class="flex-shrink-0 inline w-4 h-4 mr-3"></InfoCircleSolid></Icon>
    <ChildContent>Danger alert! Change a few things up and try submitting again.</ChildContent>
</Alert>
<Alert Color="AlertColors.Warning">
    <Icon><InfoCircleSolid class="flex-shrink-0 inline w-4 h-4 mr-3"></InfoCircleSolid></Icon>
    <ChildContent>Warning alert! Change a few things up and try submitting again.</ChildContent>
</Alert>
<Alert Color="AlertColors.Success">
    <Icon><InfoCircleSolid class="flex-shrink-0 inline w-4 h-4 mr-3"></InfoCircleSolid></Icon>
    <ChildContent>Success alert! Change a few things up and try submitting again.</ChildContent>
</Alert>
<Alert Color="AlertColors.Neutral">
    <Icon><InfoCircleSolid class="flex-shrink-0 inline w-4 h-4 mr-3"></InfoCircleSolid></Icon>
    <ChildContent>Neutral alert! Change a few things up and try submitting again.</ChildContent>
</Alert>
```

    
### Bordered alerts
#### Use this example to add a border accent to the alert component instead of just a plain background.

```razor
<Alert Border="AlertBorder.Border">
    <Icon><InfoCircleSolid class="flex-shrink-0 inline w-4 h-4 mr-3"></InfoCircleSolid></Icon>
    <ChildContent>Primary alert! Change a few things up and try submitting again.</ChildContent>
</Alert>
<Alert Color="AlertColors.Supporting" Border="AlertBorder.Border">
    <Icon><InfoCircleSolid class="flex-shrink-0 inline w-4 h-4 mr-3"></InfoCircleSolid></Icon>
    <ChildContent>Supporting alert! Change a few things up and try submitting again.</ChildContent>
</Alert>
<Alert Color="AlertColors.Accent" Border="AlertBorder.Border">
    <Icon><InfoCircleSolid class="flex-shrink-0 inline w-4 h-4 mr-3"></InfoCircleSolid></Icon>
    <ChildContent>Accent alert! Change a few things up and try submitting again.</ChildContent>
</Alert>
<Alert Color="AlertColors.Danger" Border="AlertBorder.Border">
    <Icon><InfoCircleSolid class="flex-shrink-0 inline w-4 h-4 mr-3"></InfoCircleSolid></Icon>
    <ChildContent>Danger alert! Change a few things up and try submitting again.</ChildContent>
</Alert>
<Alert Color="AlertColors.Warning" Border="AlertBorder.Border">
    <Icon><InfoCircleSolid class="flex-shrink-0 inline w-4 h-4 mr-3"></InfoCircleSolid></Icon>
    <ChildContent>Warning alert! Change a few things up and try submitting again.</ChildContent>
</Alert>
<Alert Color="AlertColors.Success" Border="AlertBorder.Border">
    <Icon><InfoCircleSolid class="flex-shrink-0 inline w-4 h-4 mr-3"></InfoCircleSolid></Icon>
    <ChildContent>Success alert! Change a few things up and try submitting again.</ChildContent>
</Alert>
<Alert Color="AlertColors.Neutral" Border="AlertBorder.Border">
    <Icon><InfoCircleSolid class="flex-shrink-0 inline w-4 h-4 mr-3"></InfoCircleSolid></Icon>
    <ChildContent>Neutral alert! Change a few things up and try submitting again.</ChildContent>
</Alert>
```


### Alerts with list
#### Use this example to show a list and a description inside an alert component.

```razor
<Alert>
    <Icon><InfoCircleSolid class="flex-shrink-0 inline w-4 h-4 mr-3"></InfoCircleSolid></Icon>
    <ChildContent>
        <span class="sr-only">Info</span>
        <div>
            <span class="font-medium">Ensure that these requirements are met:</span>
            <ul class="mt-1.5 ml-4 list-disc list-inside">
                <li>At least 10 characters (and up to 100 characters)</li>
                <li>At least one lowercase character</li>
                <li>Inclusion of at least one special character, e.g., ! @@ # ?</li>
            </ul>
        </div>
    </ChildContent>
</Alert>
<Alert Color="AlertColors.Danger">
    <Icon><InfoCircleSolid class="flex-shrink-0 inline w-4 h-4 mr-3"></InfoCircleSolid></Icon>
    <ChildContent>
        <span class="sr-only">Info</span>
        <div>
            <span class="font-medium">Ensure that these requirements are met:</span>
            <ul class="mt-1.5 ml-4 list-disc list-inside">
                <li>At least 10 characters (and up to 100 characters)</li>
                <li>At least one lowercase character</li>
                <li>Inclusion of at least one special character, e.g., ! @@ # ?</li>
            </ul>
        </div>
    </ChildContent>
</Alert>
```
    
### Dismissing
#### Use the following alert elements that are also dismissable.

```razor
<Alert Dismissable="true">
    <Icon><InfoCircleSolid class="flex-shrink-0 inline w-4 h-4 mr-3"></InfoCircleSolid></Icon>
    <ChildContent>Primary alert! Change a few things up and try submitting again.</ChildContent>
</Alert>
<Alert Color="AlertColors.Supporting" Dismissable="true">
    <Icon><InfoCircleSolid class="flex-shrink-0 inline w-4 h-4 mr-3"></InfoCircleSolid></Icon>
    <ChildContent>Supporting alert! Change a few things up and try submitting again.</ChildContent>
</Alert>
<Alert Color="AlertColors.Accent" Dismissable="true">
    <Icon><InfoCircleSolid class="flex-shrink-0 inline w-4 h-4 mr-3"></InfoCircleSolid></Icon>
    <ChildContent>Accent alert! Change a few things up and try submitting again.</ChildContent>
</Alert>
<Alert Color="AlertColors.Danger" Dismissable="true">
    <Icon><InfoCircleSolid class="flex-shrink-0 inline w-4 h-4 mr-3"></InfoCircleSolid></Icon>
    <ChildContent>Danger alert! Change a few things up and try submitting again.</ChildContent>
</Alert>
<Alert Color="AlertColors.Warning" Dismissable="true">
    <Icon><InfoCircleSolid class="flex-shrink-0 inline w-4 h-4 mr-3"></InfoCircleSolid></Icon>
    <ChildContent>Warning alert! Change a few things up and try submitting again.</ChildContent>
</Alert>
<Alert Color="AlertColors.Success" Dismissable="true">
    <Icon><InfoCircleSolid class="flex-shrink-0 inline w-4 h-4 mr-3"></InfoCircleSolid></Icon>
    <ChildContent>Success alert! Change a few things up and try submitting again.</ChildContent>
</Alert>
<Alert Color="AlertColors.Neutral" Dismissable="true">
    <Icon><InfoCircleSolid class="flex-shrink-0 inline w-4 h-4 mr-3"></InfoCircleSolid></Icon>
    <ChildContent>Neutral alert! Change a few things up and try submitting again.</ChildContent>
</Alert>
```

    
### Accent borders
#### Use this example to add a border accent on top of the alert component for further visual distinction.

```razor
<Alert Border="AlertBorder.TopAccent" Dismissable="true">
    <Icon><InfoCircleSolid class="flex-shrink-0 inline w-4 h-4 mr-3"></InfoCircleSolid></Icon>
    <ChildContent>Primary alert! This is a top accent.</ChildContent>
</Alert>
<Alert Color="AlertColors.Supporting" Border="AlertBorder.TopAccent" Dismissable="true">
    <Icon><InfoCircleSolid class="flex-shrink-0 inline w-4 h-4 mr-3"></InfoCircleSolid></Icon>
    <ChildContent>Supporting alert! This is a top accent.</ChildContent>
</Alert>
<Alert Color="AlertColors.Danger" Border="AlertBorder.TopAccent" Dismissable="true">
    <Icon><InfoCircleSolid class="flex-shrink-0 inline w-4 h-4 mr-3"></InfoCircleSolid></Icon>
    <ChildContent>Danger alert! This is a top accent.</ChildContent>
</Alert>
<Alert Border="AlertBorder.BottomAccent" Dismissable="true">
    <Icon><InfoCircleSolid class="flex-shrink-0 inline w-4 h-4 mr-3"></InfoCircleSolid></Icon>
    <ChildContent>Primary alert! This is a bottom accent.</ChildContent>
</Alert>
<Alert Color="AlertColors.Supporting" Border="AlertBorder.BottomAccent" Dismissable="true">
    <Icon><InfoCircleSolid class="flex-shrink-0 inline w-4 h-4 mr-3"></InfoCircleSolid></Icon>
    <ChildContent>Supporting alert! This is a bottom accent.</ChildContent>
</Alert>
<Alert Color="AlertColors.Danger" Border="AlertBorder.BottomAccent" Dismissable="true">
    <Icon><InfoCircleSolid class="flex-shrink-0 inline w-4 h-4 mr-3"></InfoCircleSolid></Icon>
    <ChildContent>Danger alert! This is a bottom accent.</ChildContent>
</Alert>
```


### Additional content
#### The following alert components can be used if you wish to disclose more information inside the element.


```razor
<Alert @ref="@primaryAlert" VisibleChanged="@UpdateState">
    <Icon><InfoCircleSolid class="flex-shrink-0 inline w-4 h-4 mr-3"></InfoCircleSolid></Icon>
    <ChildContent>
        <span class="sr-only">Info</span>
        <div>
            <h3 class="text-lg font-medium">This is a info alert</h3>
        </div>
    </ChildContent>
    <Extra>
        <div class="mt-2 mb-4 text-sm">
            More info about this info alert goes here. This example text is going to run a bit longer so that you can see how spacing within an alert works with this kind of content.
        </div>
        <div class="flex">
            <Button class="inline-flex items-center mr-2" Size="Sizes.ExtraSmall" >
                <EyeSolid class="-ml-0.5 mr-2 h-3 w-3"></EyeSolid>
                View more
            </Button>
            <Button Outline="true" Size="Sizes.ExtraSmall" 
                    OnClick="@primaryAlert.Hide" aria-label="Close">
                Dismiss
            </Button>
        </div>
    </Extra>
</Alert>
<Alert @ref="@dangerAlert" Color="AlertColors.Danger" VisibleChanged="@UpdateState">
    <Icon><InfoCircleSolid class="flex-shrink-0 inline w-4 h-4 mr-3"></InfoCircleSolid></Icon>
    <ChildContent>
        <span class="sr-only">Info</span>
        <div>
            <h3 class="text-lg font-medium">This is a info alert</h3>
        </div>
    </ChildContent>
    <Extra>
        <div class="mt-2 mb-4 text-sm">
            More info about this info alert goes here. This example text is going to run a bit longer so that you can see how spacing within an alert works with this kind of content.
        </div>
        <div class="flex">
            <Button class="inline-flex items-center mr-2" Color="Colors.Red" Size="Sizes.ExtraSmall" >
                <EyeSolid class="-ml-0.5 mr-2 h-3 w-3"></EyeSolid>
                View more
            </Button>
            <Button Color="Colors.Red" Outline="true" Size="Sizes.ExtraSmall" 
                    OnClick="@dangerAlert.Hide" aria-label="Close">
                Dismiss
            </Button>
        </div>
    </Extra>
</Alert>
<div class="flex justify-center gap-4">
    @if (primaryAlert.Hidden)
    {
        <Button OnClick="@primaryAlert.Show">Show Primary Alert</Button>
    }
    @if (dangerAlert.Hidden)
    {
        <Button OnClick="@dangerAlert.Show" Color="Colors.Red">Show Danger Alert</Button>
    }
</div>
```


```csharp
    private Alert primaryAlert = new();
    private Alert dangerAlert = new();

    //Update this view to show the "Show" buttons when they are dismissed
    private void UpdateState()
    {
        StateHasChanged();
    }
```