﻿namespace LibraryManagement.Forms
{
    partial class ConfirmRecvBook
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmRecvBook));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtgvChosenBook = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlCode = new System.Windows.Forms.Panel();
            this.lbReaderCode = new System.Windows.Forms.Label();
            this.lbReaderName = new System.Windows.Forms.Label();
            this.pnlName = new System.Windows.Forms.Panel();
            this.lbReturnDate = new System.Windows.Forms.Label();
            this.pnlReturnDate = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.lbSlipCode = new System.Windows.Forms.Label();
            this.pnlSlipCode = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btnCancel = new LibraryManagement.nButton();
            this.btnAccept = new LibraryManagement.nButton();
            this.lbFineThisPeriod = new System.Windows.Forms.Label();
            this.pnlFineThisPeriod = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.lbTotalFine = new System.Windows.Forms.Label();
            this.pnlTotalFine = new System.Windows.Forms.Panel();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChosenBook)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(84)))), ((int)(((byte)(131)))));
            this.pnlTop.Controls.Add(this.btnMinimize);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(800, 25);
            this.pnlTop.TabIndex = 1;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(84)))), ((int)(((byte)(131)))));
            this.btnMinimize.BackgroundImage = global::LibraryManagement.Properties.Resources.minimize_btn;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimize.Location = new System.Drawing.Point(1357, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(24, 20);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(84)))), ((int)(((byte)(131)))));
            this.btnClose.BackgroundImage = global::LibraryManagement.Properties.Resources.close_btn;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1387, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 20);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(40, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã độc giả:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(32, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tên độc giả:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(345, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ngày trả:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(574, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tiền phạt kỳ này:";
            // 
            // dtgvChosenBook
            // 
            this.dtgvChosenBook.AllowUserToAddRows = false;
            this.dtgvChosenBook.AllowUserToResizeRows = false;
            this.dtgvChosenBook.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvChosenBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvChosenBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChosenBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.Column1});
            this.dtgvChosenBook.EnableHeadersVisualStyles = false;
            this.dtgvChosenBook.Location = new System.Drawing.Point(12, 274);
            this.dtgvChosenBook.MultiSelect = false;
            this.dtgvChosenBook.Name = "dtgvChosenBook";
            this.dtgvChosenBook.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvChosenBook.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvChosenBook.RowHeadersVisible = false;
            this.dtgvChosenBook.RowHeadersWidth = 40;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgvChosenBook.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvChosenBook.RowTemplate.Height = 26;
            this.dtgvChosenBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvChosenBook.Size = new System.Drawing.Size(776, 245);
            this.dtgvChosenBook.TabIndex = 27;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "stt";
            this.dataGridViewTextBoxColumn6.HeaderText = "STT";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 50;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "bookCode";
            this.dataGridViewTextBoxColumn7.HeaderText = "Mã sách";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 120;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "bookName";
            this.dataGridViewTextBoxColumn8.HeaderText = "Tên sách";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 200;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "borrowDate";
            this.dataGridViewTextBoxColumn9.HeaderText = "Ngày mượn";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 122;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "borrowedDays";
            this.dataGridViewTextBoxColumn10.HeaderText = "Số ngày mượn";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 140;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "fine";
            this.Column1.HeaderText = "Tiền phạt";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 140;
            // 
            // pnlCode
            // 
            this.pnlCode.BackColor = System.Drawing.Color.Black;
            this.pnlCode.Location = new System.Drawing.Point(148, 194);
            this.pnlCode.Name = "pnlCode";
            this.pnlCode.Size = new System.Drawing.Size(60, 1);
            this.pnlCode.TabIndex = 30;
            // 
            // lbReaderCode
            // 
            this.lbReaderCode.AutoSize = true;
            this.lbReaderCode.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReaderCode.Location = new System.Drawing.Point(144, 170);
            this.lbReaderCode.Name = "lbReaderCode";
            this.lbReaderCode.Size = new System.Drawing.Size(66, 23);
            this.lbReaderCode.TabIndex = 31;
            this.lbReaderCode.Text = "DG012";
            // 
            // lbReaderName
            // 
            this.lbReaderName.AutoSize = true;
            this.lbReaderName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReaderName.Location = new System.Drawing.Point(144, 222);
            this.lbReaderName.Name = "lbReaderName";
            this.lbReaderName.Size = new System.Drawing.Size(190, 23);
            this.lbReaderName.TabIndex = 33;
            this.lbReaderName.Text = "Nguyễn Thành Meow";
            // 
            // pnlName
            // 
            this.pnlName.BackColor = System.Drawing.Color.Black;
            this.pnlName.Location = new System.Drawing.Point(148, 246);
            this.pnlName.Name = "pnlName";
            this.pnlName.Size = new System.Drawing.Size(180, 1);
            this.pnlName.TabIndex = 32;
            // 
            // lbReturnDate
            // 
            this.lbReturnDate.AutoSize = true;
            this.lbReturnDate.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReturnDate.Location = new System.Drawing.Point(423, 171);
            this.lbReturnDate.Name = "lbReturnDate";
            this.lbReturnDate.Size = new System.Drawing.Size(104, 23);
            this.lbReturnDate.TabIndex = 36;
            this.lbReturnDate.Text = "12/12/2022";
            // 
            // pnlReturnDate
            // 
            this.pnlReturnDate.BackColor = System.Drawing.Color.Black;
            this.pnlReturnDate.Location = new System.Drawing.Point(427, 195);
            this.pnlReturnDate.Name = "pnlReturnDate";
            this.pnlReturnDate.Size = new System.Drawing.Size(96, 1);
            this.pnlReturnDate.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(212, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(374, 41);
            this.label9.TabIndex = 41;
            this.label9.Text = "Thông Tin Phiếu Trả Sách";
            // 
            // lbSlipCode
            // 
            this.lbSlipCode.AutoSize = true;
            this.lbSlipCode.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSlipCode.Location = new System.Drawing.Point(144, 119);
            this.lbSlipCode.Name = "lbSlipCode";
            this.lbSlipCode.Size = new System.Drawing.Size(87, 23);
            this.lbSlipCode.TabIndex = 45;
            this.lbSlipCode.Text = "MPTS010";
            // 
            // pnlSlipCode
            // 
            this.pnlSlipCode.BackColor = System.Drawing.Color.Black;
            this.pnlSlipCode.Location = new System.Drawing.Point(148, 143);
            this.pnlSlipCode.Name = "pnlSlipCode";
            this.pnlSlipCode.Size = new System.Drawing.Size(84, 1);
            this.pnlSlipCode.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(30, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 24);
            this.label7.TabIndex = 43;
            this.label7.Text = "Mã phiếu trả:";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancel.BackgroundColor = System.Drawing.Color.LightCoral;
            this.btnCancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancel.BorderRadius = 20;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(406, 535);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 40);
            this.btnCancel.TabIndex = 42;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAccept.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAccept.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAccept.BorderRadius = 20;
            this.btnAccept.BorderSize = 0;
            this.btnAccept.FlatAppearance.BorderSize = 0;
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.ForeColor = System.Drawing.Color.White;
            this.btnAccept.Location = new System.Drawing.Point(272, 535);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(120, 40);
            this.btnAccept.TabIndex = 28;
            this.btnAccept.Text = "Xác Nhận";
            this.btnAccept.TextColor = System.Drawing.Color.White;
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // lbFineThisPeriod
            // 
            this.lbFineThisPeriod.AutoSize = true;
            this.lbFineThisPeriod.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFineThisPeriod.Location = new System.Drawing.Point(722, 170);
            this.lbFineThisPeriod.Name = "lbFineThisPeriod";
            this.lbFineThisPeriod.Size = new System.Drawing.Size(20, 23);
            this.lbFineThisPeriod.TabIndex = 51;
            this.lbFineThisPeriod.Text = "5";
            // 
            // pnlFineThisPeriod
            // 
            this.pnlFineThisPeriod.BackColor = System.Drawing.Color.Black;
            this.pnlFineThisPeriod.Location = new System.Drawing.Point(726, 194);
            this.pnlFineThisPeriod.Name = "pnlFineThisPeriod";
            this.pnlFineThisPeriod.Size = new System.Drawing.Size(12, 1);
            this.pnlFineThisPeriod.TabIndex = 50;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Navy;
            this.label11.Location = new System.Drawing.Point(639, 222);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 24);
            this.label11.TabIndex = 49;
            this.label11.Text = "Tổng nợ:";
            // 
            // lbTotalFine
            // 
            this.lbTotalFine.AutoSize = true;
            this.lbTotalFine.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalFine.Location = new System.Drawing.Point(722, 221);
            this.lbTotalFine.Name = "lbTotalFine";
            this.lbTotalFine.Size = new System.Drawing.Size(20, 23);
            this.lbTotalFine.TabIndex = 53;
            this.lbTotalFine.Text = "5";
            // 
            // pnlTotalFine
            // 
            this.pnlTotalFine.BackColor = System.Drawing.Color.Black;
            this.pnlTotalFine.Location = new System.Drawing.Point(726, 245);
            this.pnlTotalFine.Name = "pnlTotalFine";
            this.pnlTotalFine.Size = new System.Drawing.Size(12, 1);
            this.pnlTotalFine.TabIndex = 52;
            // 
            // ConfirmRecvBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 606);
            this.Controls.Add(this.lbTotalFine);
            this.Controls.Add(this.pnlTotalFine);
            this.Controls.Add(this.lbFineThisPeriod);
            this.Controls.Add(this.pnlFineThisPeriod);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbSlipCode);
            this.Controls.Add(this.pnlSlipCode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbReturnDate);
            this.Controls.Add(this.pnlReturnDate);
            this.Controls.Add(this.lbReaderName);
            this.Controls.Add(this.pnlName);
            this.Controls.Add(this.lbReaderCode);
            this.Controls.Add(this.pnlCode);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.dtgvChosenBook);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlTop);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfirmRecvBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ConfirmLendBook";
            this.Load += new System.EventHandler(this.ConfirmLendBook_Load);
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChosenBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtgvChosenBook;
        private nButton btnAccept;
        private System.Windows.Forms.Panel pnlCode;
        private System.Windows.Forms.Label lbReaderCode;
        private System.Windows.Forms.Label lbReaderName;
        private System.Windows.Forms.Panel pnlName;
        private System.Windows.Forms.Label lbReturnDate;
        private System.Windows.Forms.Panel pnlReturnDate;
        private System.Windows.Forms.Label label9;
        private nButton btnCancel;
        private System.Windows.Forms.Label lbSlipCode;
        private System.Windows.Forms.Panel pnlSlipCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label lbFineThisPeriod;
        private System.Windows.Forms.Panel pnlFineThisPeriod;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbTotalFine;
        private System.Windows.Forms.Panel pnlTotalFine;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}