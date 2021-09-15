
namespace GiftShopView
{
    partial class FormReportComponentGifts
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
            this.buttonSaveToExcel = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.GiftColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComponentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSaveToExcel
            // 
            this.buttonSaveToExcel.Location = new System.Drawing.Point(12, 12);
            this.buttonSaveToExcel.Name = "buttonSaveToExcel";
            this.buttonSaveToExcel.Size = new System.Drawing.Size(159, 21);
            this.buttonSaveToExcel.TabIndex = 2;
            this.buttonSaveToExcel.Text = "Save to Excel";
            this.buttonSaveToExcel.UseVisualStyleBackColor = true;
            this.buttonSaveToExcel.Click += new System.EventHandler(this.ButtonSaveToExcel_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GiftColumn,
            this.ComponentColumn,
            this.CountColumn});
            this.dataGridView.Location = new System.Drawing.Point(12, 44);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(516, 394);
            this.dataGridView.TabIndex = 3;
            // 
            // GiftColumn
            // 
            this.GiftColumn.HeaderText = "Gift";
            this.GiftColumn.Name = "GiftColumn";
            this.GiftColumn.Width = 200;
            // 
            // ComponentColumn
            // 
            this.ComponentColumn.HeaderText = "Component";
            this.ComponentColumn.Name = "ComponentColumn";
            this.ComponentColumn.Width = 200;
            // 
            // CountColumn
            // 
            this.CountColumn.HeaderText = "Quantity";
            this.CountColumn.Name = "CountColumn";
            this.CountColumn.Width = 110;
            // 
            // FormReportComponentGifts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(540, 450);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttonSaveToExcel);
            this.Name = "FormReportComponentGifts";
            this.Text = "Products by component";
            this.Load += new System.EventHandler(this.FormReportProductComponents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSaveToExcel;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiftColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComponentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountColumn;
    }
}