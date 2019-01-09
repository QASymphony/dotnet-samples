# .NET Core xUnit Test Sample Project
This is a xUnit test project running on .NET Core
Support .NET Core 2.1+

# Package Dependencies
Intalled via NuGet:

1. [NunitXml.TestLogger](https://github.com/spekt/nunit.testlogger) to generate [NUnit 3 format](https://github.com/nunit/docs/wiki/Test-Result-XML-Format)

2. [Selenium.WebDriver](https://www.nuget.org/packages/Selenium.WebDriver/)

3. [Selenium.Support](https://www.nuget.org/packages/Selenium.Support/)

4. [Selenium.WebDriver.ChromeDriver (Win32, macOS, and Linux64)](https://www.nuget.org/packages/Selenium.WebDriver.ChromeDriver/)

 
# Run test on Command Prompt or Terminal
1. Run all tests in the project and generate XML results
dotnet test --logger:"nunit;LogFilePath=../test-results/results.xml"
2. Run specific test method in the test project, e.g. Test1, and generate XML result
dotnet test --filter "FullyQualifiedName=xUnitSample.UnitTest1.Test1"  --logger:"nunit;LogFilePath=../test-result.xml"

[dotnet test command reference](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-test)
