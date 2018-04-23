using System;
using System.ComponentModel;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Registrator;
using System.Collections.Generic;

namespace WindowsApplication1 {
    public delegate void GetAutoCompleteListEventHandler(object sender, AutoCompleteListEventArgs e);

    [System.ComponentModel.DesignerCategory("")]
    [UserRepositoryItem("Register")]
    public class RepositoryItemMyLookUpEdit : RepositoryItemLookUpEdit {
        private static readonly object getAutoCompleteList = new object();

        public event GetAutoCompleteListEventHandler GetAutoCompleteList {
            add {
                Events.AddHandler(getAutoCompleteList, value);
                OnPropertiesChanged();
            }
            remove {
                Events.RemoveHandler(getAutoCompleteList, value);
                OnPropertiesChanged();
            }
        }


        /// <summary>
        /// Triggers the GetAutoCompleteList event.
        /// </summary>
        public virtual void RaiseGetAutoCompleteList(AutoCompleteListEventArgs ea) {
            GetAutoCompleteListEventHandler handler = (GetAutoCompleteListEventHandler)Events[getAutoCompleteList];
            if (handler != null) {
                handler(GetEventSender(), ea);
            }
        }


        static RepositoryItemMyLookUpEdit() {
            Register();
        }
        public RepositoryItemMyLookUpEdit() {
            DataSource = new List<string>();
            ImmediatePopup = true;
            TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
        }
        internal const string EditorName = "MyLookUpEdit";

        public static void Register() {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(EditorName, typeof(MyLookUpEdit),
                typeof(RepositoryItemMyLookUpEdit), typeof(DevExpress.XtraEditors.ViewInfo.LookUpEditViewInfo),
                new DevExpress.XtraEditors.Drawing.ButtonEditPainter(), true, null));
        }
        public override string EditorTypeName {
            get {
                return EditorName;
            }
        }
        public void UpdateDataSource(string autoSearchText) {
            List<string> items = DataAdapter.DataSource as List<string>;
            RaiseGetAutoCompleteList(new AutoCompleteListEventArgs(autoSearchText, items));
        }
        public override void Assign(RepositoryItem item) {
            BeginUpdate();
            try {
                base.Assign(item);
                RepositoryItemMyLookUpEdit source = item as RepositoryItemMyLookUpEdit;
                if(source == null)
                    return;
                Events.AddHandler(getAutoCompleteList, source.Events[getAutoCompleteList]);
            } finally {
                EndUpdate();
            }
        }
    }
}
