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

        private void button_insert_Click(object sender, EventArgs e)
        {

        }

        private void Information_Load(object sender, EventArgs e)
        {

        }
    }
}
//private void button_insert_Click(object sender, EventArgs e)
//{
//    #region
//    //这一部分是集合和泛型的示例
//    //ListViewItem lsvi = new ListViewItem();
//    //lsvi.SubItems.Add(txt_name.Text);
//    //lsvi.SubItems.Add(txt_no.Text);
//    //lsvi.SubItems.Add(comboBox_class.Text);
//    //lsvi.SubItems.Add(txt_phoneno.Text);
//    //string sex = "男";
//    //if (radioButton2.Checked==true)
//    //{
//    //    sex = "女";
//    //}
//    //lsvi.SubItems.Add(sex);
//    //listView1.Items.Add(lsvi);
//    #endregion
//    try
//    {
//        string no = txt_no.Text.Trim();
//        string name = txt_name.Text.Trim();
//        int age = Convert.ToInt32(txt_age.Text.Trim());
//        string clas = comboBox_clas.Text;
//        string phone = txt_phone.Text;
//        string sex = "男";
//        if (radioButton_woman.Checked)
//        {
//            sex = "女";
//        }
//        if (comboBox_clas.Text == "请选择班级")
//        {
//            MessageBox.Show("请选择班级!");
//            comboBox_clas.DropDownStyle = ComboBoxStyle.DropDownList;
//            return;
//        }
//        string constr = "Data Source=.;Initial Catalog=testproject;Integrated Security=True";//连接字符串
//        string sql_insert = string.Format("insert into information( no, name, age, clas, phone, sex ) values ('{0}','{1}','{2}','{3}','{4}','{5}')", no, name, age, clas, phone, sex);
//        //定义查询要执行的SQL语句
//        //不允许因为代码编辑窗口太小而使用回车,这会导致错误!!!
//        SqlConnection con = new SqlConnection(constr);//实例化一个数据库连接对象
//        SqlCommand cmd_insert = new SqlCommand
//        {
//            CommandText = sql_insert
//        };//实例化一个数据库操作对象
//        cmd_insert.Connection = con;
//        try
//        {
//            con.Open();//打开数据库连接
//        }
//        catch (Exception)
//        {
//            MessageBox.Show("连接数据库失败!");
//            return;
//        }
//        int j = cmd_insert.ExecuteNonQuery();//由于增加了一条记录，所以返回1
//        if (j > 0)
//        {
//            MessageBox.Show("添加学生信息成功!");
//        }
//        else
//        {
//            MessageBox.Show("添加学生信息失败!");
//        }
//        try
//        {
//            con.Close();//立即关闭数据库连接
//        }
//        catch (Exception)
//        {
//            MessageBox.Show("断开数据库失败!");
//            return;
//        }
//    }
//    catch//一般的catch代码块:catch后面没有任何内容,可以匹配任何类型的异常.
//    {
//        MessageBox.Show("输入有误,请重新输入!");
//        return;
//    }
//}

//private void button_delete_Click(object sender, EventArgs e)
//{
//    try
//    {
//        string no = txt_no.Text.Trim();
//        string name = txt_name.Text.Trim();
//        string constr = "Data Source=.;Initial Catalog=testproject;Integrated Security=True";//连接字符串
//        string sql_delete = string.Format("delete from information where no='{0}' and name='{1}'", no, name);
//        //定义查询要执行的SQL语句
//        //不允许因为代码编辑窗口太小而使用回车,这会导致错误!!!
//        SqlConnection con = new SqlConnection(constr);//实例化一个数据库连接对象
//        SqlCommand cmd_delete = new SqlCommand
//        {
//            CommandText = sql_delete
//        };//实例化一个数据库操作对象
//        cmd_delete.Connection = con;
//        try
//        {
//            con.Open();//打开数据库连接
//        }
//        catch (Exception)
//        {
//            MessageBox.Show("连接数据库失败!");
//            return;
//        }
//        int j = cmd_delete.ExecuteNonQuery();//由于增加了一条记录，所以返回1
//        if (j > 0)
//        {
//            MessageBox.Show("删除学生信息成功!");
//        }
//        else
//        {
//            MessageBox.Show("删除学生信息失败!");
//        }
//        try
//        {
//            con.Close();//立即关闭数据库连接
//        }
//        catch (Exception)
//        {
//            MessageBox.Show("断开数据库失败!");
//            return;
//        }
//    }
//    catch//一般的catch代码块:catch后面没有任何内容,可以匹配任何类型的异常.
//    {
//        MessageBox.Show("输入有误,请重新输入!");
//        return;
//    }
//}

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
//    int j = (int)cmd_select.ExecuteScalar();
//    MessageBox.Show("j");

