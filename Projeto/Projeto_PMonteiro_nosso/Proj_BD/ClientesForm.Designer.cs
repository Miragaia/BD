
namespace Proj_BD
{
    partial class ClientesForm
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
            this.nomeTxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gobackBtn = new System.Windows.Forms.Button();
            this.nifTxt = new System.Windows.Forms.TextBox();
            this.nomeLbl = new System.Windows.Forms.Label();
            this.nifLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.dataLbl = new System.Windows.Forms.Label();
            this.dataTxt = new System.Windows.Forms.TextBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.moradaLbl = new System.Windows.Forms.Label();
            this.telemovelLbl = new System.Windows.Forms.Label();
            this.moradaTxt = new System.Windows.Forms.TextBox();
            this.telemovelTxt = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.numClientLbl = new System.Windows.Forms.Label();
            this.numClientTxt = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeTxt
            // 
            this.nomeTxt.Location = new System.Drawing.Point(60, 9);
            this.nomeTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nomeTxt.Name = "nomeTxt";
            this.nomeTxt.Size = new System.Drawing.Size(154, 23);
            this.nomeTxt.TabIndex = 0;
            this.nomeTxt.TextChanged += new System.EventHandler(this.nomeTxt_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 94);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1083, 350);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // gobackBtn
            // 
            this.gobackBtn.Location = new System.Drawing.Point(12, 463);
            this.gobackBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gobackBtn.Name = "gobackBtn";
            this.gobackBtn.Size = new System.Drawing.Size(108, 25);
            this.gobackBtn.TabIndex = 2;
            this.gobackBtn.Text = "Go back";
            this.gobackBtn.UseVisualStyleBackColor = true;
            this.gobackBtn.Click += new System.EventHandler(this.goBackBtn_Click);
            // 
            // nifTxt
            // 
            this.nifTxt.Location = new System.Drawing.Point(60, 46);
            this.nifTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nifTxt.Name = "nifTxt";
            this.nifTxt.Size = new System.Drawing.Size(154, 23);
            this.nifTxt.TabIndex = 3;
            this.nifTxt.TextChanged += new System.EventHandler(this.nifTxt_TextChanged);
            // 
            // nomeLbl
            // 
            this.nomeLbl.AutoSize = true;
            this.nomeLbl.Location = new System.Drawing.Point(10, 12);
            this.nomeLbl.Name = "nomeLbl";
            this.nomeLbl.Size = new System.Drawing.Size(43, 15);
            this.nomeLbl.TabIndex = 6;
            this.nomeLbl.Text = "Nome:";
            // 
            // nifLbl
            // 
            this.nifLbl.AutoSize = true;
            this.nifLbl.Location = new System.Drawing.Point(10, 49);
            this.nifLbl.Name = "nifLbl";
            this.nifLbl.Size = new System.Drawing.Size(28, 15);
            this.nifLbl.TabIndex = 7;
            this.nifLbl.Text = "NIF:";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Location = new System.Drawing.Point(486, 46);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(39, 15);
            this.emailLbl.TabIndex = 8;
            this.emailLbl.Text = "Email:";
            // 
            // dataLbl
            // 
            this.dataLbl.AutoSize = true;
            this.dataLbl.Location = new System.Drawing.Point(228, 12);
            this.dataLbl.Name = "dataLbl";
            this.dataLbl.Size = new System.Drawing.Size(115, 15);
            this.dataLbl.TabIndex = 9;
            this.dataLbl.Text = "Data de nascimento:";
            // 
            // dataTxt
            // 
            this.dataTxt.Location = new System.Drawing.Point(360, 10);
            this.dataTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataTxt.Name = "dataTxt";
            this.dataTxt.Size = new System.Drawing.Size(120, 23);
            this.dataTxt.TabIndex = 10;
            this.dataTxt.TextChanged += new System.EventHandler(this.dataTxt_TextChanged);
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(548, 44);
            this.emailTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(179, 23);
            this.emailTxt.TabIndex = 11;
            this.emailTxt.TextChanged += new System.EventHandler(this.emailTxt_TextChanged);
            // 
            // moradaLbl
            // 
            this.moradaLbl.AutoSize = true;
            this.moradaLbl.Location = new System.Drawing.Point(486, 11);
            this.moradaLbl.Name = "moradaLbl";
            this.moradaLbl.Size = new System.Drawing.Size(51, 15);
            this.moradaLbl.TabIndex = 12;
            this.moradaLbl.Text = "Morada:";
            // 
            // telemovelLbl
            // 
            this.telemovelLbl.AutoSize = true;
            this.telemovelLbl.Location = new System.Drawing.Point(228, 49);
            this.telemovelLbl.Name = "telemovelLbl";
            this.telemovelLbl.Size = new System.Drawing.Size(63, 15);
            this.telemovelLbl.TabIndex = 13;
            this.telemovelLbl.Text = "Telemovel:";
            // 
            // moradaTxt
            // 
            this.moradaTxt.Location = new System.Drawing.Point(548, 10);
            this.moradaTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.moradaTxt.Name = "moradaTxt";
            this.moradaTxt.Size = new System.Drawing.Size(179, 23);
            this.moradaTxt.TabIndex = 14;
            this.moradaTxt.TextChanged += new System.EventHandler(this.moradaTxt_TextChanged);
            // 
            // telemovelTxt
            // 
            this.telemovelTxt.Location = new System.Drawing.Point(360, 44);
            this.telemovelTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.telemovelTxt.Name = "telemovelTxt";
            this.telemovelTxt.Size = new System.Drawing.Size(120, 23);
            this.telemovelTxt.TabIndex = 15;
            this.telemovelTxt.TextChanged += new System.EventHandler(this.telemovelTxt_TextChanged);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(1062, 7);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 25);
            this.searchBtn.TabIndex = 16;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(982, 44);
            this.removeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(75, 25);
            this.removeBtn.TabIndex = 17;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(1063, 41);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 25);
            this.clearBtn.TabIndex = 18;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // numClientLbl
            // 
            this.numClientLbl.AutoSize = true;
            this.numClientLbl.Location = new System.Drawing.Point(732, 11);
            this.numClientLbl.Name = "numClientLbl";
            this.numClientLbl.Size = new System.Drawing.Size(92, 15);
            this.numClientLbl.TabIndex = 21;
            this.numClientLbl.Text = "Num do cliente:";
            // 
            // numClientTxt
            // 
            this.numClientTxt.Location = new System.Drawing.Point(836, 9);
            this.numClientTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numClientTxt.Name = "numClientTxt";
            this.numClientTxt.Size = new System.Drawing.Size(127, 23);
            this.numClientTxt.TabIndex = 22;
            this.numClientTxt.TextChanged += new System.EventHandler(this.numClientTxt_TextChanged);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(982, 7);
            this.addBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 25);
            this.addBtn.TabIndex = 23;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // ClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 505);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.numClientTxt);
            this.Controls.Add(this.numClientLbl);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.telemovelTxt);
            this.Controls.Add(this.moradaTxt);
            this.Controls.Add(this.telemovelLbl);
            this.Controls.Add(this.moradaLbl);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.dataTxt);
            this.Controls.Add(this.dataLbl);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.nifLbl);
            this.Controls.Add(this.nomeLbl);
            this.Controls.Add(this.nifTxt);
            this.Controls.Add(this.gobackBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.nomeTxt);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ClientesForm";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.PessoasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button gobackBtn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label numClientLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label nomeLbl;
        private System.Windows.Forms.Label nifLbl;
        private System.Windows.Forms.Label dataLbl;
        private System.Windows.Forms.Label moradaLbl;
        private System.Windows.Forms.Label telemovelLbl;
        private System.Windows.Forms.TextBox nomeTxt;
        private System.Windows.Forms.TextBox nifTxt;
        private System.Windows.Forms.TextBox dataTxt;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.TextBox moradaTxt;
        private System.Windows.Forms.TextBox telemovelTxt;
        private System.Windows.Forms.TextBox numClientTxt;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label emailLbl;
    }
}