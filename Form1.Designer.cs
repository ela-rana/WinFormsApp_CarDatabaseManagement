
namespace WinFormsApp_CarDatabaseManagement
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
            this.grpDisplay = new System.Windows.Forms.GroupBox();
            this.dtgrdInventory = new System.Windows.Forms.DataGridView();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpCRUD = new System.Windows.Forms.GroupBox();
            this.tbctrlManageInventory = new System.Windows.Forms.TabControl();
            this.tbpgAddCar = new System.Windows.Forms.TabPage();
            this.btnAddRecord = new System.Windows.Forms.Button();
            this.tblAddRecord = new System.Windows.Forms.TableLayoutPanel();
            this.lblVINToAdd = new System.Windows.Forms.Label();
            this.lblMakeToAdd = new System.Windows.Forms.Label();
            this.lblModelToAdd = new System.Windows.Forms.Label();
            this.lblYearToAdd = new System.Windows.Forms.Label();
            this.lblPriceToAdd = new System.Windows.Forms.Label();
            this.txtVINToAdd = new System.Windows.Forms.TextBox();
            this.txtMakeToAdd = new System.Windows.Forms.TextBox();
            this.txtModelToAdd = new System.Windows.Forms.TextBox();
            this.txtYearToAdd = new System.Windows.Forms.TextBox();
            this.txtPriceToAdd = new System.Windows.Forms.TextBox();
            this.tbpgEditCar = new System.Windows.Forms.TabPage();
            this.lblEdit = new System.Windows.Forms.Label();
            this.tblUpdate = new System.Windows.Forms.TableLayoutPanel();
            this.lblUpdatedVIN = new System.Windows.Forms.Label();
            this.lblUpdatedMake = new System.Windows.Forms.Label();
            this.lblUpdatedModel = new System.Windows.Forms.Label();
            this.lblUpdatedYear = new System.Windows.Forms.Label();
            this.lblUpdatedPrice = new System.Windows.Forms.Label();
            this.txtUpdatedVin = new System.Windows.Forms.TextBox();
            this.txtUpdatedMake = new System.Windows.Forms.TextBox();
            this.txtUpdatedModel = new System.Windows.Forms.TextBox();
            this.txtUpdatedYear = new System.Windows.Forms.TextBox();
            this.txtUpdatedPrice = new System.Windows.Forms.TextBox();
            this.btnEditThisRecord = new System.Windows.Forms.Button();
            this.lblVINToEdit = new System.Windows.Forms.Label();
            this.txtVINToEdit = new System.Windows.Forms.TextBox();
            this.btnUpdateRecord = new System.Windows.Forms.Button();
            this.tbpgDeleteCar = new System.Windows.Forms.TabPage();
            this.lblDeleteMessage = new System.Windows.Forms.Label();
            this.btnDeleteRecord = new System.Windows.Forms.Button();
            this.lblVINToDelete = new System.Windows.Forms.Label();
            this.txtVINToDelete = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBegin = new System.Windows.Forms.Label();
            this.lblUpdateTheFields = new System.Windows.Forms.Label();
            this.grpDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdInventory)).BeginInit();
            this.grpCRUD.SuspendLayout();
            this.tbctrlManageInventory.SuspendLayout();
            this.tbpgAddCar.SuspendLayout();
            this.tblAddRecord.SuspendLayout();
            this.tbpgEditCar.SuspendLayout();
            this.tblUpdate.SuspendLayout();
            this.tbpgDeleteCar.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDisplay
            // 
            this.grpDisplay.BackColor = System.Drawing.Color.OldLace;
            this.grpDisplay.Controls.Add(this.dtgrdInventory);
            this.grpDisplay.Location = new System.Drawing.Point(471, 126);
            this.grpDisplay.Name = "grpDisplay";
            this.grpDisplay.Size = new System.Drawing.Size(762, 592);
            this.grpDisplay.TabIndex = 0;
            this.grpDisplay.TabStop = false;
            this.grpDisplay.Text = "Car Inventory Display";
            this.grpDisplay.Visible = false;
            // 
            // dtgrdInventory
            // 
            this.dtgrdInventory.AllowUserToAddRows = false;
            this.dtgrdInventory.AllowUserToDeleteRows = false;
            this.dtgrdInventory.AllowUserToOrderColumns = true;
            this.dtgrdInventory.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dtgrdInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdInventory.Location = new System.Drawing.Point(0, 55);
            this.dtgrdInventory.Name = "dtgrdInventory";
            this.dtgrdInventory.ReadOnly = true;
            this.dtgrdInventory.Size = new System.Drawing.Size(762, 537);
            this.dtgrdInventory.TabIndex = 0;
            this.dtgrdInventory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrdInventory_CellContentClick);
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.BackColor = System.Drawing.SystemColors.Info;
            this.lblSubtitle.Font = new System.Drawing.Font("Curlz MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.Location = new System.Drawing.Point(361, 721);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(485, 39);
            this.lblSubtitle.TabIndex = 4;
            this.lblSubtitle.Text = "We make buying a used car as easy as 1-2-3\r\n";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.Info;
            this.lblTitle.Font = new System.Drawing.Font("Curlz MT", 50F, System.Drawing.FontStyle.Italic);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitle.Location = new System.Drawing.Point(438, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(339, 89);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "123Cars.com";
            // 
            // grpCRUD
            // 
            this.grpCRUD.BackColor = System.Drawing.Color.OldLace;
            this.grpCRUD.Controls.Add(this.tbctrlManageInventory);
            this.grpCRUD.Location = new System.Drawing.Point(17, 126);
            this.grpCRUD.Name = "grpCRUD";
            this.grpCRUD.Size = new System.Drawing.Size(437, 592);
            this.grpCRUD.TabIndex = 1;
            this.grpCRUD.TabStop = false;
            this.grpCRUD.Text = "What would you like to do?";
            this.grpCRUD.Visible = false;
            // 
            // tbctrlManageInventory
            // 
            this.tbctrlManageInventory.Controls.Add(this.tbpgAddCar);
            this.tbctrlManageInventory.Controls.Add(this.tbpgEditCar);
            this.tbctrlManageInventory.Controls.Add(this.tbpgDeleteCar);
            this.tbctrlManageInventory.Location = new System.Drawing.Point(0, 55);
            this.tbctrlManageInventory.Name = "tbctrlManageInventory";
            this.tbctrlManageInventory.SelectedIndex = 0;
            this.tbctrlManageInventory.Size = new System.Drawing.Size(437, 537);
            this.tbctrlManageInventory.TabIndex = 0;
            // 
            // tbpgAddCar
            // 
            this.tbpgAddCar.BackColor = System.Drawing.Color.LavenderBlush;
            this.tbpgAddCar.Controls.Add(this.btnAddRecord);
            this.tbpgAddCar.Controls.Add(this.tblAddRecord);
            this.tbpgAddCar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbpgAddCar.Location = new System.Drawing.Point(4, 24);
            this.tbpgAddCar.Name = "tbpgAddCar";
            this.tbpgAddCar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgAddCar.Size = new System.Drawing.Size(429, 509);
            this.tbpgAddCar.TabIndex = 0;
            this.tbpgAddCar.Text = "Add New Car";
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.Location = new System.Drawing.Point(128, 245);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(183, 25);
            this.btnAddRecord.TabIndex = 1;
            this.btnAddRecord.Text = "Add New Car to Inventory";
            this.btnAddRecord.UseVisualStyleBackColor = true;
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // tblAddRecord
            // 
            this.tblAddRecord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tblAddRecord.ColumnCount = 2;
            this.tblAddRecord.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.46903F));
            this.tblAddRecord.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.53098F));
            this.tblAddRecord.Controls.Add(this.lblVINToAdd, 0, 0);
            this.tblAddRecord.Controls.Add(this.lblMakeToAdd, 0, 1);
            this.tblAddRecord.Controls.Add(this.lblModelToAdd, 0, 2);
            this.tblAddRecord.Controls.Add(this.lblYearToAdd, 0, 3);
            this.tblAddRecord.Controls.Add(this.lblPriceToAdd, 0, 4);
            this.tblAddRecord.Controls.Add(this.txtVINToAdd, 1, 0);
            this.tblAddRecord.Controls.Add(this.txtMakeToAdd, 1, 1);
            this.tblAddRecord.Controls.Add(this.txtModelToAdd, 1, 2);
            this.tblAddRecord.Controls.Add(this.txtYearToAdd, 1, 3);
            this.tblAddRecord.Controls.Add(this.txtPriceToAdd, 1, 4);
            this.tblAddRecord.Location = new System.Drawing.Point(46, 57);
            this.tblAddRecord.Name = "tblAddRecord";
            this.tblAddRecord.RowCount = 5;
            this.tblAddRecord.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblAddRecord.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblAddRecord.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblAddRecord.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblAddRecord.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblAddRecord.Size = new System.Drawing.Size(339, 159);
            this.tblAddRecord.TabIndex = 0;
            // 
            // lblVINToAdd
            // 
            this.lblVINToAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVINToAdd.AutoSize = true;
            this.lblVINToAdd.Location = new System.Drawing.Point(18, 8);
            this.lblVINToAdd.Name = "lblVINToAdd";
            this.lblVINToAdd.Size = new System.Drawing.Size(29, 15);
            this.lblVINToAdd.TabIndex = 0;
            this.lblVINToAdd.Text = "VIN";
            // 
            // lblMakeToAdd
            // 
            this.lblMakeToAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMakeToAdd.AutoSize = true;
            this.lblMakeToAdd.Location = new System.Drawing.Point(12, 39);
            this.lblMakeToAdd.Name = "lblMakeToAdd";
            this.lblMakeToAdd.Size = new System.Drawing.Size(42, 15);
            this.lblMakeToAdd.TabIndex = 2;
            this.lblMakeToAdd.Text = "Make";
            // 
            // lblModelToAdd
            // 
            this.lblModelToAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblModelToAdd.AutoSize = true;
            this.lblModelToAdd.Location = new System.Drawing.Point(9, 70);
            this.lblModelToAdd.Name = "lblModelToAdd";
            this.lblModelToAdd.Size = new System.Drawing.Size(47, 15);
            this.lblModelToAdd.TabIndex = 4;
            this.lblModelToAdd.Text = "Model";
            // 
            // lblYearToAdd
            // 
            this.lblYearToAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblYearToAdd.AutoSize = true;
            this.lblYearToAdd.Location = new System.Drawing.Point(15, 101);
            this.lblYearToAdd.Name = "lblYearToAdd";
            this.lblYearToAdd.Size = new System.Drawing.Size(36, 15);
            this.lblYearToAdd.TabIndex = 6;
            this.lblYearToAdd.Text = "Year";
            // 
            // lblPriceToAdd
            // 
            this.lblPriceToAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPriceToAdd.AutoSize = true;
            this.lblPriceToAdd.Location = new System.Drawing.Point(13, 134);
            this.lblPriceToAdd.Name = "lblPriceToAdd";
            this.lblPriceToAdd.Size = new System.Drawing.Size(40, 15);
            this.lblPriceToAdd.TabIndex = 8;
            this.lblPriceToAdd.Text = "Price";
            // 
            // txtVINToAdd
            // 
            this.txtVINToAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVINToAdd.Location = new System.Drawing.Point(96, 5);
            this.txtVINToAdd.Name = "txtVINToAdd";
            this.txtVINToAdd.Size = new System.Drawing.Size(213, 21);
            this.txtVINToAdd.TabIndex = 9;
            this.txtVINToAdd.Validating += new System.ComponentModel.CancelEventHandler(this.txtVINToAdd_Validating);
            // 
            // txtMakeToAdd
            // 
            this.txtMakeToAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMakeToAdd.Location = new System.Drawing.Point(96, 36);
            this.txtMakeToAdd.Name = "txtMakeToAdd";
            this.txtMakeToAdd.Size = new System.Drawing.Size(213, 21);
            this.txtMakeToAdd.TabIndex = 10;
            // 
            // txtModelToAdd
            // 
            this.txtModelToAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtModelToAdd.Location = new System.Drawing.Point(96, 67);
            this.txtModelToAdd.Name = "txtModelToAdd";
            this.txtModelToAdd.Size = new System.Drawing.Size(213, 21);
            this.txtModelToAdd.TabIndex = 11;
            // 
            // txtYearToAdd
            // 
            this.txtYearToAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtYearToAdd.Location = new System.Drawing.Point(96, 98);
            this.txtYearToAdd.Name = "txtYearToAdd";
            this.txtYearToAdd.Size = new System.Drawing.Size(213, 21);
            this.txtYearToAdd.TabIndex = 12;
            this.txtYearToAdd.Validating += new System.ComponentModel.CancelEventHandler(this.txtYearToAdd_Validating);
            // 
            // txtPriceToAdd
            // 
            this.txtPriceToAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPriceToAdd.Location = new System.Drawing.Point(96, 131);
            this.txtPriceToAdd.Name = "txtPriceToAdd";
            this.txtPriceToAdd.Size = new System.Drawing.Size(213, 21);
            this.txtPriceToAdd.TabIndex = 13;
            this.txtPriceToAdd.Validating += new System.ComponentModel.CancelEventHandler(this.txtPriceToAdd_Validating);
            // 
            // tbpgEditCar
            // 
            this.tbpgEditCar.BackColor = System.Drawing.Color.Lavender;
            this.tbpgEditCar.Controls.Add(this.lblUpdateTheFields);
            this.tbpgEditCar.Controls.Add(this.lblEdit);
            this.tbpgEditCar.Controls.Add(this.tblUpdate);
            this.tbpgEditCar.Controls.Add(this.btnEditThisRecord);
            this.tbpgEditCar.Controls.Add(this.lblVINToEdit);
            this.tbpgEditCar.Controls.Add(this.txtVINToEdit);
            this.tbpgEditCar.Controls.Add(this.btnUpdateRecord);
            this.tbpgEditCar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbpgEditCar.Location = new System.Drawing.Point(4, 24);
            this.tbpgEditCar.Name = "tbpgEditCar";
            this.tbpgEditCar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgEditCar.Size = new System.Drawing.Size(429, 509);
            this.tbpgEditCar.TabIndex = 1;
            this.tbpgEditCar.Text = "Edit A Car";
            // 
            // lblEdit
            // 
            this.lblEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEdit.AutoSize = true;
            this.lblEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdit.ForeColor = System.Drawing.Color.Green;
            this.lblEdit.Location = new System.Drawing.Point(35, 42);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(301, 30);
            this.lblEdit.TabIndex = 14;
            this.lblEdit.Text = "Enter the VIN of the record you want to edit or \r\nselect it from the grid on the " +
    "right:";
            // 
            // tblUpdate
            // 
            this.tblUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tblUpdate.ColumnCount = 2;
            this.tblUpdate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.03835F));
            this.tblUpdate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.96165F));
            this.tblUpdate.Controls.Add(this.lblUpdatedVIN, 0, 0);
            this.tblUpdate.Controls.Add(this.lblUpdatedMake, 0, 1);
            this.tblUpdate.Controls.Add(this.lblUpdatedModel, 0, 2);
            this.tblUpdate.Controls.Add(this.lblUpdatedYear, 0, 3);
            this.tblUpdate.Controls.Add(this.lblUpdatedPrice, 0, 4);
            this.tblUpdate.Controls.Add(this.txtUpdatedVin, 1, 0);
            this.tblUpdate.Controls.Add(this.txtUpdatedMake, 1, 1);
            this.tblUpdate.Controls.Add(this.txtUpdatedModel, 1, 2);
            this.tblUpdate.Controls.Add(this.txtUpdatedYear, 1, 3);
            this.tblUpdate.Controls.Add(this.txtUpdatedPrice, 1, 4);
            this.tblUpdate.Location = new System.Drawing.Point(37, 236);
            this.tblUpdate.Name = "tblUpdate";
            this.tblUpdate.RowCount = 5;
            this.tblUpdate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblUpdate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblUpdate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblUpdate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblUpdate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblUpdate.Size = new System.Drawing.Size(339, 177);
            this.tblUpdate.TabIndex = 13;
            this.tblUpdate.Visible = false;
            // 
            // lblUpdatedVIN
            // 
            this.lblUpdatedVIN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUpdatedVIN.AutoSize = true;
            this.lblUpdatedVIN.Location = new System.Drawing.Point(12, 10);
            this.lblUpdatedVIN.Name = "lblUpdatedVIN";
            this.lblUpdatedVIN.Size = new System.Drawing.Size(87, 15);
            this.lblUpdatedVIN.TabIndex = 0;
            this.lblUpdatedVIN.Text = "Updated VIN";
            // 
            // lblUpdatedMake
            // 
            this.lblUpdatedMake.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUpdatedMake.AutoSize = true;
            this.lblUpdatedMake.Location = new System.Drawing.Point(6, 45);
            this.lblUpdatedMake.Name = "lblUpdatedMake";
            this.lblUpdatedMake.Size = new System.Drawing.Size(100, 15);
            this.lblUpdatedMake.TabIndex = 2;
            this.lblUpdatedMake.Text = "Updated Make";
            // 
            // lblUpdatedModel
            // 
            this.lblUpdatedModel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUpdatedModel.AutoSize = true;
            this.lblUpdatedModel.Location = new System.Drawing.Point(3, 80);
            this.lblUpdatedModel.Name = "lblUpdatedModel";
            this.lblUpdatedModel.Size = new System.Drawing.Size(105, 15);
            this.lblUpdatedModel.TabIndex = 4;
            this.lblUpdatedModel.Text = "Updated Model";
            // 
            // lblUpdatedYear
            // 
            this.lblUpdatedYear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUpdatedYear.AutoSize = true;
            this.lblUpdatedYear.Location = new System.Drawing.Point(9, 115);
            this.lblUpdatedYear.Name = "lblUpdatedYear";
            this.lblUpdatedYear.Size = new System.Drawing.Size(94, 15);
            this.lblUpdatedYear.TabIndex = 6;
            this.lblUpdatedYear.Text = "Updated Year";
            // 
            // lblUpdatedPrice
            // 
            this.lblUpdatedPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUpdatedPrice.AutoSize = true;
            this.lblUpdatedPrice.Location = new System.Drawing.Point(7, 151);
            this.lblUpdatedPrice.Name = "lblUpdatedPrice";
            this.lblUpdatedPrice.Size = new System.Drawing.Size(98, 15);
            this.lblUpdatedPrice.TabIndex = 8;
            this.lblUpdatedPrice.Text = "Updated Price";
            // 
            // txtUpdatedVin
            // 
            this.txtUpdatedVin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUpdatedVin.Location = new System.Drawing.Point(119, 7);
            this.txtUpdatedVin.Name = "txtUpdatedVin";
            this.txtUpdatedVin.Size = new System.Drawing.Size(213, 21);
            this.txtUpdatedVin.TabIndex = 9;
            this.txtUpdatedVin.Validating += new System.ComponentModel.CancelEventHandler(this.txtUpdatedVin_Validating);
            // 
            // txtUpdatedMake
            // 
            this.txtUpdatedMake.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUpdatedMake.Location = new System.Drawing.Point(119, 42);
            this.txtUpdatedMake.Name = "txtUpdatedMake";
            this.txtUpdatedMake.Size = new System.Drawing.Size(213, 21);
            this.txtUpdatedMake.TabIndex = 10;
            // 
            // txtUpdatedModel
            // 
            this.txtUpdatedModel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUpdatedModel.Location = new System.Drawing.Point(119, 77);
            this.txtUpdatedModel.Name = "txtUpdatedModel";
            this.txtUpdatedModel.Size = new System.Drawing.Size(213, 21);
            this.txtUpdatedModel.TabIndex = 11;
            // 
            // txtUpdatedYear
            // 
            this.txtUpdatedYear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUpdatedYear.Location = new System.Drawing.Point(119, 112);
            this.txtUpdatedYear.Name = "txtUpdatedYear";
            this.txtUpdatedYear.Size = new System.Drawing.Size(213, 21);
            this.txtUpdatedYear.TabIndex = 12;
            this.txtUpdatedYear.Validating += new System.ComponentModel.CancelEventHandler(this.txtUpdatedYear_Validating);
            // 
            // txtUpdatedPrice
            // 
            this.txtUpdatedPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUpdatedPrice.Location = new System.Drawing.Point(119, 148);
            this.txtUpdatedPrice.Name = "txtUpdatedPrice";
            this.txtUpdatedPrice.Size = new System.Drawing.Size(213, 21);
            this.txtUpdatedPrice.TabIndex = 13;
            this.txtUpdatedPrice.Validating += new System.ComponentModel.CancelEventHandler(this.txtUpdatedPrice_Validating);
            // 
            // btnEditThisRecord
            // 
            this.btnEditThisRecord.Location = new System.Drawing.Point(109, 138);
            this.btnEditThisRecord.Name = "btnEditThisRecord";
            this.btnEditThisRecord.Size = new System.Drawing.Size(183, 25);
            this.btnEditThisRecord.TabIndex = 12;
            this.btnEditThisRecord.Text = "Edit This Record";
            this.btnEditThisRecord.UseVisualStyleBackColor = true;
            this.btnEditThisRecord.Click += new System.EventHandler(this.btnEditThisRecord_Click);
            // 
            // lblVINToEdit
            // 
            this.lblVINToEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVINToEdit.AutoSize = true;
            this.lblVINToEdit.Location = new System.Drawing.Point(56, 94);
            this.lblVINToEdit.Name = "lblVINToEdit";
            this.lblVINToEdit.Size = new System.Drawing.Size(29, 15);
            this.lblVINToEdit.TabIndex = 10;
            this.lblVINToEdit.Text = "VIN";
            // 
            // txtVINToEdit
            // 
            this.txtVINToEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVINToEdit.Location = new System.Drawing.Point(134, 91);
            this.txtVINToEdit.Name = "txtVINToEdit";
            this.txtVINToEdit.Size = new System.Drawing.Size(213, 21);
            this.txtVINToEdit.TabIndex = 11;
            this.txtVINToEdit.TextChanged += new System.EventHandler(this.txtVINToEdit_TextChanged);
            // 
            // btnUpdateRecord
            // 
            this.btnUpdateRecord.Location = new System.Drawing.Point(108, 439);
            this.btnUpdateRecord.Name = "btnUpdateRecord";
            this.btnUpdateRecord.Size = new System.Drawing.Size(183, 25);
            this.btnUpdateRecord.TabIndex = 3;
            this.btnUpdateRecord.Text = "Update Record";
            this.btnUpdateRecord.UseVisualStyleBackColor = true;
            this.btnUpdateRecord.Visible = false;
            this.btnUpdateRecord.Click += new System.EventHandler(this.btnUpdateRecord_Click);
            // 
            // tbpgDeleteCar
            // 
            this.tbpgDeleteCar.BackColor = System.Drawing.Color.LightCyan;
            this.tbpgDeleteCar.Controls.Add(this.lblDeleteMessage);
            this.tbpgDeleteCar.Controls.Add(this.btnDeleteRecord);
            this.tbpgDeleteCar.Controls.Add(this.lblVINToDelete);
            this.tbpgDeleteCar.Controls.Add(this.txtVINToDelete);
            this.tbpgDeleteCar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbpgDeleteCar.Location = new System.Drawing.Point(4, 24);
            this.tbpgDeleteCar.Name = "tbpgDeleteCar";
            this.tbpgDeleteCar.Size = new System.Drawing.Size(429, 509);
            this.tbpgDeleteCar.TabIndex = 2;
            this.tbpgDeleteCar.Text = "Delete Car";
            // 
            // lblDeleteMessage
            // 
            this.lblDeleteMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDeleteMessage.AutoSize = true;
            this.lblDeleteMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteMessage.ForeColor = System.Drawing.Color.Green;
            this.lblDeleteMessage.Location = new System.Drawing.Point(48, 49);
            this.lblDeleteMessage.Name = "lblDeleteMessage";
            this.lblDeleteMessage.Size = new System.Drawing.Size(317, 30);
            this.lblDeleteMessage.TabIndex = 16;
            this.lblDeleteMessage.Text = "Enter the VIN of the record you want to delete or \r\nselect it from the grid on th" +
    "e right:";
            // 
            // btnDeleteRecord
            // 
            this.btnDeleteRecord.Location = new System.Drawing.Point(115, 174);
            this.btnDeleteRecord.Name = "btnDeleteRecord";
            this.btnDeleteRecord.Size = new System.Drawing.Size(183, 25);
            this.btnDeleteRecord.TabIndex = 15;
            this.btnDeleteRecord.Text = "Delete This Record";
            this.btnDeleteRecord.UseVisualStyleBackColor = true;
            this.btnDeleteRecord.Click += new System.EventHandler(this.btnDeleteRecord_Click);
            // 
            // lblVINToDelete
            // 
            this.lblVINToDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVINToDelete.AutoSize = true;
            this.lblVINToDelete.Location = new System.Drawing.Point(71, 127);
            this.lblVINToDelete.Name = "lblVINToDelete";
            this.lblVINToDelete.Size = new System.Drawing.Size(29, 15);
            this.lblVINToDelete.TabIndex = 13;
            this.lblVINToDelete.Text = "VIN";
            // 
            // txtVINToDelete
            // 
            this.txtVINToDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVINToDelete.Location = new System.Drawing.Point(141, 124);
            this.txtVINToDelete.Name = "txtVINToDelete";
            this.txtVINToDelete.Size = new System.Drawing.Size(213, 21);
            this.txtVINToDelete.TabIndex = 14;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.OldLace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1259, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openAllToolStripMenuItem,
            this.closeAllToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openAllToolStripMenuItem
            // 
            this.openAllToolStripMenuItem.Name = "openAllToolStripMenuItem";
            this.openAllToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.openAllToolStripMenuItem.Text = "Open All";
            this.openAllToolStripMenuItem.Click += new System.EventHandler(this.openAllToolStripMenuItem_Click);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.closeAllToolStripMenuItem.Text = "Close All";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.closeAllToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblBegin
            // 
            this.lblBegin.AutoSize = true;
            this.lblBegin.BackColor = System.Drawing.SystemColors.Info;
            this.lblBegin.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBegin.Location = new System.Drawing.Point(16, 61);
            this.lblBegin.Name = "lblBegin";
            this.lblBegin.Size = new System.Drawing.Size(191, 30);
            this.lblBegin.TabIndex = 6;
            this.lblBegin.Text = "Click File to begin";
            // 
            // lblUpdateTheFields
            // 
            this.lblUpdateTheFields.AutoSize = true;
            this.lblUpdateTheFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateTheFields.ForeColor = System.Drawing.Color.Green;
            this.lblUpdateTheFields.Location = new System.Drawing.Point(35, 200);
            this.lblUpdateTheFields.Name = "lblUpdateTheFields";
            this.lblUpdateTheFields.Size = new System.Drawing.Size(276, 15);
            this.lblUpdateTheFields.TabIndex = 15;
            this.lblUpdateTheFields.Text = "Update the fields that need to be updated:";
            this.lblUpdateTheFields.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinFormsApp_CarDatabaseManagement.Properties.Resources.carwallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1259, 810);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblBegin);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.grpCRUD);
            this.Controls.Add(this.grpDisplay);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "123Cars.com HOME";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdInventory)).EndInit();
            this.grpCRUD.ResumeLayout(false);
            this.tbctrlManageInventory.ResumeLayout(false);
            this.tbpgAddCar.ResumeLayout(false);
            this.tblAddRecord.ResumeLayout(false);
            this.tblAddRecord.PerformLayout();
            this.tbpgEditCar.ResumeLayout(false);
            this.tbpgEditCar.PerformLayout();
            this.tblUpdate.ResumeLayout(false);
            this.tblUpdate.PerformLayout();
            this.tbpgDeleteCar.ResumeLayout(false);
            this.tbpgDeleteCar.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDisplay;
        private System.Windows.Forms.GroupBox grpCRUD;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblBegin;
        private System.Windows.Forms.DataGridView dtgrdInventory;
        private System.Windows.Forms.TabControl tbctrlManageInventory;
        private System.Windows.Forms.TabPage tbpgAddCar;
        private System.Windows.Forms.Button btnAddRecord;
        private System.Windows.Forms.TableLayoutPanel tblAddRecord;
        private System.Windows.Forms.Label lblVINToAdd;
        private System.Windows.Forms.Label lblMakeToAdd;
        private System.Windows.Forms.Label lblModelToAdd;
        private System.Windows.Forms.Label lblYearToAdd;
        private System.Windows.Forms.Label lblPriceToAdd;
        private System.Windows.Forms.TextBox txtVINToAdd;
        private System.Windows.Forms.TextBox txtMakeToAdd;
        private System.Windows.Forms.TextBox txtModelToAdd;
        private System.Windows.Forms.TextBox txtYearToAdd;
        private System.Windows.Forms.TextBox txtPriceToAdd;
        private System.Windows.Forms.TabPage tbpgEditCar;
        private System.Windows.Forms.Label lblEdit;
        private System.Windows.Forms.TableLayoutPanel tblUpdate;
        private System.Windows.Forms.Label lblUpdatedVIN;
        private System.Windows.Forms.Label lblUpdatedMake;
        private System.Windows.Forms.Label lblUpdatedModel;
        private System.Windows.Forms.Label lblUpdatedYear;
        private System.Windows.Forms.Label lblUpdatedPrice;
        private System.Windows.Forms.TextBox txtUpdatedVin;
        private System.Windows.Forms.TextBox txtUpdatedMake;
        private System.Windows.Forms.TextBox txtUpdatedModel;
        private System.Windows.Forms.TextBox txtUpdatedYear;
        private System.Windows.Forms.TextBox txtUpdatedPrice;
        private System.Windows.Forms.Button btnEditThisRecord;
        private System.Windows.Forms.Label lblVINToEdit;
        private System.Windows.Forms.TextBox txtVINToEdit;
        private System.Windows.Forms.Button btnUpdateRecord;
        private System.Windows.Forms.TabPage tbpgDeleteCar;
        private System.Windows.Forms.Label lblDeleteMessage;
        private System.Windows.Forms.Button btnDeleteRecord;
        private System.Windows.Forms.Label lblVINToDelete;
        private System.Windows.Forms.TextBox txtVINToDelete;
        private System.Windows.Forms.Label lblUpdateTheFields;
    }
}

