namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("fsharp-angular")>]
[<assembly: AssemblyProductAttribute("fsharp-angular")>]
[<assembly: AssemblyDescriptionAttribute("Complete F# AngularJS example in Visual Studio 2015")>]
[<assembly: AssemblyVersionAttribute("1.0")>]
[<assembly: AssemblyFileVersionAttribute("1.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0"
