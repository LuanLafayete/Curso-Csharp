
namespace PostAndComment.Entities
{
    class Comment
    {
        //Atributo
        public string Text { get; set; }
        
        //Construtor
        public Comment()
        {
        }
        public Comment(string text)
        {
            Text = text;
        }
    }        
}
