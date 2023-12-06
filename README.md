# Fizz Buzz Interview

This solution was generated using the following commands:
`dotnet new gitignore`
`dotnet new classlib -o FizzBuzzService`
`dotnet new xunit -o FizzBuzzService.Tests`

## Instructions

To run unit tests `dotnet test` should be run in the top level solution


## Note

The tests don't inject an output service at current (which is what I would do next), but the task took a lot longer than I planned since I ensure to commit as regularly as possible. My next step would be to add tests for Generate() that inject a mock output service and check the correct values are printed to output (by adding the output service as an argument to the constructor of the FizzBuzz Service)