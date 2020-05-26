namespace Atividade_POO
{
    public class celular
    {
        public string cor;
        public string modelo;
        public float tamanho;
        public bool ligado;
        public string mensagem;
        public string ligacao;

        // public string ligarCelular(){
        //     return "celular ligado";
        // }

        /// <summary>
        /// Enviar mensagem
        /// </summary>
        /// <returns>mensagem</returns>
        public string enviarMensagem(){
            return mensagem;
        }
        /// <summary>
        /// Fazer uma ligaçao
        /// </summary>
        /// <returns>ligar</returns>
        public string fazerLigacao(){
            return "ligando para"+ligacao;
        }
          public bool traduzConsole(string condicao){
            if(condicao == "sim"){
                ligado = true;
            }else{
                ligado = false;
            }
            return ligado;
        }
    }
}