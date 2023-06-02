namespace Car_Spare_Parts_company
{
    partial class Employeess
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdderss = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Car_Spare_Parts_company_Car_Company_DBDataSet1 = new Car_Spare_Parts_company._Car_Spare_Parts_company_Car_Company_DBDataSet1();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bandedGridColumn1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn3 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn4 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn5 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn6 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn7 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.employeesTableAdapter = new Car_Spare_Parts_company._Car_Spare_Parts_company_Car_Company_DBDataSet1TableAdapters.EmployeesTableAdapter();
            this.fName_label = new DevExpress.XtraEditors.LabelControl();
            this.lName_label = new DevExpress.XtraEditors.LabelControl();
            this.S_label = new DevExpress.XtraEditors.LabelControl();
            this.P_label = new DevExpress.XtraEditors.LabelControl();
            this.A_label = new DevExpress.XtraEditors.LabelControl();
            this.ID_la = new DevExpress.XtraEditors.LabelControl();
            this.First_name_text = new System.Windows.Forms.TextBox();
            this.Ls_text = new System.Windows.Forms.TextBox();
            this.Adders_text = new System.Windows.Forms.TextBox();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.ID_text = new System.Windows.Forms.TextBox();
            this.phone_text = new System.Windows.Forms.MaskedTextBox();
            this.Add_Employee = new DevExpress.XtraEditors.SimpleButton();
            this.Upd_Employee = new DevExpress.XtraEditors.SimpleButton();
            this.Delete_Emp = new DevExpress.XtraEditors.SimpleButton();
            this.Cleartext_box = new DevExpress.XtraEditors.SimpleButton();
            this.Salary_text = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Car_Spare_Parts_company_Car_Company_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.AppearancePrint.EvenRow.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.AppearancePrint.EvenRow.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colFirstName,
            this.colLastName,
            this.colSalary,
            this.colPhone,
            this.colAdderss});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colID
            // 
            this.colID.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.colID.AppearanceHeader.BackColor2 = System.Drawing.Color.Silver;
            this.colID.AppearanceHeader.BorderColor = System.Drawing.Color.Gray;
            this.colID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.colID.AppearanceHeader.Options.UseBackColor = true;
            this.colID.AppearanceHeader.Options.UseBorderColor = true;
            this.colID.AppearanceHeader.Options.UseFont = true;
            this.colID.AppearanceHeader.Options.UseTextOptions = true;
            this.colID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowEdit = false;
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colFirstName
            // 
            this.colFirstName.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.colFirstName.AppearanceHeader.BackColor2 = System.Drawing.Color.Gray;
            this.colFirstName.AppearanceHeader.BorderColor = System.Drawing.Color.Silver;
            this.colFirstName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.colFirstName.AppearanceHeader.Options.UseBackColor = true;
            this.colFirstName.AppearanceHeader.Options.UseBorderColor = true;
            this.colFirstName.AppearanceHeader.Options.UseFont = true;
            this.colFirstName.AppearanceHeader.Options.UseTextOptions = true;
            this.colFirstName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.OptionsColumn.AllowEdit = false;
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 1;
            // 
            // colLastName
            // 
            this.colLastName.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.colLastName.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.colLastName.AppearanceHeader.BorderColor = System.Drawing.Color.Gray;
            this.colLastName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.colLastName.AppearanceHeader.Options.UseBackColor = true;
            this.colLastName.AppearanceHeader.Options.UseBorderColor = true;
            this.colLastName.AppearanceHeader.Options.UseFont = true;
            this.colLastName.AppearanceHeader.Options.UseTextOptions = true;
            this.colLastName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 2;
            // 
            // colSalary
            // 
            this.colSalary.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.colSalary.AppearanceHeader.BackColor2 = System.Drawing.Color.Silver;
            this.colSalary.AppearanceHeader.BorderColor = System.Drawing.Color.Gray;
            this.colSalary.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.colSalary.AppearanceHeader.Options.UseBackColor = true;
            this.colSalary.AppearanceHeader.Options.UseBorderColor = true;
            this.colSalary.AppearanceHeader.Options.UseFont = true;
            this.colSalary.AppearanceHeader.Options.UseTextOptions = true;
            this.colSalary.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSalary.FieldName = "Salary";
            this.colSalary.Name = "colSalary";
            this.colSalary.Visible = true;
            this.colSalary.VisibleIndex = 3;
            // 
            // colPhone
            // 
            this.colPhone.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.colPhone.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.colPhone.AppearanceHeader.BorderColor = System.Drawing.Color.Gray;
            this.colPhone.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.colPhone.AppearanceHeader.Options.UseBackColor = true;
            this.colPhone.AppearanceHeader.Options.UseBorderColor = true;
            this.colPhone.AppearanceHeader.Options.UseFont = true;
            this.colPhone.AppearanceHeader.Options.UseTextOptions = true;
            this.colPhone.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPhone.FieldName = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.Visible = true;
            this.colPhone.VisibleIndex = 4;
            // 
            // colAdderss
            // 
            this.colAdderss.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.colAdderss.AppearanceHeader.BackColor2 = System.Drawing.Color.Silver;
            this.colAdderss.AppearanceHeader.BorderColor = System.Drawing.Color.Gray;
            this.colAdderss.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.colAdderss.AppearanceHeader.Options.UseBackColor = true;
            this.colAdderss.AppearanceHeader.Options.UseBorderColor = true;
            this.colAdderss.AppearanceHeader.Options.UseFont = true;
            this.colAdderss.AppearanceHeader.Options.UseTextOptions = true;
            this.colAdderss.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAdderss.FieldName = "Adderss";
            this.colAdderss.Name = "colAdderss";
            this.colAdderss.Visible = true;
            this.colAdderss.VisibleIndex = 5;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.employeesBindingSource;
            this.gridControl1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gridLevelNode1.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(-2, 187);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.ShowOnlyPredefinedDetails = true;
            this.gridControl1.Size = new System.Drawing.Size(1022, 164);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView4,
            this.gridView3,
            this.gridView2,
            this.bandedGridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this._Car_Spare_Parts_company_Car_Company_DBDataSet1;
            // 
            // _Car_Spare_Parts_company_Car_Company_DBDataSet1
            // 
            this._Car_Spare_Parts_company_Car_Company_DBDataSet1.DataSetName = "_Car_Spare_Parts_company_Car_Company_DBDataSet1";
            this._Car_Spare_Parts_company_Car_Company_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn14});
            this.gridView4.GridControl = this.gridControl1;
            this.gridView4.Name = "gridView4";
            // 
            // gridColumn8
            // 
            this.gridColumn8.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridColumn8.AppearanceHeader.BackColor2 = System.Drawing.Color.Silver;
            this.gridColumn8.AppearanceHeader.BorderColor = System.Drawing.Color.Gray;
            this.gridColumn8.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridColumn8.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn8.AppearanceHeader.Options.UseBorderColor = true;
            this.gridColumn8.AppearanceHeader.Options.UseFont = true;
            this.gridColumn8.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn8.FieldName = "ID";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 0;
            // 
            // gridColumn9
            // 
            this.gridColumn9.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridColumn9.AppearanceHeader.BackColor2 = System.Drawing.Color.Gray;
            this.gridColumn9.AppearanceHeader.BorderColor = System.Drawing.Color.Silver;
            this.gridColumn9.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridColumn9.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn9.AppearanceHeader.Options.UseBorderColor = true;
            this.gridColumn9.AppearanceHeader.Options.UseFont = true;
            this.gridColumn9.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn9.FieldName = "FirstName";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 1;
            // 
            // gridColumn10
            // 
            this.gridColumn10.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridColumn10.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridColumn10.AppearanceHeader.BorderColor = System.Drawing.Color.Gray;
            this.gridColumn10.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridColumn10.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn10.AppearanceHeader.Options.UseBorderColor = true;
            this.gridColumn10.AppearanceHeader.Options.UseFont = true;
            this.gridColumn10.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn10.FieldName = "LastName";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 2;
            // 
            // gridColumn11
            // 
            this.gridColumn11.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridColumn11.AppearanceHeader.BackColor2 = System.Drawing.Color.Silver;
            this.gridColumn11.AppearanceHeader.BorderColor = System.Drawing.Color.Gray;
            this.gridColumn11.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridColumn11.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn11.AppearanceHeader.Options.UseBorderColor = true;
            this.gridColumn11.AppearanceHeader.Options.UseFont = true;
            this.gridColumn11.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn11.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn11.FieldName = "Salary";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 3;
            // 
            // gridColumn12
            // 
            this.gridColumn12.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridColumn12.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridColumn12.AppearanceHeader.BorderColor = System.Drawing.Color.Gray;
            this.gridColumn12.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridColumn12.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn12.AppearanceHeader.Options.UseBorderColor = true;
            this.gridColumn12.AppearanceHeader.Options.UseFont = true;
            this.gridColumn12.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn12.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn12.FieldName = "Phone";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 4;
            // 
            // gridColumn13
            // 
            this.gridColumn13.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridColumn13.AppearanceHeader.BackColor2 = System.Drawing.Color.Silver;
            this.gridColumn13.AppearanceHeader.BorderColor = System.Drawing.Color.Gray;
            this.gridColumn13.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridColumn13.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn13.AppearanceHeader.Options.UseBorderColor = true;
            this.gridColumn13.AppearanceHeader.Options.UseFont = true;
            this.gridColumn13.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn13.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn13.FieldName = "Adderss";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 5;
            // 
            // gridColumn14
            // 
            this.gridColumn14.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridColumn14.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridColumn14.AppearanceHeader.BorderColor = System.Drawing.Color.Gray;
            this.gridColumn14.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn14.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn14.AppearanceHeader.Options.UseBorderColor = true;
            this.gridColumn14.AppearanceHeader.Options.UseFont = true;
            this.gridColumn14.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn14.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn14.FieldName = "HR_ID";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 6;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.gridView3.GridControl = this.gridControl1;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridColumn1.AppearanceHeader.BackColor2 = System.Drawing.Color.Silver;
            this.gridColumn1.AppearanceHeader.BorderColor = System.Drawing.Color.Gray;
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridColumn1.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn1.AppearanceHeader.Options.UseBorderColor = true;
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridColumn2.AppearanceHeader.BackColor2 = System.Drawing.Color.Gray;
            this.gridColumn2.AppearanceHeader.BorderColor = System.Drawing.Color.Silver;
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridColumn2.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn2.AppearanceHeader.Options.UseBorderColor = true;
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.FieldName = "FirstName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridColumn3.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridColumn3.AppearanceHeader.BorderColor = System.Drawing.Color.Gray;
            this.gridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridColumn3.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn3.AppearanceHeader.Options.UseBorderColor = true;
            this.gridColumn3.AppearanceHeader.Options.UseFont = true;
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.FieldName = "LastName";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridColumn4.AppearanceHeader.BackColor2 = System.Drawing.Color.Silver;
            this.gridColumn4.AppearanceHeader.BorderColor = System.Drawing.Color.Gray;
            this.gridColumn4.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridColumn4.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn4.AppearanceHeader.Options.UseBorderColor = true;
            this.gridColumn4.AppearanceHeader.Options.UseFont = true;
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.FieldName = "Salary";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridColumn5.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridColumn5.AppearanceHeader.BorderColor = System.Drawing.Color.Gray;
            this.gridColumn5.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridColumn5.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn5.AppearanceHeader.Options.UseBorderColor = true;
            this.gridColumn5.AppearanceHeader.Options.UseFont = true;
            this.gridColumn5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.FieldName = "Phone";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridColumn6.AppearanceHeader.BackColor2 = System.Drawing.Color.Silver;
            this.gridColumn6.AppearanceHeader.BorderColor = System.Drawing.Color.Gray;
            this.gridColumn6.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridColumn6.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn6.AppearanceHeader.Options.UseBorderColor = true;
            this.gridColumn6.AppearanceHeader.Options.UseFont = true;
            this.gridColumn6.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn6.FieldName = "Adderss";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // gridColumn7
            // 
            this.gridColumn7.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridColumn7.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridColumn7.AppearanceHeader.BorderColor = System.Drawing.Color.Gray;
            this.gridColumn7.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn7.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn7.AppearanceHeader.Options.UseBorderColor = true;
            this.gridColumn7.AppearanceHeader.Options.UseFont = true;
            this.gridColumn7.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn7.FieldName = "HR_ID";
            this.gridColumn7.Name = "gridColumn7";
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            // 
            // bandedGridView1
            // 
            this.bandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1});
            this.bandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.bandedGridColumn1,
            this.bandedGridColumn2,
            this.bandedGridColumn3,
            this.bandedGridColumn4,
            this.bandedGridColumn5,
            this.bandedGridColumn6,
            this.bandedGridColumn7});
            this.bandedGridView1.GridControl = this.gridControl1;
            this.bandedGridView1.Name = "bandedGridView1";
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "gridBand1";
            this.gridBand1.Columns.Add(this.bandedGridColumn1);
            this.gridBand1.Columns.Add(this.bandedGridColumn2);
            this.gridBand1.Columns.Add(this.bandedGridColumn3);
            this.gridBand1.Columns.Add(this.bandedGridColumn4);
            this.gridBand1.Columns.Add(this.bandedGridColumn5);
            this.gridBand1.Columns.Add(this.bandedGridColumn6);
            this.gridBand1.Columns.Add(this.bandedGridColumn7);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 525;
            // 
            // bandedGridColumn1
            // 
            this.bandedGridColumn1.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bandedGridColumn1.AppearanceHeader.BackColor2 = System.Drawing.Color.Silver;
            this.bandedGridColumn1.AppearanceHeader.BorderColor = System.Drawing.Color.Gray;
            this.bandedGridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.bandedGridColumn1.AppearanceHeader.Options.UseBackColor = true;
            this.bandedGridColumn1.AppearanceHeader.Options.UseBorderColor = true;
            this.bandedGridColumn1.AppearanceHeader.Options.UseFont = true;
            this.bandedGridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumn1.FieldName = "ID";
            this.bandedGridColumn1.Name = "bandedGridColumn1";
            this.bandedGridColumn1.Visible = true;
            // 
            // bandedGridColumn2
            // 
            this.bandedGridColumn2.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bandedGridColumn2.AppearanceHeader.BackColor2 = System.Drawing.Color.Gray;
            this.bandedGridColumn2.AppearanceHeader.BorderColor = System.Drawing.Color.Silver;
            this.bandedGridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.bandedGridColumn2.AppearanceHeader.Options.UseBackColor = true;
            this.bandedGridColumn2.AppearanceHeader.Options.UseBorderColor = true;
            this.bandedGridColumn2.AppearanceHeader.Options.UseFont = true;
            this.bandedGridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumn2.FieldName = "FirstName";
            this.bandedGridColumn2.Name = "bandedGridColumn2";
            this.bandedGridColumn2.Visible = true;
            // 
            // bandedGridColumn3
            // 
            this.bandedGridColumn3.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bandedGridColumn3.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bandedGridColumn3.AppearanceHeader.BorderColor = System.Drawing.Color.Gray;
            this.bandedGridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.bandedGridColumn3.AppearanceHeader.Options.UseBackColor = true;
            this.bandedGridColumn3.AppearanceHeader.Options.UseBorderColor = true;
            this.bandedGridColumn3.AppearanceHeader.Options.UseFont = true;
            this.bandedGridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumn3.FieldName = "LastName";
            this.bandedGridColumn3.Name = "bandedGridColumn3";
            this.bandedGridColumn3.Visible = true;
            // 
            // bandedGridColumn4
            // 
            this.bandedGridColumn4.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bandedGridColumn4.AppearanceHeader.BackColor2 = System.Drawing.Color.Silver;
            this.bandedGridColumn4.AppearanceHeader.BorderColor = System.Drawing.Color.Gray;
            this.bandedGridColumn4.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.bandedGridColumn4.AppearanceHeader.Options.UseBackColor = true;
            this.bandedGridColumn4.AppearanceHeader.Options.UseBorderColor = true;
            this.bandedGridColumn4.AppearanceHeader.Options.UseFont = true;
            this.bandedGridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumn4.FieldName = "Salary";
            this.bandedGridColumn4.Name = "bandedGridColumn4";
            this.bandedGridColumn4.Visible = true;
            // 
            // bandedGridColumn5
            // 
            this.bandedGridColumn5.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bandedGridColumn5.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bandedGridColumn5.AppearanceHeader.BorderColor = System.Drawing.Color.Gray;
            this.bandedGridColumn5.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.bandedGridColumn5.AppearanceHeader.Options.UseBackColor = true;
            this.bandedGridColumn5.AppearanceHeader.Options.UseBorderColor = true;
            this.bandedGridColumn5.AppearanceHeader.Options.UseFont = true;
            this.bandedGridColumn5.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumn5.FieldName = "Phone";
            this.bandedGridColumn5.Name = "bandedGridColumn5";
            this.bandedGridColumn5.Visible = true;
            // 
            // bandedGridColumn6
            // 
            this.bandedGridColumn6.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bandedGridColumn6.AppearanceHeader.BackColor2 = System.Drawing.Color.Silver;
            this.bandedGridColumn6.AppearanceHeader.BorderColor = System.Drawing.Color.Gray;
            this.bandedGridColumn6.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.bandedGridColumn6.AppearanceHeader.Options.UseBackColor = true;
            this.bandedGridColumn6.AppearanceHeader.Options.UseBorderColor = true;
            this.bandedGridColumn6.AppearanceHeader.Options.UseFont = true;
            this.bandedGridColumn6.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumn6.FieldName = "Adderss";
            this.bandedGridColumn6.Name = "bandedGridColumn6";
            this.bandedGridColumn6.Visible = true;
            // 
            // bandedGridColumn7
            // 
            this.bandedGridColumn7.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bandedGridColumn7.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bandedGridColumn7.AppearanceHeader.BorderColor = System.Drawing.Color.Gray;
            this.bandedGridColumn7.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bandedGridColumn7.AppearanceHeader.Options.UseBackColor = true;
            this.bandedGridColumn7.AppearanceHeader.Options.UseBorderColor = true;
            this.bandedGridColumn7.AppearanceHeader.Options.UseFont = true;
            this.bandedGridColumn7.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumn7.FieldName = "HR_ID";
            this.bandedGridColumn7.Name = "bandedGridColumn7";
            this.bandedGridColumn7.Visible = true;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // fName_label
            // 
            this.fName_label.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fName_label.Appearance.Options.UseFont = true;
            this.fName_label.Location = new System.Drawing.Point(32, 14);
            this.fName_label.Name = "fName_label";
            this.fName_label.Size = new System.Drawing.Size(76, 16);
            this.fName_label.TabIndex = 1;
            this.fName_label.Text = "First Name :";
            // 
            // lName_label
            // 
            this.lName_label.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lName_label.Appearance.Options.UseFont = true;
            this.lName_label.Location = new System.Drawing.Point(344, 14);
            this.lName_label.Name = "lName_label";
            this.lName_label.Size = new System.Drawing.Size(76, 16);
            this.lName_label.TabIndex = 2;
            this.lName_label.Text = "Last Name :";
            // 
            // S_label
            // 
            this.S_label.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S_label.Appearance.Options.UseFont = true;
            this.S_label.Location = new System.Drawing.Point(626, 14);
            this.S_label.Name = "S_label";
            this.S_label.Size = new System.Drawing.Size(50, 16);
            this.S_label.TabIndex = 3;
            this.S_label.Text = "Salary :";
            // 
            // P_label
            // 
            this.P_label.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P_label.Appearance.Options.UseFont = true;
            this.P_label.Location = new System.Drawing.Point(32, 64);
            this.P_label.Name = "P_label";
            this.P_label.Size = new System.Drawing.Size(49, 16);
            this.P_label.TabIndex = 4;
            this.P_label.Text = "Phone :";
            // 
            // A_label
            // 
            this.A_label.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A_label.Appearance.Options.UseFont = true;
            this.A_label.Location = new System.Drawing.Point(344, 64);
            this.A_label.Name = "A_label";
            this.A_label.Size = new System.Drawing.Size(63, 16);
            this.A_label.TabIndex = 5;
            this.A_label.Text = "Adderss :";
            // 
            // ID_la
            // 
            this.ID_la.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_la.Appearance.Options.UseFont = true;
            this.ID_la.Location = new System.Drawing.Point(613, 64);
            this.ID_la.Name = "ID_la";
            this.ID_la.Size = new System.Drawing.Size(14, 16);
            this.ID_la.TabIndex = 6;
            this.ID_la.Text = "ID";
            this.ID_la.Visible = false;
            // 
            // First_name_text
            // 
            this.First_name_text.Location = new System.Drawing.Point(114, 12);
            this.First_name_text.Multiline = true;
            this.First_name_text.Name = "First_name_text";
            this.First_name_text.Size = new System.Drawing.Size(132, 22);
            this.First_name_text.TabIndex = 7;
            // 
            // Ls_text
            // 
            this.Ls_text.Location = new System.Drawing.Point(435, 12);
            this.Ls_text.Multiline = true;
            this.Ls_text.Name = "Ls_text";
            this.Ls_text.Size = new System.Drawing.Size(130, 22);
            this.Ls_text.TabIndex = 8;
            // 
            // Adders_text
            // 
            this.Adders_text.Location = new System.Drawing.Point(413, 60);
            this.Adders_text.Multiline = true;
            this.Adders_text.Name = "Adders_text";
            this.Adders_text.Size = new System.Drawing.Size(142, 22);
            this.Adders_text.TabIndex = 12;
            // 
            // ID_text
            // 
            this.ID_text.Location = new System.Drawing.Point(658, 63);
            this.ID_text.Name = "ID_text";
            this.ID_text.Size = new System.Drawing.Size(100, 21);
            this.ID_text.TabIndex = 13;
            this.ID_text.Visible = false;
            // 
            // phone_text
            // 
            this.phone_text.Location = new System.Drawing.Point(103, 59);
            this.phone_text.Name = "phone_text";
            this.phone_text.Size = new System.Drawing.Size(156, 21);
            this.phone_text.TabIndex = 10;
            // 
            // Add_Employee
            // 
            this.Add_Employee.Appearance.BackColor = System.Drawing.Color.Silver;
            this.Add_Employee.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Employee.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Add_Employee.Appearance.Options.UseBackColor = true;
            this.Add_Employee.Appearance.Options.UseFont = true;
            this.Add_Employee.Appearance.Options.UseForeColor = true;
            this.Add_Employee.Location = new System.Drawing.Point(42, 142);
            this.Add_Employee.Name = "Add_Employee";
            this.Add_Employee.Size = new System.Drawing.Size(158, 39);
            this.Add_Employee.TabIndex = 14;
            this.Add_Employee.Text = "Add Employee";
            this.Add_Employee.Click += new System.EventHandler(this.Add_Employee_Click);
            // 
            // Upd_Employee
            // 
            this.Upd_Employee.Appearance.BackColor = System.Drawing.Color.Silver;
            this.Upd_Employee.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Upd_Employee.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Upd_Employee.Appearance.Options.UseBackColor = true;
            this.Upd_Employee.Appearance.Options.UseFont = true;
            this.Upd_Employee.Appearance.Options.UseForeColor = true;
            this.Upd_Employee.Location = new System.Drawing.Point(275, 142);
            this.Upd_Employee.Name = "Upd_Employee";
            this.Upd_Employee.Size = new System.Drawing.Size(158, 39);
            this.Upd_Employee.TabIndex = 15;
            this.Upd_Employee.Text = "Update";
            this.Upd_Employee.Click += new System.EventHandler(this.Upd_Employee_Click);
            // 
            // Delete_Emp
            // 
            this.Delete_Emp.Appearance.BackColor = System.Drawing.Color.Silver;
            this.Delete_Emp.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Emp.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Delete_Emp.Appearance.Options.UseBackColor = true;
            this.Delete_Emp.Appearance.Options.UseFont = true;
            this.Delete_Emp.Appearance.Options.UseForeColor = true;
            this.Delete_Emp.Location = new System.Drawing.Point(555, 142);
            this.Delete_Emp.Name = "Delete_Emp";
            this.Delete_Emp.Size = new System.Drawing.Size(158, 39);
            this.Delete_Emp.TabIndex = 16;
            this.Delete_Emp.Text = "Delete";
            this.Delete_Emp.Click += new System.EventHandler(this.Delete_Emp_Click);
            // 
            // Cleartext_box
            // 
            this.Cleartext_box.Appearance.BackColor = System.Drawing.Color.Silver;
            this.Cleartext_box.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cleartext_box.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Cleartext_box.Appearance.Options.UseBackColor = true;
            this.Cleartext_box.Appearance.Options.UseFont = true;
            this.Cleartext_box.Appearance.Options.UseForeColor = true;
            this.Cleartext_box.Location = new System.Drawing.Point(778, 142);
            this.Cleartext_box.Name = "Cleartext_box";
            this.Cleartext_box.Size = new System.Drawing.Size(158, 39);
            this.Cleartext_box.TabIndex = 17;
            this.Cleartext_box.Text = "Clear";
            this.Cleartext_box.Click += new System.EventHandler(this.Cleartext_box_Click);
            // 
            // Salary_text
            // 
            this.Salary_text.Location = new System.Drawing.Point(691, 12);
            this.Salary_text.Multiline = true;
            this.Salary_text.Name = "Salary_text";
            this.Salary_text.Size = new System.Drawing.Size(167, 22);
            this.Salary_text.TabIndex = 18;
            // 
            // Employeess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 350);
            this.Controls.Add(this.Salary_text);
            this.Controls.Add(this.Cleartext_box);
            this.Controls.Add(this.Delete_Emp);
            this.Controls.Add(this.Upd_Employee);
            this.Controls.Add(this.Add_Employee);
            this.Controls.Add(this.ID_text);
            this.Controls.Add(this.Adders_text);
            this.Controls.Add(this.phone_text);
            this.Controls.Add(this.Ls_text);
            this.Controls.Add(this.First_name_text);
            this.Controls.Add(this.ID_la);
            this.Controls.Add(this.A_label);
            this.Controls.Add(this.P_label);
            this.Controls.Add(this.S_label);
            this.Controls.Add(this.lName_label);
            this.Controls.Add(this.fName_label);
            this.Controls.Add(this.gridControl1);
            this.Name = "Employeess";
            this.Text = "Employeess";
            this.Load += new System.EventHandler(this.Employeess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Car_Spare_Parts_company_Car_Company_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private _Car_Spare_Parts_company_Car_Company_DBDataSet1 _Car_Spare_Parts_company_Car_Company_DBDataSet1;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private _Car_Spare_Parts_company_Car_Company_DBDataSet1TableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private DevExpress.XtraEditors.LabelControl fName_label;
        private DevExpress.XtraEditors.LabelControl lName_label;
        private DevExpress.XtraEditors.LabelControl S_label;
        private DevExpress.XtraEditors.LabelControl P_label;
        private DevExpress.XtraEditors.LabelControl A_label;
        private DevExpress.XtraEditors.LabelControl ID_la;
        private System.Windows.Forms.TextBox First_name_text;
        private System.Windows.Forms.TextBox Ls_text;
        private System.Windows.Forms.TextBox Adders_text;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.TextBox ID_text;
        private System.Windows.Forms.MaskedTextBox phone_text;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colSalary;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colAdderss;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn3;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn4;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn5;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn6;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn7;
        private DevExpress.XtraEditors.SimpleButton Add_Employee;
        private DevExpress.XtraEditors.SimpleButton Upd_Employee;
        private DevExpress.XtraEditors.SimpleButton Delete_Emp;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraEditors.SimpleButton Cleartext_box;
        private System.Windows.Forms.TextBox Salary_text;
    }
}