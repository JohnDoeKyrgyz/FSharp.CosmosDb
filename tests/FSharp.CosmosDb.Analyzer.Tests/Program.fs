﻿module FSharp.CosmosDb.Analyzer.Tests

open Expecto
open Expecto.Logging

let config =
    { defaultConfig with
          verbosity = Verbose
          ``parallel`` = false }

[<EntryPoint>]
let main argv = runTestsInAssembly config argv
