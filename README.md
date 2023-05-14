<div>
  <img src="https://img.shields.io/badge/version-0.1.0-%236C63FF" />
</div>

<br/>

<div>
  <img src="https://img.shields.io/badge/Docker-%230db7ed.svg?style=flat&logo=docker&logoColor=white" />
  <img src="https://img.shields.io/badge/nx-143055?style=flat&logo=nx&logoColor=white" />
  <img src="https://img.shields.io/badge/Angular-DD0031?style=flat&logo=angular&logoColor=white" />
  <img src="https://img.shields.io/badge/.NET-512BD4?style=flat&logo=dotnet&logoColor=white" />
  <img src="https://img.shields.io/badge/MS%20SQL%20Sever-00000F?style=flat&logo=microsoft%20sql%20server&logoColor=white" />
  <img src="https://img.shields.io/badge/-Swagger-%23Clojure?style=flat&logo=swagger&logoColor=white" />
  <img src="https://img.shields.io/badge/Postman-FF6C37?style=flat&logo=postman&logoColor=white" />
</div>

# Planify

Note: This project is currently on hold.

An app that allows users to plan their personal development process.

Features:
- SMART Goals setting
- Task management
- Calendar schedule
- Skills management
<br/>

## Installation

This project was generated with [NX](https://nx.dev/) version 15.0.4.

To run the development server locally you will need to install the following tools:
- [npm (NodeJs)](https://nodejs.org/en/download/)
- [Angular CLI](https://github.com/angular/angular-cli)
- [NX](https://nx.dev/)

### Node Package Manager (npm)

Check if the installation was successful:
```bash
npm --version
```

Your output should look something like this:
```bash
8.11.0
```

### NX

To install nx run the following command in the terminal:
```bash
nx --version
```

Your output should look something like this:
```bash
15.0.4
```

### Angular CLI

To install angular cli run the following command in the terminal:
```bash
ng --version
```

Your output should look something like this:
```bash

     _                      _                 ____ _     ___
    / \   _ __   __ _ _   _| | __ _ _ __     / ___| |   |_ _|
   / △ \ | '_ \ / _` | | | | |/ _` | '__|   | |   | |    | |
  / ___ \| | | | (_| | |_| | | (_| | |      | |___| |___ | |
 /_/   \_\_| |_|\__, |\__,_|_|\__,_|_|       \____|_____|___|
                |___/


Angular CLI: 14.2.7
Node: 16.5.1
Package Manager: npm 6.14.14
OS: win32 x64
.
.
.
```

### Development server

To start development server, you need to clone the repository and install dependencies
```bash
git clone https://github.com/mirzaceligija/Planify.git
cd planify
npm i
npm start
```

Navigate to `http://localhost:4200/` for the customer portal and `http://localhost:4201/` for the admin portal. The app will automatically reload if you change any of the source files.
If you get any errors, make sure that nothing is running on the ports 4200 and 4201.


### Build

The build artifacts will be stored in the `dist/` directory. To build the project run:

```bash
npm run build
```

### Build:Production

The build artifacts will be stored in the `dist/` directory. To build the project run:

```bash
npm run build:prod
```

### Running unit tests

To execute the unit test run:

```bash
npm run test
```


### Clean

To remove generated files in the `dist/` directory run:

```bash
npm run clean
```
