﻿namespace TraCuuSach
{
    partial class FormCTPT
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.pnlBookId = new System.Windows.Forms.Panel();
            this.pnlBorrowDays = new System.Windows.Forms.Panel();
            this.pnlBookName = new System.Windows.Forms.Panel();
            this.pnlSlipId = new System.Windows.Forms.Panel();
            this.lbBorrowDays = new System.Windows.Forms.Label();
            this.lbBookName = new System.Windows.Forms.Label();
            this.lbBookId = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbSlipId = new System.Windows.Forms.Label();
            this.pnlDetailId = new System.Windows.Forms.Panel();
            this.lbDetailId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbFine = new System.Windows.Forms.Label();
            this.pnlFine = new System.Windows.Forms.Panel();
            this.btnExit = new TraCuuSach.But();
            this.btnCancel = new TraCuuSach.But();
            this.btnDelete = new TraCuuSach.But();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(84)))), ((int)(((byte)(131)))));
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1500, 58);
            this.pnlTop.TabIndex = 4;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            // 
            // dtgv
            // 
            this.dtgv.AllowUserToAddRows = false;
            this.dtgv.AllowUserToResizeRows = false;
            this.dtgv.BackgroundColor = System.Drawing.Color.White;
            this.dtgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(84)))), ((int)(((byte)(131)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(84)))), ((int)(((byte)(131)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.readerName,
            this.bookName,
            this.dataGridViewTextBoxColumn9,
            this.fine});
            this.dtgv.EnableHeadersVisualStyles = false;
            this.dtgv.Location = new System.Drawing.Point(60, 420);
            this.dtgv.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.dtgv.MultiSelect = false;
            this.dtgv.Name = "dtgv";
            this.dtgv.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgv.RowHeadersVisible = false;
            this.dtgv.RowHeadersWidth = 40;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgv.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgv.RowTemplate.Height = 26;
            this.dtgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv.Size = new System.Drawing.Size(1380, 415);
            this.dtgv.TabIndex = 104;
            this.dtgv.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgv_CellMouseDown);
            // 
            // pnlBookId
            // 
            this.pnlBookId.BackColor = System.Drawing.Color.Black;
            this.pnlBookId.Location = new System.Drawing.Point(717, 223);
            this.pnlBookId.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.pnlBookId.Name = "pnlBookId";
            this.pnlBookId.Size = new System.Drawing.Size(0, 2);
            this.pnlBookId.TabIndex = 101;
            // 
            // pnlBorrowDays
            // 
            this.pnlBorrowDays.BackColor = System.Drawing.Color.Black;
            this.pnlBorrowDays.Location = new System.Drawing.Point(1341, 223);
            this.pnlBorrowDays.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.pnlBorrowDays.Name = "pnlBorrowDays";
            this.pnlBorrowDays.Size = new System.Drawing.Size(0, 2);
            this.pnlBorrowDays.TabIndex = 100;
            // 
            // pnlBookName
            // 
            this.pnlBookName.BackColor = System.Drawing.Color.Black;
            this.pnlBookName.Location = new System.Drawing.Point(717, 309);
            this.pnlBookName.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.pnlBookName.Name = "pnlBookName";
            this.pnlBookName.Size = new System.Drawing.Size(0, 2);
            this.pnlBookName.TabIndex = 99;
            // 
            // pnlSlipId
            // 
            this.pnlSlipId.BackColor = System.Drawing.Color.Black;
            this.pnlSlipId.Location = new System.Drawing.Point(252, 223);
            this.pnlSlipId.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.pnlSlipId.Name = "pnlSlipId";
            this.pnlSlipId.Size = new System.Drawing.Size(0, 2);
            this.pnlSlipId.TabIndex = 98;
            // 
            // lbBorrowDays
            // 
            this.lbBorrowDays.AutoSize = true;
            this.lbBorrowDays.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBorrowDays.Location = new System.Drawing.Point(1338, 185);
            this.lbBorrowDays.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbBorrowDays.Name = "lbBorrowDays";
            this.lbBorrowDays.Size = new System.Drawing.Size(0, 35);
            this.lbBorrowDays.TabIndex = 97;
            // 
            // lbBookName
            // 
            this.lbBookName.AutoSize = true;
            this.lbBookName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookName.Location = new System.Drawing.Point(714, 274);
            this.lbBookName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbBookName.Name = "lbBookName";
            this.lbBookName.Size = new System.Drawing.Size(0, 35);
            this.lbBookName.TabIndex = 96;
            // 
            // lbBookId
            // 
            this.lbBookId.AutoSize = true;
            this.lbBookId.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookId.Location = new System.Drawing.Point(714, 185);
            this.lbBookId.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbBookId.Name = "lbBookId";
            this.lbBookId.Size = new System.Drawing.Size(0, 35);
            this.lbBookId.TabIndex = 95;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(1116, 185);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 33);
            this.label6.TabIndex = 94;
            this.label6.Text = "Số ngày mượn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(506, 274);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 33);
            this.label5.TabIndex = 93;
            this.label5.Text = "Tên cuốn sách";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(510, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 33);
            this.label4.TabIndex = 92;
            this.label4.Text = "Mã cuốn sách:";
            // 
            // lbSlipId
            // 
            this.lbSlipId.AutoSize = true;
            this.lbSlipId.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSlipId.Location = new System.Drawing.Point(246, 185);
            this.lbSlipId.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbSlipId.Name = "lbSlipId";
            this.lbSlipId.Size = new System.Drawing.Size(0, 35);
            this.lbSlipId.TabIndex = 91;
            // 
            // pnlDetailId
            // 
            this.pnlDetailId.BackColor = System.Drawing.Color.Black;
            this.pnlDetailId.Location = new System.Drawing.Point(252, 309);
            this.pnlDetailId.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.pnlDetailId.Name = "pnlDetailId";
            this.pnlDetailId.Size = new System.Drawing.Size(0, 2);
            this.pnlDetailId.TabIndex = 87;
            // 
            // lbDetailId
            // 
            this.lbDetailId.AutoSize = true;
            this.lbDetailId.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetailId.Location = new System.Drawing.Point(249, 274);
            this.lbDetailId.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbDetailId.Name = "lbDetailId";
            this.lbDetailId.Size = new System.Drawing.Size(0, 35);
            this.lbDetailId.TabIndex = 90;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(54, 185);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 33);
            this.label2.TabIndex = 89;
            this.label2.Text = "Mã phiếu trả:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(90, 274);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 33);
            this.label3.TabIndex = 88;
            this.label3.Text = "Mã CTPT:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(565, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 61);
            this.label1.TabIndex = 86;
            this.label1.Text = "Chi Tiết Phiếu Trả";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(1182, 274);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 33);
            this.label7.TabIndex = 94;
            this.label7.Text = "Tiền phạt:";
            // 
            // lbFine
            // 
            this.lbFine.AutoSize = true;
            this.lbFine.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFine.Location = new System.Drawing.Point(1338, 274);
            this.lbFine.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbFine.Name = "lbFine";
            this.lbFine.Size = new System.Drawing.Size(0, 35);
            this.lbFine.TabIndex = 97;
            // 
            // pnlFine
            // 
            this.pnlFine.BackColor = System.Drawing.Color.Black;
            this.pnlFine.Location = new System.Drawing.Point(1341, 309);
            this.pnlFine.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.pnlFine.Name = "pnlFine";
            this.pnlFine.Size = new System.Drawing.Size(0, 2);
            this.pnlFine.TabIndex = 100;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.LightCoral;
            this.btnExit.BackgroundColor = System.Drawing.Color.LightCoral;
            this.btnExit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnExit.BorderRadius = 20;
            this.btnExit.BorderSize = 0;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(654, 860);
            this.btnExit.Margin = new System.Windows.Forms.Padding(15);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(192, 72);
            this.btnExit.TabIndex = 105;
            this.btnExit.Text = "Thoát";
            this.btnExit.TextColor = System.Drawing.Color.White;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancel.BackgroundColor = System.Drawing.Color.IndianRed;
            this.btnCancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancel.BorderRadius = 12;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(1260, 335);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(8, 8, 30, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(180, 65);
            this.btnCancel.TabIndex = 102;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.Chocolate;
            this.btnDelete.BackgroundColor = System.Drawing.Color.Chocolate;
            this.btnDelete.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDelete.BorderRadius = 12;
            this.btnDelete.BorderSize = 0;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(1042, 335);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(8, 8, 30, 8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(180, 65);
            this.btnDelete.TabIndex = 103;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.dataGridViewTextBoxColumn7.DataPropertyName = "specSlipCode";
            this.dataGridViewTextBoxColumn7.HeaderText = "Mã chi tiết phiếu trả";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 200;
            // 
            // readerName
            // 
            this.readerName.DataPropertyName = "bookCode";
            this.readerName.HeaderText = "Mã cuốn sách";
            this.readerName.MinimumWidth = 8;
            this.readerName.Name = "readerName";
            this.readerName.ReadOnly = true;
            this.readerName.Width = 140;
            // 
            // bookName
            // 
            this.bookName.HeaderText = "Tên sách";
            this.bookName.MinimumWidth = 8;
            this.bookName.Name = "bookName";
            this.bookName.ReadOnly = true;
            this.bookName.Width = 277;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "borrowDays";
            this.dataGridViewTextBoxColumn9.HeaderText = "Số ngày mượn";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 150;
            // 
            // fine
            // 
            this.fine.HeaderText = "Tiền phạt";
            this.fine.MinimumWidth = 8;
            this.fine.Name = "fine";
            this.fine.ReadOnly = true;
            // 
            // FormCTPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 962);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dtgv);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.pnlBookId);
            this.Controls.Add(this.pnlFine);
            this.Controls.Add(this.pnlBorrowDays);
            this.Controls.Add(this.pnlBookName);
            this.Controls.Add(this.pnlSlipId);
            this.Controls.Add(this.lbFine);
            this.Controls.Add(this.lbBorrowDays);
            this.Controls.Add(this.lbBookName);
            this.Controls.Add(this.lbBookId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbSlipId);
            this.Controls.Add(this.pnlDetailId);
            this.Controls.Add(this.lbDetailId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCTPT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCTPT";
            this.Load += new System.EventHandler(this.FormCTPT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private But btnExit;
        private System.Windows.Forms.DataGridView dtgv;
        private But btnCancel;
        private But btnDelete;
        private System.Windows.Forms.Panel pnlBookId;
        private System.Windows.Forms.Panel pnlBorrowDays;
        private System.Windows.Forms.Panel pnlBookName;
        private System.Windows.Forms.Panel pnlSlipId;
        private System.Windows.Forms.Label lbBorrowDays;
        private System.Windows.Forms.Label lbBookName;
        private System.Windows.Forms.Label lbBookId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbSlipId;
        private System.Windows.Forms.Panel pnlDetailId;
        private System.Windows.Forms.Label lbDetailId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbFine;
        private System.Windows.Forms.Panel pnlFine;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn readerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn fine;
    }
}