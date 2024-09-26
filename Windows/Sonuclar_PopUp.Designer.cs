namespace ADBoyaSU.Windows
{
    partial class Sonuclar_PopUp
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sonuclar_PopUp));
            dataGridView1 = new DataGridView();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            Ad = new DataGridViewTextBoxColumn();
            Akiz1 = new DataGridViewImageColumn();
            Akiz2 = new DataGridViewImageColumn();
            Akiz3 = new DataGridViewImageColumn();
            Sonuclar = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Ad, Akiz1, Akiz2, Akiz3, Sonuclar });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(762, 392);
            dataGridView1.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 426);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 398);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Ad
            // 
            Ad.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            Ad.DefaultCellStyle = dataGridViewCellStyle1;
            Ad.HeaderText = "Ad";
            Ad.Name = "Ad";
            Ad.ReadOnly = true;
            Ad.Width = 21;
            // 
            // Akiz1
            // 
            Akiz1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            Akiz1.HeaderText = "Akis 1";
            Akiz1.Image = Properties.Resources.gir_ozum_01;
            Akiz1.Name = "Akiz1";
            Akiz1.Resizable = DataGridViewTriState.False;
            Akiz1.Width = 21;
            // 
            // Akiz2
            // 
            Akiz2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            Akiz2.HeaderText = "Akis 2";
            Akiz2.Image = Properties.Resources.gir_ozum_01;
            Akiz2.Name = "Akiz2";
            Akiz2.Width = 21;
            // 
            // Akiz3
            // 
            Akiz3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            Akiz3.HeaderText = "Akis 3";
            Akiz3.Image = Properties.Resources.gir_ozum_01;
            Akiz3.Name = "Akiz3";
            Akiz3.Width = 21;
            // 
            // Sonuclar
            // 
            Sonuclar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            Sonuclar.DefaultCellStyle = dataGridViewCellStyle2;
            Sonuclar.HeaderText = "Sonuclar";
            Sonuclar.Name = "Sonuclar";
            Sonuclar.ReadOnly = true;
            Sonuclar.Width = 21;
            // 
            // Sonuclar_PopUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Sonuclar_PopUp";
            Text = "Sonuclar_PopUp";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridViewTextBoxColumn Ad;
        private DataGridViewImageColumn Akiz1;
        private DataGridViewImageColumn Akiz2;
        private DataGridViewImageColumn Akiz3;
        private DataGridViewTextBoxColumn Sonuclar;
    }
}