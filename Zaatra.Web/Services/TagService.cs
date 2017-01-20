using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Zaatra.Models;
using Zaatra.Models.ViewModels;
using Zaatra.Repository;

namespace Zaatra.Services
{
    public class TagService
    {
        readonly TagRepository _tagRepository = new TagRepository();

        public List<Tag> GetAll()
        {
            return _tagRepository.GetAll();
        } 

        public List<TagWithCategoryViewModel> GetTagsForFilterPortion()
        {
            var packageTags = _tagRepository.GetAll().GroupBy(_ => _.TagCategory.Name);
            var tags = new List<TagWithCategoryViewModel>();
            foreach (var tagCategory in packageTags)
            {
                var tagCategoryViewModel = new TagWithCategoryViewModel { Name = tagCategory.Key };
                foreach (var tag in tagCategory)
                {
                    tagCategoryViewModel.TagViewModels.Add(new TagViewModel
                    {
                        Id = tag.Id,
                        Name = tag.Name,
                        IsSelected = false
                    });
                }
                tags.Add(tagCategoryViewModel);
            }
            return tags;
        } 
    }
}