#r @"C:\Training\euler\hello\packages\MathNet.Numerics.3.9.0\lib\net35\MathNet.Numerics.dll"
#r @"C:\Training\euler\hello\packages\MathNet.Numerics.FSharp.3.9.0\lib\net35\MathNet.Numerics.Fsharp.dll"

open MathNet.Numerics.Statistics

let rnd = System.Random()

let rand() = rnd.NextDouble()

let data = seq { for i in 0 .. 10000000 -> rand()  }

Statistics.StandardDeviation data

open System
open MathNet.Numerics.LinearAlgebra
let m = matrix [[ 1.0; 2.0 ]
                [ 3.0; 4.0 ]]
let m' = m.Inverse()

//vieans budas
let m1 = matrix [[ 2.0; 3.0 ]
                 [ 4.0; 5.0 ]]
//kitas budas
let arr = array2D [[1.0;2.0]; [1.0;2.0]]

let m = DenseMatrix.ofArray2 arr



let v1 = vector [ 1.0; 2.0; 3.0 ]

// dense 3x4 matrix filled with zeros.
// (usually the type is inferred, but not for zero matrices)
let m2 = DenseMatrix.zero<float> 3 4

// dense 3x4 matrix initialized by a function
let m3 = DenseMatrix.init 3 4 (fun i j -> float (i+j))

// diagonal 4x4 identity matrix of single precision
let m4 = DiagonalMatrix.identity<float32> 4

// dense 3x4 matrix created from a sequence of sequence-columns
let x = Seq.init 4 (fun c -> Seq.init 3 (fun r -> float (100*r + c)))
let m5 = DenseMatrix.ofColumnSeq x

// random matrix with standard distribution:
let m6 = DenseMatrix.randomStandard<float> 3 4

// random matrix with a uniform and one with a Gamma distribution:
let m7a = DenseMatrix.random<float> 3 4 (ContinuousUniform(-2.0, 4.0))
let m7b = DenseMatrix.random<float> 3 4 (Gamma(1.0, 2.0))