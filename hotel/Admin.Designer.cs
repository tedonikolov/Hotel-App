namespace hotel
{
    partial class Admin
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.postgisServicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Types = new System.Windows.Forms.DataGridView();
            this.postgisServicesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.Rooms = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.TextBox();
            this.type = new System.Windows.Forms.TextBox();
            this.Profiles = new System.Windows.Forms.DataGridView();
            this.Price = new System.Windows.Forms.TextBox();
            this.TypeBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.People = new System.Windows.Forms.TextBox();
            this.Bathroom = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.postgisServicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Types)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postgisServicesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Profiles)).BeginInit();
            this.Bathroom.SuspendLayout();
            this.SuspendLayout();
            // 
            // Types
            // 
            this.Types.AllowUserToOrderColumns = true;
            this.Types.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Types.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Types.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Types.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Types.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Types.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Types.ColumnHeadersHeight = 29;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Types.DefaultCellStyle = dataGridViewCellStyle2;
            this.Types.GridColor = System.Drawing.SystemColors.Highlight;
            this.Types.Location = new System.Drawing.Point(972, 3);
            this.Types.Name = "Types";
            this.Types.ReadOnly = true;
            this.Types.RowHeadersVisible = false;
            this.Types.RowHeadersWidth = 51;
            this.Types.RowTemplate.Height = 29;
            this.Types.Size = new System.Drawing.Size(577, 746);
            this.Types.TabIndex = 0;
            this.Types.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Types_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Rooms
            // 
            this.Rooms.AllowUserToDeleteRows = false;
            this.Rooms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Rooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Rooms.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Rooms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Rooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Rooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Rooms.DefaultCellStyle = dataGridViewCellStyle4;
            this.Rooms.GridColor = System.Drawing.SystemColors.Highlight;
            this.Rooms.Location = new System.Drawing.Point(629, 3);
            this.Rooms.Name = "Rooms";
            this.Rooms.RowHeadersVisible = false;
            this.Rooms.RowHeadersWidth = 51;
            this.Rooms.RowTemplate.Height = 29;
            this.Rooms.Size = new System.Drawing.Size(337, 746);
            this.Rooms.TabIndex = 2;
            this.Rooms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Rooms_CellClick);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(171, 53);
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Size = new System.Drawing.Size(187, 27);
            this.id.TabIndex = 3;
            this.id.Visible = false;
            // 
            // type
            // 
            this.type.Location = new System.Drawing.Point(171, 101);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(187, 27);
            this.type.TabIndex = 4;
            this.type.Visible = false;
            // 
            // Profiles
            // 
            this.Profiles.AllowUserToDeleteRows = false;
            this.Profiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Profiles.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Profiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Profiles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Profiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Profiles.DefaultCellStyle = dataGridViewCellStyle6;
            this.Profiles.GridColor = System.Drawing.SystemColors.Highlight;
            this.Profiles.Location = new System.Drawing.Point(550, 3);
            this.Profiles.Name = "Profiles";
            this.Profiles.RowHeadersVisible = false;
            this.Profiles.RowHeadersWidth = 51;
            this.Profiles.RowTemplate.Height = 29;
            this.Profiles.Size = new System.Drawing.Size(73, 746);
            this.Profiles.TabIndex = 5;
            this.Profiles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Profiles_CellClick);
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(171, 146);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(187, 27);
            this.Price.TabIndex = 6;
            this.Price.Visible = false;
            // 
            // TypeBox
            // 
            this.TypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeBox.FormattingEnabled = true;
            this.TypeBox.Location = new System.Drawing.Point(167, 100);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(194, 28);
            this.TypeBox.TabIndex = 7;
            this.TypeBox.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(202, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 51);
            this.button2.TabIndex = 9;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(202, 179);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 51);
            this.button3.TabIndex = 13;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(171, 101);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(187, 27);
            this.username.TabIndex = 11;
            this.username.Visible = false;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(171, 146);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(190, 27);
            this.password.TabIndex = 12;
            this.password.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 17;
            // 
            // People
            // 
            this.People.Location = new System.Drawing.Point(171, 191);
            this.People.Name = "People";
            this.People.Size = new System.Drawing.Size(190, 27);
            this.People.TabIndex = 18;
            this.People.Visible = false;
            // 
            // Bathroom
            // 
            this.Bathroom.Controls.Add(this.radioButton2);
            this.Bathroom.Controls.Add(this.radioButton1);
            this.Bathroom.Location = new System.Drawing.Point(167, 140);
            this.Bathroom.Name = "Bathroom";
            this.Bathroom.Size = new System.Drawing.Size(207, 78);
            this.Bathroom.TabIndex = 19;
            this.Bathroom.TabStop = false;
            this.Bathroom.Text = "Баня";
            this.Bathroom.Visible = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(11, 54);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(68, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Няма";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(11, 25);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(60, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Има";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 20;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1547, 749);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Bathroom);
            this.Controls.Add(this.People);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Profiles);
            this.Controls.Add(this.type);
            this.Controls.Add(this.id);
            this.Controls.Add(this.Rooms);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Types);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detelina";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.postgisServicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Types)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postgisServicesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Profiles)).EndInit();
            this.Bathroom.ResumeLayout(false);
            this.Bathroom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BindingSource postgisServicesBindingSource;
        private DataGridView Types;
        private Button button1;
        private DataGridView Rooms;
        private BindingSource postgisServicesBindingSource1;
        private TextBox id;
        private TextBox type;
        private DataGridView Profiles;
        private TextBox Price;
        private ComboBox TypeBox;
        private Button button2;
        private TextBox username;
        private TextBox password;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox People;
        private GroupBox Bathroom;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label4;
    }
}