
namespace WinFormsApp
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BezierCanvas = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.HundredButton = new System.Windows.Forms.Button();
            this.UCRButton = new System.Windows.Forms.Button();
            this.GCRButton = new System.Windows.Forms.Button();
            this.SavePicButton = new System.Windows.Forms.Button();
            this.ChangePictureButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.BWButton = new System.Windows.Forms.Button();
            this.ShowAllButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AllCheckbox = new System.Windows.Forms.CheckBox();
            this.BlackButton = new System.Windows.Forms.RadioButton();
            this.YellowButton = new System.Windows.Forms.RadioButton();
            this.MagentaButton = new System.Windows.Forms.RadioButton();
            this.CyanButton = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ImageCanvas = new System.Windows.Forms.PictureBox();
            this.SeparatedImageCanvas = new System.Windows.Forms.PictureBox();
            this.ChangePicDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveCurvesDialog = new System.Windows.Forms.SaveFileDialog();
            this.LoadCurvesDialog = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BezierCanvas)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeparatedImageCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 550F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(982, 753);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoScroll = true;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 544F));
            this.tableLayoutPanel2.Controls.Add(this.BezierCanvas, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(544, 747);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // BezierCanvas
            // 
            this.BezierCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BezierCanvas.Location = new System.Drawing.Point(3, 3);
            this.BezierCanvas.Name = "BezierCanvas";
            this.BezierCanvas.Size = new System.Drawing.Size(538, 541);
            this.BezierCanvas.TabIndex = 0;
            this.BezierCanvas.TabStop = false;
            this.BezierCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BezierCanvas_MouseDown);
            this.BezierCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BezierCanvas_MouseMove);
            this.BezierCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BezierCanvas_MouseUp);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 550);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(538, 194);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Controls.Add(this.ZeroButton, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.HundredButton, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.UCRButton, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.GCRButton, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.SavePicButton, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.ChangePictureButton, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.SaveButton, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.LoadButton, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.BWButton, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.ShowAllButton, 2, 2);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(137, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(398, 188);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // ZeroButton
            // 
            this.ZeroButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZeroButton.Location = new System.Drawing.Point(8, 8);
            this.ZeroButton.Margin = new System.Windows.Forms.Padding(8);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(116, 31);
            this.ZeroButton.TabIndex = 0;
            this.ZeroButton.Text = "0%";
            this.ZeroButton.UseVisualStyleBackColor = true;
            this.ZeroButton.Click += new System.EventHandler(this.ZeroButton_Click);
            // 
            // HundredButton
            // 
            this.HundredButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HundredButton.Location = new System.Drawing.Point(8, 55);
            this.HundredButton.Margin = new System.Windows.Forms.Padding(8);
            this.HundredButton.Name = "HundredButton";
            this.HundredButton.Size = new System.Drawing.Size(116, 31);
            this.HundredButton.TabIndex = 1;
            this.HundredButton.Text = "100%";
            this.HundredButton.UseVisualStyleBackColor = true;
            this.HundredButton.Click += new System.EventHandler(this.HundredButton_Click);
            // 
            // UCRButton
            // 
            this.UCRButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UCRButton.Location = new System.Drawing.Point(8, 102);
            this.UCRButton.Margin = new System.Windows.Forms.Padding(8);
            this.UCRButton.Name = "UCRButton";
            this.UCRButton.Size = new System.Drawing.Size(116, 31);
            this.UCRButton.TabIndex = 2;
            this.UCRButton.Text = "UCR";
            this.UCRButton.UseVisualStyleBackColor = true;
            this.UCRButton.Click += new System.EventHandler(this.UCRButton_Click);
            // 
            // GCRButton
            // 
            this.GCRButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GCRButton.Location = new System.Drawing.Point(8, 149);
            this.GCRButton.Margin = new System.Windows.Forms.Padding(8);
            this.GCRButton.Name = "GCRButton";
            this.GCRButton.Size = new System.Drawing.Size(116, 31);
            this.GCRButton.TabIndex = 3;
            this.GCRButton.Text = "GCR";
            this.GCRButton.UseVisualStyleBackColor = true;
            this.GCRButton.Click += new System.EventHandler(this.GCRButton_Click);
            // 
            // SavePicButton
            // 
            this.SavePicButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SavePicButton.Location = new System.Drawing.Point(140, 8);
            this.SavePicButton.Margin = new System.Windows.Forms.Padding(8);
            this.SavePicButton.Name = "SavePicButton";
            this.SavePicButton.Size = new System.Drawing.Size(116, 31);
            this.SavePicButton.TabIndex = 4;
            this.SavePicButton.Text = "Save pictures";
            this.SavePicButton.UseVisualStyleBackColor = true;
            this.SavePicButton.Click += new System.EventHandler(this.SavePicButton_Click);
            // 
            // ChangePictureButton
            // 
            this.ChangePictureButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChangePictureButton.Location = new System.Drawing.Point(140, 55);
            this.ChangePictureButton.Margin = new System.Windows.Forms.Padding(8);
            this.ChangePictureButton.Name = "ChangePictureButton";
            this.ChangePictureButton.Size = new System.Drawing.Size(116, 31);
            this.ChangePictureButton.TabIndex = 5;
            this.ChangePictureButton.Text = "Change pic";
            this.ChangePictureButton.UseVisualStyleBackColor = true;
            this.ChangePictureButton.Click += new System.EventHandler(this.ChangePictureButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveButton.Location = new System.Drawing.Point(140, 102);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(8);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(116, 31);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Save curves";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoadButton.Location = new System.Drawing.Point(140, 149);
            this.LoadButton.Margin = new System.Windows.Forms.Padding(8);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(116, 31);
            this.LoadButton.TabIndex = 7;
            this.LoadButton.Text = "Load curves";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // BWButton
            // 
            this.BWButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BWButton.Location = new System.Drawing.Point(272, 8);
            this.BWButton.Margin = new System.Windows.Forms.Padding(8);
            this.BWButton.Name = "BWButton";
            this.tableLayoutPanel5.SetRowSpan(this.BWButton, 2);
            this.BWButton.Size = new System.Drawing.Size(118, 78);
            this.BWButton.TabIndex = 8;
            this.BWButton.Text = "Black and white";
            this.BWButton.UseVisualStyleBackColor = true;
            // 
            // ShowAllButton
            // 
            this.ShowAllButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShowAllButton.Location = new System.Drawing.Point(272, 102);
            this.ShowAllButton.Margin = new System.Windows.Forms.Padding(8);
            this.ShowAllButton.Name = "ShowAllButton";
            this.tableLayoutPanel5.SetRowSpan(this.ShowAllButton, 2);
            this.ShowAllButton.Size = new System.Drawing.Size(118, 78);
            this.ShowAllButton.TabIndex = 9;
            this.ShowAllButton.Text = "Show all pictures";
            this.ShowAllButton.UseVisualStyleBackColor = true;
            this.ShowAllButton.Click += new System.EventHandler(this.ShowAllButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AllCheckbox);
            this.groupBox1.Controls.Add(this.BlackButton);
            this.groupBox1.Controls.Add(this.YellowButton);
            this.groupBox1.Controls.Add(this.MagentaButton);
            this.groupBox1.Controls.Add(this.CyanButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 188);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Curves";
            // 
            // AllCheckbox
            // 
            this.AllCheckbox.Checked = true;
            this.AllCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AllCheckbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.AllCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AllCheckbox.Location = new System.Drawing.Point(3, 143);
            this.AllCheckbox.Name = "AllCheckbox";
            this.AllCheckbox.Size = new System.Drawing.Size(122, 40);
            this.AllCheckbox.TabIndex = 4;
            this.AllCheckbox.Text = "Show all curves?";
            this.AllCheckbox.UseVisualStyleBackColor = true;
            this.AllCheckbox.CheckedChanged += new System.EventHandler(this.ButtonCheckedChanged);
            // 
            // BlackButton
            // 
            this.BlackButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.BlackButton.AutoSize = true;
            this.BlackButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.BlackButton.Location = new System.Drawing.Point(3, 113);
            this.BlackButton.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.BlackButton.Name = "BlackButton";
            this.BlackButton.Size = new System.Drawing.Size(122, 30);
            this.BlackButton.TabIndex = 3;
            this.BlackButton.Text = "BlacK";
            this.BlackButton.UseVisualStyleBackColor = true;
            this.BlackButton.Click += new System.EventHandler(this.ButtonCheckedChanged);
            // 
            // YellowButton
            // 
            this.YellowButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.YellowButton.AutoSize = true;
            this.YellowButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.YellowButton.Location = new System.Drawing.Point(3, 83);
            this.YellowButton.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.YellowButton.Name = "YellowButton";
            this.YellowButton.Size = new System.Drawing.Size(122, 30);
            this.YellowButton.TabIndex = 2;
            this.YellowButton.Text = "Yellow";
            this.YellowButton.UseVisualStyleBackColor = true;
            this.YellowButton.Click += new System.EventHandler(this.ButtonCheckedChanged);
            // 
            // MagentaButton
            // 
            this.MagentaButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.MagentaButton.AutoSize = true;
            this.MagentaButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.MagentaButton.Location = new System.Drawing.Point(3, 53);
            this.MagentaButton.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.MagentaButton.Name = "MagentaButton";
            this.MagentaButton.Size = new System.Drawing.Size(122, 30);
            this.MagentaButton.TabIndex = 1;
            this.MagentaButton.Text = "Magenta";
            this.MagentaButton.UseVisualStyleBackColor = true;
            this.MagentaButton.Click += new System.EventHandler(this.ButtonCheckedChanged);
            // 
            // CyanButton
            // 
            this.CyanButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.CyanButton.AutoSize = true;
            this.CyanButton.Checked = true;
            this.CyanButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CyanButton.Location = new System.Drawing.Point(3, 23);
            this.CyanButton.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.CyanButton.Name = "CyanButton";
            this.CyanButton.Size = new System.Drawing.Size(122, 30);
            this.CyanButton.TabIndex = 0;
            this.CyanButton.TabStop = true;
            this.CyanButton.Text = "Cyan";
            this.CyanButton.UseVisualStyleBackColor = true;
            this.CyanButton.Click += new System.EventHandler(this.ButtonCheckedChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoScroll = true;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.ImageCanvas, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.SeparatedImageCanvas, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(553, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(426, 747);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // ImageCanvas
            // 
            this.ImageCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImageCanvas.Location = new System.Drawing.Point(3, 3);
            this.ImageCanvas.Name = "ImageCanvas";
            this.ImageCanvas.Size = new System.Drawing.Size(420, 367);
            this.ImageCanvas.TabIndex = 0;
            this.ImageCanvas.TabStop = false;
            // 
            // SeparatedImageCanvas
            // 
            this.SeparatedImageCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SeparatedImageCanvas.Location = new System.Drawing.Point(3, 376);
            this.SeparatedImageCanvas.Name = "SeparatedImageCanvas";
            this.SeparatedImageCanvas.Size = new System.Drawing.Size(420, 368);
            this.SeparatedImageCanvas.TabIndex = 1;
            this.SeparatedImageCanvas.TabStop = false;
            // 
            // ChangePicDialog
            // 
            this.ChangePicDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";
            // 
            // SaveCurvesDialog
            // 
            this.SaveCurvesDialog.Filter = "Curve files (*.curve)|*.curve";
            // 
            // LoadCurvesDialog
            // 
            this.LoadCurvesDialog.Filter = "Curve files (*.curve)|*.curve";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(800, 800);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BezierCanvas)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImageCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeparatedImageCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox BezierCanvas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox ImageCanvas;
        private System.Windows.Forms.PictureBox SeparatedImageCanvas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox AllCheckbox;
        private System.Windows.Forms.RadioButton BlackButton;
        private System.Windows.Forms.RadioButton YellowButton;
        private System.Windows.Forms.RadioButton MagentaButton;
        private System.Windows.Forms.RadioButton CyanButton;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button HundredButton;
        private System.Windows.Forms.Button UCRButton;
        private System.Windows.Forms.Button GCRButton;
        private System.Windows.Forms.Button SavePicButton;
        private System.Windows.Forms.Button ChangePictureButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button BWButton;
        private System.Windows.Forms.Button ShowAllButton;
        private System.Windows.Forms.OpenFileDialog ChangePicDialog;
        private System.Windows.Forms.SaveFileDialog SaveCurvesDialog;
        private System.Windows.Forms.OpenFileDialog LoadCurvesDialog;
    }
}

