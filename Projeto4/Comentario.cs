using System;


public class Comentario{
  public int id;
  public int idVoluntario;
  public int idAcao;
  public string descricao;


  public int Id{
    get => id;
    set => id = value;
  }
  public int IdVoluntario{
    get => idVoluntario;
    set => idVoluntario = value;
  }
  public int IdAcao{
    get => idAcao;
    set => idAcao = value;
  }
  public string Descricao{
    get => descricao;
    set => descricao = value;
  }
  
  public Comentario(){}


public Comentario(int Id){
    this.id = Id;
  }
  public Comentario(int Id, string Descricao){
    this.id = Id;
    this.descricao = Descricao;
  }
  


  public Comentario(int Id, string Descricao, int IdVoluntario,int IdAcao){
   this.id = Id;
   this.idVoluntario = IdVoluntario;
   this.descricao = Descricao;
   this.idAcao = IdAcao;
 }
  public void SetDescricao(string umaDescricao){
    this.descricao = umaDescricao;
  }
  public string  GetDescricao(){
    return descricao;
  }
  public void Setid(int umId){
    this.id = umId;
  }
  public int Getid(){
    return id;
  }
  public void SetidVoluntario(int umIdVoluntario){
    this.id = umIdVoluntario;
  }
  public int  GetidVoluntario(){
    return idVoluntario;
  }
  public void SetidAcao(int umidAcao){
    this.idAcao = umidAcao;
  }
  public int GetidAcao(){
    return idAcao;
  }
  public override string ToString(){
    return $"{descricao} - Comentario {id} - no movimento {idAcao} - Feito pelo voluntario: ";
  }
}