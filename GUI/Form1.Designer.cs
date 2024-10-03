namespace GUI
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtpExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.lbExpiryDate = new System.Windows.Forms.Label();
            this.txbOrigin = new System.Windows.Forms.TextBox();
            this.lbOrigin = new System.Windows.Forms.Label();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.txbQuantity = new System.Windows.Forms.TextBox();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.txbProductName = new System.Windows.Forms.TextBox();
            this.lbProductName = new System.Windows.Forms.Label();
            this.txbProductID = new System.Windows.Forms.TextBox();
            this.lbProductID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EndPrice = new System.Windows.Forms.TextBox();
            this.StartPrice = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnExpiryDate = new System.Windows.Forms.Button();
            this.btnOrigin = new System.Windows.Forms.Button();
            this.btnHighestPrice = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txbFilterOrigin = new System.Windows.Forms.TextBox();
            this.btnDeleteAllDate = new System.Windows.Forms.Button();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.btnCheckDate = new System.Windows.Forms.Button();
            this.btnDeleteOrigin = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.dtpExpiryDate);
            this.panel1.Controls.Add(this.lbExpiryDate);
            this.panel1.Controls.Add(this.txbOrigin);
            this.panel1.Controls.Add(this.lbOrigin);
            this.panel1.Controls.Add(this.txbPrice);
            this.panel1.Controls.Add(this.lbPrice);
            this.panel1.Controls.Add(this.txbQuantity);
            this.panel1.Controls.Add(this.lbQuantity);
            this.panel1.Controls.Add(this.txbProductName);
            this.panel1.Controls.Add(this.lbProductName);
            this.panel1.Controls.Add(this.txbProductID);
            this.panel1.Controls.Add(this.lbProductID);
            this.panel1.Location = new System.Drawing.Point(16, 41);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 391);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            //
            // btnDelete
            //
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(232, 338);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Xoá SP";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            //
            // btnSave
            //
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(59, 338);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Lưu SP";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            //
            // dtpExpiryDate
            //
            this.dtpExpiryDate.Location = new System.Drawing.Point(148, 282);
            this.dtpExpiryDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpExpiryDate.Name = "dtpExpiryDate";
            this.dtpExpiryDate.Size = new System.Drawing.Size(244, 22);
            this.dtpExpiryDate.TabIndex = 12;
            //
            // lbExpiryDate
            //
            this.lbExpiryDate.AutoSize = true;
            this.lbExpiryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExpiryDate.Location = new System.Drawing.Point(19, 282);
            this.lbExpiryDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbExpiryDate.Name = "lbExpiryDate";
            this.lbExpiryDate.Size = new System.Drawing.Size(112, 20);
            this.lbExpiryDate.TabIndex = 11;
            this.lbExpiryDate.Text = "Ngày hết hạn:";
            //
            // txbOrigin
            //
            this.txbOrigin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbOrigin.Location = new System.Drawing.Point(101, 229);
            this.txbOrigin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbOrigin.Name = "txbOrigin";
            this.txbOrigin.Size = new System.Drawing.Size(291, 26);
            this.txbOrigin.TabIndex = 10;
            //
            // lbOrigin
            //
            this.lbOrigin.AutoSize = true;
            this.lbOrigin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrigin.Location = new System.Drawing.Point(19, 233);
            this.lbOrigin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbOrigin.Name = "lbOrigin";
            this.lbOrigin.Size = new System.Drawing.Size(70, 20);
            this.lbOrigin.TabIndex = 9;
            this.lbOrigin.Text = "Xuất xứ:";
            //
            // txbPrice
            //
            this.txbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPrice.Location = new System.Drawing.Point(101, 180);
            this.txbPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(291, 26);
            this.txbPrice.TabIndex = 8;
            //
            // lbPrice
            //
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(19, 183);
            this.lbPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(71, 20);
            this.lbPrice.TabIndex = 7;
            this.lbPrice.Text = "Đơn giá:";
            //
            // txbQuantity
            //
            this.txbQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbQuantity.Location = new System.Drawing.Point(101, 130);
            this.txbQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbQuantity.Name = "txbQuantity";
            this.txbQuantity.Size = new System.Drawing.Size(291, 26);
            this.txbQuantity.TabIndex = 6;
            //
            // lbQuantity
            //
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantity.Location = new System.Drawing.Point(19, 134);
            this.lbQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(79, 20);
            this.lbQuantity.TabIndex = 5;
            this.lbQuantity.Text = "Số lượng:";
            //
            // txbProductName
            //
            this.txbProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProductName.Location = new System.Drawing.Point(101, 80);
            this.txbProductName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbProductName.Name = "txbProductName";
            this.txbProductName.Size = new System.Drawing.Size(291, 26);
            this.txbProductName.TabIndex = 4;
            //
            // lbProductName
            //
            this.lbProductName.AutoSize = true;
            this.lbProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductName.Location = new System.Drawing.Point(19, 84);
            this.lbProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(69, 20);
            this.lbProductName.TabIndex = 3;
            this.lbProductName.Text = "Tên SP:";
            //
            // txbProductID
            //
            this.txbProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProductID.Location = new System.Drawing.Point(101, 31);
            this.txbProductID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbProductID.Name = "txbProductID";
            this.txbProductID.Size = new System.Drawing.Size(291, 26);
            this.txbProductID.TabIndex = 2;
            //
            // lbProductID
            //
            this.lbProductID.AutoSize = true;
            this.lbProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductID.Location = new System.Drawing.Point(19, 34);
            this.lbProductID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbProductID.Name = "lbProductID";
            this.lbProductID.Size = new System.Drawing.Size(64, 20);
            this.lbProductID.TabIndex = 0;
            this.lbProductID.Text = "Mã SP:";
            //
            // panel2
            //
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(109, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 49);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập thông tin sản phẩm:";
            //
            // panel3
            //
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.EndPrice);
            this.panel3.Controls.Add(this.StartPrice);
            this.panel3.Controls.Add(this.btnFilter);
            this.panel3.Controls.Add(this.btnExpiryDate);
            this.panel3.Controls.Add(this.btnOrigin);
            this.panel3.Controls.Add(this.btnHighestPrice);
            this.panel3.Location = new System.Drawing.Point(439, 41);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1284, 391);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            //
            // dataGridView1
            //
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 102);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1240, 265);
            this.dataGridView1.TabIndex = 6;
            //
            // EndPrice
            //
            this.EndPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndPrice.Location = new System.Drawing.Point(1128, 32);
            this.EndPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EndPrice.Name = "EndPrice";
            this.EndPrice.Size = new System.Drawing.Size(81, 30);
            this.EndPrice.TabIndex = 5;
            //
            // StartPrice
            //
            this.StartPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartPrice.Location = new System.Drawing.Point(1000, 32);
            this.StartPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StartPrice.Name = "StartPrice";
            this.StartPrice.Size = new System.Drawing.Size(81, 30);
            this.StartPrice.TabIndex = 4;
            //
            // btnFilter
            //
            this.btnFilter.BackColor = System.Drawing.Color.Cyan;
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.Location = new System.Drawing.Point(843, 18);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(135, 63);
            this.btnFilter.TabIndex = 3;
            this.btnFilter.Text = "Xuất các SP có DG từ [a..b]";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            //
            // btnExpiryDate
            //
            this.btnExpiryDate.BackColor = System.Drawing.Color.Cyan;
            this.btnExpiryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpiryDate.Location = new System.Drawing.Point(399, 18);
            this.btnExpiryDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExpiryDate.Name = "btnExpiryDate";
            this.btnExpiryDate.Size = new System.Drawing.Size(128, 63);
            this.btnExpiryDate.TabIndex = 2;
            this.btnExpiryDate.Text = "Xuất toàn bộ SP quá hạn";
            this.btnExpiryDate.UseVisualStyleBackColor = false;
            this.btnExpiryDate.Click += new System.EventHandler(this.btnExpiryDate_Click);
            //
            // btnOrigin
            //
            this.btnOrigin.BackColor = System.Drawing.Color.Cyan;
            this.btnOrigin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrigin.Location = new System.Drawing.Point(220, 18);
            this.btnOrigin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOrigin.Name = "btnOrigin";
            this.btnOrigin.Size = new System.Drawing.Size(128, 63);
            this.btnOrigin.TabIndex = 1;
            this.btnOrigin.Text = "1 SP từ Nhật Bản";
            this.btnOrigin.UseVisualStyleBackColor = false;
            this.btnOrigin.Click += new System.EventHandler(this.btnOrigin_Click);
            //
            // btnHighestPrice
            //
            this.btnHighestPrice.BackColor = System.Drawing.Color.Cyan;
            this.btnHighestPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHighestPrice.Location = new System.Drawing.Point(44, 18);
            this.btnHighestPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHighestPrice.Name = "btnHighestPrice";
            this.btnHighestPrice.Size = new System.Drawing.Size(128, 63);
            this.btnHighestPrice.TabIndex = 0;
            this.btnHighestPrice.Text = "1 SP có DG cao nhất";
            this.btnHighestPrice.UseVisualStyleBackColor = false;
            this.btnHighestPrice.Click += new System.EventHandler(this.btnHighestPrice_Click);
            //
            // panel4
            //
            this.panel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(995, 15);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(243, 49);
            this.panel4.TabIndex = 3;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chọn chức năng tìm kiếm";
            //
            // panel5
            //
            this.panel5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.dataGridView2);
            this.panel5.Location = new System.Drawing.Point(16, 458);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1707, 334);
            this.panel5.TabIndex = 4;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            //
            // panel8
            //
            this.panel8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel8.Controls.Add(this.label4);
            this.panel8.Location = new System.Drawing.Point(1423, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(149, 49);
            this.panel8.TabIndex = 5;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            //
            // label4
            //
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Chọn thao tác";
            //
            // panel7
            //
            this.panel7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel7.Controls.Add(this.txbFilterOrigin);
            this.panel7.Controls.Add(this.btnDeleteAllDate);
            this.panel7.Controls.Add(this.btnDeleteAll);
            this.panel7.Controls.Add(this.btnCheckDate);
            this.panel7.Controls.Add(this.btnDeleteOrigin);
            this.panel7.Location = new System.Drawing.Point(1299, 16);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(385, 314);
            this.panel7.TabIndex = 1;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            //
            // txbFilterOrigin
            //
            this.txbFilterOrigin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFilterOrigin.Location = new System.Drawing.Point(152, 58);
            this.txbFilterOrigin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbFilterOrigin.Name = "txbFilterOrigin";
            this.txbFilterOrigin.Size = new System.Drawing.Size(212, 26);
            this.txbFilterOrigin.TabIndex = 7;
            //
            // btnDeleteAllDate
            //
            this.btnDeleteAllDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAllDate.Location = new System.Drawing.Point(199, 210);
            this.btnDeleteAllDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteAllDate.Name = "btnDeleteAllDate";
            this.btnDeleteAllDate.Size = new System.Drawing.Size(167, 59);
            this.btnDeleteAllDate.TabIndex = 6;
            this.btnDeleteAllDate.Text = "Xoá toàn bộ SP quá hạn";
            this.btnDeleteAllDate.UseVisualStyleBackColor = true;
            this.btnDeleteAllDate.Click += new System.EventHandler(this.btnDeleteAllDate_Click);
            //
            // btnDeleteAll
            //
            this.btnDeleteAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAll.Location = new System.Drawing.Point(19, 210);
            this.btnDeleteAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(167, 59);
            this.btnDeleteAll.TabIndex = 5;
            this.btnDeleteAll.Text = "Xoá toàn bộ SP trong kho";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            //
            // btnCheckDate
            //
            this.btnCheckDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckDate.Location = new System.Drawing.Point(19, 123);
            this.btnCheckDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCheckDate.Name = "btnCheckDate";
            this.btnCheckDate.Size = new System.Drawing.Size(347, 57);
            this.btnCheckDate.TabIndex = 4;
            this.btnCheckDate.Text = "Kiểm tra trong kho có SP quá hạn hay không";
            this.btnCheckDate.UseVisualStyleBackColor = true;
            this.btnCheckDate.Click += new System.EventHandler(this.btnCheckDate_Click);
            //
            // btnDeleteOrigin
            //
            this.btnDeleteOrigin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteOrigin.Location = new System.Drawing.Point(19, 41);
            this.btnDeleteOrigin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteOrigin.Name = "btnDeleteOrigin";
            this.btnDeleteOrigin.Size = new System.Drawing.Size(125, 62);
            this.btnDeleteOrigin.TabIndex = 3;
            this.btnDeleteOrigin.Text = "Xoá SP theo xuất xứ bất kì";
            this.btnDeleteOrigin.UseVisualStyleBackColor = true;
            this.btnDeleteOrigin.Click += new System.EventHandler(this.btnDeleteOrigin_Click);
            //
            // dataGridView2
            //
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(5, 39);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1285, 290);
            this.dataGridView2.TabIndex = 0;
            //
            // panel6
            //
            this.panel6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(20, 439);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(328, 49);
            this.panel6.TabIndex = 4;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Danh sách sản phẩm sau khi nhập";
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1739, 806);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "LINQ to Object - Quản lý sản phảm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbProductID;
        private System.Windows.Forms.TextBox txbProductID;
        private System.Windows.Forms.TextBox txbProductName;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.TextBox txbPrice;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.TextBox txbQuantity;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Label lbExpiryDate;
        private System.Windows.Forms.TextBox txbOrigin;
        private System.Windows.Forms.Label lbOrigin;
        private System.Windows.Forms.DateTimePicker dtpExpiryDate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHighestPrice;
        private System.Windows.Forms.Button btnOrigin;
        private System.Windows.Forms.Button btnExpiryDate;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TextBox StartPrice;
        private System.Windows.Forms.TextBox EndPrice;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDeleteOrigin;
        private System.Windows.Forms.Button btnCheckDate;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Button btnDeleteAllDate;
        private System.Windows.Forms.TextBox txbFilterOrigin;
    }
}

