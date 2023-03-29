use p8g8
go

CREATE TABLE ReservaVos.Airport (
	Airport_Code	int,
	City		VARCHAR(30)		NOT NULL,
	Airport_Name		VARCHAR(30)		NOT NULL,
	Airport_State		VARCHAR(30),
	PRIMARY KEY (Airport_Code),
);
CREATE TABLE ReservaVos.Airplane (
	Airplane_Id int,
	Total_no_of_seats int NOT NULL,
	AirplaneType_name VARCHAR(30) NOT NULL,
	PRIMARY KEY (Airplane_Id),
);
CREATE TABLE ReservaVos.Airplane_Type (
	AirplaneType_Name VARCHAR(30),
	Company VARCHAR(30) NOT NULL,
	Max_Seats int,
	PRIMARY KEY (AirplaneType_Name),
);

CREATE TABLE ReservaVos.Flight (
	F_Number int,
	Airline VARCHAR(30) NOT NULL,
	Weekdays int,
	PRIMARY KEY(F_Number),
);

CREATE TABLE ReservaVos.Flight_leg (
	Fleg_no int,
	Fleg_Number int,
	Airport_Code int NOT NULL,
	Dep_time DATE NOT NULL,
	Arr_time DATE NOT NULL,
	PRIMARY KEY(Fleg_Number,Fleg_no),
	FOREIGN KEY (Airport_code) REFERENCES ReservaVos.Airport(Airport_Code),
	FOREIGN KEY (Fleg_Number) REFERENCES ReservaVos.Flight(F_Number),
);

CREATE TABLE ReservaVos.Leg_Instance (
	Leg_Date DATE, 
	No_of_avaliable_seats int NOT NULL,
	Fleg_no int,
	Fleg_Number int,
	Airplane_Id int NOT NULL,
	Airport_Code int NOT NULL,
	Dep_time DATE NOT NULL,
	Arr_time DATE NOT NULL,
	PRIMARY KEY ( Fleg_no, Fleg_Number, Leg_Date),

	FOREIGN KEY ( Airplane_Id) REFERENCES ReservaVos.Airplane ( Airplane_Id),
	FOREIGN KEY (Airport_Code) REFERENCES ReservaVos.Airport(Airport_Code),
	FOREIGN KEY (Fleg_Number,Fleg_no) REFERENCES ReservaVos.Flight_Leg(Fleg_Number,Fleg_no),
);

CREATE TABLE ReservaVos.Seat (
	Fleg_Number int,
	Fleg_no int,
	Seat_no int,
	Costumer_Name VARCHAR(30),
	cphone int,
	Leg_Date DATE,
	PRIMARY KEY (Fleg_Number,Fleg_no,Seat_no,Leg_Date),

	FOREIGN KEY (Fleg_no,Fleg_Number,Leg_Date) REFERENCES ReservaVos.Leg_Instance(Fleg_no,Fleg_Number,Leg_Date),
);

CREATE TABLE ReservaVos.Fare (
	Code int,
	Number int,
	Ammount	int,
	Restrictions VARCHAR(50),

	PRIMARY KEY (Code,Number),
	FOREIGN KEY (Number) REFERENCES  ReservaVos.Flight(F_Number),
);



