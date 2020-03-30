﻿using System;
using Aspose.BarCode.BarCodeRecognition;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.BarCode.Examples.CSharp.RecognitionExamples
{
    class SwitchBarcodeRecognitionModes
    {
        public static void Run()
        {
            try
            {
                // ExStart:SwitchBarcodeRecognitionModes
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_Recognition();

                // Initialize the BarCodeReader object and  Set recognition mode
                BarCodeReader reader = new BarCodeReader(dataDir + "datamatrix-barcode.jpg", DecodeType.DataMatrix);
                reader.QualitySettings = QualitySettings.HighPerformance;
                reader.QualitySettings.AllowInvertImage = true;
                reader.QualitySettings.AllowIncorrectBarcodes = true;

                // Try to recognize all possible barcodes in the image and Display the codetext
                while (reader.Read())
                {
                    Console.WriteLine("Codetext: " + reader.GetCodeText());
                }
                // Close the reader
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose BarCode License. You can purchase full license or get 30 day temporary license from http://wwww.aspose.com/purchase/default.aspx.");
            }
            // ExEnd:SwitchBarcodeRecognitionModes
        }
    }
}