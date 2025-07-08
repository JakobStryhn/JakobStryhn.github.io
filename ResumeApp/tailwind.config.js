/** @type {import('tailwindcss').Config} */
module.exports = {
    content: ["./../**/*.{razor,html,cshtml}"],
    theme: {
        extend: {
            width: {
                "screen": "100%"
            },
            colors: {
                "defaultext": "#2A2A29",
                "chip": {
                    "selected": "#073331",
                    "border": {
                        "default": "#073331",
                        "inactive": "#073331/50",
                    },
                },
                "tab": {
                    "selected": "#073331"
                },
                "table": {
                    "devider": "#B4CAE4"
                },
                "outline": "#B4CAE4",
                "status": {
                    "pending": "#FCCFCD",
                    "progress": "#FCEDE4",
                    "done": "#CCE2DF"
                },
                "button": {
                    "surface": "#B4CAE4",
                    "border": "#073331",
                },
                link: '#073331',
                "link-hover": '#385B5A',
                "link-visited": '#5A507C',

                required: '#0EA5E9',

                surface: '#F0F5FA',

                primary: '#073331',
                "primary-light": '#385B5A',
                secondary: '#E5E9ED',
                "secondary-light": '#EFF2F4',

                //* Add Colors 
                // "contrast-baby-blue": '#B4CAE4',
                // */
                
                error: '#F21105',
                "error-light": '#FCCFCD',
                success: '#006E62',
                "success-light": '#CCE2DF',
                warning: '#F0A678',
                "warning-light": '#FCEDE4',
            }
        },
    },
    variants: {
        extend: {
            scale: ['hover'], // Enables the scale-200 class on hover
        },
    },
    plugins: [],
}

