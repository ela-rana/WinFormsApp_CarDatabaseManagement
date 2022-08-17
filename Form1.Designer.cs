
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
            this.grpCRUD = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblBegin = new System.Windows.Forms.Label();
            this.tabEditInventory = new System.Windows.Forms.TabControl();
            this.tbpgAddCar = new System.Windows.Forms.TabPage();
            this.tbpgEditCar = new System.Windows.Forms.TabPage();
            this.tbpgDeleteCar = new System.Windows.Forms.TabPage();
            this.dtgrdInventory = new System.Windows.Forms.DataGridView();
            this.grpDisplay.SuspendLayout();
            this.grpCRUD.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabEditInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDisplay
            // 
            this.grpDisplay.BackColor = System.Drawing.Color.OldLace;
            this.grpDisplay.Controls.Add(this.dtgrdInventory);
            this.grpDisplay.Location = new System.Drawing.Point(706, 71);
            this.grpDisplay.Name = "grpDisplay";
            this.grpDisplay.Size = new System.Drawing.Size(762, 849);
            this.grpDisplay.TabIndex = 0;
            this.grpDisplay.TabStop = false;
            this.grpDisplay.Text = "Car Inventory Display";
            this.grpDisplay.Visible = false;
            // 
            // grpCRUD
            // 
            this.grpCRUD.BackColor = System.Drawing.Color.OldLace;
            this.grpCRUD.Controls.Add(this.tabEditInventory);
            this.grpCRUD.Location = new System.Drawing.Point(30, 71);
            this.grpCRUD.Name = "grpCRUD";
            this.grpCRUD.Size = new System.Drawing.Size(647, 849);
            this.grpCRUD.TabIndex = 1;
            this.grpCRUD.TabStop = false;
            this.grpCRUD.Text = "What would you like to do?";
            this.grpCRUD.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.OldLace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1480, 24);
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
            this.openAllToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openAllToolStripMenuItem.Text = "Open All";
            this.openAllToolStripMenuItem.Click += new System.EventHandler(this.openAllToolStripMenuItem_Click);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeAllToolStripMenuItem.Text = "Close All";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.closeAllToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.Info;
            this.lblTitle.Font = new System.Drawing.Font("Curlz MT", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(530, 333);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(486, 128);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "123Cars.com";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.BackColor = System.Drawing.SystemColors.Info;
            this.lblSubtitle.Font = new System.Drawing.Font("Curlz MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.Location = new System.Drawing.Point(531, 461);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(485, 39);
            this.lblSubtitle.TabIndex = 4;
            this.lblSubtitle.Text = "We make buying a used car as easy as 1-2-3\r\n";
            // 
            // lblBegin
            // 
            this.lblBegin.AutoSize = true;
            this.lblBegin.BackColor = System.Drawing.SystemColors.Info;
            this.lblBegin.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBegin.Location = new System.Drawing.Point(29, 38);
            this.lblBegin.Name = "lblBegin";
            this.lblBegin.Size = new System.Drawing.Size(191, 30);
            this.lblBegin.TabIndex = 6;
            this.lblBegin.Text = "Click File to begin";
            // 
            // tabEditInventory
            // 
            this.tabEditInventory.Controls.Add(this.tbpgAddCar);
            this.tabEditInventory.Controls.Add(this.tbpgEditCar);
            this.tabEditInventory.Controls.Add(this.tbpgDeleteCar);
            this.tabEditInventory.Location = new System.Drawing.Point(0, 31);
            this.tabEditInventory.Name = "tabEditInventory";
            this.tabEditInventory.SelectedIndex = 0;
            this.tabEditInventory.Size = new System.Drawing.Size(647, 818);
            this.tabEditInventory.TabIndex = 0;
            // 
            // tbpgAddCar
            // 
            this.tbpgAddCar.BackColor = System.Drawing.Color.LavenderBlush;
            this.tbpgAddCar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbpgAddCar.Location = new System.Drawing.Point(4, 24);
            this.tbpgAddCar.Name = "tbpgAddCar";
            this.tbpgAddCar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgAddCar.Size = new System.Drawing.Size(639, 790);
            this.tbpgAddCar.TabIndex = 0;
            this.tbpgAddCar.Text = "Add New Car";
            // 
            // tbpgEditCar
            // 
            this.tbpgEditCar.BackColor = System.Drawing.Color.Lavender;
            this.tbpgEditCar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbpgEditCar.Location = new System.Drawing.Point(4, 24);
            this.tbpgEditCar.Name = "tbpgEditCar";
            this.tbpgEditCar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgEditCar.Size = new System.Drawing.Size(639, 790);
            this.tbpgEditCar.TabIndex = 1;
            this.tbpgEditCar.Text = "Edit A Car";
            // 
            // tbpgDeleteCar
            // 
            this.tbpgDeleteCar.BackColor = System.Drawing.Color.LightCyan;
            this.tbpgDeleteCar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbpgDeleteCar.Location = new System.Drawing.Point(4, 24);
            this.tbpgDeleteCar.Name = "tbpgDeleteCar";
            this.tbpgDeleteCar.Size = new System.Drawing.Size(639, 790);
            this.tbpgDeleteCar.TabIndex = 2;
            this.tbpgDeleteCar.Text = "Delete Car";
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
            this.dtgrdInventory.Size = new System.Drawing.Size(762, 794);
            this.dtgrdInventory.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinFormsApp_CarDatabaseManagement.Properties.Resources.carwallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1480, 967);
            this.Controls.Add(this.lblBegin);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblTitle);
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
            this.grpCRUD.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabEditInventory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdInventory)).EndInit();
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
        private System.Windows.Forms.TabControl tabEditInventory;
        private System.Windows.Forms.TabPage tbpgAddCar;
        private System.Windows.Forms.TabPage tbpgEditCar;
        private System.Windows.Forms.TabPage tbpgDeleteCar;
    }
}

