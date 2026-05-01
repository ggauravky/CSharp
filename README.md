```
   ____ _                  _                          _          _
  / ___| |__   _ __ ___  __| |  _ __ ___   __ _  _ __ | |__   ___ | |_
 | |   | '_ \ | '__/ _ \/ _` | | '_ ` _ \ / _` || '__|| '_ \ / _ \| __|
 | |___| | | || | |  __/ (_| | | | | | | | (_| || |   | | | |  __/| |_
  \____|_| |_||_|  \___|\__,_| |_| |_| |_|\__,_||_|   |_| |_|\___| \__|
```
Place your logo or banner above the title for the best visual impact.

# C# Learning Lab 📘
Hands-on .NET Framework console projects for mastering C# fundamentals and core .NET topics.

[![Build](https://img.shields.io/badge/build-not%20configured-lightgrey)](https://github.com/ggauravky/CSharp/actions)
[![License](https://img.shields.io/badge/license-Unspecified-lightgrey)](#license)
[![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.7.2-512BD4?logo=dotnet)](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net472)
[![NuGet](https://img.shields.io/badge/NuGet-n%2Fa-004880?logo=nuget)](https://www.nuget.org/)

## Table of Contents
- [About the Project](#about-the-project)
- [Tech Stack](#tech-stack)
- [Getting Started](#getting-started)
- [Usage](#usage)
- [Project Structure](#project-structure)
- [Configuration](#configuration)
- [Contributing](#contributing)
- [Roadmap](#roadmap)
- [License](#license)
- [Acknowledgements](#acknowledgements)

## About the Project
This repository is a curated collection of standalone console apps organized by topic. It is designed for learning, revising, and demonstrating core C# and .NET Framework concepts through concise, runnable examples.

**Key features**
- Topic-by-topic progression from basics to advanced concepts
- Self-contained projects you can run independently
- Coverage across fundamentals, OOP, collections, IO, threading, and networking
- Friendly for quick experimentation and study

## Tech Stack
| Layer | Details |
| --- | --- |
| Language | C# |
| Runtime | .NET Framework 4.7.2 |
| Project Type | Console applications (classic .csproj) |
| Tooling | Visual Studio / MSBuild |
| Dependencies | No external NuGet packages detected |

## Getting Started
### Prerequisites
- Windows 10 or later
- Visual Studio 2019 or 2022 (or Build Tools with MSBuild)
- .NET Framework 4.7.2 Developer Pack

### Installation
1. Clone the repository.
2. Choose a topic folder (for example, 001 to 016, Array, Searching, MoreAboutVariable).
3. Open the solution or project in Visual Studio and build.

### Run
- Visual Studio: Press F5 or Ctrl+F5.
- CLI (PowerShell example):

```powershell
msbuild "Array\ArrayList\ArrayList\ArrayList.csproj" /p:Configuration=Debug
.\Array\ArrayList\ArrayList\bin\Debug\ArrayList.exe
```

## Usage
### Example snippet
```csharp
Console.WriteLine("Hello, .NET!");
int number = 10;
double price = 99.99;
char grade = 'A';
string name = "Gaurav";
bool isActive = true;

Console.WriteLine("Number: " + number);
Console.WriteLine("Price: " + price);
Console.WriteLine("Grade: " + grade);
Console.WriteLine("Name: " + name);
Console.WriteLine("Active: " + isActive);
```

## Project Structure
- Numbered folders (001 to 016) contain topic-based lessons and practice apps.
- Additional practice areas include Array, Searching, and MoreAboutVariable.
- Each topic includes a runnable entry point and configuration file, such as
  [Array/ArrayList/ArrayList/Program.cs](Array/ArrayList/ArrayList/Program.cs) and
  [Array/ArrayList/ArrayList/App.config](Array/ArrayList/ArrayList/App.config).

## Configuration
Project settings and runtime configuration live in each app configuration file, for example
[Array/ArrayList/ArrayList/App.config](Array/ArrayList/ArrayList/App.config). Update the supported runtime there if you target a different .NET Framework version.

## Contributing
1. Fork the repository.
2. Create a feature branch.
3. Add or improve examples with clear, runnable code.
4. Run the project to validate behavior.
5. Open a pull request with a concise description and screenshots or output where helpful.

## Roadmap
- Add per-topic mini guides and exercises
- Add CI builds to validate compilation
- Migrate projects to SDK-style formats where appropriate
- Introduce unit tests for selected topics

## License
No license file is currently present. Add a license to clarify usage and contributions.

## Acknowledgements
- Microsoft C# documentation and .NET Framework docs
- The broader C# and .NET community
