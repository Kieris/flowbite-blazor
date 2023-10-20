## Blazor Text - Flowbite
Learn how to customize text-related styles and properties such as font size, font style, text decoration, font weight and more

Get started with a collection of text customization examples to learn how to update the size, font weight, style, decoration and spacing of inline text elements.

### Setup
Import the Paragraph and Span components from Flowbite.Blazor.Typography

```razor
@using Flowbite.Blazor.Typography
```

### Font size
Use this example to set the font size of inline text elements using the Size parameter.

```razor
<Paragraph Size="TextSizes.XS">Aa</Paragraph>
<Paragraph Size="TextSizes.SM">Aa</Paragraph>
<Paragraph Size="TextSizes.Base">Aa</Paragraph>
<Paragraph Size="TextSizes.LG">Aa</Paragraph>
<Paragraph Size="TextSizes.XL">Aa</Paragraph>
<Paragraph Size="TextSizes.XL2">Aa</Paragraph>
<Paragraph Size="TextSizes.XL3">Aa</Paragraph>
<Paragraph Size="TextSizes.XL4">Aa</Paragraph>
<Paragraph Size="TextSizes.XL5">Aa</Paragraph>
<Paragraph Size="TextSizes.XL6">Aa</Paragraph>
<Paragraph Size="TextSizes.XL7">Aa</Paragraph>
<Paragraph Size="TextSizes.XL8">Aa</Paragraph>
<Paragraph Size="TextSizes.XL9">Aa</Paragraph>
```
    
### Font weight
This example can be used to the font weight of an inline text element using the Weight parameter.

```razor
<Paragraph Size="TextSizes.XL4" Weight="FontWeights.Thin">Aa</Paragraph>
<Paragraph Size="TextSizes.XL4" Weight="FontWeights.ExtraLight">Aa</Paragraph>
<Paragraph Size="TextSizes.XL4" Weight="FontWeights.Light">Aa</Paragraph>
<Paragraph Size="TextSizes.XL4" Weight="FontWeights.Normal">Aa</Paragraph>
<Paragraph Size="TextSizes.XL4" Weight="FontWeights.Medium">Aa</Paragraph>
<Paragraph Size="TextSizes.XL4" Weight="FontWeights.SemiBold">Aa</Paragraph>
<Paragraph Size="TextSizes.XL4" Weight="FontWeights.Bold">Aa</Paragraph>
<Paragraph Size="TextSizes.XL4" Weight="FontWeights.ExtraBold">Aa</Paragraph>
<Paragraph Size="TextSizes.XL4" Weight="FontWeights.Black">Aa</Paragraph>
```
    
### Text color
Use the Color parameter to set the color of the inline text.

```razor
<Paragraph Color="text-blue-700 dark:text-blue-500">This text is in the blue color.</Paragraph>
<Paragraph Color="text-green-700 dark:text-green-500">This text is in the green color.</Paragraph>
<Paragraph Color="text-red-700 dark:text-red-500">This text is in the red color.</Paragraph>
<Paragraph Color="text-purple-700 dark:text-purple-500">This text is in the purple color.</Paragraph>
<Paragraph Color="text-teal-700 dark:text-teal-500">This text is in the teal color.</Paragraph>
```

    
### Letter spacing
Increase or decrease the spacing between letters using the Space parameter.

```razor
<Paragraph Space="Spaces.Tighter">Flowbite app will help you improve yourself by analysing your everyday life.</Paragraph>
<Paragraph Space="Spaces.Tight">Flowbite app will help you improve yourself by analysing your everyday life.</Paragraph>
<Paragraph Space="Spaces.Normal">Flowbite app will help you improve yourself by analysing your everyday life.</Paragraph>
<Paragraph Space="Spaces.Wide">Flowbite app will help you improve yourself by analysing your everyday life.</Paragraph>
<Paragraph Space="Spaces.Wider">Flowbite app will help you improve yourself by analysing your everyday life.</Paragraph>
<Paragraph Space="Spaces.Widest">Flowbite app will help you improve yourself by analysing your everyday life.</Paragraph>
```
    
### Text decoration
                
#### Underline
Update the text decoration style using the Underline and DecorationClass parameters.

```razor
<Paragraph>
    Track work across the enterprise through an open, collaborative platform. <Span underline>Link issues across Jira</Span> 
    and ingest data from other <Span underline DecorationClass="decoration-blue-500 decoration-double">software development</Span> 
    tools, so your IT support and operations teams have richer contextual information to rapidly respond to 
    <Span underline DecorationClass="decoration-green-500 decoration-dotted">requests</Span>, 
    <Span underline DecorationClass="decoration-4 decoration-red-500 decoration-dashed">incidents</Span>, and 
    <Span underline DecorationClass="decoration-sky-500 decoration-wavy">changes</Span>.
</Paragraph>
```
    
#### Line through
Set a strikethrough line on a text element using the LineThrough parameter.

