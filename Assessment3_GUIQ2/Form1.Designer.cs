namespace Assessment3_GUIQ2
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
            labelGuess = new Label();
            richTextBox = new RichTextBox();
            textGuess = new TextBox();
            startButton = new Button();
            SuspendLayout();
            // 
            // labelGuess
            // 
            labelGuess.AutoSize = true;
            labelGuess.Location = new Point(83, 42);
            labelGuess.Name = "labelGuess";
            labelGuess.Size = new Size(44, 15);
            labelGuess.TabIndex = 0;
            labelGuess.Text = "Guess :";
            labelGuess.Click += label1_Click;
            // 
            // richTextBox
            // 
            richTextBox.Location = new Point(50, 80);
            richTextBox.Name = "richTextBox";
            richTextBox.Size = new Size(253, 141);
            richTextBox.TabIndex = 1;
            richTextBox.Text = "";
            // 
            // textGuess
            // 
            textGuess.Location = new Point(167, 39);
            textGuess.Name = "textGuess";
            textGuess.Size = new Size(100, 23);
            textGuess.TabIndex = 2;
            // 
            // startButton
            // 
            startButton.Location = new Point(137, 239);
            startButton.Name = "startButton";
            startButton.Size = new Size(75, 23);
            startButton.TabIndex = 3;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(startButton);
            Controls.Add(textGuess);
            Controls.Add(richTextBox);
            Controls.Add(labelGuess);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelGuess;
        private RichTextBox richTextBox;
        private TextBox textGuess;
        private Button startButton;
    }
}
