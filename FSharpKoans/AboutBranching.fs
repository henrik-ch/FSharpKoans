namespace FSharpKoans
open FSharpKoans.Core

type ``about branching``() =
    
    [<Koan>]
    member this.BasicBranching() =
        let isEven x =
            if x % 2 = 0 then
                "true"
            else
                "false"
                
        let result = isEven 2                
        AssertEquality result "true"
    
    [<Koan>]
    member this.IfStatementsReturnValues() =
    
        (* In some languages, if statements do not yield results; they only
           execute code. This isn't true in F# due to its functional programming
           roots. *)
           
        let result = 
            if 2 = 3 then
                "something is REALLY wrong"
            else
                "no problem here"

        AssertEquality result "no problem here"

    [<Koan>]
    member this.BranchingWithAPatternMatch() =
        let isApple x =
            match x with
            | "apple" -> true
            | _ -> false
        
        let result1 = isApple "apple"
        let result2 = isApple ""
        
        AssertEquality result1 true
        AssertEquality result2 false
    
    [<Koan>]
    member this.UsingTuplesWithIfStatementsQuicklyBecomesClumsy() =
        
        let getDinner x = 
            let name, foodChoice = x
            
            if foodChoice = "veggies" || foodChoice ="fish" || 
               foodChoice = "chicken" then
                name + " doesn't want red meat"
            else
                name + " wants 'em some " + foodChoice
         
        let person1 = ("Chris", "steak")
        let person2 = ("Dave", "veggies")
        
        AssertEquality (getDinner person1) "Chris wants 'em some steak"
        AssertEquality (getDinner person2) "Dave doesn't want red meat"

        
    [<Koan>]
    member this.PatternMatchingIsNicer() =
    
        let getDinner x =
            match x with
            | (name, "veggies")
            | (name, "fish")
            | (name, "chicken") -> name + " doesn't want red meat"
            | (name, foodChoice) -> name + " wants 'em some " + foodChoice 
            
        let person1 = ("Bob", "fish")
        let person2 = ("Sally", "Burger")
        
        AssertEquality (getDinner person1) "Bob doesn't want red meat"
        AssertEquality (getDinner person2) "Sally wants 'em some Burger"