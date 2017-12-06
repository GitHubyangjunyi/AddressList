using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlClass
{
    public class SqlInsert
    {
        public string sql;
        public SqlInsert(string sql)
        {
            this.sql = sql;
        }
        public void Execute()
        {

        }
        //    string no = txt_no.Text.Trim();
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
    }
}
