INSERT INTO Higiliquidos.Produto (ID, Nome, Marca, Tipo_de_Produto, IVA, Preco, Quantidade) VALUES
(0, "Amaciador", "Pantene", "Cabelo", 23, 5.99, 100),
(1, "Detergente para Louça", "Fairy", "Limpeza", 23, 2.99, 200),
(2, "Limpador Multiuso", "Veja", "Limpeza", 23, 4.49, 150),
(3, "Amaciador de Roupas", "Comfort", "Roupa", 23, 3.99, 100),
(4, "Lustra Móveis", "Mr. Proper", "Limpeza", 23, 3.29, 120),
(5, "Sabão em Pó", "Omo", "Roupa", 23, 6.99, 180),
(6, "Desinfetante", "Lysoform", "Limpeza", 23, 3.99, 80),
(7, "Limpa Vidros", "Ajax", "Limpeza", 23, 2.49, 120),
(8, "Esponja de Limpeza", "Scotch-Brite", "Acessório", 23, 1.99, 300),
(9, "Pano de Microfibra", "Flash", "Acessório", 23, 2.99, 250),
(10, "Desodorizante de Ambiente", "Ambi Pur", "Limpeza", 23, 4.99, 150),
(11, "Alvejante", "Qboa", "Limpeza", 23, 3.49, 100),
(12, "Saco de Lixo", "Plasvale", "Acessório", 23, 5.99, 200),
(13, "Limpador de Banheiro", "Sanol", "Limpeza", 23, 3.79, 150),
(14, "Água Sanitária", "Brilux", "Limpeza", 23, 2.29, 120),
(15, "Vassoura", "Condor", "Acessório", 23, 6.99, 100),
(16, "Limpador de Carpete", "Vanish", "Limpeza", 23, 8.99, 80),
(17, "Esponja de Aço", "Bombril", "Acessório", 23, 1.49, 200),
(18, "Detergente Desengordurante", "Sun", "Limpeza", 23, 4.99, 150),
(19, "Pano de Limpeza Descartável", "Dexter", "Acessório", 23, 3.49, 250);


INSERT INTO Higiliquidos.Armazem(ID, Tamanho, Endereco, ID_Produto) VALUES
(0,2100,"Rua 31 Janeiro, Arrifana", 0),
(0,2100,"Rua 31 Janeiro, Arrifana", 1),
(0,2100,"Rua 31 Janeiro, Arrifana", 2),
(0,2100,"Rua 31 Janeiro, Arrifana", 3),
(1,2100,"Rua 31 Janeiro, Arrifana", 4),
(1,1500,"Rua 31 Janeiro, Arrifana", 5),
(1,1500,"Rua 31 Janeiro, Arrifana", 6),
(1,1500,"Rua 31 Janeiro, Arrifana", 7),
(2,300,"Rua 31 Janeiro, Arrifana", 8),
(2,300,"Rua 31 Janeiro, Arrifana", 9),
(2,300,"Rua 31 Janeiro, Arrifana", 10),
(2,300,"Rua 31 Janeiro, Arrifana", 11),
(3,150,"Rua Barroco da Cela 8, Arrifana", 12),
(3,150,"Rua Barroco da Cela 8, Arrifana", 13),
(3,150,"Rua Barroco da Cela 8, Arrifana", 14),
(3,150,"Rua Barroco da Cela 8, Arrifana", 15),
(4,400,"Rua Barroco da Cela 8, Arrifana", 16),
(4,400,"Rua Barroco da Cela 8, Arrifana", 17),
(4,400,"Rua Barroco da Cela 8, Arrifana", 18),
(4,400,"Rua Barroco da Cela 8, Arrifana", 19);


INSERT INTO Higiliquidos.Carrinha (Matricula, Ano, Marca, Combustivel, Peso) VALUES
("AA-09-BD",2018,"Renault","Diesel",1160),
("CD-89-AK", 2014, "Mercedes","Gasolina",5000),
("EF-34-RT", 2019, "Fiat","Gasolina",1500),
("GH-56-LM", 2016, "Ford","Diesel",2000),
("IJ-78-NP", 2017, "Toyota","Gasolina",2500),
("KL-90-QR", 2020, "Dacia","Gasolina",3000),
("OP-45-UV", 2018, "Peugeot","Gasolina",1800),
("QR-67-WX", 2016, "Citroen","Diesel",1900);


