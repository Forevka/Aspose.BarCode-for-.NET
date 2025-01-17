//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.Serialization
{
    internal class BarCodeReaderSerialization : SerializationBase
    {
		public static void Run()
        {
            string path = GetFolder();
            string recpath = GetReaderFolder();
            System.Console.WriteLine("BarCodeReaderSerialization:");

            //init barcode reader
            using (BarCodeReader read = new BarCodeReader())
            {
                read.SetBarCodeReadType(DecodeType.Pdf417);
                read.BarcodeSettings.StripFNC = true;
                read.QualitySettings.MedianSmoothingWindowSize = 5;
                ////serialize BarCodeReader to file
                read.ExportToXml($"{path}readerPdf417.xml");
            }

            //load BarCodeReader from file
            Console.WriteLine("BarCodeReaderSerialization:");
            using (BarCodeReader read = BarCodeReader.ImportFromXml($"{path}readerPdf417.xml"))
            {
                //set the recognized file because it is not stored
                read.SetBarCodeImage($"{recpath}many_pdf417.png");
                //initialized data
                Console.WriteLine($"StripFNC:{read.BarcodeSettings.StripFNC}");
                Console.WriteLine($"MedianSmoothingWindowSize:{read.QualitySettings.MedianSmoothingWindowSize}");
                //read
                Console.WriteLine($"Barcodes read: {read.ReadBarCodes().Length}");
                foreach (BarCodeResult result in read.FoundBarCodes)
                    Console.WriteLine($"{result.CodeTypeName}:{result.CodeText}");
            }
        }
    }
}