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
            this.richTxtData = new System.Windows.Forms.RichTextBox();
            this.btnCreateList = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTxtDataDisplay = new System.Windows.Forms.RichTextBox();
            this.btnDispAvg = new System.Windows.Forms.Button();
            this.btnDispSD = new System.Windows.Forms.Button();
            this.btnDisplayList = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTxtData
            // 
            this.richTxtData.Location = new System.Drawing.Point(12, 10);
            this.richTxtData.Name = "richTxtData";
            this.richTxtData.Size = new System.Drawing.Size(222, 299);
            this.richTxtData.TabIndex = 0;
            this.richTxtData.Text = "";
            // 
            // btnCreateList
            // 
            this.btnCreateList.Location = new System.Drawing.Point(12, 315);
            this.btnCreateList.Name = "btnCreateList";
            this.btnCreateList.Size = new System.Drawing.Size(222, 48);
            this.btnCreateList.TabIndex = 1;
            this.btnCreateList.Text = "Create List of Data";
            this.btnCreateList.UseVisualStyleBackColor = true;
            this.btnCreateList.Click += new System.EventHandler(this.btnCreateList_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDisplayList);
            this.panel1.Controls.Add(this.richTxtData);
            this.panel1.Controls.Add(this.btnCreateList);
            this.panel1.Location = new System.Drawing.Point(12, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 447);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDispSD);
            this.panel2.Controls.Add(this.btnDispAvg);
            this.panel2.Controls.Add(this.richTxtDataDisplay);
            this.panel2.Location = new System.Drawing.Point(264, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 447);
            this.panel2.TabIndex = 3;
            // 
            // richTxtDataDisplay
            // 
            this.richTxtDataDisplay.Location = new System.Drawing.Point(3, 10);
            this.richTxtDataDisplay.Name = "richTxtDataDisplay";
            this.richTxtDataDisplay.Size = new System.Drawing.Size(217, 218);
            this.richTxtDataDisplay.TabIndex = 4;
            this.richTxtDataDisplay.Text = "";
            // 
            // btnDispAvg
            // 
            this.btnDispAvg.Location = new System.Drawing.Point(3, 234);
            this.btnDispAvg.Name = "btnDispAvg";
            this.btnDispAvg.Size = new System.Drawing.Size(217, 42);
            this.btnDispAvg.TabIndex = 4;
            this.btnDispAvg.Text = "Display Average";
            this.btnDispAvg.UseVisualStyleBackColor = true;
            // 
            // btnDispSD
            // 
            this.btnDispSD.Location = new System.Drawing.Point(3, 282);
            this.btnDispSD.Name = "btnDispSD";
            this.btnDispSD.Size = new System.Drawing.Size(217, 42);
            this.btnDispSD.TabIndex = 5;
            this.btnDispSD.Text = "Display Standard Deviation";
            this.btnDispSD.UseVisualStyleBackColor = true;
            // 
            // btnDisplayList
            // 
            this.btnDisplayList.Location = new System.Drawing.Point(12, 369);
            this.btnDisplayList.Name = "btnDisplayList";
            this.btnDisplayList.Size = new System.Drawing.Size(222, 48);
            this.btnDisplayList.TabIndex = 2;
            this.btnDisplayList.Text = "Display List";
            this.btnDisplayList.UseVisualStyleBackColor = true;
            this.btnDisplayList.Click += new System.EventHandler(this.btnDisplayList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 458);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTxtData;
        private System.Windows.Forms.Button btnCreateList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDispSD;
        private System.Windows.Forms.Button btnDispAvg;
        private System.Windows.Forms.RichTextBox richTxtDataDisplay;
        private System.Windows.Forms.Button btnDisplayList;
    }
}

