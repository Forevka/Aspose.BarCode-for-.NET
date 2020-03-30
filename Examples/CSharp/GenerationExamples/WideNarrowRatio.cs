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
    class WideNarrowRatio
    {
        public static void Run()
        {
            // ExStart:WideNarrowRatio   
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Generation();

            // Instantiate linear barcode object
            BarcodeGenerator generator = new BarcodeGenerator(EncodeTypes.Code39Standard, "1234567");
            // Set the wide to narrow ratio for the barcode
            generator.Parameters.Barcode.WideNarrowRatio = 3.0f;

            // Save the image to your system and set its image format to Jpeg
            generator.Save(dataDir + "barcode_ratio_3_out.jpg", BarCodeImageFormat.Jpeg);

            // Set the wide to narrow ratio for the barcode
            generator.Parameters.Barcode.WideNarrowRatio = 5.0f;

            // Save the image to your system and set its image format to Jpeg
            generator.Save(dataDir + "barcode_ratio_5_out.jpg", BarCodeImageFormat.Jpeg);

            // Set the wide to narrow ratio for the barcode
            generator.Parameters.Barcode.WideNarrowRatio = 7.0f;

            // Save the image to your system and set its image format to Jpeg
            generator.Save(dataDir + "barcode_ratio_7_out.jpg", BarCodeImageFormat.Jpeg);

            // Set the wide to narrow ratio for the barcode
            generator.Parameters.Barcode.WideNarrowRatio = 9.0f;

            // Save the image to your system and set its image format to Jpeg
            generator.Save(dataDir + "code39-wide-narrow-ratio_out.jpg", BarCodeImageFormat.Jpeg);
            // ExEnd:WideNarrowRatio   
        }
    }
}
