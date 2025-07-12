module.exports = {
    content: ["./**/*.{razor,html,cshtml}"],
    theme: {
        colors: {
            //* Add Colors 
            // "contrast-baby-blue": '#B4CAE4',
            // */

        },
        extend: {
            width: {
                "screen": "100%"
            },
            backgroundImage: {
                'checkerboard-pattern': "url('/images/Checkerboard.png')"
            },
            keyframes: {
                'fade-in-down': {
                    '0%': { opacity: '0', transform: 'translateY(-20px)' },
                    '100%': { opacity: '1', transform: 'translateY(0)' },
                },
                'fade-in-up': {
                    '0%': { opacity: '0', transform: 'translateY(20px)' },
                    '100%': { opacity: '1', transform: 'translateY(0)' },
                },
                'fade-in': {
                    '0%': { opacity: '0' },
                    '100%': { opacity: '1' },
                },
                'diagonal-move': {
                    '0%': { backgroundPosition: '0% 0%' },
                    '100%': { backgroundPosition: '100% 100%' },
                }
            },
            animation: {
                'fade-in-down': 'fade-in-down 1s ease-out forwards',
                'fade-in-up': 'fade-in-up 1s ease-out forwards',
                'fade-in': 'fade-in 1.2s ease-out forwards',
                'diagonal-move': 'diagonal-move 10s linear infinite'
            },
            animationDelay: {
                100: '100ms',
                200: '200ms',
                300: '300ms',
                400: '400ms',
                500: '500ms',
                600: '600ms',
                700: '700ms',
                800: '800ms',
                900: '900ms',
                1000: '1000ms',
            },
        },
    },
    variants: {

    },
    plugins: [
        require('tailwindcss-animation-delay'),
    ],
}

