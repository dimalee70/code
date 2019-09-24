using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace idetTest.Models
{
    public class DepartamentDAO
    {
        string connectionString ="Server=localhost;Database=Testdb;User=sa;Password=1234DimaLi;";

        // public void insertEmp(ItemEmployee emp, int pos_id)
        // {

        // }
        
        public void insertImage(Image img)
        {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "insert into imageinfo(imagepath) values(@imagepath)";
                    cmd.Parameters.AddWithValue("@imagepath",img.path);
                    con.Open();  
                    cmd.ExecuteNonQuery();
                } 
        }
        public void insertPer(ItemEmployee emp, int per_id)
        {
            int emp_id = getId(emp);
            if( emp_id!= -1)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "insert into perrel(emp_id,per_id) values(@emp_id,@per_id)";
                    cmd.Parameters.AddWithValue("@emp_id",emp_id);
                    cmd.Parameters.AddWithValue("@dep_id",per_id);
                    con.Open();  
                    cmd.ExecuteNonQuery();
                } 
            }
        }
        public void insertIntoRel(ItemEmployee emp,int pos_id,int dep_id)
        {
            int emp_id = getId(emp);
            if( emp_id!= -1)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "insert into itemrel(emp_id,pos_id, dep_id) values(@emp_id,@pos_id,@dep_id)";
                    cmd.Parameters.Add("@emp_id",SqlDbType.NVarChar,100).Value = emp_id;
                    cmd.Parameters.Add("@pos_id",SqlDbType.NVarChar,100).Value = pos_id;
                    cmd.Parameters.Add("@dep_id",SqlDbType.NVarChar,100).Value = dep_id;
                    con.Open();  
                    cmd.ExecuteNonQuery();
                } 
            }
        }
        public int getId(ItemEmployee emp)
        {
            int id = -1;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "select id from itememp where name = @name and surname = @surname and patronymic = @patronymic;";
                cmd.Parameters.Add("@name",SqlDbType.NVarChar,100).Value = emp.name;
                cmd.Parameters.Add("@surname",SqlDbType.NVarChar,100).Value = emp.surname;
                cmd.Parameters.Add("@patronymic",SqlDbType.NVarChar,100).Value = emp.patronymic;
                con.Open(); 
                SqlDataReader rdr = cmd.ExecuteReader();  
                while (rdr.Read())  
                {  
                    id = Convert.ToInt32(rdr["id"]);
                }  
                con.Close();  
            } 
            return id;
        }
        public void InsertEmp(ItemEmployee emp)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "insert into itememp(name,surname, patronymic) values(@name,@surname,@patronymic)";
                cmd.Parameters.Add("@name",SqlDbType.NVarChar,100).Value = emp.name;
                cmd.Parameters.Add("@surname",SqlDbType.NVarChar,100).Value = emp.surname;
                cmd.Parameters.Add("@patronymic",SqlDbType.NVarChar,100).Value = emp.patronymic;
                con.Open();  
                cmd.ExecuteNonQuery();
            } 
        }
        public IEnumerable<Permision> GetAllPermision()
        {
            List<Permision> listPer = new List<Permision>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "select id,name from permision;";
                con.Open();  
                SqlDataReader rdr = cmd.ExecuteReader();  
  
                while (rdr.Read())  
                {  
                    Permision per = new Permision();
                    per.id = Convert.ToInt32(rdr["id"]);
                    per.name = rdr["name"].ToString();
                    listPer.Add(per);  
                }  
                con.Close();  
            }
            return listPer; 
        }
        public IEnumerable<Department> GetAllDepartment()
        {
            List<Department> listDep = new List<Department>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "select id,name from department;";
                con.Open();  
                SqlDataReader rdr = cmd.ExecuteReader();  
  
                while (rdr.Read())  
                {  
                    Department dep = new Department();
                    dep.id = Convert.ToInt32(rdr["id"]);
                    dep.name = rdr["name"].ToString();
                    listDep.Add(dep);  
                }  
                con.Close();  
            }
            return listDep; 
        }
        public IEnumerable<Position> GetAllPos()
        {
            List<Position> listPos = new List<Position>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "select id,name from pos;";
                con.Open();  
                SqlDataReader rdr = cmd.ExecuteReader();  
  
                while (rdr.Read())  
                {  
                    Position pos = new Position();
                    pos.id = Convert.ToInt32(rdr["id"]);
                    pos.name = rdr["name"].ToString();
                    listPos.Add(pos);  
                }  
                con.Close();  
            }
            return listPos; 
        }
        public IEnumerable<ItemEmployee> GetAllEmp(int id)
        {
            List<ItemEmployee> listEmp = new List<ItemEmployee>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "select e.id,e.name, e.surname,e.patronymic from itememp e inner join itemrel r on r.emp_id = e.id where r.dep_id = @id;";
                cmd.Parameters.AddWithValue("@id",id); 
                con.Open();  
                SqlDataReader rdr = cmd.ExecuteReader();  
  
                while (rdr.Read())  
                {  
                    ItemEmployee emp = new ItemEmployee();
                    emp.id = Convert.ToInt32(rdr["id"]);
                    emp.name = rdr["name"].ToString();
                    emp.surname = rdr["surname"].ToString();
                    emp.patronymic = rdr["patronymic"].ToString();
                    emp.position = GetPos(emp.id);
                    emp.listPermision = GetAllPer(emp.id).ToList();
                     // Employee employee = new Employee();  
  
                    // employee.id = System.Convert.ToInt32(rdr["id"]);  
                    // employee.name = rdr["name"].ToString();  
                    // employee.surname = rdr["surname"].ToString();  
                    // employee.patronymic = rdr["patronymic"].ToString();   
                    listEmp.Add(emp);  
                }  
                con.Close();   
            }
            return listEmp; 
        }

        public Position GetPos(int id)
        {
            Position pos = new Position();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "select pos.id,pos.name from itememp e inner join itemrel r on r.emp_id = e.id "+
                                    "inner join pos on pos.id = r.pos_id where e.id = @id; ";
                cmd.Parameters.AddWithValue("@id",id); 
                con.Open();  
                SqlDataReader rdr = cmd.ExecuteReader();  
  
                while (rdr.Read())  
                {  
                    pos.id = Convert.ToInt32(rdr["id"]);
                    pos.name = rdr["name"].ToString();  
                }  
                con.Close();  
            }
            return pos; 
        }
        public IEnumerable<Permision> GetAllPer(int id)
        {
            List<Permision> listPer = new List<Permision>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "select p.id, p.name from itememp "+
                            "e inner join perrel r on r.emp_id = e.id inner join permision p on p.id = r.per_id where e.id = @id;";
                cmd.Parameters.AddWithValue("@id",id); 
                con.Open();  
                SqlDataReader rdr = cmd.ExecuteReader();  
  
                while (rdr.Read())  
                {  
                    Permision per = new Permision();
                    per.id = Convert.ToInt32(rdr["id"]);
                    per.name = rdr["name"].ToString();
                    
                     // Employee employee = new Employee();  
  
                    // employee.id = System.Convert.ToInt32(rdr["id"]);  
                    // employee.name = rdr["name"].ToString();  
                    // employee.surname = rdr["surname"].ToString();  
                    // employee.patronymic = rdr["patronymic"].ToString();   
                    listPer.Add(per);  
                }  
                con.Close();  
            }
            return listPer; 
        }
        public IEnumerable<Department> GetAllDep()
        {

            List<Department> listDep = new List<Department>(); 
  
            using (SqlConnection con = new SqlConnection(connectionString))  
            {  
                SqlCommand cmd = con.CreateCommand();  
                cmd.CommandText = "select id,name from department;"; 
             
                con.Open();  
                SqlDataReader rdr = cmd.ExecuteReader();  
  
                while (rdr.Read())  
                {  
                    Department dep = new Department();
                    dep.id = Convert.ToInt32(rdr["id"]);
                    dep.name = rdr["name"].ToString();
                    dep.listEmployee = GetAllEmp(dep.id).ToList();
                     // Employee employee = new Employee();  
  
                    // employee.id = System.Convert.ToInt32(rdr["id"]);  
                    // employee.name = rdr["name"].ToString();  
                    // employee.surname = rdr["surname"].ToString();  
                    // employee.patronymic = rdr["patronymic"].ToString();   
                    listDep.Add(dep);  
                }  
                con.Close();  
            }
            return listDep;  
        }  
    }
}