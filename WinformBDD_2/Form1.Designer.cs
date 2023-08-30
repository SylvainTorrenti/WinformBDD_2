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
            tbName = new TextBox();
            tbFirstName = new TextBox();
            dtpBirthday = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            flpbutton = new FlowLayoutPanel();
            btRefresh = new Button();
            dgvUser = new DataGridView();
            bsUser = new BindingSource(components);
            tlpMain.SuspendLayout();
            tlpInput.SuspendLayout();
            flpbutton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsUser).BeginInit();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.Controls.Add(tlpInput, 0, 1);
            tlpMain.Controls.Add(flpbutton, 0, 2);
            tlpMain.Controls.Add(dgvUser, 0, 0);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 3;
            tlpMain.RowStyles.Add(new RowStyle());
            tlpMain.RowStyles.Add(new RowStyle());
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpMain.Size = new Size(754, 451);
            tlpMain.TabIndex = 0;
            // 
            // tlpInput
            // 
            tlpInput.ColumnCount = 2;
            tlpInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.68514F));
            tlpInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.31486F));
            tlpInput.Controls.Add(tbName, 1, 0);
            tlpInput.Controls.Add(tbFirstName, 1, 1);
            tlpInput.Controls.Add(dtpBirthday, 1, 2);
            tlpInput.Controls.Add(label1, 0, 0);
            tlpInput.Controls.Add(label2, 0, 1);
            tlpInput.Controls.Add(label3, 0, 2);
            tlpInput.Dock = DockStyle.Fill;
            tlpInput.Location = new Point(3, 237);
            tlpInput.Name = "tlpInput";
            tlpInput.RowCount = 3;
            tlpInput.RowStyles.Add(new RowStyle());
            tlpInput.RowStyles.Add(new RowStyle());
            tlpInput.RowStyles.Add(new RowStyle());
            tlpInput.Size = new Size(748, 85);
            tlpInput.TabIndex = 0;
            // 
            // tbName
            // 
            tbName.Dock = DockStyle.Fill;
            tbName.Location = new Point(187, 3);
            tbName.Name = "tbName";
            tbName.Size = new Size(558, 23);
            tbName.TabIndex = 0;
            // 
            // tbFirstName
            // 
            tbFirstName.Dock = DockStyle.Fill;
            tbFirstName.Location = new Point(187, 32);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(558, 23);
            tbFirstName.TabIndex = 1;
            // 
            // dtpBirthday
            // 
            dtpBirthday.Dock = DockStyle.Fill;
            dtpBirthday.Location = new Point(187, 61);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(558, 23);
            dtpBirthday.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(178, 29);
            label1.TabIndex = 3;
            label1.Text = "label1";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 29);
            label2.Name = "label2";
            label2.Size = new Size(178, 29);
            label2.TabIndex = 4;
            label2.Text = "label2";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 58);
            label3.Name = "label3";
            label3.Size = new Size(178, 29);
            label3.TabIndex = 5;
            label3.Text = "label3";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flpbutton
            // 
            flpbutton.Controls.Add(btRefresh);
            flpbutton.Dock = DockStyle.Fill;
            flpbutton.Location = new Point(3, 328);
            flpbutton.Name = "flpbutton";
            flpbutton.Size = new Size(748, 120);
            flpbutton.TabIndex = 1;
            // 
            // btRefresh
            // 
            btRefresh.Location = new Point(3, 3);
            btRefresh.Name = "btRefresh";
            btRefresh.Size = new Size(130, 65);
            btRefresh.TabIndex = 0;
            btRefresh.Text = "Actualiser";
            btRefresh.UseVisualStyleBackColor = true;
            btRefresh.Click += btRefresh_Click;
            // 
            // dgvUser
            // 
            dgvUser.AllowUserToAddRows = false;
            dgvUser.AllowUserToDeleteRows = false;
            dgvUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUser.BackgroundColor = SystemColors.Control;
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUser.Dock = DockStyle.Fill;
            dgvUser.Location = new Point(3, 3);
            dgvUser.MultiSelect = false;
            dgvUser.Name = "dgvUser";
            dgvUser.ReadOnly = true;
            dgvUser.RowHeadersVisible = false;
            dgvUser.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvUser.RowTemplate.Height = 25;
            dgvUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUser.Size = new Size(748, 228);
            dgvUser.TabIndex = 2;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 451);
            Controls.Add(tlpMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(770, 490);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Utilisateurs";
            tlpMain.ResumeLayout(false);
            tlpInput.ResumeLayout(false);
            tlpInput.PerformLayout();
            flpbutton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsUser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMain;
        private TableLayoutPanel tlpInput;
        private TextBox tbName;
        private TextBox tbFirstName;
        private DateTimePicker dtpBirthday;
        private FlowLayoutPanel flpbutton;
        private DataGridView dgvUser;
        private BindingSource bsUser;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btRefresh;
    }
}