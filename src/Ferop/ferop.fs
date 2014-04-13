﻿module Ferop.Code

type FeropAttribute = ReflectedDefinitionAttribute

[<System.AttributeUsageAttribute (System.AttributeTargets.Class)>]
type ClangFlagsOsxAttribute (flags: string) =
    inherit System.Attribute ()

[<System.AttributeUsageAttribute (System.AttributeTargets.Class)>]
type ClangLibsOsxAttribute (libs: string) =
    inherit System.Attribute ()

[<System.AttributeUsageAttribute (System.AttributeTargets.Class)>]
type MsvcLibsWinAttribute (libs: string) =
    inherit System.Attribute ()

[<System.AttributeUsageAttribute (System.AttributeTargets.Class)>]
type MsvcIncludesWinAttribute (libs: string) =
    inherit System.Attribute ()

[<System.AttributeUsageAttribute (System.AttributeTargets.Class, AllowMultiple = true)>]
type IncludeAttribute (headerFile: string) =
    inherit System.Attribute ()

let private errorMsg = "This should not be called directly. Instead, call the generated version."

let C (code: string) =
    code |> ignore
    failwith errorMsg