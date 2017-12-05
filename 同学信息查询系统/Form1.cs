using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 同学信息查询系统
{
    public partial class Form1 : Form
    {
        #region 创建一个构造数据库连接的方法
        public SqlConnection CreateConnection()
        {
            return new SqlConnection(@"Database=Exercise;Server=localhost;Integrated Security=SSPI;Connect Timeout=10");
        }
        #endregion
        #region 创造一个数据库执行对象的方法
        public SqlCommand CreateCommand()
        {
            return new SqlCommand(@"select Name,
                                           age,
                                           hight,
                                           major,
                                           hobby,
                                           homeplace,
                                           ID", new SqlConnection(@"Database=Excrise;Server=(local)\SQLEXPRESS;Integrated Security=SSPI;Connect Timeout=10"));


        }
        #endregion
        #region 遍历获得Student表中的Name字段的信息，是一个数组，就是string[]类型的result
        public string[] GetStudentName()
        {
            List <string> result= new List<string>();
            SqlConnection myconnection = CreateConnection();
            myconnection.Open();
            SqlCommand mycommand =myconnection. CreateCommand();
            mycommand.CommandText = "select Name from Student";
            mycommand.Connection = myconnection;
            SqlDataReader reader = mycommand.ExecuteReader();
            while (reader.Read())
            {
                if (reader.IsDBNull(0)==false)
                {
                    result.Add(reader.GetString(0));
                }
                
            }
            reader.Close();
            return result.ToArray();

        }
        #endregion
        #region 定义一个类型，用来描述学生的各项信息，后面填充表格用到
        public class StudentInfo
        {
            private string _Name = null;
            public string Name
            {
                get { return _Name; }
                set { _Name = value; }
            }
            private string _age = null;
            public string age
            {
                get { return _age; }
                set { _age = value; }
            }
            private string _hight = null;
            public string hight
            {
                get { return _hight; }
                set { _hight = value; }
            }
            private string _major = null;
            public string major
            {
                get { return _major; }
                set { _major = value; }
            }
            private string _hobby = null;
            public string hobby
            {
                get { return _hobby; }
                set { _hobby = value; }
            }
            private string _homeplace = null;
            public string homeplace
            {
                get { return _homeplace; }
                set { _homeplace = value; }
            }
            private string _ID = null;
            public string ID
            {
                get { return _ID; }
                set { _ID = value; }
            }
        }
        #endregion
        #region 定义一个获取学生各项信息的方法GetInfo()
        public StudentInfo GetInfo(string id)
        {
            SqlConnection con;
            SqlCommand mycommand;
            if (id == null || id.Trim().Length == 0)
            {
                return null;
            }
            StudentInfo result = null;
            using (con = CreateConnection())
            {
                con.Open();
                using (mycommand =con.CreateCommand())
                {
                    mycommand.CommandText = @"select Name,
                                           age,
                                           hight,
                                           major,
                                           hobby,
                                           homeplace,
                                           ID from Student where Name='"+ id+ "'" ;
                    mycommand.Connection = con;
                    SqlDataReader reader = mycommand.ExecuteReader();
                    if (reader.Read())
                    {
                        result = new StudentInfo();
                        if (reader.IsDBNull(0) == false)
                        {
                            result.Name= reader.GetString(0);
                        }
                        if (reader.IsDBNull(1) == false)
                        {
                            result.age = reader.GetString(1);
                        }
                        if (reader.IsDBNull(2) == false)
                        {
                            result.hight = reader.GetString(2);
                        }
                        if (reader.IsDBNull(3) == false)
                        {
                            result.major = reader.GetString(3);
                        }
                        if (reader.IsDBNull(4) == false)
                        {
                            result.hobby= reader.GetString(4);
                        }
                        if (reader.IsDBNull(5) == false)
                        {
                            result.homeplace= reader.GetString(5);
                        }
                        if (reader.IsDBNull(6) == false)
                        {
                            result.ID = reader.GetString(6);
                        }
                        
                    }//end if
                    reader.Close();
                }//end using
                con.Close();
            }//end using
           
            return result;
        }
#endregion

        public Form1()
        {
            InitializeComponent();
        }
        #region 关闭事件
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region 连接数据库及点击事件
        private void sqlconnection_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                lstMessage.Items.Clear();
                string[] ids = this.GetStudentName();
                lstMessage.Items.AddRange(ids);
                label.Text = "连接成功！";
            }
            catch (Exception ext)
            {
                MessageBox.Show(ext.Message);
            }
            this.Cursor = Cursors.Default;
        }
        #endregion
        #region ListBox的SelectdeIndexChanged事件
        private void lstMessage_SelectedIndexChanged(object sender, EventArgs e)
        {
            StudentInfo info = null;
            if (lstMessage.Text != null && lstMessage.Text.Trim().Length > 0)
            {
                try
                {
                    info = this.GetInfo(lstMessage.Text);
                }
                catch (Exception ext)
                {
                    MessageBox.Show(ext.Message);
                }
            }
            if (info == null)
            {
                tbxID.Text = "";
                tbxName.Text = "";
                tbxage.Text = "";
                tbxhight.Text = "";
                tbxhobby.Text = "";
                tbxhomeplace.Text = "";
                tbxmajor.Text = "";
            }
            else
            {
                tbxID.Text = info.ID;
                tbxName.Text = info.Name;
                tbxage.Text = info.age;
                tbxhight.Text = info.hight;
                tbxhobby.Text = info.hobby;
                tbxhomeplace.Text = info.homeplace;
                tbxmajor.Text = info.major;
            }

        }
        #endregion
    }
}
