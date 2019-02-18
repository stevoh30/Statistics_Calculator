namespace Statistics_Calculator
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxSelectList = new System.Windows.Forms.GroupBox();
            this.radioBtnDisplay2 = new System.Windows.Forms.RadioButton();
            this.radioBtnDisplay1 = new System.Windows.Forms.RadioButton();
            this.btnDispAvg = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.richTxtDataDisplay = new System.Windows.Forms.RichTextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxCreateList = new System.Windows.Forms.GroupBox();
            this.radioBtnCList2 = new System.Windows.Forms.RadioButton();
            this.radioBtnCList1 = new System.Windows.Forms.RadioButton();
            this.Label1 = new System.Windows.Forms.Label();
            this.richTxtData = new System.Windows.Forms.RichTextBox();
            this.btnCreateList = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBtnSelect2 = new System.Windows.Forms.RadioButton();
            this.radioBtnSelect1 = new System.Windows.Forms.RadioButton();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.txtAddValue = new System.Windows.Forms.TextBox();
            this.btnRemoveValue = new System.Windows.Forms.Button();
            this.btnAddValue = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel2.SuspendLayout();
            this.groupBoxSelectList.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxCreateList.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.groupBoxSelectList);
            this.panel2.Controls.Add(this.btnDispAvg);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.richTxtDataDisplay);
            this.panel2.Location = new System.Drawing.Point(287, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(209, 450);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Listbox Properties";
            // 
            // groupBoxSelectList
            // 
            this.groupBoxSelectList.Controls.Add(this.radioBtnDisplay2);
            this.groupBoxSelectList.Controls.Add(this.radioBtnDisplay1);
            this.groupBoxSelectList.Location = new System.Drawing.Point(14, 268);
            this.groupBoxSelectList.Name = "groupBoxSelectList";
            this.groupBoxSelectList.Size = new System.Drawing.Size(181, 44);
            this.groupBoxSelectList.TabIndex = 5;
            this.groupBoxSelectList.TabStop = false;
            // 
            // radioBtnDisplay2
            // 
            this.radioBtnDisplay2.AutoSize = true;
            this.radioBtnDisplay2.Location = new System.Drawing.Point(86, 19);
            this.radioBtnDisplay2.Name = "radioBtnDisplay2";
            this.radioBtnDisplay2.Size = new System.Drawing.Size(50, 17);
            this.radioBtnDisplay2.TabIndex = 1;
            this.radioBtnDisplay2.TabStop = true;
            this.radioBtnDisplay2.Text = "List 2";
            this.radioBtnDisplay2.UseVisualStyleBackColor = true;
            // 
            // radioBtnDisplay1
            // 
            this.radioBtnDisplay1.AutoSize = true;
            this.radioBtnDisplay1.Location = new System.Drawing.Point(30, 19);
            this.radioBtnDisplay1.Name = "radioBtnDisplay1";
            this.radioBtnDisplay1.Size = new System.Drawing.Size(50, 17);
            this.radioBtnDisplay1.TabIndex = 0;
            this.radioBtnDisplay1.TabStop = true;
            this.radioBtnDisplay1.Text = "List 1";
            this.radioBtnDisplay1.UseVisualStyleBackColor = true;
            // 
            // btnDispAvg
            // 
            this.btnDispAvg.Location = new System.Drawing.Point(14, 321);
            this.btnDispAvg.Name = "btnDispAvg";
            this.btnDispAvg.Size = new System.Drawing.Size(181, 42);
            this.btnDispAvg.TabIndex = 4;
            this.btnDispAvg.Text = "Display Properties";
            this.btnDispAvg.UseVisualStyleBackColor = true;
            this.btnDispAvg.Click += new System.EventHandler(this.btnDispAvg_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(14, 369);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(181, 41);
            this.button4.TabIndex = 3;
            this.button4.Text = "Delete List";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // richTxtDataDisplay
            // 
            this.richTxtDataDisplay.Location = new System.Drawing.Point(14, 34);
            this.richTxtDataDisplay.Name = "richTxtDataDisplay";
            this.richTxtDataDisplay.Size = new System.Drawing.Size(181, 235);
            this.richTxtDataDisplay.TabIndex = 4;
            this.richTxtDataDisplay.Text = "";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(266, 454);
            this.tabControl.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(258, 428);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Create List";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBoxCreateList);
            this.panel1.Controls.Add(this.Label1);
            this.panel1.Controls.Add(this.richTxtData);
            this.panel1.Controls.Add(this.btnCreateList);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 471);
            this.panel1.TabIndex = 2;
            // 
            // groupBoxCreateList
            // 
            this.groupBoxCreateList.Controls.Add(this.radioBtnCList2);
            this.groupBoxCreateList.Controls.Add(this.radioBtnCList1);
            this.groupBoxCreateList.Location = new System.Drawing.Point(11, 313);
            this.groupBoxCreateList.Name = "groupBoxCreateList";
            this.groupBoxCreateList.Size = new System.Drawing.Size(221, 40);
            this.groupBoxCreateList.TabIndex = 3;
            this.groupBoxCreateList.TabStop = false;
            this.groupBoxCreateList.Text = "Create List";
            // 
            // radioBtnCList2
            // 
            this.radioBtnCList2.AutoSize = true;
            this.radioBtnCList2.Location = new System.Drawing.Point(105, 17);
            this.radioBtnCList2.Name = "radioBtnCList2";
            this.radioBtnCList2.Size = new System.Drawing.Size(50, 17);
            this.radioBtnCList2.TabIndex = 5;
            this.radioBtnCList2.TabStop = true;
            this.radioBtnCList2.Text = "List 2";
            this.radioBtnCList2.UseVisualStyleBackColor = true;
            // 
            // radioBtnCList1
            // 
            this.radioBtnCList1.AutoSize = true;
            this.radioBtnCList1.Location = new System.Drawing.Point(49, 17);
            this.radioBtnCList1.Name = "radioBtnCList1";
            this.radioBtnCList1.Size = new System.Drawing.Size(50, 17);
            this.radioBtnCList1.TabIndex = 4;
            this.radioBtnCList1.TabStop = true;
            this.radioBtnCList1.Text = "List 1";
            this.radioBtnCList1.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(20, 13);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(193, 26);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Create a list of values with a \" \" \r\nseperator in between values.";
            // 
            // richTxtData
            // 
            this.richTxtData.Location = new System.Drawing.Point(11, 54);
            this.richTxtData.Name = "richTxtData";
            this.richTxtData.Size = new System.Drawing.Size(221, 252);
            this.richTxtData.TabIndex = 0;
            this.richTxtData.Text = "";
            // 
            // btnCreateList
            // 
            this.btnCreateList.Location = new System.Drawing.Point(12, 359);
            this.btnCreateList.Name = "btnCreateList";
            this.btnCreateList.Size = new System.Drawing.Size(220, 48);
            this.btnCreateList.TabIndex = 1;
            this.btnCreateList.Text = "Create List of Data";
            this.btnCreateList.UseVisualStyleBackColor = true;
            this.btnCreateList.Click += new System.EventHandler(this.btnCreateList_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.listBox2);
            this.tabPage2.Controls.Add(this.txtAddValue);
            this.tabPage2.Controls.Add(this.btnRemoveValue);
            this.tabPage2.Controls.Add(this.btnAddValue);
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(258, 428);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Selected List";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtnSelect2);
            this.groupBox1.Controls.Add(this.radioBtnSelect1);
            this.groupBox1.Location = new System.Drawing.Point(6, 295);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 47);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select List";
            // 
            // radioBtnSelect2
            // 
            this.radioBtnSelect2.AutoSize = true;
            this.radioBtnSelect2.Location = new System.Drawing.Point(158, 19);
            this.radioBtnSelect2.Name = "radioBtnSelect2";
            this.radioBtnSelect2.Size = new System.Drawing.Size(50, 17);
            this.radioBtnSelect2.TabIndex = 1;
            this.radioBtnSelect2.TabStop = true;
            this.radioBtnSelect2.Text = "List 2";
            this.radioBtnSelect2.UseVisualStyleBackColor = true;
            // 
            // radioBtnSelect1
            // 
            this.radioBtnSelect1.AutoSize = true;
            this.radioBtnSelect1.Location = new System.Drawing.Point(34, 19);
            this.radioBtnSelect1.Name = "radioBtnSelect1";
            this.radioBtnSelect1.Size = new System.Drawing.Size(50, 17);
            this.radioBtnSelect1.TabIndex = 0;
            this.radioBtnSelect1.TabStop = true;
            this.radioBtnSelect1.Text = "List 1";
            this.radioBtnSelect1.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(128, 12);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(118, 277);
            this.listBox2.TabIndex = 4;
            // 
            // txtAddValue
            // 
            this.txtAddValue.Location = new System.Drawing.Point(128, 353);
            this.txtAddValue.Name = "txtAddValue";
            this.txtAddValue.Size = new System.Drawing.Size(118, 20);
            this.txtAddValue.TabIndex = 3;
            // 
            // btnRemoveValue
            // 
            this.btnRemoveValue.Location = new System.Drawing.Point(6, 382);
            this.btnRemoveValue.Name = "btnRemoveValue";
            this.btnRemoveValue.Size = new System.Drawing.Size(240, 28);
            this.btnRemoveValue.TabIndex = 2;
            this.btnRemoveValue.Text = "Remove Value";
            this.btnRemoveValue.UseVisualStyleBackColor = true;
            this.btnRemoveValue.Click += new System.EventHandler(this.btnRemoveValue_Click);
            // 
            // btnAddValue
            // 
            this.btnAddValue.Location = new System.Drawing.Point(6, 348);
            this.btnAddValue.Name = "btnAddValue";
            this.btnAddValue.Size = new System.Drawing.Size(116, 28);
            this.btnAddValue.TabIndex = 1;
            this.btnAddValue.Text = "Add Value";
            this.btnAddValue.UseVisualStyleBackColor = true;
            this.btnAddValue.Click += new System.EventHandler(this.btnAddValue_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(116, 277);
            this.listBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 474);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBoxSelectList.ResumeLayout(false);
            this.groupBoxSelectList.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxCreateList.ResumeLayout(false);
            this.groupBoxCreateList.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDispAvg;
        private System.Windows.Forms.RichTextBox richTxtDataDisplay;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTxtData;
        private System.Windows.Forms.Button btnCreateList;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtAddValue;
        private System.Windows.Forms.Button btnRemoveValue;
        private System.Windows.Forms.Button btnAddValue;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.GroupBox groupBoxSelectList;
        private System.Windows.Forms.RadioButton radioBtnDisplay2;
        private System.Windows.Forms.RadioButton radioBtnDisplay1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBoxCreateList;
        private System.Windows.Forms.RadioButton radioBtnCList2;
        private System.Windows.Forms.RadioButton radioBtnCList1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBtnSelect2;
        private System.Windows.Forms.RadioButton radioBtnSelect1;
    }
}

