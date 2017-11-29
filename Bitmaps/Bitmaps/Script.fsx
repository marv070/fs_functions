open System.Drawing

let bitmap = new Bitmap(32,32)

let path = "/Users/marvinlaucher/FsDev/Bitmaps/Bitmaps" + "/"

bitmap.Save(path + "large.png")

//printfn "%A" (path)