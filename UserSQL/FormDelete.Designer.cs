
namespace UserSQL
{
    partial class FormDelete
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
            this.lblDelete = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvEliminated = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminated)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTable.Location = new System.Drawing.Point(304, 192);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(134, 17);
            this.lblTable.TabIndex = 19;
            this.lblTable.Text = "Registro tabla";
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelete.Location = new System.Drawing.Point(70, 86);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(170, 17);
            this.lblDelete.TabIndex = 21;
            this.lblDelete.Text = "Usuario a eliminar";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(279, 83);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(141, 20);
            this.txtUser.TabIndex = 22;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(189, 138);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(141, 36);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvEliminated
            // 
            this.dgvEliminated.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEliminated.Location = new System.Drawing.Point(200, 242);
            this.dgvEliminated.Name = "dgvEliminated";
            this.dgvEliminated.Size = new System.Drawing.Size(372, 150);
            this.dgvEliminated.TabIndex = 24;
            this.dgvEliminated.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEliminated_CellContentClick);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(394, 138);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(141, 36);
            this.btnClose.TabIndex = 25;
            this.btnClose.Text = "Salir";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvEliminated);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblDelete);
            this.Controls.Add(this.lblTable);
            this.Name = "FormDelete";
            this.Text = "FormDelete";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminated)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvEliminated;
        private System.Windows.Forms.Button btnClose;
    }
}