// Learn more about F# at http://fsharp.org. See the 'F# Tutorial' project
// for more guidance on F# programming.

let location = (77.51,166.40,21)

let longAlt location = 
    let long,_,alt = location
    (alt, long)
printfn "%A" (fst(longAlt location))
printfn "%A" (snd(longAlt location))

let birthDay = 22,09,1982

let reverse birth = 
    let dd,mm,yy = birth
    yy,mm,dd

printfn "%A" (reverse birthDay)    
