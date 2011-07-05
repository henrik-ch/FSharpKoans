namespace FSharpKoans
open FSharpKoans.Core

type ``about tuples``() =
    
    [<Koan>]
    member this.CreatingTuples() =
        let items = ("apple", "dog")
        
        AssertEquality items ("apple", "dog")
        
    [<Koan>]
    member this.AccessingTupleElements() =
        let items = ("apple", "dog")
        
        let fruit = fst items
        let animal = snd items
        
        AssertEquality fruit "apple"
        AssertEquality animal "dog"

    (* although you can access the items
       of a two element tuple with fst and snd,
       it's often better to use a technique
       called pattern matching to access the
       elements of a tuple *)
        
    [<Koan>]
    member this.AccessingTupleElementsWithPatternMatching() =
        let items = ("apple", "dog", "Mustang")
        
        let fruit, animal, car = items
        
        AssertEquality fruit "apple"
        AssertEquality animal "dog"
        AssertEquality car "Mustang"
        
    [<Koan>]
    member this.IgnoringValuesWithPatternMatching() =
        let items = ("apple", "dog", "Mustang")
        
        let _, animal, _ = items
        
        AssertEquality animal "dog"
    
    (* NOTE: pattern matching is found in many places
             throughout F#, and we'll revisit it again later *)
        
    [<Koan>]
    member this.ReturningMultipleValuesFromAFunction() =
        let squareAndCube x =
            (x ** 2.0, x ** 3.0)
        
        let squared, cubed = squareAndCube 3.0
        
        
        AssertEquality squared 9.0
        AssertEquality cubed 27.0
    
    (* THINK ABOUT IT: Is there really more than one return value?
                       What type does the squareAndCube function
                       return? *)
    
    [<Koan>]
    member this.TheTruthBehindMultipleReturnValues() =
        let squareAndCube x =
            (x ** 2.0, x ** 3.0)
            
        let result = squareAndCube 3.0
       
        AssertEquality result (9.0, 27.0)