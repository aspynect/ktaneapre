using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ktaneapre
{
    public partial class Profile : UserControl
    {
        public static string profileName { get; private set; } = "vanilla";
        public Profile()
        {
            InitializeComponent();
            try
            {
                string[] files = Directory.GetFiles("./profiles", "*.json").Select(Path.GetFileNameWithoutExtension).ToArray();
                comboBoxProfile.Items.AddRange(files);
                JsonHandling.loadData();
                ProfileChanged?.Invoke(this, EventArgs.Empty);
            }
            catch { }
        }

        public event EventHandler? ProfileChanged;

        private void comboBoxProfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            profileName = comboBoxProfile.Text;
            JsonHandling.loadData();
            this.FindForm().Text = $"KTANEAPRE — {profileName}";
            ProfileChanged?.Invoke(this, EventArgs.Empty);
        }

        private void buttonNewProfile_Click(object sender, EventArgs e)
        {
            
        }
    }

    interface Reloadable
    {
        void reload();
    }
}
