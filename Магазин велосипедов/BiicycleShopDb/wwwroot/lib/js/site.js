// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


const animitems = document.querySelectorAll('._anim-items')

if (animitems.length > 0) {
    window.addEventListener('scroll', animOnScroll)
    function animOnScroll() {
        for (let i = 0; i < animitems.length; i++) {
            const animItem = animitems[i]
            const animItemHeight = animItem.offsetHeight
            const animItemOfset = offset(animItem).top
            const animStart = 4

            let animItemPoint = window.innerHeight - animItemHeight / animStart

            if (animItemHeight > window.innerHeight) { /* в этом моменте наш обект получает клас при котором будет анемироваться*/
                animItemPoint = window.innerHeight - window.innerHeight / animStart
            }

            if ((pageYOffset > animItemOfset - animItemPoint) && pageYOffset < (animItemOfset + animItemHeight)) {
                animItem.classList.add('_active')
            }
            else {
                if (!animItem.classList.contains('anim-no-height')) {
                    animItem.classList.remove('_active')
                }
            }

        }
    }
    function offset(el) {
        const rect = el.getBoundingClientRect(),
            scrollLeft = window.pageXOffset || document.documentElement.scrollLeft,
            scrollTop = window.pageYOffset || document.documentElement.scrollTop;
        return { top: rect.top + scrollTop, left: rect.left + scrollLeft }
    }

    setTimeout(() => { animOnScroll(); }, 500)
    
}

const visibletext = document.querySelectorAll('.__visible__text')

function Start() {
    for (let i = 0; i < visibletext.length; i++) {
        let text = visibletext[i];
        text.classList.add('_none')
    }
}

setTimeout(() => {
    Start()
}, 3000);