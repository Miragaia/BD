INSERT INTO Higiliquidos.Empresa (NIF_Empresa, Nome, Email, Endereco, ContactoTelefonico) VALUES
(203551783,"Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",27196334);


INSERT INTO Higiliquidos.Carrinha (Matricula, Ano, Marca, Combustivel, Peso, NIF_Empresa) VALUES
("AA-09-BD", 2018, "Renault","Diesel",    1160, 203551783),
("CD-89-AK", 2014, "Mercedes","Gasolina", 5000, 203551783),
("EF-34-RT", 2019, "Fiat","Gasolina",     1500, 203551783),
("GH-56-LM", 2016, "Ford","Diesel",       2000, 203551783),
("IJ-78-NP", 2017, "Toyota","Gasolina",   2500, 203551783),
("KL-90-QR", 2020, "Dacia","Gasolina",    3000, 203551783),
("OP-45-UV", 2018, "Peugeot","Gasolina",  1800, 203551783),
("QR-67-WX", 2016, "Citroen","Diesel",    1900, 203551783);


INSERT INTO Higiliquidos.Armazem(ID, Area, Endereco, NIF_Empresa) VALUES
(0, 2100,"Rua 31 Janeiro, Arrifana",        203551783),
(1, 1700,"Rua 31 Janeiro, Arrifana",        203551783),
(2, 300, "Rua 31 Janeiro, Arrifana",        203551783),
(3, 400, "Rua Barroco da Cela 8, Arrifana", 203551783),
(4, 300, "Rua Barroco da Cela 8, Arrifana", 203551783);
 
 
INSERT INTO Higiliquidos.Pessoa (NIF, Nome, Data_de_Nascimento, Email, Morada, ContactoTelefonico, NIF_Empresa) VALUES
--Funcionarios
(294455765, "João Antonio",       "1983/10/05", 'joaoant@gmail.com',            "Rua Vou AliJaVenho",            931764532, 203551783),
(287649264, "Maria Silva",        "1990/03/12", 'maria.silva@gmail.com',        "Avenida Principal",             987854321, 203551783),
(287654321, "Pedro Santos",       "1985/07/07", 'pedro.santos@gmail.com',       "Rua das Flores",                977888999, 203551783),
(295748365, "Ana Sousa",          "1995/09/22", 'ana.sousa@gmail.com',          "Travessa das Oliveiras",        911022333, 203551783),
(211111111, "Carlos Costa",       "1978/05/19", 'carlos.costa@gmail.com',       "Rua dos Amigos",                955444333, 203551783),
(222222222, "Sofia Rodrigues",    "1992/08/14", 'sofia.rodrigues@gmail.com',    "Avenida Central",               966777888, 203551783),
(299999999, "Rita Pereira",       "1989/11/28", 'rita.pereira@gmail.com',       "Praça da Liberdade",            922330444, 203551783),
(288888888, "Luis Mendes",        "1987/02/02", 'luis.mendes@gmail.com',        "Rua Nova",                      977111333, 203551783),
(277777777, "Andre Almeida",      "1998/06/15", 'andre.almeida@gmail.com',      "Travessa dos Cravos",           999444555, 203551783),
(266666666, "Marta Gomes",        "1993/09/10", 'marta.gomes@gmail.com',        "Avenida da Paz",                923456789, 203551783),
(244444444, "Ricardo Ferreira",   "1980/12/25", 'ricardo.ferreira@gmail.com',   "Rua dos Sonhos",                944555666, 203551783),
(233333333, "Inês Pereira",       "1996/07/18", 'ines.pereira@gmail.com',       "Praça dos Leões",               989123456, 203551783),
(222222333, "Paulo Marques",      "1984/03/30", 'paulo.marques@gmail.com',      "Rua das Gaivotas",              987684321, 203551783),
(223456789, "Patricia Santos",    "1991/06/08", 'patricia.santos@gmail.com',    "Avenida das Flores",            955666777, 203551783),
(255666777, "Hugo Carvalho",      "1988/02/14", 'hugo.carvalho@gmail.com',      "Rua das Estrelas",              999888777, 203551783),
--Fornecedores
(277888999, "Mariana Costa",      "1994/11/03", 'mariana.costa@gmail.com',      "Travessa dos Lírios",           911222333, 203551783),
(299888777, "Rui Oliveira",       "1986/07/27", 'rui.oliveira@gmail.com',       "Avenida dos Pinheiros",         944505666, 203551783),
(211222333, "Carolina Fernandes", "1997/04/19", 'carolina.fernandes@gmail.com', "Rua dos Girassóis",             977808999, 203551783),
(244555666, "Diogo Pereira",      "1992/09/13", 'diogo.pereira@gmail.com',      "Travessa das Margaridas",       922333444, 203551783),