//}

//private void pictureBox1_Click(object sender, EventArgs e)
//{
//    OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
//    if (DialogResult.OK == OpenFileDialog1.ShowDialog())
//        pictureBox_show.Image = Image.FromFile(OpenFileDialog1.FileName);

//}

//private void button_update_Click(object sender, EventArgs e)
//{
//    try
//    {
//        string no = txt_no.Text.Trim();
//        string name = txt_name.Text.Trim();
//        int age = Convert.ToInt32(txt_age.Text.Trim());
//        string clas = comboBox_clas.Text;
//        string phone = txt_phone.Text;
//        string sex = "男";
//        if (radioButton_woman.Checked)
//        {
//            sex = "女";
//        }
//        if (comboBox_clas.Text == "请选择班级")
//        {
//            MessageBox.Show("请选择班级!");
//            comboBox_clas.DropDownStyle = ComboBoxStyle.DropDownList;
//            return;
//        }
//        string constr = "Data Source=.;Initial Catalog=testproject;Integrated Security=True";//连接字符串
//        string sql_update = string.Format("update information set name='{0}', age={1}, clas='{2}', phone='{3}', sex='{4}' where no='{5}'", name, age, clas, phone, sex, no);
//        //同时修改多项数据需要用逗号隔开,(用逗号隔开)(用逗号隔开),出错时先把异常捕获注释掉,通过异常信息调试程序错误
//        //定义查询要执行的SQL语句
//        //不允许因为代码编辑窗口太小而使用回车,这会导致错误!!!
//        SqlConnection con = new SqlConnection(constr);//实例化一个数据库连接对象
//        SqlCommand cmd_update = new SqlCommand
//        {
//            CommandText = sql_update
//        };//实例化一个数据库操作对象
//        cmd_update.Connection = con;
//        try
//        {
//            con.Open();//打开数据库连接
//        }
//        catch (Exception)
//        {
//            MessageBox.Show("连接数据库失败!");
//            return;
//        }
//        int j = cmd_update.ExecuteNonQuery();//由于增加了一条记录，所以返回1
//        if (j > 0)
//        {
//            MessageBox.Show("修改学生信息成功!");
//        }
//        else
//        {
//            MessageBox.Show("修改学生信息失败!");
//        }
//        try
//        {
//            con.Close();//立即关闭数据库连接
//        }
//        catch (Exception)
//        {
//            MessageBox.Show("断开数据库失败!");
//            return;
//        }
//    }
//    catch
//    {
//        MessageBox.Show("输入错误请重新输入!");
//        return;
//    }
//}

//private void Form2_Load(object sender, EventArgs e)
//{

//}
//    }
//}
//数据库访问一般步骤
//1-定义连接数据库的连接字符串
//2-定义要进行的SQL语言操作
//3-把连接字符串传递给SqlConnection类的构造函数实例化一个数据库连接员对象
//4-实例化SqlCommand类的数据库操作员对象,并将要执行SQL操作传递给操作员对象的CommandText属性(告诉操作员做什么)
//5-数据库操作员的连接属性等于操作员(也就是叫数据库连接员来引路)
//6-连接员引路打开数据库方法让操作员操作
//7-操作员操作完数据连接员关闭数据库