INSERT INTO Higiliquidos.Pessoa (NIF, Nome, Data_de_Nascimento, Email, Morada, ContactoTelefonico) VALUES
--Funcionarios
(294455765, "João Antonio", "05/10/1983", 'joaoant@gmail.com', "Rua Vou AliJaVenho", 931764532),
(287649264, "Maria Silva", "12/03/1990", 'maria.silva@gmail.com', "Avenida Principal", 987854321),
(287654321, "Pedro Santos", "07/07/1985", 'pedro.santos@gmail.com', "Rua das Flores", 977888999),
(295748365, "Ana Sousa", "22/09/1995", 'ana.sousa@gmail.com', "Travessa das Oliveiras", 911022333),
(211111111, "Carlos Costa", "19/05/1978", 'carlos.costa@gmail.com', "Rua dos Amigos", 955444333),
(222222222, "Sofia Rodrigues", "14/08/1992", 'sofia.rodrigues@gmail.com', "Avenida Central", 966777888),
(299999999, "Rita Pereira", "28/11/1989", 'rita.pereira@gmail.com', "Praça da Liberdade", 922330444),
(288888888, "Luis Mendes", "02/02/1987", 'luis.mendes@gmail.com', "Rua Nova", 977111333),
(277777777, "Andre Almeida", "15/06/1998", 'andre.almeida@gmail.com', "Travessa dos Cravos", 999444555),
(266666666, "Marta Gomes", "10/09/1993", 'marta.gomes@gmail.com', "Avenida da Paz", 923456789),
(244444444, "Ricardo Ferreira", "25/12/1980", 'ricardo.ferreira@gmail.com', "Rua dos Sonhos", 944555666),
(233333333, "Inês Pereira", "18/07/1996", 'ines.pereira@gmail.com', "Praça dos Leões", 989123456),
(222222333, "Paulo Marques", "30/03/1984", 'paulo.marques@gmail.com', "Rua das Gaivotas", 987684321),
(223456789, "Patricia Santos", "08/06/1991", 'patricia.santos@gmail.com', "Avenida das Flores", 955666777),
(255666777, "Hugo Carvalho", "14/02/1988", 'hugo.carvalho@gmail.com', "Rua das Estrelas", 999888777),
--Fornecedores
(277888999, "Mariana Costa", "03/11/1994", 'mariana.costa@gmail.com', "Travessa dos Lírios", 911222333),
(299888777, "Rui Oliveira", "27/07/1986", 'rui.oliveira@gmail.com', "Avenida dos Pinheiros", 944505666),
(211222333, "Carolina Fernandes", "19/04/1997", 'carolina.fernandes@gmail.com', "Rua dos Girassóis", 977808999),
(244555666, "Diogo Pereira", "13/09/1992", 'diogo.pereira@gmail.com', "Travessa das Margaridas", 922333444),
(266555444, "Sara Rodrigues", "06/12/1984", 'sara.rodrigues@gmail.com', "Avenida das Águias", 933444555),
(233444555, "Gustavo Silva", "21/01/1990", 'gustavo.silva@gmail.com', "Rua das Árvores", 966877888),
(288777666, "Luana Mendonça", "17/08/1993", 'luana.mendonca@gmail.com', "Praça dos Girafas", 999000111),
(222330444, "Rodrigo Almeida", "29/05/1987", 'rodrigo.almeida@gmail.com', "Avenida dos Cravos", 944333222),
(277654321, "Ana Maria", "14/06/1989", 'ana.maria@gmail.com', "Rua das Oliveiras, 789", 911888777),
(255777888, "Hugo Santos", "23/09/1991", 'hugo.santos@gmail.com', "Travessa das Flores, 654", 977666555),
(244666555, "Diogo Costa", "07/07/1986", 'diogo.costa@gmail.com', "Avenida Central, 321", 922888777),
(233555444, "Inês Pereira", "29/02/1992", 'ines.pereira1@gmail.com', "Rua dos Cravos, 987", 989666555),
(288444333, "Luís Oliveira", "08/12/1983", 'luis.oliveira@gmail.com', "Avenida das Gaivotas, 654", 955333888),
(211333222, "Carla Fernandes", "16/05/1995", 'carla.fernandes@gmail.com', "Rua dos Girassóis, 321", 977222333),
(299222111, "Ricardo Silva", "03/03/1990", 'ricardo.silva@gmail.com', "Avenida dos Lírios, 789", 944888777),
--Clientes
(277111000, "Mariana Almeida", "11/11/1987", 'mariana.almeida@gmail.com', "Travessa das Margaridas, 654", 911555444),
(288333444, "Luana Costa", "26/04/1993", 'luana.costa@gmail.com', "Rua das Árvores, 321", 977333222),
(255000111, "Hugo Mendonça", "02/08/1988", 'hugo.mendonca@gmail.com', "Praça dos Girafas, 987", 999222111),
(233222111, "Gustavo Oliveira", "19/09/1990", 'gustavo.oliveira@gmail.com', "Rua das Estrelas, 456", 966444555),
(288111000, "Luana Rodrigues", "10/03/1985", 'luana.rodrigues@gmail.com', "Travessa dos Cravos, 789", 977111222),
(211343222, "Carolina Ferreira", "27/07/1997", 'carolina.ferreira@gmail.com', "Avenida das Flores, 654", 955333444),
(299444555, "Rui Santos", "08/06/1989", 'rui.santos@gmail.com', "Rua dos Girassóis, 321", 922444555),
(277555666, "Mariana Costa", "15/01/1994", 'mariana.costa1@gmail.com', "Avenida dos Pinheiros, 987", 911555666),
(288666777, "Luís Almeida", "22/08/1986", 'luis.almeida@gmail.com', "Travessa das Margaridas, 654", 977666777),
(255777588, "Hugo Pereira", "07/05/1991", 'hugo.pereira@gmail.com', "Rua das Árvores, 321", 944777888),
(233888999, "Inês Silva", "24/12/1995", 'ines.silva@gmail.com', "Praça dos Lírios, 789", 989888999),
(299999000, "Rita Mendes", "11/02/1984", 'rita.mends@gmail.com', "Rua Nova, 456", 922999000),
(211000111, "Carlos Rodrigues", "28/10/1998", 'carlos.rodrigues@gmail.com', "Avenida Principal, 654", 955000111),
(233202111, "Gustavo Oliveira", "19/09/1990", 'gustavo.oliveirinha@gmail.com', "Rua das Estrelas, 456", 966044555),
(288101000, "Luana Rodrigues", "10/03/1985", 'luana.rodrigues2@gmail.com', "Travessa dos Cravos, 789", 907111222),
(211313222, "Carolina Ferreira", "27/07/1997", 'carolina.ferreira1@gmail.com', "Avenida das Flores, 654", 955303444),
(299444055, "Rui Santos", "08/06/1989", 'rui.sants@gmail.com', "Rua dos Girassóis, 321", 922444155),
(277505666, "Mariana Costa", "15/01/1994", 'mariana.costa2@gmail.com', "Avenida dos Pinheiros, 987", 911551666),
(288666707, "Luís Almeida", "22/08/1986", 'luis.almeida3@gmail.com', "Travessa das Margaridas, 654", 977266777),
(255777878, "Hugo Pereira", "07/05/1991", 'hugo.pereira1@gmail.com', "Rua das Árvores, 321", 944777828),
(233808999, "Inês Silva", "24/12/1995", 'ines.silva1@gmail.com', "Praça dos Lírios, 789", 989883999),
(299939000, "Rita Mendes", "11/02/1984", 'rita.mendes@gmail.com', "Rua Nova, 456", 922929000),
(211000181, "Carlos Rodrigues", "28/10/1998", 'carlos.rodrigues2@gmail.com', "Avenida Principal, 654", 955040111),
(233232111, "Gustavo Oliveira", "19/09/1990", 'gustavo.oliveirota@gmail.com', "Rua das Estrelas, 456", 966494555),
(288121000, "Luana Rodrigues", "10/03/1985", 'luana.rodriguesrrr@gmail.com', "Travessa dos Cravos, 789", 977191222),
(211383222, "Carolina Ferreira", "27/07/1997", 'carolina.ferreira2@gmail.com', "Avenida das Flores, 654", 955333494),
(299484555, "Rui Santos", "08/06/1989", 'rui.santos1@gmail.com', "Rua dos Girassóis, 321", 922444565),
(279505666, "Mariana Costa", "15/01/1994", 'mariana.costa3@gmail.com', "Avenida dos Pinheiros, 987", 911575666),
(289666777, "Luís Almeida", "22/08/1986", 'luis.almeida4@gmail.com', "Travessa das Margaridas, 654", 977686777),
(211900111, "Carlos Rodrigues", "28/10/1998", 'carlos.rodriguesss@gmail.com', "Avenida Principal, 654", 955090111);


