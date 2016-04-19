open System
open System.IO
open System.Drawing

let arr = String.Join(", ", [|"aaa"; "bbb"; "ccc"|])
let reduceDemo (arr : array<string>) =
    arr
    //|> Array.reduce(fun acc elem -> sprintf "%s, %s" acc elem)
    |> Array.reduce(+)

[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    0 // return an integer exit code

