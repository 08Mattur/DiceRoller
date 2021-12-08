namespace DiceRoller.Forms
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddD100 = new System.Windows.Forms.Button();
            this.btnAddD20 = new System.Windows.Forms.Button();
            this.btnAddD12 = new System.Windows.Forms.Button();
            this.btnAddD10 = new System.Windows.Forms.Button();
            this.btnAddD8 = new System.Windows.Forms.Button();
            this.btnAddD6 = new System.Windows.Forms.Button();
            this.btnAddD4 = new System.Windows.Forms.Button();
            this.btnRoll = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.flpDice = new System.Windows.Forms.FlowLayoutPanel();
            this.lblStringResult = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddD100);
            this.groupBox1.Controls.Add(this.btnAddD20);
            this.groupBox1.Controls.Add(this.btnAddD12);
            this.groupBox1.Controls.Add(this.btnAddD10);
            this.groupBox1.Controls.Add(this.btnAddD8);
            this.groupBox1.Controls.Add(this.btnAddD6);
            this.groupBox1.Controls.Add(this.btnAddD4);
            this.groupBox1.Location = new System.Drawing.Point(588, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 364);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dice";
            // 
            // btnAddD100
            // 
            this.btnAddD100.Location = new System.Drawing.Point(6, 325);
            this.btnAddD100.Name = "btnAddD100";
            this.btnAddD100.Size = new System.Drawing.Size(188, 23);
            this.btnAddD100.TabIndex = 6;
            this.btnAddD100.Text = "Add D100";
            this.btnAddD100.UseVisualStyleBackColor = true;
            this.btnAddD100.Click += new System.EventHandler(this.btnAddD100_Click);
            // 
            // btnAddD20
            // 
            this.btnAddD20.Location = new System.Drawing.Point(6, 275);
            this.btnAddD20.Name = "btnAddD20";
            this.btnAddD20.Size = new System.Drawing.Size(188, 23);
            this.btnAddD20.TabIndex = 5;
            this.btnAddD20.Text = "Add D20";
            this.btnAddD20.UseVisualStyleBackColor = true;
            this.btnAddD20.Click += new System.EventHandler(this.btnAddD20_Click);
            // 
            // btnAddD12
            // 
            this.btnAddD12.Location = new System.Drawing.Point(6, 225);
            this.btnAddD12.Name = "btnAddD12";
            this.btnAddD12.Size = new System.Drawing.Size(188, 23);
            this.btnAddD12.TabIndex = 4;
            this.btnAddD12.Text = "Add D12";
            this.btnAddD12.UseVisualStyleBackColor = true;
            this.btnAddD12.Click += new System.EventHandler(this.btnAddD12_Click);
            // 
            // btnAddD10
            // 
            this.btnAddD10.Location = new System.Drawing.Point(6, 175);
            this.btnAddD10.Name = "btnAddD10";
            this.btnAddD10.Size = new System.Drawing.Size(188, 23);
            this.btnAddD10.TabIndex = 3;
            this.btnAddD10.Text = "Add D10";
            this.btnAddD10.UseVisualStyleBackColor = true;
            this.btnAddD10.Click += new System.EventHandler(this.btnAddD10_Click);
            // 
            // btnAddD8
            // 
            this.btnAddD8.Location = new System.Drawing.Point(6, 125);
            this.btnAddD8.Name = "btnAddD8";
            this.btnAddD8.Size = new System.Drawing.Size(188, 23);
            this.btnAddD8.TabIndex = 2;
            this.btnAddD8.Text = "Add D8";
            this.btnAddD8.UseVisualStyleBackColor = true;
            this.btnAddD8.Click += new System.EventHandler(this.btnAddD8_Click);
            // 
            // btnAddD6
            // 
            this.btnAddD6.Location = new System.Drawing.Point(6, 75);
            this.btnAddD6.Name = "btnAddD6";
            this.btnAddD6.Size = new System.Drawing.Size(188, 23);
            this.btnAddD6.TabIndex = 1;
            this.btnAddD6.Text = "Add D6";
            this.btnAddD6.UseVisualStyleBackColor = true;
            this.btnAddD6.Click += new System.EventHandler(this.btnAddD6_Click);
            // 
            // btnAddD4
            // 
            this.btnAddD4.Location = new System.Drawing.Point(6, 25);
            this.btnAddD4.Name = "btnAddD4";
            this.btnAddD4.Size = new System.Drawing.Size(188, 23);
            this.btnAddD4.TabIndex = 0;
            this.btnAddD4.Text = "Add D4";
            this.btnAddD4.UseVisualStyleBackColor = true;
            this.btnAddD4.Click += new System.EventHandler(this.btnAddD4_Click);
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(594, 382);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(188, 56);
            this.btnRoll.TabIndex = 1;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flpDice, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(560, 426);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblResult, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblStringResult, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 365);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(554, 58);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Result";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblResult
            // 
            this.lblResult.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(113, 7);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 15);
            this.lblResult.TabIndex = 1;
            // 
            // flpDice
            // 
            this.flpDice.AutoScroll = true;
            this.flpDice.Location = new System.Drawing.Point(3, 3);
            this.flpDice.Name = "flpDice";
            this.flpDice.Size = new System.Drawing.Size(554, 356);
            this.flpDice.TabIndex = 1;
            // 
            // lblStringResult
            // 
            this.lblStringResult.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStringResult.AutoSize = true;
            this.lblStringResult.Location = new System.Drawing.Point(113, 36);
            this.lblStringResult.Name = "lblStringResult";
            this.lblStringResult.Size = new System.Drawing.Size(0, 15);
            this.lblStringResult.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btnAddD100;
        private Button btnAddD20;
        private Button btnAddD12;
        private Button btnAddD10;
        private Button btnAddD8;
        private Button btnAddD6;
        private Button btnAddD4;
        private Button btnRoll;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label lblResult;
        private FlowLayoutPanel flpDice;
        private Label lblStringResult;
    }
}