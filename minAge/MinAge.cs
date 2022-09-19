using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minAge
{
    public partial class MinAge : Form
    {
        List<DateTime> PeapleBirthday=new List<DateTime>();
        public MinAge()
        {
            InitializeComponent();
            StartPosition=FormStartPosition.CenterScreen;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            FullNameTb.Text = "";
            BirthdayDTP.Value = DateTime.Today;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string fio = FullNameTb.Text;
            string birth = BirthdayDTP.Value.ToShortDateString();
            peopleTable.Rows.Add(fio, birth);

            PeapleBirthday.Add(BirthdayDTP.Value);

        }

        private void findMin_Click(object sender, EventArgs e)
        {
            DateTime minDate=DateTime.MaxValue;
            int index = 0;
            for (int i = 0; i < PeapleBirthday.Count; i++)
            {
                DateTime date = PeapleBirthday[i];
                if (date < minDate)
                {
                    index = i;
                    minDate = date;

                }

            }
            MessageBox.Show(peopleTable[0,index].Value.ToString());
        }
    }
}
