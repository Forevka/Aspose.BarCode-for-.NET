﻿using Aspose.BarCode;
using Aspose.BarCode.Examples.CSharp;
using Aspose.BarCode.Generation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp.CreateAndManageTwoDBarcodes
{
    class ErrorCorrectionLevel
    {
        public static void Run()
        {
            //ExStart:ErrorCorrectionLevel
            // For complete examples and data files, please go to https://github.com/aspose-barcode/Aspose.BarCode-for-.NET

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_CreateAndManage2DBarCodes();

            // Instantiate barcode object
            BarCodeGenerator generator = new BarCodeGenerator(EncodeTypes.Pdf417, "1234567890");
            
            // Set Pdf417 Error correction level
            generator.Pdf417.ErrorLevel = Pdf417ErrorLevel.Level8;

            generator.Save(dataDir + "ManagePDF417Barcode_out.bmp", BarCodeImageFormat.Bmp);
            //ExEnd:ErrorCorrectionLevel
        }
    }
}
