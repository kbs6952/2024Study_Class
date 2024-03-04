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

namespace Database_Test
{
    public partial class Form1 : Form
    {
        // Row - Table - Set 데이터가 저장되는 크기에 따라서 분류 잠시 소개를 드렸습니다.
        DataSet ds = new DataSet();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            IDText.Text = "";
            NameText.Text = "";
            RaceText.Text = "";
            RegionSelectBox.Text = "";
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            bool checkIsTable = false;

            if (ds.Tables.Contains(RegionSelectBox.Text)) // 키값이 이미 존재합니다.
            {
                checkIsTable = true;
            }

            // bool 이 True이면 이미 생성한 데이터가 있으니까 그 데이터를 불러와서 추가로 데이터를 만들어 주면 되고
            // bool 이 false이면 처음 생성한 데이터가 이기 때문에 새롭게 데이터를 생성해주면 됩니다.

            // DataSet - DataTable - DataRow, DataColumn 생성
            DataTable dt = null;

            if (!checkIsTable)
            {
                // 데이터가 없을 경우에는 새롭게 데이터를 만들어 준다.
                dt = new DataTable(listBox.Text);

                DataColumn columnID = new DataColumn("ID", typeof(string));
                DataColumn columnName = new DataColumn("Name", typeof(string));
                DataColumn columnRace = new DataColumn("Race", typeof(string));
                DataColumn columnRegion = new DataColumn("Region", typeof(string));

                dt.Columns.Add(columnID);
                dt.Columns.Add(columnName);
                dt.Columns.Add(columnRace);
                dt.Columns.Add(columnRegion);
            }
            else
            {
                dt = ds.Tables[RegionSelectBox.Text];
            }

            // 생성할 데이터를 Row에 입력을 한 후
            DataRow row = dt.NewRow();
            row["ID"] = IDText.Text;
            row["Name"] = NameText.Text;
            row["Race"] = RaceText.Text;
            row["Region"] = RegionSelectBox.Text;

            // 데이터 테이블이 이미 존재한다면 기존 테이블을 불러온 후 새로운 데이터를 이어서 추가 해주고
            if (checkIsTable)
            {
                ds.Tables[RegionSelectBox.Text].Rows.Add(row);
            }
            else
            {
                // 테이블이 존재 하지 않는다면 row를 table에 추가해주면 된다.
                dt.Rows.Add(row);
                ds.Tables.Add(dt);

            }

            // 생성한 데이터를 볼 수 있게 View
            ViewRefresh();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            int selectRow = dataGridViewInfo.SelectedRows[0].Index;

            ds.Tables[RegionSelectBox.Text].Rows.RemoveAt(selectRow);

            ViewRefresh();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewInfo.DataSource = ds.Tables[listBox.Text];

            foreach(DataGridViewRow row in dataGridViewInfo.Rows)
            {
                row.HeaderCell.Value = row.Index.ToString();
            }
        }

        private void ViewRefresh()
        {
            dataGridViewInfo.DataSource = ds.Tables[listBox.Text];

            foreach (DataGridViewRow row in dataGridViewInfo.Rows)
            {
                row.HeaderCell.Value = row.Index.ToString();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //TextWriter writer = new StreamWriter(@"C:\Sample\Text.txt");

            //for (int i = 0; i < dataGridViewInfo.Rows.Count - 1; i++)
            //{
            //    for(int j = 0; j< dataGridViewInfo.Columns.Count; j++)
            //    {
            //        writer.Write("\t" + dataGridViewInfo.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
            //    }
            //    writer.WriteLine();
            //}

            //writer.Close();

            DataManager.SaveToJson(dataGridViewInfo, @"C:\Sample\SampeJson.json", listBox.Text);

            MessageBox.Show("Json 데이터가 저장 되었음");
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            DataTable dt = DataManager.LoadToJson(@"C:\Sample\SampeJson.json").dt;
            dt.TableName = DataManager.LoadToJson(@"C:\Sample\SampeJson.json").tableName;
            ds.Tables.Add(dt);

            ViewRefresh();
        }
    }
}
