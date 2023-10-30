namespace Restorant_Otomasyonu
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
            this.navigationPane1 = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.pageUrunler = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.flowUrunler = new System.Windows.Forms.FlowLayoutPanel();
            this.pageMasalar = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.flowMasa = new System.Windows.Forms.FlowLayoutPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnOde = new DevExpress.XtraEditors.SimpleButton();
            this.txtToplam = new DevExpress.XtraEditors.CalcEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUrunKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrunAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirimi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMiktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToplam = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.pageUrunler.SuspendLayout();
            this.pageMasalar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtToplam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // navigationPane1
            // 
            this.navigationPane1.Controls.Add(this.pageUrunler);
            this.navigationPane1.Controls.Add(this.pageMasalar);
            this.navigationPane1.Dock = System.Windows.Forms.DockStyle.Right;
            this.navigationPane1.Location = new System.Drawing.Point(1118, 0);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.PageProperties.ShowCollapseButton = false;
            this.navigationPane1.PageProperties.ShowExpandButton = false;
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.pageUrunler,
            this.pageMasalar});
            this.navigationPane1.RegularSize = new System.Drawing.Size(350, 636);
            this.navigationPane1.SelectedPage = this.pageUrunler;
            this.navigationPane1.Size = new System.Drawing.Size(59, 636);
            this.navigationPane1.State = DevExpress.XtraBars.Navigation.NavigationPaneState.Collapsed;
            this.navigationPane1.TabIndex = 0;
            this.navigationPane1.Text = "navigationPane1";
            // 
            // pageUrunler
            // 
            this.pageUrunler.Caption = "Ürünler";
            this.pageUrunler.Controls.Add(this.flowUrunler);
            this.pageUrunler.Name = "pageUrunler";
            this.pageUrunler.Size = new System.Drawing.Size(257, 572);
            // 
            // flowUrunler
            // 
            this.flowUrunler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowUrunler.Location = new System.Drawing.Point(0, 0);
            this.flowUrunler.Name = "flowUrunler";
            this.flowUrunler.Size = new System.Drawing.Size(257, 572);
            this.flowUrunler.TabIndex = 0;
            // 
            // pageMasalar
            // 
            this.pageMasalar.Caption = "Masalar";
            this.pageMasalar.Controls.Add(this.flowMasa);
            this.pageMasalar.Controls.Add(this.groupControl1);
            this.pageMasalar.Name = "pageMasalar";
            this.pageMasalar.Size = new System.Drawing.Size(59, 636);
            // 
            // flowMasa
            // 
            this.flowMasa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowMasa.Location = new System.Drawing.Point(0, 0);
            this.flowMasa.Name = "flowMasa";
            this.flowMasa.Size = new System.Drawing.Size(59, 533);
            this.flowMasa.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnOde);
            this.groupControl1.Controls.Add(this.txtToplam);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 533);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(59, 103);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Toplam Tutar ";
            // 
            // btnOde
            // 
            this.btnOde.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOde.Appearance.Options.UseFont = true;
            this.btnOde.Location = new System.Drawing.Point(5, 39);
            this.btnOde.Name = "btnOde";
            this.btnOde.Size = new System.Drawing.Size(247, 33);
            this.btnOde.TabIndex = 1;
            this.btnOde.Text = "ÖDEME";
            this.btnOde.Click += new System.EventHandler(this.btnOde_Click);
            // 
            // txtToplam
            // 
            this.txtToplam.Location = new System.Drawing.Point(5, 78);
            this.txtToplam.Name = "txtToplam";
            this.txtToplam.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToplam.Properties.Appearance.Options.UseFont = true;
            this.txtToplam.Size = new System.Drawing.Size(252, 20);
            this.txtToplam.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1118, 636);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUrunKodu,
            this.colUrunAdi,
            this.colBirimi,
            this.colMiktar,
            this.colFiyat,
            this.colToplam});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colUrunKodu
            // 
            this.colUrunKodu.Caption = "Ürün Kodu";
            this.colUrunKodu.FieldName = "UrunKodu";
            this.colUrunKodu.Name = "colUrunKodu";
            this.colUrunKodu.OptionsColumn.AllowEdit = false;
            this.colUrunKodu.Visible = true;
            this.colUrunKodu.VisibleIndex = 0;
            // 
            // colUrunAdi
            // 
            this.colUrunAdi.Caption = "Ürün Adı";
            this.colUrunAdi.FieldName = "UrunAdi";
            this.colUrunAdi.Name = "colUrunAdi";
            this.colUrunAdi.OptionsColumn.AllowEdit = false;
            this.colUrunAdi.Visible = true;
            this.colUrunAdi.VisibleIndex = 1;
            // 
            // colBirimi
            // 
            this.colBirimi.Caption = "Birimi";
            this.colBirimi.FieldName = "Birimi";
            this.colBirimi.Name = "colBirimi";
            this.colBirimi.OptionsColumn.AllowEdit = false;
            this.colBirimi.Visible = true;
            this.colBirimi.VisibleIndex = 2;
            // 
            // colMiktar
            // 
            this.colMiktar.Caption = "Miktar";
            this.colMiktar.FieldName = "Miktar";
            this.colMiktar.Name = "colMiktar";
            this.colMiktar.Visible = true;
            this.colMiktar.VisibleIndex = 3;
            // 
            // colFiyat
            // 
            this.colFiyat.Caption = "Birim Fiyatı";
            this.colFiyat.DisplayFormat.FormatString = "C2";
            this.colFiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colFiyat.FieldName = "Fiyat";
            this.colFiyat.Name = "colFiyat";
            this.colFiyat.Visible = true;
            this.colFiyat.VisibleIndex = 4;
            // 
            // colToplam
            // 
            this.colToplam.Caption = "Toplam";
            this.colToplam.DisplayFormat.FormatString = "C2";
            this.colToplam.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colToplam.FieldName = "colToplam";
            this.colToplam.Name = "colToplam";
            this.colToplam.OptionsColumn.AllowEdit = false;
            this.colToplam.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "colToplam", "SUM={0:C2}")});
            this.colToplam.UnboundDataType = typeof(decimal);
            this.colToplam.UnboundExpression = "[Fiyat] * [Miktar]";
            this.colToplam.Visible = true;
            this.colToplam.VisibleIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 636);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.navigationPane1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.pageUrunler.ResumeLayout(false);
            this.pageMasalar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtToplam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationPane navigationPane1;
        private DevExpress.XtraBars.Navigation.NavigationPage pageUrunler;
        private DevExpress.XtraBars.Navigation.NavigationPage pageMasalar;
        private System.Windows.Forms.FlowLayoutPanel flowUrunler;
        private System.Windows.Forms.FlowLayoutPanel flowMasa;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimi;
        private DevExpress.XtraGrid.Columns.GridColumn colMiktar;
        private DevExpress.XtraGrid.Columns.GridColumn colFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn colToplam;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CalcEdit txtToplam;
        private DevExpress.XtraEditors.SimpleButton btnOde;
    }
}

