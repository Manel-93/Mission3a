// ========================================
// EditMed.cs
// ========================================
using System;
using System.Linq;
using System.Windows.Forms;
    
namespace mission3A
{
    public partial class EditMed : Form
    {
        private medecin medecinAModifier;
        private gsbrapports2023Entities1 mesDonneesEF;
        private bool estNouveauMedecin;

        public EditMed(medecin medecin)
        {
            InitializeComponent();
            mesDonneesEF = new gsbrapports2023Entities1();

            // Si l'ID est 0, on considère que c'est un nouveau médecin
            if (medecin.id == 0)
            {
                medecinAModifier = medecin;
                estNouveauMedecin = true;
            }
            else
            {
                // Charger depuis la BD pour être sûr d'avoir une version à jour
                var medExist = mesDonneesEF.medecins.Find(medecin.id);
                if (medExist != null)
                {
                    medecinAModifier = medExist;
                    estNouveauMedecin = false;
                }
                else
                {
                    // Si non trouvé, on prend celui fourni, c'est un cas rare
                    medecinAModifier = medecin;
                    estNouveauMedecin = false;
                }
            }

            ConfigurerFormulaire();
            ChargerDonneesMedecin();
        }

        private void ConfigurerFormulaire()
        {
            if (estNouveauMedecin)
            {
                this.Text = "Ajouter un nouveau médecin";
                label7.Text = "Ajout d'un nouveau médecin";
                modifier.Visible = false;
                ajouter.Visible = true;
            }
            else
            {
                this.Text = "Modifier un médecin";
                label7.Text = "Modification d'un médecin";
                modifier.Visible = true;
                ajouter.Visible = false;
            }
        }

        private void ChargerDonneesMedecin()
        {
            txtnommedecin.Text = medecinAModifier.nom;
            txtprenommedecin.Text = medecinAModifier.prenom;
            txtadresse.Text = medecinAModifier.adresse;
            txtnumtel.Text = medecinAModifier.tel;
            txtdepartement.Text = medecinAModifier.departement.ToString();

            var specialites = mesDonneesEF.medecins
                .Where(m => m.specialiteComplementaire != null && m.specialiteComplementaire != "")
                .Select(m => m.specialiteComplementaire)
                .Distinct()
                .ToList();

            txtspecialite.Items.Clear();
            foreach (var specialite in specialites)
            {
                txtspecialite.Items.Add(specialite);
            }

            if (!string.IsNullOrEmpty(medecinAModifier.specialiteComplementaire))
            {
                int index = txtspecialite.Items.IndexOf(medecinAModifier.specialiteComplementaire);
                if (index >= 0)
                {
                    txtspecialite.SelectedIndex = index;
                }
                else
                {
                    txtspecialite.Items.Add(medecinAModifier.specialiteComplementaire);
                    txtspecialite.SelectedIndex = txtspecialite.Items.Count - 1;
                }
            }
        }

        private bool ValideDonnees()
        {
            if (string.IsNullOrWhiteSpace(txtnommedecin.Text))
            {
                MessageBox.Show("Le nom du médecin est obligatoire", "Erreur de validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtnommedecin.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtprenommedecin.Text))
            {
                MessageBox.Show("Le prénom du médecin est obligatoire", "Erreur de validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtprenommedecin.Focus();
                return false;
            }

            if (!int.TryParse(txtdepartement.Text, out _))
            {
                MessageBox.Show("Le département doit être un nombre valide", "Erreur de validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdepartement.Focus();
                return false;
            }

            return true;
        }

        private void SauvegarderMedecin()
        {
            if (!ValideDonnees()) return;

            try
            {
                medecinAModifier.nom = txtnommedecin.Text;
                medecinAModifier.prenom = txtprenommedecin.Text;
                medecinAModifier.adresse = txtadresse.Text;
                medecinAModifier.tel = txtnumtel.Text;
                medecinAModifier.specialiteComplementaire = txtspecialite.Text ?? "";
                medecinAModifier.departement = int.Parse(txtdepartement.Text);

                if (estNouveauMedecin)
                {
                    // Ajout
                    mesDonneesEF.medecins.Add(medecinAModifier);
                }
                else
                {
                    // Modification
                    var medExistant = mesDonneesEF.medecins.Find(medecinAModifier.id);
                    if (medExistant != null)
                    {
                        mesDonneesEF.Entry(medExistant).CurrentValues.SetValues(medecinAModifier);
                    }
                }

                mesDonneesEF.SaveChanges();

                MessageBox.Show(estNouveauMedecin ? "Nouveau médecin ajouté avec succès" : "Modifications enregistrées avec succès",
                    "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'enregistrement : " + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            SauvegarderMedecin();
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            SauvegarderMedecin();
        }

        private void EditMed_Load(object sender, EventArgs e)
        {
            // Code d'initialisation supplémentaire si nécessaire
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // Personnalisation du panel si nécessaire
        }
    }
}
