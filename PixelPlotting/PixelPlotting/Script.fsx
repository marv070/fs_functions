open System.Drawing

let bitmap = new Bitmap(16,16)

let path = "/Users/marvinlaucher/FsDev/PixelPlotting" + "/" 

bitmap.SetPixel(6, 2, Color.DarkOrange)
bitmap.SetPixel(10, 2, Color.DarkOrange)
bitmap.SetPixel(8, 5, Color.CadetBlue)
bitmap.SetPixel(5, 6, Color.BlueViolet)
bitmap.SetPixel(6, 7, Color.BlueViolet)
bitmap.SetPixel(4, 6, Color.BlueViolet)
//bitmap.SetPixel(6, 8, Color.DarkOrange)
bitmap.SetPixel(7, 8, Color.BlueViolet)
bitmap.SetPixel(8, 8, Color.BlueViolet)
bitmap.SetPixel(9, 8, Color.BlueViolet)
bitmap.SetPixel(11, 7, Color.BlueViolet)
bitmap.SetPixel(11, 6, Color.BlueViolet)
bitmap.SetPixel(5, 7, Color.BlueViolet)
bitmap.SetPixel(10, 7, Color.BlueViolet)
bitmap.SetPixel(12, 6, Color.BlueViolet)

bitmap.Save(path + "plot.png")