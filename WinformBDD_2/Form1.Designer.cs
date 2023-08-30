namespace WinformBDD_2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            tlpMain = new TableLayoutPanel();
            tlpInput = new TableLayoutPanel();
            flpbutton = new FlowLayoutPanel();
            dgvUser = new DataGridView();
            bsUser = new BindingSource(components);
            tbName = new TextBox();
            tbFirstName = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            tlpMain.SuspendLayout();
            tlpInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsUser).BeginInit();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpMain.Controls.Add(tlpInput, 0, 1);
            tlpMain.Controls.Add(flpbutton, 0, 2);
            tlpMain.Controls.Add(dgvUser, 0, 0);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 3;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 72F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 28F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 124F));
            tlpMain.Size = new Size(800, 450);
            tlpMain.TabIndex = 0;
            // 
            // tlpInput
            // 
            tlpInput.ColumnCount = 2;
            tlpInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.68514F));
            tlpInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.31486F));
            tlpInput.Controls.Add(tbName, 1, 0);
            tlpInput.Controls.Add(tbFirstName, 1, 1);
            tlpInput.Controls.Add(dateTimePicker1, 1, 2);
            tlpInput.Dock = DockStyle.Fill;
            tlpInput.Location = new Point(3, 237);
            tlpInput.Name = "tlpInput";
            tlpInput.RowCount = 3;
            tlpInput.RowStyles.Add(new RowStyle());
            tlpInput.RowStyles.Add(new RowStyle());
            tlpInput.RowStyles.Add(new RowStyle());
            tlpInput.Size = new Size(794, 85);
            tlpInput.TabIndex = 0;
            // 
            // flpbutton
            // 
            flpbutton.Dock = DockStyle.Fill;
            flpbutton.Location = new Point(3, 328);
            flpbutton.Name = "flpbutton";
            flpbutton.Size = new Size(794, 119);
            flpbutton.TabIndex = 1;
            // 
            // dgvUser
            // 
            dgvUser.AllowUserToAddRows = false;
            dgvUser.AllowUserToDeleteRows = false;
            dgvUser.BackgroundColor = SystemColors.Control;
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUser.Dock = DockStyle.Fill;
            dgvUser.Location = new Point(3, 3);
            dgvUser.Name = "dgvUser";
            dgvUser.ReadOnly = true;
            dgvUser.RowTemplate.Height = 25;
            dgvUser.Size = new Size(794, 228);
            dgvUser.TabIndex = 2;
            // 
            // tbName
            // 
            tbName.Dock = DockStyle.Fill;
            tbName.Location = new Point(199, 3);
            tbName.Name = "tbName";
            tbName.Size = new Size(592, 23);
            tbName.TabIndex = 0;
            // 
            // tbFirstName
            // 
            tbFirstName.Dock = DockStyle.Fill;
            tbFirstName.Location = new Point(199, 32);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(592, 23);
            tbFirstName.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Dock = DockStyle.Fill;
            dateTimePicker1.Location = new Point(199, 61);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(592, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tlpMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Utilisateurs";
            tlpMain.ResumeLayout(false);
            tlpInput.ResumeLayout(false);
            tlpInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsUser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMain;
        private TableLayoutPanel tlpInput;
        private TextBox tbName;
        private TextBox tbFirstName;
        private DateTimePicker dateTimePicker1;
        private FlowLayoutPanel flpbutton;
        private DataGridView dgvUser;
        private BindingSource bsUser;
    }
}