--Clientes
(277111000, "Mariana Almeida",    "1987/11/11", 'mariana.almeida@gmail.com',     "Travessa das Margaridas, 654", 911555444, 203551783),
(288333444, "Luana Costa",        "1993/04/26", 'luana.costa@gmail.com',         "Rua das Árvores, 321",         977333222, 203551783),
(255000111, "Hugo Mendonça",      "1988/08/02", 'hugo.mendonca@gmail.com',       "Praça dos Girafas, 987",       999222111, 203551783),
(233222111, "Gustavo Oliveira",   "1990/09/19", 'gustavo.oliveira@gmail.com',    "Rua das Estrelas, 456",        966444555, 203551783),
(288111000, "Luana Rodrigues",    "1985/03/10", 'luana.rodrigues@gmail.com',     "Travessa dos Cravos, 789",     977111222, 203551783),
(211343222, "Carolina Ferreira",  "1997/07/27", 'carolina.ferreira@gmail.com',   "Avenida das Flores, 654",      955333444, 203551783),
(299444555, "Rui Santos",         "1989/06/08", 'rui.santos@gmail.com',          "Rua dos Girassóis, 321",       922444555, 203551783),
(277555666, "Mariana Costa",      "1994/01/15", 'mariana.costa1@gmail.com',      "Avenida dos Pinheiros, 987",   911555666, 203551783),
(288666777, "Luís Almeida",       "1986/08/22", 'luis.almeida@gmail.com',        "Travessa das Margaridas, 654", 977666777, 203551783),
(255777588, "Hugo Pereira",       "1991/05/07", 'hugo.pereira@gmail.com',        "Rua das Árvores, 321",         944777888, 203551783),
(233888999, "Inês Silva",         "1995/12/24", 'ines.silva@gmail.com',          "Praça dos Lírios, 789",        989888999, 203551783),
(299999000, "Rita Mendes",        "1984/02/11", 'rita.mends@gmail.com',          "Rua Nova, 456",                922999000, 203551783),
(211000111, "Carlos Rodrigues",   "1998/10/28", 'carlos.rodrigues@gmail.com',    "Avenida Principal, 654",       955000111, 203551783),
(233202111, "Gustavo Oliveira",   "1990/09/19", 'gustavo.oliveirinha@gmail.com', "Rua das Estrelas, 456",        966044555, 203551783),
(288101000, "Luana Rodrigues",    "1985/03/10", 'luana.rodrigues2@gmail.com',    "Travessa dos Cravos, 789",     907111222, 203551783),
(211313222, "Carolina Ferreira",  "1997/07/27", 'carolina.ferreira1@gmail.com',  "Avenida das Flores, 654",      955303444, 203551783),
(299444055, "Rui Santos",         "1989/06/08", 'rui.sants@gmail.com',           "Rua dos Girassóis, 321",       922444155, 203551783),
(277505666, "Mariana Costa",      "1994/01/15", 'mariana.costa2@gmail.com',      "Avenida dos Pinheiros, 987",   911551666, 203551783),
(288666707, "Luís Almeida",       "1986/08/22", 'luis.almeida3@gmail.com',       "Travessa das Margaridas, 654", 977266777, 203551783),
(255777878, "Hugo Pereira",       "1991/05/07", 'hugo.pereira1@gmail.com',       "Rua das Árvores, 321",         944777828, 203551783),
(233808999, "Inês Silva",         "1995/12/24", 'ines.silva1@gmail.com',         "Praça dos Lírios, 789",        989883999, 203551783),
(299939000, "Rita Mendes",        "1984/02/11", 'rita.mendes@gmail.com',         "Rua Nova, 456",                922929000, 203551783),
(211000181, "Carlos Rodrigues",   "1998/10/28", 'carlos.rodrigues2@gmail.com',   "Avenida Principal, 654",       955040111, 203551783),
(233232111, "Gustavo Oliveira",   "1990/09/19", 'gustavo.oliveirota@gmail.com',  "Rua das Estrelas, 456",        966494555, 203551783),
(288121000, "Luana Rodrigues",    "1985/03/10", 'luana.rodriguesrrr@gmail.com',  "Travessa dos Cravos, 789",     977191222, 203551783),
(211383222, "Carolina Ferreira",  "1997/07/27", 'carolina.ferreira2@gmail.com',  "Avenida das Flores, 654",      955333494, 203551783),
(299484555, "Rui Santos",         "1989/06/08", 'rui.santos1@gmail.com',         "Rua dos Girassóis, 321",       922444565, 203551783),
(279505666, "Mariana Costa",      "1994/01/15", 'mariana.costa3@gmail.com',      "Avenida dos Pinheiros, 987",   911575666, 203551783),
(289666777, "Luís Almeida",       "1986/08/22", 'luis.almeida4@gmail.com',       "Travessa das Margaridas, 654", 977686777, 203551783),
(211900111, "Carlos Rodrigues",   "1998/10/28", 'carlos.rodriguesss@gmail.com',  "Avenida Principal, 654",       955090111, 203551783);


