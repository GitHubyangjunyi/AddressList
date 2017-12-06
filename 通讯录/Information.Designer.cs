namespace 通讯录
{
    partial class Information
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
            this.groupBox_information = new System.Windows.Forms.GroupBox();
            this.button_update = new System.Windows.Forms.Button();
            this.label_addr = new System.Windows.Forms.Label();
            this.label_qq = new System.Windows.Forms.Label();
            this.label_hash = new System.Windows.Forms.Label();
            this.pictureBox_show = new System.Windows.Forms.PictureBox();
            this.comboBox_dept = new System.Windows.Forms.ComboBox();
            this.comboBox_clas = new System.Windows.Forms.ComboBox();
            this.groupBox_sex = new System.Windows.Forms.GroupBox();
            this.radioButton_woman = new System.Windows.Forms.RadioButton();
            this.radioButton_man = new System.Windows.Forms.RadioButton();
            this.txt_addr = new System.Windows.Forms.TextBox();
            this.txt_qq = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_no = new System.Windows.Forms.TextBox();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.txt_hash = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.button_select = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_insert = new System.Windows.Forms.Button();
            this.label_dept = new System.Windows.Forms.Label();
            this.label_phone = new System.Windows.Forms.Label();
            this.label_clas = new System.Windows.Forms.Label();
            this.label_age = new System.Windows.Forms.Label();
            this.label_no = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.dataGridView_sinformation = new System.Windows.Forms.DataGridView();
            this.groupBox_information.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_show)).BeginInit();
            this.groupBox_sex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sinformation)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_information
            // 
            this.groupBox_information.Controls.Add(this.button_update);
            this.groupBox_information.Controls.Add(this.label_addr);
            this.groupBox_information.Controls.Add(this.label_qq);
            this.groupBox_information.Controls.Add(this.label_hash);
            this.groupBox_information.Controls.Add(this.pictureBox_show);
            this.groupBox_information.Controls.Add(this.comboBox_dept);
            this.groupBox_information.Controls.Add(this.comboBox_clas);
            this.groupBox_information.Controls.Add(this.groupBox_sex);
            this.groupBox_information.Controls.Add(this.txt_addr);
            this.groupBox_information.Controls.Add(this.txt_qq);
            this.groupBox_information.Controls.Add(this.txt_phone);
            this.groupBox_information.Controls.Add(this.txt_no);
            this.groupBox_information.Controls.Add(this.txt_age);
            this.groupBox_information.Controls.Add(this.txt_hash);
            this.groupBox_information.Controls.Add(this.txt_name);
            this.groupBox_information.Controls.Add(this.button_select);
            this.groupBox_information.Controls.Add(this.button_delete);
            this.groupBox_information.Controls.Add(this.button_insert);
            this.groupBox_information.Controls.Add(this.label_dept);
            this.groupBox_information.Controls.Add(this.label_phone);
            this.groupBox_information.Controls.Add(this.label_clas);
            this.groupBox_information.Controls.Add(this.label_age);
            this.groupBox_information.Controls.Add(this.label_no);
            this.groupBox_information.Controls.Add(this.label_name);
            this.groupBox_information.Font = new System.Drawing.Font("宋体", 9F);
            this.groupBox_information.Location = new System.Drawing.Point(1, 2);
            this.groupBox_information.Name = "groupBox_information";
            this.groupBox_information.Size = new System.Drawing.Size(981, 371);
            this.groupBox_information.TabIndex = 1;
            this.groupBox_information.TabStop = false;
            this.groupBox_information.Text = "学生信息:";
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(268, 292);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(83, 49);
            this.button_update.TabIndex = 11;
            this.button_update.Text = "修改";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // label_addr
            // 
            this.label_addr.AutoSize = true;
            this.label_addr.Font = new System.Drawing.Font("宋体", 12F);
            this.label_addr.Location = new System.Drawing.Point(281, 74);
            this.label_addr.Name = "label_addr";
            this.label_addr.Size = new System.Drawing.Size(48, 16);
            this.label_addr.TabIndex = 10;
            this.label_addr.Text = "地址:";
            // 
            // label_qq
            // 
            this.label_qq.AutoSize = true;
            this.label_qq.Font = new System.Drawing.Font("宋体", 12F);
            this.label_qq.Location = new System.Drawing.Point(297, 44);
            this.label_qq.Name = "label_qq";
            this.label_qq.Size = new System.Drawing.Size(32, 16);
            this.label_qq.TabIndex = 10;
            this.label_qq.Text = "QQ:";
            // 
            // label_hash
            // 
            this.label_hash.AutoSize = true;
            this.label_hash.Font = new System.Drawing.Font("宋体", 12F);
            this.label_hash.Location = new System.Drawing.Point(57, 17);
            this.label_hash.Name = "label_hash";
            this.label_hash.Size = new System.Drawing.Size(48, 16);
            this.label_hash.TabIndex = 10;
            this.label_hash.Text = "编号:";
            // 
            // pictureBox_show
            // 
            this.pictureBox_show.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_show.Location = new System.Drawing.Point(588, 12);
            this.pictureBox_show.Name = "pictureBox_show";
            this.pictureBox_show.Size = new System.Drawing.Size(135, 170);
            this.pictureBox_show.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_show.TabIndex = 9;
            this.pictureBox_show.TabStop = false;
            this.pictureBox_show.Click += new System.EventHandler(this.pictureBox_show_Click);
            // 
            // comboBox_dept
            // 
            this.comboBox_dept.FormattingEnabled = true;
            this.comboBox_dept.Items.AddRange(new object[] {
            "软件工程系",
            "数字媒体系",
            "信息管理系"});
            this.comboBox_dept.Location = new System.Drawing.Point(110, 156);
            this.comboBox_dept.Name = "comboBox_dept";
            this.comboBox_dept.Size = new System.Drawing.Size(133, 20);
            this.comboBox_dept.TabIndex = 8;
            this.comboBox_dept.Text = "请选择所在系";
            // 
            // comboBox_clas
            // 
            this.comboBox_clas.FormattingEnabled = true;
            this.comboBox_clas.Items.AddRange(new object[] {
            "16级软件开发1班",
            "16级软件开发2班",
            "16级软件开发3班"});
            this.comboBox_clas.Location = new System.Drawing.Point(110, 130);
            this.comboBox_clas.Name = "comboBox_clas";
            this.comboBox_clas.Size = new System.Drawing.Size(133, 20);
            this.comboBox_clas.TabIndex = 8;
            this.comboBox_clas.Text = "请选择班级";
            // 
            // groupBox_sex
            // 
            this.groupBox_sex.Controls.Add(this.radioButton_woman);
            this.groupBox_sex.Controls.Add(this.radioButton_man);
            this.groupBox_sex.Font = new System.Drawing.Font("宋体", 12F);
            this.groupBox_sex.Location = new System.Drawing.Point(52, 185);
            this.groupBox_sex.Name = "groupBox_sex";
            this.groupBox_sex.Size = new System.Drawing.Size(209, 50);
            this.groupBox_sex.TabIndex = 7;
            this.groupBox_sex.TabStop = false;
            this.groupBox_sex.Text = "性别:";
            // 
            // radioButton_woman
            // 
            this.radioButton_woman.AutoSize = true;
            this.radioButton_woman.Location = new System.Drawing.Point(157, 28);
            this.radioButton_woman.Name = "radioButton_woman";
            this.radioButton_woman.Size = new System.Drawing.Size(42, 20);
            this.radioButton_woman.TabIndex = 0;
            this.radioButton_woman.Text = "女";
            this.radioButton_woman.UseVisualStyleBackColor = true;
            // 
            // radioButton_man
            // 
            this.radioButton_man.AutoSize = true;
            this.radioButton_man.Checked = true;
            this.radioButton_man.Location = new System.Drawing.Point(39, 28);
            this.radioButton_man.Name = "radioButton_man";
            this.radioButton_man.Size = new System.Drawing.Size(42, 20);
            this.radioButton_man.TabIndex = 0;
            this.radioButton_man.TabStop = true;
            this.radioButton_man.Text = "男";
            this.radioButton_man.UseVisualStyleBackColor = true;
            // 
            // txt_addr
            // 
            this.txt_addr.Location = new System.Drawing.Point(335, 69);
            this.txt_addr.Multiline = true;
            this.txt_addr.Name = "txt_addr";
            this.txt_addr.Size = new System.Drawing.Size(133, 108);
            this.txt_addr.TabIndex = 6;
            // 
            // txt_qq
            // 
            this.txt_qq.Location = new System.Drawing.Point(335, 44);
            this.txt_qq.Name = "txt_qq";
            this.txt_qq.Size = new System.Drawing.Size(133, 21);
            this.txt_qq.TabIndex = 6;
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(335, 12);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(133, 21);
            this.txt_phone.TabIndex = 6;
            // 
            // txt_no
            // 
            this.txt_no.Location = new System.Drawing.Point(110, 40);
            this.txt_no.Name = "txt_no";
            this.txt_no.Size = new System.Drawing.Size(133, 21);
            this.txt_no.TabIndex = 6;
            // 
            // txt_age
            // 
            this.txt_age.Location = new System.Drawing.Point(110, 103);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(133, 21);
            this.txt_age.TabIndex = 6;
            // 
            // txt_hash
            // 
            this.txt_hash.Enabled = false;
            this.txt_hash.Location = new System.Drawing.Point(110, 12);
            this.txt_hash.Name = "txt_hash";
            this.txt_hash.Size = new System.Drawing.Size(133, 21);
            this.txt_hash.TabIndex = 6;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(110, 74);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(133, 21);
            this.txt_name.TabIndex = 6;
            // 
            // button_select
            // 
            this.button_select.Location = new System.Drawing.Point(484, 292);
            this.button_select.Name = "button_select";
            this.button_select.Size = new System.Drawing.Size(83, 49);
            this.button_select.TabIndex = 5;
            this.button_select.Text = "查询";
            this.button_select.UseVisualStyleBackColor = true;
            this.button_select.Click += new System.EventHandler(this.button_select_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(376, 292);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(83, 49);
            this.button_delete.TabIndex = 5;
            this.button_delete.Text = "删除";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_insert
            // 
            this.button_insert.Location = new System.Drawing.Point(160, 292);
            this.button_insert.Name = "button_insert";
            this.button_insert.Size = new System.Drawing.Size(83, 49);
            this.button_insert.TabIndex = 5;
            this.button_insert.Text = "提交";
            this.button_insert.UseVisualStyleBackColor = true;
            this.button_insert.Click += new System.EventHandler(this.button_insert_Click);
            // 
            // label_dept
            // 
            this.label_dept.AutoSize = true;
            this.label_dept.Font = new System.Drawing.Font("宋体", 12F);
            this.label_dept.Location = new System.Drawing.Point(41, 156);
            this.label_dept.Name = "label_dept";
            this.label_dept.Size = new System.Drawing.Size(64, 16);
            this.label_dept.TabIndex = 3;
            this.label_dept.Text = "所在系:";
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.Font = new System.Drawing.Font("宋体", 12F);
            this.label_phone.Location = new System.Drawing.Point(249, 17);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(80, 16);
            this.label_phone.TabIndex = 3;
            this.label_phone.Text = "联系电话:";
            // 
            // label_clas
            // 
            this.label_clas.AutoSize = true;
            this.label_clas.Font = new System.Drawing.Font("宋体", 12F);
            this.label_clas.Location = new System.Drawing.Point(57, 129);
            this.label_clas.Name = "label_clas";
            this.label_clas.Size = new System.Drawing.Size(48, 16);
            this.label_clas.TabIndex = 4;
            this.label_clas.Text = "班级:";
            // 
            // label_age
            // 
            this.label_age.AutoSize = true;
            this.label_age.Font = new System.Drawing.Font("宋体", 12F);
            this.label_age.Location = new System.Drawing.Point(57, 101);
            this.label_age.Name = "label_age";
            this.label_age.Size = new System.Drawing.Size(48, 16);
            this.label_age.TabIndex = 1;
            this.label_age.Text = "年龄:";
            // 
            // label_no
            // 
            this.label_no.AutoSize = true;
            this.label_no.Font = new System.Drawing.Font("宋体", 12F);
            this.label_no.Location = new System.Drawing.Point(57, 45);
            this.label_no.Name = "label_no";
            this.label_no.Size = new System.Drawing.Size(48, 16);
            this.label_no.TabIndex = 1;
            this.label_no.Text = "学号:";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("宋体", 12F);
            this.label_name.Location = new System.Drawing.Point(57, 73);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(48, 16);
            this.label_name.TabIndex = 2;
            this.label_name.Text = "姓名:";
            // 
            // dataGridView_sinformation
            // 
            this.dataGridView_sinformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_sinformation.Location = new System.Drawing.Point(1, 377);
            this.dataGridView_sinformation.Name = "dataGridView_sinformation";
            this.dataGridView_sinformation.RowTemplate.Height = 23;
            this.dataGridView_sinformation.Size = new System.Drawing.Size(981, 294);
            this.dataGridView_sinformation.TabIndex = 2;
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 711);
            this.Controls.Add(this.dataGridView_sinformation);
            this.Controls.Add(this.groupBox_information);
            this.Name = "Information";
            this.Text = "通讯录管理";
            this.Load += new System.EventHandler(this.Information_Load);
            this.groupBox_information.ResumeLayout(false);
            this.groupBox_information.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_show)).EndInit();
            this.groupBox_sex.ResumeLayout(false);
            this.groupBox_sex.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sinformation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_information;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Label label_hash;
        private System.Windows.Forms.PictureBox pictureBox_show;
        private System.Windows.Forms.ComboBox comboBox_clas;
        private System.Windows.Forms.GroupBox groupBox_sex;
        private System.Windows.Forms.RadioButton radioButton_woman;
        private System.Windows.Forms.RadioButton radioButton_man;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_no;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.TextBox txt_hash;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button button_select;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_insert;
        private System.Windows.Forms.Label label_phone;
        private System.Windows.Forms.Label label_clas;
        private System.Windows.Forms.Label label_age;
        private System.Windows.Forms.Label label_no;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_qq;
        private System.Windows.Forms.Label label_dept;
        private System.Windows.Forms.Label label_addr;
        private System.Windows.Forms.TextBox txt_qq;
        private System.Windows.Forms.TextBox txt_addr;
        private System.Windows.Forms.DataGridView dataGridView_sinformation;
        private System.Windows.Forms.ComboBox comboBox_dept;
    }
}