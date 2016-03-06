namespace Ve.KodeKata.Martian.FormsUI
{
    partial class FrmMarsOne
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRigth = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtMovements = new System.Windows.Forms.TextBox();
            this.lblMovements = new System.Windows.Forms.Label();
            this.lblHeigth = new System.Windows.Forms.Label();
            this.txtHeigth = new System.Windows.Forms.TextBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(520, 51);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 23);
            this.btnUp.TabIndex = 0;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(520, 109);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(75, 23);
            this.btnDown.TabIndex = 1;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(567, 80);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 23);
            this.btnLeft.TabIndex = 2;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRigth
            // 
            this.btnRigth.Location = new System.Drawing.Point(472, 80);
            this.btnRigth.Name = "btnRigth";
            this.btnRigth.Size = new System.Drawing.Size(75, 23);
            this.btnRigth.TabIndex = 3;
            this.btnRigth.Text = "Rigth";
            this.btnRigth.UseVisualStyleBackColor = true;
            this.btnRigth.Click += new System.EventHandler(this.btnRigth_Click);
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(472, 224);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(75, 23);
            this.btnMove.TabIndex = 4;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(567, 224);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtMovements
            // 
            this.txtMovements.Location = new System.Drawing.Point(472, 189);
            this.txtMovements.Name = "txtMovements";
            this.txtMovements.Size = new System.Drawing.Size(170, 20);
            this.txtMovements.TabIndex = 6;

            // 
            // lblMovements
            // 
            this.lblMovements.AutoSize = true;
            this.lblMovements.Location = new System.Drawing.Point(469, 173);
            this.lblMovements.Name = "lblMovements";
            this.lblMovements.Size = new System.Drawing.Size(62, 13);
            this.lblMovements.TabIndex = 7;
            this.lblMovements.Text = "Movements";

            // 
            // lblHeigth
            // 
            this.lblHeigth.AutoSize = true;
            this.lblHeigth.Location = new System.Drawing.Point(113, 9);
            this.lblHeigth.Name = "lblHeigth";
            this.lblHeigth.Size = new System.Drawing.Size(38, 13);
            this.lblHeigth.TabIndex = 9;
            this.lblHeigth.Text = "Heigth";
            // 
            // txtHeigth
            // 
            this.txtHeigth.Location = new System.Drawing.Point(116, 25);
            this.txtHeigth.Name = "txtHeigth";
            this.txtHeigth.Size = new System.Drawing.Size(59, 20);
            this.txtHeigth.TabIndex = 8;
            this.txtHeigth.TextChanged += new System.EventHandler(this.txtHeigth_TextChanged);
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(12, 9);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(40, 13);
            this.lblLength.TabIndex = 11;
            this.lblLength.Text = "Length";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(15, 25);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(60, 20);
            this.txtLength.TabIndex = 10;
            this.txtLength.TextChanged += new System.EventHandler(this.txtLength_TextChanged);
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(15, 64);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.Size = new System.Drawing.Size(422, 184);
            this.txtResults.TabIndex = 12;
            // 
            // FrmMarsOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 277);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.lblHeigth);
            this.Controls.Add(this.txtHeigth);
            this.Controls.Add(this.lblMovements);
            this.Controls.Add(this.txtMovements);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.btnRigth);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Name = "FrmMarsOne";
            this.Text = "Mars One";
            this.Load += new System.EventHandler(this.frmMarsOne_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRigth;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtMovements;
        private System.Windows.Forms.Label lblMovements;
        private System.Windows.Forms.Label lblHeigth;
        private System.Windows.Forms.TextBox txtHeigth;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtResults;
    }
}

