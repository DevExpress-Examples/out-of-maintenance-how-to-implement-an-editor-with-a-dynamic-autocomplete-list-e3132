using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();

        }

        Random random = new Random();

        private string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }


        private void myLookUpEdit1_Properties_GetAutoCompleteList(object sender, AutoCompleteListEventArgs e)
        {
            e.AutoCompleteList.Clear();
            for (int i = 0; i < 10; i++)
            {
                e.AutoCompleteList.Add(String.Format("{0}{1}", e.AutoSearchText, RandomString(5, true)));
            }
        }
    }
}