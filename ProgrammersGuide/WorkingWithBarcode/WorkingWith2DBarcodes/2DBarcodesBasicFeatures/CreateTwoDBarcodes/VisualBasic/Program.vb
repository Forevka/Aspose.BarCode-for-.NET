'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.BarCode. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.BarCode
Imports System.Drawing.Imaging

Namespace CreateTwoDBarcodes
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			' Create directory if it is not already present.
			Dim IsExists As Boolean = System.IO.Directory.Exists(dataDir)
			If (Not IsExists) Then
				System.IO.Directory.CreateDirectory(dataDir)
			End If

			Dim b As Aspose.BarCode.BarCodeBuilder
			b = New Aspose.BarCode.BarCodeBuilder()
			b.SymbologyType = Aspose.BarCode.Symbology.Pdf417
			' width of each module
			b.xDimension = 0.6f
			' height of each module
			b.yDimension = 1.2f
			b.CodeText = "this is some test code text. " & Constants.vbLf & " Second line " & Constants.vbLf & " third line."
			b.Save(dataDir & "result.bmp", ImageFormat.Bmp)

		End Sub
	End Class
End Namespace