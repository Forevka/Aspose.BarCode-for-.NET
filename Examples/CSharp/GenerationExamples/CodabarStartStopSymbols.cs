﻿using Aspose.BarCode.Generation;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.BarCode.Examples.CSharp.GenerationExamples
{
    class CodabarStartStopSymbols
    {
        public static void Run()
        {
            // ExStart:CodabarStartStopSymbols 

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Generation();

            // Create instance of BarcodeGenerator, specify codetext and symbology in the constructor
            using (BarcodeGenerator generator = new BarcodeGenerator(EncodeTypes.Codabar, "11112222333344"))
            {
                // Set the codabar start symbol to A and stop symbol to D
                generator.Parameters.Barcode.Codabar.CodabarStartSymbol = CodabarSymbol.A;
                generator.Parameters.Barcode.Codabar.CodabarStopSymbol = CodabarSymbol.D;

                generator.Save(dataDir + "Coabar-start-stop-symbols_out.png");
            }
            
            // ExEnd:CodabarStartStopSymbols 
        }
    }
}