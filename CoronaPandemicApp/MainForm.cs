using Bussinesslogic;
using BussinessObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoronaPandemicApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            UserBO objUBO = new UserBO();
            /*
             calling BussinessObject (UserBO) 
             And passing all value from Control to it.
            */

            objUBO.Name = "Abc";
            

            UserBL objUBL = new UserBL();

            int result = objUBL.SaveUserregisrationBL(objUBO);
        }
    }
}