INSERT INTO Higiliquidos.Empresa (Nome, Email, Endereco, ContactoTelefonico, ID_Armazem, NIF_Pessoa, Matricula_Carrinha) VALUES
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, 0, NULL, NULL),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, 1, NULL, NULL),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, 2, NULL, NULL),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, 3, NULL, NULL),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, 4, NULL, NULL),
--Funcionários
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, 294455765, NULL),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, 287649264, NULL),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, 287654321, NULL),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, 295748365, NULL),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, 211111111, NULL),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, 222222222, NULL),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, 299999999, NULL),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, 288888888, NULL),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, 277777777, NULL),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, 266666666, NULL),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, 244444444, NULL),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, 233333333, NULL),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, 222222333, NULL),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, 223456789, NULL),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, 255666777, NULL),
--Fornecedores
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, 277888999, NULL),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, 299888777, NULL),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, 211222333, NULL),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, 244555666, NULL),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, 266555444, NULL),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, 233444555, NULL),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, 288777666, NULL),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, 222330444, NULL),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, 277654321, NULL),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, 255777888, NULL),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, 244666555, NULL),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, 233555444, NULL),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, 288444333, NULL),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, 211333222, NULL),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, 299222111, NULL),
--Clientes
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, 277111000, NULL),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, 288333444, NULL),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, 255000111, NULL),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, 233222111, NULL),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, 288111000, NULL),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, 211343222, NULL),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, 299444555, NULL),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, 277555666, NULL),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, 288666777, NULL),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, 255777588, NULL),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, 233888999, NULL),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, 299999000, NULL),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, 211000111, NULL),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, 233202111, NULL),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, 288101000, NULL),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, 211313222, NULL),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, 299444055, NULL),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, 277505666, NULL),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, 288666707, NULL),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, 255777878, NULL),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, 233808999, NULL),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, 299939000, NULL),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, 211000181, NULL),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, 233232111, NULL),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, 288121000, NULL),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, 211383222, NULL),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, 299484555, NULL),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, 279505666, NULL),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, 289666777, NULL),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, 211900111, NULL),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, NULL, "AA-09-BD"),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, NULL, "CD-89-AK"),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, NULL, "EF-34-RT"),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, NULL, "GH-56-LM"),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, NULL, "IJ-78-NP"),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, NULL, "KL-90-QR"),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, NULL, "OP-45-UV"),
("Higilíquidos","higiliquidos@sapo.pt","Rua Barroco da Cela 8, Arrifana",271963349, NULL, NULL, "QR-67-WX");