```razor
<Span LineThrough="true">$109</Span><Span class="ml-3">$79</Span>
<Span lineThrough class="ml-3">$109</Span><Span class="ml-3">$79</Span>
```
    
#### Uppercase
Force uppercase characters for a given portion of text using the uppercase parameter.

```razor
<Paragraph>The crypto <Span Uppercase="true">identity</Span> primitive.</Paragraph>
<Paragraph>The crypto <Span uppercase>identity</Span> primitive.</Paragraph>
```
    
### Font Style
                    
#### Italic
Use the Italic parameter to set italic font style to a text element. Text elements by default are non-italic.

```razor
<Paragraph Italic="true">The crypto identity primitive.</Paragraph>
<Paragraph italic>The crypto identity primitive.</Paragraph>
```

### Line heights
Set the height between lines using the Height parameter.

```razor
<Paragraph Size="TextSizes.XL2" Height="Heights.None" Class="max-w-lg">The Al-powered app will help you improve yourself by analysing your everyday life.</Paragraph>
<Paragraph Size="TextSizes.XL2" Height="Heights.Tight" Class="max-w-lg">The Al-powered app will help you improve yourself by analysing your everyday life.</Paragraph>
<Paragraph Size="TextSizes.XL2" Height="Heights.Snug" Class="max-w-lg">The Al-powered app will help you improve yourself by analysing your everyday life.</Paragraph>
<Paragraph Size="TextSizes.XL2" Height="Heights.Normal" Class="max-w-lg">The Al-powered app will help you improve yourself by analysing your everyday life.</Paragraph>
<Paragraph Size="TextSizes.XL2" Height="Heights.Relaxed" Class="max-w-lg">The Al-powered app will help you improve yourself by analysing your everyday life.</Paragraph>
<Paragraph Size="TextSizes.XL2" Height="Heights.Loose" Class="max-w-lg">The Al-powered app will help you improve yourself by analysing your everyday life.</Paragraph>
```

### Text alignment
Align the paragraph component to the left (default), center or right side of the document page using the Align parameter.

#### Left
Use Align="Aligns.Left" or the default to align the paragraph text to the left.

```razor
<Paragraph Align="Aligns.Left">
    Track work across the enterprise through an open, collaborative platform. Link issues across Jira and ingest data 
    from other software development tools, so your IT support and operations teams have richer contextual information 
    to rapidly respond to requests, incidents, and changes.
</Paragraph>
```

#### Center
Use Align="Aligns.Center" to align the paragraph text to the center.

```razor
<Paragraph Align="Aligns.Center">
    Track work across the enterprise through an open, collaborative platform. Link issues across Jira and ingest data 
    from other software development tools, so your IT support and operations teams have richer contextual information 
    to rapidly respond to requests, incidents, and changes.
</Paragraph>
```

#### Right
Use Align="Aligns.Right" to align the paragraph text to the right.

```razor
<Paragraph Align="Aligns.Right">
    Track work across the enterprise through an open, collaborative platform. Link issues across Jira and ingest data 
    from other software development tools, so your IT support and operations teams have richer contextual information 
    to rapidly respond to requests, incidents, and changes.
</Paragraph>
```

#### Justify
Use the the Justify parameter to justify the text content.

```razor
<Paragraph Justify="true">
    Track work across the enterprise through an open, collaborative platform. Link issues across Jira and ingest data from other software development tools, so your IT support and operations teams have richer contextual information to rapidly respond to requests, incidents, and changes. Get started with an enterprise-level, profesionally designed, fully responsive, and HTML semantic set of web pages, sections and over 400+ components crafted with the utility classes from Tailwind CSS and based on the Flowbite component library.
</Paragraph>
```

### Whitespace
Configure the whitespace behaviour of inline text elements using the Whitespace parameter.

#### Normal
Use Whitespace.Normal to set the default whitespace behaviour.

```razor
<Paragraph Whitespace="Whitespace.Normal">This is some text. This is some text. This is some text. This is some text. This is some text. This is some text. This is some text. This is some text. This is some text.</Paragraph>
```

#### Nowrap
Use Whitespace.NoWrap to prevent text being added to a new line when the full width has been reached.
```razor
<Paragraph Whitespace="Whitespace.NoWrap">This is some text. This is some text. This is some text. This is some text. This is some text. This is some text. This is some text. This is some text. This is some text.</Paragraph>
```

#### Pre
Use Whitespace.Pre to preserve newlines and spaces within an element. Text will not be wrapped. Whitespace.PreWrap will do the same, but will wrap the text normally.

```razor
<Paragraph Whitespace="Whitespace.Pre">This is some text.    This is some text. This is some text. This is some text. 
    
    This is some text. This is some text. This is some text. This is some text. This is some text.</Paragraph>
```

#### Pre line

Use Whitespace.PreLine to preserve newlines but not spaces within an element. Text will be wrapped normally.

```razor
<Paragraph Whitespace="Whitespace.PreLine">This is some text.    This is some text. This is some text. This is some text. 
            
            This is some text. This is some text. This is some text. This is some text. This is some text.</Paragraph>
```