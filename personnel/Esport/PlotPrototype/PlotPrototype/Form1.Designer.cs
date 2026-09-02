namespace PlotPrototype
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            label1 = new Label();
            label2 = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            importerUnFichierToolStripMenuItem = new ToolStripMenuItem();
            fichierToolStripMenuItem = new ToolStripMenuItem();
            quitterToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            Paramètres = new GroupBox();
            checkBox1 = new CheckBox();
            comboBox1 = new ComboBox();
            Graphiques = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            checkedListBox1 = new CheckedListBox();
            label6 = new Label();
            button3 = new Button();
            menuStrip1.SuspendLayout();
            Paramètres.SuspendLayout();
            Graphiques.SuspendLayout();
            SuspendLayout();
            // 
            // formsPlot1
            // 
            formsPlot1.Location = new Point(208, 108);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(693, 358);
            formsPlot1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(517, 469);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 1;
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(832, 499);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 2;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, viewToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(913, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { importerUnFichierToolStripMenuItem, fichierToolStripMenuItem, quitterToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 20);
            fileToolStripMenuItem.Text = "Fichier";
            fileToolStripMenuItem.Click += fileToolStripMenuItem_Click;
            // 
            // importerUnFichierToolStripMenuItem
            // 
            importerUnFichierToolStripMenuItem.Name = "importerUnFichierToolStripMenuItem";
            importerUnFichierToolStripMenuItem.Size = new Size(173, 22);
            importerUnFichierToolStripMenuItem.Text = "Importer un fichier";
            // 
            // fichierToolStripMenuItem
            // 
            fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            fichierToolStripMenuItem.Size = new Size(173, 22);
            fichierToolStripMenuItem.Text = "Connecter une API";
            // 
            // quitterToolStripMenuItem
            // 
            quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            quitterToolStripMenuItem.Size = new Size(173, 22);
            quitterToolStripMenuItem.Text = "Quitter";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(39, 20);
            viewToolStripMenuItem.Text = "Vue";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(253, 131);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 5;
            label4.Text = "Graphique 1";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(253, 146);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 6;
            label5.Text = "Graphique 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 19);
            label3.Name = "label3";
            label3.Size = new Size(166, 15);
            label3.TabIndex = 10;
            label3.Text = "Sélectionner le type de courbe";
            // 
            // Paramètres
            // 
            Paramètres.Controls.Add(checkBox1);
            Paramètres.Controls.Add(comboBox1);
            Paramètres.Controls.Add(label3);
            Paramètres.Location = new Point(244, 26);
            Paramètres.Name = "Paramètres";
            Paramètres.Size = new Size(643, 76);
            Paramètres.TabIndex = 12;
            Paramètres.TabStop = false;
            Paramètres.Text = "Paramètres";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(222, 41);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(113, 19);
            checkBox1.TabIndex = 13;
            checkBox1.Text = "Masquer la grille";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(16, 37);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(187, 23);
            comboBox1.TabIndex = 12;
            // 
            // Graphiques
            // 
            Graphiques.Controls.Add(button3);
            Graphiques.Controls.Add(button2);
            Graphiques.Controls.Add(button1);
            Graphiques.Controls.Add(checkedListBox1);
            Graphiques.Controls.Add(label6);
            Graphiques.ImeMode = ImeMode.Disable;
            Graphiques.Location = new Point(12, 27);
            Graphiques.Name = "Graphiques";
            Graphiques.Size = new Size(167, 417);
            Graphiques.TabIndex = 13;
            Graphiques.TabStop = false;
            Graphiques.Text = "Graphiques";
            // 
            // button2
            // 
            button2.Location = new Point(18, 375);
            button2.Name = "button2";
            button2.Size = new Size(133, 23);
            button2.TabIndex = 15;
            button2.Text = "Exporter en PNG";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(18, 346);
            button1.Name = "button1";
            button1.Size = new Size(133, 23);
            button1.TabIndex = 14;
            button1.Text = "Réinitialiser le zoom";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Graphique 1", "Graphique 2" });
            checkedListBox1.Location = new Point(6, 46);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(154, 256);
            checkedListBox1.TabIndex = 2;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 24);
            label6.Name = "label6";
            label6.Size = new Size(154, 15);
            label6.TabIndex = 1;
            label6.Text = "Sélectionner les graphiques ";
            label6.Click += label6_Click;
            // 
            // button3
            // 
            button3.Location = new Point(18, 317);
            button3.Name = "button3";
            button3.Size = new Size(133, 23);
            button3.TabIndex = 16;
            button3.Text = "Ajouter une valeur";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 523);
            Controls.Add(Graphiques);
            Controls.Add(Paramètres);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(formsPlot1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            Paramètres.ResumeLayout(false);
            Paramètres.PerformLayout();
            Graphiques.ResumeLayout(false);
            Graphiques.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private Label label1;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private Label label4;
        private Label label5;
        private Label label3;
        private GroupBox Paramètres;
        private ComboBox comboBox1;
        private CheckBox checkBox1;
        private ToolStripMenuItem importerUnFichierToolStripMenuItem;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private GroupBox Graphiques;
        private Label label6;
        private CheckedListBox checkedListBox1;
        private Button button1;
        private Button button2;
        private ToolStripMenuItem fichierToolStripMenuItem;
        private Button button3;
    }
}
