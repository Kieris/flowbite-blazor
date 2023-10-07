
let timeoutId;
export function addPopper(popcorn, ttip, place, trigger, delay) {
    let popperInstance = Popper.createPopper(popcorn, ttip, {
            modifiers: [
                {
                    name: 'offset',
                    options: {
                        offset: [0, 0]
                    }
                },
                {
                    name: "flip", //flips popper with allowed placements
                    options: {
                        allowedAutoPlacements: ["top", "bottom"],
                        rootBoundary: "viewport"
                    }
                }
            ],
            placement: place,
            triggerType: "hover"
        });
    
    let ttiphover = false;
    function show() {
        timeoutId = setTimeout(() => {
            ttip.setAttribute('data-show', '');

            // Enable the event listeners
            popperInstance.setOptions((options) => ({
                ...options,
                modifiers: [
                    ...options.modifiers,
                    { name: 'eventListeners', enabled: true },
                ],
            }));
            popperInstance.update();
        }, delay);
    }

    function hide() {
        clearTimeout(timeoutId);
        if(!ttiphover) {
            ttip.removeAttribute('data-show');

            // Disable the event listeners
            popperInstance.setOptions((options) => ({
                ...options,
                modifiers: [
                    ...options.modifiers,
                    { name: 'eventListeners', enabled: false },
                ],
            }));
        }

    }

    const showEvents = ['mouseenter', 'focus'];
    const hideEvents = ['mouseleave', 'blur'];

    showEvents.forEach((event) => {
        popcorn.addEventListener(event, show);
    });

    hideEvents.forEach((event) => {
        popcorn.addEventListener(event, hide);
    });
    
    ttip.addEventListener("mouseenter", function(event) {
        ttiphover = true;
    });

    ttip.addEventListener("mouseleave", function(event) {
        ttiphover = false;
        hide();
    });
};

//create popper instance
function createInstance(popperButton, popperPopup, place) {
    const popperInstance = Popper.createPopper(popperButton, popperPopup, {
        placement: place, //preferred placement of popper
        modifiers: [
            {
                name: "offset", //offsets popper from the reference/button
                options: {
                    offset: [0, 8]
                }
            },
            {
                name: "flip", //flips popper with allowed placements
                options: {
                    allowedAutoPlacements: ["top", "bottom"],
                    rootBoundary: "viewport"
                }
            }
        ]
    });

    return popperInstance;
}

//destroy popper instance
function destroyInstance(popperInstance) {
    if (popperInstance) {
        popperInstance.destroy();
        popperInstance = null;
    }
}

//show and create popper
export function showPopper(popperButton, popperPopup, place) {
    popperPopup.setAttribute("data-show", "");
    return createInstance(popperButton, popperPopup, place);
}

//hide and destroy popper instance
export function hidePopper(popperPopup, popperInstance) {
    popperPopup.removeAttribute("data-show");
    destroyInstance(popperInstance);
}