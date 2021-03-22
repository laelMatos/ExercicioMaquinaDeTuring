
namespace MaquinaDeTuring
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
            this.components = new System.ComponentModel.Container();
            this.Val1 = new System.Windows.Forms.TextBox();
            this.Val2 = new System.Windows.Forms.TextBox();
            this.Entrada = new System.Windows.Forms.Label();
            this.Resultado = new System.Windows.Forms.Label();
            this.Bt_iniciar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Val1
            // 
            this.Val1.Location = new System.Drawing.Point(12, 12);
            this.Val1.Name = "Val1";
            this.Val1.Size = new System.Drawing.Size(100, 23);
            this.Val1.TabIndex = 0;
            // 
            // Val2
            // 
            this.Val2.Location = new System.Drawing.Point(12, 41);
            this.Val2.Name = "Val2";
            this.Val2.Size = new System.Drawing.Size(100, 23);
            this.Val2.TabIndex = 1;
            // 
            // Entrada
            // 
            this.Entrada.AutoSize = true;
            this.Entrada.Location = new System.Drawing.Point(12, 77);
            this.Entrada.Name = "Entrada";
            this.Entrada.Size = new System.Drawing.Size(47, 15);
            this.Entrada.TabIndex = 2;
            this.Entrada.Text = "entrada";
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.Location = new System.Drawing.Point(12, 92);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(54, 15);
            this.Resultado.TabIndex = 3;
            this.Resultado.Text = "Processo";
            // 
            // Bt_iniciar
            // 
            this.Bt_iniciar.Location = new System.Drawing.Point(227, 11);
            this.Bt_iniciar.Name = "Bt_iniciar";
            this.Bt_iniciar.Size = new System.Drawing.Size(75, 23);
            this.Bt_iniciar.TabIndex = 4;
            this.Bt_iniciar.Text = "Iniciar";
            this.Bt_iniciar.UseVisualStyleBackColor = true;
            this.Bt_iniciar.Click += new System.EventHandler(this.Bt_iniciar_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 127);
            this.Controls.Add(this.Bt_iniciar);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.Entrada);
            this.Controls.Add(this.Val2);
            this.Controls.Add(this.Val1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Val1;
        private System.Windows.Forms.TextBox Val2;
        private System.Windows.Forms.Label Entrada;
        private System.Windows.Forms.Label Resultado;
        private System.Windows.Forms.Button Bt_iniciar;
        private System.Windows.Forms.Timer timer1;
    }
}

