namespace FSharpKoans
open FSharpKoans.Core

type ``about how to apply what you've learned so far``() =
    (* Now that you've learned a few things about F#, it's time to use that
       knowledge to use to solve a problem. The problem that we are going to
       solve is the simple "fizzbuzz" problem.
       
       The problem is defined on Jeff Attwood's blog (www.codinghorror.com) as
       follows:
           
           "Write a program that prints the numbers from 1 to 100. But for
           multiples of three print "Fizz" instead of the number and for the
           multiples of five print "Buzz". For numbers which are multiples of
           both three and five print "FizzBuzz"."

       We are going to slightly modify that problem statement to return a list.
       Below is a stubbed out function and a few koans that depend on the
       results of the function. Your goal is to fill in the body of the function
       in order to make it pass. *)

    let fizzer(i : int) = 
        match i with
        | _ when i % 3 = 0 && i % 5 = 0 -> "FizzBuzz"
        | _ when i % 3 = 0 -> "Fizz"
        | _ when i % 5 = 0 -> "Buzz"
        | _ -> i.ToString()
        


    [<Koan>]
    member this.Multipl() =

        let result1 =   [0..100]
                        |> List.map fizzer
        //|> List.iter (fun inStr -> printfn "%A" inStr)

        AssertEquality result1 ["FizzBuzz"; "1"; "2"; "Fizz"; "4"; 
                                "Buzz"; "Fizz"; "7"; "8"; "Fizz"; "Buzz"; "11"; 
                                "Fizz"; "13"; "14"; "FizzBuzz"; "16"; "17"; "Fizz"; 
                                "19"; "Buzz"; "Fizz"; "22"; "23"; "Fizz"; "Buzz"; "26"; 
                                "Fizz"; "28"; "29"; "FizzBuzz"; "31"; "32"; "Fizz"; "34"; 
                                "Buzz"; "Fizz"; "37"; "38"; "Fizz"; "Buzz"; "41"; "Fizz"; "43"; 
                                "44"; "FizzBuzz"; "46"; "47"; "Fizz"; "49"; "Buzz"; "Fizz"; "52"; 
                                "53"; "Fizz"; "Buzz"; "56"; "Fizz"; "58"; "59"; "FizzBuzz"; "61"; 
                                "62"; "Fizz"; "64"; "Buzz"; "Fizz"; "67"; "68"; "Fizz"; "Buzz"; "71"; 
                                "Fizz"; "73"; "74"; "FizzBuzz"; "76"; "77"; "Fizz"; "79"; "Buzz"; "Fizz"; "82"; 
                                "83"; "Fizz"; "Buzz"; "86"; "Fizz"; "88"; "89"; "FizzBuzz"; "91"; "92"; "Fizz"; 
                                "94"; "Buzz"; "Fizz"; "97"; "98"; "Fizz"; "Buzz";]

        ()