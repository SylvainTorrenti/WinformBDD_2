using System.ComponentModel;
using System.Xml.Linq;

namespace WinformBDD_2
{
    public partial class frmMain : Form
    {
        db _db = new db();
        BindingList<User> _utils = new();
        public frmMain()
        {
            InitializeComponent();
            InitializeBinding();
        }
        private void btRefresh_Click(object sender, EventArgs e)
        {
            //cr�� un current qui correspond � l'utilisateur selectionner gr�ce au BindingSource
            User current = bsUser.Current as User;
            //efface la collection pour eviter de la r�p�ter 
            _utils.Clear();
            //cr�tion d'une variable qui r�cup�re les donn� r�cup�r� grace a la m�thode GetUtilisateurs()
            var u = _db.GetUtilisateurs();
            //ajout des utilisateurs r�cup�r� dans notre binding list
            foreach (User utilisateur in u)
                _utils.Add(utilisateur);
            //permet de r�cuperer la position de la selection dans le DataGridView
            if (current is not null)
            {
                bsUser.Position = _utils.IndexOf(_utils.Where(u => u.Id == current.Id).FirstOrDefault());
            }
        }
        private void InitializeBinding()
        {
            _utils = new BindingList<User>();
            bsUser.DataSource = _utils;
            dgvUser.DataSource = bsUser;
            tbName.DataBindings.Add("text", bsUser, "Nom", false, DataSourceUpdateMode.Never);
            tbFirstName.DataBindings.Add("text", bsUser, "Prenom", false, DataSourceUpdateMode.Never);
            dtpBirthday.DataBindings.Add("text", bsUser, "DtNaiss", false, DataSourceUpdateMode.Never);
            dgvUser.Columns["Id"].Visible = false;
            dgvUser.Columns["DtNaiss"].HeaderText = "Date de naissance";
            dgvUser.Columns["DtNaiss"].DefaultCellStyle.Format = "D";
            dgvUser.Columns["IdDept"].HeaderText = "D�partement";
        }
    }
}