INSERT INTO Higiliquidos.Fornecedor (NIF_Fornecedor) VALUES
(277888999), 
(299888777), 
(211222333),
(244555666), 
(266555444),
(233444555),
(288777666), 
(222330444), 
(277654321),
(255777888),
(244666555),
(233555444),
(288444333),
(211333222),
(299222111);

INSERT INTO Higiliquidos.Encomenda (ID, ID_Produto, Quantidade_Produto, Quantidade_Total) VALUES
--Fornecedor
(0, 0, 5, 20),
(0, 3, 5, 20),
(0, 5, 10, 20),

(1, 1, 10, 10),

(2, 2, 10, 20),
(2, 4, 10, 20),

(3, 3, 10, 10),

(4, 1, 15, 50),
(4, 4, 10, 50),
(4, 12, 15, 50),
(4, 19, 10, 50),

(5, 5, 10, 20),
(5, 18, 10, 20),

(6, 1, 30, 140),
(6, 6, 10, 140),
(6, 7, 10, 140),
(6, 9, 20, 140),
(6, 10, 10, 140),
(6, 11, 10, 140),
(6, 13, 10, 140),
(6, 15, 20, 140),
(6, 17, 15, 140),
(6, 18, 15, 140),
(6, 19, 10, 140),

(7, 7, 11, 11),
(8, 8, 1, 1),
(9, 9, 22, 22),
(10, 10, 4, 4),
(11, 11, 1, 1),
(12, 14, 2, 2),
(13, 15, 6, 6),
(14, 16, 4, 4),
(15, 17, 4, 4),
(16, 18, 1, 1),
(17, 19, 7, 7),
--Cliente
(18, 0, 1, 1),
(19, 1, 2, 2),
(20, 2, 1, 1),
(21, 14, 3, 3),
(22, 12, 2, 2),
(23, 3, 10, 10),
(24, 7, 1, 1),
(25, 8, 1, 1),
(26, 2, 2, 2),
(27, 1, 5, 5),
(28, 5, 6, 6),
(29, 4, 2, 2),
(30, 8, 3, 3),
(31, 13, 1, 1),
(32, 16, 1, 1),
(33, 4, 1, 1),
(34, 11, 1, 1),
(35, 2, 1, 1),
(36, 1, 1, 1),
(37, 1, 1, 1),
(38, 10, 1, 1),
(39, 5, 1, 1),
(40, 2, 1, 1),
(41, 16, 1, 1),
(42, 18, 1, 1),
(43, 3, 1, 1),
(44, 4, 1, 1),
(45, 5, 1, 1),
(46, 6, 1, 1),
(47, 7, 1, 1),
(48, 15, 1, 1),
(49, 17, 1, 1),
(50, 19, 1, 1),
(51, 3, 1, 1),
(52, 9, 1, 1);





