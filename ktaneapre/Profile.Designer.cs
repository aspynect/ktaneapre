namespace ktaneapre
{
    partial class Profile
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
            groupBoxProfile = new GroupBox();
            comboBoxProfile = new ComboBox();
            buttonNewProfile = new Button();
            groupBoxProfile.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxProfile
            // 
            groupBoxProfile.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxProfile.Controls.Add(comboBoxProfile);
            groupBoxProfile.Controls.Add(buttonNewProfile);
            groupBoxProfile.Location = new Point(3, 3);
            groupBoxProfile.Name = "groupBoxProfile";
            groupBoxProfile.Size = new Size(413, 202);
            groupBoxProfile.TabIndex = 1;
            groupBoxProfile.TabStop = false;
            groupBoxProfile.Text = "Profile";
            // 
            // comboBoxProfile
            // 
            comboBoxProfile.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProfile.FormattingEnabled = true;
            comboBoxProfile.Location = new Point(6, 22);
            comboBoxProfile.Name = "comboBoxProfile";
            comboBoxProfile.Size = new Size(319, 23);
            comboBoxProfile.TabIndex = 4;
            comboBoxProfile.SelectedIndexChanged += comboBoxProfile_SelectedIndexChanged;
            // 
            // buttonNewProfile
            // 
            buttonNewProfile.BackColor = Color.White;
            buttonNewProfile.Location = new Point(6, 53);
            buttonNewProfile.Margin = new Padding(5);
            buttonNewProfile.Name = "buttonNewProfile";
            buttonNewProfile.Size = new Size(84, 38);
            buttonNewProfile.TabIndex = 3;
            buttonNewProfile.Text = "New";
            buttonNewProfile.UseVisualStyleBackColor = false;
            buttonNewProfile.Click += buttonNewProfile_Click;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBoxProfile);
            Name = "Profile";
            Size = new Size(419, 211);
            groupBoxProfile.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxProfile;
        private ComboBox comboBoxProfile;
        private Button buttonNewProfile;
    }
}
