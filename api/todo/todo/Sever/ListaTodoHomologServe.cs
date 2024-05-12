using System.Runtime.Intrinsics.X86;
using System;
using System.Data;
using todo.Data;
using todo.Model;


namespace todo.Sever
{
    // depende do modelo ListaTodoHomologModel para representar os dados da entidade "ListaTodoHomolog". desempenha um papel crucial na interação entre a camada de apresentação (controlador) e a camada de acesso a dados
    public class ListaTodoHomologServe
    {
        public List<ListaTodoHomologModel> ListaTodoHomolog()
        {
            var listaTodoHomologData = new ListaTodoHomologData();
            try
            {
                DataSet ds = new DataSet();

                ds = listaTodoHomologData.selectListaTodoHomolog();

                if (ds.Tables[0].Rows.Count > 0)
                {
                    List<ListaTodoHomologModel> lista = new List<ListaTodoHomologModel>();

                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        string DataCria = String.Empty;
                        DataCria = ds.Tables[0].Rows[i]["DataCriacao"].ToString();
                        if (DataCria.Length > 3)
                        {
                            DataCria = DateTime.Parse(DataCria).ToString("dd/MM/yyyy");
                        }
                        string DataConclu = String.Empty;
                        DataConclu = ds.Tables[0].Rows[i]["DataConclusao"].ToString();
                        if (DataConclu.Length > 3)
                        {
                            DataConclu = DateTime.Parse(DataConclu).ToString("dd/MM/yyyy");
                        }
                        lista.Add(new ListaTodoHomologModel
                        {
                            ID = int.Parse(ds.Tables[0].Rows[i]["ID"].ToString()),
                            NomeTarefa = ds.Tables[0].Rows[i]["NomeTarefa"].ToString(),
                            DataCriacao = DataCria,
                            DataConclusao = DataConclu,
                            Status = bool.Parse(ds.Tables[0].Rows[i]["Status"].ToString()),
                        });
                    }

                    return lista;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                string erro = ex.Message;
                return null;
            }

        }


        public List<ListaTodoHomologModel> ListaTodoHomolog(int id)
        {
            var listaTodoHomologData = new ListaTodoHomologData();
            try
            {
                DataSet ds = new DataSet();

                ds = listaTodoHomologData.selectListaTodoHomolog(id);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    List<ListaTodoHomologModel> lista = new List<ListaTodoHomologModel>();

                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        string DataCria = String.Empty;
                        DataCria = ds.Tables[0].Rows[i]["DataCriacao"].ToString();
                        if (DataCria.Length > 3)
                        {
                            DataCria = DateTime.Parse(DataCria).ToString("dd/MM/yyyy");
                        }
                        string DataConclu = String.Empty;
                        DataConclu = ds.Tables[0].Rows[i]["DataConclusao"].ToString();
                        if (DataConclu.Length > 3)
                        {
                            DataConclu = DateTime.Parse(DataConclu).ToString("dd/MM/yyyy");
                        }
                        lista.Add(new ListaTodoHomologModel
                        {
                            ID = int.Parse(ds.Tables[0].Rows[i]["ID"].ToString()),
                            NomeTarefa = ds.Tables[0].Rows[i]["NomeTarefa"].ToString(),
                            DataCriacao = DataCria,
                            DataConclusao = DataConclu,
                            Status = bool.Parse(ds.Tables[0].Rows[i]["Status"].ToString()),
                        });
                    }

                    return lista;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                string erro = ex.Message;
                return null;
            }

        }

        public string deleteTodoHomolog(int id)
        {
            try
            {

                ListaTodoHomologData listaTodoHomologData = new ListaTodoHomologData();
                DataSet ds = new DataSet();

                string sql = String.Empty;

                listaTodoHomologData.deleteListaTodoHomolog(id);

                return "0";

            }

            catch (Exception e)
            {
                string ex = e.Message;
                return "-1|" + ex;
            }
        }

        public string InsertTodoHomolog(ListaTodoHomologModel listaTodoHomologModel)
        {
            try
            {

                ListaTodoHomologData listaTodoHomologData = new ListaTodoHomologData();
                DataSet ds = new DataSet();

                string sql = String.Empty;

                listaTodoHomologData.insertTodoHomolog(listaTodoHomologModel);

                return "0";

            }

            catch (Exception e)
            {
                string ex = e.Message;
                return "-1|" + ex;
            }
        }

        public string AtualizaTodoHomolog(ListaTodoHomologModel listaTodoHomologModel)
        {

            try
            {

                ListaTodoHomologData listaTodoHomologData = new ListaTodoHomologData();
                DataSet ds = new DataSet();

                string sql = String.Empty;

                listaTodoHomologData.updateTodoHomolog(listaTodoHomologModel);

                return "0";

            }

            catch (Exception e)
            {
                string ex = e.Message;
                return "-1|" + ex;
            }
        }

    }



}

