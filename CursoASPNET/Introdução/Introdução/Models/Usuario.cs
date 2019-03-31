using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Introdução.Models
{
    public class Usuario
    {
        //VALIDAÇÕES NO FORMULARIO

        [Required(ErrorMessage="O nome é obrigatório")]//O nome não pode estar em branco
        public string Nome { get; set; }
        [StringLength(50,MinimumLength =5,ErrorMessage = "Insira uma informação de 5 a 50 caracteres")]//nas observacoes o tamanho maximo é 50 e o minímo 5 caracteres
        public string Observacoes { get; set; }
        [Range(18,70, ErrorMessage = "Idade tem que estar entre 18 anos e 70")]//Idade entre 18 e 70
        public int Idade { get; set; }
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*",ErrorMessage ="Digitar o email corretamente")]//Expressão regular para email
        public string Email { get; set; }
        [RegularExpression(@"[a-zA-Z]{5,15}",ErrorMessage ="Somente letrar e de 5 a 15 caracteres")]//Expressão regular para aceitar palavras minusculas e maiusculas, com minimo de 5 e maximo 15 caracteres
        [Required(ErrorMessage = "O login é obrigatório")]//O login não pode estar em branco
        [Remote("LoginUnico", "Usuario", ErrorMessage="Este login ja existe")]//Busca uma função para que essas seja executada
        public string Login { get; set; }
        [Required(ErrorMessage = "A senha é obrigatório")]//A senha não pode estar em branco
        public string Senha { get; set; }
        [System.Web.Mvc.Compare("Senha",ErrorMessage ="As senhas não são iguais!")]//Compara se a senha digita no campo SENHA é igual ao campo CONFIRMAR SENHA
        public string ConfirmaSenha { get; set; }
    }
}