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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.invoiceNum = new System.Windows.Forms.Label();
            this.invoiceNumTextBox = new System.Windows.Forms.TextBox();
            this.extract = new System.Windows.Forms.Button();
            this.inject = new System.Windows.Forms.Button();
            this.costCodeTextBox = new System.Windows.Forms.TextBox();
            this.costCode = new System.Windows.Forms.Label();
            this.assignToComboBox = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Sub = new System.Windows.Forms.Label();
            this.subComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.goButton = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.stateTestBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(817, 180);
            this.textBox1.TabIndex = 2;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(904, 92);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(27, 13);
            this.title.TabIndex = 3;
            this.title.Text = "Title";
            this.title.Click += new System.EventHandler(this.Label1_Click);
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.Location = new System.Drawing.Point(904, 223);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(43, 13);
            this.amount.TabIndex = 4;
            this.amount.Text = "Amount";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(901, 291);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(30, 13);
            this.date.TabIndex = 5;
            this.date.Text = "Date";
            this.date.Click += new System.EventHandler(this.label3_Click);
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(904, 110);
            this.titleTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(148, 20);
            this.titleTextBox.TabIndex = 6;
            this.titleTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(904, 252);
            this.amountTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(148, 20);
            this.amountTextBox.TabIndex = 7;
            this.amountTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(904, 320);
            this.dateTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(148, 20);
            this.dateTextBox.TabIndex = 8;
            // 
            // projectTextBox
            // 
            this.projectTextBox.Location = new System.Drawing.Point(904, 428);
            this.projectTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.projectTextBox.Name = "projectTextBox";
            this.projectTextBox.Size = new System.Drawing.Size(148, 20);
            this.projectTextBox.TabIndex = 9;
            // 
            // project
            // 
            this.project.AutoSize = true;
            this.project.Location = new System.Drawing.Point(901, 411);
            this.project.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.project.Name = "project";
            this.project.Size = new System.Drawing.Size(40, 13);
            this.project.TabIndex = 10;
            this.project.Text = "Project";
            this.project.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // assignTo
            // 
            this.assignTo.AutoSize = true;
            this.assignTo.Location = new System.Drawing.Point(904, 463);
            this.assignTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.assignTo.Name = "assignTo";
            this.assignTo.Size = new System.Drawing.Size(56, 13);
            this.assignTo.TabIndex = 11;
            this.assignTo.Text = "Assign to :";
            // 
            // invoiceNum
            // 
            this.invoiceNum.AutoSize = true;
            this.invoiceNum.Location = new System.Drawing.Point(904, 173);
            this.invoiceNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.invoiceNum.Name = "invoiceNum";
            this.invoiceNum.Size = new System.Drawing.Size(62, 13);
            this.invoiceNum.TabIndex = 13;
            this.invoiceNum.Text = "Invoice No.";
            this.invoiceNum.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // invoiceNumTextBox
            // 
            this.invoiceNumTextBox.Location = new System.Drawing.Point(904, 194);
            this.invoiceNumTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.invoiceNumTextBox.Name = "invoiceNumTextBox";
            this.invoiceNumTextBox.Size = new System.Drawing.Size(148, 20);
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
            this.inject.Text = "Add to List";
            this.inject.UseVisualStyleBackColor = true;
            this.inject.Click += new System.EventHandler(this.inject_Click);
            // 
            // costCodeTextBox
            // 
            this.costCodeTextBox.Location = new System.Drawing.Point(904, 376);
            this.costCodeTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.costCodeTextBox.Name = "costCodeTextBox";
            this.costCodeTextBox.Size = new System.Drawing.Size(148, 20);
            this.costCodeTextBox.TabIndex = 19;
            // 
            // costCode
            // 
            this.costCode.AutoSize = true;
            this.costCode.Location = new System.Drawing.Point(901, 350);
            this.costCode.Name = "costCode";
            this.costCode.Size = new System.Drawing.Size(56, 13);
            this.costCode.TabIndex = 20;
            this.costCode.Text = "Cost Code";
            this.costCode.Click += new System.EventHandler(this.costCode_Click);
            // 
            // assignToComboBox
            // 
            this.assignToComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.assignToComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.assignToComboBox.FormattingEnabled = true;
            this.assignToComboBox.Items.AddRange(new object[] {
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
            this.assignToComboBox.Location = new System.Drawing.Point(904, 492);
            this.assignToComboBox.Name = "assignToComboBox";
            this.assignToComboBox.Size = new System.Drawing.Size(148, 21);
            this.assignToComboBox.TabIndex = 21;
            this.assignToComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1142, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(45, 277);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 24;
            // 
            // Sub
            // 
            this.Sub.AutoSize = true;
            this.Sub.Location = new System.Drawing.Point(904, 135);
            this.Sub.Name = "Sub";
            this.Sub.Size = new System.Drawing.Size(26, 13);
            this.Sub.TabIndex = 25;
            this.Sub.Text = "Sub";
            this.Sub.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // subComboBox
            // 
            this.subComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.subComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.subComboBox.FormattingEnabled = true;
            this.subComboBox.Items.AddRange(new object[] {
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
            this.subComboBox.Location = new System.Drawing.Point(904, 151);
            this.subComboBox.Name = "subComboBox";
            this.subComboBox.Size = new System.Drawing.Size(148, 21);
            this.subComboBox.TabIndex = 26;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 320);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(817, 150);
            this.dataGridView1.TabIndex = 27;
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(170, 277);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(75, 23);
            this.goButton.TabIndex = 28;
            this.goButton.Text = "List";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(275, 278);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 29;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // stateTestBox
            // 
            this.stateTestBox.Location = new System.Drawing.Point(471, 279);
            this.stateTestBox.Name = "stateTestBox";
            this.stateTestBox.Size = new System.Drawing.Size(223, 20);
            this.stateTestBox.TabIndex = 30;
            this.stateTestBox.Text = "Done | Queue";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(366, 277);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 31;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScrollMargin = new System.Drawing.Size(10, 0);
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(1142, 572);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.stateTestBox);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.subComboBox);
            this.Controls.Add(this.Sub);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.assignToComboBox);
            this.Controls.Add(this.costCode);
            this.Controls.Add(this.costCodeTextBox);
            this.Controls.Add(this.inject);
            this.Controls.Add(this.extract);
            this.Controls.Add(this.invoiceNumTextBox);
            this.Controls.Add(this.invoiceNum);
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
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automate";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Label invoiceNum;
        private System.Windows.Forms.TextBox invoiceNumTextBox;
        private System.Windows.Forms.Button extract;
        private System.Windows.Forms.Button inject;
        private System.Windows.Forms.TextBox costCodeTextBox;
        private System.Windows.Forms.Label costCode;
        private System.Windows.Forms.ComboBox assignToComboBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label Sub;
        private System.Windows.Forms.ComboBox subComboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TextBox stateTestBox;
        private System.Windows.Forms.Button startButton;
    }
}

