namespace APIMinima
{
    public class TodoItemDTO
    {
        public int id {  get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; }
        public TodoItemDTO() { }
        public TodoItemDTO(Todo todoitem) => 
            (id, Name, IsComplete)=(todoitem.id, todoitem.Name, todoitem.IsComplete);
    }
}
