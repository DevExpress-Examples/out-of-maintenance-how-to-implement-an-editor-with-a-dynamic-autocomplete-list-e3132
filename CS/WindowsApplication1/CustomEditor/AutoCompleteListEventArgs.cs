using System;
using System.Collections.Generic;

namespace WindowsApplication1 {
    public class AutoCompleteListEventArgs : EventArgs {
        public AutoCompleteListEventArgs(string autoSearchText, List<string> list) {
            _AutoCompleteList = list;
            _AutoSearchText = autoSearchText;
        }
        private List<string> _AutoCompleteList;

        private string _AutoSearchText;
        public string AutoSearchText {
            get {
                return _AutoSearchText;
            }
        }


        public List<string> AutoCompleteList {
            get {
                return _AutoCompleteList;
            }
        }
    }
}
