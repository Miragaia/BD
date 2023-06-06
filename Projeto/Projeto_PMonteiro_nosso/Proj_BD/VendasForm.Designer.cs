
namespace Proj_BD
{
    partial class VendasForm
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
            this.id_prodLbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gobackBtn = new System.Windows.Forms.Button();
            this.idVendaTXT = new System.Windows.Forms.TextBox();
            this.quantLb = new System.Windows.Forms.Label();
            this.idProdLbl = new System.Windows.Forms.Label();
            this.IDProdTXT = new System.Windows.Forms.TextBox();
            this.idArmLbl = new System.Windows.Forms.Label();
            this.IDArmTXT = new System.Windows.Forms.TextBox();
            this.nomeVendLbl = new System.Windows.Forms.Label();
            this.nomeVendTXT = new System.Windows.Forms.TextBox();
            this.nomeDisLbl = new System.Windows.Forms.Label();
            this.NumDistTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NIFClientTXT = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.nome_CTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nome_distTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nome_VendTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ID_ProdTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ID_VendaTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Nome_ProdTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Type_ProdTxt = new System.Windows.Forms.TextBox();
            this.ID_ArmTxt = new System.Windows.Forms.TextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.quantTXT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataEntTxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.data_vendaTXT = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // id_prodLbl
            // 
            this.id_prodLbl.AutoSize = true;
            this.id_prodLbl.Location = new System.Drawing.Point(62, 513);
            this.id_prodLbl.Name = "id_prodLbl";
            this.id_prodLbl.Size = new System.Drawing.Size(72, 15);
            this.id_prodLbl.TabIndex = 7;
            this.id_prodLbl.Text = "ID da Venda:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 119);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1415, 308);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // gobackBtn
            // 
            this.gobackBtn.Location = new System.Drawing.Point(33, 454);
            this.gobackBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gobackBtn.Name = "gobackBtn";
            this.gobackBtn.Size = new System.Drawing.Size(108, 25);
            this.gobackBtn.TabIndex = 9;
            this.gobackBtn.Text = "Go back";
            this.gobackBtn.UseVisualStyleBackColor = true;
            this.gobackBtn.Click += new System.EventHandler(this.gobackBtn_Click);
            // 
            // idVendaTXT
            // 
            this.idVendaTXT.Location = new System.Drawing.Point(170, 510);
            this.idVendaTXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idVendaTXT.Name = "idVendaTXT";
            this.idVendaTXT.Size = new System.Drawing.Size(154, 23);
            this.idVendaTXT.TabIndex = 10;
            this.idVendaTXT.TextChanged += new System.EventHandler(this.nomeTxt_TextChanged);
            // 
            // quantLb
            // 
            this.quantLb.AutoSize = true;
            this.quantLb.Location = new System.Drawing.Point(343, 512);
            this.quantLb.Name = "quantLb";
            this.quantLb.Size = new System.Drawing.Size(72, 15);
            this.quantLb.TabIndex = 12;
            this.quantLb.Text = "Quantidade:";
            // 
            // idProdLbl
            // 
            this.idProdLbl.AutoSize = true;
            this.idProdLbl.Location = new System.Drawing.Point(62, 550);
            this.idProdLbl.Name = "idProdLbl";
            this.idProdLbl.Size = new System.Drawing.Size(84, 15);
            this.idProdLbl.TabIndex = 13;
            this.idProdLbl.Text = "ID do Produto:";
            // 
            // IDProdTXT
            // 
            this.IDProdTXT.Location = new System.Drawing.Point(170, 547);
            this.IDProdTXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IDProdTXT.Name = "IDProdTXT";
            this.IDProdTXT.Size = new System.Drawing.Size(154, 23);
            this.IDProdTXT.TabIndex = 14;
            this.IDProdTXT.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // idArmLbl
            // 
            this.idArmLbl.AutoSize = true;
            this.idArmLbl.Location = new System.Drawing.Point(517, 550);
            this.idArmLbl.Name = "idArmLbl";
            this.idArmLbl.Size = new System.Drawing.Size(92, 15);
            this.idArmLbl.TabIndex = 16;
            this.idArmLbl.Text = "ID do Armazem:";
            // 
            // IDArmTXT
            // 
            this.IDArmTXT.Location = new System.Drawing.Point(642, 547);
            this.IDArmTXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IDArmTXT.Name = "IDArmTXT";
            this.IDArmTXT.Size = new System.Drawing.Size(154, 23);
            this.IDArmTXT.TabIndex = 17;
            // 
            // nomeVendLbl
            // 
            this.nomeVendLbl.AutoSize = true;
            this.nomeVendLbl.Location = new System.Drawing.Point(517, 513);
            this.nomeVendLbl.Name = "nomeVendLbl";
            this.nomeVendLbl.Size = new System.Drawing.Size(113, 15);
            this.nomeVendLbl.TabIndex = 18;
            this.nomeVendLbl.Text = "Nome do Vendedor:";
            // 
            // nomeVendTXT
            // 
            this.nomeVendTXT.Location = new System.Drawing.Point(642, 510);
            this.nomeVendTXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nomeVendTXT.Name = "nomeVendTXT";
            this.nomeVendTXT.Size = new System.Drawing.Size(154, 23);
            this.nomeVendTXT.TabIndex = 19;
            // 
            // nomeDisLbl
            // 
            this.nomeDisLbl.AutoSize = true;
            this.nomeDisLbl.Location = new System.Drawing.Point(828, 550);
            this.nomeDisLbl.Name = "nomeDisLbl";
            this.nomeDisLbl.Size = new System.Drawing.Size(125, 15);
            this.nomeDisLbl.TabIndex = 20;
            this.nomeDisLbl.Text = "Nome do Distribuidor:";
            // 
            // NumDistTXT
            // 
            this.NumDistTXT.Location = new System.Drawing.Point(957, 547);
            this.NumDistTXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NumDistTXT.Name = "NumDistTXT";
            this.NumDistTXT.Size = new System.Drawing.Size(154, 23);
            this.NumDistTXT.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(828, 511);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "NIF do Cliente:";
            // 
            // NIFClientTXT
            // 
            this.NIFClientTXT.Location = new System.Drawing.Point(957, 503);
            this.NIFClientTXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NIFClientTXT.Name = "NIFClientTXT";
            this.NIFClientTXT.Size = new System.Drawing.Size(154, 23);
            this.NIFClientTXT.TabIndex = 23;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(1177, 503);
            this.addBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(95, 25);
            this.addBtn.TabIndex = 24;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(1373, 25);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 25);
            this.searchBtn.TabIndex = 25;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // nome_CTxt
            // 
            this.nome_CTxt.Location = new System.Drawing.Point(1056, 64);
            this.nome_CTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nome_CTxt.Name = "nome_CTxt";
            this.nome_CTxt.Size = new System.Drawing.Size(178, 23);
            this.nome_CTxt.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(928, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 40;
            this.label2.Text = "Nome do Cliente:";
            // 
            // nome_distTxt
            // 
            this.nome_distTxt.Location = new System.Drawing.Point(743, 64);
            this.nome_distTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nome_distTxt.Name = "nome_distTxt";
            this.nome_distTxt.Size = new System.Drawing.Size(179, 23);
            this.nome_distTxt.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(618, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 15);
            this.label3.TabIndex = 38;
            this.label3.Text = "Nome do Distribuidor:";
            // 
            // nome_VendTxt
            // 
            this.nome_VendTxt.Location = new System.Drawing.Point(1094, 27);
            this.nome_VendTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nome_VendTxt.Name = "nome_VendTxt";
            this.nome_VendTxt.Size = new System.Drawing.Size(178, 23);
            this.nome_VendTxt.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(975, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 15);
            this.label4.TabIndex = 36;
            this.label4.Text = "Nome do Vendedor:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ID_ProdTxt
            // 
            this.ID_ProdTxt.Location = new System.Drawing.Point(132, 67);
            this.ID_ProdTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ID_ProdTxt.Name = "ID_ProdTxt";
            this.ID_ProdTxt.Size = new System.Drawing.Size(154, 23);
            this.ID_ProdTxt.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 15);
            this.label6.TabIndex = 31;
            this.label6.Text = "ID do Produto:";
            // 
            // ID_VendaTxt
            // 
            this.ID_VendaTxt.Location = new System.Drawing.Point(373, 27);
            this.ID_VendaTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ID_VendaTxt.Name = "ID_VendaTxt";
            this.ID_VendaTxt.Size = new System.Drawing.Size(154, 23);
            this.ID_VendaTxt.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(295, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 15);
            this.label8.TabIndex = 28;
            this.label8.Text = "ID da Venda:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(533, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 15);
            this.label7.TabIndex = 42;
            this.label7.Text = "Nome_Produto:";
            // 
            // Nome_ProdTxt
            // 
            this.Nome_ProdTxt.Location = new System.Drawing.Point(630, 27);
            this.Nome_ProdTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Nome_ProdTxt.Name = "Nome_ProdTxt";
            this.Nome_ProdTxt.Size = new System.Drawing.Size(154, 23);
            this.Nome_ProdTxt.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(579, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 15);
            this.label9.TabIndex = 44;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(334, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 15);
            this.label10.TabIndex = 46;
            this.label10.Text = "Tipo_de_Produto:";
            // 
            // Type_ProdTxt
            // 
            this.Type_ProdTxt.Location = new System.Drawing.Point(431, 64);
            this.Type_ProdTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Type_ProdTxt.Name = "Type_ProdTxt";
            this.Type_ProdTxt.Size = new System.Drawing.Size(154, 23);
            this.Type_ProdTxt.TabIndex = 47;
            // 
            // ID_ArmTxt
            // 
            this.ID_ArmTxt.Location = new System.Drawing.Point(899, 27);
            this.ID_ArmTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ID_ArmTxt.Name = "ID_ArmTxt";
            this.ID_ArmTxt.Size = new System.Drawing.Size(70, 23);
            this.ID_ArmTxt.TabIndex = 49;
            this.ID_ArmTxt.TextChanged += new System.EventHandler(this.textBox15_TextChanged);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(1177, 545);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(95, 25);
            this.deleteBtn.TabIndex = 50;
            this.deleteBtn.Text = "Delete Txt Boxs";
            this.deleteBtn.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1373, 60);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 25);
            this.button2.TabIndex = 51;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // quantTXT
            // 
            this.quantTXT.Location = new System.Drawing.Point(421, 509);
            this.quantTXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quantTXT.Name = "quantTXT";
            this.quantTXT.Size = new System.Drawing.Size(58, 23);
            this.quantTXT.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 15);
            this.label5.TabIndex = 53;
            this.label5.Text = "Data de entrega:";
            // 
            // dataEntTxt
            // 
            this.dataEntTxt.Location = new System.Drawing.Point(132, 22);
            this.dataEntTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataEntTxt.Name = "dataEntTxt";
            this.dataEntTxt.Size = new System.Drawing.Size(154, 23);
            this.dataEntTxt.TabIndex = 54;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(343, 555);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 15);
            this.label12.TabIndex = 55;
            this.label12.Text = "Data de venda:";
            // 
            // data_vendaTXT
            // 
            this.data_vendaTXT.Location = new System.Drawing.Point(431, 547);
            this.data_vendaTXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.data_vendaTXT.Name = "data_vendaTXT";
            this.data_vendaTXT.Size = new System.Drawing.Size(80, 23);
            this.data_vendaTXT.TabIndex = 56;
            // 
            // VendasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1479, 614);
            this.Controls.Add(this.data_vendaTXT);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dataEntTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.quantTXT);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.ID_ArmTxt);
            this.Controls.Add(this.Type_ProdTxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Nome_ProdTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nome_CTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nome_distTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nome_VendTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ID_ProdTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ID_VendaTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.NIFClientTXT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumDistTXT);
            this.Controls.Add(this.nomeDisLbl);
            this.Controls.Add(this.nomeVendTXT);
            this.Controls.Add(this.nomeVendLbl);
            this.Controls.Add(this.IDArmTXT);
            this.Controls.Add(this.idArmLbl);
            this.Controls.Add(this.IDProdTXT);
            this.Controls.Add(this.idProdLbl);
            this.Controls.Add(this.quantLb);
            this.Controls.Add(this.idVendaTXT);
            this.Controls.Add(this.gobackBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.id_prodLbl);
            this.Name = "VendasForm";
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.VendasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label id_prodLbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button gobackBtn;
        private System.Windows.Forms.TextBox idVendaTXT;
        private System.Windows.Forms.Label quantLb;
        private System.Windows.Forms.Label idProdLbl;
        private System.Windows.Forms.TextBox IDProdTXT;
        private System.Windows.Forms.Label idArmLbl;
        private System.Windows.Forms.TextBox IDArmTXT;
        private System.Windows.Forms.Label nomeVendLbl;
        private System.Windows.Forms.TextBox nomeVendTXT;
        private System.Windows.Forms.Label nomeDisLbl;
        private System.Windows.Forms.TextBox NumDistTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NumClientTXT;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox nome_CTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nome_distTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nome_VendTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ID_ProdTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ID_VendaTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Nome_ProdTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Type_ProdTxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ID_ArmTxt;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox quantTXT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dataEntTxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox data_vendaTXT;
        private System.Windows.Forms.TextBox NIFClientTXT;
    }
}