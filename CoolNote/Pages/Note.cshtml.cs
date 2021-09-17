using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace CoolNote.Pages
{
    public class NoteModel : PageModel
    {
        [BindProperty, Required]
        public string Note
        {
            get => DataManager.Note;
            set => DataManager.Note = value;
        }

        public int EditsAmount
        {
            get => DataManager.EditsAmount;
            set => DataManager.EditsAmount = value;
        }

        public IActionResult OnPost()
        {
            EditsAmount++;
            return Redirect("/Index");
        }
    }
}
