namespace _AulaPOOCelular
{
    public class Celulares{
        
    public string cor;
    public string modelo;
    public int tamanho;
    public bool ligado;
    public string ligação;
    public string envioMensagem;
    public string opçãoDesligar;
    public string inválido;
   
    public bool Ligar(){

        if(ligado == false){
               return false;
        }else{
               return true;
        }
    }
    public string Desligar(){
            
        string resultado1 = opçãoDesligar;
        if(ligado == true){
            return opçãoDesligar;
        }else{
            return inválido;
        }
    }
    public string FazerLigação(){
        string resultado2 = ligação;
        if(ligado == true){
            return resultado2;
        }else{
            return inválido;
        }
    }
    public string EnviarMensagem(){
        string resultado3 = envioMensagem; 
        if(ligado == true){
                return resultado3;
            }else{    
                return inválido;
            }    
        }    
    }
}