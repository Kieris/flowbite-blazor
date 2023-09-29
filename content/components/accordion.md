
The accordion component is a collection of vertically collapsing header and body elements that can be used to show and hide information based on the Tailwind CSS utility classes and Flowbite.

A popular use case would be the "Frequently Asked Questions" section of a website or page when you can show questions and answers for each child element.


## Default accordion

#### Multiple attribute
By default the Accordion will only allow one AccordionItem to be open at a time. Set the Multiple attribute to true to allow more than one to be open at the same time. 

#### First attribute
If the First attribute is not set to true on the first AccordionItem, the top of the Accordion will not be rounded.

```razor
<Accordion Class="mt-4">
    <AccordionItem First="true">
        <Header>
            <span>What is Flowbite?</span>
        </Header>
        <Body>
        <p class="mb-2 text-gray-500 dark:text-gray-400">
            Flowbite is an open-source library of interactive components built on top of Tailwind CSS including buttons, dropdowns, modals, navbars, and more.
        </p>
        <p class="text-gray-500 dark:text-gray-400">
            Check out this guide to learn how to <a href="/docs/getting-started/introduction/" class="text-blue-600 dark:text-blue-500 hover:underline">get started</a> and start developing websites even faster with components on top of Tailwind CSS.
        </p>
        </Body>
    </AccordionItem>
    <AccordionItem>
        <Header>
            <span>Is there a Figma file available?</span>
        </Header>
        <Body>
        <p class="mb-2 text-gray-500 dark:text-gray-400">
            Flowbite is first conceptualized and designed using the Figma software so everything you see in the library has a design equivalent in our Figma file.
        </p>
        <p class="text-gray-500 dark:text-gray-400">
            Check out the <a href="{{< param homepage >}}/figma/" class="text-blue-600 dark:text-blue-500 hover:underline">Figma design system</a> based on the utility classes from Tailwind CSS and components from Flowbite.
        </p>
        </Body>
    </AccordionItem>
    <AccordionItem>
        <Header>
            <span>What are the differences between Flowbite and Tailwind UI?</span>
        </Header>
        <Body>
            <div class="p-5 border border-t-0 border-gray-200 dark:border-gray-700">
                <p class="mb-2 text-gray-500 dark:text-gray-400">The main difference is that the core components from Flowbite are open source under the MIT license, whereas Tailwind UI is a paid product. Another difference is that Flowbite relies on smaller and standalone components, whereas Tailwind UI offers sections of pages.</p>
                <p class="mb-2 text-gray-500 dark:text-gray-400">However, we actually recommend using both Flowbite, Flowbite Pro, and even Tailwind UI as there is no technical reason stopping you from using the best of two worlds.</p>
                <p class="mb-2 text-gray-500 dark:text-gray-400">Learn more about these technologies:</p>
                <ul class="pl-5 text-gray-500 list-disc dark:text-gray-400">
                <li><a href="{{< param homepage >}}/pro/" class="text-blue-600 dark:text-blue-500 hover:underline">Flowbite Pro</a></li>
                <li><a href="https://tailwindui.com/" rel="nofollow" class="text-blue-600 dark:text-blue-500 hover:underline">Tailwind UI</a></li>
                </ul>
            </div>
        </Body>
    </AccordionItem>
</Accordion>
```

## Start open and always open

#### Open attribute
Add the open attribute to the AccordionItem to default the body of the collapse to be open by default. The state of the collapse can be managed with the Open attribute, so setting it to true will also default to open.

#### OpenAlways attribute
Setting OpenAlways=true will keep the body of the collapse open indefinitely.

