﻿let lucky = 3 + 4

let unlucky = lucky + 6     


let duplicated = "original value"
let duplicated = "new value"

let shadowed = "original value"
let shadowed = " new value"

let anInt = 10
let aFloat = 20.0
let astring = "I'm a string!"

printfn "hello world from Marvin"

printfn "The answer is %s" "pizza"

let add x y = 
    x + y

add 2 2

add 100 499

let toHackerTalk (phrase:string) =
    phrase.Replace('d', '2').Replace('o', '0')

toHackerTalk "today"

let quadruple x = 
    let double x =
        x * 2
    double(double(x))

quadruple 2

let chrisTest test =
    test "Chris"

let isMe x =
    if x = "Chris" then
        "it is Chris!"
    else
        "it's someone else"

chrisTest isMe

let add = (fun x y -> x + y)
add 2 2

let evens = [2;4;6;8]

let oneHundredList = [0..100]

let doubled = List.map (fun x -> x * 2) oneHundredList

let firstHundred = [0..100]
List.map (fun x -> x * 2) 
    (List.filter (fun x -> x % 2 = 0) firstHundred)

List.sum (List.map (fun x -> x * 2) 
    (List.filter (fun x -> x % 2 = 0) [0..100]))


[0..100]
|> List.filter (fun x -> x % 2 = 0)
|> List.map (fun x -> x * 2)
|> List.sum

//"Date,Open,High,Low,Close,Volume,Adj Close"
let stockData =
    [ 
      "2012-03-30,32.40,32.41,32.04,32.26,31749400,32.26";
      "2012-03-29,32.06,32.19,31.81,32.12,37038500,32.12";
      "2012-03-28,32.52,32.70,32.04,32.19,41344800,32.19";
      "2012-03-27,32.65,32.70,32.40,32.52,36274900,32.52";
      "2012-03-26,32.19,32.61,32.15,32.59,36758300,32.59";
      "2012-03-23,32.10,32.11,31.72,32.01,35912200,32.01";
      "2012-03-22,31.81,32.09,31.79,32.00,31749500,32.00";
      "2012-03-21,31.96,32.15,31.82,31.91,37928600,31.91";
      "2012-03-20,32.10,32.15,31.74,31.99,41566800,31.99";
      "2012-03-19,32.54,32.61,32.15,32.20,44789200,32.20";
      "2012-03-16,32.91,32.95,32.50,32.60,65626400,32.60";
      "2012-03-15,32.79,32.94,32.58,32.85,49068300,32.85";
      "2012-03-14,32.53,32.88,32.49,32.77,41986900,32.77";
      "2012-03-13,32.24,32.69,32.15,32.67,48951700,32.67";
      "2012-03-12,31.97,32.20,31.82,32.04,34073600,32.04";
      "2012-03-09,32.10,32.16,31.92,31.99,34628400,31.99";
      "2012-03-08,32.04,32.21,31.90,32.01,36747400,32.01";
      "2012-03-07,31.67,31.92,31.53,31.84,34340400,31.84";
      "2012-03-06,31.54,31.98,31.49,31.56,51932900,31.56";
      "2012-03-05,32.01,32.05,31.62,31.80,45240000,31.80";
      "2012-03-02,32.31,32.44,32.00,32.08,47314200,32.08";
      "2012-03-01,31.93,32.39,31.85,32.29,77344100,32.29";
      "2012-02-29,31.89,32.00,31.61,31.74,59323600,31.74"; ]

let splitCommas (x:string) =
    x.Split([|','|])

stockData
|> List.map splitCommas
|> List.maxBy (fun x -> abs(float x.[1] - float x.[4]))
|> (fun x -> x.[0])







