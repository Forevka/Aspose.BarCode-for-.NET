﻿using System.Drawing.Imaging;
using Aspose.BarCode.Generation;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.BarCode.Examples.CSharp.CreateAndManageTwoDBarcodes
{
    class CreateC40DatamatrixBarCode
    {
        public static void Run()
        {
            //ExStart:CreateC40DatamatrixBarCode
            // For complete examples and data files, please go to https://github.com/aspose-barcode/Aspose.BarCode-for-.NET

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_CreateAndManage2DBarCodes();

            // Create an instance of BarCodeBuilder class
            // Set codetext value and EncodeType
            BarCodeGenerator generator = new BarCodeGenerator(EncodeTypes.DataMatrix, "ABCDEF123456");

            // Set the DataMatrix encoding mode to C40
            generator.DataMatrix.EncodeMode = DataMatrixEncodeMode.C40;

            // Save the barcode image
            generator.Save("dataMatrixC40.png");

            //ExEnd:CreateC40DatamatrixBarCode
        }
    }
}

