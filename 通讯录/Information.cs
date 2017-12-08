using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 通讯录
{
    public partial class Information : Form
    {
        static public string no;
        static public string name;
        static public int age;
        static public string sex;
        static public string clas;
        static public string dept;
        static public string phone;
        static public string qq;
        static public string addr;
        static public string picture;
        public Information()
        {
            InitializeComponent();
            no =txt_no.Text;
            name=txt_name.Text;
            age= Convert.ToInt32(txt_age.Text.Trim());
            sex = "男";
            if (radioButton_woman.Checked)
            {
                sex = "女";
            }
            clas= comboBox_clas.Text;
            dept = comboBox_dept.Text;
            phone=txt_phone.Text;
            qq=txt_qq.Text;
            addr=txt_addr.Text;
            picture= pictureBox_show.ImageLocation;
        }
        static string constr = string.Format("Data Source=.;Initial Catalog=addresslist;UID={0};PWD={1}", Login.username, Login.pwd);
        SqlConnection con = new SqlConnection(constr);
        public void Judge(int j, string task)
        {
            if (j > 0)
            {
                MessageBox.Show(task + "学生信息成功!");
            }
            else
            {
                MessageBox.Show(task + "学生信息失败!");
            }
        }
        private void button_insert_Click(object sender, EventArgs e)
        {
            try
            {
                string sex = "男";
                if (radioButton_woman.Checked)
                {
                    sex = "女";
                }
                if (comboBox_clas.Text == "请选择班级")
                {
                    MessageBox.Show("请选择班级!");
                    comboBox_clas.DropDownStyle = ComboBoxStyle.DropDownList;
                    return;
                }
                if (comboBox_dept.Text == "请选择所在系")
                {
                    MessageBox.Show("请选择所在系!");
                    comboBox_dept.DropDownStyle = ComboBoxStyle.DropDownList;
                    return;
                }
                string sql_insert = string.Format("insert into sinformation( no, name, age, sex, clas, dept, phone, qq, addr,picture) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')", txt_no.Text.Trim(), txt_name.Text.Trim(), Convert.ToInt32(txt_age.Text.Trim()), sex, comboBox_clas.Text, comboBox_dept.Text, txt_phone.Text, txt_qq.Text, txt_addr.Text, pictureBox_show.ImageLocation);
                SqlCommand cmd_insert = new SqlCommand
                {
                    CommandText = sql_insert,
                    Connection = con
                };
                try
                {
                    con.Open();
                }
                catch (Exception)
                {
                    MessageBox.Show("连接数据库失败!");
                }
                Judge(cmd_insert.ExecuteNonQuery(), "提交");
                GetDate("select *  from sinformation");
                try
                {
                    con.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("断开数据库失败!");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("输入有误,请重新输入!");
                return;
            }
        }

        private void Information_Load(object sender, EventArgs e)
        {
            GetDate("select *  from sinformation");
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                string sql_delete = string.Format("delete from sinformation where no={0} and name={1}", txt_no.Text.Trim(), txt_name.Text.Trim());
                SqlCommand cmd_delete = new SqlCommand
                {
                    CommandText = sql_delete
                };
                cmd_delete.Connection = con;
                if (MessageBox.Show("确定删除?此操作不可恢复!", "此操作不可恢复!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    try
                    {
                        con.Open();//打开数据库连接
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("连接数据库失败!");
                        return;
                    }
                    Judge(cmd_delete.ExecuteNonQuery(), "删除");
                    GetDate("select *  from sinformation");
                    try
                    {
                        con.Close();//立即关闭数据库连接
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("断开数据库失败!");
                        return;
                    }
                }
            }
            catch
            {
                MessageBox.Show("输入有误,请重新输入!");
                return;
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            try
            {
                string sex = "男";
                if (radioButton_woman.Checked)
                {
                    sex = "女";
                }
                if (comboBox_clas.Text == "请选择班级")
                {
                    MessageBox.Show("请选择班级!");
                    comboBox_clas.DropDownStyle = ComboBoxStyle.DropDownList;
                    return;
                }
                if (comboBox_dept.Text == "请选择所在系")
                {
                    MessageBox.Show("请选择所在系!");
                    comboBox_dept.DropDownStyle = ComboBoxStyle.DropDownList;
                    return;
                }
                string sql_insert = string.Format("update sinformation set  age='{0}', sex='{1}', clas='{2}', dept='{3}', phone='{4}', qq='{5}', addr='{6}' where no='{7}' and name='{8}'", Convert.ToInt32(txt_age.Text.Trim()), sex, comboBox_clas.Text, comboBox_dept.Text, txt_phone.Text, txt_qq.Text, txt_addr.Text, txt_no.Text.Trim(), txt_name.Text.Trim());
                SqlCommand cmd_insert = new SqlCommand
                {
                    CommandText = sql_insert
                };
                cmd_insert.Connection = con;
                try
                {
                    con.Open();
                }
                catch (Exception)
                {
                    MessageBox.Show("连接数据库失败!");
                }
                Judge(cmd_insert.ExecuteNonQuery(), "修改");
                GetDate("select *  from sinformation");
                try
                {
                    con.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("断开数据库失败!");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("输入有误,请重新输入!");
                return;
            }
        }

        private void button_select_Click(object sender, EventArgs e)
        {
            string sql_select = string.Format("select * from sinformation where 1<0 or name= '{1}'or no= '{0}'", txt_name.Text.Trim(), txt_no.Text.Trim());
            GetDate(sql_select);
        }

        private void pictureBox_show_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
            if (DialogResult.OK == OpenFileDialog1.ShowDialog())
                pictureBox_show.Image = Image.FromFile(OpenFileDialog1.FileName);
        }

        public void GetDate(string sql)
        {
            SqlCommand GetDate_Command = new SqlCommand(sql)
            {
                Connection = con
            };
            SqlDataAdapter dataAdapter = new SqlDataAdapter
            {
                SelectCommand = GetDate_Command
            };
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView_sinformation.DataSource = dataSet.Tables[0];
        }
    }
}