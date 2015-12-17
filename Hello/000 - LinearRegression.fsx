#r @"G:\Repository\hello\packages\MathNet.Numerics.FSharp.3.9.0\lib\net35\MathNet.Numerics.FSharp.dll"
#r @"G:\Repository\hello\packages\MathNet.Numerics.3.9.0\lib\net35\MathNet.Numerics.dll"

#r "System.Windows.Forms.DataVisualization.dll"

open System

open MathNet.Numerics.LinearAlgebra.Double
open MathNet.Numerics

open System.Drawing
open System.Windows.Forms
open System.Windows.Forms.DataVisualization.Charting





// data points
let xdata = [22.0; 22.0; 37.0 ]
let ydata = [11.0; 22.0; 34.0 ]

let mapToTuple x y = (List.zip x y) |> List.map(fun x -> Tuple<float, float> x)

let result = LinearRegression.SimpleRegression.Fit(mapToTuple xdata ydata)


printfn "%A" (result.Item1)



//multiple regressions




// data points
let xdata2 = [|22.0; 22.0; 37.0 |]
let ydata2 = [|11.0; 22.0; 34.0 |]
let zdata2 = [|6.0; 33.0; 5.0 |]
module Array2D
let data = array2D [ xdata2; ydata2]
let array2DRes = array2D [zdata2]
//let mapToTuple2 x y z = (List.zip3 x y z) |> List.map(fun x -> Tuple<float, float, float> x)
let matrix = Matrix.Build.DenseOfArray(data)
let matrixRes = Matrix.Build.DenseOfArray(array2DRes)
let result2 = LinearRegression.MultipleRegression.QR(matrix, matrixRes)























#r "System.Windows.Forms.DataVisualization.dll"

open System
open System.Windows.Forms
open System.Windows.Forms.DataVisualization.Charting


//fancy chart
// Create an instance of chart control and add main area
let chart = new Chart(Dock = DockStyle.Fill)
chart.DataBindTable (mapToTuple xdata ydata)
chart.DataBind 
let area = new ChartArea("Main")
chart.ChartAreas.Add(area)
// Enable 3D look and rotate the chart
area.Area3DStyle <- 
  ChartArea3DStyle
    (Enable3D = true, IsRightAngleAxes = false, Rotation = 30, 
     Inclination = 30, PointDepth = 100, PointGapDepth = 200)
// Show the chart control on a top-most form
let mainForm = new Form(Visible = true, TopMost = true, 
                        Width = 700, Height = 500)
mainForm.Controls.Add(chart)

//Point chart

#r "System.Windows.Forms.DataVisualization.dll"

open System
open System.Drawing
open System.Windows.Forms
open System.Windows.Forms.DataVisualization.Charting
let data = 
  [ for i in 0.0 .. 0.02 .. 2.0 * Math.PI -> 
      sin i, cos i * sin i ]

// Create a chart containing a default area and show it on a form
let chartp = new Chart(Dock = DockStyle.Fill)
let form = new Form(Visible = true, Width = 700, Height = 500)
chartp.ChartAreas.Add(new ChartArea("MainArea"))
form.Controls.Add(chartp)

// Create series and add it to the chart
let series = new Series(ChartType = SeriesChartType.Line)
chartp.Series.Add(series)

// Add data to the series in a loop
for x, y in data do
  series.Points.AddXY(x, y) |> ignore