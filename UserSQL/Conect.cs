using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient; // BIBLIOTECA CLASE SqlConnection
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserSQL
{
    public class Conect
    {

        // DECLARACION DE LAS VARIABLES DE LA CLASE SQL DE FORMA GLOBAL

        SqlCommand consult; // VARIABLE QUE ALMACENA LA CONSULTA SEGUN DEMANDEMOS EN LA TABLA, ES UNA CLASE ESPECIFICA DE LA BIBLIOTECA
        SqlDataReader dr; // VARIBLE DEL TIPO READ DEL FICHERO SQL, RECIBIRA LOS DATOS QUE DEMANDEMOS

        SqlConnection conect;

        DataTable dt;
        SqlDataAdapter da;


        public Conect()
        {
            try
            {
                conect = new SqlConnection("Data Source=; Initial Catalog = USUARIOS; Integrated Security = True");
                conect.Open();
                MessageBox.Show("ALRIGHT");
            }
            catch (Exception error)
            {
                MessageBox.Show("Not conected " + error.ToString());
                
            }
        }


       public void CargarDatos(DataGridView dgvData)
        {
            try
            {
                da = new SqlDataAdapter("select * from datos_usuario ", conect);
                dt = new DataTable();

                da.Fill(dt);
                dgvData.DataSource = dt;

            } catch (Exception error)
            {
                MessageBox.Show("Error" + error.ToString());
            }
        }

        public string Insert(ClsUser user)
        {
            string response = "se insertó el nuevo campo";
            try
            {
                
                consult = new SqlCommand(string.Format("INSERT into datos_usuario(users, password, mail) VALUES ('{0}', '{1}', '{2}')", user.Users, user.Password, user.Mail),conect);// REALIZA LA INSTRUCCION SQL CON EL OBJETO DE LA CLASE USER

                consult.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not conected " + ex.ToString());
                response = "Not posible";
            }

            return response;
        }

        public bool VerificaRegistro(ClsUser user)
        {
       
            bool verifica = true;
            try
            {
                consult = new SqlCommand(string.Format("SELECT users FROM datos_usuario where users = '{0}'", user.Users), conect);
                consult.ExecuteNonQuery();
                dr = consult.ExecuteReader();

                while(dr.Read())
                {
                    verifica = false;
                }
                dr.Close();
            } catch (Exception ex)
            {
                MessageBox.Show("No se puede hacer consulta " + ex.ToString());
            }

            return verifica;
        }


        public bool Actualiza(string user, string pass, string mail)
        {
            bool response = true;

            try
            {
                consult = new SqlCommand(string.Format("UPDATE datos_usuario set password = '{0}',  mail = '{1}' WHERE users = '{2}'", pass, mail, user), conect);
                consult.ExecuteNonQuery();
                MessageBox.Show("ACTUALIZADO CON EXITO");
                response = false;
            } catch(Exception error)
            {
                MessageBox.Show("NO ACTUALIZADO" + error.ToString());
                response = true;
            }

            return response;
        }

        public bool Elimina(string user)
        {
            bool response = true;

            try
            {
                consult = new SqlCommand(string.Format("DELETE from datos_usuario WHERE users ='{0}'", user), conect);
                consult.ExecuteNonQuery();
                MessageBox.Show("USUARIO ELIMINADO");
                response = false;
            }
            catch (Exception error)
            {
                MessageBox.Show("NO ELIMINADO" + error.ToString());
                response = true;
            }

            return response;
        }

        public bool Search(string response, string option, DataGridView dgvSearch)
        {
            bool response1 = true;

            try
            {
                if(response == "Usuario")
                {
                    // consult = new SqlCommand(string.Format("SELECT * from datos_usuario WHERE users ='{0}'", option), conect);
                    da = new SqlDataAdapter(string.Format("SELECT * from datos_usuario WHERE users ='{0}'", option), conect);
                    dt = new DataTable();
                    //consult.ExecuteNonQuery();

                    da.Fill(dt);
                    dgvSearch.DataSource = dt;
                     MessageBox.Show("REGISTRO ENCONTRADO");
                     response1 = false;
                } if (response == "Contraseña")
                {
                    //consult = new SqlCommand(string.Format("SELECT * from datos_usuario WHERE password ='{0}'", option), conect);
                    //consult.ExecuteNonQuery();

                    da = new SqlDataAdapter(string.Format("SELECT * from datos_usuario WHERE password ='{0}'", option), conect);
                    dt = new DataTable();
                    //consult.ExecuteNonQuery();

                    da.Fill(dt);
                    dgvSearch.DataSource = dt;
                    MessageBox.Show("REGISTRO ENCONTRADO");
                    response1 = false;
                } else
                {
                    //consult = new SqlCommand(string.Format("SELECT * from datos_usuario WHERE mail ='{0}'", option), conect);
                    //consult.ExecuteNonQuery();

                    da = new SqlDataAdapter(string.Format("SELECT * from datos_usuario WHERE mail ='{0}'", option), conect);
                    dt = new DataTable();
                    //consult.ExecuteNonQuery();

                    da.Fill(dt);
                    dgvSearch.DataSource = dt;

                    MessageBox.Show("REGISTRO ENCONTRADO");
                    response1 = false;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("NO ELIMINADO" + error.ToString());
            
            }

            return response1;
        }
    }
}