```razor
<Accordion Class="mt-4">
    <AccordionItem First="true" open>
        <Header>
            <span>What is Flowbite?</span>
        </Header>
        <Body>
        <p class="mb-2 text-gray-500 dark:text-gray-400">
            Flowbite is an open-source library of interactive components built on top of Tailwind CSS including buttons, dropdowns, modals, navbars, and more.
        </p>
        <p class="text-gray-500 dark:text-gray-400">
            Check out this guide to learn how to <a href="/docs/getting-started/introduction/" class="text-blue-600 dark:text-blue-500 hover:underline">get started</a> and start developing websites even faster with components on top of Tailwind CSS.
        </p>
        </Body>
    </AccordionItem>
    <AccordionItem OpenAlways="true">
        <!-- Remove arrow icons -->
        <ArrowUp></ArrowUp>
        <ArrowDown></ArrowDown>
        <Header>
            <span>Is there a Figma file available?</span>
        </Header>
        <Body>
        <p class="mb-2 text-gray-500 dark:text-gray-400">
            Flowbite is first conceptualized and designed using the Figma software so everything you see in the library has a design equivalent in our Figma file.
        </p>
        <p class="text-gray-500 dark:text-gray-400">
            Check out the <a href="{{< param homepage >}}/figma/" class="text-blue-600 dark:text-blue-500 hover:underline">Figma design system</a> based on the utility classes from Tailwind CSS and components from Flowbite.
        </p>
        </Body>
    </AccordionItem>
    <AccordionItem Open="true">
        <Header>
            <span>What are the differences between Flowbite and Tailwind UI?</span>
        </Header>
        <Body>
            <div class="p-5 border border-t-0 border-gray-200 dark:border-gray-700">
                <p class="mb-2 text-gray-500 dark:text-gray-400">The main difference is that the core components from Flowbite are open source under the MIT license, whereas Tailwind UI is a paid product. Another difference is that Flowbite relies on smaller and standalone components, whereas Tailwind UI offers sections of pages.</p>
                <p class="mb-2 text-gray-500 dark:text-gray-400">However, we actually recommend using both Flowbite, Flowbite Pro, and even Tailwind UI as there is no technical reason stopping you from using the best of two worlds.</p>
                <p class="mb-2 text-gray-500 dark:text-gray-400">Learn more about these technologies:</p>
                <ul class="pl-5 text-gray-500 list-disc dark:text-gray-400">
                <li><a href="{{< param homepage >}}/pro/" class="text-blue-600 dark:text-blue-500 hover:underline">Flowbite Pro</a></li>
                <li><a href="https://tailwindui.com/" rel="nofollow" class="text-blue-600 dark:text-blue-500 hover:underline">Tailwind UI</a></li>
                </ul>
            </div>
        </Body>
    </AccordionItem>
</Accordion>
```

## Flush accordion

Set the Flush attribute to true to remove the background color and rounded borders from the accordion component.

```razor
<Accordion Class="mt-4" Flush="true">
    <AccordionItem First="true">
        <Header>
            <span>What is Flowbite?</span>
        </Header>
        <Body>
        <p class="mb-2 text-gray-500 dark:text-gray-400">
            Flowbite is an open-source library of interactive components built on top of Tailwind CSS including buttons, dropdowns, modals, navbars, and more.
        </p>
        <p class="text-gray-500 dark:text-gray-400">
            Check out this guide to learn how to <a href="/docs/getting-started/introduction/" class="text-blue-600 dark:text-blue-500 hover:underline">get started</a> and start developing websites even faster with components on top of Tailwind CSS.
        </p>
        </Body>
    </AccordionItem>
    <AccordionItem>
        <Header>
            <span>Is there a Figma file available?</span>
        </Header>
        <Body>
        <p class="mb-2 text-gray-500 dark:text-gray-400">
            Flowbite is first conceptualized and designed using the Figma software so everything you see in the library has a design equivalent in our Figma file.
        </p>
        <p class="text-gray-500 dark:text-gray-400">
            Check out the <a href="{{< param homepage >}}/figma/" class="text-blue-600 dark:text-blue-500 hover:underline">Figma design system</a> based on the utility classes from Tailwind CSS and components from Flowbite.
        </p>
        </Body>
    </AccordionItem>
    <AccordionItem>
        <Header>
            <span>What are the differences between Flowbite and Tailwind UI?</span>
        </Header>
        <Body>
        <div class="p-5 border border-t-0 border-gray-200 dark:border-gray-700">
            <p class="mb-2 text-gray-500 dark:text-gray-400">The main difference is that the core components from Flowbite are open source under the MIT license, whereas Tailwind UI is a paid product. Another difference is that Flowbite relies on smaller and standalone components, whereas Tailwind UI offers sections of pages.</p>
            <p class="mb-2 text-gray-500 dark:text-gray-400">However, we actually recommend using both Flowbite, Flowbite Pro, and even Tailwind UI as there is no technical reason stopping you from using the best of two worlds.</p>
            <p class="mb-2 text-gray-500 dark:text-gray-400">Learn more about these technologies:</p>
            <ul class="pl-5 text-gray-500 list-disc dark:text-gray-400">
                <li><a href="{{< param homepage >}}/pro/" class="text-blue-600 dark:text-blue-500 hover:underline">Flowbite Pro</a></li>
                <li><a href="https://tailwindui.com/" rel="nofollow" class="text-blue-600 dark:text-blue-500 hover:underline">Tailwind UI</a></li>
            </ul>
        </div>
        </Body>
    </AccordionItem>
</Accordion>
```

