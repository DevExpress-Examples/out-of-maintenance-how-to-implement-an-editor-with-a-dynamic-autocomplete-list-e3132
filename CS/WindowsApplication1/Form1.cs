using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApplication1 {
    public partial class Form1 : DevExpress.XtraEditors.XtraForm {
        public Form1() {
            InitializeComponent();
        }

     
        private void lookUpEdit1_AutoSuggest(object sender, DevExpress.XtraEditors.Controls.LookUpEditAutoSuggestEventArgs e) {
            e.QuerySuggestions = Task.Run(() => GetData());
        }
        private ICollection GetData() {
            var list = new List<string>();
            for(int i = 0; i < 10; i++) {
                list.Add(RandomString(5, true));
            }
            return list;
        }
        private readonly Random random = new Random();
        private string RandomString(int size, bool lowerCase) {
            StringBuilder builder = new StringBuilder();
            char ch;
            for(int i = 0; i < size; i++) {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if(lowerCase) {
                return builder.ToString().ToLower();
            }
            return builder.ToString();
        }
    }
}