INSERT INTO Higiliquidos.Produto (ID, Nome, Marca, Tipo_de_Produto, IVA, Preco, Quantidade) VALUES
(0, "Amaciador",                    "Pantene",      "Cabelo",    23, 5.99, 100),
(1, "Detergente para Louça",        "Fairy",        "Limpeza",   23, 2.99, 200),
(2, "Limpador Multiuso",            "Veja",         "Limpeza",   23, 4.49, 150),
(3, "Amaciador de Roupas",          "Comfort",      "Roupa",     23, 3.99, 100),
(4, "Lustra Móveis",                "Mr. Proper",   "Limpeza",   23, 3.29, 120),
(5, "Sabão em Pó",                  "Omo",          "Roupa",     23, 6.99, 180),
(6, "Desinfetante",                 "Lysoform",     "Limpeza",   23, 3.99, 80 ),
(7, "Limpa Vidros",                 "Ajax",         "Limpeza",   23, 2.49, 120),
(8, "Esponja de Limpeza",           "Scotch-Brite", "Acessório", 23, 1.99, 300),
(9, "Pano de Microfibra",           "Flash",        "Acessório", 23, 2.99, 250),
(10, "Desodorizante de Ambiente",   "Ambi Pur",     "Limpeza",   23, 4.99, 150),
(11, "Alvejante",                   "Qboa",         "Limpeza",   23, 3.49, 100),
(12, "Saco de Lixo",                "Plasvale",     "Acessório", 23, 5.99, 200),
(13, "Limpador de Banheiro",        "Sanol",        "Limpeza",   23, 3.79, 150),
(14, "Água Sanitária",              "Brilux",       "Limpeza",   23, 2.29, 120),
(15, "Vassoura",                    "Condor",       "Acessório", 23, 6.99, 100),
(16, "Limpador de Carpete",         "Vanish",       "Limpeza",   23, 8.99, 80 ),
(17, "Esponja de Aço",              "Bombril",      "Acessório", 23, 1.49, 200),
(18, "Detergente Desengordurante",  "Sun",          "Limpeza",   23, 4.99, 150),
(19, "Pano de Limpeza Descartável", "Dexter",       "Acessório", 23, 3.49, 250);


INSERT INTO Higiliquidos.Cliente (NIF_Cliente, Num_Cliente) VALUES
(277111000, 1),
(288333444, 2),
(255000111, 3), 
(233222111, 4), 
(288111000, 5),
(211343222, 6),
(299444555, 7),
(277555666, 8),
(288666777, 9),
(255777588, 10),
(233888999, 11),
(299999000, 12),
(211000111, 13),
(233202111, 14),
(288101000, 15),
(211313222, 16),
(299444055, 17),
(277505666, 18),
(288666707, 19),
(255777878, 20),
(233808999, 21),
(299939000, 22),
(211000181, 23),
(233232111, 24),
(288121000, 25),
(211383222, 26),
(299484555, 27),
(279505666, 28),
(289666777, 29),
(211900111, 30);


INSERT INTO Higiliquidos.Fornecedor (NIF_Fornecedor, Num_Fornecedor) VALUES
(277888999, 1), 
(299888777, 2), 
(211222333, 3),
(244555666, 4);



