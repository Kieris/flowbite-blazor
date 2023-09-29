# Changelog

All notable changes to this project will be documented in this file. See [standard-version](https://github.com/conventional-changelog/standard-version) for commit guidelines.

Added important PostBuild commands that require postcss to be installed for a successful build. Tailwind is also required. The recommended install command is 

npm install tailwindcss postcss autoprefixer postcss-cli

Changed tailwind generated file to FlowbiteBlazorTailwind.css for imports where projects may already have an app.css.


