namespace project
{
    partial class shop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(shop));
            this.listView1 = new System.Windows.Forms.ListView();
            this.cck = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productName1 = new System.Windows.Forms.Label();
            this.priceName1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.p_name1 = new System.Windows.Forms.Label();
            this.p_price1 = new System.Windows.Forms.Label();
            this.numName1 = new System.Windows.Forms.Label();
            this.p_number1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.p_name2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.p_price2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.p_number2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.p_name3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.p_price3 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.p_number3 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.p_name4 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.p_price4 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.p_number4 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.customer = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.p_image4 = new System.Windows.Forms.PictureBox();
            this.p_image3 = new System.Windows.Forms.PictureBox();
            this.p_image2 = new System.Windows.Forms.PictureBox();
            this.p_image1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_image4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_image3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_image2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_image1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cck,
            this.columnHeader1,
            this.columnHeader2,
            this.price});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(879, 76);
            this.listView1.Name = "listView1";
            this.listView1.OwnerDraw = true;
            this.listView1.Size = new System.Drawing.Size(271, 388);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.ListView1_DrawColumnHeader);
            this.listView1.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.listView1_DrawItem);
            this.listView1.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.listView1_DrawSubItem);
            // 
            // cck
            // 
            this.cck.Text = "";
            this.cck.Width = 23;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "제품명";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 61;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "수량";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 73;
            // 
            // price
            // 
            this.price.Text = "가격";
            this.price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.price.Width = 89;
            // 
            // productName1
            // 
            this.productName1.AutoSize = true;
            this.productName1.BackColor = System.Drawing.Color.Transparent;
            this.productName1.Font = new System.Drawing.Font("D2Coding", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.productName1.Location = new System.Drawing.Point(85, 292);
            this.productName1.Name = "productName1";
            this.productName1.Size = new System.Drawing.Size(46, 22);
            this.productName1.TabIndex = 2;
            this.productName1.Text = "제품";
            // 
            // priceName1
            // 
            this.priceName1.AutoSize = true;
            this.priceName1.BackColor = System.Drawing.Color.Transparent;
            this.priceName1.Font = new System.Drawing.Font("D2Coding", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.priceName1.Location = new System.Drawing.Point(85, 321);
            this.priceName1.Name = "priceName1";
            this.priceName1.Size = new System.Drawing.Size(46, 22);
            this.priceName1.TabIndex = 3;
            this.priceName1.Text = "가격";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("D2Coding", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(82, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "찜하기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // p_name1
            // 
            this.p_name1.AutoSize = true;
            this.p_name1.BackColor = System.Drawing.Color.Transparent;
            this.p_name1.Font = new System.Drawing.Font("D2Coding", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.p_name1.Location = new System.Drawing.Point(137, 292);
            this.p_name1.Name = "p_name1";
            this.p_name1.Size = new System.Drawing.Size(64, 22);
            this.p_name1.TabIndex = 2;
            this.p_name1.Text = "label1";
            // 
            // p_price1
            // 
            this.p_price1.AutoSize = true;
            this.p_price1.BackColor = System.Drawing.Color.Transparent;
            this.p_price1.Font = new System.Drawing.Font("D2Coding", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.p_price1.Location = new System.Drawing.Point(137, 321);
            this.p_price1.Name = "p_price1";
            this.p_price1.Size = new System.Drawing.Size(64, 22);
            this.p_price1.TabIndex = 3;
            this.p_price1.Text = "label2";
            // 
            // numName1
            // 
            this.numName1.AutoSize = true;
            this.numName1.BackColor = System.Drawing.Color.Transparent;
            this.numName1.Font = new System.Drawing.Font("D2Coding", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.numName1.Location = new System.Drawing.Point(85, 349);
            this.numName1.Name = "numName1";
            this.numName1.Size = new System.Drawing.Size(46, 22);
            this.numName1.TabIndex = 5;
            this.numName1.Text = "수량";
            // 
            // p_number1
            // 
            this.p_number1.AutoSize = true;
            this.p_number1.BackColor = System.Drawing.Color.Transparent;
            this.p_number1.Font = new System.Drawing.Font("D2Coding", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.p_number1.Location = new System.Drawing.Point(147, 349);
            this.p_number1.Name = "p_number1";
            this.p_number1.Size = new System.Drawing.Size(64, 22);
            this.p_number1.TabIndex = 5;
            this.p_number1.Text = "label3";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(141, 374);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(22, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(169, 374);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(22, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("D2Coding", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(292, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "제품";
            // 
            // p_name2
            // 
            this.p_name2.AutoSize = true;
            this.p_name2.BackColor = System.Drawing.Color.Transparent;
            this.p_name2.Font = new System.Drawing.Font("D2Coding", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.p_name2.Location = new System.Drawing.Point(344, 292);
            this.p_name2.Name = "p_name2";
            this.p_name2.Size = new System.Drawing.Size(64, 22);
            this.p_name2.TabIndex = 2;
            this.p_name2.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("D2Coding", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(292, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "가격";
            // 
            // p_price2
            // 
            this.p_price2.AutoSize = true;
            this.p_price2.BackColor = System.Drawing.Color.Transparent;
            this.p_price2.Font = new System.Drawing.Font("D2Coding", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.p_price2.Location = new System.Drawing.Point(344, 321);
            this.p_price2.Name = "p_price2";
            this.p_price2.Size = new System.Drawing.Size(64, 22);
            this.p_price2.TabIndex = 3;
            this.p_price2.Text = "label2";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("D2Coding", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button4.Location = new System.Drawing.Point(289, 414);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 38);
            this.button4.TabIndex = 4;
            this.button4.Text = "찜하기";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("D2Coding", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(292, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "수량";
            // 
            // p_number2
            // 
            this.p_number2.AutoSize = true;
            this.p_number2.BackColor = System.Drawing.Color.Transparent;
            this.p_number2.Font = new System.Drawing.Font("D2Coding", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.p_number2.Location = new System.Drawing.Point(354, 349);
            this.p_number2.Name = "p_number2";
            this.p_number2.Size = new System.Drawing.Size(64, 22);
            this.p_number2.TabIndex = 5;
            this.p_number2.Text = "label3";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(348, 374);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(22, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "<";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(376, 374);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(22, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = ">";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("D2Coding", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(497, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 22);
            this.label7.TabIndex = 2;
            this.label7.Text = "제품";
            // 
            // p_name3
            // 
            this.p_name3.AutoSize = true;
            this.p_name3.BackColor = System.Drawing.Color.Transparent;
            this.p_name3.Font = new System.Drawing.Font("D2Coding", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.p_name3.Location = new System.Drawing.Point(549, 292);
            this.p_name3.Name = "p_name3";
            this.p_name3.Size = new System.Drawing.Size(64, 22);
            this.p_name3.TabIndex = 2;
            this.p_name3.Text = "label1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("D2Coding", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(497, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 22);
            this.label9.TabIndex = 3;
            this.label9.Text = "가격";
            // 
            // p_price3
            // 
            this.p_price3.AutoSize = true;
            this.p_price3.BackColor = System.Drawing.Color.Transparent;
            this.p_price3.Font = new System.Drawing.Font("D2Coding", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.p_price3.Location = new System.Drawing.Point(549, 321);
            this.p_price3.Name = "p_price3";
            this.p_price3.Size = new System.Drawing.Size(64, 22);
            this.p_price3.TabIndex = 3;
            this.p_price3.Text = "label2";
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("D2Coding", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button7.Location = new System.Drawing.Point(494, 414);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(129, 38);
            this.button7.TabIndex = 4;
            this.button7.Text = "찜하기";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("D2Coding", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(497, 349);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 22);
            this.label11.TabIndex = 5;
            this.label11.Text = "수량";
            // 
            // p_number3
            // 
            this.p_number3.AutoSize = true;
            this.p_number3.BackColor = System.Drawing.Color.Transparent;
            this.p_number3.Font = new System.Drawing.Font("D2Coding", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.p_number3.Location = new System.Drawing.Point(559, 349);
            this.p_number3.Name = "p_number3";
            this.p_number3.Size = new System.Drawing.Size(64, 22);
            this.p_number3.TabIndex = 5;
            this.p_number3.Text = "label3";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(553, 374);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(22, 23);
            this.button8.TabIndex = 6;
            this.button8.Text = "<";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(581, 374);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(22, 23);
            this.button9.TabIndex = 6;
            this.button9.Text = ">";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("D2Coding", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(704, 292);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 22);
            this.label13.TabIndex = 2;
            this.label13.Text = "제품";
            // 
            // p_name4
            // 
            this.p_name4.AutoSize = true;
            this.p_name4.BackColor = System.Drawing.Color.Transparent;
            this.p_name4.Font = new System.Drawing.Font("D2Coding", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.p_name4.Location = new System.Drawing.Point(756, 292);
            this.p_name4.Name = "p_name4";
            this.p_name4.Size = new System.Drawing.Size(64, 22);
            this.p_name4.TabIndex = 2;
            this.p_name4.Text = "label1";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("D2Coding", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.Location = new System.Drawing.Point(704, 321);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 22);
            this.label15.TabIndex = 3;
            this.label15.Text = "가격";
            // 
            // p_price4
            // 
            this.p_price4.AutoSize = true;
            this.p_price4.BackColor = System.Drawing.Color.Transparent;
            this.p_price4.Font = new System.Drawing.Font("D2Coding", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.p_price4.Location = new System.Drawing.Point(756, 321);
            this.p_price4.Name = "p_price4";
            this.p_price4.Size = new System.Drawing.Size(64, 22);
            this.p_price4.TabIndex = 3;
            this.p_price4.Text = "label2";
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("D2Coding", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button10.Location = new System.Drawing.Point(701, 414);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(129, 38);
            this.button10.TabIndex = 4;
            this.button10.Text = "찜하기";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("D2Coding", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.Location = new System.Drawing.Point(704, 349);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 22);
            this.label17.TabIndex = 5;
            this.label17.Text = "수량";
            // 
            // p_number4
            // 
            this.p_number4.AutoSize = true;
            this.p_number4.BackColor = System.Drawing.Color.Transparent;
            this.p_number4.Font = new System.Drawing.Font("D2Coding", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.p_number4.Location = new System.Drawing.Point(766, 349);
            this.p_number4.Name = "p_number4";
            this.p_number4.Size = new System.Drawing.Size(64, 22);
            this.p_number4.TabIndex = 5;
            this.p_number4.Text = "label3";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(760, 374);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(22, 23);
            this.button11.TabIndex = 6;
            this.button11.Text = "<";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(788, 374);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(22, 23);
            this.button12.TabIndex = 6;
            this.button12.Text = ">";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("D2Coding", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(76, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(384, 74);
            this.label2.TabIndex = 7;
            this.label2.Text = "오늘의 핫딜";
            // 
            // customer
            // 
            this.customer.AutoSize = true;
            this.customer.BackColor = System.Drawing.Color.Transparent;
            this.customer.Font = new System.Drawing.Font("D2Coding", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.customer.Location = new System.Drawing.Point(873, 25);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(105, 33);
            this.customer.TabIndex = 8;
            this.customer.Text = "label4";
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("D2Coding", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button13.Location = new System.Drawing.Point(879, 519);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(119, 48);
            this.button13.TabIndex = 9;
            this.button13.Text = "삭제하기";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("D2Coding", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button14.Location = new System.Drawing.Point(1015, 519);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(115, 48);
            this.button14.TabIndex = 10;
            this.button14.Text = "구매하기";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("D2Coding", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(886, 476);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 28);
            this.label4.TabIndex = 11;
            this.label4.Text = "총가격";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("D2Coding", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(1009, 476);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 28);
            this.label6.TabIndex = 11;
            this.label6.Text = "label4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("D2Coding", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(1110, 476);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 28);
            this.label8.TabIndex = 13;
            this.label8.Text = "원";
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(375, 532);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 23);
            this.button15.TabIndex = 15;
            this.button15.Text = "<";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(456, 532);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 23);
            this.button16.TabIndex = 15;
            this.button16.Text = ">";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("D2Coding", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button17.Location = new System.Drawing.Point(1039, 23);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(91, 35);
            this.button17.TabIndex = 16;
            this.button17.Text = "구매내역";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 48);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // p_image4
            // 
            this.p_image4.Location = new System.Drawing.Point(701, 132);
            this.p_image4.Name = "p_image4";
            this.p_image4.Size = new System.Drawing.Size(129, 143);
            this.p_image4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p_image4.TabIndex = 1;
            this.p_image4.TabStop = false;
            // 
            // p_image3
            // 
            this.p_image3.Location = new System.Drawing.Point(494, 132);
            this.p_image3.Name = "p_image3";
            this.p_image3.Size = new System.Drawing.Size(129, 143);
            this.p_image3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p_image3.TabIndex = 1;
            this.p_image3.TabStop = false;
            // 
            // p_image2
            // 
            this.p_image2.Location = new System.Drawing.Point(289, 132);
            this.p_image2.Name = "p_image2";
            this.p_image2.Size = new System.Drawing.Size(129, 143);
            this.p_image2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p_image2.TabIndex = 1;
            this.p_image2.TabStop = false;
            // 
            // p_image1
            // 
            this.p_image1.BackColor = System.Drawing.Color.Transparent;
            this.p_image1.Location = new System.Drawing.Point(82, 132);
            this.p_image1.Name = "p_image1";
            this.p_image1.Size = new System.Drawing.Size(129, 143);
            this.p_image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p_image1.TabIndex = 1;
            this.p_image1.TabStop = false;
            // 
            // shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1180, 627);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.customer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.p_number4);
            this.Controls.Add(this.p_number3);
            this.Controls.Add(this.p_number2);
            this.Controls.Add(this.p_number1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numName1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.p_price4);
            this.Controls.Add(this.p_price3);
            this.Controls.Add(this.p_price2);
            this.Controls.Add(this.p_price1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.priceName1);
            this.Controls.Add(this.p_name4);
            this.Controls.Add(this.p_name3);
            this.Controls.Add(this.p_name2);
            this.Controls.Add(this.p_name1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productName1);
            this.Controls.Add(this.p_image4);
            this.Controls.Add(this.p_image3);
            this.Controls.Add(this.p_image2);
            this.Controls.Add(this.p_image1);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "shop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ㅕ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_image4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_image3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_image2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_image1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader cck;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.PictureBox p_image1;
        private System.Windows.Forms.Label productName1;
        private System.Windows.Forms.Label priceName1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label p_name1;
        private System.Windows.Forms.Label p_price1;
        private System.Windows.Forms.Label numName1;
        private System.Windows.Forms.Label p_number1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox p_image2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label p_name2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label p_price2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label p_number2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox p_image3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label p_name3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label p_price3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label p_number3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.PictureBox p_image4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label p_name4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label p_price4;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label p_number4;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label customer;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
    }
}