## Arrow style

The ArrowDown and ArrowUp components can be defined to change the icon shown during each state. Adding them with no content will show nothing instead of an icon.

```razor
<Accordion Class="mt-4">
    <AccordionItem First="true">
        <ArrowDown>
            <svg xmlns="http://www.w3.org/2000/svg" class="w-3 h-3" fill="none" viewBox="0 0 10 12">
                <g fill="#2F2F38">
                    <path d="M5 12a.997.997 0 0 1-.705-.293L.305 7.711A.999.999 0 1 1 1.715 6.3L5 9.589l3.285-3.29a.997.997 0 0 1 1.69.71 1 1 0 0 1-.28.702l-3.99 3.996A.997.997 0 0 1 5 12Z"/>
                    <path d="M5 6.006a.997.997 0 0 1-.705-.293L.305 1.718A.999.999 0 1 1 1.715.305L5 3.595 8.285.305a.997.997 0 1 1 1.41 1.413l-3.99 3.995A.997.997 0 0 1 5 6.006Z"/>
                </g>
            </svg>
        </ArrowDown>
        <ArrowUp>
            <svg xmlns="http://www.w3.org/2000/svg" class="w-3 h-3" fill="none" viewBox="0 0 10 12">
                <g fill="#2F2F38">
                    <path d="M9.001 5.994a.999.999 0 0 1-.706-.293l-3.289-3.29-3.289 3.29A.999.999 0 1 1 .305 4.288L4.3.292a.999.999 0 0 1 1.412 0l3.996 3.996A1 1 0 0 1 9 5.994Z"/>
                    <path d="M9.001 11.988a.998.998 0 0 1-.706-.293l-3.289-3.29-3.289 3.29a1 1 0 1 1-1.412-1.413L4.3 6.286a.999.999 0 0 1 1.412 0l3.996 3.996A.999.999 0 0 1 9 11.988Z"/>
                </g>
            </svg>
        </ArrowUp>
        <Header>
            <span>Changing the style for the arrows to chevron double</span>
        </Header>
        <Body>
        <p class="mb-2 text-gray-500 dark:text-gray-400">
            Flowbite is an open-source library of interactive components built on top of Tailwind CSS including buttons, dropdowns, modals, navbars, and more.
        </p>
        <p class="text-gray-500 dark:text-gray-400">
            Check out this guide to learn how to <a href="/docs/getting-started/introduction/" class="text-blue-600 dark:text-blue-500 hover:underline">get started</a> and start developing websites even faster with components on top of Tailwind CSS.
        </p>
        </Body>
    </AccordionItem>
    <AccordionItem>
        <ArrowUp>
            <svg class="w-4 h-4 shrink-0 -mr-0.5" aria-hidden="true" xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 20 20">
                <path stroke="currentColor" stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M7.529 7.988a2.502 2.502 0 0 1 5 .191A2.441 2.441 0 0 1 10 10.582V12m-.01 3.008H10M19 10a9 9 0 1 1-18 0 9 9 0 0 1 18 0Z"/>
            </svg>
        </ArrowUp>
        <ArrowDown>
            <svg class="w-4 h-4 shrink-0 -mr-0.5" aria-hidden="true" xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 20 20">
                <path stroke="currentColor" stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M7.529 7.988a2.502 2.502 0 0 1 5 .191A2.441 2.441 0 0 1 10 10.582V12m-.01 3.008H10M19 10a9 9 0 1 1-18 0 9 9 0 0 1 18 0Z"/>
            </svg>
        </ArrowDown>
        <Header>
            <span>With the same icon for open or closed</span>
        </Header>
        <Body>
        <p class="mb-2 text-gray-500 dark:text-gray-400">
            Flowbite is first conceptualized and designed using the Figma software so everything you see in the library has a design equivalent in our Figma file.
        </p>
        <p class="text-gray-500 dark:text-gray-400">
            Check out the <a href="{{< param homepage >}}/figma/" class="text-blue-600 dark:text-blue-500 hover:underline">Figma design system</a> based on the utility classes from Tailwind CSS and components from Flowbite.
        </p>
        </Body>
    </AccordionItem>
    <AccordionItem>
        <ArrowUp></ArrowUp>
        <ArrowDown></ArrowDown>
        <Header>
            <span>Without an arrow</span>
        </Header>
        <Body>
        <div class="p-5 border border-t-0 border-gray-200 dark:border-gray-700">
            <p class="mb-2 text-gray-500 dark:text-gray-400">The main difference is that the core components from Flowbite are open source under the MIT license, whereas Tailwind UI is a paid product. Another difference is that Flowbite relies on smaller and standalone components, whereas Tailwind UI offers sections of pages.</p>
            <p class="mb-2 text-gray-500 dark:text-gray-400">However, we actually recommend using both Flowbite, Flowbite Pro, and even Tailwind UI as there is no technical reason stopping you from using the best of two worlds.</p>
            <p class="mb-2 text-gray-500 dark:text-gray-400">Learn more about these technologies:</p>
            <ul class="pl-5 text-gray-500 list-disc dark:text-gray-400">
                <li><a href="{{< param homepage >}}/pro/" class="text-blue-600 dark:text-blue-500 hover:underline">Flowbite Pro</a></li>
                <li><a href="https://tailwindui.com/" rel="nofollow" class="text-blue-600 dark:text-blue-500 hover:underline">Tailwind UI</a></li>
            </ul>
        </div>
        </Body>
    </AccordionItem>
</Accordion>
```

