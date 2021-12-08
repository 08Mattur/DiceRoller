namespace DiceRoller.Forms.UserControls
{
    partial class Dice
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDice
            // 
            this.lblDice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDice.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDice.Location = new System.Drawing.Point(0, 0);
            this.lblDice.Name = "lblDice";
            this.lblDice.Size = new System.Drawing.Size(89, 88);
            this.lblDice.TabIndex = 0;
            this.lblDice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.lblDice);
            this.Name = "Dice";
            this.Size = new System.Drawing.Size(89, 88);
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblDice;
    }
}
