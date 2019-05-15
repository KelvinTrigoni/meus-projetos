using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LPll3bi
{
    public class negocios
    {
        public int codigo { get; set; }

        public string nome { get; set; }

        public string endereco { get; set; }

        public string telefone { get; set; }

        banco dados = new banco();


        public void inserir()
        {
            try
            {
                dados.comandosql("insert into LPII3bi (codigo, nome, endereco, telefone) values ('"+ dados.proximocod() + "','" + nome + "','" + endereco + "','" + telefone + "')");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

            public void alterar()
        {
            try
            {
                dados.comandosql("update LPII3bi set nome = '" + nome + "', endereco = '" + endereco + "',telefone = '" + telefone + "' where codigo = '" + codigo + "'");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

            public void preenchergrid(DataGridView Dgv)
        {
            try
            {
                dados.consultar(Dgv, "select * from LPII3bi");
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

            public void excluir(int codigo)
        {
            try
            {
                dados.comandosql("delete from LPII3bi where codigo = '" + codigo + "'");
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

            public void Concodigo(DataGridView Dgv)
        {
            try
            {
                dados.consultar(Dgv, "select * from LPII3bi where codigo = '" + codigo + "'");
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
            public void Connome(DataGridView Dgv)
        {
            try
            {
                dados.consultar(Dgv, "select * from LPII3bi where nome like '%"  + nome + "%'");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

            public void Confone(DataGridView Dgv)
        {
            try
            {
                dados.consultar(Dgv, "select * from LPII3bi where telefone like '%" + telefone + "%'");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




    }

 }
