using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ve.KodeKata.Martian.ExplorerManager;
using Ve.KodeKata.Martian.Model;

namespace Ve.KodeKata.Martian.FormsUI
{
    public partial class FrmMarsOne : Form
    {
        public List<Constants.Movements> movements;
        IExplorerManager _explorerManager;

        public FrmMarsOne(IExplorerManager explorerManager)
        {
            InitializeComponent();
            try
            {
                _explorerManager = explorerManager;
                movements = new List<Constants.Movements>();
                txtHeigth.Text = Constants.DEFAULT_HEIGTH.ToString();
                txtLength.Text = Constants.DEFAULT_LENGTH.ToString();

                _explorerManager._planet.Heigth = int.Parse(txtHeigth.Text);
                _explorerManager._planet.Length = int.Parse(txtHeigth.Text);
                _explorerManager._explorer.CurrentPosition = new Position(Constants.DEFAULT_POSITION_Y, Constants.DEFAULT_POSITION_Y);
                
            }
            catch (Exception ex)
            {
                txtResults.Text = ex.Message.ToString();               
            }
        }

        private void frmMarsOne_Load(object sender, EventArgs e)
        {

        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            movements.Add(Constants.Movements.up);
            ShowMovements();
        }

        private void btnRigth_Click(object sender, EventArgs e)
        {
            movements.Add(Constants.Movements.rigth);
            ShowMovements();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            movements.Add(Constants.Movements.left);
            ShowMovements();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            movements.Add(Constants.Movements.down);
            ShowMovements();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearMovements();
            txtResults.Clear();
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            string error = "";
            WriteLog(string.Format(Constants.CURRENT_POSITION, _explorerManager._explorer.CurrentPosition));
            
            var targetPosition = _explorerManager.Explore(movements, out error);

            StringBuilder result = new StringBuilder();
            if (!string.IsNullOrEmpty(error))
            {
                WriteLog(error);                
            }
            else
            {
                WriteLog(string.Format(Constants.MOVEMENTS_DONE, targetPosition.ToString()));                
            }

            ClearMovements();
            WriteLog(string.Format(Constants.CURRENT_POSITION, _explorerManager._explorer.CurrentPosition));

        }

        private void txtLength_TextChanged(object sender, EventArgs e)
        {
            _explorerManager._planet.Length = int.Parse(txtLength.Text);
        }

        private void txtHeigth_TextChanged(object sender, EventArgs e)
        {
            _explorerManager._planet.Heigth = int.Parse(txtHeigth.Text);
        }

        #region auxiliar
        private void ClearMovements()
        {
            this.movements.Clear();
            ShowMovements();
        }

        public void ShowMovements()
        {
            StringBuilder movs = new StringBuilder();
            foreach (var movement in movements)
            {
                movs.Append(movement.ToString());
                movs.Append(" ");
            }
            txtMovements.Text = movs.ToString().TrimEnd();
        }

        public void WriteLog(string log)
        {
            StringBuilder currentLog = new StringBuilder(txtResults.Text);
            txtResults.Text = currentLog.AppendLine(log).ToString();
        }
        #endregion
    }
}
