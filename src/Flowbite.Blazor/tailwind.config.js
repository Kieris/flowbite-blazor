/** @type {import('tailwindcss').Config} */
module.exports = {
  content: [
    './**/*.{html,js,razor,cshtml,cs,ts,md}',
    './**/*.razor.css'
  ],
  theme: {
    extend: {
      colors: {
        /** Indigo */
        primary: { "50": "#e0e8f9", "100": "#bed0f7", "200": "#98aeeb", "300": "#7b93db", "400": "#647acb", "500": "#4c63b6", "600": "#4055a8", "700": "#35469c", "800": "#2d3a8c", "900": "#19216c" },
        /** Gray */
        neutral: {
          "50": "#FAFAFA",
          "100": "#E4E4E7",
          "200": "#cfcfcf",
          "300": "#D4D4D8",
          "400": "#A1A1AA",
          "500": "#71717A",
          "600": "#52525B",
          "700": "#3F3F46",
          "800": "#27272A",
          "900": "#18181B"
        }, /** Light Blue (Vivid) */
        supporting: { "50": "#e3f8ff", "100": "#b3ecff", "200": "#81defd", "300": "#5ed0fa", "400": "#40c3f7", "500": "#2bb0ed", "600": "#1992d4", "700": "#127fbf", "800": "#0b69a3", "900": "#035388" },
        /** Teal */
        accent: { "50": "#effcf6", "100": "#c6f7e2", "200": "#8eedc7", "300": "#65d6ad", "400": "#3ebd93", "500": "#27ab83", "600": "#199473", "700": "#147d64", "800": "#0c6b58", "900": "#014d40" },
        /** Red */
        danger: { "50": "#ffeeee", "100": "#facdcd", "200": "#f29b9b", "300": "#e66a6a", "400": "#d64545", "500": "#ba2525", "600": "#a61b1b", "700": "#911111", "800": "#780a0a", "900": "#610404" },
        /** Yellow */
        warning: { "50": "#fffaeb", "100": "#fcefc7", "200": "#f8e3a3", "300": "#f9da8b", "400": "#f7d070", "500": "#e9b949", "600": "#c99a2e", "700": "#a27c1a", "800": "#7c5e10", "900": "#513c06" },
        /** Green */
        success: { "50": "#e3f9e5", "100": "#c1eac5", "200": "#a3d9a5", "300": "#7bc47f", "400": "#57ae5b", "500": "#3f9142", "600": "#2f8132", "700": "#207227", "800": "#0e5814", "900": "#05400A" }
      }
    }
  },
  plugins: [
    
  ],
  darkMode: 'class',
}
