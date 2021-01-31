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
        public Form1()
        {
            InitializeComponent();
        }

        private void questionnaireBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.questionnaireBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.session4_106DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "session4_106DataSet.questionnaire". При необходимости она может быть перемещена или удалена.
            this.questionnaireTableAdapter.Fill(this.session4_106DataSet.questionnaire);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.questionnaireTableAdapter.Fill(this.session4_106DataSet.questionnaire);
            for (int i = 1; i <= questionnaireBindingSource.Count; i++)
            {
                try
                {
                    questionnaireBindingSource.Position = i-1;
                    DataRowView ddd = questionnaireBindingSource.Current as DataRowView;
                    this.questionnaireTableAdapter.UpdateQuery(i, ddd.Row[0].ToString(), ddd.Row[1].ToString(),  ddd.Row[3].ToString(), ddd.Row[5].ToString(), ddd.Row[6].ToString(), ddd.Row[7].ToString(), ddd.Row[8].ToString(),(Int32)(ddd.Row[3]));
                }
                catch { }
                }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
