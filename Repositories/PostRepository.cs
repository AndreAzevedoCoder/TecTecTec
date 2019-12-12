using System.Collections.Generic;
using System.IO;
using FeedbackMVC.Models;

namespace FeedbackMVC.Repositories
{
    public class PostRepository
    {
        private const string PATH = "Database/Posts.csv";
        public PostRepository(){
            if(!File.Exists(PATH)){
                File.Create(PATH).Close();
            }
        }

        public bool Inserir (Post post){
            var linha = new string[] {PrepararRegistroCSV(post)};
            File.AppendAllLines(PATH, linha);
            
            return true;
        }

        //TODO METODO PARA RECEBER TODOS OS POSTS DE TODOS OS CLIENTES
        public List<Post> ObterTodosOsPosts()
        {
            //TODO CRIA NOVA LISTA DE POSTS VAZIA PARA RECEBER OS POSTS
            List<Post> TodosOsPosts = new List<Post>();
            var linhas = File.ReadAllLines(PATH);

            foreach(var linha in linhas){


                    Post c = new Post();
                    c.ID = ulong.Parse(ExtrairValorDoCampo("ID", linha));
                    c.Curtidas = uint.Parse(ExtrairValorDoCampo("Curtidas", linha));
                    c.DonoDoPost = ExtrairValorDoCampo("Dono_Do_Post", linha);
                    c.DonoDoPostArroba = ExtrairValorDoCampo("Dono_Do_Post_Arroba", linha);
                    c.MensagemDoPost = ExtrairValorDoCampo("Mensagem_Do_Post", linha);
                    c.IDDaListaDeComentarios = ulong.Parse(ExtrairValorDoCampo("ID_Da_Lista_De_Comentarios", linha));
                    TodosOsPosts.Add(c);
                
            }

            
            //TODO RETORNA A LISTA DE TODOSOSPOSTS AGORA PREENCHIDA PELOS POSTS
            return TodosOsPosts;
        }


        public string ExtrairValorDoCampo(string nomeCampo, string linha){
            var chave = nomeCampo;
            var indiceChave = linha.IndexOf(chave);

            var indiceTerminal = linha.IndexOf(";", indiceChave);
            var valor = "";

            if(indiceTerminal != -1){
                valor = linha.Substring(indiceChave, indiceTerminal - indiceChave);
            }
            else{
                valor = linha.Substring(indiceChave);
            }

            System.Console.WriteLine($"Campo {nomeCampo} tem valor {valor}");
            return valor.Replace(nomeCampo + "=", "");
        }

        private string PrepararRegistroCSV (Post post){
            return $"ID={post.ID};Dono_Do_Post={post.DonoDoPost};Dono_Do_Post_Arroba={post.DonoDoPostArroba};Mensagem_Do_Post={post.MensagemDoPost};Curtidas={post.Curtidas};ID_Da_Lista_De_Comentarios={post.IDDaListaDeComentarios}";
        }
    }
}