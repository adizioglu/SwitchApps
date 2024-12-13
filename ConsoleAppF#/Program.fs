open System

let firstName = "Sue"
let age = 189

match age with
| _ when age >= 0 && age < 18 -> 
    printfn "You are a child"
| _ when age >= 18 && age < 66 -> 
    printfn "You should have a job"
| _ when age >= 66 -> 
    printfn "Hopefully you are retired or retiring soon."
| _ -> 
    printfn "Age was not in an expected range."

//match firstName.ToLower() with
//| "tim" | "sue" -> 
//    printfn "Hello Professor"
//| "tom" -> 
//    printfn "Hello Tom"
//| _ -> 
//    printfn "I don't know you"
