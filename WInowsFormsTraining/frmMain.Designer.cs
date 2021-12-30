
namespace WInowsFormsTraining
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPopupMsg = new System.Windows.Forms.Button();
            this.grpGroupTest1 = new System.Windows.Forms.GroupBox();
            this.txtPopupMsg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbCheese = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRadioSelect = new System.Windows.Forms.Button();
            this.rdbWIne = new System.Windows.Forms.RadioButton();
            this.rdbChocolate = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.grpDataGridExample = new System.Windows.Forms.GroupBox();
            this.dgvExample = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpGroupTest1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpDataGridExample.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExample)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPopupMsg
            // 
            this.btnPopupMsg.Location = new System.Drawing.Point(277, 16);
            this.btnPopupMsg.Name = "btnPopupMsg";
            this.btnPopupMsg.Size = new System.Drawing.Size(75, 23);
            this.btnPopupMsg.TabIndex = 0;
            this.btnPopupMsg.Text = "Go!";
            this.btnPopupMsg.UseVisualStyleBackColor = true;
            this.btnPopupMsg.Click += new System.EventHandler(this.btnPopupMsg_Click);
            // 
            // grpGroupTest1
            // 
            this.grpGroupTest1.Controls.Add(this.txtPopupMsg);
            this.grpGroupTest1.Controls.Add(this.label1);
            this.grpGroupTest1.Controls.Add(this.btnPopupMsg);
            this.grpGroupTest1.Location = new System.Drawing.Point(12, 23);
            this.grpGroupTest1.Name = "grpGroupTest1";
            this.grpGroupTest1.Size = new System.Drawing.Size(382, 83);
            this.grpGroupTest1.TabIndex = 1;
            this.grpGroupTest1.TabStop = false;
            this.grpGroupTest1.Text = "Input Example";
            // 
            // txtPopupMsg
            // 
            this.txtPopupMsg.Location = new System.Drawing.Point(103, 16);
            this.txtPopupMsg.Name = "txtPopupMsg";
            this.txtPopupMsg.Size = new System.Drawing.Size(168, 23);
            this.txtPopupMsg.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Some Text:";
            // 
            // rdbCheese
            // 
            this.rdbCheese.AutoSize = true;
            this.rdbCheese.Checked = true;
            this.rdbCheese.Location = new System.Drawing.Point(6, 37);
            this.rdbCheese.Name = "rdbCheese";
            this.rdbCheese.Size = new System.Drawing.Size(63, 19);
            this.rdbCheese.TabIndex = 2;
            this.rdbCheese.TabStop = true;
            this.rdbCheese.Text = "Cheese";
            this.rdbCheese.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRadioSelect);
            this.groupBox1.Controls.Add(this.rdbWIne);
            this.groupBox1.Controls.Add(this.rdbChocolate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rdbCheese);
            this.groupBox1.Location = new System.Drawing.Point(12, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 162);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Radio Button Example";
            // 
            // btnRadioSelect
            // 
            this.btnRadioSelect.Location = new System.Drawing.Point(6, 112);
            this.btnRadioSelect.Name = "btnRadioSelect";
            this.btnRadioSelect.Size = new System.Drawing.Size(119, 23);
            this.btnRadioSelect.TabIndex = 2;
            this.btnRadioSelect.Text = "Go!";
            this.btnRadioSelect.UseVisualStyleBackColor = true;
            this.btnRadioSelect.Click += new System.EventHandler(this.btnRadioSelect_Click);
            // 
            // rdbWIne
            // 
            this.rdbWIne.AutoSize = true;
            this.rdbWIne.Location = new System.Drawing.Point(6, 87);
            this.rdbWIne.Name = "rdbWIne";
            this.rdbWIne.Size = new System.Drawing.Size(52, 19);
            this.rdbWIne.TabIndex = 4;
            this.rdbWIne.TabStop = true;
            this.rdbWIne.Text = "Wine";
            this.rdbWIne.UseVisualStyleBackColor = true;
            // 
            // rdbChocolate
            // 
            this.rdbChocolate.AutoSize = true;
            this.rdbChocolate.Location = new System.Drawing.Point(6, 62);
            this.rdbChocolate.Name = "rdbChocolate";
            this.rdbChocolate.Size = new System.Drawing.Size(79, 19);
            this.rdbChocolate.TabIndex = 3;
            this.rdbChocolate.TabStop = true;
            this.rdbChocolate.Text = "Chocolate";
            this.rdbChocolate.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please seelct an option and press go!";
            // 
            // grpDataGridExample
            // 
            this.grpDataGridExample.Controls.Add(this.dgvExample);
            this.grpDataGridExample.Location = new System.Drawing.Point(400, 23);
            this.grpDataGridExample.Name = "grpDataGridExample";
            this.grpDataGridExample.Size = new System.Drawing.Size(711, 251);
            this.grpDataGridExample.TabIndex = 4;
            this.grpDataGridExample.TabStop = false;
            this.grpDataGridExample.Text = "DataGridExample";
            // 
            // dgvExample
            // 
            this.dgvExample.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExample.Location = new System.Drawing.Point(6, 22);
            this.dgvExample.Name = "dgvExample";
            this.dgvExample.RowTemplate.Height = 25;
            this.dgvExample.Size = new System.Drawing.Size(699, 223);
            this.dgvExample.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(986, 280);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(119, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 313);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpDataGridExample);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpGroupTest1);
            this.Name = "frmMain";
            this.Text = "WinForms Training";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpGroupTest1.ResumeLayout(false);
            this.grpGroupTest1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpDataGridExample.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExample)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPopupMsg;
        private System.Windows.Forms.GroupBox grpGroupTest1;
        private System.Windows.Forms.TextBox txtPopupMsg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbCheese;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRadioSelect;
        private System.Windows.Forms.RadioButton rdbWIne;
        private System.Windows.Forms.RadioButton rdbChocolate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpDataGridExample;
        private System.Windows.Forms.DataGridView dgvExample;
        private System.Windows.Forms.Button btnExit;
    }
}

