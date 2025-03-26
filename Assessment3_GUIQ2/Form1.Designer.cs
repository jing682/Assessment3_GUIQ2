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
            labelGuess.Location = new Point(154, 90);
            labelGuess.Margin = new Padding(6, 0, 6, 0);
            labelGuess.Name = "labelGuess";
            labelGuess.Size = new Size(89, 32);
            labelGuess.TabIndex = 0;
            labelGuess.Text = "Guess :";
            labelGuess.Click += label1_Click;
            // 
            // richTextBox
            // 
            richTextBox.Location = new Point(93, 171);
            richTextBox.Margin = new Padding(6);
            richTextBox.Name = "richTextBox";
            richTextBox.Size = new Size(466, 296);
            richTextBox.TabIndex = 1;
            richTextBox.Text = "";
            // 
            // textGuess
            // 
            textGuess.Location = new Point(310, 83);
            textGuess.Margin = new Padding(6);
            textGuess.Name = "textGuess";
            textGuess.Size = new Size(182, 39);
            textGuess.TabIndex = 2;
            textGuess.TextChanged += textGuess_TextChanged;
            // 
            // startButton
            // 
            startButton.Location = new Point(254, 510);
            startButton.Margin = new Padding(6);
            startButton.Name = "startButton";
            startButton.Size = new Size(139, 49);
            startButton.TabIndex = 3;
            startButton.Text = "Guess";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 960);
            Controls.Add(startButton);
            Controls.Add(textGuess);
            Controls.Add(richTextBox);
            Controls.Add(labelGuess);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
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
