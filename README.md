C# Microsoft Access Database Connection Class | C# Microsoft Access Veritabanı Bağlantısı Sınıfı

Usage: You must insert the database file into the Debug folder.
Then add dbConnectionClass.cs to project file.
Open your dbConnectionClass.cs file and edit it according to your own project name.

DataSet virtualx;

string query = "insert into table(column1,column2,column3,column4) values('" + txt1.Text + "','" + txt2.Text + "','" + txt3.Text + "','" + txt4.Text + "') "; DBConnect.RunCommand(query);

string query2 = "delete * from table where ID= '" + txt1.Text + "' "; DBConnect.RunCommand(query2);

string query3 = "select * from table";
virtualx = DBConnect.infoList(query3);
dataGridView1.DataSource = virtualx.Tables[0];

string query4 = "update table set Name='" + txtNAME.Text + "', Surname='" + txtSurname.Text + "' where ID= '"+ txt1.Text +"' ";
DBConnect.RunCommand(komut);

![alt text](https://user-images.githubusercontent.com/39583220/41089852-805b44b8-6a4b-11e8-8a27-b6060df0d4a7.png)


Kullanım: Projenizin içinde bulunan Debug klasörünün içine .accdb (veritabanı) dosyanızı atın.
Daha sonra projenize .cs uzantılı veritabanı işlemlerimizi yapacak olan dosyamızı ekleyin.
.cs uzantılı dosyamızı açın ve kendi proje adınıza göre düzenleyin.

string komut = "insert into tabloAdi(kolon1,kolon2,kolon3,kolon4) values('" + txt1.Text + "','" + txt2.Text + "','" + txt3.Text + "','" + txt4.Text + "') "; VTBaglan.komutisle(komut);



![alt text](https://user-images.githubusercontent.com/39583220/41034606-c6f45180-6992-11e8-8731-82efa900c309.png)
