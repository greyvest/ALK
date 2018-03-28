namespace SpreadsheetGUI
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
            this.spreadsheetPanel1 = new SS.SpreadsheetPanel();
            this.cell_name_textbox = new System.Windows.Forms.TextBox();
            this.cell_value_textbox = new System.Windows.Forms.TextBox();
            this.cell_content_textbox = new System.Windows.Forms.TextBox();
            this.cell_name_label = new System.Windows.Forms.Label();
            this.cell_value_label = new System.Windows.Forms.Label();
            this.cell_content_label = new System.Windows.Forms.Label();
            this.content_enter_button = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penguinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penguinToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.slothToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.justDoItToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.landSharkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.landsharkToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.doggieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Pony = new System.Windows.Forms.PictureBox();
            this.Doggie = new System.Windows.Forms.PictureBox();
            this.JustDoIt = new System.Windows.Forms.PictureBox();
            this.Sloth = new System.Windows.Forms.PictureBox();
            this.LandShark = new System.Windows.Forms.PictureBox();
            this.PenguinGif = new System.Windows.Forms.PictureBox();
            this.ponyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pony)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Doggie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JustDoIt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sloth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LandShark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PenguinGif)).BeginInit();
            this.SuspendLayout();
            // 
            // spreadsheetPanel1
            // 
            this.spreadsheetPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spreadsheetPanel1.Location = new System.Drawing.Point(15, 82);
            this.spreadsheetPanel1.Name = "spreadsheetPanel1";
            this.spreadsheetPanel1.Size = new System.Drawing.Size(683, 383);
            this.spreadsheetPanel1.TabIndex = 0;
            // 
            // cell_name_textbox
            // 
            this.cell_name_textbox.Location = new System.Drawing.Point(76, 40);
            this.cell_name_textbox.Name = "cell_name_textbox";
            this.cell_name_textbox.ReadOnly = true;
            this.cell_name_textbox.Size = new System.Drawing.Size(100, 20);
            this.cell_name_textbox.TabIndex = 1;
            // 
            // cell_value_textbox
            // 
            this.cell_value_textbox.Location = new System.Drawing.Point(245, 40);
            this.cell_value_textbox.Name = "cell_value_textbox";
            this.cell_value_textbox.ReadOnly = true;
            this.cell_value_textbox.Size = new System.Drawing.Size(100, 20);
            this.cell_value_textbox.TabIndex = 2;
            // 
            // cell_content_textbox
            // 
            this.cell_content_textbox.Location = new System.Drawing.Point(425, 40);
            this.cell_content_textbox.Name = "cell_content_textbox";
            this.cell_content_textbox.Size = new System.Drawing.Size(100, 20);
            this.cell_content_textbox.TabIndex = 3;
            this.cell_content_textbox.TextChanged += new System.EventHandler(this.cell_content_textbox_TextChanged);
            // 
            // cell_name_label
            // 
            this.cell_name_label.AutoSize = true;
            this.cell_name_label.Location = new System.Drawing.Point(12, 43);
            this.cell_name_label.Name = "cell_name_label";
            this.cell_name_label.Size = new System.Drawing.Size(58, 13);
            this.cell_name_label.TabIndex = 4;
            this.cell_name_label.Text = "Cell Name:";
            // 
            // cell_value_label
            // 
            this.cell_value_label.AutoSize = true;
            this.cell_value_label.Location = new System.Drawing.Point(202, 43);
            this.cell_value_label.Name = "cell_value_label";
            this.cell_value_label.Size = new System.Drawing.Size(37, 13);
            this.cell_value_label.TabIndex = 5;
            this.cell_value_label.Text = "Value:";
            // 
            // cell_content_label
            // 
            this.cell_content_label.AutoSize = true;
            this.cell_content_label.Location = new System.Drawing.Point(372, 43);
            this.cell_content_label.Name = "cell_content_label";
            this.cell_content_label.Size = new System.Drawing.Size(47, 13);
            this.cell_content_label.TabIndex = 6;
            this.cell_content_label.Text = "Content:";
            // 
            // content_enter_button
            // 
            this.content_enter_button.Location = new System.Drawing.Point(569, 38);
            this.content_enter_button.Name = "content_enter_button";
            this.content_enter_button.Size = new System.Drawing.Size(75, 23);
            this.content_enter_button.TabIndex = 7;
            this.content_enter_button.Text = "Enter";
            this.content_enter_button.UseVisualStyleBackColor = true;
            this.content_enter_button.Click += new System.EventHandler(this.content_enter_button_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.funToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(694, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.new_spreadsheet_click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.Save_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.Open_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.Close_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.Help_Clicked);
            // 
            // funToolStripMenuItem
            // 
            this.funToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.penguinToolStripMenuItem,
            this.landSharkToolStripMenuItem});
            this.funToolStripMenuItem.Name = "funToolStripMenuItem";
            this.funToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.funToolStripMenuItem.Text = "Need a boost?";
            // 
            // penguinToolStripMenuItem
            // 
            this.penguinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.penguinToolStripMenuItem1,
            this.slothToolStripMenuItem,
            this.justDoItToolStripMenuItem});
            this.penguinToolStripMenuItem.Name = "penguinToolStripMenuItem";
            this.penguinToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.penguinToolStripMenuItem.Text = "Motivational";
            // 
            // penguinToolStripMenuItem1
            // 
            this.penguinToolStripMenuItem1.Name = "penguinToolStripMenuItem1";
            this.penguinToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.penguinToolStripMenuItem1.Text = "Penguin";
            this.penguinToolStripMenuItem1.Click += new System.EventHandler(this.PenguinClickEvent);
            // 
            // slothToolStripMenuItem
            // 
            this.slothToolStripMenuItem.Name = "slothToolStripMenuItem";
            this.slothToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.slothToolStripMenuItem.Text = "Sloth";
            this.slothToolStripMenuItem.Click += new System.EventHandler(this.SlothClickEvent);
            // 
            // justDoItToolStripMenuItem
            // 
            this.justDoItToolStripMenuItem.Name = "justDoItToolStripMenuItem";
            this.justDoItToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.justDoItToolStripMenuItem.Text = "Just Do It!";
            this.justDoItToolStripMenuItem.Click += new System.EventHandler(this.JustDoItClickEvent);
            // 
            // landSharkToolStripMenuItem
            // 
            this.landSharkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.landsharkToolStripMenuItem1,
            this.doggieToolStripMenuItem,
            this.ponyToolStripMenuItem});
            this.landSharkToolStripMenuItem.Name = "landSharkToolStripMenuItem";
            this.landSharkToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.landSharkToolStripMenuItem.Text = "Funny";
            // 
            // landsharkToolStripMenuItem1
            // 
            this.landsharkToolStripMenuItem1.Name = "landsharkToolStripMenuItem1";
            this.landsharkToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.landsharkToolStripMenuItem1.Text = "Landshark";
            this.landsharkToolStripMenuItem1.Click += new System.EventHandler(this.LandSharkClickEvent);
            // 
            // doggieToolStripMenuItem
            // 
            this.doggieToolStripMenuItem.Name = "doggieToolStripMenuItem";
            this.doggieToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.doggieToolStripMenuItem.Text = "Doggie";
            this.doggieToolStripMenuItem.Click += new System.EventHandler(this.DoggieClickEvent);
            // 
            // Pony
            // 
            this.Pony.Image = global::SpreadsheetGUI.Properties.Resources.IMG_1814;
            this.Pony.Location = new System.Drawing.Point(76, 27);
            this.Pony.Name = "Pony";
            this.Pony.Size = new System.Drawing.Size(560, 315);
            this.Pony.TabIndex = 15;
            this.Pony.TabStop = false;
            this.Pony.Visible = false;
            this.Pony.Click += new System.EventHandler(this.ClickedPonyGIF);
            // 
            // Doggie
            // 
            this.Doggie.Image = global::SpreadsheetGUI.Properties.Resources.IMG_7839;
            this.Doggie.Location = new System.Drawing.Point(234, 66);
            this.Doggie.Name = "Doggie";
            this.Doggie.Size = new System.Drawing.Size(236, 256);
            this.Doggie.TabIndex = 14;
            this.Doggie.TabStop = false;
            this.Doggie.Visible = false;
            this.Doggie.Click += new System.EventHandler(this.ClickedDoggieGif);
            // 
            // JustDoIt
            // 
            this.JustDoIt.Image = global::SpreadsheetGUI.Properties.Resources.IMG_7837;
            this.JustDoIt.Location = new System.Drawing.Point(205, 43);
            this.JustDoIt.Name = "JustDoIt";
            this.JustDoIt.Size = new System.Drawing.Size(265, 200);
            this.JustDoIt.TabIndex = 13;
            this.JustDoIt.TabStop = false;
            this.JustDoIt.Visible = false;
            this.JustDoIt.Click += new System.EventHandler(this.ClickedJustDoItGIF);
            // 
            // Sloth
            // 
            this.Sloth.Image = global::SpreadsheetGUI.Properties.Resources.IMG_7838;
            this.Sloth.Location = new System.Drawing.Point(172, 59);
            this.Sloth.Name = "Sloth";
            this.Sloth.Size = new System.Drawing.Size(353, 200);
            this.Sloth.TabIndex = 12;
            this.Sloth.TabStop = false;
            this.Sloth.Visible = false;
            this.Sloth.Click += new System.EventHandler(this.ClickedSlothGIF);
            // 
            // LandShark
            // 
            this.LandShark.Image = global::SpreadsheetGUI.Properties.Resources.IMG_7836;
            this.LandShark.InitialImage = null;
            this.LandShark.Location = new System.Drawing.Point(104, 43);
            this.LandShark.Name = "LandShark";
            this.LandShark.Size = new System.Drawing.Size(501, 279);
            this.LandShark.TabIndex = 11;
            this.LandShark.TabStop = false;
            this.LandShark.Visible = false;
            this.LandShark.Click += new System.EventHandler(this.ClickedLandSharkGIF);
            // 
            // PenguinGif
            // 
            this.PenguinGif.Image = global::SpreadsheetGUI.Properties.Resources.IMG_7835;
            this.PenguinGif.InitialImage = null;
            this.PenguinGif.Location = new System.Drawing.Point(172, 27);
            this.PenguinGif.Name = "PenguinGif";
            this.PenguinGif.Size = new System.Drawing.Size(353, 333);
            this.PenguinGif.TabIndex = 10;
            this.PenguinGif.TabStop = false;
            this.PenguinGif.Visible = false;
            this.PenguinGif.Click += new System.EventHandler(this.ClickedPenguinGIF);
            // 
            // ponyToolStripMenuItem
            // 
            this.ponyToolStripMenuItem.Name = "ponyToolStripMenuItem";
            this.ponyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ponyToolStripMenuItem.Text = "Pony";
            this.ponyToolStripMenuItem.Click += new System.EventHandler(this.PonyClickEvent);
            // 
            // Form1
            // 
            this.AcceptButton = this.content_enter_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 434);
            this.Controls.Add(this.Pony);
            this.Controls.Add(this.Doggie);
            this.Controls.Add(this.JustDoIt);
            this.Controls.Add(this.Sloth);
            this.Controls.Add(this.LandShark);
            this.Controls.Add(this.PenguinGif);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.content_enter_button);
            this.Controls.Add(this.cell_content_label);
            this.Controls.Add(this.cell_value_label);
            this.Controls.Add(this.cell_name_label);
            this.Controls.Add(this.cell_content_textbox);
            this.Controls.Add(this.cell_value_textbox);
            this.Controls.Add(this.cell_name_textbox);
            this.Controls.Add(this.spreadsheetPanel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pony)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Doggie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JustDoIt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sloth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LandShark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PenguinGif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SS.SpreadsheetPanel spreadsheetPanel1;
        private System.Windows.Forms.TextBox cell_name_textbox;
        private System.Windows.Forms.TextBox cell_value_textbox;
        private System.Windows.Forms.TextBox cell_content_textbox;
        private System.Windows.Forms.Label cell_name_label;
        private System.Windows.Forms.Label cell_value_label;
        private System.Windows.Forms.Label cell_content_label;
        private System.Windows.Forms.Button content_enter_button;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.PictureBox PenguinGif;
        private System.Windows.Forms.PictureBox LandShark;
        private System.Windows.Forms.ToolStripMenuItem funToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penguinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem landSharkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penguinToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem landsharkToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem slothToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem justDoItToolStripMenuItem;
        private System.Windows.Forms.PictureBox Sloth;
        private System.Windows.Forms.PictureBox JustDoIt;
        private System.Windows.Forms.PictureBox Doggie;
        private System.Windows.Forms.ToolStripMenuItem doggieToolStripMenuItem;
        private System.Windows.Forms.PictureBox Pony;
        private System.Windows.Forms.ToolStripMenuItem ponyToolStripMenuItem;
    }
}

