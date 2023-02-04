namespace WinFormsApp_ADOdotNET
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtInput = new System.Windows.Forms.TextBox();
            this.mainGrid = new System.Windows.Forms.DataGridView();
            this.btnDeliveris = new System.Windows.Forms.Button();
            this.btnGoods = new System.Windows.Forms.Button();
            this.btnGoodsTypes = new System.Windows.Forms.Button();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 12);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(1020, 23);
            this.txtInput.TabIndex = 0;
            // 
            // mainGrid
            // 
            this.mainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainGrid.Location = new System.Drawing.Point(16, 52);
            this.mainGrid.Name = "mainGrid";
            this.mainGrid.RowTemplate.Height = 25;
            this.mainGrid.Size = new System.Drawing.Size(732, 386);
            this.mainGrid.TabIndex = 1;
            // 
            // btnDeliveris
            // 
            this.btnDeliveris.AutoSize = true;
            this.btnDeliveris.Location = new System.Drawing.Point(754, 52);
            this.btnDeliveris.Name = "btnDeliveris";
            this.btnDeliveris.Size = new System.Drawing.Size(80, 25);
            this.btnDeliveris.TabIndex = 2;
            this.btnDeliveris.Text = "Deliveries";
            this.btnDeliveris.UseVisualStyleBackColor = true;
            // 
            // btnGoods
            // 
            this.btnGoods.AutoSize = true;
            this.btnGoods.Location = new System.Drawing.Point(754, 83);
            this.btnGoods.Name = "btnGoods";
            this.btnGoods.Size = new System.Drawing.Size(80, 25);
            this.btnGoods.TabIndex = 3;
            this.btnGoods.Text = "Goods";
            this.btnGoods.UseVisualStyleBackColor = true;
            // 
            // btnGoodsTypes
            // 
            this.btnGoodsTypes.AutoSize = true;
            this.btnGoodsTypes.Location = new System.Drawing.Point(754, 114);
            this.btnGoodsTypes.Name = "btnGoodsTypes";
            this.btnGoodsTypes.Size = new System.Drawing.Size(80, 25);
            this.btnGoodsTypes.TabIndex = 4;
            this.btnGoodsTypes.Text = "GoodsTypes";
            this.btnGoodsTypes.UseVisualStyleBackColor = true;
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.AutoSize = true;
            this.btnSuppliers.Location = new System.Drawing.Point(754, 145);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(80, 25);
            this.btnSuppliers.TabIndex = 5;
            this.btnSuppliers.Text = "Suppliers";
            this.btnSuppliers.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.Location = new System.Drawing.Point(754, 413);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(278, 25);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSuppliers);
            this.Controls.Add(this.btnGoodsTypes);
            this.Controls.Add(this.btnGoods);
            this.Controls.Add(this.btnDeliveris);
            this.Controls.Add(this.mainGrid);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mainGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtInput;
        private DataGridView mainGrid;
        private Button btnDeliveris;
        private Button btnGoods;
        private Button btnGoodsTypes;
        private Button btnSuppliers;
        private Button btnUpdate;
    }
}