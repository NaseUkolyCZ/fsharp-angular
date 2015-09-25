namespace fsharp_angular

open ApiaryProvider

/// Documentation for my library
///
/// ## Example
///
///     let h = Library.hello 1
///     printfn "%d" h
///
module Library = 
  // first param: from http://docs.fsharpangular.apiary.io
  // second param: from HOST: http://polls.apiblueprint.org/ in editor e.g. https://app.apiary.io/fsharpangular/editor
  let db = new ApiaryProvider<"fsharpangular">("http://polls.apiblueprint.org/")
  
  /// Returns 42
  ///
  /// ## Parameters
  ///  - `num` - whatever
  let GetNumberOfQuestions () =
    db.GetQuestions().Value.Length

  let GetQuestions () =
    db.GetQuestions().Value
