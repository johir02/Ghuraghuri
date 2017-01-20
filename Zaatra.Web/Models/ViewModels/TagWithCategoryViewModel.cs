using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zaatra.Models.ViewModels
{
    public class TagWithCategoryViewModel : BasicViewModel
    {
        public TagWithCategoryViewModel()
        {
            TagViewModels = new List<TagViewModel>();
        }
        public List<TagViewModel> TagViewModels { get; set; } 

    }
}