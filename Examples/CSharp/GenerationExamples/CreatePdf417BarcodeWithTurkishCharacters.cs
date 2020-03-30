﻿using System.Text;
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
    class CreatePdf417BarcodeWithTurkishCharacters
    {
        public static void Run()
        {
            // ExStart:CreatePdf417BarcodeWithTurkishCharacters
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Generation();
            const string codetext = "AYŞE" + "\n" + "Ümit" + "\n" + "Ümit@estee.com" + "\n" + "Türkiye";

            // Generate the barcode
            BarcodeGenerator generator = new BarcodeGenerator(EncodeTypes.Pdf417, codetext);

            // Encode the code text and  Set the display text
            generator.Parameters.Barcode.Pdf417.CodeTextEncoding = Encoding.Unicode;
            generator.Parameters.Barcode.CodeTextParameters.TwoDDisplayText = codetext;
            generator.Save(dataDir + "CreatePdf417BarcodeWithTurkishCharacters_out.png");
            // ExEnd:CreatePdf417BarcodeWithTurkishCharacters
        }
    }
}