
namespace Proj_BD
{
    partial class ProdutosForm
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
            this.clearBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.telemovelLbl = new System.Windows.Forms.Label();
            this.precoTxt = new System.Windows.Forms.TextBox();
            this.marcaTxt = new System.Windows.Forms.TextBox();
            this.dataLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.nomeLbl = new System.Windows.Forms.Label();
            this.idLbl = new System.Windows.Forms.Label();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.nomeTxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gobackBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(1072, 54);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 25);
            this.clearBtn.TabIndex = 57;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(1071, 17);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 25);
            this.searchBtn.TabIndex = 55;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // telemovelLbl
            // 
            this.telemovelLbl.AutoSize = true;
            this.telemovelLbl.Location = new System.Drawing.Point(241, 17);
            this.telemovelLbl.Name = "telemovelLbl";
            this.telemovelLbl.Size = new System.Drawing.Size(95, 15);
            this.telemovelLbl.TabIndex = 52;
            this.telemovelLbl.Text = "Tipo de produto:";
            // 
            // precoTxt
            // 
            this.precoTxt.Location = new System.Drawing.Point(598, 17);
            this.precoTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.precoTxt.Name = "precoTxt";
            this.precoTxt.Size = new System.Drawing.Size(87, 23);
            this.precoTxt.TabIndex = 50;
            // 
            // marcaTxt
            // 
            this.marcaTxt.Location = new System.Drawing.Point(59, 54);
            this.marcaTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.marcaTxt.Name = "marcaTxt";
            this.marcaTxt.Size = new System.Drawing.Size(154, 23);
            this.marcaTxt.TabIndex = 49;
            // 
            // dataLbl
            // 
            this.dataLbl.AutoSize = true;
            this.dataLbl.Location = new System.Drawing.Point(11, 58);
            this.dataLbl.Name = "dataLbl";
            this.dataLbl.Size = new System.Drawing.Size(43, 15);
            this.dataLbl.TabIndex = 48;
            this.dataLbl.Text = "Marca:";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Location = new System.Drawing.Point(500, 17);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(40, 15);
            this.emailLbl.TabIndex = 47;
            this.emailLbl.Text = "Preço:";
            // 
            // nomeLbl
            // 
            this.nomeLbl.AutoSize = true;
            this.nomeLbl.Location = new System.Drawing.Point(12, 17);
            this.nomeLbl.Name = "nomeLbl";
            this.nomeLbl.Size = new System.Drawing.Size(43, 15);
            this.nomeLbl.TabIndex = 46;
            this.nomeLbl.Text = "Nome:";
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Location = new System.Drawing.Point(235, 58);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(21, 15);
            this.idLbl.TabIndex = 45;
            this.idLbl.Text = "ID:";
            // 
            // idTxt
            // 
            this.idTxt.Location = new System.Drawing.Point(342, 54);
            this.idTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(117, 23);
            this.idTxt.TabIndex = 44;
            this.idTxt.TextChanged += new System.EventHandler(this.idTxt_TextChanged);
            // 
            // nomeTxt
            // 
            this.nomeTxt.Location = new System.Drawing.Point(61, 14);
            this.nomeTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nomeTxt.Name = "nomeTxt";
            this.nomeTxt.Size = new System.Drawing.Size(154, 23);
            this.nomeTxt.TabIndex = 43;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 120);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1083, 350);
            this.dataGridView1.TabIndex = 42;
            // 
            // gobackBtn
            // 
            this.gobackBtn.Location = new System.Drawing.Point(49, 493);
            this.gobackBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gobackBtn.Name = "gobackBtn";
            this.gobackBtn.Size = new System.Drawing.Size(108, 25);
            this.gobackBtn.TabIndex = 63;
            this.gobackBtn.Text = "Go back";
            this.gobackBtn.UseVisualStyleBackColor = true;
            this.gobackBtn.Click += new System.EventHandler(this.gobackBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(342, 17);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 23);
            this.textBox1.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(500, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 65;
            this.label2.Text = "ID do Armazem:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(598, 56);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(87, 23);
            this.textBox2.TabIndex = 66;
            // 
            // ProdutosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 525);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gobackBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.telemovelLbl);
            this.Controls.Add(this.precoTxt);
            this.Controls.Add(this.marcaTxt);
            this.Controls.Add(this.dataLbl);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.nomeLbl);
            this.Controls.Add(this.idLbl);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.nomeTxt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ProdutosForm";
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.ArmazensForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label telemovelLbl;
        private System.Windows.Forms.TextBox precoTxt;
        private System.Windows.Forms.TextBox marcaTxt;
        private System.Windows.Forms.Label dataLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label nomeLbl;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.TextBox nomeTxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button gobackBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
    }
}