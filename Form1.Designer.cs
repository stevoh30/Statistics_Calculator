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
            this.btnDispAvg = new System.Windows.Forms.Button();
            this.richTxtDataDisplay = new System.Windows.Forms.RichTextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.richTxtData = new System.Windows.Forms.RichTextBox();
            this.btnCreateList = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtAddValue = new System.Windows.Forms.TextBox();
            this.btnRemoveValue = new System.Windows.Forms.Button();
            this.btnAddValue = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDispAvg);
            this.panel2.Controls.Add(this.richTxtDataDisplay);
            this.panel2.Location = new System.Drawing.Point(284, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(209, 295);
            this.panel2.TabIndex = 3;
            // 
            // btnDispAvg
            // 
            this.btnDispAvg.Location = new System.Drawing.Point(14, 236);
            this.btnDispAvg.Name = "btnDispAvg";
            this.btnDispAvg.Size = new System.Drawing.Size(181, 42);
            this.btnDispAvg.TabIndex = 4;
            this.btnDispAvg.Text = "Display Properties";
            this.btnDispAvg.UseVisualStyleBackColor = true;
            this.btnDispAvg.Click += new System.EventHandler(this.btnDispAvg_Click);
            // 
            // richTxtDataDisplay
            // 
            this.richTxtDataDisplay.Location = new System.Drawing.Point(14, 12);
            this.richTxtDataDisplay.Name = "richTxtDataDisplay";
            this.richTxtDataDisplay.Size = new System.Drawing.Size(181, 218);
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
            this.tabControl.Size = new System.Drawing.Size(266, 434);
            this.tabControl.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(258, 408);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Create List";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Label1);
            this.panel1.Controls.Add(this.richTxtData);
            this.panel1.Controls.Add(this.btnCreateList);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 396);
            this.panel1.TabIndex = 2;
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
            this.richTxtData.Location = new System.Drawing.Point(12, 50);
            this.richTxtData.Name = "richTxtData";
            this.richTxtData.Size = new System.Drawing.Size(214, 289);
            this.richTxtData.TabIndex = 0;
            this.richTxtData.Text = "";
            // 
            // btnCreateList
            // 
            this.btnCreateList.Location = new System.Drawing.Point(12, 345);
            this.btnCreateList.Name = "btnCreateList";
            this.btnCreateList.Size = new System.Drawing.Size(214, 48);
            this.btnCreateList.TabIndex = 1;
            this.btnCreateList.Text = "Create List of Data";
            this.btnCreateList.UseVisualStyleBackColor = true;
            this.btnCreateList.Click += new System.EventHandler(this.btnCreateList_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.txtAddValue);
            this.tabPage2.Controls.Add(this.btnRemoveValue);
            this.tabPage2.Controls.Add(this.btnAddValue);
            this.tabPage2.Controls.Add(this.listBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(258, 408);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Selected List";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtAddValue
            // 
            this.txtAddValue.Location = new System.Drawing.Point(128, 323);
            this.txtAddValue.Name = "txtAddValue";
            this.txtAddValue.Size = new System.Drawing.Size(118, 20);
            this.txtAddValue.TabIndex = 3;
            // 
            // btnRemoveValue
            // 
            this.btnRemoveValue.Location = new System.Drawing.Point(17, 355);
            this.btnRemoveValue.Name = "btnRemoveValue";
            this.btnRemoveValue.Size = new System.Drawing.Size(105, 28);
            this.btnRemoveValue.TabIndex = 2;
            this.btnRemoveValue.Text = "Remove Value";
            this.btnRemoveValue.UseVisualStyleBackColor = true;
            this.btnRemoveValue.Click += new System.EventHandler(this.btnRemoveValue_Click);
            // 
            // btnAddValue
            // 
            this.btnAddValue.Location = new System.Drawing.Point(17, 321);
            this.btnAddValue.Name = "btnAddValue";
            this.btnAddValue.Size = new System.Drawing.Size(105, 28);
            this.btnAddValue.TabIndex = 1;
            this.btnAddValue.Text = "Add Value";
            this.btnAddValue.UseVisualStyleBackColor = true;
            this.btnAddValue.Click += new System.EventHandler(this.btnAddValue_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(17, 12);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(229, 303);
            this.listBox.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(128, 355);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 28);
            this.button4.TabIndex = 3;
            this.button4.Text = "Delete List";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 458);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label Label1;
    }
}

