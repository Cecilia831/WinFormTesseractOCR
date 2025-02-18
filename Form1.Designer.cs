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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Sub = new System.Windows.Forms.Label();
            this.subComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.goButton = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.stateTestBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.buttonClearItem = new System.Windows.Forms.Button();
            this.buttonResume = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteProjectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vendorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newVendorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteVendorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.costCodeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newProjectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteProjectToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 36);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open PDF";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 85);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(1224, 268);
            this.textBox1.TabIndex = 2;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(1291, 58);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(38, 20);
            this.title.TabIndex = 3;
            this.title.Text = "Title";
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.Location = new System.Drawing.Point(1291, 254);
            this.amount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(65, 20);
            this.amount.TabIndex = 4;
            this.amount.Text = "Amount";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(1291, 372);
            this.date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(44, 20);
            this.date.TabIndex = 5;
            this.date.Text = "Date";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(1291, 85);
            this.titleTextBox.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(220, 26);
            this.titleTextBox.TabIndex = 6;
            this.titleTextBox.TextChanged += new System.EventHandler(this.titleTextBox_TextChanged);
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(1291, 298);
            this.amountTextBox.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(220, 26);
            this.amountTextBox.TabIndex = 7;
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(1291, 400);
            this.dateTextBox.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(220, 26);
            this.dateTextBox.TabIndex = 8;
            // 
            // projectTextBox
            // 
            this.projectTextBox.Location = new System.Drawing.Point(1291, 562);
            this.projectTextBox.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.projectTextBox.Name = "projectTextBox";
            this.projectTextBox.Size = new System.Drawing.Size(220, 26);
            this.projectTextBox.TabIndex = 9;
            // 
            // project
            // 
            this.project.AutoSize = true;
            this.project.Location = new System.Drawing.Point(1287, 536);
            this.project.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.project.Name = "project";
            this.project.Size = new System.Drawing.Size(58, 20);
            this.project.TabIndex = 10;
            this.project.Text = "Project";
            // 
            // assignTo
            // 
            this.assignTo.AutoSize = true;
            this.assignTo.Location = new System.Drawing.Point(1291, 615);
            this.assignTo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.assignTo.Name = "assignTo";
            this.assignTo.Size = new System.Drawing.Size(83, 20);
            this.assignTo.TabIndex = 11;
            this.assignTo.Text = "Assign to :";
            // 
            // invoiceNum
            // 
            this.invoiceNum.AutoSize = true;
            this.invoiceNum.Location = new System.Drawing.Point(1291, 180);
            this.invoiceNum.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.invoiceNum.Name = "invoiceNum";
            this.invoiceNum.Size = new System.Drawing.Size(87, 20);
            this.invoiceNum.TabIndex = 13;
            this.invoiceNum.Text = "Invoice No.";
            // 
            // invoiceNumTextBox
            // 
            this.invoiceNumTextBox.Location = new System.Drawing.Point(1291, 211);
            this.invoiceNumTextBox.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.invoiceNumTextBox.Name = "invoiceNumTextBox";
            this.invoiceNumTextBox.Size = new System.Drawing.Size(220, 26);
            this.invoiceNumTextBox.TabIndex = 14;
            this.invoiceNumTextBox.TextChanged += new System.EventHandler(this.invoiceNumTextBox_TextChanged);
            // 
            // extract
            // 
            this.extract.Location = new System.Drawing.Point(216, 36);
            this.extract.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.extract.Name = "extract";
            this.extract.Size = new System.Drawing.Size(173, 40);
            this.extract.TabIndex = 15;
            this.extract.Text = "Extract";
            this.extract.UseVisualStyleBackColor = true;
            this.extract.Click += new System.EventHandler(this.Button2_Click);
            // 
            // inject
            // 
            this.inject.Location = new System.Drawing.Point(417, 36);
            this.inject.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.inject.Name = "inject";
            this.inject.Size = new System.Drawing.Size(175, 40);
            this.inject.TabIndex = 16;
            this.inject.Text = "Add to List";
            this.inject.UseVisualStyleBackColor = true;
            this.inject.Click += new System.EventHandler(this.inject_Click);
            // 
            // costCodeTextBox
            // 
            this.costCodeTextBox.Location = new System.Drawing.Point(1291, 484);
            this.costCodeTextBox.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.costCodeTextBox.Name = "costCodeTextBox";
            this.costCodeTextBox.Size = new System.Drawing.Size(220, 26);
            this.costCodeTextBox.TabIndex = 19;
            // 
            // costCode
            // 
            this.costCode.AutoSize = true;
            this.costCode.Location = new System.Drawing.Point(1287, 445);
            this.costCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.costCode.Name = "costCode";
            this.costCode.Size = new System.Drawing.Size(84, 20);
            this.costCode.TabIndex = 20;
            this.costCode.Text = "Cost Code";
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
            this.assignToComboBox.Location = new System.Drawing.Point(1291, 639);
            this.assignToComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.assignToComboBox.Name = "assignToComboBox";
            this.assignToComboBox.Size = new System.Drawing.Size(220, 28);
            this.assignToComboBox.TabIndex = 21;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 398);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(150, 34);
            this.progressBar1.TabIndex = 24;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // Sub
            // 
            this.Sub.AutoSize = true;
            this.Sub.Location = new System.Drawing.Point(1291, 122);
            this.Sub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Sub.Name = "Sub";
            this.Sub.Size = new System.Drawing.Size(38, 20);
            this.Sub.TabIndex = 25;
            this.Sub.Text = "Sub";
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
            this.subComboBox.Location = new System.Drawing.Point(1291, 146);
            this.subComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.subComboBox.Name = "subComboBox";
            this.subComboBox.Size = new System.Drawing.Size(220, 28);
            this.subComboBox.TabIndex = 26;
            this.subComboBox.SelectedIndexChanged += new System.EventHandler(this.subComboBox_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 476);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1224, 268);
            this.dataGridView1.TabIndex = 27;
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(200, 398);
            this.goButton.Margin = new System.Windows.Forms.Padding(4);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(112, 34);
            this.goButton.TabIndex = 28;
            this.goButton.Text = "List";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(634, 398);
            this.delete.Margin = new System.Windows.Forms.Padding(4);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(112, 34);
            this.delete.TabIndex = 29;
            this.delete.Text = "Clear";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // stateTestBox
            // 
            this.stateTestBox.Location = new System.Drawing.Point(919, 406);
            this.stateTestBox.Margin = new System.Windows.Forms.Padding(4);
            this.stateTestBox.Name = "stateTestBox";
            this.stateTestBox.Size = new System.Drawing.Size(240, 26);
            this.stateTestBox.TabIndex = 30;
            this.stateTestBox.Text = "Done | Queue";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(776, 398);
            this.startButton.Margin = new System.Windows.Forms.Padding(4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(112, 34);
            this.startButton.TabIndex = 31;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // buttonClearItem
            // 
            this.buttonClearItem.Location = new System.Drawing.Point(621, 36);
            this.buttonClearItem.Name = "buttonClearItem";
            this.buttonClearItem.Size = new System.Drawing.Size(175, 40);
            this.buttonClearItem.TabIndex = 32;
            this.buttonClearItem.Text = "Clear Item";
            this.buttonClearItem.UseVisualStyleBackColor = true;
            // 
            // buttonResume
            // 
            this.buttonResume.Location = new System.Drawing.Point(346, 398);
            this.buttonResume.Name = "buttonResume";
            this.buttonResume.Size = new System.Drawing.Size(112, 34);
            this.buttonResume.TabIndex = 33;
            this.buttonResume.Text = "Resume";
            this.buttonResume.UseVisualStyleBackColor = true;
            this.buttonResume.Click += new System.EventHandler(this.buttonResume_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(489, 398);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(112, 34);
            this.buttonDelete.TabIndex = 34;
            this.buttonDelete.Text = "Delete Last";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(1291, 690);
            this.labelAddress.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(68, 20);
            this.labelAddress.TabIndex = 36;
            this.labelAddress.Text = "Address";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(1291, 718);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(220, 26);
            this.textBoxAddress.TabIndex = 35;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectToolStripMenuItem,
            this.vendorToolStripMenuItem1,
            this.costCodeToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1628, 33);
            this.menuStrip1.TabIndex = 38;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProjectToolStripMenuItem,
            this.deleteProjectToolStripMenuItem});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(82, 29);
            this.projectToolStripMenuItem.Text = "Project";
            // 
            // newProjectToolStripMenuItem
            // 
            this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(223, 34);
            this.newProjectToolStripMenuItem.Text = "New Project";
            // 
            // deleteProjectToolStripMenuItem
            // 
            this.deleteProjectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.deleteProjectToolStripMenuItem1});
            this.deleteProjectToolStripMenuItem.Name = "deleteProjectToolStripMenuItem";
            this.deleteProjectToolStripMenuItem.Size = new System.Drawing.Size(223, 34);
            this.deleteProjectToolStripMenuItem.Text = "Delete Project";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(286, 34);
            this.deleteToolStripMenuItem.Text = "Delete Current Project";
            // 
            // deleteProjectToolStripMenuItem1
            // 
            this.deleteProjectToolStripMenuItem1.Name = "deleteProjectToolStripMenuItem1";
            this.deleteProjectToolStripMenuItem1.Size = new System.Drawing.Size(286, 34);
            this.deleteProjectToolStripMenuItem1.Text = "Delete Project";
            // 
            // vendorToolStripMenuItem1
            // 
            this.vendorToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newVendorToolStripMenuItem,
            this.deleteVendorToolStripMenuItem});
            this.vendorToolStripMenuItem1.Name = "vendorToolStripMenuItem1";
            this.vendorToolStripMenuItem1.Size = new System.Drawing.Size(85, 29);
            this.vendorToolStripMenuItem1.Text = "Vendor";
            // 
            // newVendorToolStripMenuItem
            // 
            this.newVendorToolStripMenuItem.Name = "newVendorToolStripMenuItem";
            this.newVendorToolStripMenuItem.Size = new System.Drawing.Size(226, 34);
            this.newVendorToolStripMenuItem.Text = "New Vendor";
            // 
            // deleteVendorToolStripMenuItem
            // 
            this.deleteVendorToolStripMenuItem.Name = "deleteVendorToolStripMenuItem";
            this.deleteVendorToolStripMenuItem.Size = new System.Drawing.Size(226, 34);
            this.deleteVendorToolStripMenuItem.Text = "Delete Vendor";
            // 
            // costCodeToolStripMenuItem1
            // 
            this.costCodeToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProjectToolStripMenuItem1,
            this.deleteProjectToolStripMenuItem2});
            this.costCodeToolStripMenuItem1.Name = "costCodeToolStripMenuItem1";
            this.costCodeToolStripMenuItem1.Size = new System.Drawing.Size(111, 29);
            this.costCodeToolStripMenuItem1.Text = "Cost Code";
            this.costCodeToolStripMenuItem1.Click += new System.EventHandler(this.costCodeToolStripMenuItem1_Click);
            // 
            // newProjectToolStripMenuItem1
            // 
            this.newProjectToolStripMenuItem1.Name = "newProjectToolStripMenuItem1";
            this.newProjectToolStripMenuItem1.Size = new System.Drawing.Size(223, 34);
            this.newProjectToolStripMenuItem1.Text = "New Project";
            // 
            // deleteProjectToolStripMenuItem2
            // 
            this.deleteProjectToolStripMenuItem2.Name = "deleteProjectToolStripMenuItem2";
            this.deleteProjectToolStripMenuItem2.Size = new System.Drawing.Size(223, 34);
            this.deleteProjectToolStripMenuItem2.Text = "Delete Project";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScrollMargin = new System.Drawing.Size(10, 0);
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(1628, 786);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonResume);
            this.Controls.Add(this.buttonClearItem);
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
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automate";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label Sub;
        private System.Windows.Forms.ComboBox subComboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TextBox stateTestBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button buttonClearItem;
        private System.Windows.Forms.Button buttonResume;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem costCodeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteProjectToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newVendorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteVendorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteProjectToolStripMenuItem2;
    }
}

