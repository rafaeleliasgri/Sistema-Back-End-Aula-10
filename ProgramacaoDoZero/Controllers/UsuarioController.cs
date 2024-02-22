using ProgramacaoDoZero.Models;
using Microsoft.AspNetCore.Mvc;

namespace ProgramacaoDoZero.Controllers;

[ApiController]
[Route("api/UsuarioController")]
public class UsuarioController : ControllerBase
{
    [HttpPost]
    [Route("Login")]
    public LoginResult Login(LoginRequest request)
    {

        var result = new LoginResult();

        if (request == null)
        {
            result.Sucesso = false;
            result.Mensagem = "Parâmetro request veio nulo.";
        }
        else if (request.Email == "")
        {
            result.Sucesso = false;
            result.Mensagem = "E-mail Obrigatório";
        }
        else if (request.Senha == "")
        {
            result.Sucesso = false;
            result.Mensagem = "Senha obrigatória";
        }
        else
        {
            result.Sucesso = true;
            result.Mensagem = "Login realizado com Sucesso!";
        }

        return result;
    }

    [HttpPost]
    [Route("Cadastro")]
    public CadastroResult Cadastro(CadastroRequest request)
    {
        var result = new CadastroResult();

        if (request == null ||
        string.IsNullOrEmpty(request.Nome) ||
        string.IsNullOrEmpty(request.Sobrenome) ||
        string.IsNullOrEmpty(request.Telefone) ||
        string.IsNullOrEmpty(request.Genero) ||
        string.IsNullOrEmpty(request.Email) ||
        string.IsNullOrEmpty(request.Senha))
        {
            result.Sucesso = false;
            result.Mensagem = "Todos os campos são obrigatórios";
        }
        else
        {
            result.Sucesso = true;
            result.Mensagem = "Cadastro realizado com Sucesso!";
        }

        return result;

    }

    [HttpPost]
    [Route("EsqueceuSenha")]
    public EsqueceuSenhaResult EsqueceuSenha(EsqueceuSenhaRequest request)
    {
        var result = new EsqueceuSenhaResult();

        if (request == null ||
        string.IsNullOrEmpty(request.Email))
        {
            result.Sucesso = false;
            result.Mensagem = "E-mail obrigatório";
        }
        else
        {
            result.Sucesso = true;
            result.Mensagem = "E-mail enviado com Sucesso!";
        }

        return result;
    }
}