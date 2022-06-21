//Connect

            string Conn = "Data Source=RAYANMEHR;Initial Catalog=proj8;Integrated Security=True";

            SqlConnection conn = new SqlConnection(Conn);

            conn.Open();

//Insert 1

            string insertQ = "INSERT INTO [amirAli] (id,name,price,count) " + "VALUES('1','aprtement','800','1')";

            SqlCommand cmd = new SqlCommand(insertQ, conn);

            cmd.ExecuteNonQuery();

//Update 1

            string updat1 = "UPDATE [amirAli]"+" SET price='300' where id='1'";

            SqlCommand cmd1 = new SqlCommand(updat1, conn);

            cmd1.ExecuteNonQuery();

            string updat2 = "UPDATE [amirAli]" + " SET price='40' where id='2'";

            SqlCommand cmd2 = new SqlCommand(updat2, conn);

            cmd2.ExecuteNonQuery();

            string updat3 = "UPDATE [amirAli]" + " SET price='200' where id='3'";

            SqlCommand cmd3 = new SqlCommand(updat3, conn);

            cmd3.ExecuteNonQuery();

//Delete

            string delet = "DELETE [amirAli] WHERE id ='2'";

            SqlCommand cmd4 = new SqlCommand(delet, conn);

            cmd4.ExecuteNonQuery();

            string delet1 = "DELETE [amirAli] WHERE id ='3'";

            SqlCommand cmd5 = new SqlCommand(delet1, conn);

            cmd5.ExecuteNonQuery();



//Insert 2

            string insert = "INSERT INTO [amirAli] (id,name,price,count) " + "VALUES('2','chash','40','22500')";

            SqlCommand cmd6 = new SqlCommand(insert, conn);

            cmd6.ExecuteNonQuery();



//Update 2

            string updat4 = "UPDATE [amirAli]" + " SET price='280' where id='2'";

            SqlCommand cmd7 = new SqlCommand(updat4, conn);

            cmd7.ExecuteNonQuery();



//Insert 3

            string insert1 = "INSERT INTO [amirAli] (id,name,price,count) " + "VALUES('3','eos','40','5')";

            SqlCommand cmd8 = new SqlCommand(insert1, conn);

            cmd8.ExecuteNonQuery();

            string insert2 = "INSERT INTO [amirAli] (id,name,price,count) " + "VALUES('4','eth','60','7')";

            SqlCommand cmd9 = new SqlCommand(insert2, conn);

            cmd9.ExecuteNonQuery();



            conn.Close();