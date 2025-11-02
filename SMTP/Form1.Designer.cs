namespace SMTP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer    components = null;

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
            textFrom = new TextBox();
            textTo = new TextBox();
            textMessage = new RichTextBox();
            Send = new Button();
            button_file = new Button();
            text_theme = new TextBox();
            text_path = new TextBox();
            SuspendLayout();
            // 
            // textFrom
            // 
            textFrom.Location = new Point(59, 41);
            textFrom.Name = "textFrom";
            textFrom.PlaceholderText = "textFrom";
            textFrom.ReadOnly = true;
            textFrom.Size = new Size(358, 23);
            textFrom.TabIndex = 0;
            textFrom.Text = "xotaoshi@gmail.com";
            // 
            // textTo
            // 
            textTo.Location = new Point(59, 70);
            textTo.Name = "textTo";
            textTo.PlaceholderText = "textTo";
            textTo.Size = new Size(358, 23);
            textTo.TabIndex = 1;
            // 
            // textMessage
            // 
            textMessage.Location = new Point(59, 128);
            textMessage.Name = "textMessage";
            textMessage.Size = new Size(358, 240);
            textMessage.TabIndex = 2;
            textMessage.Text = "";
            // 
            // Send
            // 
            Send.Location = new Point(59, 432);
            Send.Name = "Send";
            Send.Size = new Size(358, 23);
            Send.TabIndex = 3;
            Send.Text = "Send";
            Send.UseVisualStyleBackColor = true;
            Send.Click += Send_Click;
            // 
            // button_file
            // 
            button_file.Location = new Point(59, 374);
            button_file.Name = "button_file";
            button_file.Size = new Size(358, 23);
            button_file.TabIndex = 4;
            button_file.Text = "Add file";
            button_file.UseVisualStyleBackColor = true;
            button_file.Click += button_file_Click;
            // 
            // text_theme
            // 
            text_theme.Location = new Point(59, 99);
            text_theme.Name = "text_theme";
            text_theme.PlaceholderText = "theme";
            text_theme.Size = new Size(358, 23);
            text_theme.TabIndex = 5;
            // 
            // text_path
            // 
            text_path.Location = new Point(59, 403);
            text_path.Name = "text_path";
            text_path.PlaceholderText = "path";
            text_path.Size = new Size(358, 23);
            text_path.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 499);
            Controls.Add(text_path);
            Controls.Add(text_theme);
            Controls.Add(button_file);
            Controls.Add(Send);
            Controls.Add(textMessage);
            Controls.Add(textTo);
            Controls.Add(textFrom);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textFrom;
        private TextBox textTo;
        private RichTextBox textMessage;
        private Button Send;
        private Button button_file;
        private TextBox text_theme;
        private TextBox text_path;
    }
}
