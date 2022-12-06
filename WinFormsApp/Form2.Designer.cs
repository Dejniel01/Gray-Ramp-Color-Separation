
namespace WinFormsApp
{
    partial class Form2
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CyanCanvas = new System.Windows.Forms.PictureBox();
            this.MagentaCanvas = new System.Windows.Forms.PictureBox();
            this.YellowCanvas = new System.Windows.Forms.PictureBox();
            this.BlackCanvas = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CyanCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MagentaCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YellowCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlackCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.CyanCanvas, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.MagentaCanvas, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.YellowCanvas, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BlackCanvas, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // CyanCanvas
            // 
            this.CyanCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CyanCanvas.Location = new System.Drawing.Point(3, 3);
            this.CyanCanvas.Name = "CyanCanvas";
            this.CyanCanvas.Size = new System.Drawing.Size(394, 219);
            this.CyanCanvas.TabIndex = 0;
            this.CyanCanvas.TabStop = false;
            // 
            // MagentaCanvas
            // 
            this.MagentaCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MagentaCanvas.Location = new System.Drawing.Point(403, 3);
            this.MagentaCanvas.Name = "MagentaCanvas";
            this.MagentaCanvas.Size = new System.Drawing.Size(394, 219);
            this.MagentaCanvas.TabIndex = 1;
            this.MagentaCanvas.TabStop = false;
            // 
            // YellowCanvas
            // 
            this.YellowCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.YellowCanvas.Location = new System.Drawing.Point(3, 228);
            this.YellowCanvas.Name = "YellowCanvas";
            this.YellowCanvas.Size = new System.Drawing.Size(394, 219);
            this.YellowCanvas.TabIndex = 2;
            this.YellowCanvas.TabStop = false;
            // 
            // BlackCanvas
            // 
            this.BlackCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BlackCanvas.Location = new System.Drawing.Point(403, 228);
            this.BlackCanvas.Name = "BlackCanvas";
            this.BlackCanvas.Size = new System.Drawing.Size(394, 219);
            this.BlackCanvas.TabIndex = 3;
            this.BlackCanvas.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CyanCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MagentaCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YellowCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlackCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox CyanCanvas;
        private System.Windows.Forms.PictureBox MagentaCanvas;
        private System.Windows.Forms.PictureBox YellowCanvas;
        private System.Windows.Forms.PictureBox BlackCanvas;
    }
}