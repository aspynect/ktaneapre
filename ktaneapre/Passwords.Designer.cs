namespace ktaneapre
{
    partial class Passwords
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxPasswordsInput = new GroupBox();
            textBoxPasswords5 = new TextBox();
            textBoxPasswords4 = new TextBox();
            textBoxPasswords3 = new TextBox();
            textBoxPasswords2 = new TextBox();
            textBoxPasswords1 = new TextBox();
            groupBoxPasswordsOutput = new GroupBox();
            labelPasswordsOutput = new Label();
            groupBoxPasswordsInput.SuspendLayout();
            groupBoxPasswordsOutput.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxPasswordsInput
            // 
            groupBoxPasswordsInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxPasswordsInput.Controls.Add(textBoxPasswords5);
            groupBoxPasswordsInput.Controls.Add(textBoxPasswords4);
            groupBoxPasswordsInput.Controls.Add(textBoxPasswords3);
            groupBoxPasswordsInput.Controls.Add(textBoxPasswords2);
            groupBoxPasswordsInput.Controls.Add(textBoxPasswords1);
            groupBoxPasswordsInput.Location = new Point(3, 3);
            groupBoxPasswordsInput.Name = "groupBoxPasswordsInput";
            groupBoxPasswordsInput.Size = new Size(827, 172);
            groupBoxPasswordsInput.TabIndex = 0;
            groupBoxPasswordsInput.TabStop = false;
            groupBoxPasswordsInput.Text = "Passwords Input";
            // 
            // textBoxPasswords5
            // 
            textBoxPasswords5.Location = new Point(6, 138);
            textBoxPasswords5.Name = "textBoxPasswords5";
            textBoxPasswords5.Size = new Size(100, 23);
            textBoxPasswords5.TabIndex = 4;
            textBoxPasswords5.TextChanged += textBoxPasswords5_TextChanged;
            // 
            // textBoxPasswords4
            // 
            textBoxPasswords4.Location = new Point(6, 109);
            textBoxPasswords4.Name = "textBoxPasswords4";
            textBoxPasswords4.Size = new Size(100, 23);
            textBoxPasswords4.TabIndex = 3;
            textBoxPasswords4.TextChanged += textBoxPasswords4_TextChanged;
            // 
            // textBoxPasswords3
            // 
            textBoxPasswords3.Location = new Point(6, 80);
            textBoxPasswords3.Name = "textBoxPasswords3";
            textBoxPasswords3.Size = new Size(100, 23);
            textBoxPasswords3.TabIndex = 2;
            textBoxPasswords3.TextChanged += textBoxPasswords3_TextChanged;
            // 
            // textBoxPasswords2
            // 
            textBoxPasswords2.Location = new Point(6, 51);
            textBoxPasswords2.Name = "textBoxPasswords2";
            textBoxPasswords2.Size = new Size(100, 23);
            textBoxPasswords2.TabIndex = 1;
            textBoxPasswords2.TextChanged += textBoxPasswords2_TextChanged;
            // 
            // textBoxPasswords1
            // 
            textBoxPasswords1.Location = new Point(6, 22);
            textBoxPasswords1.Name = "textBoxPasswords1";
            textBoxPasswords1.Size = new Size(100, 23);
            textBoxPasswords1.TabIndex = 0;
            textBoxPasswords1.TextChanged += textBoxPasswords1_TextChanged;
            // 
            // groupBoxPasswordsOutput
            // 
            groupBoxPasswordsOutput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxPasswordsOutput.Controls.Add(labelPasswordsOutput);
            groupBoxPasswordsOutput.Location = new Point(3, 181);
            groupBoxPasswordsOutput.Name = "groupBoxPasswordsOutput";
            groupBoxPasswordsOutput.Size = new Size(827, 339);
            groupBoxPasswordsOutput.TabIndex = 5;
            groupBoxPasswordsOutput.TabStop = false;
            groupBoxPasswordsOutput.Text = "Passwords Output";
            // 
            // labelPasswordsOutput
            // 
            labelPasswordsOutput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelPasswordsOutput.Location = new Point(6, 19);
            labelPasswordsOutput.Name = "labelPasswordsOutput";
            labelPasswordsOutput.Size = new Size(815, 317);
            labelPasswordsOutput.TabIndex = 0;
            // 
            // Passwords
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBoxPasswordsOutput);
            Controls.Add(groupBoxPasswordsInput);
            Name = "Passwords";
            Size = new Size(833, 523);
            groupBoxPasswordsInput.ResumeLayout(false);
            groupBoxPasswordsInput.PerformLayout();
            groupBoxPasswordsOutput.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxPasswordsInput;
        private TextBox textBoxPasswords5;
        private TextBox textBoxPasswords4;
        private TextBox textBoxPasswords3;
        private TextBox textBoxPasswords2;
        private TextBox textBoxPasswords1;
        private GroupBox groupBoxPasswordsOutput;
        private Label labelPasswordsOutput;
    }
}
