let person = ("Marv", "Laucher","Steelers", 30)

type Date = {
    day : int
    month : int
    year : int }

    
type Person = {
    firstName: string
    lastName: string
    favTeam: string
    myAge: int 
    dateOfBirth: Date }

let me = {
    firstName="Marvin"
    lastName="Laucher"
    favTeam="Steelers"
    myAge=35
    dateOfBirth= {day=22;month=9;year=1982} } 


let updateDob person birthday = 
    let updated = { person with dateOfBirth=birthday }
    printfn "%A" updated
    printfn "%A" person
    updated

let { firstName=myFirstName } = me
let { lastName=myLastName } = me
let { myAge=myAge } = me
let { favTeam=myFavTeam } = me
let { dateOfBirth=myDob } = me

let myFullName = me.firstName + " " +  me.lastName

let temp = { me with myAge=35 }

let marvsBdate = me.dateOfBirth

let anotherUpdate = { me with favTeam="The Pittsburgh STEELERS" }

me

