UniSharp Boilerplate
=============

UniSharp is a boilerplate for Unity and C# Server (.NET Core) app.
Good start point to develop a multi-platform online game.

**Uni** means *Unity* and *United*.

This project heavily depends on the [MagicOnion](https://github.com/Cysharp/MagicOnion).

Default target platform
---------

- iOS
- Android (6.0+ / arm64)
- WebGL

Usage
-----

Copy this repository. 
(download zip from GitHub or clone and do `git archive`)

It is recommended to replace all `UniSharp` word to another unique name for your app (e.g. `UniSharp.Foo` -> `MyCoolApp.Foo`)

Open `UniSharp.Unity` folder from Unity and select `Assets/Open C# Project` from menu.

Prerequisites
------

- Unity 2019.3.x
- .NET Core 3.1.x SDK

Solution structure
-------

### etc

Setting files which be used while development.

### src

All production codes.

- **Server** - server codes
- **Shared** - shared interfaces, messages, constants and settings
- **Unity** - Unity codes and assets
- **Unity External** - 3rd party projects (do not touch codes inside this folder directly)
- **Unity Framework** - common library of the UniSharp

Unity*** folders are empty on server solution but do not delete.
They will be used by [SlnMerge](https://github.com/Cysharp/SlnMerge) when opening client solution.

### test

Test codes.

Server Solution (UniSharp.Server/UniSharp.Server.sln)
--------

This solution is usually only used to be included by Unity client's solution using SlnMerge.

Although, server side developers can use this solution alone.

