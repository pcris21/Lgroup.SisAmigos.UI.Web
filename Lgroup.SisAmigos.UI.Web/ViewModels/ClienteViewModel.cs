using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

/// <summary>
/// O model no mvc significa aramzenamento de dados. Um nome mais profissinal, trocar de model para ViewModel
/// Siginifica que estamos armazenando dados  de uma determinada tela
///
/// Data Annotations são configurações adicionais, opcionais
/// </summary>
namespace Lgroup.SisAmigos.UI.Web.ViewModels
{
    public class ClienteViewModel 
    { 
        public Int32 Codigo { get; set; }

        [StringLength(50, MinimumLength = 3, ErrorMessage = "O nome deve ter de 3 a 50 caracteres")]
        [Required(ErrorMessage = "Informe o seu nome")]
        [Display(Name = "Nome")]
        public String  Nome { get; set; }

        [StringLength(50, MinimumLength = 3, ErrorMessage = "O E-mail deve ter de 3 a 50 caracteres")]
        [RegularExpression(@"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"
                                   + "@"
                                   + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$", ErrorMessage = "E-mail inválido")]  // @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$"
        [Required(ErrorMessage = "Informe seu e-mail")]
        [Display(Name = "E-mail")]
        public String Email { get; set; }

        [Required(ErrorMessage ="Informe o telefone")]
        [Display(Name = "Celular")]
        public String Telefone { get; set; }


        //[Display(Name = "Data de Nascimento", ResourceType = typeof(Resources.Resources))]  // Display Exibe o texto desejado para a propriedade
        //[Required(ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "DataNascimento")]

        [Required(ErrorMessage = "Informe a Data de Nascimento")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? DataNascimento { get; set; }
                
        //Classe SelectList é exclusiva para carregar combo
        [Display(Name = "Sexo")]
        public SelectList ListaSexos { get; set; }

        public Int32 CodigoSexo { get; set; }

        
    }
}