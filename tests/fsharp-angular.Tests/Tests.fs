module fsharp_angular.Tests

open fsharp_angular
open NUnit.Framework

[<Test>]
let ``hello returns 10`` () =
  let result = Library.GetNumberOfQuestions ()
  printfn "%i" result
  Assert.AreEqual(10,result)
