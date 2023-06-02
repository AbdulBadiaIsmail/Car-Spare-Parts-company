namespace Car_Spare_Parts_company
{
    partial class fromClient
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.Name_text = new System.Windows.Forms.TextBox();
            this.text_ID = new System.Windows.Forms.TextBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Car_Spare_Parts_company_Car_Company_DBDataSet = new Car_Spare_Parts_company._Car_Spare_Parts_company_Car_Company_DBDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clientsTableAdapter = new Car_Spare_Parts_company._Car_Spare_Parts_company_Car_Company_DBDataSetTableAdapters.ClientsTableAdapter();
            this.Add_client = new DevExpress.XtraEditors.SimpleButton();
            this.Clear_from = new DevExpress.XtraEditors.SimpleButton();
            this.Delete_Client = new DevExpress.XtraEditors.SimpleButton();
            this.Update_Client = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Car_Spare_Parts_company_Car_Company_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name  :";
            // 
            // Name_text
            // 
            this.Name_text.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_text.Location = new System.Drawing.Point(94, 10);
            this.Name_text.Multiline = true;
            this.Name_text.Name = "Name_text";
            this.Name_text.Size = new System.Drawing.Size(212, 30);
            this.Name_text.TabIndex = 1;
            // 
            // text_ID
            // 
            this.text_ID.Location = new System.Drawing.Point(612, 13);
            this.text_ID.Multiline = true;
            this.text_ID.Name = "text_ID";
            this.text_ID.Size = new System.Drawing.Size(100, 20);
            this.text_ID.TabIndex = 2;
            this.text_ID.Visible = false;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.clientsBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(2, 102);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(934, 163);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this._Car_Spare_Parts_company_Car_Company_DBDataSet;
            // 
            // _Car_Spare_Parts_company_Car_Company_DBDataSet
            // 
            this._Car_Spare_Parts_company_Car_Company_DBDataSet.DataSetName = "_Car_Spare_Parts_company_Car_Company_DBDataSet";
            this._Car_Spare_Parts_company_Car_Company_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colName});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colID
            // 
            this.colID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colID.AppearanceHeader.Options.UseFont = true;
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowEdit = false;
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colName
            // 
            this.colName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colName.AppearanceHeader.Options.UseFont = true;
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // Add_client
            // 
            this.Add_client.Appearance.BackColor = System.Drawing.Color.Silver;
            this.Add_client.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_client.Appearance.Options.UseBackColor = true;
            this.Add_client.Appearance.Options.UseFont = true;
            this.Add_client.Location = new System.Drawing.Point(36, 63);
            this.Add_client.Name = "Add_client";
            this.Add_client.Size = new System.Drawing.Size(144, 33);
            this.Add_client.TabIndex = 4;
            this.Add_client.Text = "AddClient";
            this.Add_client.Click += new System.EventHandler(this.Add_client_Click);
            // 
            // Clear_from
            // 
            this.Clear_from.Appearance.BackColor = System.Drawing.Color.Silver;
            this.Clear_from.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_from.Appearance.Options.UseBackColor = true;
            this.Clear_from.Appearance.Options.UseFont = true;
            this.Clear_from.Location = new System.Drawing.Point(725, 63);
            this.Clear_from.Name = "Clear_from";
            this.Clear_from.Size = new System.Drawing.Size(144, 33);
            this.Clear_from.TabIndex = 5;
            this.Clear_from.Text = "Clear";
            this.Clear_from.Click += new System.EventHandler(this.Clear_from_Click);
            // 
            // Delete_Client
            // 
            this.Delete_Client.Appearance.BackColor = System.Drawing.Color.Silver;
            this.Delete_Client.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Client.Appearance.Options.UseBackColor = true;
            this.Delete_Client.Appearance.Options.UseFont = true;
            this.Delete_Client.Location = new System.Drawing.Point(466, 63);
            this.Delete_Client.Name = "Delete_Client";
            this.Delete_Client.Size = new System.Drawing.Size(144, 33);
            this.Delete_Client.TabIndex = 6;
            this.Delete_Client.Text = "Delete";
            this.Delete_Client.Click += new System.EventHandler(this.Delete_Client_Click);
            // 
            // Update_Client
            // 
            this.Update_Client.Appearance.BackColor = System.Drawing.Color.Silver;
            this.Update_Client.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_Client.Appearance.Options.UseBackColor = true;
            this.Update_Client.Appearance.Options.UseFont = true;
            this.Update_Client.Location = new System.Drawing.Point(251, 63);
            this.Update_Client.Name = "Update_Client";
            this.Update_Client.Size = new System.Drawing.Size(144, 33);
            this.Update_Client.TabIndex = 7;
            this.Update_Client.Text = "Update";
            this.Update_Client.Click += new System.EventHandler(this.Update_Client_Click);
            // 
            // fromClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 268);
            this.Controls.Add(this.Update_Client);
            this.Controls.Add(this.Delete_Client);
            this.Controls.Add(this.Clear_from);
            this.Controls.Add(this.Add_client);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.text_ID);
            this.Controls.Add(this.Name_text);
            this.Controls.Add(this.label1);
            this.Name = "fromClient";
            this.Text = "fromClient";
            this.Load += new System.EventHandler(this.fromClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Car_Spare_Parts_company_Car_Company_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Name_text;
        private System.Windows.Forms.TextBox text_ID;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private _Car_Spare_Parts_company_Car_Company_DBDataSet _Car_Spare_Parts_company_Car_Company_DBDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private _Car_Spare_Parts_company_Car_Company_DBDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraEditors.SimpleButton Add_client;
        private DevExpress.XtraEditors.SimpleButton Clear_from;
        private DevExpress.XtraEditors.SimpleButton Delete_Client;
        private DevExpress.XtraEditors.SimpleButton Update_Client;
    }
}