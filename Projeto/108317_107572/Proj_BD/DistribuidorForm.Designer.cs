
namespace Proj_BD
{
    partial class DistribuidorForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gobackBtn = new System.Windows.Forms.Button();
            this.nifLbl = new System.Windows.Forms.Label();
            this.nomeLbl = new System.Windows.Forms.Label();
            this.nifTxt = new System.Windows.Forms.TextBox();
            this.nomeTxt = new System.Windows.Forms.TextBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.emailLbl = new System.Windows.Forms.Label();
            this.num_funcTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Id_vendaTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.matriculaTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.num_dist = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1062, 352);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // gobackBtn
            // 
            this.gobackBtn.Location = new System.Drawing.Point(23, 476);
            this.gobackBtn.Name = "gobackBtn";
            this.gobackBtn.Size = new System.Drawing.Size(123, 33);
            this.gobackBtn.TabIndex = 3;
            this.gobackBtn.Text = "Go back";
            this.gobackBtn.UseVisualStyleBackColor = true;
            this.gobackBtn.Click += new System.EventHandler(this.gobackBtn_Click);
            // 
            // nifLbl
            // 
            this.nifLbl.AutoSize = true;
            this.nifLbl.Location = new System.Drawing.Point(25, 65);
            this.nifLbl.Name = "nifLbl";
            this.nifLbl.Size = new System.Drawing.Size(34, 20);
            this.nifLbl.TabIndex = 11;
            this.nifLbl.Text = "NIF:";
            // 
            // nomeLbl
            // 
            this.nomeLbl.AutoSize = true;
            this.nomeLbl.Location = new System.Drawing.Point(244, 27);
            this.nomeLbl.Name = "nomeLbl";
            this.nomeLbl.Size = new System.Drawing.Size(53, 20);
            this.nomeLbl.TabIndex = 10;
            this.nomeLbl.Text = "Nome:";
            // 
            // nifTxt
            // 
            this.nifTxt.Location = new System.Drawing.Point(83, 61);
            this.nifTxt.Name = "nifTxt";
            this.nifTxt.Size = new System.Drawing.Size(175, 27);
            this.nifTxt.TabIndex = 9;
            // 
            // nomeTxt
            // 
            this.nomeTxt.Location = new System.Drawing.Point(302, 23);
            this.nomeTxt.Name = "nomeTxt";
            this.nomeTxt.Size = new System.Drawing.Size(175, 27);
            this.nomeTxt.TabIndex = 8;
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(606, 24);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(204, 27);
            this.emailTxt.TabIndex = 13;
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Location = new System.Drawing.Point(535, 26);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(49, 20);
            this.emailLbl.TabIndex = 12;
            this.emailLbl.Text = "Email:";
            // 
            // num_funcTxt
            // 
            this.num_funcTxt.Location = new System.Drawing.Point(468, 62);
            this.num_funcTxt.Name = "num_funcTxt";
            this.num_funcTxt.Size = new System.Drawing.Size(204, 27);
            this.num_funcTxt.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Num de Funcionario:";
            // 
            // Id_vendaTxt
            // 
            this.Id_vendaTxt.Location = new System.Drawing.Point(954, 24);
            this.Id_vendaTxt.Name = "Id_vendaTxt";
            this.Id_vendaTxt.Size = new System.Drawing.Size(78, 27);
            this.Id_vendaTxt.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(856, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "ID de venda:";
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(1119, 7);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(86, 33);
            this.searchBtn.TabIndex = 18;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(1119, 46);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(86, 33);
            this.clearBtn.TabIndex = 19;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(698, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Matricula_carrinha:";
            // 
            // matriculaTxt
            // 
            this.matriculaTxt.Location = new System.Drawing.Point(837, 65);
            this.matriculaTxt.Name = "matriculaTxt";
            this.matriculaTxt.Size = new System.Drawing.Size(109, 27);
            this.matriculaTxt.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Num_Distribuidor";
            // 
            // num_dist
            // 
            this.num_dist.Location = new System.Drawing.Point(157, 20);
            this.num_dist.Name = "num_dist";
            this.num_dist.Size = new System.Drawing.Size(81, 27);
            this.num_dist.TabIndex = 22;
            // 
            // DistribuidorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 562);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.num_dist);
            this.Controls.Add(this.matriculaTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.Id_vendaTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.num_funcTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.nifLbl);
            this.Controls.Add(this.nomeLbl);
            this.Controls.Add(this.nifTxt);
            this.Controls.Add(this.nomeTxt);
            this.Controls.Add(this.gobackBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DistribuidorForm";
            this.Text = "DistribuidorForm";
            this.Load += new System.EventHandler(this.DistribuidorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button gobackBtn;
        private System.Windows.Forms.Label nifLbl;
        private System.Windows.Forms.Label nomeLbl;
        private System.Windows.Forms.TextBox nifTxt;
        private System.Windows.Forms.TextBox nomeTxt;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.TextBox num_funcTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Id_vendaTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox matriculaTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox num_dist;
    }
}