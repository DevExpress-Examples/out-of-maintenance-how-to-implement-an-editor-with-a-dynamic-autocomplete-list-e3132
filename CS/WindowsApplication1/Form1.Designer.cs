namespace WindowsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.myLookUpEdit1 = new WindowsApplication1.MyLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.myLookUpEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // myLookUpEdit1
            // 
            this.myLookUpEdit1.Location = new System.Drawing.Point(12, 12);
            this.myLookUpEdit1.Name = "myLookUpEdit1";
            this.myLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.myLookUpEdit1.Properties.DataSource = ((object)(resources.GetObject("myLookUpEdit1.Properties.DataSource")));
            this.myLookUpEdit1.Properties.ImmediatePopup = true;
            this.myLookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.myLookUpEdit1.Properties.GetAutoCompleteList += new WindowsApplication1.GetAutoCompleteListEventHandler(this.myLookUpEdit1_Properties_GetAutoCompleteList);
            this.myLookUpEdit1.Size = new System.Drawing.Size(266, 22);
            this.myLookUpEdit1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 75);
            this.Controls.Add(this.myLookUpEdit1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.myLookUpEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyLookUpEdit myLookUpEdit1;


    }
}

