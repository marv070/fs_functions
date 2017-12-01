open System.Drawing
open System.IO

let pathAndFileName
    = Path.Combine("/Users/marvinlaucher/FsDev/Division", "accuracy.png")

let bitmap = new Bitmap(32,32)


bitmap.Save(pathAndFileName)