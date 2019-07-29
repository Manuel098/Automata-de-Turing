namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Star = new System.Windows.Forms.Button();
            this.inputData = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.subirArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modalidadDelAutomataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parDe0ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameAuto = new System.Windows.Forms.Label();
            this.inputMessage = new System.Windows.Forms.RichTextBox();
            this.save = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Star
            // 
            this.Star.Location = new System.Drawing.Point(34, 137);
            this.Star.Name = "Star";
            this.Star.Size = new System.Drawing.Size(161, 49);
            this.Star.TabIndex = 0;
            this.Star.Text = "Iniciar";
            this.Star.UseVisualStyleBackColor = true;
            this.Star.Click += new System.EventHandler(this.Star_Click);
            // 
            // inputData
            // 
            this.inputData.Location = new System.Drawing.Point(34, 86);
            this.inputData.Name = "inputData";
            this.inputData.Size = new System.Drawing.Size(339, 26);
            this.inputData.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subirArchivoToolStripMenuItem,
            this.modalidadDelAutomataToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // subirArchivoToolStripMenuItem
            // 
            this.subirArchivoToolStripMenuItem.Name = "subirArchivoToolStripMenuItem";
            this.subirArchivoToolStripMenuItem.Size = new System.Drawing.Size(130, 29);
            this.subirArchivoToolStripMenuItem.Text = "Subir Archivo";
            this.subirArchivoToolStripMenuItem.Click += new System.EventHandler(this.subirArchivoToolStripMenuItem_Click);
            // 
            // modalidadDelAutomataToolStripMenuItem
            // 
            this.modalidadDelAutomataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sumadorToolStripMenuItem,
            this.restadorToolStripMenuItem,
            this.parDe0ToolStripMenuItem});
            this.modalidadDelAutomataToolStripMenuItem.Name = "modalidadDelAutomataToolStripMenuItem";
            this.modalidadDelAutomataToolStripMenuItem.Size = new System.Drawing.Size(223, 29);
            this.modalidadDelAutomataToolStripMenuItem.Text = "Modalidad del Automata";
            // 
            // sumadorToolStripMenuItem
            // 
            this.sumadorToolStripMenuItem.Name = "sumadorToolStripMenuItem";
            this.sumadorToolStripMenuItem.Size = new System.Drawing.Size(169, 30);
            this.sumadorToolStripMenuItem.Text = "Sumador";
            this.sumadorToolStripMenuItem.Click += new System.EventHandler(this.sumadorToolStripMenuItem_Click);
            // 
            // restadorToolStripMenuItem
            // 
            this.restadorToolStripMenuItem.Name = "restadorToolStripMenuItem";
            this.restadorToolStripMenuItem.Size = new System.Drawing.Size(169, 30);
            this.restadorToolStripMenuItem.Text = "Restador";
            this.restadorToolStripMenuItem.Click += new System.EventHandler(this.restadorToolStripMenuItem_Click);
            // 
            // parDe0ToolStripMenuItem
            // 
            this.parDe0ToolStripMenuItem.Name = "parDe0ToolStripMenuItem";
            this.parDe0ToolStripMenuItem.Size = new System.Drawing.Size(169, 30);
            this.parDe0ToolStripMenuItem.Text = "Par de 0";
            this.parDe0ToolStripMenuItem.Click += new System.EventHandler(this.parDe0ToolStripMenuItem_Click);
            // 
            // nameAuto
            // 
            this.nameAuto.AutoSize = true;
            this.nameAuto.Location = new System.Drawing.Point(30, 54);
            this.nameAuto.Name = "nameAuto";
            this.nameAuto.Size = new System.Drawing.Size(0, 20);
            this.nameAuto.TabIndex = 5;
            // 
            // inputMessage
            // 
            this.inputMessage.Location = new System.Drawing.Point(413, 54);
            this.inputMessage.Name = "inputMessage";
            this.inputMessage.Size = new System.Drawing.Size(375, 384);
            this.inputMessage.TabIndex = 6;
            this.inputMessage.Text = "";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(212, 137);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(161, 49);
            this.save.TabIndex = 7;
            this.save.Text = "Guardar";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.save);
            this.Controls.Add(this.inputMessage);
            this.Controls.Add(this.nameAuto);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.inputData);
            this.Controls.Add(this.Star);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Automata de Turing";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Star;
        private System.Windows.Forms.TextBox inputData;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modalidadDelAutomataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sumadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parDe0ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subirArchivoToolStripMenuItem;
        private System.Windows.Forms.Label nameAuto;
        private System.Windows.Forms.RichTextBox inputMessage;
        private System.Windows.Forms.Button save;
    }
}

