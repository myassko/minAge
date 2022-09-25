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
        List<Person> people = new List<Person>();
        public MinAge()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        public void Clear()
        {
            FullNameTb.Text = "";
            BirthdayDTP.Value = DateTime.Today;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string fio = FullNameTb.Text;
            string birth = BirthdayDTP.Value.ToShortDateString();
            string[] datePersonSplit = birth.Split('.');
            if (string.IsNullOrEmpty(fio))
            {
                MessageBox.Show("Вы некорректно вписали ФИО");
                return;
            }
            peopleTable.Rows.Add(fio, birth);





            DateOfBirth datePerson = new DateOfBirth(int.Parse(datePersonSplit[0]), int.Parse(datePersonSplit[1]),
                int.Parse(datePersonSplit[2]));
            Person person = new Person(fio, datePerson);

            people.Add(person);


            Clear();



        }

        private void findMin_Click(object sender, EventArgs e)
        {
            DateOfBirth minDate = DateOfBirth.MinBirth;
            Person ans = new Person();
            for (int i = 0; i < people.Count; i++)
            {
                Person man = people[i];
                DateOfBirth date = man.BirthDate;
                var a = DateOfBirth.CompareDate(minDate, date);

                if (a == 1)
                {
                    ans = man;
                    minDate = man.BirthDate;
                }


            }

            MessageBox.Show(ans.ToString());
        }
    }
}
