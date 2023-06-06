
namespace Proj_BD
{
    partial class FornecedoresForm
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
            this.nomeLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gobackBtn = new System.Windows.Forms.Button();
            this.nifLbl = new System.Windows.Forms.Label();
            this.nomeTxt = new System.Windows.Forms.TextBox();
            this.nifTxt = new System.Windows.Forms.TextBox();
            this.dataLbl = new System.Windows.Forms.Label();
            this.telemovelLbl = new System.Windows.Forms.Label();
            this.dataTxt = new System.Windows.Forms.TextBox();
            this.telemovelTxt = new System.Windows.Forms.TextBox();
            this.moradaLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.moradaTxt = new System.Windows.Forms.TextBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.numFornecedorLbl = new System.Windows.Forms.Label();
            this.numFornecedorTxt = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeLbl
            // 
            this.nomeLbl.AutoSize = true;
            this.nomeLbl.Location = new System.Drawing.Point(12, 22);
            this.nomeLbl.Name = "nomeLbl";
            this.nomeLbl.Size = new System.Drawing.Size(43, 15);
            this.nomeLbl.TabIndex = 7;
            this.nomeLbl.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-141, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nome:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 98);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(780, 350);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // gobackBtn
            // 
            this.gobackBtn.Location = new System.Drawing.Point(30, 469);
            this.gobackBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gobackBtn.Name = "gobackBtn";
            this.gobackBtn.Size = new System.Drawing.Size(108, 25);
            this.gobackBtn.TabIndex = 10;
            this.gobackBtn.Text = "Go back";
            this.gobackBtn.UseVisualStyleBackColor = true;
            this.gobackBtn.Click += new System.EventHandler(this.gobackBtn_Click);
            // 
            // nifLbl
            // 
            this.nifLbl.AutoSize = true;
            this.nifLbl.Location = new System.Drawing.Point(12, 60);
            this.nifLbl.Name = "nifLbl";
            this.nifLbl.Size = new System.Drawing.Size(28, 15);
            this.nifLbl.TabIndex = 11;
            this.nifLbl.Text = "NIF:";
            // 
            // nomeTxt
            // 
            this.nomeTxt.Location = new System.Drawing.Point(61, 22);
            this.nomeTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nomeTxt.Name = "nomeTxt";
            this.nomeTxt.Size = new System.Drawing.Size(154, 23);
            this.nomeTxt.TabIndex = 12;
            this.nomeTxt.TextChanged += new System.EventHandler(this.nomeTxt_TextChanged);
            // 
            // nifTxt
            // 
            this.nifTxt.Location = new System.Drawing.Point(61, 57);
            this.nifTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nifTxt.Name = "nifTxt";
            this.nifTxt.Size = new System.Drawing.Size(154, 23);
            this.nifTxt.TabIndex = 14;
            this.nifTxt.TextChanged += new System.EventHandler(this.nifTxt_TextChanged);
            // 
            // dataLbl
            // 
            this.dataLbl.AutoSize = true;
            this.dataLbl.Location = new System.Drawing.Point(232, 30);
            this.dataLbl.Name = "dataLbl";
            this.dataLbl.Size = new System.Drawing.Size(115, 15);
            this.dataLbl.TabIndex = 15;
            this.dataLbl.Text = "Data de nascimento:";
            // 
            // telemovelLbl
            // 
            this.telemovelLbl.AutoSize = true;
            this.telemovelLbl.Location = new System.Drawing.Point(232, 60);
            this.telemovelLbl.Name = "telemovelLbl";
            this.telemovelLbl.Size = new System.Drawing.Size(63, 15);
            this.telemovelLbl.TabIndex = 16;
            this.telemovelLbl.Text = "Telemovel:";
            // 
            // dataTxt
            // 
            this.dataTxt.Location = new System.Drawing.Point(353, 22);
            this.dataTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataTxt.Name = "dataTxt";
            this.dataTxt.Size = new System.Drawing.Size(120, 23);
            this.dataTxt.TabIndex = 17;
            this.dataTxt.TextChanged += new System.EventHandler(this.dataTxt_TextChanged);
            // 
            // telemovelTxt
            // 
            this.telemovelTxt.Location = new System.Drawing.Point(353, 57);
            this.telemovelTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.telemovelTxt.Name = "telemovelTxt";
            this.telemovelTxt.Size = new System.Drawing.Size(120, 23);
            this.telemovelTxt.TabIndex = 18;
            this.telemovelTxt.TextChanged += new System.EventHandler(this.telemovelTxt_TextChanged);
            // 
            // moradaLbl
            // 
            this.moradaLbl.AutoSize = true;
            this.moradaLbl.Location = new System.Drawing.Point(490, 30);
            this.moradaLbl.Name = "moradaLbl";
            this.moradaLbl.Size = new System.Drawing.Size(51, 15);
            this.moradaLbl.TabIndex = 19;
            this.moradaLbl.Text = "Morada:";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Location = new System.Drawing.Point(490, 60);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(39, 15);
            this.emailLbl.TabIndex = 20;
            this.emailLbl.Text = "Email:";
            // 
            // moradaTxt
            // 
            this.moradaTxt.Location = new System.Drawing.Point(547, 27);
            this.moradaTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.moradaTxt.Name = "moradaTxt";
            this.moradaTxt.Size = new System.Drawing.Size(179, 23);
            this.moradaTxt.TabIndex = 21;
            this.moradaTxt.TextChanged += new System.EventHandler(this.moradaTxt_TextChanged);
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(547, 57);
            this.emailTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(179, 23);
            this.emailTxt.TabIndex = 22;
            this.emailTxt.TextChanged += new System.EventHandler(this.emailTxt_TextChanged);
            // 
            // numFornecedorLbl
            // 
            this.numFornecedorLbl.AutoSize = true;
            this.numFornecedorLbl.Location = new System.Drawing.Point(742, 30);
            this.numFornecedorLbl.Name = "numFornecedorLbl";
            this.numFornecedorLbl.Size = new System.Drawing.Size(115, 15);
            this.numFornecedorLbl.TabIndex = 23;
            this.numFornecedorLbl.Text = "Num do fornecedor:";
            // 
            // numFornecedorTxt
            // 
            this.numFornecedorTxt.Location = new System.Drawing.Point(856, 27);
            this.numFornecedorTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numFornecedorTxt.Name = "numFornecedorTxt";
            this.numFornecedorTxt.Size = new System.Drawing.Size(127, 23);
            this.numFornecedorTxt.TabIndex = 24;
            this.numFornecedorTxt.TextChanged += new System.EventHandler(this.numFornecedorTxt_TextChanged);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(827, 98);
            this.addBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 25);
            this.addBtn.TabIndex = 25;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(908, 98);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 25);
            this.searchBtn.TabIndex = 26;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(908, 128);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 25);
            this.clearBtn.TabIndex = 27;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(827, 128);
            this.removeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(75, 25);
            this.removeBtn.TabIndex = 28;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // FornecedoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 505);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.numFornecedorTxt);
            this.Controls.Add(this.numFornecedorLbl);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.moradaTxt);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.moradaLbl);
            this.Controls.Add(this.telemovelTxt);
            this.Controls.Add(this.dataTxt);
            this.Controls.Add(this.telemovelLbl);
            this.Controls.Add(this.dataLbl);
            this.Controls.Add(this.nifTxt);
            this.Controls.Add(this.nomeTxt);
            this.Controls.Add(this.nifLbl);
            this.Controls.Add(this.gobackBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.nomeLbl);
            this.Name = "FornecedoresForm";
            this.Text = "Fornecedores";
            this.Load += new System.EventHandler(this.Fornecedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nomeLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button gobackBtn;
        private System.Windows.Forms.Label nifLbl;
        private System.Windows.Forms.TextBox nomeTxt;
        private System.Windows.Forms.TextBox nifTxt;
        private System.Windows.Forms.Label dataLbl;
        private System.Windows.Forms.Label telemovelLbl;
        private System.Windows.Forms.TextBox dataTxt;
        private System.Windows.Forms.TextBox telemovelTxt;
        private System.Windows.Forms.Label moradaLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.TextBox moradaTxt;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.Label numFornecedorLbl;
        private System.Windows.Forms.TextBox numFornecedorTxt;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button removeBtn;
    }
}