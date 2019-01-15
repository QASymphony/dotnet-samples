# .NET Test Samples
This is sample .NET solution for integrating with [Universal Agent](https://support.qasymphony.com/hc/en-us/articles/360004704172-Universal-Agent-Overview). This solution contains:

1. Test projects that support .NET Core 2.1+: xUnitSample, MSTestSample, NUnitSample
2. Test project that support .NET 4.5 (Windows only): UnitTestSample

Follow these instructions for integrating with [Universal Agent](https://support.qasymphony.com/hc/en-us/articles/360004704172-Universal-Agent-Overview)
1. [Integrate NUnit with Universal Agent](https://support.qasymphony.com/hc/en-us/articles/360021796232)
2. [Integrate MSTest with Universal Agent](https://support.qasymphony.com/hc/en-us/articles/360021798132)
3. [Integrate xUnit.net with Universal Agent](https://support.qasymphony.com/hc/en-us/articles/360021750432)


# Package Dependencies
Intalled via NuGet:

1. [NunitXml.TestLogger](https://github.com/spekt/nunit.testlogger) to generate [NUnit 3 format](https://github.com/nunit/docs/wiki/Test-Result-XML-Format)

2. [Selenium.WebDriver](https://www.nuget.org/packages/Selenium.WebDriver/)

3. [Selenium.Support](https://www.nuget.org/packages/Selenium.Support/)

4. [Selenium.WebDriver.ChromeDriver (Win32, macOS, and Linux64)](https://www.nuget.org/packages/Selenium.WebDriver.ChromeDriver/)

# .NET Core 2.1+: xUnitSample, MSTestSample, NUnitSample project

## Run tests on Command Prompt or Terminal
Open Terminal (or Command Prompt on Windows). 

Navigate to the **dotnet-samples** directory.

Publish the test project, e.g. xUnitSample
```
dotnet publish DotnetCore/xUnitSample/xUnitSample.csproj
```
This command will publish the project to **dotnet-samples/DotnetCore/xUnitSample/bin/Debug/netcoreapp2.1/publish** directory

Now, run tests using any of these **dotnet vstest** command that fits your need. Below are some examples:

1. Run all tests (classes and methods) in the test project and generate NUnit XML results
``` 
dotnet vstest DotnetCore/xUnitSample/bin/Debug/netcoreapp2.1/publish/xUnitSample.dll --logger:"nunit;LogFilePath=./test-results/regressiontest-results.xml"
```
2. Run specific test class, e.g. BrowserTest, in the test project and generate NUnit XML result
```
dotnet vstest DotnetCore/xUnitSample/bin/Debug/netcoreapp2.1/publish/xUnitSample.dll /Tests:BrowserTest --logger:"nunit;LogFilePath=./test-results/browsertest-results.xml"
```

or UnitTest class only

```
dotnet vstest DotnetCore/xUnitSample/bin/Debug/netcoreapp2.1/publish/xUnitSample.dll /Tests:UnitTest --logger:"nunit;LogFilePath=./test-results/unittest-results.xml"
```
3. Run only one test method of a test class in the test project, e.g. xUnitSample.UnitTest.FailingTest, and generate NUnit XML result
```
dotnet vstest DotnetCore/xUnitSample/bin/Debug/netcoreapp2.1/publish/xUnitSample.dll /Tests:xUnitSample.UnitTest.FailingTest --logger:"nunit;LogFilePath=./test-results/xUnitSample.UnitTest.FailingTest-results.xml"

```
The command line to run tests for MSTestSample, NUnitSample project similar to xUnitSample project.

Refer to [dotnet vstest documentation](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-vstest?tabs=netcore21) for more options regarding **dotnet vstest** command

# .NET 4.5+: UnitTestSample project (Windows only)

## Run tests on Command Prompt
Open Command Prompt on Windows. 

Navigate to the **dotnet-samples** directory.

Build project on Visual Studio to generate UnitTestSample.dll file on bin\Debug folder.

Open Developer Command Prompt and type ```where vstest.console.exe``` to find the location of vstest.console.exe, e.g "C:\Program Files (x86)\Microsoft Visual Studio\2017\Community\Common7\IDE\CommonExtensions\Microsoft\TestWindow".

Set the path of vstest.console.exe to system environment variables.

Now, run tests using any of these **vstest.console.exe** command that fits your need.
Below are some examples:

1. Run all tests (classes and methods) in the test project and generate NUnit XML results
``` 
vstest.console.exe Dotnet\UnitTestSample\bin\Debug\UnitTestSample.dll --logger:"nunit;LogFilePath=./test-results/regressiontest-results.xml"
```
2. Run specific test class, e.g. BrowserTest, in the test project and generate NUnit XML result
```
vstest.console.exe Dotnet\UnitTestSample\bin\Debug\UnitTestSample.dll /Tests:ArithmeticCalculatorTest --logger:"nunit;LogFilePath=./test-results/arithmetic-calculator-test-results.xml"
```

3. Run only one test method of a test class in the test project, e.g. xUnitSample.UnitTest.FailingTest, and generate NUnit XML result
```
vstest.console.exe Dotnet\UnitTestSample\bin\Debug\UnitTestSample.dll /Tests:ArithmeticCalculatorTest.PassingAdditionTest --logger:"nunit;LogFilePath=./test-results/test-result.xml"

```

Refer to [vstest console documentation](https://docs.microsoft.com/en-us/visualstudio/test/vstest-console-options?view=vs-2017) for more options regarding **vstest.console.exe** command
