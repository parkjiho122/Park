using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        class Food
        {
            public string Name { get; set; }
            public int good { get; set; }

            public Food(string _Name, int _good)
            {
                Name = _Name;
                good = _good;
            }

        }
        class Wait
        {
            public string Name2 { get; set; }
            public int waiting_time { get; set; }
            public Wait(string _Name2, int _waiting_time)
            {
                Name2 = _Name2;
                waiting_time = _waiting_time;
            }
        }
        List<int> gd = new List<int>();
        List<string> name = new List<string>();
        List<int> wt_time = new List<int>();
        List<string> name2 = new List<string> ();
        public Form1()
        {
            InitializeComponent();
            Food[] food = new Food[]
            {
                new Food("ㅁㅁㅁ라멘",3),
                new Food("OOO돈가스",6),
                new Food("XX떡볶이",4),
                new Food("OOO우동", 2),
            };
            Wait[] wait = new Wait[]
            {
                new Wait("ㅁㅁㅁ라멘",20),
                new Wait("OOO돈가스",60),
                new Wait("XX떡볶이",20),
                new Wait("OOO우동", 15),
            };

            foreach (var Temp in food)
            {
                gd.Add(Temp.good);
                name.Add(Temp.Name);
            }
            foreach (var Temp2 in wait)
            {
                wt_time.Add(Temp2.waiting_time);
                name2.Add(Temp2.Name2);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           chart1.Series[0].Points.DataBindXY(name, gd);
           chart2.Series[0].Points.DataBindXY(name2, wt_time);
           chart3.Series[0].Points.DataBindXY(name, gd);
           chart4.Series[0].Points.DataBindXY(name2, wt_time);
        }
        
          

        private void btn_start_Click(object sender, EventArgs e)
        {
            page2.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            admin_login.Visible = true;
        }

        private void btn_prev1_Click(object sender, EventArgs e)
        {
            page2.Visible=false;
            user_select.Text = "";
            user_waiting.Text = "";
        }
        private void user_select_TextChanged(object sender, EventArgs e)
        {

        }

        private void user_waiting_TextChanged(object sender, EventArgs e)
        {

        }
        private void btn_submit_Click(object sender, EventArgs e)
        {
            page3.Visible = true;
            //name.Add(user_select.Text);
            //name2.Add(user_select.Text);
            //wt_time.Add(int.Parse(user_waiting.Text));
            //gd.Add(1);
            chart1.Series[0].Points.DataBindXY(name, gd);
            chart2.Series[0].Points.DataBindXY(name2, wt_time);
            chart3.Series[0].Points.DataBindXY(name, gd);
            chart4.Series[0].Points.DataBindXY(name2, wt_time);
            newalram.Text =username.Text + "님이 "+ comboBox1.Text + " 설문조사에 참여하셨습니다.";
            comboselect.Text = comboBox1.Text + " 기준";
        }

        private void user_result_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("다른 유저들의 결과를 보시겠습니까?", "결과 확인", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                page4.Visible = true;
            }
            else
            {
                MessageBox.Show("응답해주셔서 감사합니다.");
                Close();
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            page5.Visible = true;
        }
        private void comboselect_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }
        private void chart2_Click(object sender, EventArgs e)
        {

        }
        private void chart3_Click(object sender, EventArgs e)
        {

        }

        private void chart4_Click(object sender, EventArgs e)
        {

        }

        private void btn_go2first_Click(object sender, EventArgs e)
        {
            name.Add(user_select.Text);
            name2.Add(user_select.Text);
            wt_time.Add(int.Parse(user_waiting.Text));
            gd.Add(1);
            chart3.Series[0].Points.DataBindXY(name, gd);
            chart4.Series[0].Points.DataBindXY(name2, wt_time);
            page5.Visible = false;
            page4.Visible = false;
            page3.Visible = false;
            page2.Visible = false;
            comboBox1.Text = "";
            username.Text = "";
            user_select.Text = "";
            user_waiting.Text = "";

        }

        private void admin_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void admin_passwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_admin_login_Click(object sender, EventArgs e)
        {
            if (admin_id.Text == "admin" && admin_passwd.Text == "0000")
            {
                admin_result.Visible = true;
            }
            else MessageBox.Show("아이디 혹은 비밀번호가 틀렸습니다.");
        }

        private void btn_go2main_Click(object sender, EventArgs e)
        {
            admin_login.Visible = false;
            admin_result.Visible=false;
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            admin_login.Visible=false;
        }

        private void newalram_Click(object sender, EventArgs e)
        {

        }


    }
}
