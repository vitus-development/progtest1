using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;

namespace test_excel
{
    public partial class Ark1
    {
        private void Ark1_Startup(object sender, System.EventArgs e)
        {
        }

        private void Ark1_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(Ark1_Startup);
            this.Shutdown += new System.EventHandler(Ark1_Shutdown);
        }
        
        #endregion

    }
}
