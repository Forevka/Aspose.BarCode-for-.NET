﻿using System;
using System.IO;
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
    class ReadMultipleMacropdf417BarcodeImages
    {
        public static void Run()
        {
            // ExStart:ReadMultipleMacropdf417BarcodeImages
            try
            {
                // The path to the documents directory.             
                string dataDir = RunExamples.GetDataDir_Recognition();
                string strFileID = "1";
                string[] strFileslist = Directory.GetFiles(dataDir, strFileID + "_*.png");
                foreach (string strFile in strFileslist)
                {
                    // We got list of all the files, now read barcodes
                    BarCodeReader reader = new BarCodeReader(strFile, DecodeType.MacroPdf417);
                    if (reader.Read() == true)
                    {
                        Console.WriteLine("File: " + strFile + " == FileID: " + reader.GetMacroPdf417FileID() +
                            " == SegmentID: " + reader.GetMacroPdf417SegmentID() + "  == CodeText: " + reader.GetCodeText());
                    }

                    // Close the reader
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose BarCode License. You can purchase full license or get 30 day temporary license from http://wwww.aspose.com/purchase/default.aspx.");
            }
            // ExEnd:ReadMultipleMacropdf417BarcodeImages
        }
    }
}
