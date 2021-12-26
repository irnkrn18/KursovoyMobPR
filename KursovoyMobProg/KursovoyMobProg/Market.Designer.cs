namespace KursovoyMobProg
{
    partial class Market
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Market));
            this.dgvTov = new System.Windows.Forms.DataGridView();
            this.dgvBuyer = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbGruzov = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dgvCl = new System.Windows.Forms.DataGridView();
            this.dgvTCl = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuyer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGruzov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTCl)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTov
            // 
            this.dgvTov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTov.Enabled = false;
            this.dgvTov.Location = new System.Drawing.Point(12, 33);
            this.dgvTov.Name = "dgvTov";
            this.dgvTov.Size = new System.Drawing.Size(283, 323);
            this.dgvTov.TabIndex = 0;
            // 
            // dgvBuyer
            // 
            this.dgvBuyer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuyer.Enabled = false;
            this.dgvBuyer.Location = new System.Drawing.Point(335, 205);
            this.dgvBuyer.Name = "dgvBuyer";
            this.dgvBuyer.Size = new System.Drawing.Size(449, 151);
            this.dgvBuyer.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(335, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(691, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 83);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pbGruzov
            // 
            this.pbGruzov.Image = ((System.Drawing.Image)(resources.GetObject("pbGruzov.Image")));
            this.pbGruzov.Location = new System.Drawing.Point(614, 85);
            this.pbGruzov.Name = "pbGruzov";
            this.pbGruzov.Size = new System.Drawing.Size(83, 50);
            this.pbGruzov.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGruzov.TabIndex = 4;
            this.pbGruzov.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Открыться";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Click_Op);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(386, 141);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Закрыться";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Click_Cl);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(435, 33);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Заказать товары";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Click_Delivery);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Товары";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(331, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Покупатели";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dgvCl
            // 
            this.dgvCl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCl.Enabled = false;
            this.dgvCl.Location = new System.Drawing.Point(825, 42);
            this.dgvCl.Name = "dgvCl";
            this.dgvCl.ReadOnly = true;
            this.dgvCl.Size = new System.Drawing.Size(475, 248);
            this.dgvCl.TabIndex = 10;
            this.dgvCl.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCl_CellContentClick);
            // 
            // dgvTCl
            // 
            this.dgvTCl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTCl.Location = new System.Drawing.Point(825, 351);
            this.dgvTCl.Name = "dgvTCl";
            this.dgvTCl.Size = new System.Drawing.Size(475, 134);
            this.dgvTCl.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(821, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Клиенты";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(821, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Товары клиентов";
            // 
            // Market
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 497);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvTCl);
            this.Controls.Add(this.dgvCl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbGruzov);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvBuyer);
            this.Controls.Add(this.dgvTov);
            this.Name = "Market";
            this.Text = "Торговая точка";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuyer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGruzov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTCl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTov;
        private System.Windows.Forms.DataGridView dgvBuyer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pbGruzov;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dgvCl;
        private System.Windows.Forms.DataGridView dgvTCl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

