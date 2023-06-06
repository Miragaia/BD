import random, unidecode, datetime, re, os

names = "Pedro Manuel José Miguel Afonso Bernardo Tomé André Fábio Eduardo Marta Eva Mariana Raquel Camila Catarina Cátia Vanessa Rute Rita Leandro Ana Alexandre Paulo Guilherme Gonçalo Telmo Tomás Tiago Artur Nuno Vasco Ricardo João Sophie Patrícia Andreia Filipe Daniela Diogo Leonor Beatriz Matilde Rodrigo Santiago"
surnames = "Oliveira Carvalho Silva Santos Ferreira Dias Pereira Oliveira Costa Rodrigues Martins Jesus Sousa Fernandes Gonçalves Gomes Lopes Marques Alves Almeida Ribeiro Pinto Teixeira Moreira Correia Mendes Nunes Soares Vieira Monteiro Cardoso Rocha Raposo Neves Coelho Cruz Cunha Pires Ramos Reis Simões Antunes Matos Fonseca Machado Araújo Barbosa Tavares Lourenço Castro Figueiredo Azevedo"
names = names.split()
surnames = surnames.split()
addresses = ["Urbanização Chave 52, 3810-081 Aveiro", "R. das Pombas, 3810-150 Aveiro", "R. Dom Manuel Barbuda e Vasconcelos, 3810-498 Aveiro", "Av. Europa 705, 3810-140 Aveiro", "R. Direita de Aradas 103, 3810-005 Aveiro", "Variante à N326 3811, 3811-902 Aveiro", "Estr. de São Bernardo 93, 3810-164 Aveiro", "Estr. de São Bernardo 192, 3810-164 Aveiro", "Estr. de São Bernardo 318E, 3810-174 Aveiro", "R. Cónego Maio 74, 3810-089 Aveiro", "R. da Cabreira 164, 3810-071 Aveiro", "R. Cónego Maio 133, 3810-089 Aveiro", "R. das Cavadas 80, 3810-030 Aveiro", "Zona Industrial da Taboeira Aveiro, Retail Park Lote F, 3800-055 Aveiro", "R. do Vale Covo Zona Industrial da Taboeira 3800-055, Aveiro", "R. da Paz nº2, 3800-309 Aveiro", "R. da Paz 109 A, 3800-587 Cacia", "Av. Europa 191, 3800-533 Cacia", "R. dos Bombeiros da Celulose 85, 3800-536 Cacia", "R. Marquês de Pombal 99, 3800-527 Cacia", "Feira Nova Hipermercados, Esgueira, 3800-000 Aveiro", "Rua de Vicente Almeida de Eça 12, 3800-144 Aveiro", "Avenida Manuel Maria Da Rocha Colmieiro, 3800-305 Aveiro", "R. Eng. Von Haff 27, 3800-177 Aveiro", "Alameda Silva Rocha, 3800-385 Aveiro", "R. do Norte, 3830-167 Gafanha de Aquém", "R. do Norte nº1 Loja D, 3830-167 Gafanha de Aquém"]
phone_prefixes = ["91", "92", "93", "96"]
mail0 = [".","_","",""]
mail1 = ["gmail","sapo","outlook","hotmail","aol","mail"]
mail2 = ["com","pt"]
supplier_names = ["L. Ribeiro - Promoção E Distribuição Alimentar, Lda", "Ignoramus - Produtos Naturais, Lda", "Frigofril - Frio E Transportes, Lda", "Frutas Cruzeiro, Lda", "Ovopor-Agro-Pecuária dos Milagres SA",
"M. CUNHA & COMPANHIA S.A", "SAUDAL GREEN", "ATACADISTA - DISTRIBUIÇÃO ALIMENTAR, S.A.", "NORTE FOODS PORTUGAL", "DHC - PRODUTOS ALIMENTARES, LDA"]

product_types = {"Mercearia": 6, "Laticínios e Ovos": 6, "Peixaria e Talho": 6, "Fruta e Legumes": 6, "Charcutaria e Queijos":6, "Padaria e Pastelaria":6, "Congelados":6, "Bebidas e Garrafeira":6, "Higiene e Beleza":6, "Produtos de Limpeza":6, "Brinquedos e Jogos":23, "Livraria e Papelaria":6}

phones = set()
nifs = set()
for i in range(2000):
    phones.add(str(random.choice(phone_prefixes))+str(random.randint(1000000, 9999999)))
    nifs.add(random.randint(200000000, 299999999))

def get_nif():
    return nifs.pop()

def get_name():
    return random.choice(names)

def get_surname():
    return random.choice(surnames)

def get_fullname(name, surname):
    return f"{name} {surname}"

def get_address():
    return random.choice(addresses)

def get_phone():
    return phones.pop()

def get_email(name, surname, phone):
    email = name[:random.randint(1,4)] + random.choice(mail0) + surname[:random.randint(1,4)] \
            + phone[:2]+ "@" + random.choice(mail1) + "." + random.choice(mail2)
    return unidecode.unidecode(email.lower())

def random_date(start, end):
    delta = end - start
    int_delta = (delta.days * 24 * 60 * 60) + delta.seconds
    random_second = random.randrange(int_delta)
    temp = start + datetime.timedelta(seconds=random_second)
    return temp.strftime('%Y/%m/%d')

def get_supplier_name():
    return supplier_names.pop()


################### supermarket.person , client e employee
clientID = 0
employeeID = 0
d1 = datetime.datetime.strptime('1/1/2010', '%m/%d/%Y')
d2 = datetime.datetime.strptime('1/1/2021', '%m/%d/%Y')

for i in range(500):
    name = get_name()
    surname = get_surname()
    phone = get_phone()
    nif = get_nif()

    #insert person
    print(f"INSERT INTO supermarket.person(NIF, name, address, phone, email) \
VALUES({nif}, '{get_fullname(name, surname)}', '{get_address()}', '{phone}', \
'{get_email(name, surname, phone)}');")
    
    if random.random() > 0.9: # insert employee
        print(f"INSERT INTO supermarket.employee(employeeID, employeeSince, salary, jobtitle, NIF) \
VALUES({employeeID}, '{random_date(d1, d2)}', {random.randrange(600, 700)}, 'Operador de Caixa', {nif});")
        
        employeeID += 1

    else: # insert client
        print(f"INSERT INTO supermarket.client(clientID, website, clientSince, NIF) \
VALUES({clientID}, '', '{random_date(d1, d2)}', {nif});")

        clientID+=1
input()
os.system("cls")
################### supermarket.supplier
supplierID = 0
for i in range(10):
    supplier_name = get_supplier_name()
    ascii_name = re.sub(r'\W+', '', supplier_name)
    phone = get_phone()
    email = get_email(supplier_name[:4],supplier_name[5:10],phone)
    print(f"INSERT INTO supermarket.supplier(supplierID , organizationName, address, email, phone, supplierSince, NIF, website, description) \
VALUES({supplierID}, '{supplier_name}', '{get_address()}', '{email}', '{phone}', \
'{random_date(d1, d2)}', {get_nif()}, '', '');")
    
    supplierID+=1
input()
os.system("cls")
################### supermarket.type
for k,v in (product_types.copy()).items():
    print(f"INSERT INTO supermarket.type(name, IVA) VALUES('{k}', {v});")

    del product_types[k]
input()
os.system("cls")
################### supermarket.wareHouse
warehouse = 0
for i in range(2):
    print(f"INSERT INTO supermarket.wareHouse(number) VALUES({warehouse});")
    warehouse += 1
