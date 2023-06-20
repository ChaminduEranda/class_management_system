CREATE DATABASE class;


use class;

CREATE TABLE teacher
(
t_id	INT	NOT NULL PRIMARY KEY,
fname	VARCHAR(50),
lname	VARCHAR(50),
t_address	VARCHAR(50),
dob		DATE,
t_email	VARCHAR(100),
mobile	INT,
nic		VARCHAR(20)
);

CREATE TABLE instructor
(
i_id	INT	NOT NULL PRIMARY KEY,
fname	VARCHAR(50),
lname	VARCHAR(50),
i_address	VARCHAR(50),
dob		DATE,
i_email	VARCHAR(100),
mobile	INT,
nic		VARCHAR(20),
teacher_id	INT NOT NULL,
FOREIGN KEY (teacher_id) REFERENCES teacher(t_id)
);


CREATE TABLE course
(
c_id	VARCHAR(10)	NOT NULL,
c_name	VARCHAR(50),
batch		VARCHAR(5)	NOT NULL,
duration	VARCHAR(50),
price	INT,
c_type	VARCHAR(10),
CONSTRAINT PK_course PRIMARY KEY (c_id,batch)
);

CREATE TABLE student
(
s_id	INT	NOT NULL PRIMARY KEY,
fname	VARCHAR(50),
lname	VARCHAR(50),
s_address	VARCHAR(50),
dob		DATE,
s_email	VARCHAR(100),
mobile	INT,
gender	VARCHAR(10),
nic		VARCHAR(20)
);

CREATE TABLE exam
(
e_id	INT	NOT NULL PRIMARY KEY,
e_name	VARCHAR(50),
e_date	DATE
);

CREATE TABLE course_exam
(
course_id	VARCHAR(10) NOT NULL,
batch		VARCHAR(5) NOT NULL,
exam_id		INT	NOT NULL,
CONSTRAINT PK_course_exam PRIMARY KEY (course_id, batch, exam_id),
FOREIGN KEY (course_id,batch) REFERENCES course (c_id,batch),
FOREIGN KEY (exam_id) REFERENCES exam (e_id)
);

CREATE TABLE attendance
(
student_id	INT NOT NULL,
a_date		DATE DEFAULT GETDATE(),
CONSTRAINT PK_attendance PRIMARY KEY (student_id, a_date),
FOREIGN KEY (student_id) REFERENCES student (s_id)
);

CREATE TABLE teacher_course
(
teacher_id	INT NOT NULL,
course_id	VARCHAR(10) NOT NULL,
batch		VARCHAR(5)	NOT NULL,
CONSTRAINT PK_teacher_course PRIMARY KEY (teacher_id, course_id,batch),
FOREIGN KEY (teacher_id) REFERENCES teacher (t_id),
FOREIGN KEY (course_id,batch) REFERENCES course (c_id,batch)
);

CREATE TABLE student_course
(
student_id	INT NOT NULL,
course_id	VARCHAR(10) NOT NULL,
batch		VARCHAR(5)	NOT NULL,
register_date	DATE,
CONSTRAINT PK_student_course PRIMARY KEY (student_id, course_id),
FOREIGN KEY (student_id) REFERENCES student (s_id),
FOREIGN KEY (course_id,batch) REFERENCES course (c_id,batch),
);

CREATE TABLE student_exam
(
student_id	INT NOT NULL,
exam_id		INT NOT NULL,
exam_marks	INT,
CONSTRAINT PK_student_exam PRIMARY KEY (student_id, exam_id),
FOREIGN KEY (student_id) REFERENCES student (s_id),
FOREIGN KEY (exam_id) REFERENCES exam (e_id)
);

CREATE TABLE app_user
(
u_username	VARCHAR(50) NOT NULL PRIMARY KEY,
u_password	VARCHAR(50)	NOT NULL,
u_role		VARCHAR(20)	NOT NULL
);

/*	Values for app_user	*/
INSERT INTO app_user VALUES('admin',HASHBYTES('md5','admin123'),'Teacher');
INSERT INTO app_user VALUES('user',HASHBYTES('md5','user123'),'Instructor');



/*	Values for teacher	*/
INSERT INTO teacher VALUES (101,'Chamath','Kavinda','Gampaha','1988-05-14','chamathkavinda@gmail.com',0758489758,'199045782151');
INSERT INTO teacher VALUES (102,'Shehan','Gunasekara','Kadawatha','1989-08-12','shehangunasekara@gmail.com',0715185146,'199074782152');
INSERT INTO teacher VALUES (103,'Sandun','Senarath','Gampaha','1988-04-05','sandunsenarath@gmail.com',0758489758,'199047482153');
INSERT INTO teacher VALUES (104,'Keshana','Gayathra','Kiribathgoda','1991-05-16','keshanagayathra@gmail.com',0758489758,'199056582154');
INSERT INTO teacher VALUES (105,'Nipun','Samith','Gampaha','1990-08-19','nipunsamith@gmail.com',0758489758,'199476482155');
INSERT INTO teacher VALUES (106,'Janidu','Rasanjana','Veyangoda','1992-04-12','janidurasanjana@gmail.com',0758489758,'199056482156');
INSERT INTO teacher VALUES (107,'Amith','Dananjaya','Veyangoda','1990-12-10','amithdananjaya@gmail.com',0758489758,'199032382157');
INSERT INTO teacher VALUES (108,'Hasitha','Senevirathna','Colombo','1990-06-11','hasithasenevirathna@gmail.com',0758489758,'199012482158');
INSERT INTO teacher VALUES (109,'Nishan','ashan','Kadawatha','1989-07-21','nishanashan@gmail.com',0758489758,'199057482159');
INSERT INTO teacher VALUES (110,'Kamal','Raveendra','Kelaniya','1990-09-23','kamalraveendra@gmail.com',0758489758,'199065282161');

