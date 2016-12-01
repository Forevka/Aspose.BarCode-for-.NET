﻿using System.Drawing.Imaging;
using Aspose.BarCode.Generation;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodes
{
    class SetSupplementData
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodes();

            // Instantiate barcode object
            BarCodeBuilder barCodeBuilder = new BarCodeBuilder("123456789123", EncodeTypes.EAN13)
            {
                // Set the supplement data (5 Digit)
                SupplementData = "12345",
                SupplementSpace = 2.0f
            };
            barCodeBuilder.Save(dataDir + "SetSupplementData_out.jpg", ImageFormat.Jpeg);
        }
    }
}