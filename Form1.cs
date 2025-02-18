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
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using System.Windows;
using System.Threading;
using System.Drawing.Text;
using OpenQA.Selenium.DevTools.V130.Autofill;
using System.Xml.Linq;
using System.Windows.Documents;
using OpenQA.Selenium.DevTools.V130.Page;

namespace WinFormTesseractOCR
{
    public partial class Form1 : Form
    {
        XmlSerializer xs;
        List<ItemClass> ls;
        Queue<ItemClass> q;
        internal String message;
        string address;
        int done = 0;
        

        public Form1()
        {
            InitializeComponent();
            ls = new List<ItemClass>();
            q = new Queue<ItemClass>();
            xs = new XmlSerializer(typeof(List<ItemClass>));
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            //Open PDF
            OpenFileDialog openfile = new OpenFileDialog();
            ComponentInfo.SetLicense("FREE-LIMITED-KEY");
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                var document = PdfDocument.Load(openfile.FileName);
                address = openfile.FileName;
                var imageOptions = new ImageSaveOptions(ImageSaveFormat.Jpeg);
                // Page limition
                /*if (document.Pages.Count > 2)
                {
                    //Pop up window warning only 2 page PDF limited
                }
                //Convert PDF to JPEG
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Dispose();
                    pictureBox1.Image = null;
                    pictureBox1.Dispose();
                }
                for (int pageIndex = 0; pageIndex < document.Pages.Count; pageIndex++)
                {
                    imageOptions.PageNumber = pageIndex;
                    document.Save($"C:/Users/lisa/Downloads/Output.jpg", imageOptions);
                    document.Close();
                }*/

                document.Save($"C:/Users/lisa/Downloads/Output.jpg");
                document.Close();

                // OCR the output
                string tessPath = "C:/Users/lisa/OneDrive/Documents/WinFormTesseractOCR/bin/Debug/tessdata";
                var img = new Bitmap($"C:/Users/lisa/Downloads/Output.jpg");
                //var ocr = new TesseractEngine("./tessdata", "eng", EngineMode.TesseractAndLstm);
                var ocr = new TesseractEngine(tessPath, "eng", EngineMode.TesseractAndLstm);
                var page = ocr.Process(img);
                textBox1.Text = page.GetText();
                var text = page.GetText().ToString();

                //Display Address
                if (address != null) { textBoxAddress.Text = address; }

                Console.WriteLine("Mean confidence: {0}", page.GetMeanConfidence());
                //Console.WriteLine("Text (GetText): \r\n{0}", text);
                //Console.WriteLine("Text (iterator):");
                img.Dispose();
            }
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
            if (matcheddate.Count >= 1) {
                dateTextBox.Text = matcheddate[0].Value;
            }
            else {
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

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(1100,550);
        }

        private void inject_Click(object sender, EventArgs e)
        {
            //Inject Item
            FileStream fs = new FileStream("..\\Item.xml", FileMode.Create, FileAccess.Write);
            ItemClass ic = new ItemClass();
            ic.Id = "|";
            ic.Title = titleTextBox.Text;
            ic.Amount = amountTextBox.Text;
            ic.Date = dateTextBox.Text;
            ic.CostCode = costCodeTextBox.Text;
            ic.Project = projectTextBox.Text;
            ic.AssignTo = assignToComboBox.Text;
            ic.Address = address;

            ls.Add(ic);
            xs.Serialize(fs, ls);
            fs.Close();

            Display();
            
            //Queue
            q.Enqueue(ic);

        }
        public void ReadStream()
        {
            FileStream fs = new FileStream("..\\Item.xml", FileMode.OpenOrCreate, FileAccess.Read);
            ls = (List<ItemClass>)xs.Deserialize(fs);
            dataGridView1.DataSource = ls;
            fs.Close();
        }
        private void Display() {
            FileStream fsc = new FileStream("..\\Item.xml", FileMode.Open, FileAccess.Read);
            ls = (List<ItemClass>)xs.Deserialize(fsc);
            dataGridView1.DataSource = ls;
            fsc.Close();
        }
        private void WriteStream(int i,String m)
        {
            FileStream fs = new FileStream("..\\Item.xml", FileMode.Open, FileAccess.Write);
            ls[i].Id = m;
            xs.Serialize(fs, ls);
            fs.Close();
            Display();
        }


