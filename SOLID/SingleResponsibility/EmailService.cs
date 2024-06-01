using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class EmailService
    {
        public void SendInfoMail(string subject)
        {
            MessageBox.Show($"{subject} konulu eposta gönderildi");
        }
    }
}
