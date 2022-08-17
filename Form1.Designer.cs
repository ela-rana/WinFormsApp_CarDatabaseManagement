
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
            this.viewInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeChangesToInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeInventoryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDisplay
            // 
            this.grpDisplay.BackColor = System.Drawing.Color.OldLace;
            this.grpDisplay.Location = new System.Drawing.Point(694, 70);
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
            this.grpCRUD.Location = new System.Drawing.Point(26, 70);
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
            this.viewInventoryToolStripMenuItem,
            this.closeInventoryToolStripMenuItem,
            this.makeChangesToInventoryToolStripMenuItem,
            this.closeInventoryToolStripMenuItem1,
            this.openAllToolStripMenuItem,
            this.closeAllToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // viewInventoryToolStripMenuItem
            // 
            this.viewInventoryToolStripMenuItem.Name = "viewInventoryToolStripMenuItem";
            this.viewInventoryToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.viewInventoryToolStripMenuItem.Text = "View Inventory";
            this.viewInventoryToolStripMenuItem.Click += new System.EventHandler(this.viewInventoryToolStripMenuItem_Click);
            // 
            // closeInventoryToolStripMenuItem
            // 
            this.closeInventoryToolStripMenuItem.Name = "closeInventoryToolStripMenuItem";
            this.closeInventoryToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.closeInventoryToolStripMenuItem.Text = "Close Inventory";
            this.closeInventoryToolStripMenuItem.Click += new System.EventHandler(this.closeInventoryToolStripMenuItem_Click);
            // 
            // makeChangesToInventoryToolStripMenuItem
            // 
            this.makeChangesToInventoryToolStripMenuItem.Name = "makeChangesToInventoryToolStripMenuItem";
            this.makeChangesToInventoryToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.makeChangesToInventoryToolStripMenuItem.Text = "Open Inventory Editor";
            this.makeChangesToInventoryToolStripMenuItem.Click += new System.EventHandler(this.makeChangesToInventoryToolStripMenuItem_Click);
            // 
            // closeInventoryToolStripMenuItem1
            // 
            this.closeInventoryToolStripMenuItem1.Name = "closeInventoryToolStripMenuItem1";
            this.closeInventoryToolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
            this.closeInventoryToolStripMenuItem1.Text = "Close Inventory Editor";
            this.closeInventoryToolStripMenuItem1.Click += new System.EventHandler(this.closeInventoryToolStripMenuItem1_Click);
            // 
            // openAllToolStripMenuItem
            // 
            this.openAllToolStripMenuItem.Name = "openAllToolStripMenuItem";
            this.openAllToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.openAllToolStripMenuItem.Text = "Open All";
            this.openAllToolStripMenuItem.Click += new System.EventHandler(this.openAllToolStripMenuItem_Click);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.closeAllToolStripMenuItem.Text = "Close All";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.closeAllToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinFormsApp_CarDatabaseManagement.Properties.Resources.carwallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1480, 967);
            this.Controls.Add(this.grpCRUD);
            this.Controls.Add(this.grpDisplay);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "123Cars.com HOME";
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
        private System.Windows.Forms.ToolStripMenuItem viewInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeChangesToInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeInventoryToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

