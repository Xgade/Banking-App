using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ListBox accountList = new ListBox();
            accountList.Location = new System.Drawing.Point(20, 40);
            accountList.Name = "AccountList";
            accountList.Size = new System.Drawing.Size(200, 200);
            accountList.BackColor = System.Drawing.Color.White;
            accountList.ForeColor = System.Drawing.Color.Black;
            accountList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            Controls.Add(accountList);

            Person person1 = new Person("aaa", "bbb", 69);
            Account acc1 = new Account(123456789, "Acc1 Owner");
            Account acc2 = new Account(24681012, "Acc2 Owner");
            Account acc3 = new Account(36912151, "Acc3 Owner");

            person1.Accounts.Add(acc1);
            person1.Accounts.Add(acc2);
            person1.Accounts.Add(acc3);

            for(int i = 0; i < person1.Accounts.Count; i++)
            {
                accountList.Items.Add(person1.Accounts[i].accountNum);
            }
        }
    }
}