
## Blazor Textarea - Flowbite Tailwind
Use the textarea component as a multi-line text field input and use it inside form elements available in multiple sizes, styles, and variants

The textarea component is a multi-line text field input that can be used to receive longer chunks of text from the user in the form of a comment box, description field, and more.

### Setup
Import the form components from Flowbite.Blazor.Forms

```razor
@using Flowbite.Blazor.Forms
```

### Textarea example
Get started with the default example of a textarea component below.

```razor
<Textarea LabelText="Your message" @bind-Value="_value1" Placeholder="Write your thoughts here..."></Textarea>
```

### WYSIWYG Editor
If you want to add other actions as buttons alongside your textarea component, such as with a WYSIWYG editor, then you can use the example below.

```razor
<EditForm EditContext="@_context">
    <DataAnnotationsValidator></DataAnnotationsValidator>
    @if (_context?.GetValidationMessages() is not null && _context.GetValidationMessages().Any())
    {
        <Alert Color="AlertColors.Danger">
            <ValidationMessage For="() => _model.Post" TValue="string"></ValidationMessage>    
        </Alert>
    }
    <div class="w-full mb-4 border border-neutral-200 rounded-lg bg-neutral-50 dark:bg-neutral-700 dark:border-neutral-600">
        <div class="flex items-center justify-between px-3 py-2 border-b dark:border-neutral-600">
            <div class="flex flex-wrap items-center divide-neutral-200 sm:divide-x dark:divide-neutral-600">
                <div class="flex items-center space-x-1 sm:pr-4">
                    <button type="button" class="p-2 text-neutral-500 rounded cursor-pointer hover:text-neutral-900 hover:bg-neutral-100 dark:text-neutral-400 dark:hover:text-white dark:hover:bg-neutral-600">
                        <PaperClipSolid class="w-4 h-4"></PaperClipSolid>
                        <span class="sr-only">Attach file</span>
                    </button>
                    <button type="button" class="p-2 text-neutral-500 rounded cursor-pointer hover:text-neutral-900 hover:bg-neutral-100 dark:text-neutral-400 dark:hover:text-white dark:hover:bg-neutral-600">
                        <MapPinAltSolid class="w-4 h-4"></MapPinAltSolid>
                        <span class="sr-only">Embed map</span>
                    </button>
                    <button type="button" class="p-2 text-neutral-500 rounded cursor-pointer hover:text-neutral-900 hover:bg-neutral-100 dark:text-neutral-400 dark:hover:text-white dark:hover:bg-neutral-600">
                        <FileEditSolid class="w-4 h-4"></FileEditSolid>
                        <span class="sr-only">Upload image</span>
                    </button>
                    <button type="button" class="p-2 text-neutral-500 rounded cursor-pointer hover:text-neutral-900 hover:bg-neutral-100 dark:text-neutral-400 dark:hover:text-white dark:hover:bg-neutral-600">
                        <FileCodeSolid class="w-4 h-4"></FileCodeSolid>
                        <span class="sr-only">Format code</span>
                    </button>
                    <button type="button" class="p-2 text-neutral-500 rounded cursor-pointer hover:text-neutral-900 hover:bg-neutral-100 dark:text-neutral-400 dark:hover:text-white dark:hover:bg-neutral-600">
                        <FaceGrinSolid class="w-4 h-4"></FaceGrinSolid>
                        <span class="sr-only">Add emoji</span>
                    </button>
                </div>
                <div class="flex flex-wrap items-center space-x-1 sm:pl-4">
                    <button type="button" class="p-2 text-neutral-500 rounded cursor-pointer hover:text-neutral-900 hover:bg-neutral-100 dark:text-neutral-400 dark:hover:text-white dark:hover:bg-neutral-600">
                        <ListOrderedSolid class="w-4 h-4"></ListOrderedSolid>
                        <span class="sr-only">Add list</span>
                    </button>
                    <button type="button" class="p-2 text-neutral-500 rounded cursor-pointer hover:text-neutral-900 hover:bg-neutral-100 dark:text-neutral-400 dark:hover:text-white dark:hover:bg-neutral-600">
                        <UserSettingsSolid class="w-4 h-4"></UserSettingsSolid>
                        <span class="sr-only">Settings</span>
                    </button>
                    <button type="button" class="p-2 text-neutral-500 rounded cursor-pointer hover:text-neutral-900 hover:bg-neutral-100 dark:text-neutral-400 dark:hover:text-white dark:hover:bg-neutral-600">
                        <FileLinesSolid class="w-4 h-4"></FileLinesSolid>
                        <span class="sr-only">Timeline</span>
                    </button>
                    <button type="button" class="p-2 text-neutral-500 rounded cursor-pointer hover:text-neutral-900 hover:bg-neutral-100 dark:text-neutral-400 dark:hover:text-white dark:hover:bg-neutral-600">
                        <DownloadSolid class="w-4 h-4"></DownloadSolid>
                        <span class="sr-only">Download</span>
                    </button>
                </div>
            </div>
            <button type="button" data-tooltip-target="tooltip-fullscreen" class="p-2 text-neutral-500 rounded cursor-pointer sm:ml-auto hover:text-neutral-900 hover:bg-neutral-100 dark:text-neutral-400 dark:hover:text-white dark:hover:bg-neutral-600">
                <Tooltip Text="Show full screen">
                    <ExpandSolid class="w-4 h-4"></ExpandSolid>
                    <span class="sr-only">Full screen</span>
                </Tooltip>
            </button>
        </div>
        <div class="px-4 py-2 bg-white rounded-b-lg dark:bg-neutral-800">
            <Textarea Id="editor" @bind-Value="@_model.Post" rows="8" LabelText="Publish post" Placeholder="Write an article..." ShowError="false"
        ColorClass="text-neutral-800 bg-white border-0 dark:bg-neutral-800 focus:ring-0 dark:text-white dark:placeholder-neutral-400" LabelScreenReaderOnly></Textarea>
        </div>
    </div>
    <Button type="submit">
        Publish post
    </Button>
</EditForm>
```


