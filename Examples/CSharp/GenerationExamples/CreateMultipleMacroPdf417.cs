﻿using System;
using System.Diagnostics;
using System.Drawing.Imaging;
using Aspose.BarCode.Generation;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.BarCode.Examples.CSharp.GenerationExamples
{
    class CreateMultipleMacroPdf417
    {
        public static void Run()
        {
            //ExStart:CreateMultipleMacroPdf417
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Generation();

            // Create array for storing multiple barcodes
            const int nSize = 4;
            string[] lstCodeText = new[] { "code-1", "code-2", "code-3", "code-4" };
            const int strFileId = 1;

            // Instantiate barcode object and set CodeText & Barcode Symbology
            using (BarcodeGenerator generator = new BarcodeGenerator(EncodeTypes.MacroPdf417, "1234567890"))
            {
                for (int nCount = 1; nCount <= nSize; nCount++)
                {
                    generator.CodeText = lstCodeText[nCount - 1];

                    // FileID should be same for all the generated bar codes
                    generator.Parameters.Barcode.Pdf417.Pdf417MacroFileID = strFileId;

                    // Assign segmentID in increasing order (1,2,3,....) and Set the segments count
                    generator.Parameters.Barcode.Pdf417.Pdf417MacroSegmentID = nCount;
                    generator.Parameters.Barcode.Pdf417.Pdf417MacroSegmentsCount = nSize;
                   
                    try
                    {
                        // Save the barcode (fileid_segmentid.png)
                        generator.Save(dataDir + strFileId + "_" + nCount + "_out.png", BarCodeImageFormat.Png);
                        Process.Start(dataDir + strFileId + "_" + nCount + "_out.png");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            //ExEnd:CreateMultipleMacroPdf417
        }
    }
}