using System;
public class Inscricao{
  public int idInsc;
  private int idVoluntario;
  private int idAcao;
  public bool presenca;

  public int IdInsc{
    get => idInsc;
    set => idInsc = value;
  }
  public int IdVoluntario{
    get => idVoluntario;
    set => idVoluntario = value;
  }
  public int IdAcao{
    get => idAcao;
    set => idAcao = value;
  }
  public bool Presenca{
    get => presenca;
    set => presenca = value;
  }
  
  public Inscricao(){}
  public Inscricao(int idInsc){
    this.idInsc = idInsc;
    }
  
  public Inscricao(int idInsc, int idVoluntario, int idAcao, bool Presenca){
    this.idInsc = idInsc;
    this.idVoluntario = idVoluntario;
    this.idAcao = idAcao;
    this.presenca = Presenca;
    
    
  }
  public void SetidInsc(int idInsc){
        this.idInsc = idInsc;  
  }
  public void SetidVoluntario(int idVoluntario){
        this.idVoluntario = idVoluntario;  
  }
  public void SetidAcao(int idAcao){
        this.idAcao = idAcao;  
  }
  public void SetPresenca(bool umaPresenca){
    this.presenca = umaPresenca;
  }
  public int GetidInsc(){
    return idInsc;
  }
  public int GetidVoluntario(){
    return idVoluntario;
  }
  public int GetidAcao(){
    return idAcao;
}
  public bool GetPresenca(){
    return presenca;
  }
   public static bool ConfirmarPresenca(int i, bool x){
  if (i == 1) x = true;
    return x;
  }
  public override string ToString(){
    return $"Inscrição de numero: {idInsc} - O voluntario ";
    }
  }
