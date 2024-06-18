namespace RadzenSkeleton.Components.Models
{
    public class ValueModel
    {
        public int No { get; set; }
        public string Value { get; set; }

        public ValueModel(int no)
        {
            No = no;
        }
        public void Copy(ValueModel model)
        {
            No = model.No;
            Value = model.Value;
        }
        public ValueModel Clone()
        {
            var other = new ValueModel(No);
            other.Copy(this);
            return other;
        }
    }
}
