﻿open System.Drawing
open System.IO
open System

let naiveLine (x0,y0) (x1,y1) color (bitmap:Bitmap) =
    printfn "%i" x0
    printfn "%i" y0
    printfn " -^-^-^-^-^-^-^"
    
    let xLen = float (x1-x0)
    let yLen = float (y1-y0)

    if xLen <> 0.0 then
        for x in x0..x1 do
            let proportion = float (x-x0) / xLen
            let y = (int(Math.Round(proportion * yLen))) + y0
            //printfn  "look here "
            printfn "%i" y 
            bitmap.SetPixel(x,y, color)


    if yLen <> 0.0 then
         for y in y0..y1 do
             let proportion = float (y-y0) / yLen
             let x = (int(Math.Round(proportion * xLen))) + x0
             //printfn  "look here "
             printfn "%i" x 
             bitmap.SetPixel(x,y, color)

let pathAndFileName
    = Path.Combine("/Users/marvinlaucher/FsDev/NaiveLine", "naive.png")

let bitmap = new Bitmap(32,32)

naiveLine (7,10) (15,19)  Color.Red bitmap

bitmap.Save(pathAndFileName)