INSERT INTO Higiliquidos.Funcionario (NIF_Funcionario, IBAN, Data_Inicio_Atividade, Numero_SS, Num_Func) VALUES
--Vendedor
(294455765, "PT50000201231234567890154", "2018/06/15", 200000000, 1),
(287649264, "PT50000392221234567890155", "2018/06/15", 200000001, 2),
(287654321, "PT50000423451234567890156", "2018/06/15", 200000101, 3),
(295748365, "PT50000584321234567890157", "2018/06/15", 200000003, 4),
(211111111, "PT50000698741234567890158", "2018/06/15", 200000004, 5),
(222222222, "PT50000765431234567890159", "2019/06/04", 200000005, 6),
(299999999, "PT50000812971234567890160", "2019/06/04", 200000006, 7),
--Distribuidor
(288888888, "PT50000900981234567890161", "2019/06/04", 200000007, 8),
(277777777, "PT50001049761234567890162", "2019/06/04", 200000008, 9),
(266666666, "PT50001132821234567890163", "2020/09/10", 200000009, 10),
(244444444, "PT50001278311234567890164", "2020/12/09", 200000405, 11),
(233333333, "PT50001364521234567890165", "2021/07/18", 200000401, 12),
(222222333, "PT50001423091234567890166", "2022/03/30", 200000601, 13),
(223456789, "PT50001554141234567890167", "2022/06/08", 200000701, 14),
--Gerente
(255666777, "PT50001686771234567890168", "2022/02/14", 200000801, 15);


INSERT INTO Higiliquidos.Gerente (Num_Gerente, Num_Func) VALUES
(1, 15);


INSERT INTO Higiliquidos.Distribuidor (Num_Distribuidor, Num_Func) VALUES
(1, 8),
(2, 9),
(3, 10),
(4, 11),
(5, 12),
(6, 13),
(7, 14);


INSERT INTO Higiliquidos.Vendedor (Num_Vendedor, Num_Func) VALUES
(1, 1),
(2, 2),
(3, 3),
(4, 4),
(5, 5),
(6, 6),
(7, 7);


INSERT INTO Higiliquidos.Carrinha_Distribuidor (Matricula, Num_Distribuidor, Data_In, Data_Out) VALUES
("AA-09-BD", 1, "2018/03/15", "2019/07/20"),
("CD-89-AK", 2, "2018/03/15", NULL),
("EF-34-RT", 3, "2018/03/15", NULL),
("GH-56-LM", 4, "2018/03/15", NULL),
("IJ-78-NP", 5, "2018/04/04", NULL),
("KL-90-QR", 6, "2018/04/04", NULL),
("OP-45-UV", 7, "2018/04/04", NULL),
("QR-67-WX", 1, "2019/07/21", NULL);


INSERT INTO Higiliquidos.Compra (ID, Data_Compra, Quantidade, ID_Produto, ID_Armazem, Num_Fornecedor) VALUES
(0,  "2018/06/15", 300, 0,  0, 1),
(1,  "2018/06/15", 200, 1,  1, 2),
(2,  "2018/06/15", 250, 2,  2, 3),
(3,  "2018/06/17", 200, 3,  3, 4),
(4,  "2018/08/17", 320, 4,  4, 1),
(5,  "2018/08/17", 280, 5,  0, 2),
(6,  "2018/08/17", 180, 6,  1, 3),
(7,  "2018/08/17", 120, 7,  2, 4),
(8,  "2018/08/17", 300, 8,  3, 1),
(9,  "2018/08/17", 250, 9,  4, 2),
(10, "2018/10/09", 150, 10, 0, 3),
(11, "2018/10/09", 100, 11, 1, 4),
(12, "2018/10/09", 200, 12, 2, 1),
(13, "2018/10/09", 150, 13, 3, 2),
(14, "2018/10/09", 120, 14, 4, 3),
(15, "2018/10/09", 100, 15, 0, 4),
(16, "2018/10/15", 180, 16, 1, 1),
(17, "2018/10/15", 200, 17, 2, 2),
(18, "2018/10/15", 150, 18, 3, 3),
(19, "2018/10/15", 100, 19, 4, 4),
(20, "2019/01/07", 100, 0,  0, 1),
(21, "2019/01/07", 200, 1,  1, 2),
(22, "2019/01/07", 150, 2,  2, 3),
(23, "2019/02/13", 100, 3,  3, 4),
(24, "2019/02/13", 120, 4,  4, 1),
(25, "2019/02/13", 180, 5,  0, 2),
(26, "2019/02/13", 280, 6,  1, 3),
(27, "2019/02/21", 120, 7,  2, 4),
(28, "2019/02/21", 300, 8,  3, 1),
(29, "2019/02/21", 250, 9,  4, 2),
(30, "2019/02/21", 150, 10, 0, 3),


