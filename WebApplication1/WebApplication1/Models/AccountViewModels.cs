﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        internal string idUsuario;
        internal object eMail;

        [Required]
        [Display(Name = "idUsuario")]
        public string IdUsuario { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Código")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "¿Recordar este explorador?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "idUsuario")]
        public string idUsuario { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "idUsuario")]
        [EmailAddress]
        public string idUsuario { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "clave")]
        public string clave { get; set; }

        [Display(Name = "¿Recordar cuenta?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "idUsuario")]
        public string idUsuario { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "El número de caracteres de {0} debe ser al menos {2}.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "clave")]
        public string clave { get; set; }

    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "eMail")]
        public string eMail { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "El número de caracteres de {0} debe ser al menos {2}.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "clave")]
        public string clave { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar clave")]
        [Compare("Password", ErrorMessage = "La clave y la clave de confirmación no coinciden.")]
        public string ConfirmClave { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "eMail")]
        public string eMail { get; set; }
    }
}
