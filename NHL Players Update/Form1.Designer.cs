namespace NHL_Players
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
            this.dataGridViewPlayers = new System.Windows.Forms.DataGridView();
            this.btnLoadCSV = new System.Windows.Forms.Button();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.comboBoxSorting = new System.Windows.Forms.ComboBox();
            this.comboBoxSortingOrder = new System.Windows.Forms.ComboBox();
            this.title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ApplyFilter = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_ApplySorting = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayers)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPlayers
            // 
            this.dataGridViewPlayers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlayers.Location = new System.Drawing.Point(254, 157);
            this.dataGridViewPlayers.Name = "dataGridViewPlayers";
            this.dataGridViewPlayers.Size = new System.Drawing.Size(659, 383);
            this.dataGridViewPlayers.TabIndex = 0;
            // 
            // btnLoadCSV
            // 
            this.btnLoadCSV.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLoadCSV.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadCSV.Location = new System.Drawing.Point(69, 98);
            this.btnLoadCSV.Name = "btnLoadCSV";
            this.btnLoadCSV.Size = new System.Drawing.Size(114, 32);
            this.btnLoadCSV.TabIndex = 1;
            this.btnLoadCSV.Text = "Load CSV";
            this.btnLoadCSV.UseVisualStyleBackColor = false;
            this.btnLoadCSV.Click += new System.EventHandler(this.btnLoadCSV_Click);
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Location = new System.Drawing.Point(14, 78);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(157, 20);
            this.textBoxFilter.TabIndex = 2;
            // 
            // comboBoxSorting
            // 
            this.comboBoxSorting.FormattingEnabled = true;
            this.comboBoxSorting.Items.AddRange(new object[] {
            "Player",
            "Team",
            "Pos",
            "GP",
            "G",
            "A",
            "P",
            "+/-",
            "PIM",
            "P/G",
            "PPG",
            "PPP",
            "SHG",
            "SHP",
            "GWG",
            "OTG",
            "S",
            "S%",
            "TOI/GP",
            "Shifts/GP",
            "FOW%"});
            this.comboBoxSorting.Location = new System.Drawing.Point(14, 80);
            this.comboBoxSorting.Name = "comboBoxSorting";
            this.comboBoxSorting.Size = new System.Drawing.Size(89, 21);
            this.comboBoxSorting.TabIndex = 4;
            // 
            // comboBoxSortingOrder
            // 
            this.comboBoxSortingOrder.FormattingEnabled = true;
            this.comboBoxSortingOrder.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.comboBoxSortingOrder.Location = new System.Drawing.Point(14, 134);
            this.comboBoxSortingOrder.Name = "comboBoxSortingOrder";
            this.comboBoxSortingOrder.Size = new System.Drawing.Size(89, 21);
            this.comboBoxSortingOrder.TabIndex = 5;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.title.Location = new System.Drawing.Point(474, 63);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(214, 45);
            this.title.TabIndex = 6;
            this.title.Text = "NHL Players";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(11, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Field";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(11, 48);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Filter Expression";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(11, 113);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sort By";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(9, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "Filter";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(9, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 26);
            this.label5.TabIndex = 12;
            this.label5.Text = "Sorting";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.btn_ApplyFilter);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxFilter);
            this.panel1.Location = new System.Drawing.Point(28, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 160);
            this.panel1.TabIndex = 13;
            // 
            // btn_ApplyFilter
            // 
            this.btn_ApplyFilter.BackColor = System.Drawing.Color.White;
            this.btn_ApplyFilter.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ApplyFilter.Location = new System.Drawing.Point(14, 120);
            this.btn_ApplyFilter.Name = "btn_ApplyFilter";
            this.btn_ApplyFilter.Size = new System.Drawing.Size(75, 23);
            this.btn_ApplyFilter.TabIndex = 12;
            this.btn_ApplyFilter.Text = "Apply";
            this.btn_ApplyFilter.UseVisualStyleBackColor = false;
            this.btn_ApplyFilter.Click += new System.EventHandler(this.btn_ApplyFilter_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Controls.Add(this.btn_ApplySorting);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.comboBoxSortingOrder);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.comboBoxSorting);
            this.panel2.Location = new System.Drawing.Point(28, 333);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 207);
            this.panel2.TabIndex = 14;
            // 
            // btn_ApplySorting
            // 
            this.btn_ApplySorting.BackColor = System.Drawing.Color.White;
            this.btn_ApplySorting.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ApplySorting.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_ApplySorting.Location = new System.Drawing.Point(14, 171);
            this.btn_ApplySorting.Name = "btn_ApplySorting";
            this.btn_ApplySorting.Size = new System.Drawing.Size(75, 23);
            this.btn_ApplySorting.TabIndex = 13;
            this.btn_ApplySorting.Text = "Apply";
            this.btn_ApplySorting.UseVisualStyleBackColor = false;
            this.btn_ApplySorting.Click += new System.EventHandler(this.btn_ApplySorting_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(936, 596);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.title);
            this.Controls.Add(this.btnLoadCSV);
            this.Controls.Add(this.dataGridViewPlayers);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPlayers;
        private System.Windows.Forms.Button btnLoadCSV;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.ComboBox comboBoxSorting;
        private System.Windows.Forms.ComboBox comboBoxSortingOrder;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_ApplyFilter;
        private System.Windows.Forms.Button btn_ApplySorting;
    }
}

