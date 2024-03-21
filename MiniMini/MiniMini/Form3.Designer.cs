namespace MiniMini
{
    partial class Form3
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
            ExitButton = new Button();
            ReturnButton = new Button();
            dataGridView1 = new DataGridView();
            FirstNameBox = new TextBox();
            LastNameBox = new TextBox();
            PhoneBox = new TextBox();
            EmailBox = new TextBox();
            IDBox = new TextBox();
            ReserveButton = new Button();
            ClearButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(211, 394);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(75, 23);
            ExitButton.TabIndex = 0;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // ReturnButton
            // 
            ReturnButton.Location = new Point(385, 394);
            ReturnButton.Name = "ReturnButton";
            ReturnButton.Size = new Size(75, 23);
            ReturnButton.TabIndex = 1;
            ReturnButton.Text = "Return";
            ReturnButton.UseVisualStyleBackColor = true;
            ReturnButton.Click += ReturnButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(307, 45);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(404, 288);
            dataGridView1.TabIndex = 2;
            // 
            // FirstNameBox
            // 
            FirstNameBox.Location = new Point(40, 45);
            FirstNameBox.Name = "FirstNameBox";
            FirstNameBox.PlaceholderText = "First Name";
            FirstNameBox.Size = new Size(140, 23);
            FirstNameBox.TabIndex = 3;
            // 
            // LastNameBox
            // 
            LastNameBox.Location = new Point(40, 94);
            LastNameBox.Name = "LastNameBox";
            LastNameBox.PlaceholderText = "Last Name";
            LastNameBox.Size = new Size(140, 23);
            LastNameBox.TabIndex = 3;
            // 
            // PhoneBox
            // 
            PhoneBox.Location = new Point(40, 143);
            PhoneBox.Name = "PhoneBox";
            PhoneBox.PlaceholderText = "Phone";
            PhoneBox.Size = new Size(140, 23);
            PhoneBox.TabIndex = 3;
            PhoneBox.TextChanged += PhoneBox_TextChanged;
            PhoneBox.Validating += PhoneBox_Validating;
            // 
            // EmailBox
            // 
            EmailBox.Location = new Point(40, 193);
            EmailBox.Name = "EmailBox";
            EmailBox.PlaceholderText = "Email";
            EmailBox.Size = new Size(140, 23);
            EmailBox.TabIndex = 3;
            EmailBox.Validating += EmailBox_Validating;
            // 
            // IDBox
            // 
            IDBox.Location = new Point(40, 264);
            IDBox.Name = "IDBox";
            IDBox.PlaceholderText = "ID";
            IDBox.Size = new Size(52, 23);
            IDBox.TabIndex = 3;
            // 
            // ReserveButton
            // 
            ReserveButton.Location = new Point(122, 263);
            ReserveButton.Name = "ReserveButton";
            ReserveButton.Size = new Size(84, 23);
            ReserveButton.TabIndex = 4;
            ReserveButton.Text = "Reserve";
            ReserveButton.UseVisualStyleBackColor = true;
            ReserveButton.Click += ReserveButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(122, 310);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(84, 40);
            ClearButton.TabIndex = 5;
            ClearButton.Text = "Clear Reservation";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ClearButton);
            Controls.Add(ReserveButton);
            Controls.Add(IDBox);
            Controls.Add(EmailBox);
            Controls.Add(PhoneBox);
            Controls.Add(LastNameBox);
            Controls.Add(FirstNameBox);
            Controls.Add(dataGridView1);
            Controls.Add(ReturnButton);
            Controls.Add(ExitButton);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ExitButton;
        private Button ReturnButton;
        private DataGridView dataGridView1;
        private TextBox FirstNameBox;
        private TextBox LastNameBox;
        private TextBox PhoneBox;
        private TextBox EmailBox;
        private TextBox IDBox;
        private Button ReserveButton;
        private Button ClearButton;
    }
}