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

        public int DbSignIn_Out()
        {
            //连接字符串string constr = "Data Source=.;Initial Catalog=addresslist;Integrated Security=True";
            //定义连接字符串为//数据库服务器名称为本地//指明要连接的数据库的名称为addresslist//集成用户方式登陆
            //路径连接:"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=路径;"
            //指明数据源的驱动程序是Microsoft.Jet.OLEDB.4.0,此驱动程序必须在本地计算机上面
            //string sql_insert = string.Format("insert into information( no, name, age, clas, phone, sex ) values ('{0}','{1}','{2}','{3}','{4}','{5}')", no, name, age, clas, phone, sex);
            //定义查询要执行的SQL语句
            //不允许因为代码编辑窗口太小而使用回车,这会导致错误!!!
            string constr_sign_in = string.Format("Data Source=.;Initial Catalog=addresslist;UID='test';PWD=123456");
            string sql_sign_in = string.Format("select count(*) from login where username='test' and pwd=123456");
            SqlConnection connect_sign_in = new SqlConnection(constr_sign_in);//实例化连接对象,并将连接字符串给该对象
            SqlCommand cmd_sign_in = new SqlCommand
            {
                CommandText = sql_sign_in
            };
            cmd_sign_in.Connection = connect_sign_in;//获取或设置 System.Data.SqlClient.SqlCommand 的此实例使用的 System.Data.SqlClient.SqlConnection。
                                                     //返回结果:到数据源的连接
            connect_sign_in.Open();//打开数据库连接
            int i = Convert.ToInt32(cmd_sign_in.ExecuteScalar());//返回执行结果的第一行第一列
            connect_sign_in.Close();
            return i;
        }

        private void button_insert_Click(object sender, EventArgs e)
        {

            try
            {
                string no = txt_no.Text.Trim();
                string name = txt_name.Text.Trim();
                int age = Convert.ToInt32(txt_age.Text.Trim());
                string sex = "男";
                string clas = comboBox_clas.Text;
                string dept = comboBox_dept.Text;
                string phone = txt_phone.Text;
                string qq = txt_qq.Text;
                string addr = txt_addr.Text;
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
                string constr = "Data Source=.;Initial Catalog=addresslist;UID=yangjunyi;PWD=123456";
                string sql_insert = string.Format("insert into sinformation( no, name, age, sex, clas, dept, phone, qq, addr ) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", no, name, age, sex, clas, dept, phone, qq, addr);
                SqlConnection con = new SqlConnection(constr);//实例化一个数据库连接对象
                SqlCommand cmd_insert = new SqlCommand
                {
                    CommandText = sql_insert
                };//实例化一个数据库操作对象
                cmd_insert.Connection = con;
                try
                {
                    con.Open();//打开数据库连接
                }
                catch (Exception)
                {
                    MessageBox.Show("连接数据库失败!");
                }
                int j = cmd_insert.ExecuteNonQuery();//由于增加了一条记录，所以返回1
                if (j > 0)
                {
                    MessageBox.Show("添加学生信息成功!");
                }
                else
                {
                    MessageBox.Show("添加学生信息失败!");
                }
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
            catch
            {
                MessageBox.Show("输入有误,请重新输入!");
                return;
            }
        }

        private void Information_Load(object sender, EventArgs e)
        {
            //Login login = new Login();
            //login.DbSignIn_Out();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                string no = txt_no.Text.Trim();
                string name = txt_name.Text.Trim();
                #region                
                //int age = Convert.ToInt32(txt_age.Text.Trim());
                //string sex = "男";
                //string clas = comboBox_clas.Text;
                //string dept = comboBox_dept.Text;
                //string phone = txt_phone.Text;
                //string qq = txt_qq.Text;
                //string addr = txt_addr.Text;
                //if (radioButton_woman.Checked)
                //{
                //    sex = "女";
                //}
                //if (comboBox_clas.Text == "请选择班级")
                //{
                //    MessageBox.Show("请选择班级!");
                //    comboBox_clas.DropDownStyle = ComboBoxStyle.DropDownList;
                //    return;
                //}
                //if (comboBox_dept.Text == "请选择所在系")
                //{
                //    MessageBox.Show("请选择所在系!");
                //    comboBox_dept.DropDownStyle = ComboBoxStyle.DropDownList;
                //    return;
                //}
                #endregion
                string constr = "Data Source=.;Initial Catalog=addresslist;UID=yangjunyi;PWD=123456";
                string sql_delete = string.Format("delete from sinformation where no={0} and name={1}", no, name);
                SqlConnection con = new SqlConnection(constr);//实例化一个数据库连接对象
                SqlCommand cmd_delete = new SqlCommand
                {
                    CommandText = sql_delete
                };//实例化一个数据库操作对象
                cmd_delete.Connection = con;
                if (MessageBox.Show("确定删除?此操作不可恢复!", "此操作不可恢复!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    //第一个字符串参数为显示在对话框中的文本,第二个字符串参数为对话框标题
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
                    int j = cmd_delete.ExecuteNonQuery();//由于增加了一条记录，所以返回1
                    if (j > 0)
                    {
                        MessageBox.Show("删除学生信息成功!");
                    }
                    else
                    {
                        MessageBox.Show("删除学生信息失败!");
                    }
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
                string no = txt_no.Text.Trim();
                string name = txt_name.Text.Trim();
                int age = Convert.ToInt32(txt_age.Text.Trim());
                string sex = "男";
                string clas = comboBox_clas.Text;
                string dept = comboBox_dept.Text;
                string phone = txt_phone.Text;
                string qq = txt_qq.Text;
                string addr = txt_addr.Text;
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
                string constr = "Data Source=.;Initial Catalog=addresslist;UID=yangjunyi;PWD=123456";
                string sql_insert = string.Format("update sinformation set no='{0}',name='{1}', age='{2}', sex='{3}', clas='{4}', dept='{5}', phone='{6}', qq='{7}', addr='{8}'", no, name, age, sex, clas, dept, phone, qq, addr);
                SqlConnection con = new SqlConnection(constr);//实例化一个数据库连接对象
                SqlCommand cmd_insert = new SqlCommand
                {
                    CommandText = sql_insert
                };//实例化一个数据库操作对象
                cmd_insert.Connection = con;
                try
                {
                    con.Open();//打开数据库连接
                }
                catch (Exception)
                {
                    MessageBox.Show("连接数据库失败!");
                }
                int j = cmd_insert.ExecuteNonQuery();//由于增加了一条记录，所以返回1
                if (j > 0)
                {
                    MessageBox.Show("修改学生信息成功!");
                }
                else
                {
                    MessageBox.Show("修改学生信息失败!");
                }
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
            catch
            {
                MessageBox.Show("输入有误,请重新输入!");
                return;
            }
        }

       

        private void button_select_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox_show_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
            if (DialogResult.OK == OpenFileDialog1.ShowDialog())
                pictureBox_show.Image = Image.FromFile(OpenFileDialog1.FileName);
        }
    }
}
//private void button_select_Click(object sender, EventArgs e)
//{

