namespace WinFormTesseractOCR
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.projectTextBox = new System.Windows.Forms.TextBox();
            this.project = new System.Windows.Forms.Label();
            this.assignTo = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.invoiceNum = new System.Windows.Forms.Label();
            this.invoiceNumTextBox = new System.Windows.Forms.TextBox();
            this.extract = new System.Windows.Forms.Button();
            this.inject = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.costCodeTextBox = new System.Windows.Forms.TextBox();
            this.costCode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 46);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open PDF";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(45, 92);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(406, 829);
            this.textBox1.TabIndex = 2;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(904, 92);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(38, 20);
            this.title.TabIndex = 3;
            this.title.Text = "Title";
            this.title.Click += new System.EventHandler(this.Label1_Click);
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.Location = new System.Drawing.Point(904, 231);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(65, 20);
            this.amount.TabIndex = 4;
            this.amount.Text = "Amount";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(901, 311);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(44, 20);
            this.date.TabIndex = 5;
            this.date.Text = "Date";
            this.date.Click += new System.EventHandler(this.label3_Click);
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(904, 122);
            this.titleTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(148, 26);
            this.titleTextBox.TabIndex = 6;
            this.titleTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(904, 268);
            this.amountTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(148, 26);
            this.amountTextBox.TabIndex = 7;
            this.amountTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(904, 336);
            this.dateTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(148, 26);
            this.dateTextBox.TabIndex = 8;
            // 
            // projectTextBox
            // 
            this.projectTextBox.Location = new System.Drawing.Point(904, 478);
            this.projectTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.projectTextBox.Name = "projectTextBox";
            this.projectTextBox.Size = new System.Drawing.Size(148, 26);
            this.projectTextBox.TabIndex = 9;
            // 
            // project
            // 
            this.project.AutoSize = true;
            this.project.Location = new System.Drawing.Point(901, 452);
            this.project.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.project.Name = "project";
            this.project.Size = new System.Drawing.Size(58, 20);
            this.project.TabIndex = 10;
            this.project.Text = "Project";
            this.project.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // assignTo
            // 
            this.assignTo.AutoSize = true;
            this.assignTo.Location = new System.Drawing.Point(904, 646);
            this.assignTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.assignTo.Name = "assignTo";
            this.assignTo.Size = new System.Drawing.Size(83, 20);
            this.assignTo.TabIndex = 11;
            this.assignTo.Text = "Assign to :";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "2 Brothers Painting",
            "7 Pines Plumbing",
            "Ace Hardware ",
            "Advance Green Pest Solutions",
            "Advanced Excavating Specialists",
            "Advanced Plumbing",
            "Advantage Lock and Key LLC",
            "Alpine Painters LLC",
            "Altamira Floors",
            "AM PRO Plumbing",
            "Amanda Swanson Design",
            "Amazon",
            "American Olean",
            "American Structures and Decking Material",
            "Anton Heating & Air Conditioning",
            "Anton Heating and Cooling",
            "Anxin Furniture",
            "Apollo Drain & Rooter Service",
            "Aspen Pest Control",
            "Atlas Labs",
            "Atlas Testing",
            "BC Drywall solutions",
            "Beacon Building Product",
            "Beaudry\'s Custom Woodwork",
            "Bliss Roofing",
            "Blue Frog Plumbing (Ben Graham)",
            "Bruner Plumbing",
            "build.com",
            "Builders First Source",
            "Building Material Resources",
            "Building Material Specialties",
            "Bulbs.com",
            "Burton Pest Control",
            "Charles McNearney",
            "Chey Plastering",
            "City of Portland FIR ",
            "City of Portland FIR Program",
            "Conin Floors, LLC",
            "Conrad Lumber Co",
            "Consolidated Supply Co.",
            "Contract Furnishings Mart",
            "Contractors Furnishing Mart (CFM)",
            "Coppa Woodworking, Inc.",
            "Cosmos Promo LLC",
            "Customline Shower Company",
            "Cutting Edge Custom Cabinetry",
            "Daneil\'s Auto Repair",
            "Deck Rejuvenations",
            "Department of Labor and Industries",
            "Dorothy Tester Sales",
            "DT Glass",
            "Eric Tolman",
            "Eric- Cascade Septic",
            "Flawless Floors and More LLC  (James)",
            "Floform Countertops",
            "G.W Hardware",
            "Galaxy Stoneworks",
            "Haltiner Sheetmetal",
            "Hankins Hardware",
            "Harbor Freight",
            "HD Painting",
            "Home Builders Association of Metropolitan Portland",
            "Johnson Creek Rentals",
            "Jon\'s Waterproofing",
            "Josh Patton AP",
            "Keoni- River City NW Mechanical",
            "LL Flooring",
            "Lowe\'s",
            "Lowes Millwork",
            "M.T. Dunn Plumbing",
            "Macadam Floor & Design",
            "Matt Wasch (Plumbing)",
            "McCoy Millwork",
            "Medallion Industries, Inc.",
            "Mikowski Painting Inc.",
            "Miller Consulting Engineers",
            "Miller Paint",
            "Montoyas Painting LLC",
            "Morrison Heating and Cooling",
            "MT Dunn Plumbing",
            "National Builders Hardware Co",
            "Next Level Roofing and Construction",
            "NW Flooring ",
            "NW Metal Fab & Pipe",
            "NW Natural",
            "Office Depot",
            "Oregon City Garbage",
            "Oregon Metro Business",
            "Oswego Drywall Installers, Inc",
            "Outside the Box: Finished/Unfinished Cabinet Doors",
            "Pacific Lock & Hardware Supply",
            "Parr Cabinet",
            "Parr Cabinet Design Center",
            "Parr Lumber",
            "Philip Sturges AP",
            "Plumbers Inc",
            "Plumbline Drywall",
            "Portland Fireplace & Chimney",
            "Precision Truss & Lumber",
            "Pride Disposal Company",
            "Proud Ground",
            "Rayborn\'s Plumbing",
            "Rejuvination",
            "Robert Licari (Bob) FLOORING GUY!",
            "Rose City Plumbing",
            "S & H Recycling",
            "Sherwin-Williams",
            "Stanley Ave Bathtub",
            "Steel Design Solutions",
            "Sunbelt Rental",
            "Super Drywall",
            "Superior Roofing",
            "Target",
            "Terra Firma Foundation Systems",
            "Terrones Concrete",
            "THE 4T CONSTRUCTION LLC",
            "The Home Depot",
            "The Plumbers Inc",
            "Uriel Sanchez (Chey Plastering & Stucco)",
            "USI Insulation",
            "Wumingkun Wei AP",
            "Xavier AP",
            "Zoro",
            "Premier Pacific Roofing",
            "Barbur BLVD Rentals INC",
            "BiMart"});
            this.listBox1.Location = new System.Drawing.Point(904, 692);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(148, 144);
            this.listBox1.TabIndex = 12;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // invoiceNum
            // 
            this.invoiceNum.AutoSize = true;
            this.invoiceNum.Location = new System.Drawing.Point(904, 161);
            this.invoiceNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.invoiceNum.Name = "invoiceNum";
            this.invoiceNum.Size = new System.Drawing.Size(87, 20);
            this.invoiceNum.TabIndex = 13;
            this.invoiceNum.Text = "Invoice No.";
            this.invoiceNum.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // invoiceNumTextBox
            // 
            this.invoiceNumTextBox.Location = new System.Drawing.Point(904, 192);
            this.invoiceNumTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.invoiceNumTextBox.Name = "invoiceNumTextBox";
            this.invoiceNumTextBox.Size = new System.Drawing.Size(148, 26);
            this.invoiceNumTextBox.TabIndex = 14;
            // 
            // extract
            // 
            this.extract.Location = new System.Drawing.Point(241, 46);
            this.extract.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.extract.Name = "extract";
            this.extract.Size = new System.Drawing.Size(134, 41);
            this.extract.TabIndex = 15;
            this.extract.Text = "Extract";
            this.extract.UseVisualStyleBackColor = true;
            this.extract.Click += new System.EventHandler(this.Button2_Click);
            // 
            // inject
            // 
            this.inject.Location = new System.Drawing.Point(435, 46);
            this.inject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inject.Name = "inject";
            this.inject.Size = new System.Drawing.Size(134, 41);
            this.inject.TabIndex = 16;
            this.inject.Text = "Inject";
            this.inject.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(483, 92);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(399, 612);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button4, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.button5, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.button3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button7, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.button6, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(483, 712);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(399, 199);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(156, 4);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 29);
            this.button2.TabIndex = 0;
            this.button2.Text = "^";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(156, 154);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 29);
            this.button4.TabIndex = 2;
            this.button4.Text = "~";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(249, 84);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 29);
            this.button5.TabIndex = 3;
            this.button5.Text = ">";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 84);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 29);
            this.button3.TabIndex = 1;
            this.button3.Text = "<";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(156, 122);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(22, 24);
            this.button7.TabIndex = 5;
            this.button7.Text = "-";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(156, 52);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(22, 24);
            this.button6.TabIndex = 4;
            this.button6.Text = "+";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // costCodeTextBox
            // 
            this.costCodeTextBox.Location = new System.Drawing.Point(904, 406);
            this.costCodeTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.costCodeTextBox.Name = "costCodeTextBox";
            this.costCodeTextBox.Size = new System.Drawing.Size(148, 26);
            this.costCodeTextBox.TabIndex = 19;
            // 
            // costCode
            // 
            this.costCode.AutoSize = true;
            this.costCode.Location = new System.Drawing.Point(901, 381);
            this.costCode.Name = "costCode";
            this.costCode.Size = new System.Drawing.Size(84, 20);
            this.costCode.TabIndex = 20;
            this.costCode.Text = "Cost Code";
            this.costCode.Click += new System.EventHandler(this.costCode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1124, 968);
            this.Controls.Add(this.costCode);
            this.Controls.Add(this.costCodeTextBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.inject);
            this.Controls.Add(this.extract);
            this.Controls.Add(this.invoiceNumTextBox);
            this.Controls.Add(this.invoiceNum);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.assignTo);
            this.Controls.Add(this.project);
            this.Controls.Add(this.projectTextBox);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.date);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.title);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "/";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label amount;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.TextBox projectTextBox;
        private System.Windows.Forms.Label project;
        private System.Windows.Forms.Label assignTo;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label invoiceNum;
        private System.Windows.Forms.TextBox invoiceNumTextBox;
        private System.Windows.Forms.Button extract;
        private System.Windows.Forms.Button inject;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox costCodeTextBox;
        private System.Windows.Forms.Label costCode;
    }
}

