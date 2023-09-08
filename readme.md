# Getting Started Instructions - dotnet

1. you will need dotnet **SDK** installed (tested with dotNET 7) 
1. having cloned the repository from GitHub, to execute the one test, run `dotnet test` from the project root
   1. You can also run the tests via Visual Studio (open the api-basic-dotnet solution file) if you wish - once you Build the project/solution (Build menu) the tests will appear in the Test Explorer Panel

> **Tip : use a package manager to install software**
> i used Chocolatey package manager for Windows to install this (https://chocolatey.org/install)
> for mac users you can use Brew (https://brew.sh/)
> for linux users you will already have a package manager of your choice to use 

# High-Level Design

## Feature Files 
`/Tests/features`
This framework uses BDD (Behaviour Driven Design) to provide validation of acceptance criteria.
These criteria are expressed as Gherkin (https://specflow.org/learn/gherkin/, https://cucumber.io/docs/gherkin/reference/) feature files to capture these in human-readable format.
Expressing test scenario behaviours and actions in a common way promotes re-usability

## Step Definitions
`Tests/Steps`
Step definition files are the C# implementation of the human-readable feature steps.  
In this example we're using the following libraries 
- `RESTSharp` - to provide HTTP REST (API) calls.  RESTSharp provides an use-to-use interface when compared to the standard HTTPClient library, it also simplifies the reading and writing of complex objects when used with complex APIs
- `Specflow/NUnit` - A dotnet framework which provides the glue between Gherkin (Given/When/Then) feature files and step definitions.  
- `Shouldly` - Another fluent-style assertion framework which allows assertions to be expressed in an intuitive form

## Other possible enhancements
- export test results to xml result file for import into pipeline test results or test management tooling
- html reporting of BDD test results - using something like `Extent.NET` - this would give humans reading the test results a more approachable and visual presentation of both the steps executed and the results
- pipeline integration - typically, test execution of this framework wouldn't be executed on a local machine (unless maintaining / triaging failures) - this framework will run at command line in a pipeline, but needs richer result file to clearly describe success / failures in this scenario