namespace SimpleNotesApi.Models
{
    public class Note
    {
        public int Id { get; set; }               // Primární klíč
        public string Title { get; set; } = "";   // Název poznámky
        public string Content { get; set; } = ""; // Obsah poznámky
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow; // Datum vytvoření
    }
}
