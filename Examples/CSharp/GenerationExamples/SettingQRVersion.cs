﻿using System.Drawing.Imaging;
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
    class SettingQRVersion
    {
        public static void Run()
        {
            //ExStart:EncodeQRCode
            
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Generation();

            // Instantiate BarcodeGenerator object
            BarcodeGenerator generator = new BarcodeGenerator(EncodeTypes.QR, "ABCDEFGHIJKLMNOPQRSTUVWXYZ");

            // Set the error level
            generator.Parameters.Barcode.QR.QrErrorLevel = QRErrorLevel.LevelQ;

            // Set the QR barcode version number
            generator.Parameters.Barcode.QR.QrVersion = QRVersion.Version10;

            //Save the image
            generator.Save(dataDir + "qr_version10_errorQ.png");
            
            //ExEnd:EncodeQRCode
        }
    }
}