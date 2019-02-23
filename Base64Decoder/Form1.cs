using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base64Decoder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void decodeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var str = System.Convert.FromBase64String(encodedTextBox.Text);
                decodedTextBox.Text = System.Text.Encoding.UTF8.GetString(str);
            } catch (Exception exc)
            {
                Console.WriteLine($"Error; {exc}");
            }
        }


        private void encodeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var str = System.Text.Encoding.UTF8.GetBytes(decodedTextBox.Text);
                encodedTextBox.Text = System.Convert.ToBase64String(str);
            } catch (Exception exc)
            {
                Console.WriteLine($"Error; {exc}");
            }
        }

        private void copyDecodeBtn_Click(object sender, EventArgs e)
        {
           copyToClipBoard(decodedTextBox.Text);
        }

        private void encodeCopyBtn_Click(object sender, EventArgs e)
        {
            copyToClipBoard(encodedTextBox.Text);
        }

        private void copyToClipBoard(string str)
        {
            Clipboard.SetText(str);
        }

        private void openHttpBtn_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(decodedTextBox.Text);
            }
            catch (Exception) { }

        }

        private void encodedPasteBtn_Click(object sender, EventArgs e)
        {
            encodedTextBox.Text = Clipboard.GetText();
        }

        private void decodedPasteBtn_Click(object sender, EventArgs e)
        {
            decodedTextBox.Text = Clipboard.GetText();
        }

        private void clearEncodeBtn_Click(object sender, EventArgs e)
        {
            encodedTextBox.Text = "";
        }

        private void clearDecodeBtn_Click(object sender, EventArgs e)
        {
            decodedTextBox.Text = "";
        }
    }
}
