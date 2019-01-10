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
Open Terminal (or Command Prompt on Windows). 

Navigate to the **dotnetcore-xunit-sample** directory.

Publish the test project:
```
dotnet publish xUnitSample/xUnitSample.csproj
```
This command will publish the project to **dotnetcore-xunit-sample/xUnitSample/bin/Debug/netcoreapp2.1/publish** directory

Now, run tests using any of these **dotnet vstest** command that fits your need. Below are some examples:

1. Run all tests (classes and methods) in the test project and generate NUnit XML results
``` 
dotnet vstest xUnitSample/bin/Debug/netcoreapp2.1/publish/xUnitSample.dll --logger:"nunit;LogFilePath=./test-results/regressiontest-results.xml"
```
2. Run specific test class, e.g. BrowserTest, in the test project and generate NUnit XML result
```
dotnet vstest xUnitSample/bin/Debug/netcoreapp2.1/publish/xUnitSample.dll /Tests:BrowserTest --logger:"nunit;LogFilePath=./test-results/browsertest-results.xml"
```

or UnitTest class only

```
dotnet vstest xUnitSample/bin/Debug/netcoreapp2.1/publish/xUnitSample.dll /Tests:UnitTest --logger:"nunit;LogFilePath=./test-results/unittest-results.xml"
```
3. Run only one test method of a test class in the test project, e.g. xUnitSample.UnitTest.FailingTest, and generate NUnit XML result
```
dotnet vstest xUnitSample/bin/Debug/netcoreapp2.1/publish/xUnitSample.dll /Tests:xUnitSample.UnitTest.FailingTest --logger:"nunit;LogFilePath=./test-results/xUnitSample.UnitTest.FailingTest-results.xml"

```

Refer to [dotnet vstest documentation](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-vstest?tabs=netcore21) for more options regarding **dotnet vstest** command
