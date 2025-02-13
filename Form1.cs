using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;
using GemBox.Pdf;
using HuggingFace;
using System.Windows.Media;

namespace WinFormTesseractOCR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            ComponentInfo.SetLicense("FREE-LIMITED-KEY");
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                var document = PdfDocument.Load(openfile.FileName);
                var imageOptions = new ImageSaveOptions(ImageSaveFormat.Jpeg);
                // Page limition
                if (document.Pages.Count > 2)
                {
                    //Pop up window warning only 2 page PDF limited
                }
                //Convert PDF to JPEG
                /*if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Dispose();
                    pictureBox1.Image = null;
                    pictureBox1.Dispose();
                }*/
                for (int pageIndex = 0; pageIndex < document.Pages.Count; pageIndex++)
                {
                    imageOptions.PageNumber = pageIndex;
                    document.Save($"C:/Users/lisa/Downloads/Output.jpg", imageOptions);
                    document.Close();
                }
                
                //pictureBox1.Load($"C:/Users/lisa/Downloads/Output.jpg") ;

                // OCR the output
                var img = new Bitmap($"C:/Users/lisa/Downloads/Output.jpg");
                var ocr = new TesseractEngine("./tessdata", "eng", EngineMode.TesseractAndLstm);
                var page = ocr.Process(img);
                textBox1.Text = page.GetText();
                var text = page.GetText().ToString();
                
                Console.WriteLine("Mean confidence: {0}", page.GetMeanConfidence());
                Console.WriteLine("Text (GetText): \r\n{0}", text);
                Console.WriteLine("Text (iterator):");
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
             string s = textBox1.Text;
            //Extract date
            Regex date = new Regex(@"(0[1-9]|1[0-2])\/(0[1-9]|[12][0-9]|3[01])\/\d{2,4}");
            MatchCollection matcheddate = date.Matches(s);
            for (int count = 0; count < matcheddate.Count; count++) { 
                Console.WriteLine(matcheddate[count].Value);
            }
            if (matcheddate.Count >= 1){
                dateTextBox.Text= matcheddate[0].Value;
            }
            else{
                Console.WriteLine("Nothing");
                dateTextBox.Text = "Not found";
            }

            //Extract amount
            //Regex amount = new Regex(@"SUBTOTAL:\s+\-{0,1}\d+\.\d{2}");
            Regex amount = new Regex(@"(SUB){0,1}TOTAL:{0,1}(BEFORE TAX){0,1}\s+\${0,1}\-{0,1}\d+\.\d{2}");
            MatchCollection matchedAmount = amount.Matches(s);
            for (int count = 0; count < matchedAmount.Count; count++)
            {
                Console.WriteLine(matchedAmount[count].Value);
            }
            if (matchedAmount.Count >= 1)
            {
                Regex digit = new Regex(@"\d+.\d{2}");
                MatchCollection matcheddigit = digit.Matches(matchedAmount[0].Value);
                Console.WriteLine(matcheddigit[0].Value);
                amountTextBox.Text = matcheddigit[0].Value;
            }
            else
            {
                Console.WriteLine("Nothing");
                amountTextBox.Text = "Not found";
            }

            //Extract PO
            Regex PO = new Regex(@"PO\/{0,1}[a-zA-z\s]{0,10}(:|#)[a-zA-Z/s]{0,15}");
            MatchCollection matchedPO = PO.Matches(s);
            for (int count = 0; count < matchedPO.Count; count++)
            {
                Console.WriteLine(matchedPO[count].Value);
            }
            if (matchedPO.Count >= 1)
            {
                string result = Regex.Replace(matchedPO[0].Value, @"\D", "");
                projectTextBox.Text = result;
            }
            else
            {
                Console.WriteLine("Nothing");
                projectTextBox.Text = "Not found";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void costCode_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
