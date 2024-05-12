namespace todo.Model
{
    //Nos métodos InsertTodoHomolog e AtualizaTodoHomolog no controlador TodoController, observe que ambos os métodos esperam receber um objeto do tipo ListaTodoHomologModel no corpo da solicitação
    public class ListaTodoHomologModel
    {
        public int ID { get; set; }
        public string NomeTarefa { get; set; }
        public string DataCriacao { get; set; }
        public string DataConclusao { get; set; }
        public bool Status { get; set; }
    }
}
