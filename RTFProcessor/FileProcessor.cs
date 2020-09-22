using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace RTFProcessor
{
    public class FileProcessor
    {
        public string ReadAndReplaceRTFFile()
        {
            string readRtfFile = @"C:/New folder/f_rpt_potential_gap_refund_notice.rtf";
            string readRtfFilebyte = System.IO.File.ReadAllText(readRtfFile);
            RichTextBox readRtBox = new RichTextBox();
            //step-1: Read rtf file and assign it to Richtextbox in rtf original format

            readRtBox.Rtf = readRtfFilebyte;
            //step-2: Create new rich text box, read and replace the rtf content in it.
            RichTextBox replaceRtfrtBox = new RichTextBox();
            //create generalized method to replace functionality here.
            replaceRtfrtBox.Rtf = readRtBox.Rtf.Replace("[!vehicle_make!]", "Test Vehicle Make").Replace("[!vehicle_model!]", "Test Vehicle Model").Replace("[!mail_info_line_3!]", "test@gmail.com");
            //step-3 : Save the content replaced rtf file in new folder
            replaceRtfrtBox.SaveFile(@"C:/output/test.rtf", RichTextBoxStreamType.RichText);
            readRtBox.Clear();
            replaceRtfrtBox.Clear();
            return "RTF file read completed and you can find the in output in C:/output/";
        }
    }
}