INSERT INTO Higiliquidos.Venda (ID, Quantidade, ID_Produto, ID_Armazem, Num_Vendedor, Num_Distribuidor, Num_Cliente) VALUES
(1,  20,  0,  0, 1, 1, 1 ),   
(2,  30,  1,  1, 2, 2, 2 ),
(3,  10,  2,  2, 3, 3, 3 ),
(4,  40,  3,  3, 4, 4, 4 ),
(5,  10,  4,  4, 5, 5, 5 ),
(6,  10,  5,  0, 6, 6, 6 ),
(7,  12,  6,  1, 7, 7, 7 ),
(8,  14,  7,  2, 1, 1, 8 ),
(9,  16,  8,  3, 2, 2, 9 ),
(10, 20,  9,  4, 3, 3, 10),
(11, 30,  10, 0, 4, 4, 11),
(12, 50,  11, 1, 5, 5, 12),
(13, 24,  12, 2, 6, 6, 13),
(14, 22,  13, 3, 7, 7, 14),
(15, 12,  14, 4, 1, 1, 15),
(16, 10,  15, 0, 2, 2, 16),
(17, 5,   16, 1, 3, 3, 17),
(18, 7,   17, 2, 4, 4, 18),
(19, 23,  18, 3, 5, 5, 19),
(20, 5,   19, 4, 6, 6, 20),
(21, 12,  0,  0, 7, 7, 21),
(22, 50,  1,  1, 1, 1, 22),
(23, 10,  2,  2, 2, 2, 23),
(24, 18,  3,  3, 3, 3, 24),
(25, 19,  4,  4, 4, 4, 25),
(26, 14,  5,  0, 5, 5, 26),
(27, 22,  6,  1, 6, 6, 27),
(28, 30,  7,  2, 7, 7, 28),
(29, 10,  8,  3, 1, 1, 29),
(30, 10,  9,  4, 2, 2, 30),
(31, 15,  10, 0, 3, 3, 1 ),
(32, 15,  11, 1, 4, 4, 2 ),
(33, 15,  12, 2, 5, 5, 3 ),
(34, 15,  13, 3, 6, 6, 4 ),
(35, 15,  14, 4, 7, 7, 5 ),
(36, 15,  15, 0, 1, 1, 6 ),
(37, 15,  16, 1, 2, 2, 7 ),
(38, 15,  17, 2, 3, 3, 8 ),
(39, 15,  18, 3, 4, 4, 9 ),
(40, 15,  19, 4, 5, 5, 10),
(41, 34,  0,  0, 6, 6, 11),
(42, 25,  1,  1, 7, 7, 12),
(43, 40,  2,  2, 1, 1, 13),
(44, 27,  3,  3, 2, 2, 14),
(45, 29,  4,  4, 3, 3, 15),
(46, 15,  5,  0, 4, 4, 16),
(47, 5,   6,  1, 5, 5, 17),
(48, 10,  7,  2, 6, 6, 18),
(49, 20,  8,  3, 7, 7, 19),
(50, 30,  9,  4, 1, 1, 20);


INSERT INTO Higiliquidos.Entrega (Data_Entrega, ID_Venda, Num_Distribuidor) VALUES
("2018/07/15", 1,  1),
("2018/07/15", 2,  2),
("2018/07/15", 3,  3),
("2018/07/17", 4,  4),
("2018/09/17", 5,  5),
("2018/09/17", 6,  6),
("2018/09/17", 7,  7),
("2018/09/17", 8,  1),
("2018/09/17", 9,  2),
("2018/09/17", 10, 3),
("2018/12/09", 11, 4),
("2018/12/09", 12, 5),
("2018/12/09", 13, 6),
("2018/12/09", 14, 7),
("2018/12/09", 15, 1),
("2018/12/09", 16, 2),
("2018/12/15", 17, 3),
("2018/12/15", 18, 4),
("2018/12/15", 19, 5),
("2018/12/15", 20, 6),
("2019/02/07", 21, 7),
("2019/02/07", 22, 1),
("2019/02/07", 23, 2),
("2019/03/13", 24, 3),
("2019/03/13", 25, 4),
("2019/03/13", 26, 5),
("2019/03/13", 27, 6),
("2019/03/21", 28, 7),
("2019/03/21", 29, 1),
("2019/03/21", 30, 2),
("2019/03/21", 31, 3),
("2019/03/21", 32, 4),
("2019/03/21", 33, 5),
("2019/03/21", 34, 6),
("2019/03/21", 35, 7),
("2019/03/21", 36, 1),
("2019/03/21", 37, 2),
("2019/03/21", 38, 3),
("2019/03/21", 39, 4),
("2019/03/21", 40, 5),
("2019/03/21", 41, 6),
("2019/03/21", 42, 7),
("2019/03/21", 43, 1),
("2019/03/21", 44, 2),
("2019/03/21", 45, 3),
("2019/03/21", 46, 4),
("2019/03/21", 47, 5),
("2019/03/21", 48, 6),
("2019/03/21", 49, 7),
("2019/03/21", 50, 1);















