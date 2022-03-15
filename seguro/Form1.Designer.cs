
namespace seguro
{
    partial class frmInsuranceCalc
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblVehicleValue = new System.Windows.Forms.Label();
            this.lblInsuranceValue = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtInsuranceValue = new System.Windows.Forms.TextBox();
            this.txtVehicleValue = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.rdoFeminine = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(37, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nome:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(37, 66);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(37, 13);
            this.lblAge.TabIndex = 1;
            this.lblAge.Text = "Idade:";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(37, 106);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(34, 13);
            this.lblSex.TabIndex = 2;
            this.lblSex.Text = "Sexo:";
            // 
            // lblVehicleValue
            // 
            this.lblVehicleValue.AutoSize = true;
            this.lblVehicleValue.Location = new System.Drawing.Point(37, 144);
            this.lblVehicleValue.Name = "lblVehicleValue";
            this.lblVehicleValue.Size = new System.Drawing.Size(102, 13);
            this.lblVehicleValue.TabIndex = 3;
            this.lblVehicleValue.Text = "Valor do Automóvel:";
            // 
            // lblInsuranceValue
            // 
            this.lblInsuranceValue.AutoSize = true;
            this.lblInsuranceValue.Location = new System.Drawing.Point(37, 176);
            this.lblInsuranceValue.Name = "lblInsuranceValue";
            this.lblInsuranceValue.Size = new System.Drawing.Size(86, 13);
            this.lblInsuranceValue.TabIndex = 4;
            this.lblInsuranceValue.Text = "Valor do Seguro:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(81, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(181, 20);
            this.txtName.TabIndex = 5;
            // 
            // txtInsuranceValue
            // 
            this.txtInsuranceValue.Enabled = false;
            this.txtInsuranceValue.Location = new System.Drawing.Point(145, 173);
            this.txtInsuranceValue.Name = "txtInsuranceValue";
            this.txtInsuranceValue.Size = new System.Drawing.Size(117, 20);
            this.txtInsuranceValue.TabIndex = 6;
            // 
            // txtVehicleValue
            // 
            this.txtVehicleValue.Location = new System.Drawing.Point(145, 141);
            this.txtVehicleValue.Name = "txtVehicleValue";
            this.txtVehicleValue.Size = new System.Drawing.Size(117, 20);
            this.txtVehicleValue.TabIndex = 7;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(81, 63);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(181, 20);
            this.txtAge.TabIndex = 8;
            // 
            // rdoFeminine
            // 
            this.rdoFeminine.AutoSize = true;
            this.rdoFeminine.Location = new System.Drawing.Point(81, 104);
            this.rdoFeminine.Name = "rdoFeminine";
            this.rdoFeminine.Size = new System.Drawing.Size(67, 17);
            this.rdoFeminine.TabIndex = 9;
            this.rdoFeminine.TabStop = true;
            this.rdoFeminine.Text = "Feminino";
            this.rdoFeminine.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(189, 104);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(73, 17);
            this.rdoMale.TabIndex = 10;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Masculino";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(40, 229);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(83, 30);
            this.btnCalculate.TabIndex = 11;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(189, 229);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(83, 30);
            this.btnClean.TabIndex = 12;
            this.btnClean.Text = "Limpar";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // frmInsuranceCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 297);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.rdoMale);
            this.Controls.Add(this.rdoFeminine);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtVehicleValue);
            this.Controls.Add(this.txtInsuranceValue);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblInsuranceValue);
            this.Controls.Add(this.lblVehicleValue);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblName);
            this.Name = "frmInsuranceCalc";
            this.Text = "Cálculo de Seguro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblVehicleValue;
        private System.Windows.Forms.Label lblInsuranceValue;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtInsuranceValue;
        private System.Windows.Forms.TextBox txtVehicleValue;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.RadioButton rdoFeminine;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClean;
    }
}