## Nesting accordions

Accordions can be nested. All of the mentioned options are supported.

```razor
<Accordion Class="mt-4">
    <AccordionItem First="true">
        <Header>
            <span>Nested accordion</span>
        </Header>
        <Body>
            <Accordion Class="mt-4">
                <AccordionItem First="true">
                    <Header>
                        <span>What is Flowbite?</span>
                    </Header>
                    <Body>
                    <p class="mb-2 text-gray-500 dark:text-gray-400">
                        Flowbite is an open-source library of interactive components built on top of Tailwind CSS including buttons, dropdowns, modals, navbars, and more.
                    </p>
                    <p class="text-gray-500 dark:text-gray-400">
                        Check out this guide to learn how to <a href="/docs/getting-started/introduction/" class="text-blue-600 dark:text-blue-500 hover:underline">get started</a> and start developing websites even faster with components on top of Tailwind CSS.
                    </p>
                    </Body>
                </AccordionItem>
                <AccordionItem>
                    <Header>
                        <span>Is there a Figma file available?</span>
                    </Header>
                    <Body>
                    <p class="mb-2 text-gray-500 dark:text-gray-400">
                        Flowbite is first conceptualized and designed using the Figma software so everything you see in the library has a design equivalent in our Figma file.
                    </p>
                    <p class="text-gray-500 dark:text-gray-400">
                        Check out the <a href="{{< param homepage >}}/figma/" class="text-blue-600 dark:text-blue-500 hover:underline">Figma design system</a> based on the utility classes from Tailwind CSS and components from Flowbite.
                    </p>
                    </Body>
                </AccordionItem>
            </Accordion>
        </Body>
    </AccordionItem>
    <AccordionItem>
        <Header>
            <span>Is there a Figma file available?</span>
        </Header>
        <Body>
        <p class="mb-2 text-gray-500 dark:text-gray-400">
            Flowbite is first conceptualized and designed using the Figma software so everything you see in the library has a design equivalent in our Figma file.
        </p>
        <p class="text-gray-500 dark:text-gray-400">
            Check out the <a href="{{< param homepage >}}/figma/" class="text-blue-600 dark:text-blue-500 hover:underline">Figma design system</a> based on the utility classes from Tailwind CSS and components from Flowbite.
        </p>
        </Body>
    </AccordionItem>
    <AccordionItem>
        <Header>
            <span>What are the differences between Flowbite and Tailwind UI?</span>
        </Header>
        <Body>
            <div class="p-5 border border-t-0 border-gray-200 dark:border-gray-700">
                <p class="mb-2 text-gray-500 dark:text-gray-400">The main difference is that the core components from Flowbite are open source under the MIT license, whereas Tailwind UI is a paid product. Another difference is that Flowbite relies on smaller and standalone components, whereas Tailwind UI offers sections of pages.</p>
                <p class="mb-2 text-gray-500 dark:text-gray-400">However, we actually recommend using both Flowbite, Flowbite Pro, and even Tailwind UI as there is no technical reason stopping you from using the best of two worlds.</p>
                <p class="mb-2 text-gray-500 dark:text-gray-400">Learn more about these technologies:</p>
                <ul class="pl-5 text-gray-500 list-disc dark:text-gray-400">
                <li><a href="{{< param homepage >}}/pro/" class="text-blue-600 dark:text-blue-500 hover:underline">Flowbite Pro</a></li>
                <li><a href="https://tailwindui.com/" rel="nofollow" class="text-blue-600 dark:text-blue-500 hover:underline">Tailwind UI</a></li>
                </ul>
            </div>
        </Body>
    </AccordionItem>
</Accordion>
```

