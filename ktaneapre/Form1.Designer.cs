namespace ktaneapre
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
            tabControl1 = new TabControl();
            tabPageWireSequences = new TabPage();
            wireSequences1 = new WireSequences();
            tabPagePasswords = new TabPage();
            passwords2 = new Passwords();
            tabPageKnob = new TabPage();
            knob2 = new Knob();
            tabPageProfile = new TabPage();
            profile1 = new Profile();
            tabControl1.SuspendLayout();
            tabPageWireSequences.SuspendLayout();
            tabPagePasswords.SuspendLayout();
            tabPageKnob.SuspendLayout();
            tabPageProfile.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageWireSequences);
            tabControl1.Controls.Add(tabPagePasswords);
            tabControl1.Controls.Add(tabPageKnob);
            tabControl1.Controls.Add(tabPageProfile);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1100, 690);
            tabControl1.TabIndex = 18;
            // 
            // tabPageWireSequences
            // 
            tabPageWireSequences.Controls.Add(wireSequences1);
            tabPageWireSequences.Location = new Point(4, 34);
            tabPageWireSequences.Name = "tabPageWireSequences";
            tabPageWireSequences.Padding = new Padding(3);
            tabPageWireSequences.Size = new Size(1092, 652);
            tabPageWireSequences.TabIndex = 0;
            tabPageWireSequences.Text = "Wire Sequences";
            tabPageWireSequences.UseVisualStyleBackColor = true;
            // 
            // wireSequences1
            // 
            wireSequences1.Dock = DockStyle.Fill;
            wireSequences1.Location = new Point(3, 3);
            wireSequences1.Name = "wireSequences1";
            wireSequences1.Size = new Size(1086, 646);
            wireSequences1.TabIndex = 0;
            // 
            // tabPagePasswords
            // 
            tabPagePasswords.Controls.Add(passwords2);
            tabPagePasswords.Location = new Point(4, 24);
            tabPagePasswords.Name = "tabPagePasswords";
            tabPagePasswords.Padding = new Padding(3);
            tabPagePasswords.Size = new Size(1092, 662);
            tabPagePasswords.TabIndex = 2;
            tabPagePasswords.Text = "Passwords";
            tabPagePasswords.UseVisualStyleBackColor = true;
            // 
            // passwords2
            // 
            passwords2.Dock = DockStyle.Fill;
            passwords2.Location = new Point(3, 3);
            passwords2.Name = "passwords2";
            passwords2.Size = new Size(1086, 656);
            passwords2.TabIndex = 0;
            // 
            // tabPageKnob
            // 
            tabPageKnob.Controls.Add(knob2);
            tabPageKnob.Location = new Point(4, 24);
            tabPageKnob.Name = "tabPageKnob";
            tabPageKnob.Padding = new Padding(3);
            tabPageKnob.Size = new Size(1092, 662);
            tabPageKnob.TabIndex = 3;
            tabPageKnob.Text = "Knob";
            tabPageKnob.UseVisualStyleBackColor = true;
            // 
            // knob2
            // 
            knob2.Dock = DockStyle.Fill;
            knob2.Location = new Point(3, 3);
            knob2.Name = "knob2";
            knob2.Size = new Size(1086, 656);
            knob2.TabIndex = 0;
            // 
            // tabPageProfile
            // 
            tabPageProfile.Controls.Add(profile1);
            tabPageProfile.Location = new Point(4, 34);
            tabPageProfile.Name = "tabPageProfile";
            tabPageProfile.Padding = new Padding(3);
            tabPageProfile.Size = new Size(1092, 652);
            tabPageProfile.TabIndex = 1;
            tabPageProfile.Text = "Profile";
            tabPageProfile.UseVisualStyleBackColor = true;
            // 
            // profile1
            // 
            profile1.Dock = DockStyle.Fill;
            profile1.Location = new Point(3, 3);
            profile1.Name = "profile1";
            profile1.Size = new Size(1086, 646);
            profile1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 690);
            Controls.Add(tabControl1);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "KTANEAPRE";
            TopMost = true;
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPageWireSequences.ResumeLayout(false);
            tabPagePasswords.ResumeLayout(false);
            tabPageKnob.ResumeLayout(false);
            tabPageProfile.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPageWireSequences;
        private TabPage tabPageProfile;
        private TabPage tabPagePasswords;
        private TabPage tabPageKnob;
        private WireSequences wireSequences1;
        private Passwords passwords2;
        private Knob knob2;
        private Profile profile1;
    }
}
