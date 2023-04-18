namespace hotel
{
    partial class Receptionist
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receptionist));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.rooms = new System.Windows.Forms.TabPage();
            this.bathroom = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.checkout = new System.Windows.Forms.DateTimePicker();
            this.checkin = new System.Windows.Forms.DateTimePicker();
            this.pane = new System.Windows.Forms.Panel();
            this.room = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.emails = new System.Windows.Forms.Label();
            this.phones = new System.Windows.Forms.Label();
            this.names = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.egn = new System.Windows.Forms.TextBox();
            this.reservation = new System.Windows.Forms.DataGridView();
            this.queries = new System.Windows.Forms.TabPage();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabControl.SuspendLayout();
            this.rooms.SuspendLayout();
            this.room.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservation)).BeginInit();
            this.queries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.rooms);
            this.tabControl.Controls.Add(this.room);
            this.tabControl.Controls.Add(this.queries);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1924, 836);
            this.tabControl.TabIndex = 0;
            // 
            // rooms
            // 
            this.rooms.BackColor = System.Drawing.Color.SeaGreen;
            this.rooms.Controls.Add(this.bathroom);
            this.rooms.Controls.Add(this.label1);
            this.rooms.Controls.Add(this.typeBox);
            this.rooms.Controls.Add(this.checkout);
            this.rooms.Controls.Add(this.checkin);
            this.rooms.Controls.Add(this.pane);
            this.rooms.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rooms.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.rooms.Location = new System.Drawing.Point(4, 37);
            this.rooms.Name = "rooms";
            this.rooms.Padding = new System.Windows.Forms.Padding(3);
            this.rooms.Size = new System.Drawing.Size(1916, 795);
            this.rooms.TabIndex = 0;
            this.rooms.Text = "Стаи";
            // 
            // bathroom
            // 
            this.bathroom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bathroom.AutoSize = true;
            this.bathroom.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bathroom.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bathroom.Location = new System.Drawing.Point(1730, 82);
            this.bathroom.Name = "bathroom";
            this.bathroom.Size = new System.Drawing.Size(91, 35);
            this.bathroom.TabIndex = 10;
            this.bathroom.Text = "Баня";
            this.bathroom.UseVisualStyleBackColor = true;
            this.bathroom.CheckedChanged += new System.EventHandler(this.bathroom_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(1524, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Тип стая:";
            // 
            // typeBox
            // 
            this.typeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.typeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeBox.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Location = new System.Drawing.Point(1490, 74);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(194, 45);
            this.typeBox.TabIndex = 8;
            this.typeBox.SelectedIndexChanged += new System.EventHandler(this.typeBox_SelectedIndexChanged_1);
            // 
            // checkout
            // 
            this.checkout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkout.CalendarFont = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkout.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkout.Location = new System.Drawing.Point(1490, 198);
            this.checkout.Name = "checkout";
            this.checkout.Size = new System.Drawing.Size(342, 41);
            this.checkout.TabIndex = 3;
            this.checkout.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // checkin
            // 
            this.checkin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkin.CalendarFont = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkin.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkin.Location = new System.Drawing.Point(1490, 152);
            this.checkin.Name = "checkin";
            this.checkin.Size = new System.Drawing.Size(342, 41);
            this.checkin.TabIndex = 2;
            this.checkin.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // pane
            // 
            this.pane.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pane.AutoScroll = true;
            this.pane.Font = new System.Drawing.Font("Britannic Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pane.Location = new System.Drawing.Point(21, 18);
            this.pane.Name = "pane";
            this.pane.Size = new System.Drawing.Size(1373, 760);
            this.pane.TabIndex = 0;
            // 
            // room
            // 
            this.room.BackColor = System.Drawing.Color.SeaGreen;
            this.room.Controls.Add(this.label4);
            this.room.Controls.Add(this.label3);
            this.room.Controls.Add(this.button1);
            this.room.Controls.Add(this.dateTimePicker4);
            this.room.Controls.Add(this.dateTimePicker3);
            this.room.Controls.Add(this.label2);
            this.room.Controls.Add(this.emails);
            this.room.Controls.Add(this.phones);
            this.room.Controls.Add(this.names);
            this.room.Controls.Add(this.label);
            this.room.Controls.Add(this.email);
            this.room.Controls.Add(this.phone);
            this.room.Controls.Add(this.name);
            this.room.Controls.Add(this.egn);
            this.room.Controls.Add(this.reservation);
            this.room.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.room.Location = new System.Drawing.Point(4, 37);
            this.room.Name = "room";
            this.room.Size = new System.Drawing.Size(1916, 795);
            this.room.TabIndex = 2;
            this.room.Text = "Стая";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1280, 407);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 28);
            this.label4.TabIndex = 14;
            this.label4.Text = "До:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(957, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 28);
            this.label3.TabIndex = 13;
            this.label3.Text = "От:";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(1081, 588);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 69);
            this.button1.TabIndex = 12;
            this.button1.Text = "Добавяне";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dateTimePicker4.Location = new System.Drawing.Point(1181, 448);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(262, 35);
            this.dateTimePicker4.TabIndex = 11;
            this.dateTimePicker4.ValueChanged += new System.EventHandler(this.dateTimePicker4_ValueChanged);
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dateTimePicker3.Location = new System.Drawing.Point(862, 448);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(261, 35);
            this.dateTimePicker3.TabIndex = 10;
            this.dateTimePicker3.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(580, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "Клиент:";
            // 
            // emails
            // 
            this.emails.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.emails.AutoSize = true;
            this.emails.Location = new System.Drawing.Point(389, 624);
            this.emails.Name = "emails";
            this.emails.Size = new System.Drawing.Size(85, 28);
            this.emails.TabIndex = 8;
            this.emails.Text = "Email:";
            // 
            // phones
            // 
            this.phones.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.phones.AutoSize = true;
            this.phones.Location = new System.Drawing.Point(239, 572);
            this.phones.Name = "phones";
            this.phones.Size = new System.Drawing.Size(236, 28);
            this.phones.TabIndex = 7;
            this.phones.Text = "Телефонен номер:";
            // 
            // names
            // 
            this.names.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.names.AutoSize = true;
            this.names.Location = new System.Drawing.Point(327, 521);
            this.names.Name = "names";
            this.names.Size = new System.Drawing.Size(147, 28);
            this.names.TabIndex = 6;
            this.names.Text = "Три имена:";
            // 
            // label
            // 
            this.label.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(408, 469);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(67, 28);
            this.label.TabIndex = 5;
            this.label.Text = "ЕГН:";
            // 
            // email
            // 
            this.email.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.email.Location = new System.Drawing.Point(496, 619);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(275, 35);
            this.email.TabIndex = 4;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // phone
            // 
            this.phone.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.phone.Location = new System.Drawing.Point(497, 565);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(274, 35);
            this.phone.TabIndex = 3;
            this.phone.TextChanged += new System.EventHandler(this.phone_TextChanged);
            // 
            // name
            // 
            this.name.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.name.Location = new System.Drawing.Point(496, 514);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(275, 35);
            this.name.TabIndex = 2;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // egn
            // 
            this.egn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.egn.Location = new System.Drawing.Point(496, 462);
            this.egn.Name = "egn";
            this.egn.Size = new System.Drawing.Size(275, 35);
            this.egn.TabIndex = 1;
            this.egn.TextChanged += new System.EventHandler(this.egn_TextChanged);
            // 
            // reservation
            // 
            this.reservation.AllowUserToResizeRows = false;
            this.reservation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reservation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.reservation.BackgroundColor = System.Drawing.SystemColors.Window;
            this.reservation.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.reservation.ColumnHeadersHeight = 40;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.reservation.DefaultCellStyle = dataGridViewCellStyle1;
            this.reservation.GridColor = System.Drawing.SystemColors.Highlight;
            this.reservation.Location = new System.Drawing.Point(4, 11);
            this.reservation.Name = "reservation";
            this.reservation.RowHeadersVisible = false;
            this.reservation.RowHeadersWidth = 51;
            this.reservation.RowTemplate.Height = 29;
            this.reservation.Size = new System.Drawing.Size(1904, 302);
            this.reservation.TabIndex = 0;
            this.reservation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reservation_CellClick);
            // 
            // queries
            // 
            this.queries.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.queries.Controls.Add(this.comboBox2);
            this.queries.Controls.Add(this.label5);
            this.queries.Controls.Add(this.dataGridView1);
            this.queries.Controls.Add(this.textBox1);
            this.queries.Controls.Add(this.comboBox1);
            this.queries.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.queries.Location = new System.Drawing.Point(4, 37);
            this.queries.Name = "queries";
            this.queries.Padding = new System.Windows.Forms.Padding(3);
            this.queries.Size = new System.Drawing.Size(1916, 795);
            this.queries.TabIndex = 1;
            this.queries.Text = "Справки";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(376, 17);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(257, 36);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(685, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 28);
            this.label5.TabIndex = 3;
            this.label5.Text = "Търси:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dataGridView1.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Highlight;
            this.dataGridView1.Location = new System.Drawing.Point(3, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1905, 716);
            this.dataGridView1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(783, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(269, 35);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Резервации",
            "Клиенти"});
            this.comboBox1.Location = new System.Drawing.Point(49, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(257, 36);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Receptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1924, 836);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Receptionist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detelina";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Receptionist_Load);
            this.tabControl.ResumeLayout(false);
            this.rooms.ResumeLayout(false);
            this.rooms.PerformLayout();
            this.room.ResumeLayout(false);
            this.room.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservation)).EndInit();
            this.queries.ResumeLayout(false);
            this.queries.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl;
        private TabPage rooms;
        private TabPage queries;
        private TabPage room;

        private List<Button> buttons = new List<Button>();

        public List<Button> button()
        {
            return buttons;
        }

        public void addButton(Button button)
        {
            buttons.Append(button);
        }

        private Panel pane;
        private DateTimePicker checkout;
        private DateTimePicker checkin;
        private ComboBox typeBox;
        private Label label1;
        private DataGridView reservation;
        private TextBox email;
        private TextBox phone;
        private TextBox name;
        private TextBox egn;
        private Label phones;
        private Label names;
        private Label label;
        private Label emails;
        private Label label2;
        private Button button1;
        private DateTimePicker dateTimePicker4;
        private DateTimePicker dateTimePicker3;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private CheckBox bathroom;
        private Label label4;
        private Label label3;
        private Label label5;
        private ComboBox comboBox2;
    }
}