        // Read
        private void button2_Click_1(object sender, EventArgs e)
        {
            Display();
        }
        
        private void button2_Click_2(object sender, EventArgs e)
        {
            //Clear
            System.Windows.Forms.MessageBox.Show("Clear all items in list?");
            ls = new List<ItemClass>();
            done = 0;
            q = new Queue<ItemClass>();

            FileStream fs = new FileStream("..\\Item.xml", FileMode.Create, FileAccess.Write);
            ls.Clear();
            xs.Serialize(fs, ls);
            fs.Close();

            Display();

        }


        private void startButton_Click(object sender, EventArgs e)
        {
            
            int todo = q.Count();
            stateTestBox.Text = ($"Done: {done} | Queue: {todo}");
            ItemClass doing = new ItemClass();
            while (q.Count > 0)
            {
                // Inject Invoices
                doing = q.Peek();
                WriteStream(done, "--");
                Inject(doing);

                q.Dequeue();
                done = done + 1;
                todo = q.Count();
                stateTestBox.Text = ($"Done: {done} | Queue: {todo}");
                
            }
        }

        private void Inject(ItemClass row) 
        {
            Automate.Program inj = new Automate.Program();
            message = inj.GetPONum(row);
            Console.WriteLine(message);
            WriteStream(done, message);
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            WriteStream(0,"32434");
        }

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void subComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            titleTextBox.Text = subComboBox.Text + " "+ invoiceNumTextBox.Text; 
        }

        private void invoiceNumTextBox_TextChanged(object sender, EventArgs e)
        {
            titleTextBox.Text = subComboBox.Text + " " + invoiceNumTextBox.Text;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void costCodeToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void buttonResume_Click(object sender, EventArgs e)
        {
            string path = "C:/Users/lisa/OneDrive/Documents/WinFormTesseractOCR/bin/Item.xml";
            ls = null;
            List<ItemClass> list = new List<ItemClass>();
            ItemClass item = new ItemClass();
            XDocument doc = XDocument.Load(path);
            doc.Descendants();

            foreach (XElement itemElement in doc.Descendants("ItemClass"))
            {
                foreach (XElement atriElement in itemElement.Descendants("Id"))
                {
                    item.Id = atriElement.Value;
                }
                foreach (XElement atriElement in itemElement.Descendants("Title"))
                {
                    item.Title = atriElement.Value;
                }
                foreach (XElement atriElement in itemElement.Descendants("Amount"))
                {
                    item.Amount = atriElement.Value;
                }
                foreach (XElement atriElement in itemElement.Descendants("Date"))
                {
                    item.Date = atriElement.Value;
                }
                foreach (XElement atriElement in itemElement.Descendants("CostCode"))
                {
                    item.CostCode = atriElement.Value;
                }
                foreach (XElement atriElement in itemElement.Descendants("Project"))
                {
                    item.Project = atriElement.Value;
                }
                foreach (XElement atriElement in itemElement.Descendants("AssignTo"))
                {
                    item.AssignTo = atriElement.Value;
                }
                foreach (XElement atriElement in itemElement.Descendants("Address"))
                {
                    item.Address = atriElement.Value;
                }
                list.Add(item);
                q.Enqueue(item);
                //Console.WriteLine(item.Id + item.Title+ item.Amount+ item.Date+ item.CostCode+ item.Project+ item.AssignTo+ item.Address);

            }
            ls = list;
            //ReDisplay list
            //Console.WriteLine(ls[1].Title);
            FileStream fs = new FileStream("..\\Item.xml", FileMode.Create, FileAccess.Write);
            xs.Serialize(fs, ls);
            fs.Close();

            Display();

        }
    }
    
}
