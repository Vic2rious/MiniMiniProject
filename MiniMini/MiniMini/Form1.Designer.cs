namespace MiniMini
{
    partial class Form1
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
            usernameBox = new TextBox();
            LoginButton = new Button();
            ExitButton = new Button();
            PasswordBox = new TextBox();
            SuspendLayout();
            // 
            // usernameBox
            // 
            usernameBox.Location = new Point(315, 77);
            usernameBox.Name = "usernameBox";
            usernameBox.PlaceholderText = "username";
            usernameBox.Size = new Size(100, 23);
            usernameBox.TabIndex = 0;
            usernameBox.TextChanged += textBox1_TextChanged;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(326, 256);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(75, 23);
            LoginButton.TabIndex = 2;
            LoginButton.Text = "Log In";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(326, 346);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(75, 23);
            ExitButton.TabIndex = 3;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // PasswordBox
            // 
            PasswordBox.Location = new Point(315, 158);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.PasswordChar = '*';
            PasswordBox.PlaceholderText = "password";
            PasswordBox.Size = new Size(100, 23);
            PasswordBox.TabIndex = 0;
            PasswordBox.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ExitButton);
            Controls.Add(LoginButton);
            Controls.Add(PasswordBox);
            Controls.Add(usernameBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameBox;
        private Button LoginButton;
        private Button ExitButton;
        private TextBox PasswordBox;
    }
}