### Comment box
Most often the textarea component is used as the main text field input element in comment sections. Use this example to also apply a helper text and buttons below the textarea itself.

```razor
<EditForm EditContext="@_commentContext">
    <DataAnnotationsValidator></DataAnnotationsValidator>
    <div class="w-full mb-4 border border-neutral-200 rounded-lg bg-neutral-50 dark:bg-neutral-700 dark:border-neutral-600">
        <div class="px-4 py-2 bg-white rounded-t-lg dark:bg-neutral-800">
            <Textarea id="comment" @bind-Value="@_model.Post" LabelText="Your comment" LabelScreenReaderOnly rows="4" placeholder="Write a comment..."
            ColorClass="text-neutral-800 bg-white border-0 dark:bg-neutral-800 focus:ring-0 dark:text-white dark:placeholder-neutral-400" AlertStyle
            SuccessMessage="Your comment is valid."></Textarea>
        </div>
        <div class="flex items-center justify-between px-3 py-2 border-t dark:border-neutral-600">
            <Button type="submit">
                Post comment
            </Button>
            <div class="flex pl-0 space-x-1 sm:pl-2">
                <button type="button" class="inline-flex justify-center items-center p-2 text-neutral-500 rounded cursor-pointer hover:text-neutral-900 hover:bg-neutral-100 dark:text-neutral-400 dark:hover:text-white dark:hover:bg-neutral-600">
                    <PaperClipSolid class="w-4 h-4"></PaperClipSolid>
                    <span class="sr-only">Attach file</span>
                </button>
                <button type="button" class="inline-flex justify-center items-center p-2 text-neutral-500 rounded cursor-pointer hover:text-neutral-900 hover:bg-neutral-100 dark:text-neutral-400 dark:hover:text-white dark:hover:bg-neutral-600">
                    <MapPinAltSolid class="w-4 h-4"></MapPinAltSolid>
                    <span class="sr-only">Set location</span>
                </button>
                <button type="button" class="inline-flex justify-center items-center p-2 text-neutral-500 rounded cursor-pointer hover:text-neutral-900 hover:bg-neutral-100 dark:text-neutral-400 dark:hover:text-white dark:hover:bg-neutral-600">
                    <ImageSolid class="w-4 h-4"></ImageSolid>
                    <span class="sr-only">Upload image</span>
                </button>
            </div>
        </div>
    </div>
</EditForm>
<Paragraph class="ml-auto text-xs text-neutral-500 dark:text-neutral-400">Remember, contributions to this topic should follow our <Anchor href="#">Community Guidelines</Anchor>.</Paragraph>
```
### Chatroom input
If you want to build a chatroom component you will usually want to use a textarea element to allow users to write multi-line chunks of text.

```razor
<div class="flex items-center px-3 py-2 rounded-lg bg-neutral-50 dark:bg-neutral-700">
    <Button type="button" Size="Sizes.Icon" Color="Colors.None" Class="p-2 hover:bg-neutral-100 dark:hover:bg-neutral-600">    
        <ImageOutline class="w-5 h-5 text-neutral-500 hover:text-neutral-900 dark:text-neutral-400 dark:hover:text-white"></ImageOutline>
        <span class="sr-only">Upload image</span>
    </Button>
    <Button type="button" Size="Sizes.Icon" Color="Colors.None" Class="p-2 hover:bg-neutral-100 dark:hover:bg-neutral-600">
        <FaceGrinOutline class="w-5 h-5 text-neutral-500 hover:text-neutral-900 dark:text-neutral-400 dark:hover:text-white"></FaceGrinOutline>
        <span class="sr-only">Add emoji</span>
    </Button>
    <div class="flex-1 mx-2">
        <Textarea @bind-Value="@_model.Post" Id="chat" rows="1" Placeholder="Your message..."></Textarea>
    </div>
    <button type="submit" class="inline-flex justify-center p-2 text-primary-600 rounded-full cursor-pointer hover:bg-primary-100 dark:text-primary-500 dark:hover:bg-neutral-600">
        <PaperPlaneSolid class="w-5 h-5 rotate-90 ml-1"></PaperPlaneSolid>
        <span class="sr-only">Send message</span>
    </button>
</div>
```

### OnChanged callback

The OnChanged callback can be used to know when an input as been changed and returns the current value.

```razor
<Textarea LabelText="Your message" @bind-Value="_value1" OnChanged="((val) => _callVal = val)" Placeholder="Write your thoughts here..."></Textarea>
<Paragraph Class="mt-2">Value: @_value1</Paragraph>
<Paragraph Class="mt-2">Callback return: @_callVal</Paragraph>
```

```razor
@code {
    EditContext? _context;
    EditContext? _commentContext;

    string _value1 = string.Empty;
    string _callVal = string.Empty;

    TextAreaTestModel _model = new();
}
``` 

