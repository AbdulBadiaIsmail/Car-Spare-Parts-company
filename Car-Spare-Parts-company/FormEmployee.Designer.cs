namespace Car_Spare_Parts_company
{
    partial class FormEmployee
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID_text_box = new System.Windows.Forms.TextBox();
            this.Adderss_text_box = new System.Windows.Forms.TextBox();
            this.phone_text_box = new System.Windows.Forms.TextBox();
            this.salar_text_box = new System.Windows.Forms.TextBox();
            this.Last_name_text_box = new System.Windows.Forms.TextBox();
            this.fir_Text_box = new System.Windows.Forms.TextBox();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.Firs_Name_label = new DevExpress.XtraLayout.LayoutControlItem();
            this.LastName_labe = new DevExpress.XtraLayout.LayoutControlItem();
            this.Salar_label = new DevExpress.XtraLayout.LayoutControlItem();
            this.Phone_label = new DevExpress.XtraLayout.LayoutControlItem();
            this.Adderss_label = new DevExpress.XtraLayout.LayoutControlItem();
            this.ID_text = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Add_data = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Clear_data = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Delete_data = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.update_data = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Firs_Name_label)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastName_labe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salar_label)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Phone_label)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Adderss_label)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID_text)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.update_data);
            this.layoutControl1.Controls.Add(this.Delete_data);
            this.layoutControl1.Controls.Add(this.Clear_data);
            this.layoutControl1.Controls.Add(this.Add_data);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.ID_text_box);
            this.layoutControl1.Controls.Add(this.Adderss_text_box);
            this.layoutControl1.Controls.Add(this.phone_text_box);
            this.layoutControl1.Controls.Add(this.salar_text_box);
            this.layoutControl1.Controls.Add(this.Last_name_text_box);
            this.layoutControl1.Controls.Add(this.fir_Text_box);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ID_text});
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(716, 7, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(896, 354);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 111);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(872, 231);
            this.gridControl1.TabIndex = 10;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // ID_text_box
            // 
            this.ID_text_box.Location = new System.Drawing.Point(450, 60);
            this.ID_text_box.Multiline = true;
            this.ID_text_box.Name = "ID_text_box";
            this.ID_text_box.Size = new System.Drawing.Size(434, 20);
            this.ID_text_box.TabIndex = 9;
            this.ID_text_box.Visible = false;
            // 
            // Adderss_text_box
            // 
            this.Adderss_text_box.Location = new System.Drawing.Point(100, 60);
            this.Adderss_text_box.Multiline = true;
            this.Adderss_text_box.Name = "Adderss_text_box";
            this.Adderss_text_box.Size = new System.Drawing.Size(784, 20);
            this.Adderss_text_box.TabIndex = 8;
            // 
            // phone_text_box
            // 
            this.phone_text_box.Location = new System.Drawing.Point(538, 36);
            this.phone_text_box.Name = "phone_text_box";
            this.phone_text_box.Size = new System.Drawing.Size(346, 20);
            this.phone_text_box.TabIndex = 7;
            // 
            // salar_text_box
            // 
            this.salar_text_box.Location = new System.Drawing.Point(100, 36);
            this.salar_text_box.Name = "salar_text_box";
            this.salar_text_box.Size = new System.Drawing.Size(346, 20);
            this.salar_text_box.TabIndex = 6;
            // 
            // Last_name_text_box
            // 
            this.Last_name_text_box.Location = new System.Drawing.Point(538, 12);
            this.Last_name_text_box.Name = "Last_name_text_box";
            this.Last_name_text_box.Size = new System.Drawing.Size(346, 20);
            this.Last_name_text_box.TabIndex = 5;
            // 
            // fir_Text_box
            // 
            this.fir_Text_box.Location = new System.Drawing.Point(100, 12);
            this.fir_Text_box.Name = "fir_Text_box";
            this.fir_Text_box.Size = new System.Drawing.Size(346, 20);
            this.fir_Text_box.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.Firs_Name_label,
            this.LastName_labe,
            this.Salar_label,
            this.Phone_label,
            this.Adderss_label,
            this.layoutControlItem7,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.simpleSeparator1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(896, 354);
            this.Root.TextVisible = false;
            // 
            // Firs_Name_label
            // 
            this.Firs_Name_label.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Firs_Name_label.AppearanceItemCaption.Options.UseFont = true;
            this.Firs_Name_label.AppearanceItemCaptionDisabled.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Firs_Name_label.AppearanceItemCaptionDisabled.Options.UseFont = true;
            this.Firs_Name_label.Control = this.fir_Text_box;
            this.Firs_Name_label.Location = new System.Drawing.Point(0, 0);
            this.Firs_Name_label.Name = "Firs_Name_label";
            this.Firs_Name_label.Size = new System.Drawing.Size(438, 24);
            this.Firs_Name_label.Text = "First Name :";
            this.Firs_Name_label.TextSize = new System.Drawing.Size(76, 16);
            // 
            // LastName_labe
            // 
            this.LastName_labe.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName_labe.AppearanceItemCaption.Options.UseFont = true;
            this.LastName_labe.Control = this.Last_name_text_box;
            this.LastName_labe.Location = new System.Drawing.Point(438, 0);
            this.LastName_labe.Name = "LastName_labe";
            this.LastName_labe.Size = new System.Drawing.Size(438, 24);
            this.LastName_labe.Text = "Last Name :";
            this.LastName_labe.TextSize = new System.Drawing.Size(76, 16);
            // 
            // Salar_label
            // 
            this.Salar_label.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salar_label.AppearanceItemCaption.Options.UseFont = true;
            this.Salar_label.Control = this.salar_text_box;
            this.Salar_label.Location = new System.Drawing.Point(0, 24);
            this.Salar_label.Name = "Salar_label";
            this.Salar_label.Size = new System.Drawing.Size(438, 24);
            this.Salar_label.Text = "Salary : ";
            this.Salar_label.TextSize = new System.Drawing.Size(76, 16);
            // 
            // Phone_label
            // 
            this.Phone_label.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone_label.AppearanceItemCaption.Options.UseFont = true;
            this.Phone_label.Control = this.phone_text_box;
            this.Phone_label.CustomizationFormText = "Phone :";
            this.Phone_label.Location = new System.Drawing.Point(438, 24);
            this.Phone_label.Name = "Phone_label";
            this.Phone_label.Size = new System.Drawing.Size(438, 24);
            this.Phone_label.Text = "Phone :";
            this.Phone_label.TextSize = new System.Drawing.Size(76, 16);
            // 
            // Adderss_label
            // 
            this.Adderss_label.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adderss_label.AppearanceItemCaption.Options.UseFont = true;
            this.Adderss_label.Control = this.Adderss_text_box;
            this.Adderss_label.Location = new System.Drawing.Point(0, 48);
            this.Adderss_label.MaxSize = new System.Drawing.Size(876, 24);
            this.Adderss_label.MinSize = new System.Drawing.Size(876, 24);
            this.Adderss_label.Name = "Adderss_label";
            this.Adderss_label.Size = new System.Drawing.Size(876, 24);
            this.Adderss_label.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.Adderss_label.Text = "Adderss :";
            this.Adderss_label.TextSize = new System.Drawing.Size(76, 16);
            // 
            // ID_text
            // 
            this.ID_text.Control = this.ID_text_box;
            this.ID_text.Location = new System.Drawing.Point(438, 48);
            this.ID_text.Name = "ID_text";
            this.ID_text.Size = new System.Drawing.Size(438, 24);
            this.ID_text.Text = "ID";
            this.ID_text.TextSize = new System.Drawing.Size(0, 0);
            this.ID_text.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.gridControl1;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 99);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(876, 235);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // Add_data
            // 
            this.Add_data.Appearance.BackColor = System.Drawing.Color.Silver;
            this.Add_data.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_data.Appearance.Options.UseBackColor = true;
            this.Add_data.Appearance.Options.UseFont = true;
            this.Add_data.Location = new System.Drawing.Point(12, 85);
            this.Add_data.Name = "Add_data";
            this.Add_data.Size = new System.Drawing.Size(214, 22);
            this.Add_data.StyleController = this.layoutControl1;
            this.Add_data.TabIndex = 11;
            this.Add_data.Text = "AddEmployee";
            this.Add_data.Click += new System.EventHandler(this.Add_data_Click);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.Add_data;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 73);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(218, 26);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // Clear_data
            // 
            this.Clear_data.Appearance.BackColor = System.Drawing.Color.Silver;
            this.Clear_data.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_data.Appearance.Options.UseBackColor = true;
            this.Clear_data.Appearance.Options.UseFont = true;
            this.Clear_data.Location = new System.Drawing.Point(684, 85);
            this.Clear_data.Name = "Clear_data";
            this.Clear_data.Size = new System.Drawing.Size(200, 22);
            this.Clear_data.StyleController = this.layoutControl1;
            this.Clear_data.TabIndex = 12;
            this.Clear_data.Text = "Clear";
            this.Clear_data.Click += new System.EventHandler(this.Clear_data_Click);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.Clear_data;
            this.layoutControlItem2.Location = new System.Drawing.Point(672, 73);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(204, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // Delete_data
            // 
            this.Delete_data.Appearance.BackColor = System.Drawing.Color.Silver;
            this.Delete_data.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_data.Appearance.Options.UseBackColor = true;
            this.Delete_data.Appearance.Options.UseFont = true;
            this.Delete_data.Location = new System.Drawing.Point(449, 85);
            this.Delete_data.Name = "Delete_data";
            this.Delete_data.Size = new System.Drawing.Size(231, 22);
            this.Delete_data.StyleController = this.layoutControl1;
            this.Delete_data.TabIndex = 13;
            this.Delete_data.Text = "Delete";
            this.Delete_data.Click += new System.EventHandler(this.Delete_data_Click);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.Delete_data;
            this.layoutControlItem3.Location = new System.Drawing.Point(437, 73);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(235, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // update_data
            // 
            this.update_data.Appearance.BackColor = System.Drawing.Color.Silver;
            this.update_data.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_data.Appearance.Options.UseBackColor = true;
            this.update_data.Appearance.Options.UseFont = true;
            this.update_data.Location = new System.Drawing.Point(230, 85);
            this.update_data.Name = "update_data";
            this.update_data.Size = new System.Drawing.Size(215, 22);
            this.update_data.StyleController = this.layoutControl1;
            this.update_data.TabIndex = 14;
            this.update_data.Text = "Update";
            this.update_data.Click += new System.EventHandler(this.update_data_Click);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.update_data;
            this.layoutControlItem4.Location = new System.Drawing.Point(218, 73);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(219, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.Location = new System.Drawing.Point(0, 72);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(876, 1);
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 354);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FormEmployee";
            this.Text = "FormEmployee";
            this.Load += new System.EventHandler(this.FormEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Firs_Name_label)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastName_labe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salar_label)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Phone_label)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Adderss_label)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID_text)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TextBox ID_text_box;
        private System.Windows.Forms.TextBox Adderss_text_box;
        private System.Windows.Forms.TextBox phone_text_box;
        private System.Windows.Forms.TextBox salar_text_box;
        private System.Windows.Forms.TextBox Last_name_text_box;
        private System.Windows.Forms.TextBox fir_Text_box;
        private DevExpress.XtraLayout.LayoutControlItem Firs_Name_label;
        private DevExpress.XtraLayout.LayoutControlItem LastName_labe;
        private DevExpress.XtraLayout.LayoutControlItem Salar_label;
        private DevExpress.XtraLayout.LayoutControlItem Phone_label;
        private DevExpress.XtraLayout.LayoutControlItem Adderss_label;
        private DevExpress.XtraLayout.LayoutControlItem ID_text;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.SimpleButton update_data;
        private DevExpress.XtraEditors.SimpleButton Delete_data;
        private DevExpress.XtraEditors.SimpleButton Clear_data;
        private DevExpress.XtraEditors.SimpleButton Add_data;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
    }
}