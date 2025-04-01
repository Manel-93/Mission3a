// ========================================
// FrmTrier.cs
// ========================================
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace mission3A
{
    public partial class FrmTrier : Form
    {
        private gsbrapports2023Entities1 mesDonneesEF;
        private BindingSource bindingSource;

        public FrmTrier()
        {
            InitializeComponent();
            mesDonneesEF = new gsbrapports2023Entities1();
            bindingSource = new BindingSource();

            // Configuration initiale du DataGridView
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.RoyalBlue;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView1.MultiSelect = false;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.DataSource = bindingSource;

            MettreAJourDonnees(false);
        }

        private void MettreAJourDonnees(bool avecSelection)
        {
            try
            {
                // Rafraîchir le contexte
                if (mesDonneesEF != null)
                {
                    mesDonneesEF.Dispose();
                }
                mesDonneesEF = new gsbrapports2023Entities1();

                string nomRecherche = textBox1.Text.ToLower().Trim();
                var resultat = mesDonneesEF.medecins.AsQueryable();

                // Filtrer par nom
                if (!string.IsNullOrEmpty(nomRecherche))
                {
                    resultat = resultat.Where(m => m.nom.ToLower().Contains(nomRecherche));
                }

                // Filtrer par département
                if (!string.IsNullOrEmpty(textBox2.Text))
                {
                    if (int.TryParse(textBox2.Text, out int departement))
                    {
                        resultat = resultat.Where(m => m.departement == departement);
                    }
                }

                // Trier par nom
                resultat = resultat.OrderBy(m => m.nom);

                // Mise à jour de la source de données
                bindingSource.DataSource = resultat.ToList();

                // Sélection automatique du premier élément si demandé
                if (avecSelection && dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.Rows[0].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la mise à jour des données : " + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MettreAJourDonnees(true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Modifier
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var medecinAModifier = dataGridView1.SelectedRows[0].DataBoundItem as medecin;
                if (medecinAModifier != null)
                {
                    using (var formModification = new EditMed(medecinAModifier))
                    {
                        if (formModification.ShowDialog() == DialogResult.OK)
                        {
                            MettreAJourDonnees(false);
                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Supprimer
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    var medecinASupprimer = dataGridView1.SelectedRows[0].DataBoundItem as medecin;
                    if (medecinASupprimer != null && medecinASupprimer.id != 0)
                    {
                        if (MessageBox.Show("Voulez-vous vraiment supprimer ce médecin ?",
                            "Confirmation de suppression",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            var medecinASupp = mesDonneesEF.medecins.Find(medecinASupprimer.id);
                            if (medecinASupp != null)
                            {
                                var rapportsAssocies = mesDonneesEF.rapports.Where(r => r.idMedecin == medecinASupp.id).ToList();
                                mesDonneesEF.rapports.RemoveRange(rapportsAssocies);


                                mesDonneesEF.medecins.Remove(medecinASupp);
                                mesDonneesEF.SaveChanges();
                                MettreAJourDonnees(false);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la suppression : " + ex.Message,
                        "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Ajouter
            var nouveauMedecin = new medecin
            {
                nom = "",
                prenom = "",
                adresse = "",
                tel = "",
                specialiteComplementaire = "",
                departement = 0
            };

            using (var formAjout = new EditMed(nouveauMedecin))
            {
                if (formAjout.ShowDialog() == DialogResult.OK)
                {
                    // Après ajout, recharger la liste
                    MettreAJourDonnees(false);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MettreAJourDonnees(false);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            MettreAJourDonnees(false);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (mesDonneesEF != null)
            {
                mesDonneesEF.Dispose();
            }
        }

        private void FrmTrier_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (var formRapport = new FrmRapport())
            {
                formRapport.ShowDialog();
            }
        }
    }
}