INSERT INTO Higiliquidos.Encomenda_Fornecedor (NIF_Fornecedor, ID_Encomenda) VALUES
(277888999,0), 
(299888777,1), 
(211222333,2),
(244555666,3), 
(266555444,4),
(233444555,5),
(288777666,6), 
(222330444,7), 
(277654321,8),
(255777888,9),
(244666555,10),
(233555444,11),
(288444333,12),
(211333222,13),
(299222111,14),
(277888999,15), 
(299888777,16), 
(211222333,17);


INSERT INTO Higiliquidos.Cliente (NIF_Cliente) VALUES
(277111000),
(288333444), 
(255000111), 
(233222111), 
(288111000),
(211343222),
(299444555),
(277555666),
(288666777),
(255777588),
(233888999),
(299999000),
(211000111),
(233202111),
(288101000),
(211313222),
(299444055),
(277505666),
(288666707),
(255777878),
(233808999),
(299939000),
(211000181),
(233232111),
(288121000),
(211383222),
(299484555),
(279505666),
(289666777),
(211900111);




INSERT INTO Higiliquidos.Encomenda_Cliente (NIF_Cliente, ID_Encomenda) VALUES
(277111000,18),
(288333444,19), 
(255000111,20), 
(233222111,21), 
(288111000,22),
(211343222,23),
(299444555,24),
(277555666,25),
(288666777,26),
(255777588,27),
(233888999,28),
(299999000,29),
(211000111,39),
(233202111,31),
(288101000,32),
(211313222,33),
(299444055,34),
(277505666,35),
(288666707,36),
(255777878,37),
(233808999,38),
(299939000,39),
(211000181,40),
(233232111,41),
(288121000,42),
(211383222,43),
(299484555,44),
(279505666,45),
(289666777,46),
(211900111,47),
(288101000,48),
(211313222,49),
(299444055,50),
(277505666,51),
(288666707,52);


