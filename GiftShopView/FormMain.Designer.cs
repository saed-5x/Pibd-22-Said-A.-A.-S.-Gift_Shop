﻿
using System;

namespace GiftShopView
{
    partial class FormMain
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.DirectoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ComponentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artistsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListofProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductsbyComponentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListofOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startWorkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lettersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonCreateOrder = new System.Windows.Forms.Button();
            this.buttonPayOrder = new System.Windows.Forms.Button();
            this.buttonRef = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.makeBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DirectoriesToolStripMenuItem,
            this.ReportsToolStripMenuItem,
            this.startWorkToolStripMenuItem,
            this.lettersToolStripMenuItem,
            this.makeBackupToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1191, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // DirectoriesToolStripMenuItem
            // 
            this.DirectoriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ComponentsToolStripMenuItem,
            this.ProductsToolStripMenuItem,
            this.ClientsToolStripMenuItem,
            this.artistsToolStripMenuItem});
            this.DirectoriesToolStripMenuItem.Name = "DirectoriesToolStripMenuItem";
            this.DirectoriesToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.DirectoriesToolStripMenuItem.Text = "Directories";
            // 
            // ComponentsToolStripMenuItem
            // 
            this.ComponentsToolStripMenuItem.Name = "ComponentsToolStripMenuItem";
            this.ComponentsToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.ComponentsToolStripMenuItem.Text = "Components";
            this.ComponentsToolStripMenuItem.Click += new System.EventHandler(this.ComponentsToolStripMenuItem_Click);
            // 
            // ProductsToolStripMenuItem
            // 
            this.ProductsToolStripMenuItem.Name = "ProductsToolStripMenuItem";
            this.ProductsToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.ProductsToolStripMenuItem.Text = "Products";
            this.ProductsToolStripMenuItem.Click += new System.EventHandler(this.ProductsToolStripMenuItem_Click);
            // 
            // ClientsToolStripMenuItem
            // 
            this.ClientsToolStripMenuItem.Name = "ClientsToolStripMenuItem";
            this.ClientsToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.ClientsToolStripMenuItem.Text = "Clients";
            this.ClientsToolStripMenuItem.Click += new System.EventHandler(this.ClientsToolStripMenuItem_Click);
            // 
            // artistsToolStripMenuItem
            // 
            this.artistsToolStripMenuItem.Name = "artistsToolStripMenuItem";
            this.artistsToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.artistsToolStripMenuItem.Text = "Artists";
            this.artistsToolStripMenuItem.Click += new System.EventHandler(this.ArtistToolStripMenuItem_Click);
            // 
            // ReportsToolStripMenuItem
            // 
            this.ReportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ListofProductsToolStripMenuItem,
            this.ProductsbyComponentToolStripMenuItem,
            this.ListofOrdersToolStripMenuItem});
            this.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem";
            this.ReportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.ReportsToolStripMenuItem.Text = "Reports";
            // 
            // ListofProductsToolStripMenuItem
            // 
            this.ListofProductsToolStripMenuItem.Name = "ListofProductsToolStripMenuItem";
            this.ListofProductsToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.ListofProductsToolStripMenuItem.Text = "List of products";
            this.ListofProductsToolStripMenuItem.Click += new System.EventHandler(this.ListofProductsToolStripMenuItem_Click);
            // 
            // ProductsbyComponentToolStripMenuItem
            // 
            this.ProductsbyComponentToolStripMenuItem.Name = "ProductsbyComponentToolStripMenuItem";
            this.ProductsbyComponentToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.ProductsbyComponentToolStripMenuItem.Text = "Products by component";
            this.ProductsbyComponentToolStripMenuItem.Click += new System.EventHandler(this.ProductsByComponentsToolStripMenuItem_Click);
            // 
            // ListofOrdersToolStripMenuItem
            // 
            this.ListofOrdersToolStripMenuItem.Name = "ListofOrdersToolStripMenuItem";
            this.ListofOrdersToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.ListofOrdersToolStripMenuItem.Text = "List of oreders";
            this.ListofOrdersToolStripMenuItem.Click += new System.EventHandler(this.ListofOrdersToolStripMenuItem_Click);
            // 
            // startWorkToolStripMenuItem
            // 
            this.startWorkToolStripMenuItem.Name = "startWorkToolStripMenuItem";
            this.startWorkToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.startWorkToolStripMenuItem.Text = "Start work";
            this.startWorkToolStripMenuItem.Click += new System.EventHandler(this.StartworkToolStripMenuItem_Click);
            // 
            // lettersToolStripMenuItem
            // 
            this.lettersToolStripMenuItem.Name = "lettersToolStripMenuItem";
            this.lettersToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.lettersToolStripMenuItem.Text = "Letters";
            this.lettersToolStripMenuItem.Click += new System.EventHandler(this.lettersToolStripMenuItem_Click);
            // 
            // buttonCreateOrder
            // 
            this.buttonCreateOrder.Location = new System.Drawing.Point(1079, 69);
            this.buttonCreateOrder.Name = "buttonCreateOrder";
            this.buttonCreateOrder.Size = new System.Drawing.Size(87, 23);
            this.buttonCreateOrder.TabIndex = 1;
            this.buttonCreateOrder.Text = "Create order";
            this.buttonCreateOrder.UseVisualStyleBackColor = true;
            this.buttonCreateOrder.Click += new System.EventHandler(this.ButtonCreateOrder_Click);
            // 
            // buttonPayOrder
            // 
            this.buttonPayOrder.Location = new System.Drawing.Point(1079, 171);
            this.buttonPayOrder.Name = "buttonPayOrder";
            this.buttonPayOrder.Size = new System.Drawing.Size(87, 23);
            this.buttonPayOrder.TabIndex = 4;
            this.buttonPayOrder.Text = "Pay order";
            this.buttonPayOrder.UseVisualStyleBackColor = true;
            this.buttonPayOrder.Click += new System.EventHandler(this.ButtonPayOrder_Click);
            // 
            // buttonRef
            // 
            this.buttonRef.Location = new System.Drawing.Point(1079, 271);
            this.buttonRef.Name = "buttonRef";
            this.buttonRef.Size = new System.Drawing.Size(87, 23);
            this.buttonRef.TabIndex = 5;
            this.buttonRef.Text = "Refresh list";
            this.buttonRef.UseVisualStyleBackColor = true;
            this.buttonRef.Click += new System.EventHandler(this.ButtonRef_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(0, 28);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1063, 321);
            this.dataGridView.TabIndex = 6;
            // 
            // makeBackupToolStripMenuItem
            // 
            this.makeBackupToolStripMenuItem.Name = "makeBackupToolStripMenuItem";
            this.makeBackupToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.makeBackupToolStripMenuItem.Text = "Make backup";
            this.makeBackupToolStripMenuItem.Click += new System.EventHandler(this.makeBackupToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1191, 351);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttonRef);
            this.Controls.Add(this.buttonPayOrder);
            this.Controls.Add(this.buttonCreateOrder);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormMain";
            this.Text = "Gift shop";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem DirectoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ComponentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProductsToolStripMenuItem;
        private System.Windows.Forms.Button buttonCreateOrder;
        private System.Windows.Forms.Button buttonPayOrder;
        private System.Windows.Forms.Button buttonRef;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ToolStripMenuItem ReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListofOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProductsbyComponentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListofProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artistsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startWorkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lettersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeBackupToolStripMenuItem;
    }
}