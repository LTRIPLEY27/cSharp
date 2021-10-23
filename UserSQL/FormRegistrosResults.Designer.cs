
namespace UserSQL
{
    partial class FormRegistrosResults
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
            this.lblTable = new System.Windows.Forms.Label();
            this.dgvData1 = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTable.Location = new System.Drawing.Point(290, 56);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(134, 17);
            this.lblTable.TabIndex = 19;
            this.lblTable.Text = "Registro tabla";
            // 
            // dgvData1
            // 
            this.dgvData1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData1.Location = new System.Drawing.Point(108, 126);
            this.dgvData1.Name = "dgvData1";
            this.dgvData1.Size = new System.Drawing.Size(586, 231);
            this.dgvData1.TabIndex = 20;
            this.dgvData1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData1_CellContentClick);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(293, 391);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(146, 36);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormRegistrosResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvData1);
            this.Controls.Add(this.lblTable);
            this.Name = "FormRegistrosResults";
            this.Text = "FormRegistrosResults";
            ((System.ComponentModel.ISupportInitialize)(this.dgvData1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.DataGridView dgvData1;
        private System.Windows.Forms.Button btnClose;
    }
}