
namespace temp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCel = new System.Windows.Forms.TextBox();
            this.txtFah = new System.Windows.Forms.TextBox();
            this.lblTemratureConvertor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFahToCel = new ePOSOne.btnProduct.Button_WOC();
            this.btnCelToFah = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // txtCel
            // 
            this.txtCel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtCel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCel.Location = new System.Drawing.Point(569, 131);
            this.txtCel.Multiline = true;
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(140, 80);
            this.txtCel.TabIndex = 3;
            this.txtCel.TextChanged += new System.EventHandler(this.txtCel_TextChanged);
            // 
            // txtFah
            // 
            this.txtFah.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtFah.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFah.Location = new System.Drawing.Point(569, 280);
            this.txtFah.Multiline = true;
            this.txtFah.Name = "txtFah";
            this.txtFah.Size = new System.Drawing.Size(140, 80);
            this.txtFah.TabIndex = 4;
            this.txtFah.TextChanged += new System.EventHandler(this.txtFah_TextChanged);
            // 
            // lblTemratureConvertor
            // 
            this.lblTemratureConvertor.AutoSize = true;
            this.lblTemratureConvertor.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemratureConvertor.Location = new System.Drawing.Point(347, 41);
            this.lblTemratureConvertor.Name = "lblTemratureConvertor";
            this.lblTemratureConvertor.Size = new System.Drawing.Size(472, 40);
            this.lblTemratureConvertor.TabIndex = 5;
            this.lblTemratureConvertor.Text = "TEMRATURE CONVERTOR";
            this.lblTemratureConvertor.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.BurlyWood;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 40);
            this.label1.TabIndex = 6;
            this.label1.Text = "Celsius";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.BurlyWood;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(260, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 40);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fahrenheit";
            // 
            // btnFahToCel
            // 
            this.btnFahToCel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnFahToCel.ButtonColor = System.Drawing.Color.DarkSlateGray;
            this.btnFahToCel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFahToCel.ForeColor = System.Drawing.Color.Transparent;
            this.btnFahToCel.Location = new System.Drawing.Point(892, 280);
            this.btnFahToCel.Name = "btnFahToCel";
            this.btnFahToCel.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnFahToCel.OnHoverButtonColor = System.Drawing.Color.LemonChiffon;
            this.btnFahToCel.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnFahToCel.Size = new System.Drawing.Size(143, 80);
            this.btnFahToCel.TabIndex = 8;
            this.btnFahToCel.Text = "Fah To Cel";
            this.btnFahToCel.TextColor = System.Drawing.Color.White;
            this.btnFahToCel.UseVisualStyleBackColor = true;
            this.btnFahToCel.Click += new System.EventHandler(this.btnFahToCel_Click);
            // 
            // btnCelToFah
            // 
            this.btnCelToFah.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCelToFah.ButtonColor = System.Drawing.Color.DarkSlateGray;
            this.btnCelToFah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCelToFah.ForeColor = System.Drawing.Color.Transparent;
            this.btnCelToFah.Location = new System.Drawing.Point(892, 131);
            this.btnCelToFah.Name = "btnCelToFah";
            this.btnCelToFah.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnCelToFah.OnHoverButtonColor = System.Drawing.Color.LavenderBlush;
            this.btnCelToFah.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnCelToFah.Size = new System.Drawing.Size(143, 80);
            this.btnCelToFah.TabIndex = 0;
            this.btnCelToFah.Text = "Cel To Fah";
            this.btnCelToFah.TextColor = System.Drawing.Color.White;
            this.btnCelToFah.UseVisualStyleBackColor = true;
            this.btnCelToFah.Click += new System.EventHandler(this.btnCelToFah_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1135, 420);
            this.Controls.Add(this.btnFahToCel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTemratureConvertor);
            this.Controls.Add(this.txtFah);
            this.Controls.Add(this.txtCel);
            this.Controls.Add(this.btnCelToFah);
            this.Name = "Form1";
            this.Text = "Temprature Convertor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ePOSOne.btnProduct.Button_WOC btnCelToFah;
        private System.Windows.Forms.TextBox txtCel;
        private System.Windows.Forms.TextBox txtFah;
        private System.Windows.Forms.Label lblTemratureConvertor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ePOSOne.btnProduct.Button_WOC btnFahToCel;
    }
}

