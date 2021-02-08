
namespace Einkaufsliste
{
	partial class frmEinkaufsliste
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.txtAnzahl = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtBeschreibung = new System.Windows.Forms.TextBox();
			this.btnHinzufügen = new System.Windows.Forms.Button();
			this.lstToDo = new System.Windows.Forms.ListBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lstErledigt = new System.Windows.Forms.ListBox();
			this.lblErgebnis = new System.Windows.Forms.Label();
			this.btnLöschen = new System.Windows.Forms.Button();
			this.btnAlleLöschen = new System.Windows.Forms.Button();
			this.btnBeenden = new System.Windows.Forms.Button();
			this.btnWurdeErledigt = new System.Windows.Forms.Button();
			this.btnNichtErledigt = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Anzahl:";
			// 
			// txtAnzahl
			// 
			this.txtAnzahl.Location = new System.Drawing.Point(16, 30);
			this.txtAnzahl.Name = "txtAnzahl";
			this.txtAnzahl.Size = new System.Drawing.Size(56, 20);
			this.txtAnzahl.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(88, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Beschreibung:";
			// 
			// txtBeschreibung
			// 
			this.txtBeschreibung.Location = new System.Drawing.Point(91, 30);
			this.txtBeschreibung.Name = "txtBeschreibung";
			this.txtBeschreibung.Size = new System.Drawing.Size(231, 20);
			this.txtBeschreibung.TabIndex = 3;
			this.txtBeschreibung.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBeschreibung_KeyDown);
			// 
			// btnHinzufügen
			// 
			this.btnHinzufügen.Location = new System.Drawing.Point(328, 28);
			this.btnHinzufügen.Name = "btnHinzufügen";
			this.btnHinzufügen.Size = new System.Drawing.Size(75, 23);
			this.btnHinzufügen.TabIndex = 4;
			this.btnHinzufügen.Text = "Hinzufügen";
			this.btnHinzufügen.UseVisualStyleBackColor = true;
			this.btnHinzufügen.Click += new System.EventHandler(this.btnHinzufügen_Click);
			// 
			// lstToDo
			// 
			this.lstToDo.FormattingEnabled = true;
			this.lstToDo.Location = new System.Drawing.Point(16, 103);
			this.lstToDo.Name = "lstToDo";
			this.lstToDo.Size = new System.Drawing.Size(214, 290);
			this.lstToDo.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(16, 77);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(214, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "ToDo";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(282, 77);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(214, 23);
			this.label4.TabIndex = 8;
			this.label4.Text = "Erledigt";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lstErledigt
			// 
			this.lstErledigt.FormattingEnabled = true;
			this.lstErledigt.Location = new System.Drawing.Point(282, 103);
			this.lstErledigt.Name = "lstErledigt";
			this.lstErledigt.Size = new System.Drawing.Size(214, 290);
			this.lstErledigt.TabIndex = 7;
			// 
			// lblErgebnis
			// 
			this.lblErgebnis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblErgebnis.Location = new System.Drawing.Point(16, 412);
			this.lblErgebnis.Name = "lblErgebnis";
			this.lblErgebnis.Size = new System.Drawing.Size(493, 23);
			this.lblErgebnis.TabIndex = 9;
			this.lblErgebnis.Text = "label5";
			this.lblErgebnis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnLöschen
			// 
			this.btnLöschen.Location = new System.Drawing.Point(16, 454);
			this.btnLöschen.Name = "btnLöschen";
			this.btnLöschen.Size = new System.Drawing.Size(75, 23);
			this.btnLöschen.TabIndex = 10;
			this.btnLöschen.Text = "Löschen";
			this.btnLöschen.UseVisualStyleBackColor = true;
			this.btnLöschen.Click += new System.EventHandler(this.btnLöschen_Click);
			// 
			// btnAlleLöschen
			// 
			this.btnAlleLöschen.Location = new System.Drawing.Point(113, 454);
			this.btnAlleLöschen.Name = "btnAlleLöschen";
			this.btnAlleLöschen.Size = new System.Drawing.Size(75, 23);
			this.btnAlleLöschen.TabIndex = 11;
			this.btnAlleLöschen.Text = "Alle löschen";
			this.btnAlleLöschen.UseVisualStyleBackColor = true;
			this.btnAlleLöschen.Click += new System.EventHandler(this.btnAlleLöschen_Click);
			// 
			// btnBeenden
			// 
			this.btnBeenden.Location = new System.Drawing.Point(421, 454);
			this.btnBeenden.Name = "btnBeenden";
			this.btnBeenden.Size = new System.Drawing.Size(75, 23);
			this.btnBeenden.TabIndex = 12;
			this.btnBeenden.Text = "Beenden";
			this.btnBeenden.UseVisualStyleBackColor = true;
			this.btnBeenden.Click += new System.EventHandler(this.btnBeenden_Click);
			// 
			// btnWurdeErledigt
			// 
			this.btnWurdeErledigt.Location = new System.Drawing.Point(236, 193);
			this.btnWurdeErledigt.Name = "btnWurdeErledigt";
			this.btnWurdeErledigt.Size = new System.Drawing.Size(40, 43);
			this.btnWurdeErledigt.TabIndex = 13;
			this.btnWurdeErledigt.Text = ">";
			this.btnWurdeErledigt.UseVisualStyleBackColor = true;
			this.btnWurdeErledigt.Click += new System.EventHandler(this.btnWurdeErledigt_Click);
			// 
			// btnNichtErledigt
			// 
			this.btnNichtErledigt.Location = new System.Drawing.Point(236, 242);
			this.btnNichtErledigt.Name = "btnNichtErledigt";
			this.btnNichtErledigt.Size = new System.Drawing.Size(40, 43);
			this.btnNichtErledigt.TabIndex = 14;
			this.btnNichtErledigt.Text = "<";
			this.btnNichtErledigt.UseVisualStyleBackColor = true;
			this.btnNichtErledigt.Click += new System.EventHandler(this.btnNichtErledigt_Click);
			// 
			// frmEinkaufsliste
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(512, 492);
			this.Controls.Add(this.btnNichtErledigt);
			this.Controls.Add(this.btnWurdeErledigt);
			this.Controls.Add(this.btnBeenden);
			this.Controls.Add(this.btnAlleLöschen);
			this.Controls.Add(this.btnLöschen);
			this.Controls.Add(this.lblErgebnis);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lstErledigt);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lstToDo);
			this.Controls.Add(this.btnHinzufügen);
			this.Controls.Add(this.txtBeschreibung);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtAnzahl);
			this.Controls.Add(this.label1);
			this.Name = "frmEinkaufsliste";
			this.Text = "Einkaufsliste";
			this.Load += new System.EventHandler(this.frmEinkaufsliste_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtAnzahl;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtBeschreibung;
		private System.Windows.Forms.Button btnHinzufügen;
		private System.Windows.Forms.ListBox lstToDo;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ListBox lstErledigt;
		private System.Windows.Forms.Label lblErgebnis;
		private System.Windows.Forms.Button btnLöschen;
		private System.Windows.Forms.Button btnAlleLöschen;
		private System.Windows.Forms.Button btnBeenden;
		private System.Windows.Forms.Button btnWurdeErledigt;
		private System.Windows.Forms.Button btnNichtErledigt;
	}
}

