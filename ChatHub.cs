using Microsoft.AspNetCore.SignalR;
namespace chat.ChatHub
{
    public class Chat : Hub
    {
        public async Task Mensagem(string idConexao, string autor, string mensagem)
        {
            await Clients.AllExcept(idConexao).SendAsync("EnviarMensagem",autor, mensagem);
        }
    }
}