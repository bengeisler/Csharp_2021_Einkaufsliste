using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Einkaufsliste
{
	public partial class frmEinkaufsliste : Form
	{
		public frmEinkaufsliste()
		{
			InitializeComponent();
		}

		private void btnHinzufügen_Click(object sender, EventArgs e)
		{
			// Neuen Eintrag in der richtigen Formatierung hinzufügen
			lstToDo.Items.Add(txtAnzahl.Text + "x " + txtBeschreibung.Text);

			// Eingabefelder leeren
			txtAnzahl.Text = "";
			txtBeschreibung.Text = "";

			// Bonus: Status anzeigen
			StatusAusgeben();

			// Bonus: Fokus wieder in das erste Eingabefeld setzen
			txtAnzahl.Focus();
		}

		private void btnLöschen_Click(object sender, EventArgs e)
		{
			// Wichtig: Als erstes prüfen, ob ein Item ausgewählt wurde
			if (lstToDo.SelectedItem != null)
			{
				// Ausgewähltes Item entfernen
				lstToDo.Items.Remove(lstToDo.SelectedItem);

				// Bonus: Status anzeigen
				StatusAusgeben();
			}
		}

		private void btnWurdeErledigt_Click(object sender, EventArgs e)
		{
			// Wichtig: Als erstes prüfen, ob ein Item ausgewählt wurde
			if (lstToDo.SelectedItem != null)
			{
				// Ausgewähltes Item der lstToDo der lstErledigt hinzufügen
				lstErledigt.Items.Add(lstToDo.SelectedItem);

				// Ausgewähltes Item aus der lstToDo löschen
				lstToDo.Items.Remove(lstToDo.SelectedItem);

				// Bonus: Status ausgeben
				StatusAusgeben();
			}
		}

		private void btnNichtErledigt_Click(object sender, EventArgs e)
		{
			// Wichtig: Als erstes prüfen, ob ein Item ausgewählt wurde
			if (lstErledigt.SelectedItem != null)
			{
				// Ausgewähltes Item der lstErledigt der lstToDo hinzufügen
				lstToDo.Items.Add(lstErledigt.SelectedItem);

				// Ausgewähltes Item aus der lstErledigt löschen
				lstErledigt.Items.Remove(lstErledigt.SelectedItem);

				// Bonus: Status ausgeben
				StatusAusgeben();
			}
		}

		private void btnAlleLöschen_Click(object sender, EventArgs e)
		{
			// Alle Elemente aus beiden Listen löschen
			lstToDo.Items.Clear();
			lstErledigt.Items.Clear();

			// Bonus: Status ausgeben
			StatusAusgeben();
		}

		private void btnBeenden_Click(object sender, EventArgs e)
		{
			// Anwendung beenden
			Close();
		}

		// Bonus: Status ausgeben
		private void StatusAusgeben()
		{
			var anzahlErledigt = lstErledigt.Items.Count;
			var anzahlGesamt = lstToDo.Items.Count + lstErledigt.Items.Count;

			lblErgebnis.Text =
				anzahlErledigt +
				" / " +
				anzahlGesamt +
				" Produkte wurden schon eingekauft.";
		}

		// Bonus: Eingabe auch bei Drücken der Enter-Taste im Feld txtBeschreibung hinzufügen
		// Diese Methode wurde automatisch erstellt, indem man in das Ereignis "KeyDown" der "txtBeschreibung" doppelklickt.
		private void txtBeschreibung_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				btnHinzufügen_Click(sender, e);
				// Alternativen:
				// - eigene Funktion "Hinzufügen" erstellen, die sowohl in txtBeschreibung_KeyDown
				//   als auch in btnHinzufügen_Click aufgerufen wird und die Funktionalität zum
				//   Hinzufügen von Elementen besitzt
				//
				// - btnHinzufügen_Click(null, null)
				//   => die Informationen sender und e, die auf das Objekt verweisen, welches das Ereignis
				//      ausgelöst haben, werden, werden in btnHinzufügen_Click nicht verwendet.
				//      Daher ist es ausreichend, "null" als Platzhalter zu übergeben.
			}
		}

		// Bonus: Status anzeigen
		private void frmEinkaufsliste_Load(object sender, EventArgs e)
		{
			StatusAusgeben();
		}
	}
}
