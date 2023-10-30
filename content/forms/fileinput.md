## Blazor File Input - Flowbite Tailwind

Get started with the file input component to let the user to upload one or more files from their device storage based on multiple styles and sizes

The file input component can be used to upload one or more files from the device storage of the user available in multiple sizes, styles, and variants and built with the utility-first classes from Tailwind CSS including support for dark mode.
    
### Setup
Import the form components from Flowbite.Blazor.Forms

```razor
@using Flowbite.Blazor.Forms
```

### File upload example
Get started with a simple file input component to let users upload one single file.

```razor
    <FileInput LabelText="Upload File" OnChange="@LoadFile"></FileInput>
```
    
### Helper text
Add a descriptive helper text to inform users the allowed extensions and sizes of the files.

```razor
<FileInput LabelText="Upload File" OnChange="@LoadFile" DescriptionText="SVG, PNG, JPG or GIF (MAX. 800x400px)" accept=".svg,.png,.jpg,.gif"></FileInput>
<FileInput Class="mt-4" LabelText="Upload File" OnChange="@LoadFile">
    <Paragraph Size="TextSizes.SM">Read about upload limits <Anchor Href="#">here</Anchor></Paragraph>
</FileInput>
```
    
### Multiple files
Apply the multiple attribute to the file input component to allow more files to be uploaded.
     
```razor
<FileInput LabelText="Upload multiple files" OnChange="@LoadMultipleFiles" multiple></FileInput>
```
    
### Sizes
Choose from the small, default, and large file input sizing options.

```razor
<FileInput LabelText="Small file input" OnChange="@LoadFile" Size="InputSizes.Small"></FileInput>
<FileInput Class="mt-4" LabelText="Default file input" OnChange="@LoadFile" Size="InputSizes.Medium"></FileInput>
<FileInput Class="mt-4" LabelText="Large file input" OnChange="@LoadFile" Size="InputSizes.Large"></FileInput>
```
    
### Border rounding
The RoundedClass parameter can be used to alter the amount of rounding applied to the file input.

```razor
<FileInput LabelText="No rounding" OnChange="@LoadFile" RoundedClass="rounded-none"></FileInput>
<FileInput LabelText="XL Rounding" OnChange="@LoadFile" RoundedClass="rounded-xl" Class="mt-4"></FileInput>
```

### Dropzone
The dropzone file input component can be used to upload one or more files by clicking anywhere in the area. Use the Dropzone parameter to enable this.


```razor
<FileInput OnChange="@LoadActFile" Dropzone DescriptionText="SVG, PNG, JPG or GIF (MAX. 800x400px)" accept=".svg,.png,.jpg,.gif"/>

@if (_file is not null)
{
    <Alert Class="mt-2" Color="AlertColors.Success">
        @_file?.Name
    </Alert>
}
<!-- With custom content inside dropzone -->
<FileInput OnChange="@LoadActMultipleFiles" Dropzone multiple>
    <UploadSolid class="w-8 h-8 mb-4 text-neutral-500 dark:text-neutral-400"></UploadSolid>
    <p class="mb-2 text-sm text-neutral-500 dark:text-neutral-400"><span class="font-semibold">Click to upload</span> or drag and drop</p>
    <p class="text-neutral-500 dark:text-neutral-400 italic">Upload up to @_maxAllowedFiles files</p>
</FileInput>

<ListGroup Class="mt-2">
    @foreach (var file in _loadedFiles)
    {
        <ListGroupItem>@file.Name</ListGroupItem>
    }
</ListGroup>

@code {
    private readonly List<IBrowserFile> _loadedFiles = new();
    private IBrowserFile? _file;
    private readonly long _maxFileSize = 1024 * 15;
    private readonly int _maxAllowedFiles = 3;

    private void LoadActFile(InputFileChangeEventArgs e)
    {
        try
        {
            if (e.File.Size < _maxFileSize)
            {
                _file = e.File;
            }
        }
        catch (Exception ex)
        {
            Logger.LogError("File: {FileName} Error: {Error}",
                e.File.Name, ex.Message);
        }
    }

    private void LoadActMultipleFiles(InputFileChangeEventArgs e)
    {
        _loadedFiles.Clear();

        foreach (var file in e.GetMultipleFiles(_maxAllowedFiles))
        {
            try
            {
                if (file.Size < _maxFileSize)
                {
                    _loadedFiles.Add(file);
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("File: {FileName} Error: {Error}",
                    file.Name, ex.Message);
            }
        }
    }
}
```