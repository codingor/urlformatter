# urlformatter

The goal of this exercise is to design a REST API that takes a URL and return a shorter version. (e.g. takes “https://www.finning.com/en_CA/company/about/finning-digital.html” and shortens it to “finning.co/g6a0dsa”)

Stack
-----

**ASP.NET Core**

The current version requires .Net Core 3.1 SDK to build and run [ASP.NET Core](https://dotnet.microsoft.com/download).

**Libraries**

- I primarily use the [MediatR](https://github.com/jbogard/MediatR) for request and response as it has a set of nicely implemented functions that dispatches to a single handler for the controller.

- Use the [Moq](https://github.com/moq/moq) for the unit tests mockup.

**xUnit**

This project uses xUnit for running unit tests.
