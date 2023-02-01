using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Diet.DAL.Entities;
using MaterialSkin.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Diet.UI
{
    public partial class Form7 : MaterialForm
    {
        DietAppContext db = new DietAppContext();
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            var query = (from u in db.Activities
                         select new
                         {
                             u.ID,
                             u.ActivityName
                         }).ToList();
            cmbActivities.Items.Add(query);
        }
    }
}
