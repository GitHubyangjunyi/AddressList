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
        public Information()
        {
            InitializeComponent();
        }

        private void Information_Load(object sender, EventArgs e)
        {
            GetDate("select *  from sinformation");
        }

        static string constr = string.Format("Data Source=.;Initial Catalog=addresslist;UID={0};PWD={1}", Login.username, Login.pwd);
        SqlConnection con = new SqlConnection(constr);
        static public string hash;
        static public string no;
        static public string name;
        static public string age;
        static public string sex;
        static public string clas;
        static public string dept;
        static public string phone;
        static public string qq;
        static public string addr;
        static public string picture;
        
        public void GetInfo()
        {
            hash = txt_hash.Text;
            no = txt_no.Text;
            name = txt_name.Text;
            age = txt_age.Text;
            sex = "男";
            if (radioButton_woman.Checked)
            {
                sex = "女";
            }
            clas = comboBox_clas.Text;
            dept = comboBox_dept.Text;
            phone = txt_phone.Text;
            qq = txt_qq.Text;
            addr = txt_addr.Text;
            picture = pictureBox_show.ImageLocation;
        }

        public void Result(int i, string task)
        {
            if (i > 0)
            {
                MessageBox.Show(task + "学生信息成功!");
            }
            else
            {
                MessageBox.Show(task + "学生信息失败!");
            }
        }
        
        private void Button_insert_Click(object sender, EventArgs e)
        {
            try
            {
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
                GetInfo();
                string sql_insert = string.Format("insert into sinformation( no, name, age, sex, clas, dept, phone, qq, addr, picture) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')", no, name, age, sex, clas, dept, phone, qq, addr, picture);
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
                Result(cmd_insert.ExecuteNonQuery(), "提交");
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

        private void Button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                GetInfo();
                string sql_delete = string.Format("delete from sinformation where no='{0}' and name='{1}'", no, name);
                SqlCommand cmd_delete = new SqlCommand
                {
                    CommandText = sql_delete,
                    Connection = con
                };
                if (MessageBox.Show("确定删除?此操作不可恢复!", "此操作不可恢复!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    try
                    {
                        con.Open();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("连接数据库失败!");
                        return;
                    }
                    Result(cmd_delete.ExecuteNonQuery(), "删除");
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
            }
            catch
            {
                MessageBox.Show("输入有误,请重新输入!");
                return;
            }
        }

        private void Button_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_hash.Text == "")
                {
                    MessageBox.Show("请输入编号进行修改!");
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
                GetInfo();
                string sql_update = string.Format("update sinformation set  no='{0}', name='{1}', age='{2}', sex='{3}', clas='{4}', dept='{5}', phone='{6}' ,qq='{7}' ,addr='{8}' ,picture='{9}'where hash='{10}'", no, name, age, sex, clas, dept, phone, qq, addr, picture, hash);
                SqlCommand cmd_update = new SqlCommand
                {
                    CommandText = sql_update,
                    Connection = con
                };
                try
                {
                    con.Open();
                }
                catch (Exception)
                {
                    MessageBox.Show("连接数据库失败!");
                    return;
                }
                Result(cmd_update.ExecuteNonQuery(), "修改");
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

        private void Button_select_Click(object sender, EventArgs e)
        {
            GetInfo();
            string sql_select = string.Format("select * from sinformation where 1<0 or name= '{1}'or no= '{0}'", name, no);
            GetDate(sql_select);
        }

        private void PictureBox_show_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
            if (DialogResult.OK == OpenFileDialog1.ShowDialog())
                pictureBox_show.Image = Image.FromFile(OpenFileDialog1.FileName);
        }

        public void GetDate(string sql)
        {
            DataSet dataSet = new DataSet();
            SqlCommand GetDate_command = new SqlCommand(sql)
            {
                Connection = con
            };
            SqlDataAdapter dataAdapter = new SqlDataAdapter
            {
                SelectCommand = GetDate_command
            };
            dataAdapter.Fill(dataSet);
            dataGridView_sinformation.DataSource = dataSet.Tables[0];
        }
    }
}