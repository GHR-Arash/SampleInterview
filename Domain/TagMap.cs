using Sample.Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Domain
{
    public class TagMap:Entity,IAggregateRoot
    {
        private int _tagId;
        public Tag Tag { get; private set; }


        private int _categoryId;
        public Category Category { get; private set; }


        private int _subcategoryId;
        public Subcategory SubCategory { get; private set; }

        public TagMap()
        {

        }
        public  TagMap(int tagId ,int categoryId,int subCategoryId)
        {
            this._tagId = tagId;
            this._categoryId = categoryId;
            this._subcategoryId = subCategoryId;
        }
    }
}