/*	Values for Instructor	*/
INSERT INTO instructor VALUES (1001,'Saman','Iduwara','Kadawatha','1998-03-17','samaniduwara@gmail.com',0758525657,'199804725956',101);
INSERT INTO instructor VALUES (1002,'Nimal','Pradeep','Veyangoda','1998-03-17','nimalpradeep@gmail.com',0711441441,'199804795666',101);
INSERT INTO instructor VALUES (1003,'Shehan','Gunawardana','Ragama','1998-03-17','shehangunawardana@gmail.com',0775856545,'199804733236',102);
INSERT INTO instructor VALUES (1004,'Kasun','Silva','Colombo','1998-03-17','kasunsilva@gmail.com',0727478588,'199806656956',102);
INSERT INTO instructor VALUES (1005,'Naveendra','Mendis','Homagama','1998-03-17','naveendramendis@gmail.com',0758524747,'199804545756',103);
INSERT INTO instructor VALUES (1006,'Nimal','Tharaka','Kiribathgoda','1998-03-17','nimaltharaka@gmail.com',0778525410,'199804808956',103);
INSERT INTO instructor VALUES (1007,'Tharaka','Dilshan','Gampaha','1998-03-17','tharakadilshan@gmail.com',0756966562,'199804726966',104);
INSERT INTO instructor VALUES (1008,'Pathum','Rukmantha','Gampaha','1998-03-17','pathumrukmantha@gmail.com',0774412270,'199804723236',104);
INSERT INTO instructor VALUES (1009,'Shenal','Maaheesha','Kadawatha','1998-03-17','shenalmaheesha@gmail.com',0778845800,'199804447456',104);
INSERT INTO instructor VALUES (1010,'Harsha','Mendis','Kadawatha','1998-03-17','harshamendis@gmail.com',0769895857,'199804796856',104);
INSERT INTO instructor VALUES (1011,'Nipun','Dilshan','Gampaha','1998-03-17','nipundilshan@gmail.com',0725858777,'199804778456',104);
INSERT INTO instructor VALUES (1012,'Lahiru','Perera','Kadawatha','1998-03-17','lahiruperera@gmail.com',0755682597,'199804724146',104);

/*	Values for course	*/
INSERT INTO course VALUES ('CHW-F','Certificate in Hardware','21.1','6 months',25000,'Full Time');
INSERT INTO course VALUES ('CHW-P','Certificate in Hardware','21.1','8 months',25000,'Part Time');
INSERT INTO course VALUES ('CGD-F','Certificate in Graphic designing','21.1','6 months',36000,'Full Time');
INSERT INTO course VALUES ('CGD-P','Certificate in Graphic designing','21.1','8 months',36000,'Part Time');
INSERT INTO course VALUES ('COP-F','Certificate in Office Package','21.1','6 months',25000,'Full Time');
INSERT INTO course VALUES ('COP-P','Certificate in Office Package','21.1','6 months',25000,'Part Time');
INSERT INTO course VALUES ('DHW-F','Diploma in Hardware','21.1','1 year',80000,'Full Time');
INSERT INTO course VALUES ('DHW-P','Diploma in Hardware','21.1','1 year',80000,'Part Time');
INSERT INTO course VALUES ('CIT-F','Information Technology','21.1','6 months',30000,'Full Time');
INSERT INTO course VALUES ('CPL-F','Certificate in Programming Lanugauge','21.1','1 year',80000,'Full Time');
INSERT INTO course VALUES ('CPL-P','Certificate in Programming Lanugauge','21.1','1 year',80000,'Part Time');