INSERT INTO Higiliquidos.Funcionario (NIF_Funcionario, IBAN, Data_Inicio_Atividade, Numero_SS, Num_Func) VALUES
--Vendedor
(294455765, "PT50000201231234567890154", "15/06/2018", 200000000, 1),
(287649264, "PT50000392221234567890155", "15/06/2018", 200000001, 1),
(287654321, "PT50000423451234567890156", "15/06/2018", 200000101, 1),
(295748365, "PT50000584321234567890157", "15/06/2018", 200000003, 1),
(211111111, "PT50000698741234567890158", "15/06/2018", 200000004, 1),
(222222222, "PT50000765431234567890159", "04/06/2019", 200000005, 1),
(299999999, "PT50000812971234567890160", "04/06/2019", 200000006, 1),
--Distribuidor
(288888888, "PT50000900981234567890161", "04/06/2019", 200000007, 2),
(277777777, "PT50001049761234567890162", "04/06/2019", 200000008, 2),
(266666666, "PT50001132821234567890163", "10/09/2020", 200000009, 2),
(244444444, "PT50001278311234567890164", "09/12/2020", 200000405, 2),
(233333333, "PT50001364521234567890165", "18/07/2021", 200000401, 2),
(222222333, "PT50001423091234567890166", "30/03/2022", 200000601, 2),
(223456789, "PT50001554141234567890167", "08/06/2022", 200000701, 2),
--Gerente
(255666777, "PT50001686771234567890168", "14/02/2022", 200000801, 3);


INSERT INTO Higiliquidos.Vendedor (NIF_Vendedor, Num_Func) VALUES
(255666777, 3);


INSERT INTO Higiliquidos.Vendedor (NIF_Vendedor, Num_Func) VALUES
(294455765, 1),
(287649264, 1),
(287654321, 1),
(295748365, 1),
(211111111, 1),
(222222222, 1),
(299999999, 1);


INSERT INTO Higiliquidos.Distribuidor (NIF_Distribuidor, Matricula_Carrinha, Nun_Func) VALUES
(288888888, "AA-09-BD", 2),
(277777777, "CD-89-AK", 2),
(266666666, "EF-34-RT", 2),
(244444444, "GH-56-LM", 2),
(233333333, "IJ-78-NP", 2),
(222222333, "KL-90-QR", 2),
(223456789, "OP-45-UV", 2);
--fica a faltar uma carrinha(reserva caso se estrague alguma)

INSERT INTO Higiliquidos.Encomenda_Distribuidor (NIF_Distribuidor, ID_Encomenda, Data_Entrega) VALUES
(288888888, 18, "15/06/2018"),
(288888888, 19, "04/07/2018"),
(288888888, 20, "01/10/2018"),
(288888888, 21, "04/10/2018"),
(288888888, 22, "21/11/2018"),

(277777777, 23, "16/06/2018"),
(277777777, 24, "20/06/2018"),
(277777777, 25, "16/07/2018"),
(277777777, 26, "02/08/2018"),
(277777777, 27, "21/12/2018"),

(266666666, 28, "13/05/2018"),
(266666666, 29, "17/06/2018"),
(266666666, 30, "22/06/2018"),
(266666666, 31, "03/07/2018"),
(266666666, 32, "20/07/2018"),

(244444444, 33, "18/06/2018"),
(244444444, 34, "08/07/2018"),
(244444444, 35, "06/09/2018"),
(244444444, 36, "15/09/2018"),
(244444444, 37, "04/01/2019"),

(233333333, 38, "05/03/2019"),
(233333333, 39, "22/03/2019"),
(233333333, 40, "15/05/2019"),
(233333333, 41, "19/06/2019"),
(233333333, 42, "22/06/2019"),

(222222333, 43, "15/03/2019"),
(222222333, 44, "14/04/2019"),
(222222333, 45, "23/04/2019"),
(222222333, 46, "17/06/2019"),
(222222333, 47, "22/06/2019"),

(223456789, 48, "21/03/2020"),
(223456789, 49, "15/04/2020"),
(223456789, 50, "01/05/2020"),
(223456789, 51, "09/05/2020"),
(223456789, 52, "26/06/2020");

