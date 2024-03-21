namespace MiniMini
{
    partial class Form2
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
            exit = new Button();
            label1 = new Label();
            CPUbox = new ComboBox();
            GPUbox = new ComboBox();
            RAMbox = new ComboBox();
            AvailabilityBox = new ComboBox();
            dataGridView1 = new DataGridView();
            Clear = new Button();
            ReserveButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // exit
            // 
            exit.Location = new Point(456, 402);
            exit.Name = "exit";
            exit.Size = new Size(75, 23);
            exit.TabIndex = 0;
            exit.Text = "Exit";
            exit.UseVisualStyleBackColor = true;
            exit.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(285, 118);
            label1.Name = "label1";
            label1.Size = new Size(128, 15);
            label1.TabIndex = 1;
            label1.Text = "Welcome <username>";
            label1.Click += label1_Click;
            // 
            // CPUbox
            // 
            CPUbox.FormattingEnabled = true;
            CPUbox.Items.AddRange(new object[] { "Intel", "AMD" });
            CPUbox.Location = new Point(41, 48);
            CPUbox.Name = "CPUbox";
            CPUbox.Size = new Size(121, 23);
            CPUbox.TabIndex = 2;
            CPUbox.Text = "CPU";
            CPUbox.SelectedIndexChanged += CPUbox_SelectedIndexChanged;
            // 
            // GPUbox
            // 
            GPUbox.FormattingEnabled = true;
            GPUbox.Items.AddRange(new object[] { "NVIDIA", "AMD" });
            GPUbox.Location = new Point(185, 48);
            GPUbox.Name = "GPUbox";
            GPUbox.Size = new Size(121, 23);
            GPUbox.TabIndex = 2;
            GPUbox.Text = "GPU";
            GPUbox.SelectedIndexChanged += GPUbox_SelectedIndexChanged;
            // 
            // RAMbox
            // 
            RAMbox.FormattingEnabled = true;
            RAMbox.Items.AddRange(new object[] { "8GB", "16GB", "32GB", "64GB" });
            RAMbox.Location = new Point(339, 48);
            RAMbox.Name = "RAMbox";
            RAMbox.Size = new Size(121, 23);
            RAMbox.TabIndex = 2;
            RAMbox.Text = "RAM";
            RAMbox.SelectedIndexChanged += RAMbox_SelectedIndexChanged;
            // 
            // AvailabilityBox
            // 
            AvailabilityBox.FormattingEnabled = true;
            AvailabilityBox.Items.AddRange(new object[] { "available", "reserved" });
            AvailabilityBox.Location = new Point(492, 48);
            AvailabilityBox.Name = "AvailabilityBox";
            AvailabilityBox.Size = new Size(121, 23);
            AvailabilityBox.TabIndex = 2;
            AvailabilityBox.Text = "Availiabilty";
            AvailabilityBox.SelectedIndexChanged += AvailabilityBox_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(66, 136);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(547, 245);
            dataGridView1.TabIndex = 4;
            // 
            // Clear
            // 
            Clear.Location = new Point(296, 402);
            Clear.Name = "Clear";
            Clear.Size = new Size(75, 23);
            Clear.TabIndex = 5;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // ReserveButton
            // 
            ReserveButton.Location = new Point(127, 402);
            ReserveButton.Name = "ReserveButton";
            ReserveButton.Size = new Size(94, 23);
            ReserveButton.TabIndex = 6;
            ReserveButton.Text = "Reservations";
            ReserveButton.UseVisualStyleBackColor = true;
            ReserveButton.Click += ReserveButton_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ReserveButton);
            Controls.Add(Clear);
            Controls.Add(dataGridView1);
            Controls.Add(AvailabilityBox);
            Controls.Add(RAMbox);
            Controls.Add(GPUbox);
            Controls.Add(CPUbox);
            Controls.Add(label1);
            Controls.Add(exit);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button exit;
        private Label label1;
        private ComboBox CPUbox;
        private ComboBox GPUbox;
        private ComboBox RAMbox;
        private ComboBox AvailabilityBox;
        private DataGridView dataGridView1;
        private Button Clear;
        private Button ReserveButton;
    }
}