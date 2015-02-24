using System;
using System.Windows.Forms;

namespace _101
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private string ParityCounting()
        {
            bool ParityExist = false;
            foreach (char c in txtParity.Text)
            {
                if (c == '0' || c == '1')
                {
                    ParityExist = true;
                    break;
                }
            }

            int Parity = 0;
            if (ParityExist == true)
            {
                int Pre = 0;
                foreach (char c in txtParity.Text)
                {
                    if (c == '1' && Pre == 0)
                    {
                        Parity = 1;
                        Pre = 1;
                    }
                    else
                    {
                        if (c == '1' && Pre == 1)
                        {
                            Parity = 0;
                            Pre = 0;
                        }
                    }
                }
            }
            if (Parity == 0)
                return "Even";
            else
                return "Odd";
        }

        private string PreliminarityCheck()
        {
            string data = txtPreliminary.Text;
            bool result = false;

            if (data.Length > 1)
            {
                for (int i = 0; i < data.Length; i++)
                {
                    if (data[0] == data[data.Length - 1])
                    {
                        data = data.Substring(1, data.Length - 2);
                        result = true;
                    }
                    else
                    {
                        result = false;
                        break;
                    }
                }
            }
            else
                result = true;

            return result.ToString();
        }

        private string ParenthesisCheck()
        {
            return "";
        }

        private void txtdata_TextChanged(object sender, EventArgs e)
        {
            if (txtParity.Text == "")
                lblParity.Text = "";
            else
                lblParity.Text = ParityCounting();
        }

        private void txtPreliminary_TextChanged(object sender, EventArgs e)
        {
            if (txtPreliminary.Text.Length == 0)
                lblPreliminary.Text = "";
            else
                lblPreliminary.Text = PreliminarityCheck();
        }

        private void txtlblParenthesis_TextChanged(object sender, EventArgs e)
        {
            if (txtlblParenthesis.Text.Length == 0)
                lblParenthesisCheck.Text = "";
            else
                lblParenthesisCheck.Text = ParenthesisCheck();
        }

    }
}