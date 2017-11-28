using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CompanyManagement
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=127.0.0.1,14331;Database=Test;Integrated Security=SSPI;";
        ArrayList companyDataList, workerDataList; //Company, Worker 클래스
        ArrayList workerDataViewList; //WorkerData 클래스
        ArrayList companyCheckList, workerCheckList; //int(index)
        bool change = true;

        public Form1() { InitializeComponent(); }

        //초기화 & DB 정보 불러오기 & DataGridView 세팅
        private void Form1_Load(object sender, EventArgs e)
        {
            //초기화
            companyDataList = new ArrayList();
            workerDataList = new ArrayList();

            dataGridViewCompany.Columns["ColumnNameCompany"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewCompany.Columns["ColumnPhoneCompany"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewCompany.Columns["ColumnAddressCompany"].SortMode = DataGridViewColumnSortMode.NotSortable;
            
            dataGridViewWorker.Columns["ColumnNameWorker"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewWorker.Columns["ColumnPhoneWorker"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewWorker.Columns["ColumnAddressWorker"].SortMode = DataGridViewColumnSortMode.NotSortable;
            
            try
            {
                //DB 정보 불러오기
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand("SELECT * FROM Table_Company ORDER BY Name ASC;", connection);
                connection.Open();

                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read()) { companyDataList.Add(new Company(dataReader["Name"] as string, dataReader["Phone"] as string, dataReader["Address"] as string)); }
                dataReader.Close();

                command = new SqlCommand("SELECT Name, Phone, Address, Company FROM Table_Worker ORDER BY Name ASC;", connection);
                dataReader = command.ExecuteReader();

                while (dataReader.Read()) { workerDataList.Add(new Worker(dataReader["Name"] as string, dataReader["Phone"] as string,
                    dataReader["Address"] as string, dataReader["Company"] as string)); }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "DB 연결 오류", MessageBoxButtons.OK);
                change = false;
                this.Close();
            }

            //DataGridView 세팅
            dataGridViewCompany.Rows.Clear();
            for (int i = 0; i < companyDataList.Count; i++)
                dataGridViewCompany.Rows.Add(new string[] { ((Company)companyDataList[i]).name, ((Company)companyDataList[i]).phone, ((Company)companyDataList[i]).address });

            textCompanyName.Text = ""; textCompanyPhone.Text = ""; textCompanyAddress.Text = "";
            WorkerUpdateData();
            change = false;
        }

        //dataGridViewCompany의 선택된 셀 체크
        private void selectedCheckCompany()
        {
            companyCheckList = new ArrayList();
            for (int i = 0; i < dataGridViewCompany.RowCount; i++)
            {
                bool flag=false;
                for (int j = 0; j < 3; j++)
                {
                    if (dataGridViewCompany.Rows[i].Cells[j].Selected)
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag) companyCheckList.Add(i);
            }
            WorkerUpdateData();
        }

        //company 데이터 입력
        private void buttonCompanyAdd_Click(object sender, EventArgs e)
        {
            if (textCompanyName.Text == "" || textCompanyPhone.Text == "" || textCompanyAddress.Text == "")
            {
                MessageBox.Show("내용을 모두 채워 넣어 주세요.", "입력 안내", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (Company comp in companyDataList)
            {
                if (comp.name == textCompanyName.Text)
                {
                    MessageBox.Show("중복되는 회사명이 있습니다.", "입력 안내", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            companyDataList.Add(new Company(textCompanyName.Text,textCompanyPhone.Text,textCompanyAddress.Text));
            dataGridViewCompany.Rows.Add(new string[]{ ((Company)companyDataList[companyDataList.Count - 1]).name,
                ((Company)companyDataList[companyDataList.Count - 1]).phone, ((Company)companyDataList[companyDataList.Count - 1]).address });
            textCompanyName.Text = ""; textCompanyPhone.Text = ""; textCompanyAddress.Text = "";
            change = true;
        }

        //company 데이터 수정
        private void buttonCompanyUpdate_Click(object sender, EventArgs e)
        {
            if (textCompanyName.Text == "" && textCompanyPhone.Text == "" && textCompanyAddress.Text == "")
            {
                MessageBox.Show("수정할 데이터를 입력해주세요.", "입력 안내", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (companyCheckList.Count == 0)
            {
                MessageBox.Show("수정할 데이터를 선택해주세요.", "입력 안내", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (companyCheckList.Count > 1)
            {
                MessageBox.Show("수정할 데이터를 1개만 선택해주세요.", "입력 안내", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int checkIndex = (int)companyCheckList[0];
            if (textCompanyName.Text != "")
            {
                for (int i = 0; i < companyDataList.Count; i++)
                {
                    if (((Company)companyDataList[i]).name == textCompanyName.Text)
                    {
                        MessageBox.Show("중복되는 회사명이 있습니다.", "입력 안내", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                ((Company)companyDataList[checkIndex]).name = textCompanyName.Text;
                for (int i = 0; i < workerDataList.Count; i++)
                {
                    if (((Worker)workerDataList[i]).company == ((Company)companyDataList[checkIndex]).name) ((Worker)workerDataList[i]).company = textCompanyName.Text;
                }
                ((Company)companyDataList[checkIndex]).name = textCompanyName.Text;
            }
            if (textCompanyPhone.Text != "") ((Company)companyDataList[checkIndex]).phone = textCompanyPhone.Text;
            if (textCompanyAddress.Text != "") ((Company)companyDataList[checkIndex]).address = textCompanyAddress.Text;
            dataGridViewCompany.Rows[checkIndex].SetValues(new Object[]{ ((Company)companyDataList[checkIndex]).name, 
                ((Company)companyDataList[checkIndex]).phone, ((Company)companyDataList[checkIndex]).address });
            textCompanyName.Text = ""; textCompanyPhone.Text = ""; textCompanyAddress.Text = "";
            change = true;
        }

        //company 데이터 삭제
        private void buttonCompanyDelete_Click(object sender, EventArgs e)
        {
            if (companyCheckList.Count == 0)
            {
                MessageBox.Show("삭제할 데이터를 선택해주세요.", "입력 안내", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string messageName = "";
            foreach (int i in companyCheckList) messageName += ((Company)companyDataList[i]).name + " ";

            if (MessageBox.Show(messageName + "의 데이터를 삭제하시겠습니까?\n해당 회사의 사원들도 같이 삭제됩니다.", "삭제 안내",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                for (int i = 0; i < workerDataList.Count; i++)
                {
                    for (int j = 0; j < companyCheckList.Count; j++)
                    {
                        if (((Worker)workerDataList[i]).company == ((Company)companyDataList[(int)companyCheckList[j]]).name)
                        {
                            workerDataList.RemoveAt(i--);
                            break;
                        }
                    }
                }

                ArrayList tempList = companyCheckList;
                while (tempList.Count > 0)
                {
                    companyDataList.RemoveAt((int)companyCheckList[0]);
                    dataGridViewCompany.Rows.RemoveAt((int)companyCheckList[0]);
                    tempList.RemoveAt(0);
                }
                selectedCheckCompany();
                WorkerUpdateData();
                change = true;
            }
        }

        //dataGridViewCompany 위치 수정
        private void dataGridViewCompany_SelectionChanged(object sender, EventArgs e) { selectedCheckCompany(); }

        //dataGridViewWorker 갱신
        private void WorkerUpdateData()
        {
            dataGridViewWorker.Rows.Clear();
            workerDataViewList = new ArrayList();
            for (int i = 0; i < workerDataList.Count; i++)
            {
                bool flag = false;
                for (int j = 0; j < companyCheckList.Count; j++)
                {
                    if (((Worker)workerDataList[i]).company == ((Company)companyDataList[(int)companyCheckList[j]]).name)
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag)
                {
                    workerDataViewList.Add(new WorkerData(i + 1, ((Worker)workerDataList[i]).name, ((Worker)workerDataList[i]).phone, ((Worker)workerDataList[i]).address));
                    dataGridViewWorker.Rows.Add(new string[]{ ((Worker)workerDataList[i]).name, ((Worker)workerDataList[i]).phone, ((Worker)workerDataList[i]).address });
                }
            }
            textWorkerName.Text = ""; textWorkerPhone.Text = ""; textWorkerAddress.Text = "";
            return;
        }

        //dataGridViewWorker의 선택된 셀 체크
        private void selectedCheckWorker()
        {
            workerCheckList = new ArrayList();
            for (int i = 0; i < dataGridViewWorker.RowCount; i++)
            {
                bool flag = false;
                for (int j = 0; j < 3; j++)
                {
                    if (dataGridViewWorker.Rows[i].Cells[j].Selected == true)
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag) workerCheckList.Add(i);
            }
        }

        //worker 데이터 입력
        private void buttonWorkerAdd_Click(object sender, EventArgs e)
        {
            if (textWorkerName.Text == "" || textWorkerPhone.Text == "" || textWorkerAddress.Text == "")
            {
                MessageBox.Show("내용을 모두 채워 넣어 주세요.", "입력 안내", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (Worker work in workerDataList)
            {
                if (work.name == textWorkerName.Text)
                {
                    MessageBox.Show("중복되는 회사명이 있습니다.", "입력 안내", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (MessageBox.Show("회사는 " + ((Company)companyDataList[(int)companyCheckList[0]]).name + "로 추가됩니다.", "입력 안내",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                workerDataList.Add(new Worker(textWorkerName.Text, textWorkerPhone.Text, textWorkerAddress.Text, ((Company)companyDataList[(int)companyCheckList[0]]).name));
                workerDataViewList.Add(new WorkerData(workerDataList.Count - 1, textWorkerName.Text, textWorkerPhone.Text, textWorkerAddress.Text));
                dataGridViewWorker.Rows.Add(new string[] { textWorkerName.Text, textWorkerPhone.Text, textWorkerAddress.Text });
                textWorkerName.Text = ""; textWorkerPhone.Text = ""; textWorkerAddress.Text = "";
                change = true;
            }
        }

        //worker 데이터 수정
        private void buttonWorkerUpdate_Click(object sender, EventArgs e)
        {
            if (textWorkerName.Text == "" && textWorkerPhone.Text == "" && textWorkerAddress.Text == "")
            {
                MessageBox.Show("수정할 데이터를 입력해주세요.", "입력 안내", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (workerCheckList.Count == 0)
            {
                MessageBox.Show("수정할 데이터를 선택해주세요.", "입력 안내", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (workerCheckList.Count > 1)
            {
                MessageBox.Show("수정할 데이터를 1개만 선택해주세요.", "입력 안내", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int checkIndex = (int)workerCheckList[0];
            int id = ((WorkerData)workerDataViewList[checkIndex]).id;
            if (textWorkerName.Text != "")
            {
                ((WorkerData)workerDataViewList[checkIndex]).name = textWorkerName.Text;
                ((Worker)workerDataList[id - 1]).name = textWorkerName.Text;
            }
            if (textWorkerPhone.Text != "")
            {
                ((WorkerData)workerDataViewList[checkIndex]).phone = textWorkerPhone.Text;
                ((Worker)workerDataList[id - 1]).phone = textWorkerPhone.Text;
            }
            if (textWorkerAddress.Text != "")
            {
                ((WorkerData)workerDataViewList[checkIndex]).address = textWorkerAddress.Text;
                ((Worker)workerDataList[id - 1]).address = textWorkerAddress.Text;
            }
            dataGridViewWorker.Rows[checkIndex].SetValues(new Object[]{ ((Worker)workerDataList[id-1]).name,
                ((Worker)workerDataList[id-1]).phone, ((Worker)workerDataList[id-1]).address });
            textWorkerName.Text = ""; textWorkerPhone.Text = ""; textWorkerAddress.Text = "";
            change = true;
        }

        //worker 데이터 삭제
        private void buttonWorkerDelete_Click(object sender, EventArgs e)
        {
            if (workerCheckList.Count == 0)
            {
                MessageBox.Show("삭제할 데이터를 선택해주세요.", "입력 안내", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string messageName = "";
            foreach (int i in workerCheckList) messageName += ((WorkerData)workerDataViewList[i]).name + " ";

            if (MessageBox.Show(messageName + "님의 데이터를 삭제하시겠습니까?", "삭제 안내",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int i = 0;
                ArrayList tempList = workerCheckList;
                while (tempList.Count > 0)
                {
                    i++;
                    int index = (int)workerCheckList[0];
                    workerDataList.RemoveAt(((WorkerData)workerDataViewList[index]).id - i);
                    workerDataViewList.RemoveAt(index);
                    dataGridViewWorker.Rows.RemoveAt(index);
                    tempList.RemoveAt(0);
                }
                selectedCheckWorker();
                change = true;
            }
        }

        //dataGridViewWorker 위치 수정
        private void dataGridViewWorker_SelectionChanged(object sender, EventArgs e) { selectedCheckWorker(); }

        //데이터 갱신
        private void DataBaseSave()
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                SqlCommand command = new SqlCommand("DELETE FROM Table_Company;", connection);
                command.ExecuteNonQuery();
                command = new SqlCommand("DELETE FROM Table_Worker;", connection);
                command.ExecuteNonQuery();
                for (int i = 0; i < companyDataList.Count; i++)
                {
                    command = new SqlCommand(
                        "INSERT INTO Table_Company VALUES(@Name, @Phone, @Address);", connection);
                    command.Parameters.AddWithValue("Name", ((Company)companyDataList[i]).name);
                    command.Parameters.AddWithValue("Phone", ((Company)companyDataList[i]).phone);
                    command.Parameters.AddWithValue("Address", ((Company)companyDataList[i]).address);
                    command.ExecuteNonQuery();
                }

                for (int i = 0; i < workerDataList.Count; i++)
                {
                    command = new SqlCommand(
                        "INSERT INTO Table_Worker VALUES(@ID ,@Name, @Phone, @Address, @Company);", connection);
                    command.Parameters.AddWithValue("ID", i + 1);
                    command.Parameters.AddWithValue("Name", ((Worker)workerDataList[i]).name);
                    command.Parameters.AddWithValue("Phone", ((Worker)workerDataList[i]).phone);
                    command.Parameters.AddWithValue("Address", ((Worker)workerDataList[i]).address);
                    command.Parameters.AddWithValue("Company", ((Worker)workerDataList[i]).company);
                    command.ExecuteNonQuery();
                }

                connection.Close();
                change = false;
            }
            catch (Exception execption)
            {
                MessageBox.Show(execption.ToString(), "DB 연결 오류", MessageBoxButtons.OK);
            }
        }

        //Event 핸들러
        private void buttonSave_Click(object sender, EventArgs e) { if (change) DataBaseSave(); }

        //닫힐 때
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (change && MessageBox.Show("변경하신 내용을 저장하시겠습니까?", "종료 안내", MessageBoxButtons.YesNo) == DialogResult.Yes) DataBaseSave();
        }
    }
    
    public class Company
    {
        public string name { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public Company(string _name, string _phone, string _address)
        { name = _name; phone = _phone; address = _address; }
    }
    
    public class Worker
    {
        public string name { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string company { get; set; }
        public Worker(string _name, string _phone, string _address, string _company)
        { name = _name; phone = _phone; address = _address; company = _company; }
    }
    
    public class WorkerData
    {
        public int id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public WorkerData(int _id, string _name, string _phone, string _address)
        { name = _name; phone = _phone; address = _address; id = _id; }
    }
}