/*	Values for student	*/
INSERT INTO student VALUES (10001,'Tharindu','Thushantha','Veyangoda','2000-09-12','tharinduthushantha@gmail.com',0726569564,'male','201415658241');
INSERT INTO student VALUES (10002,'Pasan','Liyanage','Kadawatha','2000-09-12','pasanliyanage@gmail.com',0726560777,'male','201415658241');
INSERT INTO student VALUES (10003,'Jevon','Lasith','Kelaniya','2000-09-12','jevonlasith@gmail.com',0726561747,'male','201415658241');
INSERT INTO student VALUES (10004,'Andrew','Qyin','Veyangoda','2000-09-12','andrewqyin@gmail.com',0778585564,'male','201415658241');
INSERT INTO student VALUES (10005,'Gihan','Pradeep','Veyaangoda','2000-09-12','gihanpradeep@gmail.com',0756999564,'male','201415658241');
INSERT INTO student VALUES (10006,'Navod','Deshan','Gampaha','2000-09-12','navoddeshan@gmail.com',0775569564,'male','201415658241');
INSERT INTO student VALUES (10007,'Sasidu','Prabath','Gampaha','2000-09-12','sasiduprabath@gmail.com',0777587446,'male','201415658241');
INSERT INTO student VALUES (10008,'Gimhani','liyanage','Ragama','2000-09-12','gimhaniliyanage@gmail.com',0776500064,'female','201415658241');
INSERT INTO student VALUES (10009,'Bumidu','Deshan','Kiribathgoda','2000-09-12','bumidudeshan@gmail.com',0719666564,'male','201415658241');
INSERT INTO student VALUES (10010,'Sithum','Navod','Gamapaha','2001-08-12','sithumnavod@gmail.com',0710006564,'male','200115658241');
INSERT INTO student VALUES (10011,'Nimali','Aponsu','Veyangoda','2000-09-12','sithumnavod@gmail.com',0775557478,'female','200205658241');

/*	Values for exam	*/
INSERT INTO exam VALUES (1,'Office Word Practical','2021-08-12');
INSERT INTO exam VALUES (2,'Office Excel Theory','2021-08-20');
INSERT INTO exam VALUES (3,'Office Excel Practical','2021-08-20');
INSERT INTO exam VALUES (4,'Office PowerPoint Practical','2021-08-22');
INSERT INTO exam VALUES (5,'MS Access','2021-09-10');
INSERT INTO exam VALUES (6,'Graphic design Mid test','2021-08-10');
INSERT INTO exam VALUES (7,'Graphic design Final','2021-10-10');
INSERT INTO exam VALUES (8,'Python programming','2021-10-10');
INSERT INTO exam VALUES (9,'Java programming','2021-10-10');

/*	Values for course_exam	*/
INSERT INTO course_exam VALUES ('COP-F','21.1',1);
INSERT INTO course_exam VALUES ('COP-F','21.1',2);
INSERT INTO course_exam VALUES ('COP-F','21.1',3);
INSERT INTO course_exam VALUES ('COP-F','21.1',4);
INSERT INTO course_exam VALUES ('COP-F','21.1',5);

/*	Values for teacher_course	*/
INSERT INTO teacher_course VALUES (101,'COP-F','21.1');
INSERT INTO teacher_course VALUES (102,'CHW-F','21.1');
INSERT INTO teacher_course VALUES (102,'CGD-F','21.1');
INSERT INTO teacher_course VALUES (103,'DHW-F','21.1');
INSERT INTO teacher_course VALUES (104,'CIT-F','21.1');
INSERT INTO teacher_course VALUES (103,'COP-F','21.1');
INSERT INTO teacher_course VALUES (103,'CGD-F','21.1');
INSERT INTO teacher_course VALUES (101,'CGD-F','21.1');
INSERT INTO teacher_course VALUES (107,'COP-F','21.1');
INSERT INTO teacher_course VALUES (108,'COP-F','21.1');
INSERT INTO teacher_course VALUES (102,'DHW-F','21.1');
INSERT INTO teacher_course VALUES (109,'COP-F','21.1');

/*	Values for student_course	*/
INSERT INTO student_course VALUES (10001,'COP-F','21.1','2021-07-01');
INSERT INTO student_course VALUES (10002,'COP-F','21.1','2021-07-01');
INSERT INTO student_course VALUES (10003,'CGD-F','21.1','2021-07-01');
INSERT INTO student_course VALUES (10004,'CGD-F','21.1','2021-07-01');

INSERT INTO student_course VALUES (10005,'CGD-F','21.1','2021-07-01');
INSERT INTO student_course VALUES (10006,'CGD-F','21.1','2021-07-01');
INSERT INTO student_course VALUES (10007,'CGD-F','21.1','2021-07-01');
INSERT INTO student_course VALUES (10008,'CGD-F','21.1','2021-07-01');

INSERT INTO student_course VALUES (10009,'CPL-F','21.1','2021-07-01');
INSERT INTO student_course VALUES (10010,'CPL-F','21.1','2021-07-01');
INSERT INTO student_course VALUES (10011,'CPL-F','21.1','2021-07-01');

/*	Values for student_exam	*/
INSERT INTO student_exam VALUES (10001,1,90);
INSERT INTO student_exam VALUES (10001,2,85);
INSERT INTO student_exam VALUES (10001,3,75);
INSERT INTO student_exam VALUES (10001,4,67);
INSERT INTO student_exam VALUES (10001,5,95);

select * from student;
select * from instructor;
select * from course;
select * from course_exam;
select * from app_user;
select * from student_course;
select * from attendance;

