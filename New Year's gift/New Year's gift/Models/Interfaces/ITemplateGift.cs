namespace New_Year_s_gift
{
    public interface ITemplateGift
    {
        public Weight TotalWeight();
        public void AddItem(Sweetness sweetness);
        public void RemoveItem(Sweetness sweetness);
        void ShowGift();
        void ShowItem();
        void Sort();
    }
}
