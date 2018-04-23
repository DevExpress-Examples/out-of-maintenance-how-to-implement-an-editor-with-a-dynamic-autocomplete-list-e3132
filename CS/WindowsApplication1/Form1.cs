using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsApplication1 {
    public partial class Form1 : DevExpress.XtraEditors.XtraForm {
        public Form1() {
            InitializeComponent();
        }

        private Random random = new Random();

        private string RandomString(int size, bool lowerCase) {
            StringBuilder builder = new StringBuilder();
            char ch;
            for (int i = 0; i < size; i++) {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase) {
                return builder.ToString().ToLower();
            }
            return builder.ToString();
        }


        private void myLookUpEdit1_Properties_GetAutoCompleteList(object sender, AutoCompleteListEventArgs e) {
            GetAutoCompleteList(e);
        }

        private void repositoryItemMyLookUpEdit1_GetAutoCompleteList(object sender, AutoCompleteListEventArgs e) {
            GetAutoCompleteList(e);
        }
        private void GetAutoCompleteList(AutoCompleteListEventArgs e) {
            e.AutoCompleteList.Clear();
            for(int i = 0; i < 10; i++) {
                e.AutoCompleteList.Add(String.Format("{0}{1}", e.AutoSearchText, RandomString(5, true)));
            }
        }
    }
}
