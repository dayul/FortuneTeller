using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FortuneTeller
{
    public partial class Form1 : Form
    {
        List<string> results;

        public Form1()
        {
            InitializeComponent();
            LoadResults();
        }

        private void LoadResults()
        {
            try
            {
                string filename = "results.csv";
                results = File.ReadAllLines(filename).ToList();
            }
            catch(FileNotFoundException ex)
            {
                MessageBox.Show($"파일이 없어요. \n{ex.Message}", "파일이 없는 오류!");
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show($"권한이 없어요. \n{ex.Message}", "파일 권한 오류!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"알 수 없는 오류가 발생했어요 \n{ex.Message}", "알 수 없는 오류!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void 상담내역불러오기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 새 창을 실행 시켜도 기존 창 조작 가능
            FormHistory form = Application.OpenForms["FormHistory"] as FormHistory;
            if(form != null)
            {
                form.Activate();    // 최상위로 포커싱
            }
            else
            {
                form = new FormHistory(this);
                form.Show();
            }
        }

        // 운세 가져오기
        public string GetFortune()
        {
            Random random = new Random();
            int index = random.Next(results.Count);
            return results[index];
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 포츈텔러정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout form = new FormAbout();
            // 새 창을 실행 시키면 기존 창 조작 불가능
            form.ShowDialog();
        }

        // 운세 결과 보기 이벤트 핸들러
        private void btnShowResult_Click(object sender, EventArgs e)
        {
            string birthday = tbBirthday.Text;
            string birthtime = tbBirthtime.Text;
            string result = GetFortune();
            string saju = result.Split('|')[0];
            string message = result.Split('|')[1];
            tbResult.Text = birthday + " " + birthtime + Environment.NewLine
                + saju + Environment.NewLine
                + message;

            SaveHistory($"{birthday} {birthtime}|{result}");

            // 클릭 개선
            FormHistory form = Application.OpenForms["FormHistory"] as FormHistory;
            if (form != null)
            {
                form.UpdateHistory();
            }
        }

        // 상담 내역 저장
        private void SaveHistory(string history)
        {
            try
            {
                string filename = "history.csv";
                File.AppendAllText(filename, history + Environment.NewLine);
            }
            catch(UnauthorizedAccessException ex)
            {
                MessageBox.Show($"권한이 없어요. \n{ex.Message}", "파일 권한 오류!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"상담 내역 저장 중 오류가 발생했어요. \n{ex.Message}", "알 수 없는 오류!");
            }
        }

        internal void LoadHistory(string history)
        {
            string birthday = history.Split('|')[0].Split(' ')[0];
            string birthtime = history.Split('|')[0].Split(' ')[1];

            tbBirthday.Text = birthday;
            tbBirthtime.Text = birthtime;
            string saju = history.Split('|')[1];
            string message = history.Split('|')[2];

            tbResult.Text = birthday + " " + birthtime + Environment.NewLine
                + saju + Environment.NewLine
                + message;
        }
    }
}