//    string no = txt_no.Text.Trim();
//    //string name = txt_name.Text.Trim();
//    //int age = Convert.ToInt32(txt_age.Text.Trim());
//    //string clas = comboBox_clas.Text;
//    //string phone = txt_phone.Text;
//    string sex = "男";
//    if (radioButton_woman.Checked)
//    {
//        sex = "女";
//    }
//    if (comboBox_clas.Text == "请选择班级")
//    {
//        MessageBox.Show("请选择班级!");
//        comboBox_clas.DropDownStyle = ComboBoxStyle.DropDownList;
//        return;
//    }
//    string constr = "Data Source=.;Initial Catalog=testproject;Integrated Security=True";//连接字符串
//                                                                                         //string sql_select = string.Format("select * from information where no='{0}' or name='{1}' or age='{2}' or clas='{3}' or phone='{4}' or sex='{5}'", txt_no.Text="1",txt_name.Text = "1", txt_age.Text = "1", comboBox_clas.Text = "1", txt_phone.Text = "1", sex = "男");
//                                                                                         //后面跟的数据用来测试默认输入,具体还未验证
//    string sql_select = string.Format("select * from information where no='{0}' or name='{1}' or age='{2}' or clas='{3}' or phone='{4}' or sex='{5}'", txt_no.Text, txt_name.Text, txt_age.Text, comboBox_clas.Text, txt_phone.Text, sex);
//    //定义查询要执行的SQL语句
//    //不允许因为代码编辑窗口太小而使用回车,这会导致错误!!!
//    SqlConnection con = new SqlConnection(constr);
//    SqlCommand cmd_select = new SqlCommand
//    {
//        CommandText = sql_select
//    };
//    cmd_select.Connection = con;
//    try
//    {
//        con.Open();//打开数据库连接
//    }
//    catch (Exception)
//    {
//        MessageBox.Show("连接数据库失败!");
//        return;
//    }

//数据库访问一般步骤
//1-定义连接数据库的连接字符串
//2-定义要进行的SQL语言操作
//3-把连接字符串传递给SqlConnection类的构造函数实例化一个数据库连接员对象
//4-实例化SqlCommand类的数据库操作员对象,并将要执行SQL操作传递给操作员对象的CommandText属性(告诉操作员做什么)
//5-数据库操作员的连接属性等于操作员(也就是叫数据库连接员来引路)
//6-连接员引路打开数据库方法让操作员操作
//7-操作员操作完数据连接员关闭数据库