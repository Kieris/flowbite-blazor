## Blazor Paragraph - Flowbite
Use the paragraph component to create multiple blocks of text separated by blank lines and write content based on multiple layouts and styles

The paragraph element is one of the most commonly used HTML tags on a document page because it is used to write longer blocks of text separated by a blank line and can massively improve the on-page SEO of the page when used correctly. Get started with a collection of paragraph components based on multiple styles, layouts, Colors and sizes to use for your website.

### Setup
Import the Paragraph component from Flowbite.Blazor.Typography

```razor
@using Flowbite.Blazor.Typography
```

### Default Paragraph
Use this example of a paragraph element to use inside article content or a landing page.

```razor
<Paragraph Weight="FontWeights.Light" Color="text-neutral-500 dark:text-neutral-400" Class="mb-3">
    Track work across the enterprise through an open, collaborative platform. Link issues across Jira and ingest data from other software development tools, so your IT support and operations teams have richer contextual information to rapidly respond to requests, incidents, and changes.
</Paragraph>
<Paragraph Weight="FontWeights.Light" Color="text-neutral-500 dark:text-neutral-400">
    Deliver great service experiences fast - without the complexity of traditional ITSM solutions.Accelerate critical development work, eliminate toil, and deploy changes with ease, with a complete audit trail for every change.
</Paragraph>
```

### Leading Paragraph
The leading text can be used as the first paragraph inside an article content page.

```razor
<Paragraph class="mb-3 md:text-xl" Weight="FontWeights.Light" Size="TextSizes.LG" Color="text-gray-500 dark:text-gray-400">
    Deliver great service experiences fast - without the complexity of traditional ITSM solutions.Accelerate 
    critical development work and deploy.
</Paragraph>
<Paragraph Weight="FontWeights.Light" Color="text-gray-500 dark:text-gray-400">Track work across the enterprise through an open, 
    collaborative platform. Link issues across Jira and ingest data from other 
    software development tools, so your IT support and operations teams have richer contextual 
    information to rapidly respond to requests, incidents, and changes.
</Paragraph>
```


### First letter
Use the FirstUpper parameter to highlight the first letter of the paragraph, often used in e-books and PDF documents.

```razor
<Paragraph class="mb-3" FirstUpper="true" Color="text-gray-500 dark:text-gray-400">
    Track work across the enterprise through an open, collaborative platform. Link issues across Jira 
    and ingest data from other software development tools, so your IT support and operations teams have 
    richer contextual information to rapidly respond to requests, incidents, and changes.
</Paragraph>
<Paragraph Weight="FontWeights.Light" Color="text-gray-500 dark:text-gray-400">
    Deliver great service experiences fast - without the complexity of traditional ITSM solutions.Accelerate 
    critical development work, eliminate toil, and deploy changes with ease, with a complete audit trail for every change.
</Paragraph>
```


### Paragraph link
This example can be used to add a custom styled link element inside the paragraph.

```razor
<Paragraph Weight="FontWeights.Light" Color="text-gray-500 dark:text-gray-400">
    Track work across the enterprise through an open, collaborative platform. <Link href="/">Link issues across Jira</Link> 
    and ingest data from other software development tools, so your IT support and operations teams have richer contextual 
    information to rapidly respond to requests, incidents, and changes.
</Paragraph>
```

### Paragraph bolder

Use this example to highlight a piece of text inside the paragraph by using a bolder font weight.
```razor
<Paragraph Weight="FontWeights.Light" Color="text-gray-500 dark:text-gray-400">
    Track work across the enterprise through an open, collaborative platform. <strong class="font-semibold text-gray-900 
    dark:text-white"> Link issues across Jira </strong> and ingest data from other software development tools, so your 
    IT support and operations teams have richer contextual information to rapidly respond to requests, incidents, and changes.
</Paragraph>
```

### Paragraph underline
This example can be used to underline a certain part of the text inside the paragraph.

```razor
<Paragraph Weight="FontWeights.Light" Color="text-gray-500 dark:text-gray-400">
    Track work across the enterprise through an open, collaborative platform.
    <u class="underline"> Link issues across Jira </u> and ingest data from other software development tools, so your 
    IT support and operations teams have richer contextual information to rapidly respond to requests, incidents, and changes.
</Paragraph>
```

### Paragraph italic
Use this example to make the font style of the text inside the paragraph italic.

```razor
<Paragraph Weight="FontWeights.Light" Color="text-gray-500 dark:text-gray-400">
    Track work across the enterprise through an open, collaborative platform.
    <em class="font-italic"> Link issues across Jira </em> and ingest data from other software development tools, so your 
    IT support and operations teams have richer contextual information to rapidly respond to requests, incidents, and changes.
</Paragraph>
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