## Open and close all items

Adding a reference for the Accordion allows access to certain basic functions including opening and closing all items.

```razor
<div class="flex space-x-2">
    <button @onclick="OpenItems" class="text-white bg-blue-700 hover:bg-blue-800 focus:ring-4 focus:ring-blue-300 font-medium rounded-lg text-sm px-5 py-2.5 mr-2 mb-2">Open All</button>
    <button @onclick="CloseItems" class="text-white bg-blue-700 hover:bg-blue-800 focus:ring-4 focus:ring-blue-300 font-medium rounded-lg text-sm px-5 py-2.5 mr-2 mb-2">Close All</button>
</div>

<Accordion @ref="@_acc" Class="mt-4">
    <AccordionItem First="true">
        <Header>
            <span>What is Flowbite?</span>
        </Header>
        <Body>
        <p class="mb-2 text-gray-500 dark:text-gray-400">
            Flowbite is an open-source library of interactive components built on top of Tailwind CSS including buttons, dropdowns, modals, navbars, and more.
        </p>
        <p class="text-gray-500 dark:text-gray-400">
            Check out this guide to learn how to <a href="/docs/getting-started/introduction/" class="text-blue-600 dark:text-blue-500 hover:underline">get started</a> and start developing websites even faster with components on top of Tailwind CSS.
        </p>
        </Body>
    </AccordionItem>
    <AccordionItem>
        <Header>
            <span>Is there a Figma file available?</span>
        </Header>
        <Body>
        <p class="mb-2 text-gray-500 dark:text-gray-400">
            Flowbite is first conceptualized and designed using the Figma software so everything you see in the library has a design equivalent in our Figma file.
        </p>
        <p class="text-gray-500 dark:text-gray-400">
            Check out the <a href="{{< param homepage >}}/figma/" class="text-blue-600 dark:text-blue-500 hover:underline">Figma design system</a> based on the utility classes from Tailwind CSS and components from Flowbite.
        </p>
        </Body>
    </AccordionItem>
    <AccordionItem>
        <Header>
            <span>What are the differences between Flowbite and Tailwind UI?</span>
        </Header>
        <Body>
        <div class="p-5 border border-t-0 border-gray-200 dark:border-gray-700">
            <p class="mb-2 text-gray-500 dark:text-gray-400">The main difference is that the core components from Flowbite are open source under the MIT license, whereas Tailwind UI is a paid product. Another difference is that Flowbite relies on smaller and standalone components, whereas Tailwind UI offers sections of pages.</p>
            <p class="mb-2 text-gray-500 dark:text-gray-400">However, we actually recommend using both Flowbite, Flowbite Pro, and even Tailwind UI as there is no technical reason stopping you from using the best of two worlds.</p>
            <p class="mb-2 text-gray-500 dark:text-gray-400">Learn more about these technologies:</p>
            <ul class="pl-5 text-gray-500 list-disc dark:text-gray-400">
                <li><a href="{{< param homepage >}}/pro/" class="text-blue-600 dark:text-blue-500 hover:underline">Flowbite Pro</a></li>
                <li><a href="https://tailwindui.com/" rel="nofollow" class="text-blue-600 dark:text-blue-500 hover:underline">Tailwind UI</a></li>
            </ul>
        </div>
        </Body>
    </AccordionItem>
</Accordion>

@code {
    private Accordion _acc = new();
    
    private void CloseItems()
    {
        _acc.CloseAll();    
    }

    private void OpenItems()
    {
        _acc.OpenAll();
    }
}
```

