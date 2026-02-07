using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace ktaneapre
{
    public partial class Passwords : UserControl
    {
        string[] words;
        string[] passwordLetters = { "", "", "", "", "" };

        public void reloadPasswordData()
        {
            //TODO make this work
            words = JsonHandling.Data.Passwords;
        }

        public Passwords()
        {

            try
            {
                InitializeComponent();
                reloadPasswordData();
            }
            catch (Exception e){}
        }

        private void checkWordListsAndUpdateOutput()
        {
            string[] filteredWords = words
                .Where(word =>
                {
                    if (word.Length != 5) return false;
                    for (int i = 0; i < 5; i++)
                    {
                        if (!string.IsNullOrEmpty(passwordLetters[i]) &&
                        !passwordLetters[i].Contains(word[i], StringComparison.OrdinalIgnoreCase))
                            return false;
                    }
                    return true;
                }).ToArray();
            string outputString = "";
            foreach (string i in filteredWords)
            {
                outputString += $"{i}, ";
            }
            labelPasswordsOutput.Text = outputString.TrimEnd(',', ' ').ToString();
        }

        private void textBoxPasswords1_TextChanged(object sender, EventArgs e)
        {
            checkWordListsAndUpdateOutput();
            passwordLetters[0] = textBoxPasswords1.Text;
        }

        private void textBoxPasswords2_TextChanged(object sender, EventArgs e)
        {
            checkWordListsAndUpdateOutput();
            passwordLetters[1] = textBoxPasswords2.Text;

        }

        private void textBoxPasswords3_TextChanged(object sender, EventArgs e)
        {
            checkWordListsAndUpdateOutput();
            passwordLetters[2] = textBoxPasswords3.Text;

        }

        private void textBoxPasswords4_TextChanged(object sender, EventArgs e)
        {
            checkWordListsAndUpdateOutput();
            passwordLetters[3] = textBoxPasswords4.Text;

        }

        private void textBoxPasswords5_TextChanged(object sender, EventArgs e)
        {
            checkWordListsAndUpdateOutput();
            passwordLetters[4] = textBoxPasswords5.Text;

        }
    }
}
