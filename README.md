# .NET Core xUnit Test Sample Project
This is a xUnit test project running on .NET Core

Support .NET Core 2.1+

# Package Dependencies
Intalled via NuGet:

1. [NunitXml.TestLogger](https://github.com/spekt/nunit.testlogger) to generate [NUnit 3 format](https://github.com/nunit/docs/wiki/Test-Result-XML-Format)

2. [Selenium.WebDriver](https://www.nuget.org/packages/Selenium.WebDriver/)

3. [Selenium.Support](https://www.nuget.org/packages/Selenium.Support/)

4. [Selenium.WebDriver.ChromeDriver (Win32, macOS, and Linux64)](https://www.nuget.org/packages/Selenium.WebDriver.ChromeDriver/)

 
# Run tests on Command Prompt or Terminal
Run tests with **dotnet test** command

1. Run all tests (classes and methods) in the project and generate XML results
``` 
dotnet test --logger:"nunit;LogFilePath=../test-results/results.xml"
```
2. Run specific test class in the project and generate NUnit XML result
```
dotnet test --filter "DisplayName~BrowserTest" --logger:"nunit;LogFilePath=../test-results/results.xml"
```
3. Run only one test method in the test project, e.g. xUnitSample.UnitTest.PassingTest, and generate NUnit XML result
```
dotnet test --filter "DisplayName=xUnitSample.UnitTest.PassingTest" --logger:"nunit;LogFilePath=../test-results/results.xml"
```
4. Run all tests except specific method in the test project, and generate NUnit XML result
```
dotnet test --filter "FullyQualifiedName!=xUnitSample.UnitTest.FailingTest" --logger:"nunit;LogFilePath=../test-results/results.xml"
```

Refer to [dotnet test documentation](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-test) for more options regarding **dotnet test** command
