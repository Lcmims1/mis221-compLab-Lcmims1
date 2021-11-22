namespace mis221_compLab_Lcmims1_2
{
    public class Book
    {
        private string ISBN {get;set;} 
        private string Title {get;set;} 
        private Author Author {get;set;}
    
        public Book(string tempISBN, string tempTitle, Author tempAuthor){
            this.ISBN = tempISBN;
            this.Title = tempTitle;
            this.Author = tempAuthor;
        }
        
public string GetIsbn(){
return ISBN;
}
public void SetIsbn(string tempISBN){
this.ISBN = tempISBN;
}
public string GetTitle(){
return Title;
}
public void SetTitle(string tempTitle){
this.Title = tempTitle;
}
public Author GetAuthor(){
return Author;
}
public void SetAuthor(Author tempAuthor){
this.Author = tempAuthor;

}
public override string ToString(){
    return "isbn =  " +ISBN+ ", title =  " +Title+ Author.ToString();
}
    }
}