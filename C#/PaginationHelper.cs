namespace AlghoritmsAndDataStructures
{
    using System.Collections.Generic;

    public class PagnationHelper<T>
    {
        // TODO: Complete this class

        private IList<T> _collection;
        private int _itemsPerPage;

        /// <summary>
        /// Constructor, takes in a list of items and the number of items that fit within a single page
        /// </summary>
        /// <param name="collection">A list of items</param>
        /// <param name="itemsPerPage">The number of items that fit within a single page</param>
        public PagnationHelper(IList<T> collection, int itemsPerPage)
        {
            this._collection = collection;
            this._itemsPerPage = itemsPerPage;
        }

        /// <summary>
        /// The number of items within the collection
        /// </summary>
        public int ItemCount
        {
            get
            {
                return this._collection.Count;
            }
        }

        /// <summary>
        /// The number of pages
        /// </summary>
        public int PageCount
        {
            get
            {
                return (this.ItemCount % this._itemsPerPage) == 0 ? this.ItemCount / this._itemsPerPage : this.ItemCount / this._itemsPerPage + 1;
            }
        }

        /// <summary>
        /// Returns the number of items in the page at the given page index 
        /// </summary>
        /// <param name="pageIndex">The zero-based page index to get the number of items for</param>
        /// <returns>The number of items on the specified page or -1 for pageIndex values that are out of range</returns>
        /// 
        public int PageItemCount(int pageIndex)
        {
            if (pageIndex > this.PageCount - 1 || pageIndex < 0)
            {
                return -1;
            }

            if (pageIndex == this.PageCount)
            {
                return this.ItemCount % this._itemsPerPage == 0 ? this._itemsPerPage : this.ItemCount % this._itemsPerPage;
            }
            return this._itemsPerPage;
        }

        /// <summary>
        /// Returns the page index of the page containing the item at the given item index.
        /// </summary>
        /// <param name="itemIndex">The zero-based index of the item to get the pageIndex for</param>
        /// <returns>The zero-based page index of the page containing the item at the given item index or -1 if the item index is out of range</returns>
        public int PageIndex(int itemIndex)
        {
            if (itemIndex > this.ItemCount - 1 || itemIndex < 0)
            {
                return -1;
            }

            int curretPage = 0;

            for (int i = 0; i < this.ItemCount; i += this._itemsPerPage)
            {
                if (itemIndex >= i && itemIndex < i + this._itemsPerPage)
                {
                    break;
                }
                curretPage++;
            }

            return curretPage;
        }
    }
}
